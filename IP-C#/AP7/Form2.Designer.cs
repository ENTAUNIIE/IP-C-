namespace AP7
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
            label1 = new Label();
            label2 = new Label();
            tb_cidr2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            tb_masque_deci = new TextBox();
            tb_masque_bin = new TextBox();
            label5 = new Label();
            tb_adresse_RP = new TextBox();
            label6 = new Label();
            tb_nb_hote = new TextBox();
            label7 = new Label();
            tb_classIP = new TextBox();
            label8 = new Label();
            tb_SR = new TextBox();
            tb_nouvCIDR = new TextBox();
            label9 = new Label();
            bt_calc = new Button();
            bt_retour = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(303, 9);
            label1.Name = "label1";
            label1.Size = new Size(173, 20);
            label1.TabIndex = 0;
            label1.Text = "Masque de Sous-reseaux";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 93);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 1;
            label2.Text = "CIDR";
            // 
            // tb_cidr2
            // 
            tb_cidr2.Enabled = false;
            tb_cidr2.Location = new Point(93, 93);
            tb_cidr2.Name = "tb_cidr2";
            tb_cidr2.ReadOnly = true;
            tb_cidr2.Size = new Size(88, 27);
            tb_cidr2.TabIndex = 2;
            tb_cidr2.TextChanged += tb_cidr2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(210, 93);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 3;
            label3.Text = "Décimal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(443, 93);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 4;
            label4.Text = "Binaire";
            // 
            // tb_masque_deci
            // 
            tb_masque_deci.Location = new Point(291, 90);
            tb_masque_deci.Name = "tb_masque_deci";
            tb_masque_deci.ReadOnly = true;
            tb_masque_deci.Size = new Size(125, 27);
            tb_masque_deci.TabIndex = 5;
            // 
            // tb_masque_bin
            // 
            tb_masque_bin.Location = new Point(504, 93);
            tb_masque_bin.Name = "tb_masque_bin";
            tb_masque_bin.ReadOnly = true;
            tb_masque_bin.Size = new Size(271, 27);
            tb_masque_bin.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 202);
            label5.Name = "label5";
            label5.Size = new Size(173, 20);
            label5.TabIndex = 7;
            label5.Text = "Adresse Réseau Principal";
            // 
            // tb_adresse_RP
            // 
            tb_adresse_RP.Location = new Point(200, 199);
            tb_adresse_RP.Name = "tb_adresse_RP";
            tb_adresse_RP.ReadOnly = true;
            tb_adresse_RP.Size = new Size(186, 27);
            tb_adresse_RP.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(392, 205);
            label6.Name = "label6";
            label6.Size = new Size(116, 20);
            label6.TabIndex = 9;
            label6.Text = "Nombre d'hôtes";
            // 
            // tb_nb_hote
            // 
            tb_nb_hote.Location = new Point(514, 202);
            tb_nb_hote.Name = "tb_nb_hote";
            tb_nb_hote.ReadOnly = true;
            tb_nb_hote.Size = new Size(72, 27);
            tb_nb_hote.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(604, 199);
            label7.Name = "label7";
            label7.Size = new Size(86, 20);
            label7.TabIndex = 11;
            label7.Text = "Class de l'IP";
            // 
            // tb_classIP
            // 
            tb_classIP.Location = new Point(696, 199);
            tb_classIP.Name = "tb_classIP";
            tb_classIP.ReadOnly = true;
            tb_classIP.Size = new Size(40, 27);
            tb_classIP.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(12, 291);
            label8.Name = "label8";
            label8.Size = new Size(240, 20);
            label8.TabIndex = 13;
            label8.Text = "Nombre de Sous Réseaux Souhaité";
            // 
            // tb_SR
            // 
            tb_SR.Location = new Point(269, 291);
            tb_SR.Name = "tb_SR";
            tb_SR.Size = new Size(64, 27);
            tb_SR.TabIndex = 14;
            // 
            // tb_nouvCIDR
            // 
            tb_nouvCIDR.Location = new Point(631, 298);
            tb_nouvCIDR.Name = "tb_nouvCIDR";
            tb_nouvCIDR.ReadOnly = true;
            tb_nouvCIDR.Size = new Size(59, 27);
            tb_nouvCIDR.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(504, 298);
            label9.Name = "label9";
            label9.Size = new Size(105, 20);
            label9.TabIndex = 16;
            label9.Text = "Nouveau CIDR";
            // 
            // bt_calc
            // 
            bt_calc.Location = new Point(354, 291);
            bt_calc.Name = "bt_calc";
            bt_calc.Size = new Size(122, 34);
            bt_calc.TabIndex = 17;
            bt_calc.Text = "Calculer";
            bt_calc.UseVisualStyleBackColor = true;
            bt_calc.Click += bt_calc_Click;
            // 
            // bt_retour
            // 
            bt_retour.Location = new Point(25, 400);
            bt_retour.Name = "bt_retour";
            bt_retour.Size = new Size(161, 33);
            bt_retour.TabIndex = 18;
            bt_retour.Text = "Retour";
            bt_retour.UseVisualStyleBackColor = true;
            bt_retour.Click += bt_retour_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_retour);
            Controls.Add(bt_calc);
            Controls.Add(label9);
            Controls.Add(tb_nouvCIDR);
            Controls.Add(tb_SR);
            Controls.Add(label8);
            Controls.Add(tb_classIP);
            Controls.Add(label7);
            Controls.Add(tb_nb_hote);
            Controls.Add(label6);
            Controls.Add(tb_adresse_RP);
            Controls.Add(label5);
            Controls.Add(tb_masque_bin);
            Controls.Add(tb_masque_deci);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tb_cidr2);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_cidr2;
        private Label label3;
        private Label label4;
        private TextBox tb_masque_deci;
        private TextBox tb_masque_bin;
        private Label label5;
        private TextBox tb_adresse_RP;
        private Label label6;
        private TextBox tb_nb_hote;
        private Label label7;
        private TextBox tb_classIP;
        private Label label8;
        private TextBox tb_SR;
        private TextBox tb_nouvCIDR;
        private Label label9;
        private Button bt_calc;
        private Button bt_retour;
    }
}