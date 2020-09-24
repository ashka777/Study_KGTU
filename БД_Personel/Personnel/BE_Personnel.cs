using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Personnel
{
    public partial class BE_Personnel : Form
    {
        public OleDbConnection connect;
        public BE_Personnel(OleDbConnection connection)
        {
            InitializeComponent();
            connect = connection;
        }

        private void Personnel_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string change = string.Format("and Personnel.[Id]>{0} order by Personnel.[Id]", tabelTB.Text);
            Next(change);
        }

        DataTable dataTable = new DataTable();
        OleDbDataAdapter da = new OleDbDataAdapter();
        private void Next(string change)
        {
            try
            {
                string command = string.Format("SELECT Personnel.Id, Personnel.FName, Personnel.LName, Personnel.PName, Department.NameDep, Occupation.NameOcc, " +
                "Occupation.Salary, Personnel.DateBegin, Personnel.DateEnd, Personnel.Education, Personnel.NumberTel, Personnel.Adress, Personnel.BirthDate, " +
                "Personnel.Family, Personnel.Child, Schedule.NameShedule, Personnel.IdShedule, Schedule.TimeBegin, Schedule.TimeEnd " +
                "FROM((Personnel INNER JOIN Department ON Personnel.IdDepart = Department.Id) " +
                "INNER JOIN Occupation ON Personnel.IdOccup = Occupation.Id) INNER JOIN Schedule ON Personnel.IdShedule = Schedule.ID " +
                "WHERE Personnel.DateEnd is null and Personnel.Id is not null " + change);
                OleDbCommand selectcom = new OleDbCommand(command, connect);
                dataTable = new DataTable();
                da = new OleDbDataAdapter(selectcom);
                da.Fill(dataTable);

                try { tabelTB.Text = dataTable.Rows[0]["Id"].ToString(); }
                catch (IndexOutOfRangeException) { return; }
                Lname.Text = dataTable.Rows[0]["Lname"].ToString();
                Fname.Text = dataTable.Rows[0]["Fname"].ToString();
                try { Pname.Text = dataTable.Rows[0]["Pname"].ToString(); } catch { Pname.Text = ""; }
                try { department.Text = dataTable.Rows[0]["NameDep"].ToString(); } catch { department.Text = ""; }
                try { Occupat.Text = dataTable.Rows[0]["NameOcc"].ToString(); } catch { Occupat.Text = ""; }
                try { salary.Text = dataTable.Rows[0]["Salary"].ToString(); } catch { salary.Text = ""; }
                try { dateBegin.Text = Convert.ToDateTime(dataTable.Rows[0]["DateBegin"]).ToString("dd.MM.yyyy"); } catch { dateBegin.Text = ""; }
                try { dateEnd.Text = Convert.ToDateTime(dataTable.Rows[0]["DateEnd"]).ToString("dd.MM.yyyy"); } catch { dateEnd.Text = ""; }
                birthDate.Text = Convert.ToDateTime(dataTable.Rows[0]["BirthDate"]).ToString("dd.MM.yyyy");
                try { adress.Text = dataTable.Rows[0]["Adress"].ToString(); } catch { adress.Text = ""; }
                try { education.Text = dataTable.Rows[0]["Education"].ToString(); } catch { education.Text = ""; }
                try { numberTel.Text = dataTable.Rows[0]["NumberTel"].ToString(); } catch { numberTel.Text = ""; }
                try { family.Text = dataTable.Rows[0]["Family"].ToString(); } catch { family.Text = ""; }
                try { child.Text = dataTable.Rows[0]["Child"].ToString(); } catch { child.Text = ""; }
                beginShedule.Text = Convert.ToDateTime(dataTable.Rows[0]["TimeBegin"]).ToString("HH:mm");
                endShedule.Text = Convert.ToDateTime(dataTable.Rows[0]["TimeEnd"]).ToString("HH:mm");

                shedule.DataSource = dataTable;
                shedule.DisplayMember = "NameShedule";
                shedule.ValueMember = "IdShedule";

                da.SelectCommand = new OleDbCommand("SELECT distinct a.IdDepart, b.NameDep FROM [Personnel] a, Department b where a.IdDepart =b.id", connect);
                DataTable dt_dep = new DataTable("Department");
                da.Fill(dt_dep);
                combo_dep.DataSource = dt_dep;
                combo_dep.DisplayMember = "NameDep";
                combo_dep.ValueMember = "IdDepart";
                combo_dep.SelectedIndex = -1;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string change = string.Format("and Personnel.[Id]<{0} order by Personnel.[Id] desc", tabelTB.Text);
            Next(change);
        }

        private DataTable dtmaximum;
        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult save = MessageBox.Show("Добавить сотрудника?", "Сохранение данных", MessageBoxButtons.YesNo);
                if (save == DialogResult.Yes)
                {
                    if (Fname.Text == "" || Lname.Text == "" || Pname.Text == "" || combo_dep.SelectedIndex == -1 || comboOcc.SelectedIndex == -1 ||
                        shedule.Text == "" || adress.Text == "" || education.Text == "" || numberTel.Text == "" || family.Text == "" || child.Text == "")
                    { MessageBox.Show("Не все поля заполнены!"); return; }
                    string commandDel = string.Format("INSERT INTO [Personnel] " +
                        "(FName, LName, PName, IdDepart, IdOccup, DateBegin, IdShedule, " +
                        "BirthDate, Adress, Education, NumberTel, Family, Child) " +
                        "VALUES ('{0}', '{1}', '{2}', {3}, {4}, '{5}', {6}, '{7}', '{8}', '{9}', '{10}', '{11}', {12}) ",
                        Fname.Text, Lname.Text, Pname.Text, combo_dep.SelectedValue, comboOcc.SelectedValue, Convert.ToDateTime(beginPicker.Text).ToString("dd.MM.yyyy"),
                        shedule.SelectedValue,
                        Convert.ToDateTime(dateBirthNew.Text).ToString("dd.MM.yyyy"), adress.Text, education.Text, numberTel.Text, family.Text, child.Text);
                    OleDbCommand deletecom = new OleDbCommand(commandDel, connect);
                    deletecom.ExecuteNonQuery();

                    OleDbCommand maximum = new OleDbCommand("SELECT Max(Id) as Pers from Personnel", connect);
                    maximum.ExecuteNonQuery();
                    dtmaximum = new DataTable("Personnel");
                    da = new OleDbDataAdapter(maximum);
                    da.Fill(dtmaximum);

                    printPreviewDialog1.Document = printDocument1;
                    printDialog1.Document = printDocument1;
                    printPreviewDialog1.DesktopBounds = Screen.PrimaryScreen.Bounds;
                    DialogResult result_print = printDialog1.ShowDialog();
                    if (result_print == DialogResult.OK)
                    {
                        printPreviewDialog1.ShowDialog();
                    }
                    MessageBox.Show("Успешно добавлен!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void shedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string command2 = string.Format("SELECT * from Schedule where Id=@id");
                OleDbCommand selectcom2 = new OleDbCommand(command2, connect);
                selectcom2.Parameters.AddWithValue("@id", shedule.SelectedValue);
                DataTable sTable = new DataTable();
                da = new OleDbDataAdapter(selectcom2);
                da.Fill(sTable);

                beginShedule.Text = Convert.ToDateTime(sTable.Rows[0]["TimeBegin"]).ToString("HH:mm");
                endShedule.Text = Convert.ToDateTime(sTable.Rows[0]["TimeEnd"]).ToString("HH:mm");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void newWorker_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            NewWorker();
        }

        private void delWorker_Click(object sender, EventArgs e)
        {
            save.Visible = false;
            button3.Visible = true;
            panel1.Visible = false;
            combo_dep.Visible = false;
            comboOcc.Visible = false;
            string change = "and Personnel.[Id]>0 order by Personnel.[Id]";
            Next(change);
        }

        private void NewWorker()
        {
            Clear();
            button1.Visible = false;
            button2.Visible = false;
            transportOcc_bt.Visible = false;
            save.Visible = true;
            button3.Visible = false;
            Lname.ReadOnly = false;
            Fname.ReadOnly = false;
            Pname.ReadOnly = false;
            adress.ReadOnly = false;
            education.ReadOnly = false;
            numberTel.ReadOnly = false;
            family.ReadOnly = false;
            child.ReadOnly = false;
            department.Visible = false;
            Occupat.Visible = false;
            combo_dep.Visible = true;
            comboOcc.Visible = true;
            dateBegin.Hide(); beginPicker.Visible = true;
            birthDate.Hide(); dateBirthNew.Visible = true;
            shedule.Enabled = true;
            tabelTB.Hide();
            label1.Hide();

            string command = string.Format("SELECT * from Department");
            OleDbCommand selectcombo = new OleDbCommand(command, connect);
            DataTable comboTable = new DataTable();
            da = new OleDbDataAdapter(selectcombo);
            da.Fill(comboTable);
            combo_dep.DataSource = comboTable;
            combo_dep.DisplayMember = "NameDep";
            combo_dep.ValueMember = "Id";
            combo_dep.SelectedIndex = -1;

            string shedulecom = string.Format("SELECT * from Schedule");
            OleDbCommand selectshedule = new OleDbCommand(shedulecom, connect);
            DataTable sheduleTable = new DataTable();
            da = new OleDbDataAdapter(selectshedule);
            da.Fill(sheduleTable);
            shedule.DataSource = sheduleTable;
            shedule.DisplayMember = "NameShedule";
            shedule.ValueMember = "ID";
        }

        private void Clear()
        {
            tabelTB.Clear();//табел
            Lname.Clear();//фио
            Fname.Clear();
            Pname.Clear();
            department.Clear();//подраздел
            Occupat.Clear();//должность
            salary.Clear();//оклад
            dateBegin.Clear();
            dateEnd.Clear();
            adress.Clear();
            education.Clear();//образов
            numberTel.Clear();
            family.Clear();//сем полож
            child.Clear();
        }

        private void transportOcc_bt_Click(object sender, EventArgs e)
        {
            department.Visible = false;
            combo_dep.Visible = true;
            transportOcc_bt.Visible = false;
            Occupat.Visible = false;
            comboOcc.Visible = true;
            button4.Visible = true;
            dateBegin.Hide(); beginPicker.Visible = true;

            shedule.Enabled = true;
            string command2 = string.Format("SELECT * from Schedule");
            OleDbCommand selectcom2 = new OleDbCommand(command2, connect);
            DataTable dataTable = new DataTable();
            da = new OleDbDataAdapter(selectcom2);
            da.Fill(dataTable);
            shedule.DataSource = dataTable;
            shedule.DisplayMember = "NameShedule";
            shedule.ValueMember = "Id";
            shedule.SelectedIndex = -1;

            button3.Visible = false;
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e) //уволить сотрудника
        {
            try
            {
                DialogResult save = MessageBox.Show("Уволить сотрудника?", "Увольнение!", MessageBoxButtons.YesNo);
                if (save == DialogResult.Yes)
                {
                    transportOcc_bt.Visible = false;
                    printPreviewDialog1.Document = printDocument2;
                    printDialog1.Document = printDocument2;
                    printPreviewDialog1.DesktopBounds = Screen.PrimaryScreen.Bounds;
                    DialogResult result_print = printDialog1.ShowDialog();
                    if (result_print == DialogResult.OK)
                    {
                        printPreviewDialog1.ShowDialog();
                        transportOcc_bt.Visible = true;
                        string commandDel = string.Format("UPDATE [Personnel] " +
                        "SET DateEnd='{1}' where [Personnel].Id={0}", tabelTB.Text, DateTime.Now.Date.ToString("dd.MM.yyyy"));
                        OleDbCommand deletecom = new OleDbCommand(commandDel, connect);
                        deletecom.ExecuteNonQuery();
                        Clear();
                    }
                    string change = string.Format("and Personnel.[Id]>0 order by Personnel.[Id]");
                    Next(change);

                    MessageBox.Show("Cотрудник уволен!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void combo_dep_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string command = string.Format("SELECT * from [Occupation] where [IdDep]={0}", combo_dep.SelectedValue);
            OleDbCommand selectcom = new OleDbCommand(command, connect);
            DataTable comboTable2 = new DataTable("Occupation");
            da = new OleDbDataAdapter(selectcom);
            da.Fill(comboTable2);
            salary.Clear();
            comboOcc.DataSource = comboTable2;
            comboOcc.DisplayMember = "NameOcc";
            comboOcc.ValueMember = "Id";
            comboOcc.SelectedIndex = -1;
        }

        private void comboOcc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string command = string.Format("SELECT * from Occupation where Id={0}", comboOcc.SelectedValue);
            OleDbCommand selectcom = new OleDbCommand(command, connect);
            DataTable dataTable = new DataTable();
            da = new OleDbDataAdapter(selectcom);
            da.Fill(dataTable);
            salary.Text = dataTable.Rows[0]["Salary"].ToString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int page_Y = 0;
            Graphics page = e.Graphics;
            Font font = new Font("Times New Roman", 12);
            Font fontBold = new Font("Times New Roman", 12, FontStyle.Bold);
            Font fontUn = new Font("Times New Roman", 12, FontStyle.Underline);
            Font font1 = new Font("Times New Roman", 7);
            int oneLineHeight = font.Height;

            page_Y = oneLineHeight * 2;
            page.DrawString("Унифицированная форма № Т - 1 \nУтверждена Постановлением Госкомстата России \nот 05.01.2004 № 1", font, Brushes.Black, 400, page_Y);

            page_Y = oneLineHeight * 6;
            page.DrawString("Наименование организации:   ООО “ Рога и Копыта” ", fontUn, Brushes.Black, 100, page_Y);

            page_Y = oneLineHeight * 9;
            page.DrawString("              ПРИКАЗ \n         (распоряжение) \nо приеме работника на работу \n\n\nПринять на работу", font, Brushes.Black, 300, page_Y);

            page_Y = oneLineHeight * 16;
            page.DrawString("ФИО полностью: " + Lname.Text + " " + Fname.Text + " " + Pname.Text, font, Brushes.Black, 100, page_Y);
            page.DrawString("Таб. номер: " + dtmaximum.Rows[0]["Pers"].ToString(), fontBold, Brushes.Black, 650, page_Y);
            page.DrawString("_____________________________________________________________________________", font, Brushes.Black, 100, page_Y + 8);

            page_Y = oneLineHeight * 19;
            page.DrawString("Структурное подразделение: " + combo_dep.Text, font, Brushes.Black, 100, page_Y);
            page.DrawString("_____________________________________________________________________________", font, Brushes.Black, 100, page_Y + 8);

            page_Y = oneLineHeight * 22;
            page.DrawString("Должность (специальность, профессия): " + comboOcc.Text, font, Brushes.Black, 100, page_Y);
            page.DrawString("_____________________________________________________________________________", font, Brushes.Black, 100, page_Y + 8);

            page_Y = oneLineHeight * 25;
            page.DrawString("Условия приема на работу, характер работы:    постоянно / временно", font, Brushes.Black, 100, page_Y);
            page.DrawString("_____________________________________________________________________________", font, Brushes.Black, 100, page_Y + 8);

            page_Y = oneLineHeight * 30;
            page.DrawString("с тарифной ставкой (окладом):  " + salary.Text + "   руб.  00  коп.", font, Brushes.Black, 100, page_Y);

            page_Y = oneLineHeight * 33;
            page.DrawString("надбавкой:                руб.       коп.", font, Brushes.Black, 240, page_Y);

            page_Y = oneLineHeight * 38;
            page.DrawString("с испытанием на срок                                                                                    месяца", font, Brushes.Black, 100, page_Y);
            page.DrawString("_____________________________________________________________________________", font, Brushes.Black, 100, page_Y + 8);

            page_Y = oneLineHeight * 42;
            page.DrawString("Основание:", font, Brushes.Black, 100, page_Y);
            page.DrawString("Трудовой договор от " + beginPicker.Value.ToString("dd.MM.yyyy") + " г.  № _______________ ", font, Brushes.Black, 100, page_Y + 25);

            page_Y = oneLineHeight * 47;
            page.DrawString("Руководитель организации _____________ _________________/ ______________________", fontBold, Brushes.Black, 100, page_Y);
            page.DrawString("(должность)                                            (подпись)                                                  (расшифровка)", font1, Brushes.Black, 330, page_Y + 26);

            page_Y = oneLineHeight * 51;
            page.DrawString("С приказом (распоряжением) работник ознакомлен ____________“___”_________20___г.", fontBold, Brushes.Black, 100, page_Y);
            page.DrawString("(личная подпись)", font1, Brushes.Black, 500, page_Y + 26);
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) //уволить
        {
            int page_Y = 0;
            Graphics page = e.Graphics;
            Font font = new Font("Times New Roman", 12);
            Font fontBold = new Font("Times New Roman", 12, FontStyle.Bold);
            Font fontUn = new Font("Times New Roman", 12, FontStyle.Underline);
            Font font1 = new Font("Times New Roman", 8);
            int oneLineHeight = font.Height;

            page_Y = oneLineHeight * 2;
            page.DrawString("Унифицированная форма № Т-8 \nУтверждена Постановлением Госкомстата России \nот 05.01.04 № 1", font, Brushes.Black, 400, page_Y);

            page_Y = oneLineHeight * 6;
            page.DrawString("Наименование организации:   ООО “ Рога и Копыта” ", fontUn, Brushes.Black, 100, page_Y);

            page_Y = oneLineHeight * 9;
            page.DrawString("              ПРИКАЗ \n         (распоряжение) ", font, Brushes.Black, 300, page_Y);
            page.DrawString("о прекращении (расторжении) трудового договора с работником (увольнении)", font, Brushes.Black, 150, page_Y + 36);

            page_Y = oneLineHeight * 15;
            page.DrawString("Прекратить действие трудового договора от  “____”___________20____г.,  №__________,", fontBold, Brushes.Black, 100, page_Y);

            page_Y = oneLineHeight * 16;
            page.DrawString("уволить   “____”___________20____г.", fontBold, Brushes.Black, 380, page_Y);
            page.DrawString("(ненужное зачеркнуть)", font1, Brushes.Black, 600, page_Y + 36);

            page_Y = oneLineHeight * 26;
            page.DrawString("ФИО полностью: " + Lname.Text + " " + Fname.Text + " " + Pname.Text, font, Brushes.Black, 100, page_Y);
            page.DrawString("Таб. номер: " + tabelTB.Text, fontBold, Brushes.Black, 650, page_Y);
            page.DrawString("_____________________________________________________________________________", font, Brushes.Black, 100, page_Y + 8);

            page_Y = oneLineHeight * 29;
            page.DrawString("Структурное подразделение: " + department.Text, font, Brushes.Black, 100, page_Y);
            page.DrawString("_____________________________________________________________________________", font, Brushes.Black, 100, page_Y + 8);

            page_Y = oneLineHeight * 32;
            page.DrawString("Должность (специальность, профессия): " + Occupat.Text, font, Brushes.Black, 100, page_Y);
            page.DrawString("_____________________________________________________________________________", font, Brushes.Black, 100, page_Y + 8);

            page_Y = oneLineHeight * 38;
            page.DrawString("______________________________________________________________________________", font, Brushes.Black, 100, page_Y);
            page.DrawString("(основание прекращения (расторжения) трудового договора (увольнения))", font1, Brushes.Black, 100, page_Y + 26);

            page_Y = oneLineHeight * 42;
            page.DrawString("Основание:", font, Brushes.Black, 100, page_Y);
            page.DrawString("(заявление, номер, дата): ____________________________________________________ ", font, Brushes.Black, 100, page_Y + 25);

            page_Y = oneLineHeight * 47;
            page.DrawString("Руководитель организации _____________ _________________/ ______________________", fontBold, Brushes.Black, 100, page_Y);
            page.DrawString("(должность)                                            (подпись)                                                  (расшифровка)", font1, Brushes.Black, 330, page_Y + 26);

            page_Y = oneLineHeight * 51;
            page.DrawString("С приказом (распоряжением) работник ознакомлен ____________“___”_________20___г.", fontBold, Brushes.Black, 100, page_Y);
            page.DrawString("(личная подпись)", font1, Brushes.Black, 500, page_Y + 26);
        }

        private void printDocument3_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int page_Y = 0;
            Graphics page = e.Graphics;
            Font font = new Font("Times New Roman", 12);
            Font fontBold = new Font("Times New Roman", 12, FontStyle.Bold);
            Font fontUn = new Font("Times New Roman", 12, FontStyle.Underline);
            Font font1 = new Font("Times New Roman", 8);
            int oneLineHeight = font.Height;

            page_Y = oneLineHeight * 2;
            page.DrawString("Форма по ОКУД 0301004 \nпо ОКПО 69897441", font, Brushes.Black, 600, page_Y);

            page_Y = oneLineHeight * 6;
            page.DrawString("Наименование организации:   ООО “ Рога и Копыта” ", fontUn, Brushes.Black, 100, page_Y);

            page_Y = oneLineHeight * 9;
            page.DrawString("              ПРИКАЗ \n         (распоряжение) ", font, Brushes.Black, 300, page_Y);
            page.DrawString("о переводе работника на другую работу", font, Brushes.Black, 250, page_Y + 36);

            page_Y = oneLineHeight * 15;
            page.DrawString("Перевести на другую работу с " + beginPicker.Value.ToString("dd.MM.yyyy") + " по _________", font, Brushes.Black, 300, page_Y);

            page_Y = oneLineHeight * 19;
            page.DrawString("ФИО полностью: " + Lname.Text + " " + Fname.Text + " " + Pname.Text, font, Brushes.Black, 100, page_Y);
            page.DrawString("Таб. номер: " + tabelTB.Text, fontBold, Brushes.Black, 650, page_Y);
            page.DrawString("_____________________________________________________________________________", font, Brushes.Black, 100, page_Y + 8);

            page_Y = oneLineHeight * 22;
            page.DrawString("вид перевода (постоянно, временно): ", font, Brushes.Black, 100, page_Y);
            page.DrawString("_____________________________________________________________________________", font, Brushes.Black, 100, page_Y + 8);

            page_Y = oneLineHeight * 25;
            page.DrawString("прежнее место работы: ", fontBold, Brushes.Black, 100, page_Y);
            page_Y = oneLineHeight * 26;
            page.DrawString("Структурное подразделение: " + department.Text, font, Brushes.Black, 100, page_Y);
            page.DrawString("_____________________________________________________________________________", font, Brushes.Black, 100, page_Y + 8);

            page_Y = oneLineHeight * 29;
            page.DrawString("Должность (специальность, профессия): " + Occupat.Text, font, Brushes.Black, 100, page_Y);
            page.DrawString("_____________________________________________________________________________", font, Brushes.Black, 100, page_Y + 8);

            page_Y = oneLineHeight * 31;
            page.DrawString("______________________________________________________________________________", font, Brushes.Black, 100, page_Y);
            page.DrawString("(причина перевода)", font1, Brushes.Black, 100, page_Y + 26);

            page_Y = oneLineHeight * 35;
            page.DrawString("новое место работы: ", fontBold, Brushes.Black, 100, page_Y);
            page_Y = oneLineHeight * 36;
            page.DrawString("Структурное подразделение: " + combo_dep.Text, font, Brushes.Black, 100, page_Y);
            page.DrawString("_____________________________________________________________________________", font, Brushes.Black, 100, page_Y + 8);

            page_Y = oneLineHeight * 39;
            page.DrawString("Должность (специальность, профессия): " + comboOcc.Text, font, Brushes.Black, 100, page_Y);
            page.DrawString("_____________________________________________________________________________", font, Brushes.Black, 100, page_Y + 8);

            page_Y = oneLineHeight * 42;
            page.DrawString("тарифная ставка (оклад):  " + salary.Text + "   руб.  00  коп.", font, Brushes.Black, 300, page_Y);
            page_Y = oneLineHeight * 44;
            page.DrawString("надбавка:                руб.       коп.", font, Brushes.Black, 400, page_Y);

            page_Y = oneLineHeight * 45;
            page.DrawString("Основание:", font, Brushes.Black, 100, page_Y);
            page.DrawString("изменение к трудовому договору от " + dateBegin.Text + " г.  № ____________ ", font, Brushes.Black, 100, page_Y + 25);
            page_Y = oneLineHeight * 48;
            page.DrawString("или другой документ: ______________________________________________________", font, Brushes.Black, 100, page_Y);

            page_Y = oneLineHeight * 51;
            page.DrawString("Руководитель организации _____________ _________________/ ______________________", fontBold, Brushes.Black, 100, page_Y);
            page.DrawString("(должность)                                            (подпись)                                                  (расшифровка)", font1, Brushes.Black, 330, page_Y + 26);

            page_Y = oneLineHeight * 54;
            page.DrawString("С приказом (распоряжением) работник ознакомлен ____________“___”_________20___г.", fontBold, Brushes.Black, 100, page_Y);
            page.DrawString("(личная подпись)", font1, Brushes.Black, 500, page_Y + 26);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (combo_dep.Text == "" || comboOcc.Text == "" || shedule.Text == "")
                {
                    MessageBox.Show("Не все поля заполнены!");
                    return;
                }

                DialogResult save = MessageBox.Show("Перевести сотрудника?", "Смена должности!", MessageBoxButtons.YesNo);
                if (save == DialogResult.Yes)
                {
                    printPreviewDialog1.Document = printDocument3;
                    printDialog1.Document = printDocument3;
                    printPreviewDialog1.DesktopBounds = Screen.PrimaryScreen.Bounds;
                    DialogResult result_print = printDialog1.ShowDialog();
                    if (result_print == DialogResult.OK)
                    {
                        printPreviewDialog1.ShowDialog();

                        string commandTrans = string.Format("UPDATE [Personnel] SET DateBegin = '{1}', IdDepart={2}, IdOccup={3}, IdShedule={4} where[Personnel].Id ={0}",
                        tabelTB.Text, beginPicker.Value.ToString("dd.MM.yyyy"), combo_dep.SelectedValue, comboOcc.SelectedValue, shedule.SelectedValue);
                        OleDbCommand transcom = new OleDbCommand(commandTrans, connect);
                        transcom.ExecuteNonQuery();

                    }
                    string change = string.Format("and Personnel.[Id]={0} order by Personnel.[Id]", tabelTB.Text);
                    Next(change);

                    department.Visible = true;
                    combo_dep.Visible = false;
                    transportOcc_bt.Visible = true;
                    Occupat.Visible = true;
                    comboOcc.Visible = false;
                    button4.Visible = false;
                    dateBegin.Show(); beginPicker.Visible = false;
                    shedule.Enabled = false;

                    MessageBox.Show("Перевод произведен!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
