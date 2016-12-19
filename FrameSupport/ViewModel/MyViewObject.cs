using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace FrameSupport.ViewModel
{
    public class MyViewObject : INotifyPropertyChanged
    {

        private string myText;
        public string MyText

        {
            get { return this.myText; }
            set
            {
                this.myText = value;
                NotifyPropertyChanged("MyText");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged( string propertyName)

        {

            if (PropertyChanged != null)

            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public  void SendingdDirectMessages(RichEditBox richEditBox)
        {
            try
            {
                MyText = "hello UWP";
                richEditBox.PlaceholderText = MyText;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }


        /// propertychanged
        /// 

        private string _name;
        private string _organization;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged("Name");
            }
        }

        public string Organization
        {
            get { return _organization; }
            set
            {
                _organization = value;
                RaisePropertyChanged("Organization");
            }
        }


        
        protected void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
