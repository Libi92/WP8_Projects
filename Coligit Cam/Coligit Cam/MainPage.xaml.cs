using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Coligit_Cam.Resources;

using System.IO;
using System.Windows.Media.Imaging;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.Phone.Tasks;
using Windows.Storage.Streams;
using Microsoft.Xna.Framework.Media;
using Nokia.Graphics.Imaging;
using System.IO.IsolatedStorage;
using Microsoft.Devices;
using System.Windows.Media;

namespace Coligit_Cam
{
    public partial class MainPage : PhoneApplicationPage
    {
        //private int savedCounter = 0;
        //PhotoCamera cam;

        CameraCaptureTask cameraCaptureTask;
        private FilterEffect _colorboostEffect = null;
        private WriteableBitmap _OriginalImageBitmap = null;
        private WriteableBitmap _colorboostImageBitmap = null;
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            cameraCaptureTask = new CameraCaptureTask();
            cameraCaptureTask.Completed += TakeImageCallback;

            _OriginalImageBitmap = new WriteableBitmap(800, 480);
            _colorboostImageBitmap = new WriteableBitmap(300, 180);
            cameraCaptureTask.Show();
        }


        

        //protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        //{
        //    if (PhotoCamera.IsCameraTypeSupported(CameraType.Primary))
        //    {
        //        cam = new Microsoft.Devices.PhotoCamera(CameraType.Primary);
        //        cam.Initialized += new EventHandler<Microsoft.Devices.CameraOperationCompletedEventArgs>(cam_Initialised);
        //        cam.CaptureCompleted += new EventHandler<CameraOperationCompletedEventArgs>(cam_CaptureCompleted);
        //        cam.CaptureImageAvailable += new EventHandler<Microsoft.Devices.ContentReadyEventArgs>(cam_CaptureImageAvailable);

        //        viewfinderBrush.SetSource(cam);
        //    }
        //}


        //void cam_Initialised(object sender, Microsoft.Devices.CameraOperationCompletedEventArgs e)
        //{
        //    if (e.Succeeded)
        //    {
        //        this.Dispatcher.BeginInvoke(delegate()
        //        {
        //            txtDebug.Text = "Camera Initialised";
        //        });
        //    }
        //}


        //private void cam_CaptureCompleted(object sender, CameraOperationCompletedEventArgs e)
        //{
        //    savedCounter++;
        //}


        //void cam_CaptureImageAvailable(object sender, Microsoft.Devices.ContentReadyEventArgs e)
        //{
        //    string filename = "ColigitCam" + savedCounter + ".jpg";
        //    try
        //    {
        //        Deployment.Current.Dispatcher.BeginInvoke(delegate()
        //        {
        //            txtDebug.Text = "Captured Image available, saving photo";
        //        });
                
        //    }
        //    finally
        //    {

        //    }
            
        //}

        

        
        

        private void ReImage_Click(object sender, EventArgs e)
        {
            //SaveButten.IsEnabled = false;
            cameraCaptureTask.Show();
            //PhotoChooserTask chooser = new PhotoChooserTask();
            //chooser.Completed += PicImageCallback;




            //if (cam != null)
            //{
            //    try
            //    {
            //        cam.CaptureImage();
            //    }
            //    catch(Exception ex)
            //    {
            //        this.Dispatcher.BeginInvoke(delegate()
            //        {
            //            txtDebug.Text = ex.Message;
            //        });
            //    }
            //}
            
        }
        

        private async void TakeImageCallback(object sender, PhotoResult e)
        {
            if (e.TaskResult != TaskResult.OK || e.ChosenPhoto == null)
            {
                return;
            }
            try
            {
                _colorboostImageBitmap.SetSource(e.ChosenPhoto);
                //_OriginalImageBitmap.SetSource(e.ChosenPhoto);
                Colorboost_Image.Source = _colorboostImageBitmap;
                //Original_Image.Source = _OriginalImageBitmap;

                e.ChosenPhoto.Position = 0;

                var ImageStream = new StreamImageSource(e.ChosenPhoto);
                _colorboostEffect = new FilterEffect(ImageStream);

                //appling filter
                var colorboostFilter = new CartoonFilter();
                _colorboostEffect.Filters = new[] { colorboostFilter };


                var renderer = new WriteableBitmapRenderer(_colorboostEffect, _colorboostImageBitmap);
                _colorboostImageBitmap = await renderer.RenderAsync();

                Original_Image.Source = _colorboostImageBitmap;
                //Colorboost_Image.Source = _colorboostImageBitmap;

                //Merge(_OriginalImageBitmap, _colorboostImageBitmap);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                return;
            }
            //SaveButten.IsEnabled = true;
        }





        private void Merge(WriteableBitmap _OriginalImageBitmap, WriteableBitmap _colorboostImageBitmap)
        {
            

            using (MemoryStream mem = new MemoryStream())
            {
                Image image = new Image();
                image.Source = _colorboostImageBitmap;

                // TranslateTransform                       
                TranslateTransform tf = new TranslateTransform();
                tf.X = 80;
                tf.Y = 80;
                _OriginalImageBitmap.Render(image, tf);


                _OriginalImageBitmap.Invalidate();
                _OriginalImageBitmap.SaveJpeg(mem, 800, 480, 0, 100);
                mem.Seek(0, System.IO.SeekOrigin.Begin);


                // Show image.                
                Original_Image.Source = _OriginalImageBitmap;
            }
        }




        //private void SaveImage_Click(object sender, EventArgs e)
        //{
        //    using (MemoryStream mem = new MemoryStream())
        //    {
        //        Image image = new Image();
        //        image.Source = _colorboostImageBitmap;

        //        // TranslateTransform                       
        //        TranslateTransform tf = new TranslateTransform();
        //        tf.X = 80;
        //        tf.Y = 80;
        //        _OriginalImageBitmap.Render(image, tf);


        //        _OriginalImageBitmap.Invalidate();
        //        _OriginalImageBitmap.SaveJpeg(mem, 800, 480, 0, 100);
        //        mem.Seek(0, System.IO.SeekOrigin.Begin);


        //        // Show image.                
        //        Original_Image.Source = _OriginalImageBitmap;
        //    }



        //    string fileName = "demo.jpg";
        //    try
        //    {
                
                
        //        var filestream=new MemoryStream();
        //        _OriginalImageBitmap.SaveJpeg(filestream,_OriginalImageBitmap.PixelWidth,_OriginalImageBitmap.PixelHeight,100,100);
        //        filestream.Seek(0,SeekOrigin.Begin);
        //        var m= new MediaLibrary();
        //        m.SavePictureToCameraRoll("test",filestream);
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show(ex.Message.ToString());
        //    }
            
        //}

        private async void SaveImage_Click(object sender, EventArgs e)
        {
            try
            {
                Merge(_OriginalImageBitmap, _colorboostImageBitmap);
                //SaveButten.IsEnabled = false;
                if (_colorboostEffect == null)
                {
                    return;
                }
                var jpegRenderer = new JpegRenderer(_colorboostEffect);

                IBuffer jpegOutput = await jpegRenderer.RenderAsync();

                MediaLibrary library = new MediaLibrary();
                string fileName = string.Format("ColigitCam_{0:G}", DateTime.Now);

                MessageBox.Show("Image Saved");

                //SaveButten.IsEnabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

    }
}