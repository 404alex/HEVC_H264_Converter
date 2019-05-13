using HEVC_H264_Converter.Model;
using HEVC_H264_Converter.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HEVC_H264_Converter
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        ConverterListViewModel ViewModel { get; } = new ConverterListViewModel();

        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void AddFile_Click(object sender, RoutedEventArgs e)
        {
            var picker = new Windows.Storage.Pickers.FileOpenPicker();
            picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
            picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
            picker.FileTypeFilter.Add(".mov");

            var files = await picker.PickMultipleFilesAsync();
            if (files.Count > 0)
            {
                foreach (var item in files)
                {

                    HevcFile hevcFile = new HevcFile();
                    hevcFile.FileName = item.Name;
                    hevcFile.FilePath = item.Path;
                    hevcFile.IsFinished = false;
                    hevcFile.Percentage = 0;
                    hevcFile.Speed = 0;
                    string temp = item.Path;
                    hevcFile.TargetPath = temp.Insert(temp.Length - item.FileType.Length, "_done");
                    ViewModel.Files.Add(hevcFile);
                }
            }
            else
            {

            }
            this.dataGrid.ItemsSource = null;
            this.dataGrid.ItemsSource = ViewModel.Files;
        }
    }
}
