
namespace SeoskiTurizam
{
    partial class FGlavna
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolVauceri = new System.Windows.Forms.ToolStripButton();
            this.toolAplikacija = new System.Windows.Forms.ToolStripButton();
            this.toolIzlaz = new System.Windows.Forms.ToolStripButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.cbxGrad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Silver;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(60, 60);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolVauceri,
            this.toolAplikacija,
            this.toolIzlaz});
            this.toolStrip1.Location = new System.Drawing.Point(788, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(181, 460);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolVauceri
            // 
            this.toolVauceri.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolVauceri.Image = global::SeoskiTurizam.Properties.Resources.analiza4;
            this.toolVauceri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolVauceri.Name = "toolVauceri";
            this.toolVauceri.Size = new System.Drawing.Size(176, 96);
            this.toolVauceri.Text = "Dodeli vaučere";
            this.toolVauceri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolVauceri.Click += new System.EventHandler(this.toolVauceri_Click);
            // 
            // toolAplikacija
            // 
            this.toolAplikacija.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolAplikacija.Image = global::SeoskiTurizam.Properties.Resources.info_40x40;
            this.toolAplikacija.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAplikacija.Name = "toolAplikacija";
            this.toolAplikacija.Size = new System.Drawing.Size(176, 96);
            this.toolAplikacija.Text = "O aplikaciji";
            this.toolAplikacija.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolAplikacija.Click += new System.EventHandler(this.toolAplikacija_Click);
            // 
            // toolIzlaz
            // 
            this.toolIzlaz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolIzlaz.Image = global::SeoskiTurizam.Properties.Resources.door_exit_40x40;
            this.toolIzlaz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolIzlaz.Name = "toolIzlaz";
            this.toolIzlaz.Size = new System.Drawing.Size(176, 96);
            this.toolIzlaz.Text = "Izlaz";
            this.toolIzlaz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolIzlaz.Click += new System.EventHandler(this.toolIzlaz_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(360, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(411, 421);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Šifra";
            this.columnHeader1.Width = 116;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Selo";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Grad";
            this.columnHeader3.Width = 179;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(7, 328);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(266, 54);
            this.btnIzmeni.TabIndex = 0;
            this.btnIzmeni.Text = "Izmeni >>>";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Šifra";
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(127, 39);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(97, 35);
            this.txtSifra.TabIndex = 0;
            this.txtSifra.TextChanged += new System.EventHandler(this.txtSifra_TextChanged);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(127, 112);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(218, 35);
            this.txtNaziv.TabIndex = 21;
            // 
            // cbxGrad
            // 
            this.cbxGrad.Location = new System.Drawing.Point(127, 176);
            this.cbxGrad.Name = "cbxGrad";
            this.cbxGrad.Size = new System.Drawing.Size(218, 37);
            this.cbxGrad.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Naziv";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 44);
            this.label3.TabIndex = 0;
            this.label3.Text = "Grad";
            // 
            // FGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 460);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxGrad);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FGlavna";
            this.Text = "Selo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FGlavna_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStripButton toolVauceri;
        private System.Windows.Forms.ToolStripButton toolIzlaz;
        private System.Windows.Forms.ToolStripButton toolAplikacija;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.ComboBox cbxGrad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

