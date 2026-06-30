namespace FilmApp.FormsUi
{
    partial class FilmDetailForm
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
            lblFormTitle = new Label();
            grpFields = new GroupBox();
            lblTitleField = new Label();
            txtTitle = new TextBox();
            lblYearField = new Label();
            txtYear = new TextBox();
            lblDurationField = new Label();
            txtDuration = new TextBox();
            lblRatingField = new Label();
            txtRating = new TextBox();
            pnlFooter = new Panel();
            btnSave = new Button();
            btnCancel = new Button();

            pnlHeader.SuspendLayout();
            grpFields.SuspendLayout();
            pnlFooter.SuspendLayout();
            SuspendLayout();

            // pnlHeader
            pnlHeader.BackColor = Color.FromArgb(44, 62, 80);
            pnlHeader.Controls.Add(lblFormTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 65;

            // lblFormTitle
            lblFormTitle.Text = "Yeni Film Əlavə Et";
            lblFormTitle.ForeColor = Color.White;
            lblFormTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblFormTitle.AutoSize = true;
            lblFormTitle.Location = new Point(20, 18);

            // grpFields
            grpFields.Text = "Film Məlumatları";
            grpFields.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpFields.ForeColor = Color.FromArgb(44, 62, 80);
            grpFields.Location = new Point(20, 80);
            grpFields.Size = new Size(395, 225);
            grpFields.Controls.Add(lblTitleField);
            grpFields.Controls.Add(txtTitle);
            grpFields.Controls.Add(lblYearField);
            grpFields.Controls.Add(txtYear);
            grpFields.Controls.Add(lblDurationField);
            grpFields.Controls.Add(txtDuration);
            grpFields.Controls.Add(lblRatingField);
            grpFields.Controls.Add(txtRating);

            int labelX = 15;
            int fieldX = 150;
            int fieldW = 225;
            int rowH = 45;
            int startY = 28;

            // Row 1 - Title
            lblTitleField.Text = "Film Adı:";
            lblTitleField.Font = new Font("Segoe UI", 9.5F);
            lblTitleField.ForeColor = Color.FromArgb(80, 80, 80);
            lblTitleField.AutoSize = true;
            lblTitleField.Location = new Point(labelX, startY + 8);

            txtTitle.Font = new Font("Segoe UI", 10F);
            txtTitle.Location = new Point(fieldX, startY + 3);
            txtTitle.Size = new Size(fieldW, 27);
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.PlaceholderText = "Film adını daxil edin";

            // Row 2 - Year
            lblYearField.Text = "Buraxılış İli:";
            lblYearField.Font = new Font("Segoe UI", 9.5F);
            lblYearField.ForeColor = Color.FromArgb(80, 80, 80);
            lblYearField.AutoSize = true;
            lblYearField.Location = new Point(labelX, startY + rowH + 8);

            txtYear.Font = new Font("Segoe UI", 10F);
            txtYear.Location = new Point(fieldX, startY + rowH + 3);
            txtYear.Size = new Size(fieldW, 27);
            txtYear.BorderStyle = BorderStyle.FixedSingle;
            txtYear.PlaceholderText = "məs: 2023";

            // Row 3 - Duration
            lblDurationField.Text = "Müddət (dəq):";
            lblDurationField.Font = new Font("Segoe UI", 9.5F);
            lblDurationField.ForeColor = Color.FromArgb(80, 80, 80);
            lblDurationField.AutoSize = true;
            lblDurationField.Location = new Point(labelX, startY + rowH * 2 + 8);

            txtDuration.Font = new Font("Segoe UI", 10F);
            txtDuration.Location = new Point(fieldX, startY + rowH * 2 + 3);
            txtDuration.Size = new Size(fieldW, 27);
            txtDuration.BorderStyle = BorderStyle.FixedSingle;
            txtDuration.PlaceholderText = "dəqiqə ilə";

            // Row 4 - Rating
            lblRatingField.Text = "Reytinq (1-10):";
            lblRatingField.Font = new Font("Segoe UI", 9.5F);
            lblRatingField.ForeColor = Color.FromArgb(80, 80, 80);
            lblRatingField.AutoSize = true;
            lblRatingField.Location = new Point(labelX, startY + rowH * 3 + 8);

            txtRating.Font = new Font("Segoe UI", 10F);
            txtRating.Location = new Point(fieldX, startY + rowH * 3 + 3);
            txtRating.Size = new Size(fieldW, 27);
            txtRating.BorderStyle = BorderStyle.FixedSingle;
            txtRating.PlaceholderText = "1-10";

            // pnlFooter
            pnlFooter.BackColor = Color.FromArgb(236, 240, 241);
            pnlFooter.Controls.Add(btnCancel);
            pnlFooter.Controls.Add(btnSave);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Height = 65;

            // btnSave
            btnSave.Text = "✔  Yadda Saxla";
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.BackColor = Color.FromArgb(39, 174, 96);
            btnSave.ForeColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Size = new Size(155, 40);
            btnSave.Location = new Point(65, 13);
            btnSave.Cursor = Cursors.Hand;
            btnSave.Click += btnSave_Click;

            // btnCancel
            btnCancel.Text = "✕  İmtina";
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.BackColor = Color.FromArgb(149, 165, 166);
            btnCancel.ForeColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Size = new Size(155, 40);
            btnCancel.Location = new Point(230, 13);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Click += btnCancel_Click;

            // FilmDetailForm
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 395);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Yeni Film Əlavə Et";
            Font = new Font("Segoe UI", 9F);
            BackColor = Color.White;
            Name = "FilmDetailForm";

            Controls.Add(grpFields);
            Controls.Add(pnlFooter);
            Controls.Add(pnlHeader);

            Load += FilmDetailForm_Load;

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            grpFields.ResumeLayout(false);
            grpFields.PerformLayout();
            pnlFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel pnlHeader;
        private Label lblFormTitle;
        private GroupBox grpFields;
        private Label lblTitleField;
        private TextBox txtTitle;
        private Label lblYearField;
        private TextBox txtYear;
        private Label lblDurationField;
        private TextBox txtDuration;
        private Label lblRatingField;
        private TextBox txtRating;
        private Panel pnlFooter;
        private Button btnSave;
        private Button btnCancel;
    }
}
