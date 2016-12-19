using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FrameSupport
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            NavigateToContentPage(typeof(DetailFramePage));
        }

        public void NavigateToContentPage(Type type)
        {
            var viewType = type;
            if (viewType != null && MasterFrame.CurrentSourcePageType != viewType)
            {
                DetailFrame.Navigate(type);
            }
            //UpdateForVisualState(AdaptiveStates.CurrentState);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            var viewType = e.Parameter as Type;
            if (viewType != null && MasterFrame.CurrentSourcePageType != viewType)
            {
                MasterFrame.Navigate(viewType);
            }
            //UpdateForVisualState(AdaptiveStates.CurrentState);
        }
    }
}
