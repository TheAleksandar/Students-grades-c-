namespace AplikacijaOcenki
{
    partial class MasterForm
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentImeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentPrezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predmetImeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.redovnostPoeniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolokviumPrvPoeniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolokviumVtorPoeniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ispitPoeniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentiBindingSource, "StudentIme", true));
            this.textBox1.Location = new System.Drawing.Point(85, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentiBindingSource, "StudentPrezime", true));
            this.textBox2.Location = new System.Drawing.Point(85, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentiBindingSource, "StudentIndex", true));
            this.textBox3.Location = new System.Drawing.Point(85, 136);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(168, 22);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentiBindingSource, "KolokviumPrvPoeni", true));
            this.textBox4.Location = new System.Drawing.Point(485, 40);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(99, 22);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "0";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentiBindingSource, "KolokviumVtorPoeni", true));
            this.textBox5.Location = new System.Drawing.Point(655, 40);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(106, 22);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "0";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentiBindingSource, "IspitPoeni", true));
            this.textBox6.Location = new System.Drawing.Point(579, 97);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(99, 22);
            this.textBox6.TabIndex = 5;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox6.Enter += new System.EventHandler(this.textBox6_Enter);
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentiBindingSource, "RedovnostPoeni", true));
            this.textBox7.Location = new System.Drawing.Point(571, 141);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(99, 22);
            this.textBox7.TabIndex = 6;
            this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "PredmetIme", true));
            this.textBox8.Location = new System.Drawing.Point(413, 214);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(99, 22);
            this.textBox8.TabIndex = 7;
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentiBindingSource, "Ocena", true));
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(655, 214);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(99, 22);
            this.textBox9.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 253);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentiBindingSource, "RedovnostPoeni", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBox1.Location = new System.Drawing.Point(571, 141);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 24);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(681, 180);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 19);
            this.label15.TabIndex = 23;
            this.label15.Text = "Bodovi";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(568, 180);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 17);
            this.label14.TabIndex = 22;
            this.label14.Text = "Vkupno Bodovi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(576, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "Ocenka";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Predmet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Redovnost Poeni";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(497, 97);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(54, 21);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ispit";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(606, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ispit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(668, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "II-Kolokvium";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "I-Kolokvium";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Br-Index";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(703, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(333, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "New";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(527, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(333, 319);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 37);
            this.button4.TabIndex = 4;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentiBindingSource, "StudentIndex", true));
            this.textBox10.Location = new System.Drawing.Point(48, 309);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(217, 22);
            this.textBox10.TabIndex = 19;
            this.textBox10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox10_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIdDataGridViewTextBoxColumn,
            this.studentImeDataGridViewTextBoxColumn,
            this.studentPrezimeDataGridViewTextBoxColumn,
            this.studentIndexDataGridViewTextBoxColumn,
            this.predmetImeDataGridViewTextBoxColumn,
            this.ocenaDataGridViewTextBoxColumn,
            this.redovnostPoeniDataGridViewTextBoxColumn,
            this.kolokviumPrvPoeniDataGridViewTextBoxColumn,
            this.kolokviumVtorPoeniDataGridViewTextBoxColumn,
            this.ispitPoeniDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 362);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(761, 170);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(115, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Search:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(366, 541);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 37);
            this.button5.TabIndex = 21;
            this.button5.Text = "LogOut";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            // 
            // studentImeDataGridViewTextBoxColumn
            // 
            this.studentImeDataGridViewTextBoxColumn.DataPropertyName = "StudentIme";
            this.studentImeDataGridViewTextBoxColumn.HeaderText = "StudentIme";
            this.studentImeDataGridViewTextBoxColumn.Name = "studentImeDataGridViewTextBoxColumn";
            // 
            // studentPrezimeDataGridViewTextBoxColumn
            // 
            this.studentPrezimeDataGridViewTextBoxColumn.DataPropertyName = "StudentPrezime";
            this.studentPrezimeDataGridViewTextBoxColumn.HeaderText = "StudentPrezime";
            this.studentPrezimeDataGridViewTextBoxColumn.Name = "studentPrezimeDataGridViewTextBoxColumn";
            // 
            // studentIndexDataGridViewTextBoxColumn
            // 
            this.studentIndexDataGridViewTextBoxColumn.DataPropertyName = "StudentIndex";
            this.studentIndexDataGridViewTextBoxColumn.HeaderText = "StudentIndex";
            this.studentIndexDataGridViewTextBoxColumn.Name = "studentIndexDataGridViewTextBoxColumn";
            // 
            // predmetImeDataGridViewTextBoxColumn
            // 
            this.predmetImeDataGridViewTextBoxColumn.DataPropertyName = "PredmetIme";
            this.predmetImeDataGridViewTextBoxColumn.HeaderText = "PredmetIme";
            this.predmetImeDataGridViewTextBoxColumn.Name = "predmetImeDataGridViewTextBoxColumn";
            // 
            // ocenaDataGridViewTextBoxColumn
            // 
            this.ocenaDataGridViewTextBoxColumn.DataPropertyName = "Ocena";
            this.ocenaDataGridViewTextBoxColumn.HeaderText = "Ocena";
            this.ocenaDataGridViewTextBoxColumn.Name = "ocenaDataGridViewTextBoxColumn";
            // 
            // redovnostPoeniDataGridViewTextBoxColumn
            // 
            this.redovnostPoeniDataGridViewTextBoxColumn.DataPropertyName = "RedovnostPoeni";
            this.redovnostPoeniDataGridViewTextBoxColumn.HeaderText = "RedovnostPoeni";
            this.redovnostPoeniDataGridViewTextBoxColumn.Name = "redovnostPoeniDataGridViewTextBoxColumn";
            // 
            // kolokviumPrvPoeniDataGridViewTextBoxColumn
            // 
            this.kolokviumPrvPoeniDataGridViewTextBoxColumn.DataPropertyName = "KolokviumPrvPoeni";
            this.kolokviumPrvPoeniDataGridViewTextBoxColumn.HeaderText = "KolokviumPrvPoeni";
            this.kolokviumPrvPoeniDataGridViewTextBoxColumn.Name = "kolokviumPrvPoeniDataGridViewTextBoxColumn";
            // 
            // kolokviumVtorPoeniDataGridViewTextBoxColumn
            // 
            this.kolokviumVtorPoeniDataGridViewTextBoxColumn.DataPropertyName = "KolokviumVtorPoeni";
            this.kolokviumVtorPoeniDataGridViewTextBoxColumn.HeaderText = "KolokviumVtorPoeni";
            this.kolokviumVtorPoeniDataGridViewTextBoxColumn.Name = "kolokviumVtorPoeniDataGridViewTextBoxColumn";
            // 
            // ispitPoeniDataGridViewTextBoxColumn
            // 
            this.ispitPoeniDataGridViewTextBoxColumn.DataPropertyName = "IspitPoeni";
            this.ispitPoeniDataGridViewTextBoxColumn.HeaderText = "IspitPoeni";
            this.ispitPoeniDataGridViewTextBoxColumn.Name = "ispitPoeniDataGridViewTextBoxColumn";
            // 
            // studentiBindingSource
            // 
            this.studentiBindingSource.DataSource = typeof(AplikacijaOcenki.Studenti);
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataSource = typeof(AplikacijaOcenki.Table);
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 590);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "MasterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterForm";
            this.Load += new System.EventHandler(this.MasterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource studentiBindingSource;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentImeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentPrezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn predmetImeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn redovnostPoeniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolokviumPrvPoeniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolokviumVtorPoeniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ispitPoeniDataGridViewTextBoxColumn;
    }
}