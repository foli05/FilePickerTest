using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FilePickerTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void SelectFile_Click(object sender, RoutedEventArgs e)
        {
            FileOpenPicker fop = new FileOpenPicker();
      
            fop.ViewMode = PickerViewMode.Thumbnail;
            fop.SuggestedStartLocation = PickerLocationId.Desktop;
            fop.FileTypeFilter.Add(".mp3");
            fop.FileTypeFilter.Add(".wav");
            fop.FileTypeFilter.Add(".jpeg");
            fop.FileTypeFilter.Add(".jpg");

            StorageFile sf = await fop.PickSingleFileAsync();

            if (sf != null)
            {
                MyLabel.Text = sf.Name;
            }
            else
            {
                MyLabel.Text = "No File Selected";
            }
            
        }
        }
}

