namespace OceneFilmova.UI
{
    partial class Tagovi
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
            this.dodajBtn = new System.Windows.Forms.Button();
            this.nazivLbl = new System.Windows.Forms.Label();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.tagoviDataGrid = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filmoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.glumciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrisiBtn = new System.Windows.Forms.Button();
            this.filmGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tagoviDataGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(450, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 68);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tagovi";
            // 
            // filmGroupBox
            // 
            this.filmGroupBox.Controls.Add(this.obrisiBtn);
            this.filmGroupBox.Controls.Add(this.dodajBtn);
            this.filmGroupBox.Controls.Add(this.nazivLbl);
            this.filmGroupBox.Controls.Add(this.nazivTextBox);
            this.filmGroupBox.Location = new System.Drawing.Point(34, 270);
            this.filmGroupBox.Name = "filmGroupBox";
            this.filmGroupBox.Size = new System.Drawing.Size(346, 181);
            this.filmGroupBox.TabIndex = 11;
            this.filmGroupBox.TabStop = false;
            this.filmGroupBox.Text = "Podaci o tagu";
            // 
            // dodajBtn
            // 
            this.dodajBtn.Location = new System.Drawing.Point(6, 129);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(94, 29);
            this.dodajBtn.TabIndex = 16;
            this.dodajBtn.Text = "Dodaj";
            this.dodajBtn.UseVisualStyleBackColor = true;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // nazivLbl
            // 
            this.nazivLbl.AutoSize = true;
            this.nazivLbl.Location = new System.Drawing.Point(6, 58);
            this.nazivLbl.Name = "nazivLbl";
            this.nazivLbl.Size = new System.Drawing.Size(46, 20);
            this.nazivLbl.TabIndex = 8;
            this.nazivLbl.Text = "Naziv";
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.Location = new System.Drawing.Point(6, 81);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(330, 27);
            this.nazivTextBox.TabIndex = 6;
            // 
            // tagoviDataGrid
            // 
            this.tagoviDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tagoviDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tagoviDataGrid.Location = new System.Drawing.Point(416, 211);
            this.tagoviDataGrid.Name = "tagoviDataGrid";
            this.tagoviDataGrid.RowHeadersWidth = 51;
            this.tagoviDataGrid.RowTemplate.Height = 29;
            this.tagoviDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tagoviDataGrid.Size = new System.Drawing.Size(684, 333);
            this.tagoviDataGrid.TabIndex = 10;
            this.tagoviDataGrid.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.tagoviDataGrid_RowStateChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmoviToolStripMenuItem,
            this.glumciToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1138, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filmoviToolStripMenuItem
            // 
            this.filmoviToolStripMenuItem.Name = "filmoviToolStripMenuItem";
            this.filmoviToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.filmoviToolStripMenuItem.Text = "Filmovi";
            this.filmoviToolStripMenuItem.Click += new System.EventHandler(this.filmoviToolStripMenuItem_Click);
            // 
            // glumciToolStripMenuItem
            // 
            this.glumciToolStripMenuItem.Name = "glumciToolStripMenuItem";
            this.glumciToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.glumciToolStripMenuItem.Text = "Glumci";
            this.glumciToolStripMenuItem.Click += new System.EventHandler(this.glumciToolStripMenuItem_Click);
            // 
            // obrisiBtn
            // 
            this.obrisiBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.obrisiBtn.ForeColor = System.Drawing.Color.Red;
            this.obrisiBtn.Location = new System.Drawing.Point(242, 129);
            this.obrisiBtn.Name = "obrisiBtn";
            this.obrisiBtn.Size = new System.Drawing.Size(94, 29);
            this.obrisiBtn.TabIndex = 18;
            this.obrisiBtn.Text = "Obrisi";
            this.obrisiBtn.UseVisualStyleBackColor = false;
            this.obrisiBtn.Click += new System.EventHandler(this.obrisiBtn_Click);
            // 
            // Tagovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1138, 576);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filmGroupBox);
            this.Controls.Add(this.tagoviDataGrid);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Tagovi";
            this.Text = "Tagovi";
            this.Load += new System.EventHandler(this.Tagovi_Load);
            this.filmGroupBox.ResumeLayout(false);
            this.filmGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tagoviDataGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox filmGroupBox;
        private Button dodajBtn;
        private Label nazivLbl;
        private TextBox nazivTextBox;
        private DataGridView tagoviDataGrid;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem filmoviToolStripMenuItem;
        private ToolStripMenuItem glumciToolStripMenuItem;
        private Button obrisiBtn;
    }
}