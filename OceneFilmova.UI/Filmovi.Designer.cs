
namespace OceneFilmova.UI
{
    partial class Filmovi
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.filmoviDataGrid = new System.Windows.Forms.DataGridView();
            this.filmGroupBox = new System.Windows.Forms.GroupBox();
            this.deskripcijaLbl = new System.Windows.Forms.Label();
            this.deskripcijaRichTextBox = new System.Windows.Forms.RichTextBox();
            this.tagoviListBox = new System.Windows.Forms.ListBox();
            this.glumciListBox = new System.Windows.Forms.ListBox();
            this.obrisiBtn = new System.Windows.Forms.Button();
            this.izmeniBtn = new System.Windows.Forms.Button();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.godinaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ocenaComboBox = new System.Windows.Forms.ComboBox();
            this.autorLbl = new System.Windows.Forms.Label();
            this.filmNazivLbl = new System.Windows.Forms.Label();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.filmTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.glumciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.glumciFilterComboBox = new System.Windows.Forms.ComboBox();
            this.tagoviFilterComboBox = new System.Windows.Forms.ComboBox();
            this.glumacFilterLbl = new System.Windows.Forms.Label();
            this.tagFilterLbl = new System.Windows.Forms.Label();
            this.filterBtn = new System.Windows.Forms.Button();
            this.resetFilterBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.filmoviDataGrid)).BeginInit();
            this.filmGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // filmoviDataGrid
            // 
            this.filmoviDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filmoviDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filmoviDataGrid.Location = new System.Drawing.Point(423, 315);
            this.filmoviDataGrid.Name = "filmoviDataGrid";
            this.filmoviDataGrid.RowHeadersWidth = 51;
            this.filmoviDataGrid.RowTemplate.Height = 29;
            this.filmoviDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.filmoviDataGrid.Size = new System.Drawing.Size(684, 333);
            this.filmoviDataGrid.TabIndex = 3;
            this.filmoviDataGrid.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.filmoviDataGrid_RowStateChanged);
            // 
            // filmGroupBox
            // 
            this.filmGroupBox.Controls.Add(this.deskripcijaLbl);
            this.filmGroupBox.Controls.Add(this.deskripcijaRichTextBox);
            this.filmGroupBox.Controls.Add(this.tagoviListBox);
            this.filmGroupBox.Controls.Add(this.glumciListBox);
            this.filmGroupBox.Controls.Add(this.obrisiBtn);
            this.filmGroupBox.Controls.Add(this.izmeniBtn);
            this.filmGroupBox.Controls.Add(this.dodajBtn);
            this.filmGroupBox.Controls.Add(this.label3);
            this.filmGroupBox.Controls.Add(this.godinaTextBox);
            this.filmGroupBox.Controls.Add(this.label2);
            this.filmGroupBox.Controls.Add(this.ocenaComboBox);
            this.filmGroupBox.Controls.Add(this.autorLbl);
            this.filmGroupBox.Controls.Add(this.filmNazivLbl);
            this.filmGroupBox.Controls.Add(this.autorTextBox);
            this.filmGroupBox.Controls.Add(this.filmTextBox);
            this.filmGroupBox.Location = new System.Drawing.Point(32, 75);
            this.filmGroupBox.Name = "filmGroupBox";
            this.filmGroupBox.Size = new System.Drawing.Size(346, 613);
            this.filmGroupBox.TabIndex = 4;
            this.filmGroupBox.TabStop = false;
            this.filmGroupBox.Text = "Podaci o filmu";
            // 
            // deskripcijaLbl
            // 
            this.deskripcijaLbl.AutoSize = true;
            this.deskripcijaLbl.Location = new System.Drawing.Point(7, 412);
            this.deskripcijaLbl.Name = "deskripcijaLbl";
            this.deskripcijaLbl.Size = new System.Drawing.Size(82, 20);
            this.deskripcijaLbl.TabIndex = 21;
            this.deskripcijaLbl.Text = "Deskripcija";
            // 
            // deskripcijaRichTextBox
            // 
            this.deskripcijaRichTextBox.Location = new System.Drawing.Point(6, 435);
            this.deskripcijaRichTextBox.Name = "deskripcijaRichTextBox";
            this.deskripcijaRichTextBox.Size = new System.Drawing.Size(330, 120);
            this.deskripcijaRichTextBox.TabIndex = 6;
            this.deskripcijaRichTextBox.Text = "";
            // 
            // tagoviListBox
            // 
            this.tagoviListBox.FormattingEnabled = true;
            this.tagoviListBox.ItemHeight = 20;
            this.tagoviListBox.Location = new System.Drawing.Point(6, 279);
            this.tagoviListBox.Name = "tagoviListBox";
            this.tagoviListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.tagoviListBox.Size = new System.Drawing.Size(330, 64);
            this.tagoviListBox.TabIndex = 20;
            // 
            // glumciListBox
            // 
            this.glumciListBox.FormattingEnabled = true;
            this.glumciListBox.ItemHeight = 20;
            this.glumciListBox.Location = new System.Drawing.Point(6, 197);
            this.glumciListBox.Name = "glumciListBox";
            this.glumciListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.glumciListBox.Size = new System.Drawing.Size(330, 64);
            this.glumciListBox.TabIndex = 19;
            // 
            // obrisiBtn
            // 
            this.obrisiBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.obrisiBtn.ForeColor = System.Drawing.Color.Red;
            this.obrisiBtn.Location = new System.Drawing.Point(238, 570);
            this.obrisiBtn.Name = "obrisiBtn";
            this.obrisiBtn.Size = new System.Drawing.Size(94, 29);
            this.obrisiBtn.TabIndex = 18;
            this.obrisiBtn.Text = "Obrisi";
            this.obrisiBtn.UseVisualStyleBackColor = false;
            this.obrisiBtn.Click += new System.EventHandler(this.obrisiBtn_Click);
            // 
            // izmeniBtn
            // 
            this.izmeniBtn.Location = new System.Drawing.Point(120, 570);
            this.izmeniBtn.Name = "izmeniBtn";
            this.izmeniBtn.Size = new System.Drawing.Size(94, 29);
            this.izmeniBtn.TabIndex = 17;
            this.izmeniBtn.Text = "Izmeni";
            this.izmeniBtn.UseVisualStyleBackColor = true;
            this.izmeniBtn.Click += new System.EventHandler(this.izmeniBtn_Click);
            // 
            // dodajBtn
            // 
            this.dodajBtn.Location = new System.Drawing.Point(0, 570);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(94, 29);
            this.dodajBtn.TabIndex = 16;
            this.dodajBtn.Text = "Dodaj";
            this.dodajBtn.UseVisualStyleBackColor = true;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Godina izdanja";
            // 
            // godinaTextBox
            // 
            this.godinaTextBox.Location = new System.Drawing.Point(216, 371);
            this.godinaTextBox.Name = "godinaTextBox";
            this.godinaTextBox.Size = new System.Drawing.Size(116, 27);
            this.godinaTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ocena";
            // 
            // ocenaComboBox
            // 
            this.ocenaComboBox.FormattingEnabled = true;
            this.ocenaComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ocenaComboBox.Location = new System.Drawing.Point(54, 371);
            this.ocenaComboBox.Name = "ocenaComboBox";
            this.ocenaComboBox.Size = new System.Drawing.Size(45, 28);
            this.ocenaComboBox.TabIndex = 10;
            // 
            // autorLbl
            // 
            this.autorLbl.AutoSize = true;
            this.autorLbl.Location = new System.Drawing.Point(6, 128);
            this.autorLbl.Name = "autorLbl";
            this.autorLbl.Size = new System.Drawing.Size(46, 20);
            this.autorLbl.TabIndex = 9;
            this.autorLbl.Text = "Autor";
            // 
            // filmNazivLbl
            // 
            this.filmNazivLbl.AutoSize = true;
            this.filmNazivLbl.Location = new System.Drawing.Point(6, 58);
            this.filmNazivLbl.Name = "filmNazivLbl";
            this.filmNazivLbl.Size = new System.Drawing.Size(84, 20);
            this.filmNazivLbl.TabIndex = 8;
            this.filmNazivLbl.Text = "Naziv filma";
            // 
            // autorTextBox
            // 
            this.autorTextBox.Location = new System.Drawing.Point(6, 151);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(330, 27);
            this.autorTextBox.TabIndex = 7;
            // 
            // filmTextBox
            // 
            this.filmTextBox.Location = new System.Drawing.Point(6, 81);
            this.filmTextBox.Name = "filmTextBox";
            this.filmTextBox.Size = new System.Drawing.Size(330, 27);
            this.filmTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(516, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 68);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ocenjeni Filmovi";
            // 
            // glumciToolStripMenuItem
            // 
            this.glumciToolStripMenuItem.Name = "glumciToolStripMenuItem";
            this.glumciToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.glumciToolStripMenuItem.Text = "Glumci";
            this.glumciToolStripMenuItem.Click += new System.EventHandler(this.glumciToolStripMenuItem_Click);
            // 
            // tagoviToolStripMenuItem
            // 
            this.tagoviToolStripMenuItem.Name = "tagoviToolStripMenuItem";
            this.tagoviToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.tagoviToolStripMenuItem.Text = "Tagovi";
            this.tagoviToolStripMenuItem.Click += new System.EventHandler(this.tagoviToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.glumciToolStripMenuItem,
            this.tagoviToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1134, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // glumciFilterComboBox
            // 
            this.glumciFilterComboBox.FormattingEnabled = true;
            this.glumciFilterComboBox.Location = new System.Drawing.Point(614, 187);
            this.glumciFilterComboBox.Name = "glumciFilterComboBox";
            this.glumciFilterComboBox.Size = new System.Drawing.Size(493, 28);
            this.glumciFilterComboBox.TabIndex = 6;
            // 
            // tagoviFilterComboBox
            // 
            this.tagoviFilterComboBox.FormattingEnabled = true;
            this.tagoviFilterComboBox.Location = new System.Drawing.Point(614, 221);
            this.tagoviFilterComboBox.Name = "tagoviFilterComboBox";
            this.tagoviFilterComboBox.Size = new System.Drawing.Size(493, 28);
            this.tagoviFilterComboBox.TabIndex = 7;
            // 
            // glumacFilterLbl
            // 
            this.glumacFilterLbl.AutoSize = true;
            this.glumacFilterLbl.Location = new System.Drawing.Point(494, 190);
            this.glumacFilterLbl.Name = "glumacFilterLbl";
            this.glumacFilterLbl.Size = new System.Drawing.Size(114, 20);
            this.glumacFilterLbl.TabIndex = 22;
            this.glumacFilterLbl.Text = "Filter za glumca";
            // 
            // tagFilterLbl
            // 
            this.tagFilterLbl.AutoSize = true;
            this.tagFilterLbl.Location = new System.Drawing.Point(494, 224);
            this.tagFilterLbl.Name = "tagFilterLbl";
            this.tagFilterLbl.Size = new System.Drawing.Size(111, 20);
            this.tagFilterLbl.TabIndex = 23;
            this.tagFilterLbl.Text = "Filter za tagove";
            // 
            // filterBtn
            // 
            this.filterBtn.Location = new System.Drawing.Point(995, 260);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(112, 41);
            this.filterBtn.TabIndex = 24;
            this.filterBtn.Text = "Filtriraj";
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // resetFilterBtn
            // 
            this.resetFilterBtn.Location = new System.Drawing.Point(877, 260);
            this.resetFilterBtn.Name = "resetFilterBtn";
            this.resetFilterBtn.Size = new System.Drawing.Size(112, 41);
            this.resetFilterBtn.TabIndex = 25;
            this.resetFilterBtn.Text = "Resetuj filter";
            this.resetFilterBtn.UseVisualStyleBackColor = true;
            this.resetFilterBtn.Click += new System.EventHandler(this.resetFilterBtn_Click);
            // 
            // Filmovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1134, 700);
            this.Controls.Add(this.resetFilterBtn);
            this.Controls.Add(this.filterBtn);
            this.Controls.Add(this.tagFilterLbl);
            this.Controls.Add(this.glumacFilterLbl);
            this.Controls.Add(this.tagoviFilterComboBox);
            this.Controls.Add(this.glumciFilterComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filmGroupBox);
            this.Controls.Add(this.filmoviDataGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Filmovi";
            this.Text = "Filmovi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filmoviDataGrid)).EndInit();
            this.filmGroupBox.ResumeLayout(false);
            this.filmGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView filmoviDataGrid;
        private GroupBox filmGroupBox;
        private Label label1;
        private TextBox autorTextBox;
        private TextBox filmTextBox;
        private Label autorLbl;
        private Label filmNazivLbl;
        private ToolStripMenuItem glumciToolStripMenuItem;
        private ToolStripMenuItem tagoviToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ComboBox ocenaComboBox;
        private Label label3;
        private TextBox godinaTextBox;
        private Label label2;
        private Button obrisiBtn;
        private Button izmeniBtn;
        private Button dodajBtn;
        private ListBox tagoviListBox;
        private ListBox glumciListBox;
        private Label deskripcijaLbl;
        private RichTextBox deskripcijaRichTextBox;
        private ComboBox glumciFilterComboBox;
        private ComboBox tagoviFilterComboBox;
        private Label glumacFilterLbl;
        private Label tagFilterLbl;
        private Button filterBtn;
        private Button resetFilterBtn;
    }
}