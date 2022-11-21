namespace AP3_GestionHackathon
{
    partial class FormGestionEquipes
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
            this.cbEquipes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpInscription = new System.Windows.Forms.DateTimePicker();
            this.cbInscription = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMdp = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbProto = new System.Windows.Forms.TextBox();
            this.BtnAction = new System.Windows.Forms.Button();
            this.BtnFermer = new System.Windows.Forms.Button();
            this.BSequipes = new System.Windows.Forms.BindingSource(this.components);
            this.BShackathons = new System.Windows.Forms.BindingSource(this.components);
            this.nudJoueursMax = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BSequipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BShackathons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJoueursMax)).BeginInit();
            this.SuspendLayout();
            // 
            // cbEquipes
            // 
            this.cbEquipes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEquipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEquipes.FormattingEnabled = true;
            this.cbEquipes.Location = new System.Drawing.Point(301, 15);
            this.cbEquipes.Name = "cbEquipes";
            this.cbEquipes.Size = new System.Drawing.Size(455, 24);
            this.cbEquipes.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(24, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Ajout d\'une Equipe";
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.label8);
            this.gbInfo.Controls.Add(this.nudJoueursMax);
            this.gbInfo.Controls.Add(this.label7);
            this.gbInfo.Controls.Add(this.label6);
            this.gbInfo.Controls.Add(this.dtpInscription);
            this.gbInfo.Controls.Add(this.cbInscription);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Controls.Add(this.tbMdp);
            this.gbInfo.Controls.Add(this.tbNom);
            this.gbInfo.Controls.Add(this.tbLogin);
            this.gbInfo.Controls.Add(this.tbProto);
            this.gbInfo.Controls.Add(this.BtnAction);
            this.gbInfo.ForeColor = System.Drawing.Color.White;
            this.gbInfo.Location = new System.Drawing.Point(28, 57);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(728, 275);
            this.gbInfo.TabIndex = 30;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Informations de l\'équipe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(302, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Hackathon inscrit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(302, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Date d\'inscription";
            // 
            // dtpInscription
            // 
            this.dtpInscription.Location = new System.Drawing.Point(305, 205);
            this.dtpInscription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpInscription.Name = "dtpInscription";
            this.dtpInscription.Size = new System.Drawing.Size(199, 20);
            this.dtpInscription.TabIndex = 34;
            // 
            // cbInscription
            // 
            this.cbInscription.FormattingEnabled = true;
            this.cbInscription.Location = new System.Drawing.Point(305, 66);
            this.cbInscription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbInscription.Name = "cbInscription";
            this.cbInscription.Size = new System.Drawing.Size(199, 21);
            this.cbInscription.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Nom de l\'équipe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Lien du prototype";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Login de l\'équipe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Mot de passe de l\'équipe";
            // 
            // tbMdp
            // 
            this.tbMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMdp.Location = new System.Drawing.Point(305, 140);
            this.tbMdp.Name = "tbMdp";
            this.tbMdp.Size = new System.Drawing.Size(199, 22);
            this.tbMdp.TabIndex = 29;
            // 
            // tbNom
            // 
            this.tbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNom.Location = new System.Drawing.Point(47, 64);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(199, 22);
            this.tbNom.TabIndex = 28;
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLogin.Location = new System.Drawing.Point(47, 137);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(199, 22);
            this.tbLogin.TabIndex = 27;
            // 
            // tbProto
            // 
            this.tbProto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProto.Location = new System.Drawing.Point(47, 203);
            this.tbProto.Name = "tbProto";
            this.tbProto.Size = new System.Drawing.Size(199, 22);
            this.tbProto.TabIndex = 26;
            // 
            // BtnAction
            // 
            this.BtnAction.BackColor = System.Drawing.Color.Black;
            this.BtnAction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAction.Location = new System.Drawing.Point(617, 205);
            this.BtnAction.Name = "BtnAction";
            this.BtnAction.Size = new System.Drawing.Size(95, 51);
            this.BtnAction.TabIndex = 25;
            this.BtnAction.Text = "AJOUTER";
            this.BtnAction.UseVisualStyleBackColor = false;
            this.BtnAction.Click += new System.EventHandler(this.BtnAction_Click);
            // 
            // BtnFermer
            // 
            this.BtnFermer.BackColor = System.Drawing.Color.Black;
            this.BtnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFermer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnFermer.Location = new System.Drawing.Point(645, 338);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(95, 51);
            this.BtnFermer.TabIndex = 31;
            this.BtnFermer.Text = "FERMER";
            this.BtnFermer.UseVisualStyleBackColor = false;
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // BSequipes
            // 
            this.BSequipes.CurrentChanged += new System.EventHandler(this.BSequipes_CurrentChanged);
            // 
            // nudJoueursMax
            // 
            this.nudJoueursMax.Location = new System.Drawing.Point(617, 143);
            this.nudJoueursMax.Name = "nudJoueursMax";
            this.nudJoueursMax.Size = new System.Drawing.Size(95, 20);
            this.nudJoueursMax.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(614, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "Joueurs max";
            // 
            // FormGestionEquipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(776, 392);
            this.Controls.Add(this.BtnFermer);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEquipes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionEquipes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormGestionEquipes_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BSequipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BShackathons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJoueursMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbEquipes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Button BtnAction;
        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.TextBox tbMdp;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbProto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource BSequipes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpInscription;
        private System.Windows.Forms.ComboBox cbInscription;
        private System.Windows.Forms.BindingSource BShackathons;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudJoueursMax;
    }
}