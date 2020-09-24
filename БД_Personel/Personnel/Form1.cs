using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Personnel
{
    public partial class Form1 : Form
    {
        public static OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Pers.mdb;Persist Security Info=True");
        public Form1()
        {
            InitializeComponent();

            ConnectSQL();
        }
        public void ConnectSQL() //SQL Server
        {
            if (connect.State == ConnectionState.Closed)
                connect.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personnel personnel = new Personnel(connect);
            personnel.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            connect.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Shedule shedule = new Shedule(connect);
            shedule.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BE_Personnel _Personnel = new BE_Personnel(connect);
            _Personnel.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Курсовой проект по предмету Базы Данных.\nТема проекта: КАДРЫ" +
                "\n\nПрограмма создана для работы с БД\nстудентами ЗИЭ-17 👽\n\n" +
                "Соломянюк Андрей, Богданов Виталий\nСенкус Сабина, Лихачёва Валерия");
        }

        private void statistic_Click(object sender, EventArgs e)
        {
            Statistic statistic = new Statistic(connect);
            statistic.Show();
        }

        private void help_Click(object sender, EventArgs e)
        {
            Helper helper = new Helper(connect);
            helper.Show();
        }
    }
}
