using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
namespace GYM.Components
{
    internal class Navigation
    {
        public static bool IsAutorizate = false;
        public static Client AutorizateUser;
        public static MainWindow main;
        public static List<Nav> navs = new List<Nav>();

        public static void NextPage(Nav nav)
        {
            navs.Add(nav);
            Update(nav);
        }
        public static void BackPage()
        {
            if (navs.Count > 1)
            {
                navs.Remove(navs[navs.Count - 1]);
                Update(navs[navs.Count - 1]);
            }
        }

        private static void Update(Nav nav)
        {
            main.ENameTb.Text = nav.EName;
            main.MyFrame.Navigate(nav.Page);

        }
    }

    class Nav
    {
        public string EName { get; set; }
        public Page Page { get; set; }
        public Nav(string EName, Page Page)
        {
            this.EName = EName;
            this.Page = Page;
        }
    }
}
