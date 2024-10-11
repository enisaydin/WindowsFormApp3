namespace WinFormsApp3
{
    partial class Form6
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
            btnButonEkle = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // btnButonEkle
            // 
            btnButonEkle.Location = new Point(95, 62);
            btnButonEkle.Name = "btnButonEkle";
            btnButonEkle.Size = new Size(94, 29);
            btnButonEkle.TabIndex = 0;
            btnButonEkle.Text = "Buton ekle";
            btnButonEkle.UseVisualStyleBackColor = true;
            btnButonEkle.Click += btnButonEkle_Click;
            // 
            // button2
            // 
            button2.Location = new Point(280, 61);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(btnButonEkle);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
        }

        #endregion

        private Button btnButonEkle;
        private Button button2;
    }
}