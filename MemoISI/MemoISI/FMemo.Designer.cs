namespace MemoISI
{
    partial class FMemo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jeuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauJeuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_Timer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_Score = new System.Windows.Forms.Label();
            this.BW_Timer = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jeuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(515, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jeuToolStripMenuItem
            // 
            this.jeuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauJeuToolStripMenuItem});
            this.jeuToolStripMenuItem.Name = "jeuToolStripMenuItem";
            this.jeuToolStripMenuItem.Size = new System.Drawing.Size(42, 24);
            this.jeuToolStripMenuItem.Text = "Jeu";
            // 
            // nouveauJeuToolStripMenuItem
            // 
            this.nouveauJeuToolStripMenuItem.Name = "nouveauJeuToolStripMenuItem";
            this.nouveauJeuToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.nouveauJeuToolStripMenuItem.Text = "Nouveau jeu";
            this.nouveauJeuToolStripMenuItem.Click += new System.EventHandler(this.nouveauJeuToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Timer :";
            // 
            // LB_Timer
            // 
            this.LB_Timer.AutoSize = true;
            this.LB_Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Timer.Location = new System.Drawing.Point(95, 45);
            this.LB_Timer.Name = "LB_Timer";
            this.LB_Timer.Size = new System.Drawing.Size(104, 20);
            this.LB_Timer.TabIndex = 2;
            this.LB_Timer.Text = "60 secondes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Score :";
            // 
            // LB_Score
            // 
            this.LB_Score.AutoSize = true;
            this.LB_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Score.Location = new System.Drawing.Point(353, 45);
            this.LB_Score.Name = "LB_Score";
            this.LB_Score.Size = new System.Drawing.Size(18, 20);
            this.LB_Score.TabIndex = 4;
            this.LB_Score.Text = "0";
            // 
            // BW_Timer
            // 
            this.BW_Timer.WorkerReportsProgress = true;
            this.BW_Timer.WorkerSupportsCancellation = true;
            // 
            // FMemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 721);
            this.Controls.Add(this.LB_Score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LB_Timer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FMemo";
            this.Text = "Memory";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jeuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauJeuToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_Timer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LB_Score;
        private System.ComponentModel.BackgroundWorker BW_Timer;
    }
}

