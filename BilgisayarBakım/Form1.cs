using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;
using Microsoft.Win32;
using System.Security.AccessControl;
using System.Linq;
using System.Collections.Generic;
using System.Data.SqlTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading.Tasks;

namespace Bilgisayar_Bakım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        bool flag = false;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

            flag = true;

        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)

            {

                this.Location = Cursor.Position;

            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }
        private void button22_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\BilgisayarBakım\Cab\wu10.diagcab");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\BilgisayarBakım\Cab\WindowsFirewall.diagcab");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\BilgisayarBakım\Cab\SearchDiagnostic.diagcab");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\BilgisayarBakım\Cab\startmenu.diagcab");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\BilgisayarBakım\Cab\WinUSB.diagcab");
        }

        private void textEdit1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button7_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C msdt.exe /id NetworkDiagnosticsWeb",
                Verb = "runas",
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            process.Start();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C msdt.exe /id NetworkDiagnosticsFileShare",
                Verb = "runas",
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            process.Start();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C msdt.exe /id NetworkDiagnosticsInbound",
                Verb = "runas",
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            process.Start();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C netsh int ip reset",
                Verb = "runas",
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            listBox2.Items.Add(output);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C msdt.exe /id NetworkDiagnosticsNetworkAdapter",
                Verb = "runas",
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            process.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C ipconfig /flushdns",
                Verb = "runas",
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            listBox2.Items.Add(output);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C ipconfig /release&ipconfig / renew",
                Verb = "runas",
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            listBox2.Items.Add(output);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C netsh winsock reset",
                Verb = "runas",
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            listBox2.Items.Add(output);
        }

        private void button9_Click_2(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C netsh winhttp reset proxy",
                Verb = "runas",
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            listBox2.Items.Add(output);
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C netsh advfirewall reset",
                Verb = "runas",
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            listBox2.Items.Add(output);
        }

        private void button33_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\BilgisayarBakım\Cab\microsoftaccountdiagnostic.diagcab");

        }

        private void button32_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\BilgisayarBakım\Cab\AppsDiagnostic.diagcab");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\BilgisayarBakım\Cab\Printerdiagnostic10.diagcab");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\BilgisayarBakım\Cab\onedrivets.diagcab");
        }

        private void button29_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\BilgisayarBakım\Cab\winfilefolder.DiagCab");
        }



        private void button20_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\BilgisayarBakım\Cab\MicrosoftProgram_Install_and_Uninstall.meta.diagcab");
        }



        private void metroTabPage3_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string historyFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Google\Chrome\User Data\Default\History");

            if (File.Exists(historyFile))
            {
                try
                {
                    File.Delete(historyFile);
                    listBox1.Items.Add("Chrome geçmiş dosyası başarıyla temizlendi.");
                }
                catch (Exception ex)
                {
                    listBox1.Items.Add("Chrome geçmiş dosyasını temizlerken bir hata oluştu: " + ex.Message);
                }
            }
            else
            {
                listBox1.Items.Add("Chrome geçmiş dosyası bulunamadı.");
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            string historyFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Opera Software\\Opera\\History");
            if (File.Exists(historyFile))
            {
                try
                {
                    File.Delete(historyFile);
                    listBox1.Items.Add("Opera geçmiş dosyası başarıyla temizlendi.");
                }
                catch (Exception ex)
                {
                    listBox1.Items.Add("Opera geçmiş dosyasını temizlerken bir hata oluştu: " + ex.Message);
                }

            }
            else
            {
                listBox1.Items.Add("Opera geçmiş dosyası bulunamadı.");
            }


        }

        private void button16_Click(object sender, EventArgs e)
        {

            string historyFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Opera Software\\Opera GX Stable\\History");
            try
            {
                if (File.Exists(historyFolder))
                {
                    File.Delete(historyFolder);
                    listBox1.Items.Add("Geçmiş başarıyla silindi.");
                }
                else
                {
                    listBox1.Items.Add("Geçmiş zaten silinmiş veya bulunamadı.");
                }
            }
            catch (IOException ex)
            {
                listBox1.Items.Add("Geçmiş silinirken bir hata oluştu: " + ex.Message);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                string edgeHistoryPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Microsoft\Edge\User Data\Default\History";
                File.Delete(edgeHistoryPath);
                listBox1.Items.Add("Edge tarayıcısının geçmişi başarıyla temizlendi.");
            }
            catch (Exception ex)
            {
                listBox1.Items.Add("Hata oluştu: " + ex.Message);
            }


        }

        private async void button23_Click(object sender, EventArgs e)
        {
            bool errorOccurred = false; // Hata durumu için flag
            string logFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "delete_errors_log.txt");

            // Geçici dosya ve klasörler
            string[] tempDirs =
            {
                Path.GetTempPath(), // Kullanıcı Temp Klasörü
                "C:\\Windows\\Temp", // Windows Temp Klasörü
                "C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Temp", // Kullanıcı AppData Temp
                "C:\\Windows\\SoftwareDistribution\\Download", // Windows Update İndirilen Dosyalar
                "C:\\ProgramData\\Microsoft\\Windows\\WER\\ReportQueue", // Windows Hata Raporları
                "C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Microsoft\\Windows\\INetCache", // Internet Explorer Cache
                "C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Microsoft\\Edge\\User Data\\Default\\Cache", // Edge Cache
                "C:\\ProgramData\\Microsoft\\Windows Defender\\Scans\\History\\Store", // Microsoft Defender Geçmişi
                "C:\\Windows\\System32\\DriverStore\\FileRepository", // DirectX Gölgeleme Önbelleği
                "C:\\Windows\\SoftwareDistribution\\DeliveryOptimization\\DeploymentService\\Machine", // Teslim İyileştirme Dosyaları
                "C:\\Windows\\SoftwareDistribution\\DeliveryOptimization\\DeploymentService\\Logs", // Teslim İyileştirme Günlükleri
                "C:\\Windows\\SoftwareDistribution\\DeliveryOptimization\\DeploymentService\\Cache", // Teslim İyileştirme Önbelleği
                "C:\\Windows\\SoftwareDistribution\\DataStore", // Teslim İyileştirme Dosyaları
                "C:\\Windows\\Prefetch", // Windows Prefetch
                "C:\\ProgramData\\Microsoft\\Windows\\WER\\ReportArchive", // Windows Error Reporting (WER) Arşiv
                "C:\\Windows\\System32\\winevt\\Logs", // Windows Sistem Günlükleri
                "C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache", // Chrome Cache
                "C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Mozilla\\Firefox\\Profiles", // Firefox Cache
                "C:\\Windows\\System32\\FNTCACHE.DAT", // Font Cache
                "C:\\Windows\\Installer", // Windows Installer Cache
                "C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Microsoft\\Windows\\Explorer", // System Thumbnail Cache
                "C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Microsoft\\DirectX\\ShaderCache", // DirectX Shader Cache
                "C:\\Windows\\LiveKernelReports", // Bellek Dökümleri
                "C:\\Windows\\Logs", // Olay Günlükleri
            };

            // PowerShell komutları için çalıştırılacak komutlar
            string[] powershellCommands =
            {
                "Clear-BCCache -Force", // Edge ve IE cache'lerini temizler
                "Clear-DnsClientCache", // DNS önbelleğini temizler
                "Clear-EventLog -LogName Application", // Uygulama olay günlüklerini temizler
                "Clear-History", // PowerShell geçmişini temizler
                "Delete-DeliveryOptimizationCache -Force" // Teslim İyileştirme önbelleğini temizler
            };

            // Geçici dosya ve klasörleri temizle
            foreach (var dir in tempDirs)
            {
                if (Directory.Exists(dir))
                {
                    try
                    {
                        // Dosyaları temizle
                        foreach (var file in Directory.GetFiles(dir))
                        {
                            File.Delete(file);
                        }

                        // Klasörleri temizle
                        foreach (var subDir in Directory.GetDirectories(dir))
                        {
                            Directory.Delete(subDir, true); // alt klasörleri de sil
                        }
                    }
                    catch (Exception ex)
                    {
                        // Hata log dosyasına kaydedilir
                        File.AppendAllText(logFilePath, $"Hata oluştu: {dir} - Hata: {ex.Message}\n");
                        errorOccurred = true;
                    }
                }
                else
                {
                    // Eğer dizin yoksa, hata log dosyasına kaydedilir
                    File.AppendAllText(logFilePath, $"Dizin bulunamadı: {dir}\n");
                    errorOccurred = true;
                }
            }

            // PowerShell komutlarını arka planda çalıştır
            foreach (var command in powershellCommands)
            {
                await ExecutePowerShellCommandAsync(command);
            }

            // Hata olsa da olmasada
            if (errorOccurred)
            {
                // Silme işleminin başarılı olduğunu göster
                listBox1.Items.Add("İstenmeyen dosyalar başarıyla silindi.");
            }
            else
            {
                // Hataların kaydedildiğini ve log dosyasına bakılması gerektiğini bildir
                listBox1.Items.Add("Bazı dosya/dizinler silinemedi. Hatalar log dosyasına kaydedildi.");
            }
        }



        private async Task ExecutePowerShellCommandAsync(string command)
        {
            try
            {
                // Komut çalıştırılmaya başlandıysa sadece çıktıyı ekle
                var startInfo = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = $"-Command \"{command}\"",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,  // Bunu false yapıyoruz ki çıktı yakalayabilelim
                    CreateNoWindow = true,
                    Verb = "runas" // YÖNETİCİ olarak çalıştır
                };

                using (var process = new System.Diagnostics.Process())
                {
                    process.StartInfo = startInfo;
                    process.Start();

                    // Çıktıları asenkron olarak oku
                    string output = await process.StandardOutput.ReadToEndAsync();
                    string error = await process.StandardError.ReadToEndAsync();

                    // Çıktıyı ListBox'a ekle
                    if (!string.IsNullOrEmpty(output))
                    {
                        listBox1.Items.Add($"{output}");
                    }

                    // Hata mesajlarını log dosyasına kaydet
                    if (!string.IsNullOrEmpty(error))
                    {
                        string logFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "delete_errors_log.txt");
                        File.AppendAllText(logFilePath, $"Hata oluştu: {command} - Hata: {error}\n");
                    }

                    // Komutun bitmesini bekleyelim
                    await Task.Run(() => process.WaitForExit());
                }

                // Komut başarılıysa ListBox'a sadece çıktı ekle
            }
            catch (Exception ex)
            {
                // Hata durumunda Log dosyasına kaydet
                string logFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "delete_errors_log.txt");
                File.AppendAllText(logFilePath, $"Komut çalıştırılırken hata oluştu: {command} - Hata: {ex.Message}\n");
            }
        }











        private void button10_Click_1(object sender, EventArgs e)
        {
            // Güvenle silinebilecek kayıt defteri anahtarlarını tanımlıyoruz.
            string[] registryPaths =
            {
                @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\RunMRU", // Geçmiş komutlar
                @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\RecentDocs", // Son belgeler
                @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\ComDlg32", // Dosya diyalog geçmişi
                @"HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\TypedURLs", // Internet Explorer geçmişi
                @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\Folders", // Yazılım yükleme geçmişi
                @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\WER\ReportQueue", // Hata raporlama verisi
                @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Taskband" // Görev çubuğu uygulama geçmişi
            };

            bool errorOccurred = false;

            foreach (var regPath in registryPaths)
            {
                try
                {
                    // Kayıt defteri anahtarının varlığını kontrol etme
                    RegistryKey key = null;
                    if (regPath.StartsWith("HKEY_CURRENT_USER"))
                    {
                        key = Registry.CurrentUser.OpenSubKey(regPath, writable: true);
                    }
                    else if (regPath.StartsWith("HKEY_LOCAL_MACHINE"))
                    {
                        key = Registry.LocalMachine.OpenSubKey(regPath, writable: true);
                    }

                    // Anahtar var mı kontrol et
                    if (key != null)
                    {
                        // Anahtarları temizle
                        key.GetValueNames().ToList().ForEach(value => key.DeleteValue(value));
                        key.Close();
                    }
                }
                catch (Exception ex)
                {
                    // Hata durumu
                    MessageBox.Show($"Kayıt defteri temizleme hatası: {regPath}\nHata: {ex.Message}",
                                     "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorOccurred = true;
                }
            }

            // Başarı mesajı
            if (!errorOccurred)
            {
                listBox1.Items.Add("Kayıt defteri anahtarları başarıyla temizlendi! Temizlik Tamamlandı");
            }
        }

        

        

        private void button14_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }    
}

