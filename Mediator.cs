using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using GameLibrary;

namespace GameLibary
{
    class Mediator
    {
        private static Mediator INSTANCE = new Mediator();
        GameController gc = new GameController();
        public ViewModel Vm = null;

        private Mediator()
        {   
                
        }

        public static Mediator getInstance()
        {
            return INSTANCE;
        }

        public void WidgetChanged(object widget)
        {
            string gameName = ((widget as System.Windows.Controls.ComboBox).SelectedItem as ComboBoxItem).Content as string;
            //Console.WriteLine(gameName);
            //Console.WriteLine(gc.Games);
            Game game = gc.Games[gameName];
            if(game != null)
            {
                IState state = game.State;
                Console.WriteLine("Gamename " + gameName + " " + state);

                if (state.getName().Equals("notOwned"))
                {
                    Vm.InstallEnabled = false;
                    Vm.PlayEnabled = false;
                    Vm.BuyEnabled = true;
                    Vm.DownloadEnabled = false;
                }
                
                else if (state.getName().Equals("downloaded"))
                {
                    //BuyButton.IsEnabled = false;
                    //DownloadButton.IsEnabled = false;
                    //InstallButton.IsEnabled = true;
                    //PlayButton.IsEnabled = true;
                }
                else if (state.getName().Equals("installed"))
                {
                    
                }
                //BuyButton.IsEnabled = true;
                //DownloadButton.IsEnabled = false;
                //InstallButton.IsEnabled = false;
                //PlayButton.IsEnabled = false;
            }
        }
    }
}
