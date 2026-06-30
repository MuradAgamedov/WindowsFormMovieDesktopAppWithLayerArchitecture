namespace FilmApp.FormsUi
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblAppTitle = new Label();
            pnlSearch = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblCount = new Label();
            MoviesDataView = new DataGridView();
            pnlFooter = new Panel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();

            pnlHeader.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MoviesDataView).BeginInit();
            pnlFooter.SuspendLayout();
            SuspendLayout();

            // pnlHeader
            pnlHeader.BackColor = Color.FromArgb(44, 62, 80);
            pnlHeader.Controls.Add(lblAppTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 65;

            // lblAppTitle
            lblAppTitle.Text = "Film Kataloqu";
            lblAppTitle.ForeColor = Color.White;
            lblAppTitle.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblAppTitle.AutoSize = true;
            lblAppTitle.Location = new Point(20, 17);

            // pnlSearch
            pnlSearch.BackColor = Color.FromArgb(236, 240, 241);
            pnlSearch.Controls.Add(lblSearch);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(lblCount);
            pnlSearch.Dock = DockStyle.Top;
            pnlSearch.Height = 55;

            // lblSearch
            lblSearch.Text = "Axtar:";
            lblSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(44, 62, 80);
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(15, 18);

            // txtSearch
            txtSearch.Font = new Font("Segoe UI", 10.5F);
            txtSearch.Location = new Point(75, 14);
            txtSearch.Size = new Size(320, 27);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.PlaceholderText = "Film adına görə axtar...";
            txtSearch.TextChanged += txtSearch_TextChanged;

            // lblCount
            lblCount.Text = "Cəmi: 0 film";
            lblCount.Font = new Font("Segoe UI", 9F);
            lblCount.ForeColor = Color.FromArgb(127, 140, 141);
            lblCount.AutoSize = true;
            lblCount.Location = new Point(415, 18);

            // MoviesDataView
            MoviesDataView.AllowUserToAddRows = false;
            MoviesDataView.AllowUserToDeleteRows = false;
            MoviesDataView.ReadOnly = true;
            MoviesDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MoviesDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MoviesDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MoviesDataView.MultiSelect = false;
            MoviesDataView.BackgroundColor = Color.White;
            MoviesDataView.BorderStyle = BorderStyle.None;
            MoviesDataView.GridColor = Color.FromArgb(220, 220, 220);
            MoviesDataView.RowHeadersVisible = false;
            MoviesDataView.Font = new Font("Segoe UI", 9.5F);
            MoviesDataView.Dock = DockStyle.Fill;
            MoviesDataView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // pnlFooter
            pnlFooter.BackColor = Color.FromArgb(236, 240, 241);
            pnlFooter.Controls.Add(btnDelete);
            pnlFooter.Controls.Add(btnEdit);
            pnlFooter.Controls.Add(btnAdd);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Height = 65;

            // btnAdd
            btnAdd.Text = "+ Əlavə Et";
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.BackColor = Color.FromArgb(39, 174, 96);
            btnAdd.ForeColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Size = new Size(140, 40);
            btnAdd.Location = new Point(15, 13);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Click += btnAdd_Click;

            // btnEdit
            btnEdit.Text = "✎  Düzəlt";
            btnEdit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEdit.BackColor = Color.FromArgb(52, 152, 219);
            btnEdit.ForeColor = Color.White;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.Size = new Size(140, 40);
            btnEdit.Location = new Point(165, 13);
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Click += btnEdit_Click;

            // btnDelete
            btnDelete.Text = "✕  Sil";
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.ForeColor = Color.White;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Size = new Size(140, 40);
            btnDelete.Location = new Point(315, 13);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Click += btnDelete_Click;

            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 600);
            MinimumSize = new Size(720, 500);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Film Tətbiqi";
            Font = new Font("Segoe UI", 9F);
            BackColor = Color.White;
            Name = "Form1";

            Controls.Add(MoviesDataView);
            Controls.Add(pnlFooter);
            Controls.Add(pnlSearch);
            Controls.Add(pnlHeader);

            Load += Form1_Load;

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MoviesDataView).EndInit();
            pnlFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel pnlHeader;
        private Label lblAppTitle;
        private Panel pnlSearch;
        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblCount;
        private DataGridView MoviesDataView;
        private Panel pnlFooter;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}
