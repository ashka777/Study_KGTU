using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personnel
{
    public partial class BeginEnd : Form
    {
        public OleDbConnection connect;
        public BeginEnd(OleDbConnection connection)
        {
            InitializeComponent();
            connect = connection;
        }

        private void BeginEnd_Load(object sender, EventArgs e)
        {
            string change = "where Personnel.[Id]>0 order by Personnel.[Id]";
            //Next(change);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string change = string.Format("where Personnel.[Id]>{0} ", tabelTB.Text);
           // Next(change);
        }

        DataTable dataTable = new DataTable();
        OleDbDataAdapter da = new OleDbDataAdapter();
        //private void Next(string change)
        //{
        //    try
        //    {
        //        string command = string.Format("SELECT Personnel.Id, Personnel.FName, Personnel.LName, Personnel.PName, Department.NameDep, Occupation.NameOcc, " +
        //        "Occupation.Salary, Personnel.DateBegin, Personnel.DateEnd, Personnel.Education, Personnel.NumberTel, Personnel.Adress, Personnel.BirthDate, " +
        //        "Personnel.Family, Personnel.Child, Schedule.NameShedule, Schedule.TimeBegin, Schedule.TimeEnd " +
        //        "FROM((Personnel INNER JOIN Department ON Personnel.IdDepart = Department.Id) " +
        //        "INNER JOIN Occupation ON Personnel.IdOccup = Occupation.Id) INNER JOIN Schedule ON Personnel.IdShedule = Schedule.ID " +
        //        change);
        //        OleDbCommand selectcom = new OleDbCommand(command, connect);
        //        dataTable = new DataTable();
        //        da = new OleDbDataAdapter(selectcom);
        //        da.Fill(dataTable);
               
        //        tabelTB.Text = dataTable.Rows[0]["Id"].ToString();
        //        Lname.Text = dataTable.Rows[0]["Fname"].ToString();
        //        Fname.Text = dataTable.Rows[0]["Lname"].ToString();
        //        try { Pname.Text = dataTable.Rows[0]["Pname"].ToString(); } catch { Pname.Text = ""; }
        //        try { department.Text = dataTable.Rows[0]["NameDep"].ToString(); } catch { department.Text = ""; }
        //        try { Occupat.Text = dataTable.Rows[0]["NameOcc"].ToString(); } catch { Occupat.Text = ""; }
        //        try { salary.Text = dataTable.Rows[0]["Salary"].ToString(); } catch { salary.Text = ""; }
        //        try { dateBegin.Text = Convert.ToDateTime(dataTable.Rows[0]["DateBegin"]).ToString("dd.MM.yyyy"); } catch { dateBegin.Text = ""; }
        //        try { dateEnd.Text = Convert.ToDateTime(dataTable.Rows[0]["DateEnd"]).ToString("dd.MM.yyyy"); } catch { dateEnd.Text = ""; }
        //        birthDate.Text = Convert.ToDateTime(dataTable.Rows[0]["BirthDate"]).ToString("dd.MM.yyyy");  
        //        try { adress.Text = dataTable.Rows[0]["Adress"].ToString(); } catch { adress.Text = ""; }
        //        try { education.Text = dataTable.Rows[0]["Education"].ToString(); } catch { education.Text = ""; }
        //        try { numberTel.Text = dataTable.Rows[0]["NumberTel"].ToString(); } catch { numberTel.Text = ""; }
        //        try { family.Text = dataTable.Rows[0]["Family"].ToString(); } catch { family.Text = ""; }
        //        try { child.Text = dataTable.Rows[0]["Child"].ToString(); } catch { child.Text = ""; }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            string change = string.Format("where Personnel.[Id]<{0} order by Personnel.[Id] desc", tabelTB.Text);
            //Next(change);
        }

        private void del_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult del = MessageBox.Show("Удалить сотрудника?", "Сохранение данных", MessageBoxButtons.YesNo);
                if (del == DialogResult.Yes)
                {
                    string commandDel = string.Format("Delete from Personnel where Personnel.Id={0} ", tabelTB.Text);
                    OleDbCommand deletecom = new OleDbCommand(commandDel, connect);
                    deletecom.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void save_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DialogResult save = MessageBox.Show("Сохранить изменения?", "Сохранение данных", MessageBoxButtons.YesNo);
        //        if (save == DialogResult.Yes)
        //        {
        //            string commandDel = string.Format("UPDATE [Personnel] SET FName='{1}', LName='{2}', PName='{3}', Adress='{4}', Education='{5}', NumberTel='{6}', " +
        //                "Family='{7}', Child={8} where [Personnel].Id={0}", tabelTB.Text, Fname.Text, Lname.Text, Pname.Text, adress.Text,
        //                education.Text, numberTel.Text, family.Text, child.Text);
        //            OleDbCommand deletecom = new OleDbCommand(commandDel, connect);
        //            deletecom.ExecuteNonQuery();
                    
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void newPers_Click(object sender, EventArgs e)
        //{
        //    tabelTB.Clear();
        //    Lname.Clear();
        //    Fname.Clear();
        //    Pname.Clear();
        //    department.Clear();
        //    Occupat.Clear();
        //    salary.Clear();
        //    dateBegin.Clear();
        //    dateEnd.Clear();
        //    birthDate.Clear(); dateBirthNew.Show(); birthDate.Hide();
        //    adress.Clear();
        //    education.Clear();
        //    numberTel.Clear();
        //    family.Clear();
        //    child.Clear();
        //}

        private void saveN_Click(object sender, EventArgs e)
        {
            
            try
            {
                DialogResult saveNew = MessageBox.Show("Сохранить новую запись?", "Сохранение данных", MessageBoxButtons.YesNo);
                if (saveNew == DialogResult.Yes)
                {
                    string commandinsert = string.Format("INSERT INTO [Personnel] " +
                        "(FName, LName, PName, BirthDate, Adress, Education, NumberTel, " +
                        "Family, Child, IdDepart, IdOccup, IdShedule) " +
                        "VALUES('{1}', '{2}', '{3}', '{0}', '{4}', '{5}', '{6}', '{7}', {8}, {9}, {10})",
                        dateBirthNew.Value.ToString("dd.MM.yyyy"), Fname.Text, Lname.Text, Pname.Text, adress.Text,
                        education.Text, numberTel.Text, family.Text, child.Text, 0, 0);
                    OleDbCommand insertcom = new OleDbCommand(commandinsert, connect);
                    insertcom.ExecuteNonQuery();
                }
                
                saveN.Visible = false;
                dateBirthNew.Hide(); 
                birthDate.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string command2 = string.Format("SELECT * from Schedule where Id=@id");
                OleDbCommand selectcom2 = new OleDbCommand(command2, connect);
                selectcom2.Parameters.AddWithValue("@id", shedule.SelectedIndex + 1);
                DataTable dataTable = new DataTable();
                da = new OleDbDataAdapter(selectcom2);
                da.Fill(dataTable);

                beginShedule.Text = Convert.ToDateTime(dataTable.Rows[0]["TimeBegin"]).ToString("HH:mm");
                endShedule.Text = Convert.ToDateTime(dataTable.Rows[0]["TimeEnd"]).ToString("HH:mm");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
    }

