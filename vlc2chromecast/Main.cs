using System.Diagnostics;

namespace vlc2chromecast
{
    public partial class Main : Form
    {
        private System.Windows.Forms.Timer _timer;

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelStatus.Visible = false;

            _timer = new System.Windows.Forms.Timer();
            _timer.Tick += timer_Tick;
            _timer.Interval = (int)TimeSpan.FromSeconds(5).TotalMilliseconds;

            LoadConfig();

            this.CenterToParent();
        }

        private void LoadConfig()
        {
            if (!File.Exists(GetSettingsFile()))
                return;

            using (StreamReader streamReader = new StreamReader(GetSettingsFile()))
            {
                txtBoxIpAdress.Text = streamReader.ReadLine();
                txtBoxPathToVideoLan.Text = streamReader.ReadLine();
            }
        }

        private void timer_Tick(object? sender, EventArgs e)
        {
            _timer.Stop();
            labelStatus.Visible = false;
        }


        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            _timer.Stop();
            _timer.Tick -= timer_Tick;
        }

        private void Main_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data == null)
                return;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void Main_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data == null)
                return;

            var files = e.Data.GetData(DataFormats.FileDrop) as string[];

            if (files == null)
                return;

            if (files.Length != 1) //we are only intressed if there is only 1 file
                return;

            labelStatus.Visible = true;
            _timer.Start();

            Process process = new Process();
            process.StartInfo = new ProcessStartInfo()
            {
                FileName = txtBoxPathToVideoLan.Text,
                Arguments = $"\"{files.First()}\" --sout \"#chromecast\" --sout-chromecast-ip={txtBoxIpAdress.Text} --demux-filter=demux_chromecast"
            };

            process.Start();
        }

        private void txtBoxPathToVideoLan_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Filter = "Video lan|vlc.exe|All Files|*.*";
            fileDialog.InitialDirectory = @$"C:\{Environment.SpecialFolder.ProgramFiles}\";

            if (fileDialog.ShowDialog() != DialogResult.OK)
                return;

            txtBoxPathToVideoLan.Text = fileDialog.FileName;
        }

        private string GetSettingsFile()
        {
            //Get path where process was started.
            var path = Directory.GetCurrentDirectory();
            var file = Path.Combine(path, "settings.conf");

            return file;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var file = GetSettingsFile();

            if (string.IsNullOrEmpty(txtBoxIpAdress.Text))
                return;

            if (string.IsNullOrEmpty(txtBoxPathToVideoLan.Text))
                return;

            try
            {
                using (StreamWriter streamWriter = new StreamWriter(file, false))
                {
                    streamWriter.WriteLine(txtBoxIpAdress.Text);
                    streamWriter.WriteLine(txtBoxPathToVideoLan.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General error when trying to save settings file: {ex.Message}");
            }
        }
    }
}
