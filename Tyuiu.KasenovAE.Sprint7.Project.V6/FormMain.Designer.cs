
namespace Tyuiu.KasenovAE.Sprint7.Project.V6
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelMenu_KAE = new System.Windows.Forms.Panel();
            this.buttonChange_KAE = new System.Windows.Forms.Button();
            this.groupBoxFilter_KAE = new System.Windows.Forms.GroupBox();
            this.buttonReturnDefault_KAE = new System.Windows.Forms.Button();
            this.buttonFilter_KAE = new System.Windows.Forms.Button();
            this.textBoxFilter_KAE = new System.Windows.Forms.TextBox();
            this.buttonChangePath_KAE = new System.Windows.Forms.Button();
            this.groupBoxEnterData_KAE = new System.Windows.Forms.GroupBox();
            this.panelEnterData_KAE = new System.Windows.Forms.Panel();
            this.textBoxPhoneNumber_KAE = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber_KAE = new System.Windows.Forms.Label();
            this.textBoxDoctor_KAE = new System.Windows.Forms.TextBox();
            this.labelDoctor_KAE = new System.Windows.Forms.Label();
            this.textBoxDisease_KAE = new System.Windows.Forms.TextBox();
            this.labelDisease_KAE = new System.Windows.Forms.Label();
            this.textBoxAge_KAE = new System.Windows.Forms.TextBox();
            this.labelAge_KAE = new System.Windows.Forms.Label();
            this.textBoxMName_KAE = new System.Windows.Forms.TextBox();
            this.labelMName_KAE = new System.Windows.Forms.Label();
            this.labelLName_KAE = new System.Windows.Forms.Label();
            this.textBoxLName_KAE = new System.Windows.Forms.TextBox();
            this.labelFName_KAE = new System.Windows.Forms.Label();
            this.textBoxFName_KAE = new System.Windows.Forms.TextBox();
            this.buttonDelete_KAE = new System.Windows.Forms.Button();
            this.buttonAdd_KAE = new System.Windows.Forms.Button();
            this.panelInfo_KAE = new System.Windows.Forms.Panel();
            this.textBoxInfo_KAE = new System.Windows.Forms.TextBox();
            this.dataGridView_KAE = new System.Windows.Forms.DataGridView();
            this.openFileDialog_KAE = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_KAE = new System.Windows.Forms.ToolTip(this.components);
            this.buttonFrequency_KAE = new System.Windows.Forms.Button();
            this.buttonInfo_KAE = new System.Windows.Forms.Button();
            this.panelMenu_KAE.SuspendLayout();
            this.groupBoxFilter_KAE.SuspendLayout();
            this.groupBoxEnterData_KAE.SuspendLayout();
            this.panelEnterData_KAE.SuspendLayout();
            this.panelInfo_KAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KAE)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu_KAE
            // 
            this.panelMenu_KAE.Controls.Add(this.buttonInfo_KAE);
            this.panelMenu_KAE.Controls.Add(this.buttonFrequency_KAE);
            this.panelMenu_KAE.Controls.Add(this.buttonChange_KAE);
            this.panelMenu_KAE.Controls.Add(this.groupBoxFilter_KAE);
            this.panelMenu_KAE.Controls.Add(this.buttonChangePath_KAE);
            this.panelMenu_KAE.Controls.Add(this.groupBoxEnterData_KAE);
            this.panelMenu_KAE.Controls.Add(this.buttonDelete_KAE);
            this.panelMenu_KAE.Controls.Add(this.buttonAdd_KAE);
            this.panelMenu_KAE.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu_KAE.Location = new System.Drawing.Point(0, 0);
            this.panelMenu_KAE.Name = "panelMenu_KAE";
            this.panelMenu_KAE.Size = new System.Drawing.Size(242, 529);
            this.panelMenu_KAE.TabIndex = 0;
            // 
            // buttonChange_KAE
            // 
            this.buttonChange_KAE.Location = new System.Drawing.Point(84, 3);
            this.buttonChange_KAE.Name = "buttonChange_KAE";
            this.buttonChange_KAE.Size = new System.Drawing.Size(75, 37);
            this.buttonChange_KAE.TabIndex = 7;
            this.buttonChange_KAE.Text = "Изменить";
            this.toolTip_KAE.SetToolTip(this.buttonChange_KAE, "Позволяет изменить данные о пациенте\r\n");
            this.buttonChange_KAE.UseVisualStyleBackColor = true;
            this.buttonChange_KAE.Click += new System.EventHandler(this.buttonChange_KAE_Click);
            // 
            // groupBoxFilter_KAE
            // 
            this.groupBoxFilter_KAE.Controls.Add(this.buttonReturnDefault_KAE);
            this.groupBoxFilter_KAE.Controls.Add(this.buttonFilter_KAE);
            this.groupBoxFilter_KAE.Controls.Add(this.textBoxFilter_KAE);
            this.groupBoxFilter_KAE.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxFilter_KAE.Location = new System.Drawing.Point(0, 139);
            this.groupBoxFilter_KAE.Name = "groupBoxFilter_KAE";
            this.groupBoxFilter_KAE.Size = new System.Drawing.Size(242, 89);
            this.groupBoxFilter_KAE.TabIndex = 6;
            this.groupBoxFilter_KAE.TabStop = false;
            this.groupBoxFilter_KAE.Text = "Фильтрация";
            // 
            // buttonReturnDefault_KAE
            // 
            this.buttonReturnDefault_KAE.Location = new System.Drawing.Point(84, 45);
            this.buttonReturnDefault_KAE.Name = "buttonReturnDefault_KAE";
            this.buttonReturnDefault_KAE.Size = new System.Drawing.Size(75, 37);
            this.buttonReturnDefault_KAE.TabIndex = 8;
            this.buttonReturnDefault_KAE.Text = "Вернуть";
            this.toolTip_KAE.SetToolTip(this.buttonReturnDefault_KAE, "Возвращает таблице исходный вид\r\n");
            this.buttonReturnDefault_KAE.UseVisualStyleBackColor = true;
            this.buttonReturnDefault_KAE.Click += new System.EventHandler(this.buttonReturnDefault_KAE_Click);
            // 
            // buttonFilter_KAE
            // 
            this.buttonFilter_KAE.Location = new System.Drawing.Point(3, 45);
            this.buttonFilter_KAE.Name = "buttonFilter_KAE";
            this.buttonFilter_KAE.Size = new System.Drawing.Size(75, 37);
            this.buttonFilter_KAE.TabIndex = 7;
            this.buttonFilter_KAE.Text = "Применить\r\n";
            this.toolTip_KAE.SetToolTip(this.buttonFilter_KAE, "Применяет фильтрацию к выбранному столбцу\r\n\r\n");
            this.buttonFilter_KAE.UseVisualStyleBackColor = true;
            this.buttonFilter_KAE.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // textBoxFilter_KAE
            // 
            this.textBoxFilter_KAE.Location = new System.Drawing.Point(6, 19);
            this.textBoxFilter_KAE.Name = "textBoxFilter_KAE";
            this.textBoxFilter_KAE.Size = new System.Drawing.Size(230, 20);
            this.textBoxFilter_KAE.TabIndex = 0;
            // 
            // buttonChangePath_KAE
            // 
            this.buttonChangePath_KAE.Location = new System.Drawing.Point(165, 3);
            this.buttonChangePath_KAE.Name = "buttonChangePath_KAE";
            this.buttonChangePath_KAE.Size = new System.Drawing.Size(75, 37);
            this.buttonChangePath_KAE.TabIndex = 5;
            this.buttonChangePath_KAE.Text = "Изменить путь";
            this.toolTip_KAE.SetToolTip(this.buttonChangePath_KAE, "Позволяет изменить путь к CSV файлу\r\n");
            this.buttonChangePath_KAE.UseVisualStyleBackColor = true;
            this.buttonChangePath_KAE.Click += new System.EventHandler(this.buttonChangePath_KAE_Click);
            // 
            // groupBoxEnterData_KAE
            // 
            this.groupBoxEnterData_KAE.Controls.Add(this.panelEnterData_KAE);
            this.groupBoxEnterData_KAE.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxEnterData_KAE.Location = new System.Drawing.Point(0, 228);
            this.groupBoxEnterData_KAE.Name = "groupBoxEnterData_KAE";
            this.groupBoxEnterData_KAE.Size = new System.Drawing.Size(242, 301);
            this.groupBoxEnterData_KAE.TabIndex = 4;
            this.groupBoxEnterData_KAE.TabStop = false;
            this.groupBoxEnterData_KAE.Text = "Данные о пациенте";
            // 
            // panelEnterData_KAE
            // 
            this.panelEnterData_KAE.AutoScroll = true;
            this.panelEnterData_KAE.Controls.Add(this.textBoxPhoneNumber_KAE);
            this.panelEnterData_KAE.Controls.Add(this.labelPhoneNumber_KAE);
            this.panelEnterData_KAE.Controls.Add(this.textBoxDoctor_KAE);
            this.panelEnterData_KAE.Controls.Add(this.labelDoctor_KAE);
            this.panelEnterData_KAE.Controls.Add(this.textBoxDisease_KAE);
            this.panelEnterData_KAE.Controls.Add(this.labelDisease_KAE);
            this.panelEnterData_KAE.Controls.Add(this.textBoxAge_KAE);
            this.panelEnterData_KAE.Controls.Add(this.labelAge_KAE);
            this.panelEnterData_KAE.Controls.Add(this.textBoxMName_KAE);
            this.panelEnterData_KAE.Controls.Add(this.labelMName_KAE);
            this.panelEnterData_KAE.Controls.Add(this.labelLName_KAE);
            this.panelEnterData_KAE.Controls.Add(this.textBoxLName_KAE);
            this.panelEnterData_KAE.Controls.Add(this.labelFName_KAE);
            this.panelEnterData_KAE.Controls.Add(this.textBoxFName_KAE);
            this.panelEnterData_KAE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEnterData_KAE.Location = new System.Drawing.Point(3, 16);
            this.panelEnterData_KAE.Name = "panelEnterData_KAE";
            this.panelEnterData_KAE.Size = new System.Drawing.Size(236, 282);
            this.panelEnterData_KAE.TabIndex = 0;
            // 
            // textBoxPhoneNumber_KAE
            // 
            this.textBoxPhoneNumber_KAE.Location = new System.Drawing.Point(3, 254);
            this.textBoxPhoneNumber_KAE.Name = "textBoxPhoneNumber_KAE";
            this.textBoxPhoneNumber_KAE.Size = new System.Drawing.Size(230, 20);
            this.textBoxPhoneNumber_KAE.TabIndex = 13;
            // 
            // labelPhoneNumber_KAE
            // 
            this.labelPhoneNumber_KAE.AutoSize = true;
            this.labelPhoneNumber_KAE.Location = new System.Drawing.Point(3, 238);
            this.labelPhoneNumber_KAE.Name = "labelPhoneNumber_KAE";
            this.labelPhoneNumber_KAE.Size = new System.Drawing.Size(93, 13);
            this.labelPhoneNumber_KAE.TabIndex = 12;
            this.labelPhoneNumber_KAE.Text = "Номер телефона";
            // 
            // textBoxDoctor_KAE
            // 
            this.textBoxDoctor_KAE.Location = new System.Drawing.Point(3, 215);
            this.textBoxDoctor_KAE.Name = "textBoxDoctor_KAE";
            this.textBoxDoctor_KAE.Size = new System.Drawing.Size(230, 20);
            this.textBoxDoctor_KAE.TabIndex = 11;
            // 
            // labelDoctor_KAE
            // 
            this.labelDoctor_KAE.AutoSize = true;
            this.labelDoctor_KAE.Location = new System.Drawing.Point(3, 199);
            this.labelDoctor_KAE.Name = "labelDoctor_KAE";
            this.labelDoctor_KAE.Size = new System.Drawing.Size(79, 13);
            this.labelDoctor_KAE.TabIndex = 10;
            this.labelDoctor_KAE.Text = "Лечащий врач";
            // 
            // textBoxDisease_KAE
            // 
            this.textBoxDisease_KAE.Location = new System.Drawing.Point(3, 176);
            this.textBoxDisease_KAE.Name = "textBoxDisease_KAE";
            this.textBoxDisease_KAE.Size = new System.Drawing.Size(230, 20);
            this.textBoxDisease_KAE.TabIndex = 9;
            // 
            // labelDisease_KAE
            // 
            this.labelDisease_KAE.AutoSize = true;
            this.labelDisease_KAE.Location = new System.Drawing.Point(3, 160);
            this.labelDisease_KAE.Name = "labelDisease_KAE";
            this.labelDisease_KAE.Size = new System.Drawing.Size(51, 13);
            this.labelDisease_KAE.TabIndex = 8;
            this.labelDisease_KAE.Text = "Диагноз";
            // 
            // textBoxAge_KAE
            // 
            this.textBoxAge_KAE.Location = new System.Drawing.Point(3, 137);
            this.textBoxAge_KAE.Name = "textBoxAge_KAE";
            this.textBoxAge_KAE.Size = new System.Drawing.Size(230, 20);
            this.textBoxAge_KAE.TabIndex = 7;
            // 
            // labelAge_KAE
            // 
            this.labelAge_KAE.AutoSize = true;
            this.labelAge_KAE.Location = new System.Drawing.Point(3, 121);
            this.labelAge_KAE.Name = "labelAge_KAE";
            this.labelAge_KAE.Size = new System.Drawing.Size(49, 13);
            this.labelAge_KAE.TabIndex = 6;
            this.labelAge_KAE.Text = "Возраст";
            // 
            // textBoxMName_KAE
            // 
            this.textBoxMName_KAE.Location = new System.Drawing.Point(3, 98);
            this.textBoxMName_KAE.Name = "textBoxMName_KAE";
            this.textBoxMName_KAE.Size = new System.Drawing.Size(230, 20);
            this.textBoxMName_KAE.TabIndex = 5;
            // 
            // labelMName_KAE
            // 
            this.labelMName_KAE.AutoSize = true;
            this.labelMName_KAE.Location = new System.Drawing.Point(3, 82);
            this.labelMName_KAE.Name = "labelMName_KAE";
            this.labelMName_KAE.Size = new System.Drawing.Size(54, 13);
            this.labelMName_KAE.TabIndex = 4;
            this.labelMName_KAE.Text = "Отчество";
            // 
            // labelLName_KAE
            // 
            this.labelLName_KAE.AutoSize = true;
            this.labelLName_KAE.Location = new System.Drawing.Point(3, 43);
            this.labelLName_KAE.Name = "labelLName_KAE";
            this.labelLName_KAE.Size = new System.Drawing.Size(56, 13);
            this.labelLName_KAE.TabIndex = 3;
            this.labelLName_KAE.Text = "Фамилия";
            // 
            // textBoxLName_KAE
            // 
            this.textBoxLName_KAE.Location = new System.Drawing.Point(3, 59);
            this.textBoxLName_KAE.Name = "textBoxLName_KAE";
            this.textBoxLName_KAE.Size = new System.Drawing.Size(230, 20);
            this.textBoxLName_KAE.TabIndex = 2;
            // 
            // labelFName_KAE
            // 
            this.labelFName_KAE.AutoSize = true;
            this.labelFName_KAE.Location = new System.Drawing.Point(3, 4);
            this.labelFName_KAE.Name = "labelFName_KAE";
            this.labelFName_KAE.Size = new System.Drawing.Size(29, 13);
            this.labelFName_KAE.TabIndex = 1;
            this.labelFName_KAE.Text = "Имя";
            // 
            // textBoxFName_KAE
            // 
            this.textBoxFName_KAE.Location = new System.Drawing.Point(3, 20);
            this.textBoxFName_KAE.Name = "textBoxFName_KAE";
            this.textBoxFName_KAE.Size = new System.Drawing.Size(230, 20);
            this.textBoxFName_KAE.TabIndex = 0;
            // 
            // buttonDelete_KAE
            // 
            this.buttonDelete_KAE.Enabled = false;
            this.buttonDelete_KAE.Location = new System.Drawing.Point(165, 96);
            this.buttonDelete_KAE.Name = "buttonDelete_KAE";
            this.buttonDelete_KAE.Size = new System.Drawing.Size(75, 37);
            this.buttonDelete_KAE.TabIndex = 1;
            this.buttonDelete_KAE.Text = "Удалить";
            this.toolTip_KAE.SetToolTip(this.buttonDelete_KAE, "Удаляет выбранную строку с пацентом\r\n");
            this.buttonDelete_KAE.UseVisualStyleBackColor = true;
            this.buttonDelete_KAE.Click += new System.EventHandler(this.buttonDelete_KAE_Click);
            // 
            // buttonAdd_KAE
            // 
            this.buttonAdd_KAE.Location = new System.Drawing.Point(3, 3);
            this.buttonAdd_KAE.Name = "buttonAdd_KAE";
            this.buttonAdd_KAE.Size = new System.Drawing.Size(75, 37);
            this.buttonAdd_KAE.TabIndex = 0;
            this.buttonAdd_KAE.Text = "Добавить";
            this.toolTip_KAE.SetToolTip(this.buttonAdd_KAE, "Добавляет строку в CSV файл с данными пациента\r\n");
            this.buttonAdd_KAE.UseVisualStyleBackColor = true;
            this.buttonAdd_KAE.Click += new System.EventHandler(this.buttonAdd_KAE_Click);
            // 
            // panelInfo_KAE
            // 
            this.panelInfo_KAE.Controls.Add(this.textBoxInfo_KAE);
            this.panelInfo_KAE.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo_KAE.Location = new System.Drawing.Point(242, 0);
            this.panelInfo_KAE.Name = "panelInfo_KAE";
            this.panelInfo_KAE.Size = new System.Drawing.Size(763, 40);
            this.panelInfo_KAE.TabIndex = 1;
            // 
            // textBoxInfo_KAE
            // 
            this.textBoxInfo_KAE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInfo_KAE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo_KAE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInfo_KAE.Location = new System.Drawing.Point(6, 13);
            this.textBoxInfo_KAE.Name = "textBoxInfo_KAE";
            this.textBoxInfo_KAE.ReadOnly = true;
            this.textBoxInfo_KAE.Size = new System.Drawing.Size(746, 19);
            this.textBoxInfo_KAE.TabIndex = 0;
            // 
            // dataGridView_KAE
            // 
            this.dataGridView_KAE.AllowUserToAddRows = false;
            this.dataGridView_KAE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_KAE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_KAE.Location = new System.Drawing.Point(242, 40);
            this.dataGridView_KAE.Name = "dataGridView_KAE";
            this.dataGridView_KAE.ReadOnly = true;
            this.dataGridView_KAE.Size = new System.Drawing.Size(763, 489);
            this.dataGridView_KAE.TabIndex = 2;
            this.dataGridView_KAE.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_KAE_CellEnter);
            // 
            // openFileDialog_KAE
            // 
            this.openFileDialog_KAE.Filter = "Файлы CSV|*.csv";
            // 
            // buttonFrequency_KAE
            // 
            this.buttonFrequency_KAE.Location = new System.Drawing.Point(3, 46);
            this.buttonFrequency_KAE.Name = "buttonFrequency_KAE";
            this.buttonFrequency_KAE.Size = new System.Drawing.Size(75, 37);
            this.buttonFrequency_KAE.TabIndex = 8;
            this.buttonFrequency_KAE.Text = "Статистика";
            this.toolTip_KAE.SetToolTip(this.buttonFrequency_KAE, "Выводит статистику данных\r\n");
            this.buttonFrequency_KAE.UseVisualStyleBackColor = true;
            this.buttonFrequency_KAE.Click += new System.EventHandler(this.buttonFrequency_KAE_Click);
            // 
            // buttonInfo_KAE
            // 
            this.buttonInfo_KAE.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_KAE.Image")));
            this.buttonInfo_KAE.Location = new System.Drawing.Point(3, 89);
            this.buttonInfo_KAE.Name = "buttonInfo_KAE";
            this.buttonInfo_KAE.Size = new System.Drawing.Size(52, 44);
            this.buttonInfo_KAE.TabIndex = 9;
            this.toolTip_KAE.SetToolTip(this.buttonInfo_KAE, "Информация о программе");
            this.buttonInfo_KAE.UseVisualStyleBackColor = true;
            this.buttonInfo_KAE.Click += new System.EventHandler(this.buttonInfo_KAE_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 529);
            this.Controls.Add(this.dataGridView_KAE);
            this.Controls.Add(this.panelInfo_KAE);
            this.Controls.Add(this.panelMenu_KAE);
            this.MinimumSize = new System.Drawing.Size(1021, 568);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База Данных Поликлинники";
            this.panelMenu_KAE.ResumeLayout(false);
            this.groupBoxFilter_KAE.ResumeLayout(false);
            this.groupBoxFilter_KAE.PerformLayout();
            this.groupBoxEnterData_KAE.ResumeLayout(false);
            this.panelEnterData_KAE.ResumeLayout(false);
            this.panelEnterData_KAE.PerformLayout();
            this.panelInfo_KAE.ResumeLayout(false);
            this.panelInfo_KAE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KAE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu_KAE;
        private System.Windows.Forms.Button buttonDelete_KAE;
        private System.Windows.Forms.Button buttonAdd_KAE;
        private System.Windows.Forms.GroupBox groupBoxEnterData_KAE;
        private System.Windows.Forms.Panel panelEnterData_KAE;
        private System.Windows.Forms.TextBox textBoxDoctor_KAE;
        private System.Windows.Forms.Label labelDoctor_KAE;
        private System.Windows.Forms.TextBox textBoxDisease_KAE;
        private System.Windows.Forms.Label labelDisease_KAE;
        private System.Windows.Forms.TextBox textBoxAge_KAE;
        private System.Windows.Forms.Label labelAge_KAE;
        private System.Windows.Forms.TextBox textBoxMName_KAE;
        private System.Windows.Forms.Label labelMName_KAE;
        private System.Windows.Forms.Label labelLName_KAE;
        private System.Windows.Forms.TextBox textBoxLName_KAE;
        private System.Windows.Forms.Label labelFName_KAE;
        private System.Windows.Forms.TextBox textBoxFName_KAE;
        private System.Windows.Forms.TextBox textBoxPhoneNumber_KAE;
        private System.Windows.Forms.Label labelPhoneNumber_KAE;
        private System.Windows.Forms.Panel panelInfo_KAE;
        private System.Windows.Forms.DataGridView dataGridView_KAE;
        private System.Windows.Forms.TextBox textBoxInfo_KAE;
        private System.Windows.Forms.Button buttonChangePath_KAE;
        private System.Windows.Forms.OpenFileDialog openFileDialog_KAE;
        private System.Windows.Forms.ToolTip toolTip_KAE;
        private System.Windows.Forms.GroupBox groupBoxFilter_KAE;
        private System.Windows.Forms.Button buttonFilter_KAE;
        private System.Windows.Forms.TextBox textBoxFilter_KAE;
        private System.Windows.Forms.Button buttonReturnDefault_KAE;
        private System.Windows.Forms.Button buttonChange_KAE;
        private System.Windows.Forms.Button buttonFrequency_KAE;
        private System.Windows.Forms.Button buttonInfo_KAE;
    }
}

