using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.FileProperties;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Runner
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage 
    {
        public MainPage()
        {
            this.InitializeComponent();
            Loaded += OnLoaded;
        }

        public double ImageCenterX { get;
            set; }
        public double ImageCenterY { get; 
            set; }

        private async void OnLoaded(object sender, RoutedEventArgs e)
        {
            var picker = new FileOpenPicker();
            picker.ViewMode = PickerViewMode.Thumbnail;
            picker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            picker.FileTypeFilter.Add(".jpg");
            picker.FileTypeFilter.Add(".jpeg");
            picker.FileTypeFilter.Add(".png");
            var file = await picker.PickSingleFileAsync();
            ImageProperties properties = await file.Properties.GetImagePropertiesAsync();
            WriteableBitmap bmp = new WriteableBitmap((int)properties.Width, (int)properties.Height);
            bmp.SetSource((await file.OpenReadAsync()).AsStream().AsRandomAccessStream());

            imageCropper.Source = bmp;
            
        }

        private void Slider_OnValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            imageCropper.ImageRotation = e.NewValue;
        }

        private async void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var savePicker = new FileSavePicker
            {
                SuggestedStartLocation = PickerLocationId.PicturesLibrary,
                SuggestedFileName = "Cropped_Image",
                FileTypeChoices =
                {
                    { "PNG Picture", new List<string> { ".png" } },
                    { "JPEG Picture", new List<string> { ".jpg" } }
                }
            };
            var imageFile = await savePicker.PickSaveFileAsync();
            if (imageFile != null)
            {
                BitmapFileFormat bitmapFileFormat;
                switch (imageFile.FileType.ToLower())
                {
                    case ".png":
                        bitmapFileFormat = BitmapFileFormat.Png;
                        break;
                    case ".jpg":
                        bitmapFileFormat = BitmapFileFormat.Jpeg;
                        break;
                    default:
                        bitmapFileFormat = BitmapFileFormat.Png;
                        break;
                }

                using (var fileStream = await imageFile.OpenAsync(FileAccessMode.ReadWrite))
                {
                    await imageCropper.SaveAsync(fileStream, bitmapFileFormat);
                }
            }
        }

        private void Scale_OnValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            imageCropper.ScaledImageValue = e.NewValue;
            ImageCenterY = imageCropper.Source.PixelHeight / 2;
            ImageCenterX = imageCropper.Source.PixelWidth / 2;
        }
    }
}
