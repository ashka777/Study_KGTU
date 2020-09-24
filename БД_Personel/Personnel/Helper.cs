using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Personnel
{
    public partial class Helper : Form
    {
        public OleDbConnection connect;
        public OleDbDataAdapter da;
        int page_Y = 0;
        private Font font = new Font("Times New Roman", 12);
        private Font fontBold = new Font("Times New Roman", 12, FontStyle.Bold);
        private Font fontUn = new Font("Times New Roman", 12, FontStyle.Underline);
        private Font font1 = new Font("Times New Roman", 8);
        private string Occupat;
        private string dateBegin;
        private string depart;
        private string salary;
        private string adress;

        public Helper(OleDbConnection connection)
        {
            InitializeComponent();
            connect = connection;
        }

        private void Helper_Load(object sender, EventArgs e)
        {
            string command = string.Format("SELECT * from Personnel");
            OleDbCommand selectcom = new OleDbCommand(command, connect);
            DataTable dataTable = new DataTable();
            da = new OleDbDataAdapter(selectcom);
            da.Fill(dataTable);

            comboBox1.DataSource = dataTable;
            comboBox1.DisplayMember = "LName";
            comboBox1.ValueMember = "Id";
            comboBox1.SelectedIndex = -1;
        }

        private void Selected()
        {
            string command = string.Format("SELECT Per.*, Occ.NameOcc, Occ.Salary, Dep.NameDep " +
                "from Personnel Per, Occupation Occ, Department Dep " +
                "where Per.IdDepart=Dep.Id and Per.IdOccup=Occ.Id and Per.Id={0} and Per.DateEnd is Null", comboBox1.SelectedValue);
            OleDbCommand selectcom = new OleDbCommand(command, connect);
            DataTable dataTable = new DataTable();
            da = new OleDbDataAdapter(selectcom);
            da.Fill(dataTable);

            tabelTB.Text = dataTable.Rows[0]["Id"].ToString();
            Fname.Text = dataTable.Rows[0]["FName"].ToString();
            Pname.Text = dataTable.Rows[0]["PName"].ToString();
            depart = dataTable.Rows[0]["NameDep"].ToString();
            Occupat = dataTable.Rows[0]["NameOcc"].ToString();
            dateBegin = Convert.ToDateTime(dataTable.Rows[0]["DateBegin"]).ToString("dd.MM.yyyy");
            salary = dataTable.Rows[0]["Salary"].ToString();
            adress = dataTable.Rows[0]["Adress"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Сотрудник не выбран.");
                return;
            }
            try
            {
                {
                    printPreviewDialog1.Document = printDocument1;
                    printDialog1.Document = printDocument1;
                    printPreviewDialog1.DesktopBounds = Screen.PrimaryScreen.Bounds;
                    DialogResult result_print = printDialog1.ShowDialog();
                    if (result_print == DialogResult.OK)
                    {
                        printPreviewDialog1.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Сотрудник не выбран.");
                return;
            }
            try
            {
                {
                    printPreviewDialog1.Document = printDocument2;
                    printDialog1.Document = printDocument2;
                    printPreviewDialog1.DesktopBounds = Screen.PrimaryScreen.Bounds;
                    DialogResult result_print = printDialog1.ShowDialog();
                    if (result_print == DialogResult.OK)
                    {
                        printPreviewDialog1.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text=="")
            {
                MessageBox.Show("Сотрудник не выбран.");
                return;
            }
            try
            {
                {
                    printPreviewDialog1.Document = printDocument3;
                    printDialog1.Document = printDocument3;
                    printPreviewDialog1.DesktopBounds = Screen.PrimaryScreen.Bounds;
                    DialogResult result_print = printDialog1.ShowDialog();
                    if (result_print == DialogResult.OK)
                    {
                        printPreviewDialog1.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Selected();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics page = e.Graphics;
            int oneLineHeight = font.Height;

            page_Y = oneLineHeight * 2;
            page.DrawString(" ООО “ Рога и Копыта” ", font, Brushes.Black, 600, page_Y);
            page.DrawString("  Тел. +7 931 605 59 03", font, Brushes.Black, 600, page_Y+26);

            page_Y = oneLineHeight * 5;
            page.DrawString("г. Калининград, ул. Выдуманная, д. 1", font, Brushes.Black, 500, page_Y);

            page_Y = oneLineHeight * 9;
            page.DrawString("              СПРАВКА ", font, Brushes.Black, 300, page_Y);
            page.DrawString("от  "+ DateTime.Now.Date.ToString("dd.MM.yyyy") + "  №________", font, Brushes.Black, 300, page_Y+36);

            page_Y = oneLineHeight * 15;
            page.DrawString("Выдана сотруднику  "+ comboBox1.Text +" "+Fname.Text+" "+Pname.Text + ", в подтверждение того, что он с "+ dateBegin, font, Brushes.Black, 50, page_Y);
            page.DrawString("по настоящее время работает в ООО “Рога и Копыта” на должности "+ Occupat +".", font, Brushes.Black, 50, page_Y + 36);
            page.DrawString("Ежемесячный должностной оклад сотрудника  "+ comboBox1.Text + " составляет "+salary+" руб. 00 коп.", font, Brushes.Black, 50, page_Y + 72);
            page.DrawString("Настоящая справка подлежит предъявлению по месту требования.", font, Brushes.Black, 50, page_Y + 110);

            page_Y = oneLineHeight * 30;
            page.DrawString("Руководитель организации _____________ _________________/ ______________________", fontBold, Brushes.Black, 100, page_Y);
            page.DrawString("(должность)                                            (подпись)                                                  (расшифровка)", font1, Brushes.Black, 330, page_Y + 26);

        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics page = e.Graphics;
            int oneLineHeight = font.Height;

            page_Y = oneLineHeight * 2;
            page.DrawString(" ООО “ Рога и Копыта” ", font, Brushes.Black, 600, page_Y);
            page.DrawString("  Тел. +7 931 605 59 03", font, Brushes.Black, 600, page_Y + 26);

            page_Y = oneLineHeight * 5;
            page.DrawString("г. Калининград, ул. Выдуманная, д. 1", font, Brushes.Black, 500, page_Y);

            page_Y = oneLineHeight * 9;
            page.DrawString("              СПРАВКА ", font, Brushes.Black, 300, page_Y);
            page.DrawString("от  " + DateTime.Now.Date.ToString("dd.MM.yyyy") + "  №________", font, Brushes.Black, 300, page_Y + 36);

            page_Y = oneLineHeight * 15;
            page.DrawString("Выдана сотруднику:  " + comboBox1.Text + " " + Fname.Text + " " + Pname.Text+"                                          ,", fontUn, Brushes.Black, 100, page_Y);

            page_Y = oneLineHeight * 17;
            page.DrawString("Работающему(ей):  в  ООО “ Рога и Копыта”                                                         ,", fontUn, Brushes.Black, 100, page_Y);

            page_Y = oneLineHeight * 20;
            page.DrawString("предоставляющая данные об установленном должностном окладе, ежегодной премии", font, Brushes.Black, 100, page_Y);
            page.DrawString("и процентной надбавке по состоянию на  " + DateTime.Now.Date.ToString("dd.MM.yyyy"), font, Brushes.Black, 100, page_Y+25);
            page.DrawString("1. Должностной оклад  " + salary+" руб.  00  коп. в месяц", font, Brushes.Black, 100, page_Y+50);
            page.DrawString("2. Ежегодная премия по итогам работы ___________руб. _____коп.", font, Brushes.Black, 100, page_Y+75);
            page.DrawString("3. Процентная надбавка ________% ", font, Brushes.Black, 100, page_Y + 100);

            page_Y = oneLineHeight * 30;
            page.DrawString("Справка выдана на основании: ________________________________________", font, Brushes.Black, 100, page_Y);

            page_Y = oneLineHeight * 35;
            page.DrawString("Начальнак отдела кадров ______________ _________________/ ____________________", fontBold, Brushes.Black, 100, page_Y);
            page.DrawString("(должность)                                          (подпись)                                            (расшифровка)", font1, Brushes.Black, 330, page_Y + 26);

            page_Y = oneLineHeight * 39;
            page.DrawString("Руководитель организации _____________ _________________/ ____________________", fontBold, Brushes.Black, 100, page_Y);
            page.DrawString("(должность)                                          (подпись)                                            (расшифровка)", font1, Brushes.Black, 330, page_Y + 26);
        }

        private void printDocument3_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics page = e.Graphics;
            int oneLineHeight = font.Height;

            page_Y = oneLineHeight * 2;
            page.DrawString(" ООО “ Рога и Копыта” ", font, Brushes.Black, 600, page_Y);
            page.DrawString("  Тел. +7 931 605 59 03", font, Brushes.Black, 600, page_Y + 26);

            page_Y = oneLineHeight * 5;
            page.DrawString("г. Калининград, ул. Выдуманная, д. 1", font, Brushes.Black, 500, page_Y);

            page_Y = oneLineHeight * 9;
            page.DrawString("              СПРАВКА ", font, Brushes.Black, 300, page_Y);
            page.DrawString("от  " + DateTime.Now.Date.ToString("dd.MM.yyyy") + "  №________", font, Brushes.Black, 300, page_Y + 36);

            page_Y = oneLineHeight * 15;
            page.DrawString("Выдана сотруднику:  " + comboBox1.Text + " " + Fname.Text + " " + Pname.Text + ",", font, Brushes.Black, 100, page_Y);

            page_Y = oneLineHeight * 17;
            page.DrawString("Работающему(ей): в  ООО “ Рога и Копыта”  в должности: " + Occupat +",", font, Brushes.Black, 100, page_Y);

            page_Y = oneLineHeight * 19;
            page.DrawString("в том, что он(она) действительно обеспечивает функционирование указанной организации ", font, Brushes.Black, 100, page_Y);
            page.DrawString("в период действия ограничительных мер по предупреждению распростраения новой", font, Brushes.Black, 100, page_Y+25);
            page.DrawString("коронавирусной инфекции (2019-nCoV) в соответствии с Приказом № 27/3 от 27.03.2020", font, Brushes.Black, 100, page_Y+50);
            page.DrawString("Трудовую деятельность осуществляет по адресу: г. Калининград, ул. Выдуманная, д. 1", fontUn, Brushes.Black, 100, page_Y + 100);
            page.DrawString("Адрес проживания (прописки) работника:  "+ adress, fontUn, Brushes.Black, 100, page_Y + 140);
            page.DrawString("Справка выдана: " + DateTime.Now.Date.ToString("dd.MM.yyyy") + " г.              Действует до _______________г.", font, Brushes.Black, 100, page_Y + 190);
            page.DrawString("Руководитель организации _____________ _________________/ ____________________", fontBold, Brushes.Black, 100, page_Y+250);
            page.DrawString("(должность)                                          (подпись)                                            (расшифровка)", font1, Brushes.Black, 330, page_Y + 270);


        }
    }
}
