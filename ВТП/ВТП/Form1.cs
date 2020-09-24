using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ВТП
{
    public partial class Form1 : Form
    {
        int columns = 0;
        int rows = 0;
        int rand;
        int for_window = 0;

        public Form1()
        {
            InitializeComponent();
        }

        void DGW()
        {
            int i = 0;
            int j = 0;
            if (rows != 0 && columns != 0)
            {
                dataGridView1.ColumnCount = columns; // Столбцы
                dataGridView1.RowCount = rows; // Строки
                for (i = 0; i < columns; i++)
                {
                    for (j = 0; j < rows; j++)
                    {
                        Random_dgw();
                        dataGridView1[i, j].Value = rand;
                        dataGridView1.Columns[i].Width = 40;
                    }
                }
            }
            else
            { return; }

            int data_to_dgw = 0;// int data_to_dgw = -1;
            dataGridView1.Rows.Add();
            for (i = 0; i < columns; i++)
            {
                if (dataGridView1[i, j - 1].Value != null)
                {
                    for (j = 0; j < rows; j++)
                    {
                        int data = (int)dataGridView1[i, j].Value;
                        if (data >=0) // if (data > data_to_dgw)
                            data_to_dgw++; //data_to_dgw = data;
                        if (for_window < data_to_dgw)
                            for_window = data_to_dgw; // for_window = data;
                    }
                    
                }
                
                if (data_to_dgw != -1)
                {
                    dataGridView1[i, j].Value = data_to_dgw;
                    data_to_dgw = 0;
                }
            }
        }

        void Random_dgw()
        {
            Thread.Sleep(20);
            Random randoms = new Random();
            rand = randoms.Next(-100, 100);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for_window = 0;
            rows = Convert.ToInt32(listBox1.SelectedItem);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for_window = 0;
            columns = Convert.ToInt32(comboBox1.SelectedItem);

        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if ((int)dataGridView1[i, rows].Value == for_window) //[i, j]
                    {
                        dataGridView1.Columns[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            for (int i = 0; i < columns; i++)
                dataGridView1.Columns[i].DefaultCellStyle.BackColor = Color.White;
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            for_window = 0;
            rows = Convert.ToInt32(listBox1.SelectedItem);
            columns = Convert.ToInt32(comboBox1.SelectedItem);
            DGW();
        }
    }
}
