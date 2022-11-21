namespace AP3_GestionHackathon
{
    partial class FormGestionMembre
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.dtpDnaiss = new System.Windows.Forms.DateTimePicker();
            this.cbEquipe = new System.Windows.Forms.ComboBox();
            this.lblEquipe = new System.Windows.Forms.Label();
            this.lblPortofolio = new System.Windows.Forms.Label();
            this.lblDnaiss = new System.Windows.Forms.Label();
            this.tbPortfolio = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.BtnAction = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.bsMembre = new System.Windows.Forms.BindingSource(this.components);
            this.bsEquipe = new System.Windows.Forms.BindingSource(this.components);
            this.cbMembres = new System.Windows.Forms.ComboBox();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMembre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEquipe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitre.Location = new System.Drawing.Point(32, 15);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(230, 29);
            this.lblTitre.TabIndex = 4;
            this.lblTitre.Text = "Ajout d\'un Membre";
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.dtpDnaiss);
            this.gbInfo.Controls.Add(this.cbEquipe);
            this.gbInfo.Controls.Add(this.lblEquipe);
            this.gbInfo.Controls.Add(this.lblPortofolio);
            this.gbInfo.Controls.Add(this.lblDnaiss);
            this.gbInfo.Controls.Add(this.tbPortfolio);
            this.gbInfo.Controls.Add(this.lblNom);
            this.gbInfo.Controls.Add(this.lblPrenom);
            this.gbInfo.Controls.Add(this.lblEmail);
            this.gbInfo.Controls.Add(this.lblTelephone);
            this.gbInfo.Controls.Add(this.tbEmail);
            this.gbInfo.Controls.Add(this.tbPrenom);
            this.gbInfo.Controls.Add(this.tbTelephone);
            this.gbInfo.Controls.Add(this.tbNom);
            this.gbInfo.Controls.Add(this.BtnAction);
            this.gbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.ForeColor = System.Drawing.Color.White;
            this.gbInfo.Location = new System.Drawing.Point(37, 70);
            this.gbInfo.Margin = new System.Windows.Forms.Padding(4);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Padding = new System.Windows.Forms.Padding(4);
            this.gbInfo.Size = new System.Drawing.Size(971, 338);
            this.gbInfo.TabIndex = 27;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Informations du membre";
            // 
            // dtpDnaiss
            // 
            this.dtpDnaiss.Location = new System.Drawing.Point(361, 252);
            this.dtpDnaiss.Name = "dtpDnaiss";
            this.dtpDnaiss.Size = new System.Drawing.Size(261, 26);
            this.dtpDnaiss.TabIndex = 45;
            // 
            // cbEquipe
            // 
            this.cbEquipe.FormattingEnabled = true;
            this.cbEquipe.Location = new System.Drawing.Point(684, 97);
            this.cbEquipe.Margin = new System.Windows.Forms.Padding(4);
            this.cbEquipe.Name = "cbEquipe";
            this.cbEquipe.Size = new System.Drawing.Size(264, 28);
            this.cbEquipe.TabIndex = 44;
            // 
            // lblEquipe
            // 
            this.lblEquipe.AutoSize = true;
            this.lblEquipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipe.Location = new System.Drawing.Point(680, 76);
            this.lblEquipe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEquipe.Name = "lblEquipe";
            this.lblEquipe.Size = new System.Drawing.Size(149, 20);
            this.lblEquipe.TabIndex = 43;
            this.lblEquipe.Text = "Equipe du membre";
            // 
            // lblPortofolio
            // 
            this.lblPortofolio.AutoSize = true;
            this.lblPortofolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortofolio.Location = new System.Drawing.Point(357, 155);
            this.lblPortofolio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPortofolio.Name = "lblPortofolio";
            this.lblPortofolio.Size = new System.Drawing.Size(129, 20);
            this.lblPortofolio.TabIndex = 42;
            this.lblPortofolio.Text = "Lien du portfolio";
            // 
            // lblDnaiss
            // 
            this.lblDnaiss.AutoSize = true;
            this.lblDnaiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDnaiss.Location = new System.Drawing.Point(357, 229);
            this.lblDnaiss.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDnaiss.Name = "lblDnaiss";
            this.lblDnaiss.Size = new System.Drawing.Size(149, 20);
            this.lblDnaiss.TabIndex = 41;
            this.lblDnaiss.Text = "Date de naissance";
            // 
            // tbPortfolio
            // 
            this.tbPortfolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPortfolio.Location = new System.Drawing.Point(361, 179);
            this.tbPortfolio.Margin = new System.Windows.Forms.Padding(4);
            this.tbPortfolio.Name = "tbPortfolio";
            this.tbPortfolio.Size = new System.Drawing.Size(264, 26);
            this.tbPortfolio.TabIndex = 39;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(35, 76);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(133, 20);
            this.lblNom.TabIndex = 37;
            this.lblNom.Text = "Nom du membre";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(357, 76);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(156, 20);
            this.lblPrenom.TabIndex = 36;
            this.lblPrenom.Text = "Prenom du membre";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(39, 155);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(116, 20);
            this.lblEmail.TabIndex = 35;
            this.lblEmail.Text = "Adresse email";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.Location = new System.Drawing.Point(35, 229);
            this.lblTelephone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(168, 20);
            this.lblTelephone.TabIndex = 34;
            this.lblTelephone.Text = "Numéro de téléphone";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(39, 178);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(264, 26);
            this.tbEmail.TabIndex = 32;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrenom.Location = new System.Drawing.Point(361, 100);
            this.tbPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(264, 26);
            this.tbPrenom.TabIndex = 31;
            // 
            // tbTelephone
            // 
            this.tbTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelephone.Location = new System.Drawing.Point(39, 252);
            this.tbTelephone.Margin = new System.Windows.Forms.Padding(4);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(264, 26);
            this.tbTelephone.TabIndex = 30;
            // 
            // tbNom
            // 
            this.tbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNom.Location = new System.Drawing.Point(39, 100);
            this.tbNom.Margin = new System.Windows.Forms.Padding(4);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(264, 26);
            this.tbNom.TabIndex = 29;
            // 
            // BtnAction
            // 
            this.BtnAction.BackColor = System.Drawing.Color.Black;
            this.BtnAction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAction.Location = new System.Drawing.Point(823, 252);
            this.BtnAction.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAction.Name = "BtnAction";
            this.BtnAction.Size = new System.Drawing.Size(127, 63);
            this.BtnAction.TabIndex = 24;
            this.BtnAction.Text = "AJOUTER";
            this.BtnAction.UseVisualStyleBackColor = false;
            this.BtnAction.Click += new System.EventHandler(this.BtnAction_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.Black;
            this.btnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFermer.Location = new System.Drawing.Point(860, 416);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(4);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(127, 63);
            this.btnFermer.TabIndex = 25;
            this.btnFermer.Text = "FERMER";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // bsMembre
            // 
            this.bsMembre.CurrentChanged += new System.EventHandler(this.bsMembre_CurrentChanged);
            // 
            // cbMembres
            // 
            this.cbMembres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMembres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMembres.FormattingEnabled = true;
            this.cbMembres.Location = new System.Drawing.Point(401, 18);
            this.cbMembres.Margin = new System.Windows.Forms.Padding(4);
            this.cbMembres.Name = "cbMembres";
            this.cbMembres.Size = new System.Drawing.Size(605, 28);
            this.cbMembres.TabIndex = 29;
            // 
            // FormGestionMembre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1035, 482);
            this.Controls.Add(this.cbMembres);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.lblTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormGestionMembre";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormGestionMembre_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMembre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEquipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Button BtnAction;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.TextBox tbPortfolio;
        private System.Windows.Forms.ComboBox cbEquipe;
        private System.Windows.Forms.Label lblEquipe;
        private System.Windows.Forms.Label lblPortofolio;
        private System.Windows.Forms.Label lblDnaiss;
        private System.Windows.Forms.BindingSource bsMembre;
        private System.Windows.Forms.BindingSource bsEquipe;
        private System.Windows.Forms.ComboBox cbMembres;
        private System.Windows.Forms.DateTimePicker dtpDnaiss;
    }
}