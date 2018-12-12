namespace FarmingEm {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbBuy = new System.Windows.Forms.GroupBox();
            this.gbSell = new System.Windows.Forms.GroupBox();
            this.gbInv = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.gbStats = new System.Windows.Forms.GroupBox();
            this.lblWheatSeeds = new System.Windows.Forms.Label();
            this.lblRiceSeeds = new System.Windows.Forms.Label();
            this.gbBuy.SuspendLayout();
            this.gbInv.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBuy
            // 
            this.gbBuy.BackColor = System.Drawing.Color.Transparent;
            this.gbBuy.Controls.Add(this.lblRiceSeeds);
            this.gbBuy.Controls.Add(this.lblWheatSeeds);
            this.gbBuy.Location = new System.Drawing.Point(12, 12);
            this.gbBuy.Name = "gbBuy";
            this.gbBuy.Size = new System.Drawing.Size(200, 174);
            this.gbBuy.TabIndex = 0;
            this.gbBuy.TabStop = false;
            this.gbBuy.Text = "Buy Menu";
            // 
            // gbSell
            // 
            this.gbSell.BackColor = System.Drawing.Color.Transparent;
            this.gbSell.Location = new System.Drawing.Point(218, 12);
            this.gbSell.Name = "gbSell";
            this.gbSell.Size = new System.Drawing.Size(200, 174);
            this.gbSell.TabIndex = 1;
            this.gbSell.TabStop = false;
            this.gbSell.Text = "Sell Menu";
            // 
            // gbInv
            // 
            this.gbInv.BackColor = System.Drawing.Color.Transparent;
            this.gbInv.Controls.Add(this.label3);
            this.gbInv.Controls.Add(this.label2);
            this.gbInv.Controls.Add(this.lbl);
            this.gbInv.Location = new System.Drawing.Point(424, 12);
            this.gbInv.Name = "gbInv";
            this.gbInv.Size = new System.Drawing.Size(200, 174);
            this.gbInv.TabIndex = 2;
            this.gbInv.TabStop = false;
            this.gbInv.Text = "Inventory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(7, 16);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(35, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "label1";
            this.lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbStats
            // 
            this.gbStats.BackColor = System.Drawing.Color.Transparent;
            this.gbStats.Location = new System.Drawing.Point(630, 12);
            this.gbStats.Name = "gbStats";
            this.gbStats.Size = new System.Drawing.Size(158, 174);
            this.gbStats.TabIndex = 3;
            this.gbStats.TabStop = false;
            this.gbStats.Text = "Stats";
            // 
            // lblWheatSeeds
            // 
            this.lblWheatSeeds.AutoSize = true;
            this.lblWheatSeeds.Location = new System.Drawing.Point(7, 16);
            this.lblWheatSeeds.Name = "lblWheatSeeds";
            this.lblWheatSeeds.Size = new System.Drawing.Size(164, 13);
            this.lblWheatSeeds.TabIndex = 0;
            this.lblWheatSeeds.Text = "Buy Wheat Seeds [Click] $5 for 5";
            // 
            // lblRiceSeeds
            // 
            this.lblRiceSeeds.AutoSize = true;
            this.lblRiceSeeds.Location = new System.Drawing.Point(7, 33);
            this.lblRiceSeeds.Name = "lblRiceSeeds";
            this.lblRiceSeeds.Size = new System.Drawing.Size(160, 13);
            this.lblRiceSeeds.TabIndex = 1;
            this.lblRiceSeeds.Text = "Buy Rice Seeds [Click] $10 for 5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbStats);
            this.Controls.Add(this.gbInv);
            this.Controls.Add(this.gbSell);
            this.Controls.Add(this.gbBuy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbBuy.ResumeLayout(false);
            this.gbBuy.PerformLayout();
            this.gbInv.ResumeLayout(false);
            this.gbInv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBuy;
        private System.Windows.Forms.GroupBox gbSell;
        private System.Windows.Forms.GroupBox gbInv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.GroupBox gbStats;
        private System.Windows.Forms.Label lblRiceSeeds;
        private System.Windows.Forms.Label lblWheatSeeds;
    }
}

