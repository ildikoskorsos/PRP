
namespace Szakdolgozat___PRP
{
    partial class ProjektListazas
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.FelelosSzuro = new System.Windows.Forms.TextBox();
            this.TermekSzuro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PartnerSzuro = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ProjektekLB = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.ProjektKivalasztottTorles = new System.Windows.Forms.Button();
            this.ProjektListazasGomb = new System.Windows.Forms.Button();
            this.ProjektOsszesExport = new System.Windows.Forms.Button();
            this.ProjektKivalasztottExport = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(982, 553);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.FelelosSzuro, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.TermekSzuro, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.PartnerSzuro, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(976, 74);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // FelelosSzuro
            // 
            this.FelelosSzuro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FelelosSzuro.Location = new System.Drawing.Point(480, 23);
            this.FelelosSzuro.Multiline = true;
            this.FelelosSzuro.Name = "FelelosSzuro";
            this.FelelosSzuro.Size = new System.Drawing.Size(160, 48);
            this.FelelosSzuro.TabIndex = 10;
            // 
            // TermekSzuro
            // 
            this.TermekSzuro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TermekSzuro.Location = new System.Drawing.Point(314, 23);
            this.TermekSzuro.Multiline = true;
            this.TermekSzuro.Name = "TermekSzuro";
            this.TermekSzuro.Size = new System.Drawing.Size(160, 48);
            this.TermekSzuro.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(480, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Felelős";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(314, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Termék";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Szűrés";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(148, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Partner";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PartnerSzuro
            // 
            this.PartnerSzuro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PartnerSzuro.Location = new System.Drawing.Point(148, 23);
            this.PartnerSzuro.Multiline = true;
            this.PartnerSzuro.Name = "PartnerSzuro";
            this.PartnerSzuro.Size = new System.Drawing.Size(160, 48);
            this.PartnerSzuro.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.Controls.Add(this.ProjektekLB, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 83);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(976, 467);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // ProjektekLB
            // 
            this.ProjektekLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjektekLB.FormattingEnabled = true;
            this.ProjektekLB.ItemHeight = 16;
            this.ProjektekLB.Location = new System.Drawing.Point(3, 3);
            this.ProjektekLB.Name = "ProjektekLB";
            this.ProjektekLB.Size = new System.Drawing.Size(820, 461);
            this.ProjektekLB.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.ProjektKivalasztottTorles, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.ProjektListazasGomb, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.ProjektOsszesExport, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.ProjektKivalasztottExport, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(829, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(144, 461);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // ProjektKivalasztottTorles
            // 
            this.ProjektKivalasztottTorles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjektKivalasztottTorles.Location = new System.Drawing.Point(3, 403);
            this.ProjektKivalasztottTorles.Name = "ProjektKivalasztottTorles";
            this.ProjektKivalasztottTorles.Size = new System.Drawing.Size(138, 55);
            this.ProjektKivalasztottTorles.TabIndex = 5;
            this.ProjektKivalasztottTorles.Text = "Kiválasztott elem TÖRLÉSE";
            this.ProjektKivalasztottTorles.UseVisualStyleBackColor = true;
            this.ProjektKivalasztottTorles.Click += new System.EventHandler(this.ProjektKivalasztottTorles_Click);
            // 
            // ProjektListazasGomb
            // 
            this.ProjektListazasGomb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjektListazasGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProjektListazasGomb.Location = new System.Drawing.Point(3, 211);
            this.ProjektListazasGomb.Name = "ProjektListazasGomb";
            this.ProjektListazasGomb.Size = new System.Drawing.Size(138, 54);
            this.ProjektListazasGomb.TabIndex = 3;
            this.ProjektListazasGomb.Text = "LISTÁZÁS";
            this.ProjektListazasGomb.UseVisualStyleBackColor = true;
            this.ProjektListazasGomb.Click += new System.EventHandler(this.ProjektListazasGomb_Click);
            // 
            // ProjektOsszesExport
            // 
            this.ProjektOsszesExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjektOsszesExport.Location = new System.Drawing.Point(3, 63);
            this.ProjektOsszesExport.Name = "ProjektOsszesExport";
            this.ProjektOsszesExport.Size = new System.Drawing.Size(138, 54);
            this.ProjektOsszesExport.TabIndex = 1;
            this.ProjektOsszesExport.Text = "Összes elem EXPORTJA";
            this.ProjektOsszesExport.UseVisualStyleBackColor = true;
            this.ProjektOsszesExport.Click += new System.EventHandler(this.ProjektOsszesExport_Click);
            // 
            // ProjektKivalasztottExport
            // 
            this.ProjektKivalasztottExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjektKivalasztottExport.Location = new System.Drawing.Point(3, 3);
            this.ProjektKivalasztottExport.Name = "ProjektKivalasztottExport";
            this.ProjektKivalasztottExport.Size = new System.Drawing.Size(138, 54);
            this.ProjektKivalasztottExport.TabIndex = 0;
            this.ProjektKivalasztottExport.Text = "Kiválasztott elem EXPORTJA";
            this.ProjektKivalasztottExport.UseVisualStyleBackColor = true;
            this.ProjektKivalasztottExport.Click += new System.EventHandler(this.ProjektKivalasztottExport_Click);
            // 
            // ProjektListazas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProjektListazas";
            this.Text = "ProjektListazas";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox FelelosSzuro;
        private System.Windows.Forms.TextBox TermekSzuro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PartnerSzuro;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ListBox ProjektekLB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button ProjektKivalasztottTorles;
        private System.Windows.Forms.Button ProjektListazasGomb;
        private System.Windows.Forms.Button ProjektOsszesExport;
        private System.Windows.Forms.Button ProjektKivalasztottExport;
    }
}