using FilmApp.Business.Abstract;
using FilmApp.Entities.Concrete;

namespace FilmApp.FormsUi
{
    public partial class FilmDetailForm : Form
    {
        private readonly IFilmService _filmService;
        private readonly Film? _existingFilm;

        public FilmDetailForm(IFilmService filmService, Film? existingFilm)
        {
            InitializeComponent();
            _filmService = filmService;
            _existingFilm = existingFilm;
        }

        private void FilmDetailForm_Load(object sender, EventArgs e)
        {
            if (_existingFilm != null)
            {
                lblFormTitle.Text = "Filmi Düzəlt";
                Text = "Filmi Düzəlt";
                txtTitle.Text = _existingFilm.Title;
                txtYear.Text = _existingFilm.Year.ToString();
                txtDuration.Text = _existingFilm.Duration.ToString();
                txtRating.Text = _existingFilm.Raiting.ToString();
            }
            else
            {
                lblFormTitle.Text = "Yeni Film Əlavə Et";
                Text = "Yeni Film Əlavə Et";
            }

            txtTitle.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            var film = new Film
            {
                Title = txtTitle.Text.Trim(),
                Year = int.Parse(txtYear.Text.Trim()),
                Duration = int.Parse(txtDuration.Text.Trim()),
                Raiting = int.Parse(txtRating.Text.Trim())
            };

            if (_existingFilm != null)
            {
                film.Id = _existingFilm.Id;
                _filmService.UpdateMovie(film);
            }
            else
            {
                _filmService.AddMovie(film);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                ShowError("Film adını daxil edin.", txtTitle);
                return false;
            }

            if (!int.TryParse(txtYear.Text, out int year) || year < 1888 || year > DateTime.Now.Year + 2)
            {
                ShowError($"Düzgün il daxil edin (1888 - {DateTime.Now.Year + 2}).", txtYear);
                return false;
            }

            if (!int.TryParse(txtDuration.Text, out int duration) || duration <= 0 || duration > 600)
            {
                ShowError("Müddəti dəqiqə ilə daxil edin (1 - 600).", txtDuration);
                return false;
            }

            if (!int.TryParse(txtRating.Text, out int rating) || rating < 1 || rating > 10)
            {
                ShowError("Reytinq 1-10 arasında tam ədəd olmalıdır.", txtRating);
                return false;
            }

            return true;
        }

        private void ShowError(string message, Control focusControl)
        {
            MessageBox.Show(message, "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            focusControl.Focus();
        }
    }
}
