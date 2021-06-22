namespace VetBD
{
    partial class DoctorForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.radioButtonFIO = new System.Windows.Forms.RadioButton();
            this.radioButtonID = new System.Windows.Forms.RadioButton();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonShowApp = new System.Windows.Forms.Button();
            this.buttonSApp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxIDdoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewApp = new System.Windows.Forms.DataGridView();
            this.buttonSearchApp = new System.Windows.Forms.Button();
            this.textBoxSearchApp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApp)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
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
            this.tabPage1.Controls.Add(this.buttonUpdate);
            this.tabPage1.Controls.Add(this.radioButtonFIO);
            this.tabPage1.Controls.Add(this.radioButtonID);
            this.tabPage1.Controls.Add(this.buttonSearch);
            this.tabPage1.Controls.Add(this.textBoxFIO);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1037, 663);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Карты пациентов";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(8, 608);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(119, 46);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "Просмотр карточки";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // radioButtonFIO
            // 
            this.radioButtonFIO.AutoSize = true;
            this.radioButtonFIO.Checked = true;
            this.radioButtonFIO.Location = new System.Drawing.Point(149, 31);
            this.radioButtonFIO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonFIO.Name = "radioButtonFIO";
            this.radioButtonFIO.Size = new System.Drawing.Size(57, 20);
            this.radioButtonFIO.TabIndex = 5;
            this.radioButtonFIO.TabStop = true;
            this.radioButtonFIO.Text = "ФИО";
            this.radioButtonFIO.UseVisualStyleBackColor = true;
            // 
            // radioButtonID
            // 
            this.radioButtonID.AutoSize = true;
            this.radioButtonID.Location = new System.Drawing.Point(86, 31);
            this.radioButtonID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonID.Name = "radioButtonID";
            this.radioButtonID.Size = new System.Drawing.Size(39, 20);
            this.radioButtonID.TabIndex = 4;
            this.radioButtonID.Text = "ID";
            this.radioButtonID.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackgroundImage = global::VetBD.Properties.Resources.loupe;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearch.Location = new System.Drawing.Point(789, 24);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(51, 36);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(214, 31);
            this.textBoxFIO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(567, 22);
            this.textBoxFIO.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поиск по:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 68);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1020, 532);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonShowApp);
            this.tabPage2.Controls.Add(this.buttonSApp);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textBoxIDdoc);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dataGridViewApp);
            this.tabPage2.Controls.Add(this.buttonSearchApp);
            this.tabPage2.Controls.Add(this.textBoxSearchApp);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1037, 663);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Приемы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonShowApp
            // 
            this.buttonShowApp.Location = new System.Drawing.Point(9, 608);
            this.buttonShowApp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonShowApp.Name = "buttonShowApp";
            this.buttonShowApp.Size = new System.Drawing.Size(119, 46);
            this.buttonShowApp.TabIndex = 13;
            this.buttonShowApp.Text = "Просмотр";
            this.buttonShowApp.UseVisualStyleBackColor = true;
            this.buttonShowApp.Click += new System.EventHandler(this.buttonShowApp_Click);
            // 
            // buttonSApp
            // 
            this.buttonSApp.BackgroundImage = global::VetBD.Properties.Resources.loupe;
            this.buttonSApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSApp.Location = new System.Drawing.Point(693, 78);
            this.buttonSApp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSApp.Name = "buttonSApp";
            this.buttonSApp.Size = new System.Drawing.Size(51, 38);
            this.buttonSApp.TabIndex = 12;
            this.buttonSApp.UseVisualStyleBackColor = true;
            this.buttonSApp.Click += new System.EventHandler(this.buttonSApp_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 43);
            this.button1.TabIndex = 11;
            this.button1.Text = "Отобразить приемы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxIDdoc
            // 
            this.textBoxIDdoc.Location = new System.Drawing.Point(156, 22);
            this.textBoxIDdoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIDdoc.Name = "textBoxIDdoc";
            this.textBoxIDdoc.Size = new System.Drawing.Size(132, 22);
            this.textBoxIDdoc.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Укажите ID врача:";
            // 
            // dataGridViewApp
            // 
            this.dataGridViewApp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewApp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewApp.Location = new System.Drawing.Point(12, 119);
            this.dataGridViewApp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewApp.Name = "dataGridViewApp";
            this.dataGridViewApp.Size = new System.Drawing.Size(1016, 481);
            this.dataGridViewApp.TabIndex = 8;
            this.dataGridViewApp.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewApp_CellContentDoubleClick);
            // 
            // buttonSearchApp
            // 
            this.buttonSearchApp.Location = new System.Drawing.Point(695, 119);
            this.buttonSearchApp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSearchApp.Name = "buttonSearchApp";
            this.buttonSearchApp.Size = new System.Drawing.Size(68, 25);
            this.buttonSearchApp.TabIndex = 6;
            this.buttonSearchApp.Text = "Поиск";
            this.buttonSearchApp.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchApp
            // 
            this.textBoxSearchApp.Location = new System.Drawing.Point(196, 87);
            this.textBoxSearchApp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSearchApp.Name = "textBoxSearchApp";
            this.textBoxSearchApp.Size = new System.Drawing.Size(489, 22);
            this.textBoxSearchApp.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Поиск по ФИО клиента:";
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 692);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DoctorForm";
            this.Text = "VetBD";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DoctorForm_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.RadioButton radioButtonID;
        private System.Windows.Forms.RadioButton radioButtonFIO;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSearchApp;
        private System.Windows.Forms.TextBox textBoxSearchApp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewApp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxIDdoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSApp;
        private System.Windows.Forms.Button buttonShowApp;
    }
}