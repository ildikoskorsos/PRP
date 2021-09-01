namespace Szakdolgozat___PRP
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ParnerekGomb = new System.Windows.Forms.Button();
            this.RaktarGomb = new System.Windows.Forms.Button();
            this.ProjektGomb = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.partnerekFelvitelVagyListaz1 = new Szakdolgozat___PRP.PartnerekFelvitelVagyListaz();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(982, 553);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.ParnerekGomb, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.RaktarGomb, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ProjektGomb, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(976, 44);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // ParnerekGomb
            // 
            this.ParnerekGomb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParnerekGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ParnerekGomb.Location = new System.Drawing.Point(3, 3);
            this.ParnerekGomb.Name = "ParnerekGomb";
            this.ParnerekGomb.Size = new System.Drawing.Size(144, 38);
            this.ParnerekGomb.TabIndex = 0;
            this.ParnerekGomb.Text = "Partnerek";
            this.ParnerekGomb.UseVisualStyleBackColor = true;
            this.ParnerekGomb.Click += new System.EventHandler(this.ParnerekGomb_Click);
            // 
            // RaktarGomb
            // 
            this.RaktarGomb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RaktarGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RaktarGomb.Location = new System.Drawing.Point(153, 3);
            this.RaktarGomb.Name = "RaktarGomb";
            this.RaktarGomb.Size = new System.Drawing.Size(144, 38);
            this.RaktarGomb.TabIndex = 1;
            this.RaktarGomb.Text = "Raktár";
            this.RaktarGomb.UseVisualStyleBackColor = true;
            this.RaktarGomb.Click += new System.EventHandler(this.RaktarGomb_Click);
            // 
            // ProjektGomb
            // 
            this.ProjektGomb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjektGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProjektGomb.Location = new System.Drawing.Point(303, 3);
            this.ProjektGomb.Name = "ProjektGomb";
            this.ProjektGomb.Size = new System.Drawing.Size(144, 38);
            this.ProjektGomb.TabIndex = 2;
            this.ProjektGomb.Text = "Projektek";
            this.ProjektGomb.UseVisualStyleBackColor = true;
            this.ProjektGomb.Click += new System.EventHandler(this.ProjektGomb_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.partnerekFelvitelVagyListaz1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 497);
            this.panel1.TabIndex = 1;
            // 
            // partnerekFelvitelVagyListaz1
            // 
            this.partnerekFelvitelVagyListaz1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("partnerekFelvitelVagyListaz1.BackgroundImage")));
            this.partnerekFelvitelVagyListaz1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.partnerekFelvitelVagyListaz1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partnerekFelvitelVagyListaz1.Location = new System.Drawing.Point(0, 0);
            this.partnerekFelvitelVagyListaz1.Name = "partnerekFelvitelVagyListaz1";
            this.partnerekFelvitelVagyListaz1.Size = new System.Drawing.Size(976, 497);
            this.partnerekFelvitelVagyListaz1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Partner-, Raktár- és Projektkezelő";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AblakBezar);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button ParnerekGomb;
        private System.Windows.Forms.Panel panel1;
        private PartnerekFelvitelVagyListaz partnerekFelvitelVagyListaz1;
        private System.Windows.Forms.Button RaktarGomb;
        private System.Windows.Forms.Button ProjektGomb;
    }
}

