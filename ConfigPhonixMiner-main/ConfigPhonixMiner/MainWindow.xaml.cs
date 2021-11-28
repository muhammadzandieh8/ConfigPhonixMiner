using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Navigation;
using System.Collections.Generic;
using System.Windows.Media.Imaging;
using System.Diagnostics;
namespace ConfigPhonixMiner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            #region App
            appli.Add("PhonixMiner");
            cmbo_App.ItemsSource = appli;
            #endregion
            #region Coin
            Coinli.Add("start_miner");
            Coinli.Add("start_miner_etc");
            Coinli.Add("Yocoin-altpool");
            Coinli.Add("Yocoin-2miners");
            Coinli.Add("WhaleCoin-minerpool");
            Coinli.Add("WhaleCoin-altpool");
            Coinli.Add("Victorium-victorium-pool");
            Coinli.Add("Victorium-pool.sexy");
            Coinli.Add("UBQ-Ubiqpool.io");
            Coinli.Add("UBQ-minerpool");
            Coinli.Add("UBQ-maxhash");
            Coinli.Add("UBQ-hodlpool");
            Coinli.Add("REOSC-ddnsking");
            Coinli.Add("QuarkChain-ontopool");
            Coinli.Add("PIRL-pool.sexy");
            Coinli.Add("PIRL-pool.se");
            Coinli.Add("PIRL-Minerpool");
            Coinli.Add("Nilu-pool-so");
            Coinli.Add("Nilu-minerpool");
            Coinli.Add("Nicehash");
            Coinli.Add("Nekonium-ftlpool");
            Coinli.Add("Nekonium-coinminer");
            Coinli.Add("Musicoin-nomnom");
            Coinli.Add("Musicoin-miningpoolhub");
            Coinli.Add("Musicoin-miningclub");
            Coinli.Add("Musicoin-minerpool");
            Coinli.Add("Musicoin-epool");
            Coinli.Add("Moac-moacpool");
            Coinli.Add("Moac-moac.bylt");
            Coinli.Add("MIX-Blockchain-minerpool");
            Coinli.Add("Metaverse-topmining");
            Coinli.Add("Metaverse-sandpool");
            Coinli.Add("Metaverse-dodopool");
            Coinli.Add("Metaverse-cryptopoolpond");
            Coinli.Add("Goldiam-goldiam-pool");
            Coinli.Add("Goldiam-goldiam-mining-gol.pool-sexy");
            Coinli.Add("Expanse-miningpoolhub");
            Coinli.Add("Expanse-expmine");
            Coinli.Add("Expanse-dwarfpool");
            Coinli.Add("EtherZero-minerpool");
            Coinli.Add("EtherInc-rustpool");
            Coinli.Add("EtherInc-crazypool");
            Coinli.Add("EtherGem -pool.egem");
            Coinli.Add("EtherGem -minerpool");
            Coinli.Add("Ethereum Social-topmining");
            Coinli.Add("Ethereum Social-sejun");
            Coinli.Add("Ethereum Social-miningpoolhub");
            Coinli.Add("Ethereum Social-gonsmine");
            Coinli.Add("Ether1-pool.s");
            Coinli.Add("Ether1-minerpool");
            Coinli.Add("Ellaism-Minerpool");
            Coinli.Add("Ellaism-ellaismpool");
            Coinli.Add("Elementrem-coinminer");
            Coinli.Add("DubaiCoin-mine.house");
            Coinli.Add("DubaiCoin-dbixmine");
            Coinli.Add("DubaiCoin");
            Coinli.Add("dual-music-nomnom-xvg-unimining");
            Coinli.Add("dual-music-miningclubx-vg-unimining");
            Coinli.Add("dual-expanse-miningpoolhub-xvg-unimining");
            Coinli.Add("dual-ethereum-verge-dwarfpool-unimining");
            Coinli.Add("dual-ethereum-ethermine-tajcoin-zergpool");
            Coinli.Add("dual-ethereum-ethermine-shield-unimining");
            Coinli.Add("dual-ethereum-ethermine-shield-antminepool");
            Coinli.Add("dual-Ethereum-ethermine - blake2s");
            Coinli.Add("dual-ethereum-classic-nanopool-xvg-unimining");
            Coinli.Add("dual-ethereum-classic-miningpoolhub-xvg-unimining");
            Coinli.Add("dual-ethereum-classic-ethermine-xvg-unimining");
            Coinli.Add("dual-ethereum-classic-ethermine-shield-antminepool");
            Coinli.Add("dual-ethereum-and-verge-nanopoo-unimining");
            Coinli.Add("dual-ethereum-and-verge-nanopool-antminerpool");
            Coinli.Add("dual-Ellaism-Minerpool-XVG-Unimining");
            Coinli.Add("Dogethereum-fairpool");
            Coinli.Add("Calisto-topmining");
            Coinli.Add("Calisto-epool");
            Coinli.Add("Calisto-clopool");
            Coinli.Add("Calisto-clo.pool.sexy");
            Coinli.Add("Calisto-callistopool");
            Coinli.Add("Calisto-2miners");
            Coinli.Add("Bitcoin Interest-suprnova");
            Coinli.Add("Bitcoin Interest-luckypool");
            Coinli.Add("Bitcoiin2Gen-nusapool");
            Coinli.Add("Bitcoiin2Gen-dragonmining");
            Coinli.Add("Bitcoiin2Gen-baikalmine");
            Coinli.Add("Aura-minerpool");
            Coinli.Add("Atheios-pool.atheios");
            Coinli.Add("Atheios-minerpool");
            Coinli.Add("Akroma-minerpool");
            Coinli.Add("28_ethereum-classic-hashcity");
            Coinli.Add("27_ethereum-classic-crazypool");
            Coinli.Add("26_ethereum-classic-emcd");
            Coinli.Add("25_ethereum-classic-beepool");
            Coinli.Add("24_ethereum-classic-coinmine");
            Coinli.Add("23_Ethereum-classic-hiveon");
            Coinli.Add("22_ethereum-classic-miningpoolhub");
            Coinli.Add("21_ethereum-classic-nanopool");
            Coinli.Add("20_ethereum-classic-ethermine");
            Coinli.Add("20_Ehereum-binance-pool");
            Coinli.Add("19_Ehereum-firepool");
            Coinli.Add("18_Ehereum-emcd");
            Coinli.Add("17_Ehereum-beepool");
            Coinli.Add("16_Ehereum-2miners");
            Coinli.Add("15. Ethereum-nicehash");
            Coinli.Add("14_Ethereum-whalesburg");
            Coinli.Add("13_Ethereum-hiveon");
            Coinli.Add("12_Ethereum-coinotron");
            Coinli.Add("11_Ethereum-gpumine");
            Coinli.Add("10_Ethereum-uupool");
            Coinli.Add("9_Ethereum-pandaminer");
            Coinli.Add("8_Ethereum-sparkpool");
            Coinli.Add("7_Ethereum-nanopool_and_email");
            Coinli.Add("6_Ethereum-minerall");
            Coinli.Add("5_Ethereum-ethermine");
            Coinli.Add("4_Etereum-spiderpool");
            Coinli.Add("3_Ethereum-f2pool");
            Coinli.Add("2_Ethereum--miningpoolhub");
            Coinli.Add("1_Ehereum-nanopool");
            cmbo_coin.ItemsSource = Coinli;
            #endregion
        }
        #region Variable
        static string AppFileLocation = "";
        private string[] files;
        private string[] lines;
        List<string> appli = new List<string>();
        List<string> Coinli = new List<string>();
        private string[] mm;
        private string[] zm;
        #endregion
        #region Func: ChooseConfig
        public void ChooseConfig(string AppName, string CoinName, string ConfigName, string selectedpath)
        {
            #region PhonixMiner
            if (AppName == "PhonixMiner")
            {

                files = Directory.GetFiles(selectedpath);
                foreach (var item in files)
                {
                    if (item.Contains(ConfigName))
                    {
                        //System.Windows.MessageBox.Show("start_miner_etc.bat Founded");
                        AppFileLocation = item;
                        if (File.Exists(AppFileLocation))
                        {
                            // Read entire text file content in one string    
                            //string text = File.ReadAllText(textFile);
                            //txtresult.Text = text;

                            lines = System.IO.File.ReadAllLines(AppFileLocation);
                            if (ConfigType1(CoinName))
                            {
                                for (int i = 0; i < lines.Length; i++)
                                {
                                    if (lines[i].Contains("PhoenixMiner.exe -pool"))
                                    {
                                        string tempconfig = lines[i].ToString();
                                        mm = tempconfig.Split(' ');
                                        txt_Pool.Text = mm[2];
                                        txt_wallet.Text = mm[4];
                                        txt_Worker.Text = mm[6];
                                    }
                                }
                                //foreach (var line in lines)
                                //{
                                //    temp += line;
                                //    temp += "\n";
                                //}
                                //txtresult.Text = temp;
                                //temp = "";


                            }
                            else if (ConfigType2(CoinName))

                            {
                                for (int i = 0; i < lines.Length; i++)
                                {
                                    if (lines[i].Contains("PhoenixMiner.exe -pool"))
                                    {
                                        string tempconfig = lines[i].ToString();
                                        mm = tempconfig.Split(' ');
                                        txt_Pool.Text = mm[2];
                                        zm = mm[4].Split('.');
                                        txt_wallet.Text = zm[0];
                                        txt_Worker.Text = zm[1];
                                    }
                                }
                            }
                        }
                    }
                }
            }
            #endregion
        }
        #endregion
        #region Controler
        private void Btn_load_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Dispatcher.Invoke((Action)delegate
            {
            if (cmbo_App.Text.ToString() != "" && cmbo_coin.Text.ToString() != "")
            {
                #region PhonixMiner
                if (Properties.Settings.Default.ApplicationPath != "")
                {
                    ChooseConfig("PhonixMiner", cmbo_coin.SelectedValue.ToString(), cmbo_coin.SelectedValue.ToString() + ".bat", Properties.Settings.Default.ApplicationPath);
                }
                else
                {
                    using (var fbd = new FolderBrowserDialog())
                    {
                        DialogResult result = fbd.ShowDialog();
                        if (result == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                        {
                            Properties.Settings.Default.ApplicationPath = fbd.SelectedPath;
                            Properties.Settings.Default.Save();
                            ChooseConfig("PhonixMiner", cmbo_coin.SelectedValue.ToString(), cmbo_coin.SelectedValue.ToString() + ".bat", Properties.Settings.Default.ApplicationPath);
                        }
                    }
                }
                #endregion
            }
            else
            {
                System.Windows.MessageBox.Show("Please SelectApp & SelectCoin");
            }
            });
        }
        private void Btn_Apply_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Dispatcher.Invoke((Action)delegate
            {
                string CoinName = cmbo_coin.SelectedValue.ToString();
            if (ConfigType1(CoinName))
            {
                #region Should Like This But Not Compelete
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Contains("PhoenixMiner.exe -pool"))
                    {
                        string temp = "";
                        string tempconfig = lines[i].ToString();
                        mm = tempconfig.Split(' ');
                        mm[2] = txt_Pool.Text;
                        mm[4] = txt_wallet.Text;
                        mm[6] = txt_Worker.Text;
                        for (int n = 0;  n < mm.Length; n++)
                        {
                            temp=  temp + mm[n] + ' ';
                        }
                        lines[i] = temp;
                        StreamWriter strw = new StreamWriter(Properties.Settings.Default.ApplicationPath+ "\\" + CoinName + ".bat");
                        string temp_out = "";
                        foreach (var line in lines)
                        {
                            temp_out += line;
                            temp_out += "\n";
                        }
                        strw.WriteLine(temp_out);
                        strw.Flush();
                    }
                }
                #endregion
            }
            else if (ConfigType2(CoinName))
            {
                #region  Should Like This But Not Compelete
                //lines = System.IO.File.ReadAllLines(textFile);
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Contains("PhoenixMiner.exe -pool"))
                    {
                        CoinName = cmbo_coin.SelectedValue.ToString();
                        string tempconfig = lines[i].ToString();
                        mm = tempconfig.Split(' ');
                        mm[2] = txt_Pool.Text;
                        mm[4] = txt_wallet.Text + "." + txt_Worker.Text;
                        string temp="";
                        for (int n = 0; n < mm.Length; n++)
                        {
                            temp = temp + mm[n] + ' ';
                        }
                        lines[i] = temp;
                        StreamWriter strw = new StreamWriter(Properties.Settings.Default.ApplicationPath + "\\" + CoinName + ".bat");
                        string temp_out = "";
                        foreach (var line in lines)
                        {
                            temp_out += line;
                            temp_out += "\n";
                        }
                        strw.WriteLine(temp_out);
                        strw.Flush();
                    }
                }
                #endregion
            }
            });
        }
        #endregion
        private bool ConfigType1(string _coinname)
        {
            bool flagConfigType1;
            if (_coinname != "Nicehash" &
                _coinname != "start_miner" &
                _coinname != "start_miner_etc" &
                _coinname != "18_Ehereum-emcd" &
                _coinname != "4_Etereum-spiderpool" &
                _coinname != "15. Ethereum-nicehash" &
                _coinname != "Expanse-miningpoolhub" &
                _coinname != "Musicoin-miningpoolhub" &
                _coinname != "26_ethereum-classic-emcd" &
                _coinname != "2_Ethereum--miningpoolhub" &
                _coinname != "28_ethereum-classic-hashcity" &
                _coinname != "24_ethereum-classic-coinmine" &
                _coinname != "7_Ethereum-nanopool_and_email" &
                _coinname != "22_ethereum-classic-miningpoolhub" &
                _coinname != "dual-Ethereum-ethermine - blake2s" &
                _coinname != "dual-ethereum-verge-dwarfpool-unimining" &
                _coinname != "dual-expanse-miningpoolhub-xvg-unimining" &
                _coinname != "dual-ethereum-ethermine-shield-unimining" &
                _coinname != "dual-ethereum-ethermine-tajcoin-zergpool" &
                _coinname != "dual-ethereum-ethermine-shield-antminepool" &
                _coinname != "dual-ethereum-classic-ethermine-xvg-unimining" &
                _coinname != "dual-ethereum-classic-miningpoolhub-xvg-unimining" &
                _coinname != "dual-ethereum-classic-ethermine-shield-antminepool")
            {
                flagConfigType1 = true;
            }
            else
            {
                flagConfigType1 = false;
            }
            return flagConfigType1;
        }
        private bool ConfigType2(string _coinName)
        {
            bool flagConfigType2;
            if (
                _coinName == "start_miner" |
                _coinName == "start_miner_etc" |
                _coinName == "18_Ehereum-emcd" |
                _coinName == "4_Etereum-spiderpool" |
                _coinName == "Expanse-miningpoolhub" |
                _coinName == "Musicoin-miningpoolhub" |
                _coinName == "26_ethereum-classic-emcd" |
                _coinName == "2_Ethereum--miningpoolhub" |
                _coinName == "28_ethereum-classic-hashcity" |
                _coinName == "24_ethereum-classic-coinmine" |
                _coinName == "7_Ethereum-nanopool_and_email" |
                _coinName == "22_ethereum-classic-miningpoolhub" |
                _coinName == "dual-Ethereum-ethermine - blake2s" |
                _coinName == "dual-ethereum-verge-dwarfpool-unimining" |
                _coinName == "dual-expanse-miningpoolhub-xvg-unimining" |
                _coinName == "dual-ethereum-ethermine-shield-unimining" |
                _coinName == "dual-ethereum-ethermine-tajcoin-zergpool" |
                _coinName == "dual-ethereum-ethermine-shield-antminepool" |
                //_coinName == "dual-ethereum-classic-ethermine-xvg-unimining" |
                //_coinName == "dual-ethereum-classic-miningpoolhub-xvg-unimining" |
                _coinName == "dual-ethereum-classic-ethermine-shield-antminepool")
            {
                flagConfigType2 = true;
            }
            else
            {
                flagConfigType2 = false;
            }
            return flagConfigType2;
        }
        private void cmbo_coin_DropDownClosed(object sender, EventArgs e)
        {
            if (cmbo_App.Text.ToString() != "" && cmbo_coin.Text.ToString() != "")
            {
                if (Properties.Settings.Default.ApplicationPath != "")
                {
                    ChooseConfig("PhonixMiner", cmbo_coin.SelectedValue.ToString(), cmbo_coin.SelectedValue.ToString() + ".bat", Properties.Settings.Default.ApplicationPath);
                }
            }
        }

        private void Btn_Run_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Dispatcher.Invoke((Action)delegate
            {
                if (cmbo_App.Text.ToString() != "" && cmbo_coin.Text.ToString() != "")
                {
                    #region PhonixMiner
                    if (Properties.Settings.Default.ApplicationPath != "")
                    {
                        Process.Start(Properties.Settings.Default.ApplicationPath + "\\" + cmbo_coin.SelectedValue + ".bat");
                    }
                    else
                    {
                        using (var fbd = new FolderBrowserDialog())
                        {
                            DialogResult result = fbd.ShowDialog();
                            if (result == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                            {
                                Properties.Settings.Default.ApplicationPath = fbd.SelectedPath;
                                Properties.Settings.Default.Save();
                                Process.Start(Properties.Settings.Default.ApplicationPath + "\\" + cmbo_coin.SelectedValue + ".bat");


                            }
                        }
                    }
                    #endregion
                }
                else
                {
                    System.Windows.MessageBox.Show("Please SelectApp & SelectCoin");
                }
            });
        }
    }
}