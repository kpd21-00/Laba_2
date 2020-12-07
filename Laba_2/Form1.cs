using Matr_Lab;
using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Laba_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _cbOper.SelectedIndex = 0;
            _dgvMatr1.RowCount = 5;
            _dgvMatr1.ColumnCount = 5;
            _dgvMatr2.RowCount = 5;
            _dgvMatr2.ColumnCount = 5;
            _dgvMatr.RowCount = 5;
            _dgvMatr.ColumnCount = 5;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    _dgvMatr.Rows[j].Cells[i].Value = 0;
                    _dgvMatr1.Rows[j].Cells[i].Value = 0;
                    _dgvMatr2.Rows[j].Cells[i].Value = 0;
                }
        }

        private void _bCreateMatr_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(_tbMatr.Text);
            _dgvMatr1.RowCount = n;
            _dgvMatr1.ColumnCount = n;
            _dgvMatr2.RowCount = n;
            _dgvMatr2.ColumnCount = n;
            _dgvMatr.RowCount = n;
            _dgvMatr.ColumnCount = n;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    _dgvMatr.Rows[j].Cells[i].Value = 0;
                    _dgvMatr1.Rows[j].Cells[i].Value = 0;
                    _dgvMatr2.Rows[j].Cells[i].Value = 0;
                }
            _bMatrRand.Enabled = true;
            _bMatr.Enabled = true;
        }

        private void _bMatrRand_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(_tbMatr.Text);
            Matr_lab<int> matr1 = new Matr_lab<int>(n);
            Matr_lab<int> matr2 = new Matr_lab<int>(n);
            Random rand = new Random();
            matr1.Rand((x, y) => (x * y + 125)*rand.Next(-50,50));
            matr2.Rand((x, y) => (x * y + 125) + rand.Next(-50, 50));
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    _dgvMatr1.Rows[i].Cells[j].Value = matr1[i,j];
                    _dgvMatr2.Rows[i].Cells[j].Value = matr2[i, j];
                }
        }

        private void _bMatr_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(_tbMatr.Text);
            Matr_lab<int> matr1 = new Matr_lab<int>(n);
            Matr_lab<int> matr2 = new Matr_lab<int>(n);
            Matr_lab<int> matr;
            Stopwatch time = new Stopwatch();
            TimeSpan timer;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    matr1[i, j] = Convert.ToInt32(_dgvMatr1.Rows[i].Cells[j].Value);
                    matr2[i, j] = Convert.ToInt32(_dgvMatr2.Rows[i].Cells[j].Value);
                }
            if (_cbOper.SelectedIndex == 1)
            {
                time.Restart();
                matr = matr1 * matr2;
                time.Stop();
                
            }
            else
            {
                time.Restart();
                matr = matr1 + matr2;
                time.Stop();
            }
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    _dgvMatr.Rows[i].Cells[j].Value = matr[i, j];
            timer = time.Elapsed;
            _tbTime.Text = Convert.ToString(timer.TotalMilliseconds);
        }

        private void _tbMatr_TextChanged(object sender, EventArgs e)
        {
            _bMatrRand.Enabled = false;
            _bMatr.Enabled = false;
        }

        private void _bSave_Click(object sender, EventArgs e)
        {
            string way = Directory.GetCurrentDirectory() + "\\Matrix_C.csv";
            StreamWriter sw = new StreamWriter(way);
            int n = Convert.ToInt32(_tbMatr.Text);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sw.Write(Convert.ToString(_dgvMatr.Rows[i].Cells[j].Value) + ";");
                }
                sw.WriteLine();
            }
            sw.Close();
            MessageBox.Show("Матрица сохранена по пути " + way);
        }
    }
}



//Stopwatch time = new Stopwatch();
//TimeSpan timer;
//time.Restart();
//time.Stop();
//_tbMatr.Text = Convert.ToString(time.Elapsed);
