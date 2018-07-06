using System;
using System.Windows.Forms;
using System.Diagnostics;
using DotRas;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Drawing;

using VPN_Connect.Controller;

namespace VPN_Connect
{
    public partial class Login : Form
    {
        MessageController InfoMsg = new MessageController();
        Image greendot = Image.FromFile(@"./assets/imgs/greendot.png");
        Image reddot = Image.FromFile(@"./assets/imgs/reddot.png");

        public Login()
        {
            InitializeComponent();
            
            extra_info_label.Text = "";
            ChangeUpdateTime();
            ChangeState(false);

            if (IsConnectedVPN())               
            {
                /*================Run the softphone exe.================*/
                ChangeUpdateTime();
                ChangeState(true);
            }
            else
            {
                try { VPN.CreateVPN(); }
                catch { InfoMsg.alertMsg("1002"); }
                finally { InfoMsg.ConsoleMsg("2001"); }
            }
        }

        //Button "Connect" onclick
        private void connect_vpn_Click(object sender, EventArgs e)
        {
            extra_info_label.Text = "";
            if (username.Text != "" && password.Text != "")
            {
                if (!IsConnectedVPN()) {
                    if (VPN.TestConnection())
                    {
                        try { VPN.ConnectToVPN(username.Text, password.Text); }
                        catch { InfoMsg.alertMsg("1003"); }
                    }
                    else
                    {
                        InfoMsg.alertMsg("1004");
                    }
                }
                else
                {
                    InfoMsg.alertMsg("2003");   //System: Connect Already Connected.
                }
            }
            else if (username.Text.ToLower() == InfoMsg.ReturnMsg("3001"))
            {
                extra_info_label.Text = GetIP();
            }
            else
            {
                InfoMsg.alertMsg("1001");
            }
        }

        //Button "DisConnect" onclick
        private void disconnect_vpn_Click(object sender, EventArgs e)
        {
            extra_info_label.Text = "";
            if (IsConnectedVPN()) VPN.DisconnectFromVPN();
        }

        //Button "Check Connection State" onclick
        private void checkState_Click(object sender, EventArgs e)
        {
            extra_info_label.Text = "";
            VPN vpn = new VPN();
            if (IsConnectedVPN())
            {
                ChangeUpdateTime();
                ChangeState(true);
            }
            else
            {
                ChangeUpdateTime();
                ChangeState(false);
            }
        }

        //Label "copyright" onclick
        private void copyright_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://itboxtech.com/");
        }



        //Get device's true IP from checkip.dyndns.org
        public string GetIP()
        {
            try
            {
                String address = "";
                WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
                using (WebResponse response = request.GetResponse())
                using (StreamReader stream = new StreamReader(response.GetResponseStream()))
                {
                    address = stream.ReadToEnd();
                }

                int first = address.IndexOf("Address: ") + 9;
                int last = address.LastIndexOf("</body>");
                address = address.Substring(first, last - first);

                return address;
            }
            catch
            {
                InfoMsg.alertMsg("1004");
                return "";
            }
        }

        //Check VPN connected or not
        public bool IsConnectedVPN()
        {
            VPN vpn = new VPN();
            if (GetIP() == vpn.IPToPing) return true;
            else return false;
        }

        //Executing exe program on the device with path
        public void executeProgram(string path)
        {
            Process.Start(path);
        }

        //Change the picture box image of state
        public void ChangeState(bool connected)
        {
            VPN vpn = new VPN();
            string vnp_name = vpn.VPNConnectionName;
            IsConnected_label.Text = connected ? "Connected: " + vnp_name : "Not Connected";
            state_pictureBox.Image = connected ? greendot : reddot;
        }

        //Change the Datetime of last checkup time
        public void ChangeUpdateTime()
        {
            final_update_label.Text = "Last Check: " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }

    public class VPN
    {
        private static string WinDir = Environment.GetFolderPath(Environment.SpecialFolder.System);
        private static string fileName = @"\rasdial.exe";//@"\rasphone.exe ";
        private static string VPNPROCESS = WinDir + fileName;

        //private string _VPNConnectionName = "";

        //private string _IPToPing = "";

        private bool _isConnected = false;

        public bool IsConnected
        {
            get { return _isConnected; }
        }

        public string IPToPing
        {
            get { return System.Configuration.ConfigurationSettings.AppSettings["serverIp"].ToString(); }
        }

