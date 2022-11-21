namespace AP3_GestionHackathon
{
    partial class FormConnexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConnexion));
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbMdp = new System.Windows.Forms.TextBox();
            this.emailbl = new System.Windows.Forms.Label();
            this.mdpLbl = new System.Windows.Forms.Label();
            this.ConnexionBtn = new System.Windows.Forms.Button();
            this.bsAdmin = new System.Windows.Forms.BindingSource(this.components);
            this.btnacces = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(308, 101);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(178, 20);
            this.tbEmail.TabIndex = 1;
            // 
            // tbMdp
            // 
            this.tbMdp.Location = new System.Drawing.Point(308, 211);
            this.tbMdp.Name = "tbMdp";
            this.tbMdp.PasswordChar = '*';
            this.tbMdp.Size = new System.Drawing.Size(178, 20);
            this.tbMdp.TabIndex = 2;
            // 
            // emailbl
            // 
            this.emailbl.AutoSize = true;
            this.emailbl.BackColor = System.Drawing.Color.Transparent;
            this.emailbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailbl.ForeColor = System.Drawing.Color.Red;
            this.emailbl.Location = new System.Drawing.Point(228, 108);
            this.emailbl.Name = "emailbl";
            this.emailbl.Size = new System.Drawing.Size(45, 13);
            this.emailbl.TabIndex = 3;
            this.emailbl.Text = "Email :";
            // 
            // mdpLbl
            // 
            this.mdpLbl.AutoSize = true;
            this.mdpLbl.BackColor = System.Drawing.Color.Transparent;
            this.mdpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdpLbl.ForeColor = System.Drawing.Color.Red;
            this.mdpLbl.Location = new System.Drawing.Point(182, 218);
            this.mdpLbl.Name = "mdpLbl";
            this.mdpLbl.Size = new System.Drawing.Size(91, 13);
            this.mdpLbl.TabIndex = 4;
            this.mdpLbl.Text = "Mot de passe :";
            // 
            // ConnexionBtn
            // 
            this.ConnexionBtn.Location = new System.Drawing.Point(352, 329);
            this.ConnexionBtn.Name = "ConnexionBtn";
            this.ConnexionBtn.Size = new System.Drawing.Size(75, 23);
            this.ConnexionBtn.TabIndex = 5;
            this.ConnexionBtn.Text = "Connexion";
            this.ConnexionBtn.UseVisualStyleBackColor = true;
            this.ConnexionBtn.Click += new System.EventHandler(this.ConnexionBtn_Click);
            // 
            // btnacces
            // 
            this.btnacces.Location = new System.Drawing.Point(62, 329);
            this.btnacces.Name = "btnacces";
            this.btnacces.Size = new System.Drawing.Size(75, 23);
            this.btnacces.TabIndex = 6;
            this.btnacces.Text = "WIP";
            this.btnacces.UseVisualStyleBackColor = true;
            this.btnacces.Click += new System.EventHandler(this.Btnacces_Click);
            // 
            // FormConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(789, 423);
            this.Controls.Add(this.btnacces);
            this.Controls.Add(this.ConnexionBtn);
            this.Controls.Add(this.mdpLbl);
            this.Controls.Add(this.emailbl);
            this.Controls.Add(this.tbMdp);
            this.Controls.Add(this.tbEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConnexion";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbMdp;
        private System.Windows.Forms.Label emailbl;
        private System.Windows.Forms.Label mdpLbl;
        private System.Windows.Forms.Button ConnexionBtn;
        private System.Windows.Forms.BindingSource bsAdmin;
        private System.Windows.Forms.Button btnacces;
    }
}