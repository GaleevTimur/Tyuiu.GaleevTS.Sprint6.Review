using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GaleevTS.Sprint6.TaskReview.V15.Lib;

namespace Tyuiu.GaleevTS.Sprint6.TaskReview.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonFAQ_GTS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_GTS_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBoxRows_GTS.Text);
                int m = Convert.ToInt32(textBoxColumns_GTS.Text);
                int n1 = Convert.ToInt32(textBoxStartNumber_GTS.Text);
                int n2 = Convert.ToInt32(textBoxEndNumber_GTS.Text);
                int k = Convert.ToInt32(textBoxStartElement_GTS.Text);
                int l = Convert.ToInt32(textBoxEndElement_GTS.Text);
                int c = Convert.ToInt32(textBoxColumnSelect_GTS.Text);


                if ((n1 < n2) && (n > 1) && (m > 1))
                {
                    int[,] matrix = ds.GetMatrix(n, m, n1, n2);
                    int rows = matrix.GetUpperBound(0) + 1;
                    int columns = matrix.Length / rows;
                    dataGridView_GTS.ColumnCount = columns;
                    dataGridView_GTS.RowCount = rows;

                    for (int i = 0; i < columns; i++)
                    {
                        dataGridView_GTS.Columns[i].Width = 50;
                    }
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            dataGridView_GTS.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                        }
                    }

                    if ((n1 < n2) && (n > 1) && (m > 1) && (k < l) && (c < m))
                    {
                        textBox_Result.Text = Convert.ToString(ds.GetMult(matrix, c, k, l));
                    }
                }

                else
                {
                    MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }   
    }
}
