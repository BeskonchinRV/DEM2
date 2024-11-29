using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DemoEx
{
    public partial class EditForm : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSqlLocalDb;Initial Catalog=RepairBD;Integrated Security=True;";
        private int requestId;
        public EditForm()
        {
            InitializeComponent();
            LoadStatusOptions();
            LoadMasters();
            LoadClients();
            LoadParts();
            LoadOrgTech();
        }

        public EditForm(int id, DateTime startDate, int orgTechId, string problemDescription, int statusId, DateTime? completionDate, int partId, int masterId, int clientId) : this()
        {
            requestId = id; // Сохраняем ID для редактирования
            dateTimePickerStartDate.Value = startDate;
            comboBoxOrgTech.SelectedValue = orgTechId;
            textBoxProblemDescription.Text = problemDescription;
            comboBoxStatus.SelectedValue = statusId;
            if (completionDate.HasValue)
            {
                dateTimePickerCompletionDate.Value = completionDate.Value;
            }
            comboBoxPart.SelectedValue = partId;
            comboBoxMaster.SelectedValue = masterId;
            comboBoxClient.SelectedValue = clientId;
        }

        private void LoadStatusOptions()
        {
            // Загружаем статусы из базы данных
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT statusID, statusName FROM Statuses";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                comboBoxStatus.DataSource = dataTable;
                comboBoxStatus.DisplayMember = "statusName";
                comboBoxStatus.ValueMember = "statusID";
            }
        }

        private void LoadMasters()
        {
            // Загружаем список мастеров
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT userID, firstname FROM Users";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                comboBoxMaster.DataSource = dataTable;
                comboBoxMaster.DisplayMember = "firstname";
                comboBoxMaster.ValueMember = "userID";
            }
        }

        private void LoadClients()
        {
            // Загружаем список клиентов
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT userID, firstname FROM Users";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                comboBoxClient.DataSource = dataTable;
                comboBoxClient.DisplayMember = "firstname";
                comboBoxClient.ValueMember = "userID";
            }
        }

        private void LoadParts()
        {
            // Загружаем список запчастей
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT partID, name FROM RepairParts";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                comboBoxPart.DataSource = dataTable;
                comboBoxPart.DisplayMember = "name";
                comboBoxPart.ValueMember = "partID";
            }
        }
        private void LoadOrgTech()
        {
            // Загружаем список техники
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT orgTechID, orgTechType FROM OrgTech";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                comboBoxOrgTech.DataSource = dataTable;
                comboBoxOrgTech.DisplayMember = "orgTechType";
                comboBoxOrgTech.ValueMember = "orgTechID";
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxProblemDescription.Text) || comboBoxStatus.SelectedValue == null || comboBoxMaster.SelectedValue == null || comboBoxClient.SelectedValue == null)
            {
                MessageBox.Show("Заполните все обязательные поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    if (requestId == 0)  // Новый запрос
                    {
                        // Получаем последний requestID
                        string queryLastId = "SELECT MAX(requestID) FROM Requests";
                        SqlCommand commandLastId = new SqlCommand(queryLastId, connection);
                        object lastId = commandLastId.ExecuteScalar();

                        // Если в базе данных нет записей, начинаем с 1
                        int newRequestID = lastId != DBNull.Value ? Convert.ToInt32(lastId) + 1 : 1;

                        string query = @"
                INSERT INTO Requests (requestID, startDate, orgTechID, problemDescription, statusID, completionDate, partID, masterID, clientID) 
                VALUES (@RequestID, @StartDate, @OrgTechID, @ProblemDescription, @StatusID, @CompletionDate, @PartID, @MasterID, @ClientID)";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@RequestID", newRequestID); // Используем новый ID
                        command.Parameters.AddWithValue("@StartDate", dateTimePickerStartDate.Value);
                        command.Parameters.AddWithValue("@OrgTechID", comboBoxOrgTech.SelectedValue);
                        command.Parameters.AddWithValue("@ProblemDescription", textBoxProblemDescription.Text.Trim());
                        command.Parameters.AddWithValue("@StatusID", comboBoxStatus.SelectedValue);
                        command.Parameters.AddWithValue("@CompletionDate", (object)dateTimePickerCompletionDate.Value ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PartID", comboBoxPart.SelectedValue);
                        command.Parameters.AddWithValue("@MasterID", comboBoxMaster.SelectedValue);
                        command.Parameters.AddWithValue("@ClientID", comboBoxClient.SelectedValue);
                        command.ExecuteNonQuery();
                    }
                    else  // Редактирование запроса
                    {
                        string query = @"
                UPDATE Requests SET startDate = @StartDate, orgTechID = @OrgTechID, problemDescription = @ProblemDescription, statusID = @StatusID, 
                completionDate = @CompletionDate, partID = @PartID, masterID = @MasterID, clientID = @ClientID
                WHERE requestID = @RequestID";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@RequestID", requestId);
                        command.Parameters.AddWithValue("@StartDate", dateTimePickerStartDate.Value);
                        command.Parameters.AddWithValue("@OrgTechID", comboBoxOrgTech.SelectedValue);
                        command.Parameters.AddWithValue("@ProblemDescription", textBoxProblemDescription.Text.Trim());
                        command.Parameters.AddWithValue("@StatusID", comboBoxStatus.SelectedValue);
                        command.Parameters.AddWithValue("@CompletionDate", (object)dateTimePickerCompletionDate.Value ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PartID", comboBoxPart.SelectedValue);
                        command.Parameters.AddWithValue("@MasterID", comboBoxMaster.SelectedValue);
                        command.Parameters.AddWithValue("@ClientID", comboBoxClient.SelectedValue);
                        command.ExecuteNonQuery();
                    }
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            // Закрываем форму при нажатии на кнопку "Отмена"
            Close();
        }

    }
}
