namespace Szakdolgozat___PRP
{
    partial class PartnerekListazasa
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
            this.AdottExport = new System.Windows.Forms.Button();
            this.CsakMegrendeloCheckBox = new System.Windows.Forms.CheckBox();
            this.CsakBeszallitoCheckBox = new System.Windows.Forms.CheckBox();
            this.ListazPartnerGomb = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Partnereink = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdottExport
            // 
            this.AdottExport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdottExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AdottExport.Location = new System.Drawing.Point(80, 231);
            this.AdottExport.Name = "AdottExport";
            this.AdottExport.Size = new System.Drawing.Size(226, 77);
            this.AdottExport.TabIndex = 2;
            this.AdottExport.Text = "Összes elem exportja";
            this.AdottExport.UseVisualStyleBackColor = true;
            this.AdottExport.Click += new System.EventHandler(this.OsszesElemExportja_Click);
            // 
            // CsakMegrendeloCheckBox
            // 
            this.CsakMegrendeloCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CsakMegrendeloCheckBox.AutoSize = true;
            this.CsakMegrendeloCheckBox.Location = new System.Drawing.Point(91, 116);
            this.CsakMegrendeloCheckBox.Name = "CsakMegrendeloCheckBox";
            this.CsakMegrendeloCheckBox.Size = new System.Drawing.Size(198, 29);
            this.CsakMegrendeloCheckBox.TabIndex = 6;
            this.CsakMegrendeloCheckBox.Text = "Csak megrendelők";
            this.CsakMegrendeloCheckBox.UseVisualStyleBackColor = true;
            // 
            // CsakBeszallitoCheckBox
            // 
            this.CsakBeszallitoCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CsakBeszallitoCheckBox.AutoSize = true;
            this.CsakBeszallitoCheckBox.Location = new System.Drawing.Point(102, 29);
            this.CsakBeszallitoCheckBox.Name = "CsakBeszallitoCheckBox";
            this.CsakBeszallitoCheckBox.Size = new System.Drawing.Size(176, 29);
            this.CsakBeszallitoCheckBox.TabIndex = 7;
            this.CsakBeszallitoCheckBox.Text = "Csak beszállítók";
            this.CsakBeszallitoCheckBox.UseVisualStyleBackColor = true;
            // 
            // ListazPartnerGomb
            // 
            this.ListazPartnerGomb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ListazPartnerGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ListazPartnerGomb.Location = new System.Drawing.Point(80, 415);
            this.ListazPartnerGomb.Name = "ListazPartnerGomb";
            this.ListazPartnerGomb.Size = new System.Drawing.Size(226, 76);
            this.ListazPartnerGomb.TabIndex = 9;
            this.ListazPartnerGomb.Text = "Listáz";
            this.ListazPartnerGomb.UseVisualStyleBackColor = true;
            this.ListazPartnerGomb.Click += new System.EventHandler(this.ListazPartnerGomb_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Partnereink, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(982, 553);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ListazPartnerGomb, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.AdottExport, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(592, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(387, 547);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.CsakBeszallitoCheckBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.CsakMegrendeloCheckBox, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(381, 174);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // Partnereink
            // 
            this.Partnereink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Partnereink.FormattingEnabled = true;
            this.Partnereink.ItemHeight = 16;
            this.Partnereink.Location = new System.Drawing.Point(3, 3);
            this.Partnereink.Name = "Partnereink";
            this.Partnereink.Size = new System.Drawing.Size(583, 547);
            this.Partnereink.TabIndex = 1;
            this.Partnereink.DoubleClick += new System.EventHandler(this.PartnerKivalaszto);
            // 
            // PartnerekListazasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PartnerekListazasa";
            this.Text = "PartnerekListazasa";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AdottExport;
        private System.Windows.Forms.CheckBox CsakMegrendeloCheckBox;
        private System.Windows.Forms.CheckBox CsakBeszallitoCheckBox;
        private System.Windows.Forms.Button ListazPartnerGomb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ListBox Partnereink;
    }
}