        public string VPNConnectionName
        {
            get { return System.Configuration.ConfigurationSettings.AppSettings["vpnName"].ToString(); }
        }

        public string UserName
        {
            get { return System.Configuration.ConfigurationSettings.AppSettings["userName"].ToString(); }
        }

        public string Password
        {
            get { return System.Configuration.ConfigurationSettings.AppSettings["password"].ToString(); }
        }

        public static bool TestConnection()
        {
            VPN vpn = new VPN();
            bool RV = false;
            try
            {
                System.Net.NetworkInformation.Ping ping = new System.Net.NetworkInformation.Ping();

                if (ping.Send(vpn.IPToPing).Status == System.Net.NetworkInformation.IPStatus.Success)
                {
                    RV = true;
                }
                else
                {
                    RV = false;
                }
                ping = null;
            }
            catch (Exception Ex)
            {
                Debug.Assert(false, Ex.ToString());
                RV = false;
            }
            return RV;
        }

        public static bool ConnectToVPN(string username, string password)
        {
            VPN vpn = new VPN();
            bool RV = false;
            try
            {

                string args = string.Format("{0} {1} {2}", vpn.VPNConnectionName, username, password);
                ProcessStartInfo myProcess = new ProcessStartInfo(VPNPROCESS, args);

                //System.Security.SecureString secretString = new System.Security.SecureString();
                //foreach (char c in vpn.Password)
                //    secretString.AppendChar(c);
                //myProcess.Arguments = vpn.VPNConnectionName;
                //myProcess.UserName = vpn.UserName;

                //myProcess.Password = secretString;

                //myProcess.Domain = "@ADServer.Local";
                myProcess.CreateNoWindow = true;

                myProcess.UseShellExecute = false;

                //Process.Start(VPNPROCESS, );

                //Process.Start(VPNPROCESS, " -d " + vpn.VPNConnectionName);
                Process.Start(myProcess);
                //System.Windows.Forms.Application.DoEvents();
                //System.Threading.Thread.Sleep(2000);
                // System.Windows.Forms.Application.DoEvents();
                RV = true;

            }
            catch (Exception Ex)
            {
                Debug.Assert(false, Ex.ToString());
                RV = false;
            }
            return RV;
        }

        public static bool DisconnectFromVPN()
        {

            VPN vpn = new VPN();
            bool RV = false;
            try
            {
                //System.Diagnostics.Process.Start(VPNPROCESS, " -h " + vpn.VPNConnectionName);
                //System.Diagnostics.Process.Start(VPNPROCESS, string.Format(@"{0} /d",vpn.VPNConnectionName));
                string args = string.Format(@"{0} /d", vpn.VPNConnectionName);
                ProcessStartInfo myProcess = new ProcessStartInfo(VPNPROCESS, args);
                myProcess.CreateNoWindow = true;
                myProcess.UseShellExecute = false;
                System.Diagnostics.Process.Start(myProcess);

                //System.Windows.Forms.Application.DoEvents();
                //System.Threading.Thread.Sleep(2000);
                //System.Windows.Forms.Application.DoEvents();
                RV = true;
            }
            catch (Exception Ex)
            {
                Debug.Assert(false, Ex.ToString());
                RV = false;
            }
            return RV;
        }

        public static void CreateVPN()
        {
            VPN vpn = new VPN();
            DotRas.RasDialer dialer = new DotRas.RasDialer();
            DotRas.RasPhoneBook allUsersPhoneBook = new DotRas.RasPhoneBook();
            allUsersPhoneBook.Open();
            if (allUsersPhoneBook.Entries.Contains(vpn.VPNConnectionName))
            {
                return;
            }
            RasEntry entry = RasEntry.CreateVpnEntry(vpn.VPNConnectionName, vpn.IPToPing, RasVpnStrategy.PptpFirst, RasDevice.GetDeviceByName("(PPTP)", RasDeviceType.Vpn));

            allUsersPhoneBook.Entries.Add(entry);
            dialer.EntryName = vpn.VPNConnectionName;
            dialer.PhoneBookPath = RasPhoneBook.GetPhoneBookPath(RasPhoneBookType.AllUsers);
            try
            {
                dialer.DialAsync();
            }
            catch (Exception)
            {
                return;
            }
        }


        public VPN()
        {
        }
    }
}