namespace Laboratoire12_2
{
    partial class CreditApp
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
            btnEmprunter = new Button();
            btnRembourser = new Button();
            btnAjouterInterets = new Button();
            groupBox1 = new GroupBox();
            txtAvantage = new TextBox();
            label5 = new Label();
            txtTaux = new TextBox();
            label4 = new Label();
            txtLimite = new TextBox();
            txtSolde = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtMontant = new TextBox();
            label1 = new Label();
            lstCartes = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEmprunter
            // 
            btnEmprunter.Location = new Point(6, 54);
            btnEmprunter.Name = "btnEmprunter";
            btnEmprunter.Size = new Size(276, 23);
            btnEmprunter.TabIndex = 2;
            btnEmprunter.Text = "Emprunter";
            btnEmprunter.UseVisualStyleBackColor = true;
            btnEmprunter.Click += btnEmprunter_Click;
            // 
            // btnRembourser
            // 
            btnRembourser.Location = new Point(6, 83);
            btnRembourser.Name = "btnRembourser";
            btnRembourser.Size = new Size(276, 23);
            btnRembourser.TabIndex = 3;
            btnRembourser.Text = "Rembourser";
            btnRembourser.UseVisualStyleBackColor = true;
            btnRembourser.Click += btnRembourser_Click;
            // 
            // btnAjouterInterets
            // 
            btnAjouterInterets.Location = new Point(6, 112);
            btnAjouterInterets.Name = "btnAjouterInterets";
            btnAjouterInterets.Size = new Size(276, 23);
            btnAjouterInterets.TabIndex = 4;
            btnAjouterInterets.Text = "Ajouter Intérêts";
            btnAjouterInterets.UseVisualStyleBackColor = true;
            btnAjouterInterets.Click += btnAjouterInterets_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAvantage);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTaux);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtLimite);
            groupBox1.Controls.Add(txtSolde);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMontant);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnEmprunter);
            groupBox1.Controls.Add(btnAjouterInterets);
            groupBox1.Controls.Add(btnRembourser);
            groupBox1.Location = new Point(135, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(288, 264);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opérations de Carte";
            // 
            // txtAvantage
            // 
            txtAvantage.Location = new Point(69, 234);
            txtAvantage.Name = "txtAvantage";
            txtAvantage.ReadOnly = true;
            txtAvantage.Size = new Size(213, 23);
            txtAvantage.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 237);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 13;
            label5.Text = "Avantage";
            // 
            // txtTaux
            // 
            txtTaux.Location = new Point(69, 145);
            txtTaux.Name = "txtTaux";
            txtTaux.ReadOnly = true;
            txtTaux.Size = new Size(213, 23);
            txtTaux.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 151);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 11;
            label4.Text = "Taux";
            // 
            // txtLimite
            // 
            txtLimite.Location = new Point(69, 203);
            txtLimite.Name = "txtLimite";
            txtLimite.ReadOnly = true;
            txtLimite.Size = new Size(213, 23);
            txtLimite.TabIndex = 10;
            // 
            // txtSolde
            // 
            txtSolde.Location = new Point(69, 174);
            txtSolde.Name = "txtSolde";
            txtSolde.ReadOnly = true;
            txtSolde.Size = new Size(213, 23);
            txtSolde.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 206);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 8;
            label3.Text = "Limite";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 180);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 7;
            label2.Text = "Solde";
            // 
            // txtMontant
            // 
            txtMontant.Location = new Point(61, 25);
            txtMontant.Name = "txtMontant";
            txtMontant.Size = new Size(221, 23);
            txtMontant.TabIndex = 6;
            txtMontant.Text = "100";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 5;
            label1.Text = "Montant";
            // 
            // lstCartes
            // 
            lstCartes.FormattingEnabled = true;
            lstCartes.ItemHeight = 15;
            lstCartes.Location = new Point(12, 17);
            lstCartes.Name = "lstCartes";
            lstCartes.Size = new Size(117, 259);
            lstCartes.TabIndex = 6;
            lstCartes.SelectedIndexChanged += lstCartes_SelectedIndexChanged;
            // 
            // CreditApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 293);
            Controls.Add(lstCartes);
            Controls.Add(groupBox1);
            Name = "CreditApp";
            Text = "Credit App";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEmprunter;
        private Button btnRembourser;
        private Button btnAjouterInterets;
        private GroupBox groupBox1;
        private Label label1;
        private ListBox lstCartes;
        private TextBox txtMontant;
        private Label label3;
        private Label label2;
        private TextBox txtLimite;
        private TextBox txtSolde;
        private TextBox txtTaux;
        private Label label4;
        private TextBox txtAvantage;
        private Label label5;
    }
}
