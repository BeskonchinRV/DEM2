using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoEx
{
    public partial class MainForm : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSqlLocalDb;Initial Catalog=RepairBD;Integrated Security=True;";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairBDDataSet.Requests". При необходимости она может быть перемещена или удалена.
            this.requestsTableAdapter.Fill(this.repairBDDataSet.Requests);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void LoadRequestsData()
        {
            string query = BuildRequestsQuery();
            ExecuteQuery(query);
        }

        // Строим SQL запрос с фильтрами и сортировкой
        private string BuildRequestsQuery()
        {
            string searchTerm = textBoxSearch.Text.Trim();
            string sortOrder = GetSortOrder();

            string query = "SELECT requestID, startDate, orgTechID, problemDescription, statusID, completionDate, partID, masterID, clientID FROM Requests WHERE 1 = 1";

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query += " AND problemDescription LIKE @SearchTerm";
            }

            if (!string.IsNullOrEmpty(sortOrder))
            {
                query += " ORDER BY startDate " + sortOrder;
            }

            return query;
        }

        // Выполняем SQL-запрос и выводим данные в DataGridView
        private void ExecuteQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SearchTerm", "%" + textBoxSearch.Text.Trim() + "%");

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
                }
            }
        }

        private string GetSortOrder()
        {
            if (radioButtonAZ.Checked)
            {
                return "ASC";
            }
            else if (radioButtonZA.Checked)
            {
                return "DESC";
            }

            return string.Empty;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadRequestsData();
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRequestsData();
        }

        private void radioButtonAZ_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAZ.Checked)
            {
                LoadRequestsData();
            }
        }

        private void radioButtonZA_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonZA.Checked)
            {
                LoadRequestsData();
            }
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                // После добавления обновляем данные
                LoadRequestsData();
            }
        }

        private void buttonEditRequest_Click(object sender, EventArgs e)
        {
            // Проверяем, выбрана ли строка
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для редактирования.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Получаем данные выбранной строки
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            int id = Convert.ToInt32(selectedRow.Cells[0].Value);
            DateTime startDate = Convert.ToDateTime(selectedRow.Cells[1].Value);
            int orgTechId = Convert.ToInt32(selectedRow.Cells[2].Value);
            string problemDescription = selectedRow.Cells[3].Value.ToString();
            int statusId = Convert.ToInt32(selectedRow.Cells[4].Value);
            DateTime? completionDate = selectedRow.Cells[5].Value == DBNull.Value
                ? (DateTime?)null
                : Convert.ToDateTime(selectedRow.Cells[5].Value);
            int partId = Convert.ToInt32(selectedRow.Cells[6].Value);
            int masterId = Convert.ToInt32(selectedRow.Cells[7].Value);
            int clientId = Convert.ToInt32(selectedRow.Cells[8].Value);

            // Открываем форму для редактирования данных
            EditForm editForm = new EditForm(id, startDate, orgTechId, problemDescription, statusId, completionDate, partId, masterId, clientId);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                // После редактирования обновляем данные
                LoadRequestsData();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для удаления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            int requestID = Convert.ToInt32(selectedRow.Cells[0].Value);

            DialogResult dialogResult = MessageBox.Show($"Вы уверены, что хотите удалить запрос с ID {requestID}?",
                                                         "Подтверждение удаления",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                string query = "DELETE FROM Requests WHERE requestID = @RequestID";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@RequestID", requestID);
                            command.ExecuteNonQuery();
                        }
                    }

                    LoadRequestsData();
                    MessageBox.Show("Запрос успешно удалён.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
