namespace WinFormsApp3
{
    partial class Form3
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
            btn3 = new Button();
            btnR = new Button();
            panel1 = new Panel();
            lstArac = new ListBox();
            blArac = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn3
            // 
            btn3.Location = new Point(12, 43);
            btn3.Name = "btn3";
            btn3.Size = new Size(352, 29);
            btn3.TabIndex = 0;
            btn3.Text = "Son elemanı Göster";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btnR
            // 
            btnR.Location = new Point(12, 97);
            btnR.Name = "btnR";
            btnR.Size = new Size(352, 29);
            btnR.TabIndex = 1;
            btnR.Text = "RastgeleEleman";
            btnR.UseVisualStyleBackColor = true;
            btnR.Click += btnR_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lstArac);
            panel1.Controls.Add(blArac);
            panel1.Location = new Point(410, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(378, 426);
            panel1.TabIndex = 2;
            // 
            // lstArac
            // 
            lstArac.FormattingEnabled = true;
            lstArac.Location = new Point(0, 65);
            lstArac.Name = "lstArac";
            lstArac.Size = new Size(375, 364);
            lstArac.TabIndex = 1;
            // 
            // blArac
            // 
            blArac.Location = new Point(19, 17);
            blArac.Name = "blArac";
            blArac.Size = new Size(94, 29);
            blArac.TabIndex = 0;
            blArac.Text = "Araç Ekle";
            blArac.UseVisualStyleBackColor = true;
            blArac.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(btnR);
            Controls.Add(btn3);
            Name = "Form3";
            Text = "Form3";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn3;
        private Button btnR;
        private Panel panel1;
        private ListBox lstArac;
        private Button blArac;
    }
}