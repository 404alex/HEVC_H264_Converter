using HEVC_H264_Converter.Model;
using HEVC_H264_Converter.ViewModels;
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
            ViewModel.Files = new List<Model.HevcFile>();

            #region
            //propulate test data
            HevcFile hevcFile = new HevcFile();
            hevcFile.FileName = "filename";
            hevcFile.FilePath = "filepath";
            hevcFile.IsFinished = true;
            hevcFile.Percentage = 54;
            hevcFile.Speed = 1.9;
            hevcFile.TargetPath = "targetpath";
            ViewModel.Files.Add(hevcFile);
            #endregion


            this.InitializeComponent();
        }
    }
}
