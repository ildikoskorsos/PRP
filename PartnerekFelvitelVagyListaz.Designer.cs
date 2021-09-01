namespace Szakdolgozat___PRP
{
    partial class PartnerekFelvitelVagyListaz
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartnerekFelvitelVagyListaz));
            this.PartnerHozzaadasFeluletvalasztogomb = new System.Windows.Forms.Button();
            this.PartnerListazasFeluletvalasztoGomb = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PartnerHozzaadasFeluletvalasztogomb
            // 
            this.PartnerHozzaadasFeluletvalasztogomb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PartnerHozzaadasFeluletvalasztogomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PartnerHozzaadasFeluletvalasztogomb.Location = new System.Drawing.Point(88, 163);
            this.PartnerHozzaadasFeluletvalasztogomb.Name = "PartnerHozzaadasFeluletvalasztogomb";
            this.PartnerHozzaadasFeluletvalasztogomb.Size = new System.Drawing.Size(153, 110);
            this.PartnerHozzaadasFeluletvalasztogomb.TabIndex = 0;
            this.PartnerHozzaadasFeluletvalasztogomb.Text = "Új partner hozzáadása";
            this.PartnerHozzaadasFeluletvalasztogomb.UseVisualStyleBackColor = true;
            this.PartnerHozzaadasFeluletvalasztogomb.Click += new System.EventHandler(this.button1_Click);
            // 
            // PartnerListazasFeluletvalasztoGomb
            // 
            this.PartnerListazasFeluletvalasztoGomb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PartnerListazasFeluletvalasztoGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PartnerListazasFeluletvalasztoGomb.Location = new System.Drawing.Point(412, 163);
            this.PartnerListazasFeluletvalasztoGomb.Name = "PartnerListazasFeluletvalasztoGomb";
            this.PartnerListazasFeluletvalasztoGomb.Size = new System.Drawing.Size(165, 110);
            this.PartnerListazasFeluletvalasztoGomb.TabIndex = 1;
            this.PartnerListazasFeluletvalasztoGomb.Text = "Partnerek listázása";
            this.PartnerListazasFeluletvalasztoGomb.UseVisualStyleBackColor = true;
            this.PartnerListazasFeluletvalasztoGomb.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.PartnerHozzaadasFeluletvalasztogomb, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PartnerListazasFeluletvalasztoGomb, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(660, 437);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // PartnerekFelvitelVagyListaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PartnerekFelvitelVagyListaz";
            this.Size = new System.Drawing.Size(660, 437);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PartnerHozzaadasFeluletvalasztogomb;
        private System.Windows.Forms.Button PartnerListazasFeluletvalasztoGomb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
