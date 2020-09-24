namespace Personnel
{
    partial class BE_Personnel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BE_Personnel));
            this.save = new System.Windows.Forms.Button();
            this.tabelTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lname = new System.Windows.Forms.TextBox();
            this.Fname = new System.Windows.Forms.TextBox();
            this.department = new System.Windows.Forms.TextBox();
            this.Pname = new System.Windows.Forms.TextBox();
            this.salary = new System.Windows.Forms.TextBox();
            this.Occupat = new System.Windows.Forms.TextBox();
            this.child = new System.Windows.Forms.TextBox();
            this.numberTel = new System.Windows.Forms.TextBox();
            this.adress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.shedule = new System.Windows.Forms.ComboBox();
            this.beginShedule = new System.Windows.Forms.TextBox();
            this.dateBegin = new System.Windows.Forms.TextBox();
            this.dateEnd = new System.Windows.Forms.TextBox();
            this.education = new System.Windows.Forms.TextBox();
            this.family = new System.Windows.Forms.TextBox();
            this.dateBirthNew = new System.Windows.Forms.DateTimePicker();
            this.endShedule = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.delWorker = new System.Windows.Forms.Button();
            this.newWorker = new System.Windows.Forms.Button();
            this.birthDate = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.combo_dep = new System.Windows.Forms.ComboBox();
            this.comboOcc = new System.Windows.Forms.ComboBox();
            this.beginPicker = new System.Windows.Forms.DateTimePicker();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.transportOcc_bt = new System.Windows.Forms.Button();
            this.printDocument3 = new System.Drawing.Printing.PrintDocument();
            this.endPicker = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Chartreuse;
            this.save.Location = new System.Drawing.Point(128, 465);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(255, 30);
            this.save.TabIndex = 1;
            this.save.Text = "Принять сотрудника с печатью";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // tabelTB
            // 
            this.tabelTB.Location = new System.Drawing.Point(502, 12);
            this.tabelTB.Name = "tabelTB";
            this.tabelTB.ReadOnly = true;
            this.tabelTB.Size = new System.Drawing.Size(71, 20);
            this.tabelTB.TabIndex = 3;
            this.tabelTB.Text = "таб.номер";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Табельный номер:";
            // 
            // Lname
            // 
            this.Lname.Location = new System.Drawing.Point(128, 40);
            this.Lname.Name = "Lname";
            this.Lname.ReadOnly = true;
            this.Lname.Size = new System.Drawing.Size(255, 20);
            this.Lname.TabIndex = 5;
            // 
            // Fname
            // 
            this.Fname.Location = new System.Drawing.Point(128, 66);
            this.Fname.Name = "Fname";
            this.Fname.ReadOnly = true;
            this.Fname.Size = new System.Drawing.Size(255, 20);
            this.Fname.TabIndex = 6;
            // 
            // department
            // 
            this.department.Location = new System.Drawing.Point(128, 118);
            this.department.Name = "department";
            this.department.ReadOnly = true;
            this.department.Size = new System.Drawing.Size(255, 20);
            this.department.TabIndex = 8;
            // 
            // Pname
            // 
            this.Pname.Location = new System.Drawing.Point(128, 92);
            this.Pname.Name = "Pname";
            this.Pname.ReadOnly = true;
            this.Pname.Size = new System.Drawing.Size(255, 20);
            this.Pname.TabIndex = 7;
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(128, 170);
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            this.salary.Size = new System.Drawing.Size(255, 20);
            this.salary.TabIndex = 10;
            // 
            // Occupat
            // 
            this.Occupat.Location = new System.Drawing.Point(128, 144);
            this.Occupat.Name = "Occupat";
            this.Occupat.ReadOnly = true;
            this.Occupat.Size = new System.Drawing.Size(255, 20);
            this.Occupat.TabIndex = 9;
            // 
            // child
            // 
            this.child.Location = new System.Drawing.Point(128, 404);
            this.child.Name = "child";
            this.child.ReadOnly = true;
            this.child.Size = new System.Drawing.Size(255, 20);
            this.child.TabIndex = 18;
            // 
            // numberTel
            // 
            this.numberTel.Location = new System.Drawing.Point(128, 352);
            this.numberTel.Name = "numberTel";
            this.numberTel.ReadOnly = true;
            this.numberTel.Size = new System.Drawing.Size(255, 20);
            this.numberTel.TabIndex = 16;
            // 
            // adress
            // 
            this.adress.Location = new System.Drawing.Point(128, 300);
            this.adress.Name = "adress";
            this.adress.ReadOnly = true;
            this.adress.Size = new System.Drawing.Size(255, 20);
            this.adress.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Фамилия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Имя:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Отчество:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Отдел:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Должность:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Оклад:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Дата принятия:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Дата увольнения:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(125, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Дополнительно:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(125, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "О сотруднике:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 277);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Дата рождения:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(35, 329);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Образование:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 355);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Номер телефона:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 381);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Семейное полож:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(51, 303);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Прописка:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(75, 407);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Дети:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.ForestGreen;
            this.button1.Location = new System.Drawing.Point(427, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 34);
            this.button1.TabIndex = 40;
            this.button1.Text = "<<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.ForestGreen;
            this.button2.Location = new System.Drawing.Point(540, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 34);
            this.button2.TabIndex = 41;
            this.button2.Text = ">>>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(394, 121);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 42;
            this.label18.Text = "Смена:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(394, 173);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(120, 13);
            this.label19.TabIndex = 43;
            this.label19.Text = "Время по графику:";
            // 
            // shedule
            // 
            this.shedule.Enabled = false;
            this.shedule.FormattingEnabled = true;
            this.shedule.Location = new System.Drawing.Point(397, 143);
            this.shedule.Name = "shedule";
            this.shedule.Size = new System.Drawing.Size(117, 21);
            this.shedule.TabIndex = 44;
            this.shedule.SelectionChangeCommitted += new System.EventHandler(this.shedule_SelectedIndexChanged);
            // 
            // beginShedule
            // 
            this.beginShedule.Location = new System.Drawing.Point(410, 196);
            this.beginShedule.Name = "beginShedule";
            this.beginShedule.ReadOnly = true;
            this.beginShedule.Size = new System.Drawing.Size(70, 20);
            this.beginShedule.TabIndex = 45;
            // 
            // dateBegin
            // 
            this.dateBegin.Location = new System.Drawing.Point(128, 196);
            this.dateBegin.Name = "dateBegin";
            this.dateBegin.ReadOnly = true;
            this.dateBegin.Size = new System.Drawing.Size(255, 20);
            this.dateBegin.TabIndex = 46;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(128, 222);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.ReadOnly = true;
            this.dateEnd.Size = new System.Drawing.Size(255, 20);
            this.dateEnd.TabIndex = 47;
            // 
            // education
            // 
            this.education.Location = new System.Drawing.Point(128, 326);
            this.education.Name = "education";
            this.education.ReadOnly = true;
            this.education.Size = new System.Drawing.Size(255, 20);
            this.education.TabIndex = 49;
            // 
            // family
            // 
            this.family.Location = new System.Drawing.Point(128, 378);
            this.family.Name = "family";
            this.family.ReadOnly = true;
            this.family.Size = new System.Drawing.Size(255, 20);
            this.family.TabIndex = 50;
            // 
            // dateBirthNew
            // 
            this.dateBirthNew.Location = new System.Drawing.Point(128, 274);
            this.dateBirthNew.Name = "dateBirthNew";
            this.dateBirthNew.Size = new System.Drawing.Size(255, 20);
            this.dateBirthNew.TabIndex = 51;
            this.dateBirthNew.Visible = false;
            // 
            // endShedule
            // 
            this.endShedule.Location = new System.Drawing.Point(522, 196);
            this.endShedule.Name = "endShedule";
            this.endShedule.ReadOnly = true;
            this.endShedule.Size = new System.Drawing.Size(71, 20);
            this.endShedule.TabIndex = 52;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(394, 199);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(121, 13);
            this.label20.TabIndex = 53;
            this.label20.Text = "С                       по";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.delWorker);
            this.panel1.Controls.Add(this.newWorker);
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 540);
            this.panel1.TabIndex = 54;
            // 
            // delWorker
            // 
            this.delWorker.BackColor = System.Drawing.Color.BurlyWood;
            this.delWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delWorker.Location = new System.Drawing.Point(329, 109);
            this.delWorker.Name = "delWorker";
            this.delWorker.Size = new System.Drawing.Size(200, 127);
            this.delWorker.TabIndex = 1;
            this.delWorker.Text = "Переводы и увольнения сотрудников с печатью приказа";
            this.delWorker.UseVisualStyleBackColor = false;
            this.delWorker.Click += new System.EventHandler(this.delWorker_Click);
            // 
            // newWorker
            // 
            this.newWorker.BackColor = System.Drawing.Color.YellowGreen;
            this.newWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newWorker.Location = new System.Drawing.Point(62, 109);
            this.newWorker.Name = "newWorker";
            this.newWorker.Size = new System.Drawing.Size(200, 127);
            this.newWorker.TabIndex = 0;
            this.newWorker.Text = "Принять нового сотрудника с печатью приказа";
            this.newWorker.UseVisualStyleBackColor = false;
            this.newWorker.Click += new System.EventHandler(this.newWorker_Click);
            // 
            // birthDate
            // 
            this.birthDate.Location = new System.Drawing.Point(128, 274);
            this.birthDate.Name = "birthDate";
            this.birthDate.ReadOnly = true;
            this.birthDate.Size = new System.Drawing.Size(255, 20);
            this.birthDate.TabIndex = 48;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.BurlyWood;
            this.button3.Location = new System.Drawing.Point(410, 465);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 30);
            this.button3.TabIndex = 55;
            this.button3.Text = "Уволить сотрудника с печатью";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // combo_dep
            // 
            this.combo_dep.FormattingEnabled = true;
            this.combo_dep.Location = new System.Drawing.Point(128, 118);
            this.combo_dep.Name = "combo_dep";
            this.combo_dep.Size = new System.Drawing.Size(255, 21);
            this.combo_dep.TabIndex = 56;
            this.combo_dep.SelectionChangeCommitted += new System.EventHandler(this.combo_dep_SelectionChangeCommitted);
            // 
            // comboOcc
            // 
            this.comboOcc.FormattingEnabled = true;
            this.comboOcc.Location = new System.Drawing.Point(128, 143);
            this.comboOcc.Name = "comboOcc";
            this.comboOcc.Size = new System.Drawing.Size(255, 21);
            this.comboOcc.TabIndex = 57;
            this.comboOcc.SelectionChangeCommitted += new System.EventHandler(this.comboOcc_SelectionChangeCommitted);
            // 
            // beginPicker
            // 
            this.beginPicker.Location = new System.Drawing.Point(128, 196);
            this.beginPicker.Name = "beginPicker";
            this.beginPicker.Size = new System.Drawing.Size(255, 20);
            this.beginPicker.TabIndex = 58;
            this.beginPicker.Visible = false;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // transportOcc_bt
            // 
            this.transportOcc_bt.BackColor = System.Drawing.Color.Chartreuse;
            this.transportOcc_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transportOcc_bt.Location = new System.Drawing.Point(130, 501);
            this.transportOcc_bt.Name = "transportOcc_bt";
            this.transportOcc_bt.Size = new System.Drawing.Size(476, 35);
            this.transportOcc_bt.TabIndex = 2;
            this.transportOcc_bt.Text = "Перевести сотрудника на другую должность с печатью приказа";
            this.transportOcc_bt.UseVisualStyleBackColor = false;
            this.transportOcc_bt.Click += new System.EventHandler(this.transportOcc_bt_Click);
            // 
            // printDocument3
            // 
            this.printDocument3.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument3_PrintPage);
            // 
            // endPicker
            // 
            this.endPicker.Location = new System.Drawing.Point(128, 222);
            this.endPicker.Name = "endPicker";
            this.endPicker.Size = new System.Drawing.Size(255, 20);
            this.endPicker.TabIndex = 59;
            this.endPicker.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.ForeColor = System.Drawing.Color.Blue;
            this.label21.Location = new System.Drawing.Point(223, 437);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(383, 15);
            this.label21.TabIndex = 66;
            this.label21.Text = "Для отмены действий без сохранения закройте форму.";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Chartreuse;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(410, 501);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 35);
            this.button4.TabIndex = 67;
            this.button4.Text = "Продолжить перевод";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BE_Personnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.beginPicker);
            this.Controls.Add(this.endShedule);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.family);
            this.Controls.Add(this.education);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.beginShedule);
            this.Controls.Add(this.shedule);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.child);
            this.Controls.Add(this.numberTel);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.Occupat);
            this.Controls.Add(this.department);
            this.Controls.Add(this.Pname);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabelTB);
            this.Controls.Add(this.save);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.dateBirthNew);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.dateBegin);
            this.Controls.Add(this.comboOcc);
            this.Controls.Add(this.combo_dep);
            this.Controls.Add(this.transportOcc_bt);
            this.Controls.Add(this.endPicker);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.button4);
            this.MaximizeBox = false;
            this.Name = "BE_Personnel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Прием, перевод и увольнение - КАДРЫ";
            this.Load += new System.EventHandler(this.Personnel_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox tabelTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.TextBox department;
        private System.Windows.Forms.TextBox Pname;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.TextBox Occupat;
        private System.Windows.Forms.TextBox child;
        private System.Windows.Forms.TextBox numberTel;
        private System.Windows.Forms.TextBox adress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox shedule;
        private System.Windows.Forms.TextBox beginShedule;
        private System.Windows.Forms.TextBox dateBegin;
        private System.Windows.Forms.TextBox dateEnd;
        private System.Windows.Forms.TextBox education;
        private System.Windows.Forms.TextBox family;
        private System.Windows.Forms.DateTimePicker dateBirthNew;
        private System.Windows.Forms.TextBox endShedule;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button delWorker;
        private System.Windows.Forms.Button newWorker;
        private System.Windows.Forms.TextBox birthDate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox combo_dep;
        private System.Windows.Forms.ComboBox comboOcc;
        private System.Windows.Forms.DateTimePicker beginPicker;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.Button transportOcc_bt;
        private System.Drawing.Printing.PrintDocument printDocument3;
        private System.Windows.Forms.DateTimePicker endPicker;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button4;
    }
}