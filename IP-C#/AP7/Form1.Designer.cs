namespace AP7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tb_ip = new TextBox();
            bt_ip = new Button();
            label2 = new Label();
            tb_cidr = new TextBox();
            label3 = new Label();
            tb_binaire = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            bt_suivant = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // tb_ip
            // 
            tb_ip.Location = new Point(153, 53);
            tb_ip.Name = "tb_ip";
            tb_ip.Size = new Size(236, 27);
            tb_ip.TabIndex = 1;
            tb_ip.TextChanged += tb_ip_TextChanged;
            // 
            // bt_ip
            // 
            bt_ip.Enabled = false;
            bt_ip.Location = new Point(183, 165);
            bt_ip.Name = "bt_ip";
            bt_ip.Size = new Size(165, 39);
            bt_ip.TabIndex = 2;
            bt_ip.Text = "Valider";
            bt_ip.UseVisualStyleBackColor = true;
            bt_ip.Click += bt_ip_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 115);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 3;
            label2.Text = "Entrer CIDR";
            // 
            // tb_cidr
            // 
            tb_cidr.Location = new Point(153, 115);
            tb_cidr.Name = "tb_cidr";
            tb_cidr.Size = new Size(236, 27);
            tb_cidr.TabIndex = 4;
            tb_cidr.TextChanged += tb_cidr_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 230);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 5;
            label3.Text = "Adresse  en binaire";
            label3.Click += label3_Click;
            // 
            // tb_binaire
            // 
            tb_binaire.Location = new Point(153, 230);
            tb_binaire.Name = "tb_binaire";
            tb_binaire.ReadOnly = true;
            tb_binaire.Size = new Size(317, 27);
            tb_binaire.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(132, 36);
            label4.Name = "label4";
            label4.Size = new Size(15, 20);
            label4.TabIndex = 7;
            label4.Text = "*";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(102, 104);
            label5.Name = "label5";
            label5.Size = new Size(15, 20);
            label5.TabIndex = 8;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(3, 1);
            label6.Name = "label6";
            label6.Size = new Size(15, 20);
            label6.TabIndex = 9;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(24, 9);
            label7.Name = "label7";
            label7.Size = new Size(93, 12);
            label7.TabIndex = 10;
            label7.Text = ": Champ Obligatoire";
            // 
            // bt_suivant
            // 
            bt_suivant.Enabled = false;
            bt_suivant.Location = new Point(347, 279);
            bt_suivant.Name = "bt_suivant";
            bt_suivant.Size = new Size(123, 29);
            bt_suivant.TabIndex = 11;
            bt_suivant.Text = "Suivant";
            bt_suivant.UseVisualStyleBackColor = true;
            bt_suivant.Click += bt_suivant_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 0;
            label1.Text = "Entrer Adresse IP ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(482, 331);
            Controls.Add(label1);
            Controls.Add(bt_suivant);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tb_binaire);
            Controls.Add(label3);
            Controls.Add(tb_cidr);
            Controls.Add(label2);
            Controls.Add(bt_ip);
            Controls.Add(tb_ip);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tb_ip;
        private Button bt_ip;
        private Label label2;
        private TextBox tb_cidr;
        private Label label3;
        private TextBox tb_binaire;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button bt_suivant;
        private Label label1;
    }
}