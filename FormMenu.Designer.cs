namespace Klassni_rukovodilel_
{
    partial class FormMenu
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
            this.buttonRuk = new System.Windows.Forms.Button();
            this.buttonStud = new System.Windows.Forms.Button();
            this.buttonVneur = new System.Windows.Forms.Button();
            this.buttonZhur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRuk
            // 
            this.buttonRuk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonRuk.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRuk.Location = new System.Drawing.Point(140, 91);
            this.buttonRuk.Name = "buttonRuk";
            this.buttonRuk.Size = new System.Drawing.Size(187, 73);
            this.buttonRuk.TabIndex = 16;
            this.buttonRuk.Text = "Классные руководители";
            this.buttonRuk.UseVisualStyleBackColor = false;
            this.buttonRuk.Click += new System.EventHandler(this.buttonRuk_Click);
            // 
            // buttonStud
            // 
            this.buttonStud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonStud.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStud.Location = new System.Drawing.Point(419, 91);
            this.buttonStud.Name = "buttonStud";
            this.buttonStud.Size = new System.Drawing.Size(187, 73);
            this.buttonStud.TabIndex = 18;
            this.buttonStud.Text = "Ученики";
            this.buttonStud.UseVisualStyleBackColor = false;
            this.buttonStud.Click += new System.EventHandler(this.buttonStud_Click);
            // 
            // buttonVneur
            // 
            this.buttonVneur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonVneur.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVneur.Location = new System.Drawing.Point(419, 265);
            this.buttonVneur.Name = "buttonVneur";
            this.buttonVneur.Size = new System.Drawing.Size(187, 73);
            this.buttonVneur.TabIndex = 24;
            this.buttonVneur.Text = "Внеурочная деятельность";
            this.buttonVneur.UseVisualStyleBackColor = false;
            // 
            // buttonZhur
            // 
            this.buttonZhur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonZhur.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonZhur.Location = new System.Drawing.Point(140, 265);
            this.buttonZhur.Name = "buttonZhur";
            this.buttonZhur.Size = new System.Drawing.Size(187, 73);
            this.buttonZhur.TabIndex = 25;
            this.buttonZhur.Text = "Журнал ТБ";
            this.buttonZhur.UseVisualStyleBackColor = false;
            this.buttonZhur.Click += new System.EventHandler(this.buttonZhur_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonZhur);
            this.Controls.Add(this.buttonVneur);
            this.Controls.Add(this.buttonStud);
            this.Controls.Add(this.buttonRuk);
            this.Name = "FormMenu";
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRuk;
        private System.Windows.Forms.Button buttonStud;
        private System.Windows.Forms.Button buttonVneur;
        private System.Windows.Forms.Button buttonZhur;
    }
}