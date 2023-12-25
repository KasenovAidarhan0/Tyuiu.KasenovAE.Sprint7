
namespace Tyuiu.KasenovAE.Sprint7.Project.V6
{
    partial class FormInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            this.label_KAE = new System.Windows.Forms.Label();
            this.pictureBox_KAE = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_KAE)).BeginInit();
            this.SuspendLayout();
            // 
            // label_KAE
            // 
            this.label_KAE.AutoSize = true;
            this.label_KAE.Location = new System.Drawing.Point(12, 9);
            this.label_KAE.Name = "label_KAE";
            this.label_KAE.Size = new System.Drawing.Size(221, 91);
            this.label_KAE.TabIndex = 0;
            this.label_KAE.Text = "Подготовил Касенов Айдархан Есенаевич\r\n\r\nПКТб-23-2\r\n\r\nТИУ ВШЦТ\r\n\r\nСпринт 7 Разраб" +
    "отка Учебного Проекта\r\n";
            // 
            // pictureBox_KAE
            // 
            this.pictureBox_KAE.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_KAE.Image")));
            this.pictureBox_KAE.Location = new System.Drawing.Point(280, 39);
            this.pictureBox_KAE.Name = "pictureBox_KAE";
            this.pictureBox_KAE.Size = new System.Drawing.Size(34, 34);
            this.pictureBox_KAE.TabIndex = 1;
            this.pictureBox_KAE.TabStop = false;
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 114);
            this.Controls.Add(this.pictureBox_KAE);
            this.Controls.Add(this.label_KAE);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_KAE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_KAE;
        private System.Windows.Forms.PictureBox pictureBox_KAE;
    }
}