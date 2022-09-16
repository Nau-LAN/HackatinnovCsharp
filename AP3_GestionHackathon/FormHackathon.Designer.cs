namespace AP3_GestionHackathon
{
    partial class FormHackathon
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvHackathon = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.voirLesÉquipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnFermer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BSHackathon = new System.Windows.Forms.BindingSource(this.components);
            this.BSEquipe = new System.Windows.Forms.BindingSource(this.components);
            this.dgvEquipes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHackathon)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BSHackathon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSEquipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHackathon
            // 
            this.dgvHackathon.AllowUserToAddRows = false;
            this.dgvHackathon.AllowUserToDeleteRows = false;
            this.dgvHackathon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHackathon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHackathon.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvHackathon.Location = new System.Drawing.Point(41, 46);
            this.dgvHackathon.MultiSelect = false;
            this.dgvHackathon.Name = "dgvHackathon";
            this.dgvHackathon.ReadOnly = true;
            this.dgvHackathon.Size = new System.Drawing.Size(706, 258);
            this.dgvHackathon.TabIndex = 0;
            this.dgvHackathon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHackathon_CellContentClick);
            this.dgvHackathon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHackathon_CellContentClick);
            this.dgvHackathon.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvHackathon_CellMouseClick);
            this.dgvHackathon.Click += new System.EventHandler(this.DgvHackathon_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voirLesÉquipesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 26);
            // 
            // voirLesÉquipesToolStripMenuItem
            // 
            this.voirLesÉquipesToolStripMenuItem.Name = "voirLesÉquipesToolStripMenuItem";
            this.voirLesÉquipesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.voirLesÉquipesToolStripMenuItem.Text = "Voir les équipes";
            this.voirLesÉquipesToolStripMenuItem.Click += new System.EventHandler(this.VoirLesÉquipesToolStripMenuItem_Click);
            // 
            // BtnFermer
            // 
            this.BtnFermer.BackColor = System.Drawing.Color.Black;
            this.BtnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFermer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnFermer.Location = new System.Drawing.Point(652, 310);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(95, 51);
            this.BtnFermer.TabIndex = 1;
            this.BtnFermer.Text = "FERMER";
            this.BtnFermer.UseVisualStyleBackColor = false;
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste des Hackathons";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(37, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "click droit sur l\'hackathon sélectionné pour voir ses équipes";
            // 
            // dgvEquipes
            // 
            this.dgvEquipes.AllowUserToAddRows = false;
            this.dgvEquipes.AllowUserToDeleteRows = false;
            this.dgvEquipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipes.Location = new System.Drawing.Point(332, 154);
            this.dgvEquipes.Name = "dgvEquipes";
            this.dgvEquipes.ReadOnly = true;
            this.dgvEquipes.Size = new System.Drawing.Size(357, 150);
            this.dgvEquipes.TabIndex = 5;
            this.dgvEquipes.Visible = false;
            // 
            // FormHackathon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(784, 384);
            this.Controls.Add(this.dgvEquipes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnFermer);
            this.Controls.Add(this.dgvHackathon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHackathon";
            this.Text = "Gestion des Hackathons";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHackathon)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BSHackathon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSEquipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource BSHackathon;
        private System.Windows.Forms.DataGridView dgvHackathon;
        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voirLesÉquipesToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource BSEquipe;
        private System.Windows.Forms.DataGridView dgvEquipes;
    }
}

