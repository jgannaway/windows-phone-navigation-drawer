using Microsoft.Phone.Controls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace DrawerLayoutWP8
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            DrawerLayout.InitializeDrawerLayout();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            this.BackKeyPress += MainPage_BackKeyPress;
        }

        private void DrawerIcon_Tapped(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (DrawerLayout.IsDrawerOpen)
                DrawerLayout.CloseDrawer();
            else
                DrawerLayout.OpenDrawer();
        }

        private void Item_Tapped(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var grid = sender as Grid;
            if (grid != null)
            {
                string menuItemName = grid.Name;
                MessageBox dialog = null;

                switch (menuItemName)
                {
                    case "Item1":
                        MessageBox.Show("Ay caramba!");
                        break;

                    case "Item2":
                        MessageBox.Show("Don't have a cow, man!");
                        break;

                    case "Item3":
                        MessageBox.Show("Hey, Ottoman!");
                        break;

                    case "Item4":
                        MessageBox.Show("Eat my shorts!");
                        break;
                }
            }
        }

        private void MainPage_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
            base.OnBackKeyPress(e);

            if (DrawerLayout.IsDrawerOpen)
            {
                DrawerLayout.CloseDrawer();
                e.Cancel = true;
            }
        }
    }
}