using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;

using TimeZoneNames;

using BigLib;

namespace AllTime
{
    public partial class MainForm : Form
    {
        private BigTime _time = new BigTime(DateTime.UtcNow);
        private string _language = CultureInfo.CurrentCulture.Name;

        public MainForm()
        {
            InitializeComponent();

            bgwTime.WorkerReportsProgress = true;
            bgwTime.WorkerSupportsCancellation = true;

            bgwTime.RunWorkerAsync();
        }

        private void bgwTime_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;

            while (true)
            {
                worker.ReportProgress(0);

                System.Threading.Thread.Sleep(500);
            }
        }

        private void bgwTime_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            BigTime now = BigTime.UtcNow;

            lblCurrentUnixTime.Text = now.ToUnixTime().ToString();

            lblCurrentUtcTime.Text = now.ToString();
            lblInternetTime.Text = now.ToInternetTimeString();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            _time = BigTime.UtcNow;

            RefreshView();
        }

        private void txtUnixTime_Leave(object sender, EventArgs e)
        {
            try
            {
                _time = new BigTime(txtUnixTime.Text);
            }
            catch { }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void RefreshView()
        {
            txtLocalTime.Text = _time.ToLocalTime().ToString();
            txtUnixTime.Text = _time.ToUnixTime().ToString();
            txtUtcTime.Text = _time.ToString();
            txtInternetTime.Text = _time.ToInternetTimeString();

            if (cboTimeZone.SelectedIndex >= 0)
                txtCustomTime.Text = _time.ToLocalTime(((TimeZoneInfo)cboTimeZone.SelectedItem).BaseUtcOffset).ToString();


        }

        private void txtTime_Leave(object sender, EventArgs e)
        {
            _time = DateTime.Parse(txtUtcTime.Text);
        }

        private void txtLocalTime_Leave(object sender, EventArgs e)
        {
            _time = BigTime.Parse(txtLocalTime.Text, TimeZoneInfo.Local);
        }

        private void txtInternetTime_Leave(object sender, EventArgs e)
        {
            if (!txtInternetTime.Text.StartsWith("@"))
                txtInternetTime.Text = "@" + txtInternetTime.Text;

            _time = BigTime.Parse(txtInternetTime.Text);
        }

        private void cboTimeZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshView();

            var customTimeAbbr = TZNames.GetAbbreviationsForTimeZone(((TimeZoneInfo)cboTimeZone.SelectedItem).Id, _language);
            lblCustom.Text = ((TimeZoneInfo)cboTimeZone.SelectedItem).IsDaylightSavingTime(_time.ToLocalTime()) ? customTimeAbbr.Daylight : customTimeAbbr.Standard;
        }

        private void txtCustomTime_Leave(object sender, EventArgs e)
        {
            if (cboTimeZone.SelectedIndex < 0)
                cboTimeZone.SelectedIndex = 0;

            _time = BigTime.Parse(txtCustomTime.Text, (TimeZoneInfo)cboTimeZone.SelectedItem);     
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cboTimeZone.Items.AddRange(TimeZoneInfo.GetSystemTimeZones().ToArray());
        }
    }
}
