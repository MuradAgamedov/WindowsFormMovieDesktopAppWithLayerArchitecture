using FilmApp.Business.Abstract;
using FilmApp.Business.Concrete;
using FilmApp.DataAccess.Concrete.EntityFramework;
using FilmApp.Entities.Concrete;

namespace FilmApp.FormsUi
{
    public partial class Form1 : Form
    {
        private readonly IFilmService _filmService;

        public Form1()
        {
            InitializeComponent();
            _filmService = new FilmManager(new EFFilmDal());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigureGrid();
            LoadGrid();
        }

        private void ConfigureGrid()
        {
            MoviesDataView.AutoGenerateColumns = false;
            MoviesDataView.Columns.Clear();

            MoviesDataView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Width = 60,
                FillWeight = 8
            });
            MoviesDataView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Title",
                HeaderText = "Film Adı",
                FillWeight = 40,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            MoviesDataView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Year",
                HeaderText = "İl",
                Width = 70,
                FillWeight = 10,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
            MoviesDataView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Duration",
                HeaderText = "Müddət (dəq)",
                Width = 110,
                FillWeight = 14,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
            MoviesDataView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Raiting",
                HeaderText = "Reytinq",
                Width = 80,
                FillWeight = 10,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            MoviesDataView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80);
            MoviesDataView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            MoviesDataView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            MoviesDataView.EnableHeadersVisualStyles = false;

            MoviesDataView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 246, 249);
            MoviesDataView.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            MoviesDataView.RowTemplate.Height = 32;
        }

        private void LoadGrid()
        {
            MoviesDataView.DataSource = _filmService.GetMoviesByTitle(txtSearch.Text);
            lblCount.Text = $"Cəmi: {MoviesDataView.Rows.Count} film";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var detailForm = new FilmDetailForm(_filmService, null);
            if (detailForm.ShowDialog() == DialogResult.OK)
                LoadGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (MoviesDataView.CurrentRow == null) return;

            var film = (Film)MoviesDataView.CurrentRow.DataBoundItem;
            var detailForm = new FilmDetailForm(_filmService, film);
            if (detailForm.ShowDialog() == DialogResult.OK)
                LoadGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MoviesDataView.CurrentRow == null) return;

            var film = (Film)MoviesDataView.CurrentRow.DataBoundItem;
            var result = MessageBox.Show(
                $"\"{film.Title}\" filmini silmək istəyirsinizmi?",
                "Silmə Təsdiqi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _filmService.DeleteMovie(film);
                LoadGrid();
            }
        }
    }
}
