using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameLibary
{
    class ViewModel : ObservableObject
    {
        public Boolean _installEnabled = true;
        public Boolean InstallEnabled
        {
            get
            {
                return _installEnabled;
            }
            set
            {
                _installEnabled = value;
                RaisePropertyChangedEvent("InstallEnabled");
            }
        }

        public Boolean _playEnabled = true;
        public Boolean PlayEnabled
        {
            get
            {
                return _playEnabled;
            }
            set
            {
                _playEnabled = value;
                RaisePropertyChangedEvent("PlayEnabled");
            }
        }

        public Boolean _downloadEnabled = true;
        public Boolean DownloadEnabled
        {
            get
            {
                return _downloadEnabled;
            }
            set
            {
                _downloadEnabled = value;
                RaisePropertyChangedEvent("DownloadEnabled");
            }
        }

        public Boolean _buyEnabled = true;
        public Boolean BuyEnabled
        {
            get
            {
                return _buyEnabled;
            }
            set
            {
                _buyEnabled = value;
                RaisePropertyChangedEvent("BuyEnabled");
            }
        }

    }
}
