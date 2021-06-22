namespace VetBD
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ApButton = new System.Windows.Forms.Button();
            this.DeleteClientButton = new System.Windows.Forms.Button();
            this.radioButtonFIO = new System.Windows.Forms.RadioButton();
            this.radioButtonID = new System.Windows.Forms.RadioButton();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.NewCardButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxApSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewAp = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DeleteDocButton = new System.Windows.Forms.Button();
            this.AddDocButton = new System.Windows.Forms.Button();
            this.DocTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewDoctor = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.buttonApSearch = new System.Windows.Forms.Button();
            this.DocSearchbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAp)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1045, 692);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.ApButton);
            this.tabPage1.Controls.Add(this.DeleteClientButton);
            this.tabPage1.Controls.Add(this.UpdateButton);
            this.tabPage1.Controls.Add(this.DeleteButton);
            this.tabPage1.Controls.Add(this.NewCardButton);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1037, 663);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Пациенты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ApButton
            // 
            this.ApButton.Location = new System.Drawing.Point(257, 604);
            this.ApButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ApButton.Name = "ApButton";
            this.ApButton.Size = new System.Drawing.Size(119, 46);
            this.ApButton.TabIndex = 12;
            this.ApButton.Text = "Запись на приём";
            this.ApButton.UseVisualStyleBackColor = true;
            this.ApButton.Click += new System.EventHandler(this.ApButton_Click);
            // 
            // DeleteClientButton
            // 
            this.DeleteClientButton.Location = new System.Drawing.Point(511, 604);
            this.DeleteClientButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteClientButton.Name = "DeleteClientButton";
            this.DeleteClientButton.Size = new System.Drawing.Size(119, 46);
            this.DeleteClientButton.TabIndex = 11;
            this.DeleteClientButton.Text = "Удалить клиента";
            this.DeleteClientButton.UseVisualStyleBackColor = true;
            this.DeleteClientButton.Click += new System.EventHandler(this.DeleteClientButton_Click);
            // 
            // radioButtonFIO
            // 
            this.radioButtonFIO.AutoSize = true;
            this.radioButtonFIO.Checked = true;
            this.radioButtonFIO.Location = new System.Drawing.Point(206, 25);
            this.radioButtonFIO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonFIO.Name = "radioButtonFIO";
            this.radioButtonFIO.Size = new System.Drawing.Size(57, 20);
            this.radioButtonFIO.TabIndex = 8;
            this.radioButtonFIO.TabStop = true;
            this.radioButtonFIO.Text = "ФОИ";
            this.radioButtonFIO.UseVisualStyleBackColor = true;
            // 
            // radioButtonID
            // 
            this.radioButtonID.AutoSize = true;
            this.radioButtonID.Location = new System.Drawing.Point(147, 25);
            this.radioButtonID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonID.Name = "radioButtonID";
            this.radioButtonID.Size = new System.Drawing.Size(39, 20);
            this.radioButtonID.TabIndex = 7;
            this.radioButtonID.Text = "ID";
            this.radioButtonID.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(131, 604);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(119, 46);
            this.UpdateButton.TabIndex = 6;
            this.UpdateButton.Text = "Просмотр карты";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(384, 604);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(119, 46);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Удалить карточку";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // NewCardButton
            // 
            this.NewCardButton.Location = new System.Drawing.Point(4, 604);
            this.NewCardButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewCardButton.Name = "NewCardButton";
            this.NewCardButton.Size = new System.Drawing.Size(119, 46);
            this.NewCardButton.TabIndex = 4;
            this.NewCardButton.Text = "Новая карточка";
            this.NewCardButton.UseVisualStyleBackColor = true;
            this.NewCardButton.Click += new System.EventHandler(this.NewCardButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поиск карточки по:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(277, 22);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(511, 22);
            this.searchTextBox.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 93);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1016, 504);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.buttonApSearch);
            this.tabPage2.Controls.Add(this.textBoxApSearch);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dataGridViewAp);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1037, 663);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Прием";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxApSearch
            // 
            this.textBoxApSearch.Location = new System.Drawing.Point(187, 17);
            this.textBoxApSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxApSearch.Name = "textBoxApSearch";
            this.textBoxApSearch.Size = new System.Drawing.Size(452, 22);
            this.textBoxApSearch.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Поиск по ФИО клиента:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 603);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Удалить приём";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewAp
            // 
            this.dataGridViewAp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAp.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAp.Location = new System.Drawing.Point(8, 77);
            this.dataGridViewAp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewAp.Name = "dataGridViewAp";
            this.dataGridViewAp.Size = new System.Drawing.Size(1016, 519);
            this.dataGridViewAp.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.DeleteDocButton);
            this.tabPage3.Controls.Add(this.AddDocButton);
            this.tabPage3.Controls.Add(this.DocSearchbutton);
            this.tabPage3.Controls.Add(this.DocTextBox);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.dataGridViewDoctor);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(1037, 663);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Врачи";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DeleteDocButton
            // 
            this.DeleteDocButton.Location = new System.Drawing.Point(135, 604);
            this.DeleteDocButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteDocButton.Name = "DeleteDocButton";
            this.DeleteDocButton.Size = new System.Drawing.Size(119, 46);
            this.DeleteDocButton.TabIndex = 5;
            this.DeleteDocButton.Text = "Удалить";
            this.DeleteDocButton.UseVisualStyleBackColor = true;
            this.DeleteDocButton.Click += new System.EventHandler(this.DeleteDocButton_Click);
            // 
            // AddDocButton
            // 
            this.AddDocButton.Location = new System.Drawing.Point(8, 604);
            this.AddDocButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddDocButton.Name = "AddDocButton";
            this.AddDocButton.Size = new System.Drawing.Size(119, 46);
            this.AddDocButton.TabIndex = 4;
            this.AddDocButton.Text = "Добавить врача";
            this.AddDocButton.UseVisualStyleBackColor = true;
            this.AddDocButton.Click += new System.EventHandler(this.AddDocButton_Click);
            // 
            // DocTextBox
            // 
            this.DocTextBox.Location = new System.Drawing.Point(132, 22);
            this.DocTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DocTextBox.Name = "DocTextBox";
            this.DocTextBox.Size = new System.Drawing.Size(495, 22);
            this.DocTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Поиск по ФИО:";
            // 
            // dataGridViewDoctor
            // 
            this.dataGridViewDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDoctor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctor.Location = new System.Drawing.Point(8, 85);
            this.dataGridViewDoctor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewDoctor.Name = "dataGridViewDoctor";
            this.dataGridViewDoctor.Size = new System.Drawing.Size(1016, 512);
            this.dataGridViewDoctor.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Список карточек пациентов:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonID);
            this.groupBox1.Controls.Add(this.searchTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButtonFIO);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(857, 63);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImage = global::VetBD.Properties.Resources.loupe;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.Location = new System.Drawing.Point(796, 13);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(50, 40);
            this.searchButton.TabIndex = 3;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // buttonApSearch
            // 
            this.buttonApSearch.BackgroundImage = global::VetBD.Properties.Resources.loupe;
            this.buttonApSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonApSearch.Location = new System.Drawing.Point(647, 11);
            this.buttonApSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonApSearch.Name = "buttonApSearch";
            this.buttonApSearch.Size = new System.Drawing.Size(46, 35);
            this.buttonApSearch.TabIndex = 4;
            this.buttonApSearch.UseVisualStyleBackColor = true;
            this.buttonApSearch.Click += new System.EventHandler(this.buttonApSearch_Click);
            // 
            // DocSearchbutton
            // 
            this.DocSearchbutton.BackgroundImage = global::VetBD.Properties.Resources.loupe;
            this.DocSearchbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DocSearchbutton.Location = new System.Drawing.Point(635, 14);
            this.DocSearchbutton.Margin = new System.Windows.Forms.Padding(4);
            this.DocSearchbutton.Name = "DocSearchbutton";
            this.DocSearchbutton.Size = new System.Drawing.Size(44, 38);
            this.DocSearchbutton.TabIndex = 3;
            this.DocSearchbutton.UseVisualStyleBackColor = true;
            this.DocSearchbutton.Click += new System.EventHandler(this.DocSearchbutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Список приёмов:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Список врачей:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 692);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "VetBD";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAp)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button NewCardButton;
        private System.Windows.Forms.RadioButton radioButtonFIO;
        private System.Windows.Forms.RadioButton radioButtonID;
        private System.Windows.Forms.Button DeleteClientButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridViewDoctor;
        private System.Windows.Forms.Button DocSearchbutton;
        private System.Windows.Forms.TextBox DocTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteDocButton;
        private System.Windows.Forms.Button AddDocButton;
        private System.Windows.Forms.DataGridView dataGridViewAp;
        private System.Windows.Forms.Button ApButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonApSearch;
        private System.Windows.Forms.TextBox textBoxApSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}