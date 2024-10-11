namespace WinFormsApp3
{
    partial class Form5
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
            btnEkle = new Button();
            btnSiralama = new Button();
            btnVarmi = new Button();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(197, 180);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(416, 29);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Şehir Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSiralama
            // 
            btnSiralama.Location = new Point(197, 297);
            btnSiralama.Name = "btnSiralama";
            btnSiralama.Size = new Size(416, 29);
            btnSiralama.TabIndex = 1;
            btnSiralama.Text = "Şehirleri Sırala";
            btnSiralama.UseVisualStyleBackColor = true;
            btnSiralama.Click += btnSiralama_Click;
            // 
            // btnVarmi
            // 
            btnVarmi.Location = new Point(197, 55);
            btnVarmi.Name = "btnVarmi";
            btnVarmi.Size = new Size(416, 29);
            btnVarmi.TabIndex = 2;
            btnVarmi.Text = "Şehir Var mı ?";
            btnVarmi.UseVisualStyleBackColor = true;
            btnVarmi.Click += btnVarmi_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVarmi);
            Controls.Add(btnSiralama);
            Controls.Add(btnEkle);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEkle;
        private Button btnSiralama;
        private Button btnVarmi;
    }
}