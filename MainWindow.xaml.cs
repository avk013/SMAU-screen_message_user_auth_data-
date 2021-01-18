using System;
using System.DirectoryServices;
using System.Timers;
//using System.Threading;
using System.Windows;


namespace message
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>


    public partial class MainWindow : Window
    {
        Timer stateTimer;
        public MainWindow()
        {
            InitializeComponent();
            // this.TopMost = true
            //  stateTimer = new Timer(, null, 0, 1000);
        //    stateTimer = new Timer(1000);
          mm();
            // message.MainWindow
            //Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
            // Size resolution = System.Windows.Screen.PrimaryScreen.Bounds.Size;
            //Console.WriteLine("Width: {0}, Height: {1}", resolution.Width, resolution.Height);
            // window1.Top= window1.
            // window1.Top=(System.Windows.SystemParameters.PrimaryScreenHeight-window1.Height)/2;
            // window1.Left = (System.Windows.SystemParameters.PrimaryScreenWidth-window1.Width)/2;
            //диспетчер задач
          
        }
        
        string ExtractUserName(string path)
        {
            string[] userPath = path.Split(new char[] { '\\' });
            return userPath[userPath.Length - 1];
        }
        bool IsExistInAD(string loginName)
        {
            string userName = ExtractUserName(loginName);
            DirectorySearcher search = new DirectorySearcher();
            search.Filter = String.Format("(SAMAccountName={0})", userName);
            search.PropertiesToLoad.Add("cn");
            SearchResult result = search.FindOne();

            if (result == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
       //delegate
            void mm1()
        {
        }
            void mm()
        {
            //   string userName = ExtractUserName(loginName);
            lbl1.Content = user_name();
            //lbl1.Content = "+";
            //reg_;
        }
            public void reg_()
        {
            Microsoft.Win32.RegistryKey regkey;
            string keyValueInt = "1";
            string subKey = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System";
            try
            {
                regkey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(subKey);
                regkey.SetValue("DisableTaskMgr", keyValueInt);
                regkey.Close();
            }
            catch (Exception)
            {
                //  MessageBox.Show(ex.ToString());
            }
        }
        public string user_name()
        {
            string user1;
            // try
            //{
            // DirectoryEntry de = new DirectoryEntry("WinNT://" + Environment.UserDomainName + "/" + Environment.UserName);
            // DirectoryEntry de = new DirectoryEntry(@"UDP://" + Environment.UserDomainName + "/" + Environment.UserName);
            //   user1 = de.Properties["displayName"].Value.ToString();

            //}
            //catch {}
            string dt=DateTime.Now.ToString();
            string cmd_line = "net user /domain username "+Environment.UserName;
            // net user "%USERNAME%" /domain | FIND /I "Полное"
            string user2 = Environment.UserName + Environment.NewLine+dt;// + user1;// + GetFu; ;
            return user2;
        }

    }
}
    

