namespace OceneFilmova.UI
{
    partial class Glumci
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
            this.label1 = new System.Windows.Forms.Label();
            this.filmGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datumRodjenjaPicker = new System.Windows.Forms.DateTimePicker();
            this.obrisiBtn = new System.Windows.Forms.Button();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.autorLbl = new System.Windows.Forms.Label();
            this.filmNazivLbl = new System.Windows.Forms.Label();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.glumciDataGrid = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filmoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glumciDataGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(476, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 68);
            this.label1.TabIndex = 8;
            this.label1.Text = "Glumci";
            // 
            // filmGroupBox
            // 
            this.filmGroupBox.Controls.Add(this.label2);
            this.filmGroupBox.Controls.Add(this.datumRodjenjaPicker);
            this.filmGroupBox.Controls.Add(this.obrisiBtn);
            this.filmGroupBox.Controls.Add(this.dodajBtn);
            this.filmGroupBox.Controls.Add(this.autorLbl);
            this.filmGroupBox.Controls.Add(this.filmNazivLbl);
            this.filmGroupBox.Controls.Add(this.prezimeTextBox);
            this.filmGroupBox.Controls.Add(this.imeTextBox);
            this.filmGroupBox.Location = new System.Drawing.Point(36, 188);
            this.filmGroupBox.Name = "filmGroupBox";
            this.filmGroupBox.Size = new System.Drawing.Size(346, 333);
            this.filmGroupBox.TabIndex = 7;
            this.filmGroupBox.TabStop = false;
            this.filmGroupBox.Text = "Podaci o glumcu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Datum rodjenja";
            // 
            // datumRodjenjaPicker
            // 
            this.datumRodjenjaPicker.Location = new System.Drawing.Point(6, 217);
            this.datumRodjenjaPicker.Name = "datumRodjenjaPicker";
            this.datumRodjenjaPicker.Size = new System.Drawing.Size(250, 27);
            this.datumRodjenjaPicker.TabIndex = 22;
            // 
            // obrisiBtn
            // 
            this.obrisiBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.obrisiBtn.ForeColor = System.Drawing.Color.Red;
            this.obrisiBtn.Location = new System.Drawing.Point(252, 286);
            this.obrisiBtn.Name = "obrisiBtn";
            this.obrisiBtn.Size = new System.Drawing.Size(94, 29);
            this.obrisiBtn.TabIndex = 18;
            this.obrisiBtn.Text = "Obrisi";
            this.obrisiBtn.UseVisualStyleBackColor = false;
            this.obrisiBtn.Click += new System.EventHandler(this.obrisiBtn_Click);
            // 
            // dodajBtn
            // 
            this.dodajBtn.Location = new System.Drawing.Point(6, 286);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(94, 29);
            this.dodajBtn.TabIndex = 16;
            this.dodajBtn.Text = "Dodaj";
            this.dodajBtn.UseVisualStyleBackColor = true;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // autorLbl
            // 
            this.autorLbl.AutoSize = true;
            this.autorLbl.Location = new System.Drawing.Point(6, 128);
            this.autorLbl.Name = "autorLbl";
            this.autorLbl.Size = new System.Drawing.Size(62, 20);
            this.autorLbl.TabIndex = 9;
            this.autorLbl.Text = "Prezime";
            // 
            // filmNazivLbl
            // 
            this.filmNazivLbl.AutoSize = true;
            this.filmNazivLbl.Location = new System.Drawing.Point(6, 58);
            this.filmNazivLbl.Name = "filmNazivLbl";
            this.filmNazivLbl.Size = new System.Drawing.Size(34, 20);
            this.filmNazivLbl.TabIndex = 8;
            this.filmNazivLbl.Text = "Ime";
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.Location = new System.Drawing.Point(6, 151);
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(330, 27);
            this.prezimeTextBox.TabIndex = 7;
            // 
            // imeTextBox
            // 
            this.imeTextBox.Location = new System.Drawing.Point(6, 81);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(330, 27);
            this.imeTextBox.TabIndex = 6;
            // 
            // glumciDataGrid
            // 
            this.glumciDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.glumciDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.glumciDataGrid.Location = new System.Drawing.Point(415, 188);
            this.glumciDataGrid.Name = "glumciDataGrid";
            this.glumciDataGrid.RowHeadersWidth = 51;
            this.glumciDataGrid.RowTemplate.Height = 29;
            this.glumciDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.glumciDataGrid.Size = new System.Drawing.Size(684, 333);
            this.glumciDataGrid.TabIndex = 6;
            this.glumciDataGrid.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.glumciDataGrid_RowStateChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmoviToolStripMenuItem,
            this.tagoviToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1156, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filmoviToolStripMenuItem
            // 
            this.filmoviToolStripMenuItem.Name = "filmoviToolStripMenuItem";
            this.filmoviToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.filmoviToolStripMenuItem.Text = "Filmovi";
            this.filmoviToolStripMenuItem.Click += new System.EventHandler(this.filmoviToolStripMenuItem_Click);
            // 
            // tagoviToolStripMenuItem
            // 
            this.tagoviToolStripMenuItem.Name = "tagoviToolStripMenuItem";
            this.tagoviToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.tagoviToolStripMenuItem.Text = "Tagovi";
            this.tagoviToolStripMenuItem.Click += new System.EventHandler(this.tagoviToolStripMenuItem_Click);
            // 
            // Glumci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1156, 549);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filmGroupBox);
            this.Controls.Add(this.glumciDataGrid);
            this.Name = "Glumci";
            this.Text = "Glumci";
            this.Load += new System.EventHandler(this.Glumci_Load);
            this.filmGroupBox.ResumeLayout(false);
            this.filmGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glumciDataGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox filmGroupBox;
        private Button obrisiBtn;
        private Button dodajBtn;
        private Label autorLbl;
        private Label filmNazivLbl;
        private TextBox prezimeTextBox;
        private TextBox imeTextBox;
        private DataGridView glumciDataGrid;
        private Label label2;
        private DateTimePicker datumRodjenjaPicker;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem filmoviToolStripMenuItem;
        private ToolStripMenuItem tagoviToolStripMenuItem;
    }
}