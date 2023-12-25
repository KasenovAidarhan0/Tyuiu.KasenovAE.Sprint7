using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KasenovAE.Sprint7.Project.V6.Lib;

namespace Tyuiu.KasenovAE.Sprint7.Project.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            try
            {
                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowData()
        {
            if (DataService.DataIsValid(DataService.path))
            {
                try
                {
                    dataGridView_KAE.DataSource = DataService.GetData();
                    dataGridView_KAE.Columns[0].Width = 45;
                    dataGridView_KAE.Columns[4].Width = 60;

                    if (DataService.GetData().Rows.Count >= 1)
                    {
                        buttonDelete_KAE.Enabled = true;
                    }
                    else
                    {
                        buttonDelete_KAE.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Неподходящая таблица");
            }       
        }

        private void buttonAdd_KAE_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes =
            {
                textBoxFName_KAE,
                textBoxLName_KAE,
                textBoxMName_KAE,
                textBoxAge_KAE,
                textBoxDisease_KAE,
                textBoxDoctor_KAE,
                textBoxPhoneNumber_KAE
            };
            try
            {
                string[] arr = new string[8];

                if (String.IsNullOrEmpty(textBoxFName_KAE.Text) && String.IsNullOrEmpty(textBoxLName_KAE.Text) && String.IsNullOrEmpty(textBoxAge_KAE.Text))
                {
                    MessageBox.Show("Имя/Фамилия/Возраст должны иметь значения");
                }
                else if (String.IsNullOrEmpty(textBoxFName_KAE.Text) || String.IsNullOrEmpty(textBoxLName_KAE.Text) || String.IsNullOrEmpty(textBoxAge_KAE.Text))
                {
                    MessageBox.Show("Имя/Фамилия/Возраст должны иметь значения");
                }
                else if (!IsNumber(textBoxAge_KAE) || !IsNumber(textBoxPhoneNumber_KAE))
                {
                    MessageBox.Show("Возраст и номер телефона должны быть записаны в виде цифр");
                }
                else
                {
                    int counter = 1;
                    foreach (var textBox in textBoxes)
                    {
                        arr[counter] = textBox.Text;
                        textBox.Clear();
                        counter++;
                    }

                    bool res = DataService.AddData(arr);
                    if (res == false)
                        MessageBox.Show("Не соблюдается уникальность значений!");

                    ShowData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                     
        }

        private void buttonDelete_KAE_Click(object sender, EventArgs e)
        {
            try
            {
                string id = Convert.ToString(dataGridView_KAE.CurrentRow.Cells["id"].Value);
                DataService.DeleteData(id);
                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_KAE_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxInfo_KAE.Text = Convert.ToString(dataGridView_KAE[e.ColumnIndex, e.RowIndex].Value);
        }

        private bool IsNumber(TextBox textbox)
        {
            Int64 n;
            if (Int64.TryParse(textbox.Text, out n))
                return true;
            else if (string.IsNullOrEmpty(textbox.Text))
                return true;


            return false;
        }

        private void buttonChangePath_KAE_Click(object sender, EventArgs e)
        {
            openFileDialog_KAE.ShowDialog();

            if (DataService.DataIsValid(openFileDialog_KAE.FileName))
            {
                DataService.path = openFileDialog_KAE.FileName;
            }
            else
            {
                MessageBox.Show("Неподходящая таблица");
            }           
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxFilter_KAE.Text) && dataGridView_KAE.Rows.Count >= 1)
            {
                try
                {
                    string word = textBoxFilter_KAE.Text;
                    int columnIndex = dataGridView_KAE.CurrentCell.ColumnIndex;
                    dataGridView_KAE.CurrentCell = null;

                    for (int i = 0; i < dataGridView_KAE.Rows.Count; i++)
                    {
                        dataGridView_KAE.Rows[i].Visible = dataGridView_KAE[columnIndex, i].Value.ToString() == word;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }          
        }

        private void buttonReturnDefault_KAE_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void buttonChange_KAE_Click(object sender, EventArgs e)
        {          
            try
            {
                TextBox[] textBoxes =
                {
                    textBoxFName_KAE,
                    textBoxLName_KAE,
                    textBoxMName_KAE,
                    textBoxAge_KAE,
                    textBoxDisease_KAE,
                    textBoxDoctor_KAE,
                    textBoxPhoneNumber_KAE
                };

                string[] textBoxesText =
                {
                    textBoxFName_KAE.Text,
                    textBoxLName_KAE.Text,
                    textBoxMName_KAE.Text,
                    textBoxAge_KAE.Text,
                    textBoxDisease_KAE.Text,
                    textBoxDoctor_KAE.Text,
                    textBoxPhoneNumber_KAE.Text
                };

                string rowId = dataGridView_KAE.CurrentRow.Cells[0].Value.ToString();

                DataService.ChangeData(rowId, textBoxesText);

                foreach (TextBox tb in textBoxes)
                {
                    tb.Clear();
                }

                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFrequency_KAE_Click(object sender, EventArgs e)
        {
            try
            {
                FormStatistic form = new FormStatistic();
                form.Show();
                if (dataGridView_KAE.Rows.Count >= 1)
                {
                    string columnName = dataGridView_KAE.Columns[dataGridView_KAE.CurrentCell.ColumnIndex].Name;
                    form.ShowChart(columnName);
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
