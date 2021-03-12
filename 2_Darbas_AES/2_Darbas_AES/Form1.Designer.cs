
namespace _2_Darbas_AES
{
    partial class Form1
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
            this.FailoSkaitymas_btn = new System.Windows.Forms.Button();
            this.FailoIrasymas_btn = new System.Windows.Forms.Button();
            this.CBC_rbtn = new System.Windows.Forms.RadioButton();
            this.ECB_rbtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Raktas_txt = new System.Windows.Forms.TextBox();
            this.Desifravimo_btn = new System.Windows.Forms.Button();
            this.Sifravimo_btn = new System.Windows.Forms.Button();
            this.STekstas_txt = new System.Windows.Forms.TextBox();
            this.Teksats_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FailoSkaitymas_btn
            // 
            this.FailoSkaitymas_btn.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FailoSkaitymas_btn.Location = new System.Drawing.Point(305, 45);
            this.FailoSkaitymas_btn.Name = "FailoSkaitymas_btn";
            this.FailoSkaitymas_btn.Size = new System.Drawing.Size(287, 42);
            this.FailoSkaitymas_btn.TabIndex = 21;
            this.FailoSkaitymas_btn.Text = "Dešifruoti failo teksta";
            this.FailoSkaitymas_btn.UseVisualStyleBackColor = true;
            this.FailoSkaitymas_btn.Click += new System.EventHandler(this.FailoSkaitymas_btn_Click);
            // 
            // FailoIrasymas_btn
            // 
            this.FailoIrasymas_btn.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FailoIrasymas_btn.Location = new System.Drawing.Point(13, 45);
            this.FailoIrasymas_btn.Name = "FailoIrasymas_btn";
            this.FailoIrasymas_btn.Size = new System.Drawing.Size(286, 42);
            this.FailoIrasymas_btn.TabIndex = 20;
            this.FailoIrasymas_btn.Text = "Šifruoti failo teksta";
            this.FailoIrasymas_btn.UseVisualStyleBackColor = true;
            this.FailoIrasymas_btn.Click += new System.EventHandler(this.FailoIrasymas_btn_Click);
            // 
            // CBC_rbtn
            // 
            this.CBC_rbtn.AutoSize = true;
            this.CBC_rbtn.Location = new System.Drawing.Point(357, 19);
            this.CBC_rbtn.Name = "CBC_rbtn";
            this.CBC_rbtn.Size = new System.Drawing.Size(46, 17);
            this.CBC_rbtn.TabIndex = 19;
            this.CBC_rbtn.TabStop = true;
            this.CBC_rbtn.Text = "CBC";
            this.CBC_rbtn.UseVisualStyleBackColor = true;
            // 
            // ECB_rbtn
            // 
            this.ECB_rbtn.AutoSize = true;
            this.ECB_rbtn.Location = new System.Drawing.Point(305, 19);
            this.ECB_rbtn.Name = "ECB_rbtn";
            this.ECB_rbtn.Size = new System.Drawing.Size(46, 17);
            this.ECB_rbtn.TabIndex = 18;
            this.ECB_rbtn.TabStop = true;
            this.ECB_rbtn.Text = "ECB";
            this.ECB_rbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Raktas:";
            // 
            // Raktas_txt
            // 
            this.Raktas_txt.Location = new System.Drawing.Point(93, 16);
            this.Raktas_txt.Name = "Raktas_txt";
            this.Raktas_txt.Size = new System.Drawing.Size(206, 20);
            this.Raktas_txt.TabIndex = 12;
            this.Raktas_txt.Text = "raktasraktasrakt";
            // 
            // Desifravimo_btn
            // 
            this.Desifravimo_btn.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desifravimo_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Desifravimo_btn.Location = new System.Drawing.Point(305, 93);
            this.Desifravimo_btn.Name = "Desifravimo_btn";
            this.Desifravimo_btn.Size = new System.Drawing.Size(287, 62);
            this.Desifravimo_btn.TabIndex = 16;
            this.Desifravimo_btn.Text = "Dešifruoti";
            this.Desifravimo_btn.UseVisualStyleBackColor = true;
            this.Desifravimo_btn.Click += new System.EventHandler(this.Desifravimo_btn_Click);
            // 
            // Sifravimo_btn
            // 
            this.Sifravimo_btn.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sifravimo_btn.Location = new System.Drawing.Point(13, 93);
            this.Sifravimo_btn.Name = "Sifravimo_btn";
            this.Sifravimo_btn.Size = new System.Drawing.Size(286, 62);
            this.Sifravimo_btn.TabIndex = 15;
            this.Sifravimo_btn.Text = "Šifruoti";
            this.Sifravimo_btn.UseVisualStyleBackColor = true;
            this.Sifravimo_btn.Click += new System.EventHandler(this.Sifravimo_btn_Click);
            // 
            // STekstas_txt
            // 
            this.STekstas_txt.Location = new System.Drawing.Point(305, 161);
            this.STekstas_txt.Multiline = true;
            this.STekstas_txt.Name = "STekstas_txt";
            this.STekstas_txt.Size = new System.Drawing.Size(287, 312);
            this.STekstas_txt.TabIndex = 13;
            // 
            // Teksats_txt
            // 
            this.Teksats_txt.Location = new System.Drawing.Point(12, 161);
            this.Teksats_txt.Multiline = true;
            this.Teksats_txt.Name = "Teksats_txt";
            this.Teksats_txt.Size = new System.Drawing.Size(287, 312);
            this.Teksats_txt.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 484);
            this.Controls.Add(this.FailoSkaitymas_btn);
            this.Controls.Add(this.FailoIrasymas_btn);
            this.Controls.Add(this.CBC_rbtn);
            this.Controls.Add(this.ECB_rbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Raktas_txt);
            this.Controls.Add(this.Desifravimo_btn);
            this.Controls.Add(this.Sifravimo_btn);
            this.Controls.Add(this.STekstas_txt);
            this.Controls.Add(this.Teksats_txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FailoSkaitymas_btn;
        private System.Windows.Forms.Button FailoIrasymas_btn;
        private System.Windows.Forms.RadioButton CBC_rbtn;
        private System.Windows.Forms.RadioButton ECB_rbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Raktas_txt;
        private System.Windows.Forms.Button Desifravimo_btn;
        private System.Windows.Forms.Button Sifravimo_btn;
        private System.Windows.Forms.TextBox STekstas_txt;
        private System.Windows.Forms.TextBox Teksats_txt;
    }
}

