using AForge.Video.DirectShow;
using MiniStore.BUS;
using MiniStore.Costumized;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using ZXing;

namespace MiniStore.ExtendedFeatures
{
    public class Barcode
    {
        private FilterInfoCollection filter;
        private VideoCaptureDevice device;
        private static PictureBox Picture;
        private PictureBox product;
        private CostumTextbox txt_code;
        private CostumTextbox Quantity_txt;

        public Barcode()
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            device = new VideoCaptureDevice(filter[0].MonikerString);
            device.NewFrame += Device_NewFrame;
        }

        public static string GenerateBarcode(string code)
        {
            BarcodeWriter writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
            string working = Environment.CurrentDirectory;
            string path = Directory.GetParent(working).Parent.FullName;
            writer.Write(code).Save(path + @"\static\Barcode\" + code + ".png", ImageFormat.Png);
            return path + @"\static\Barcode\" + code + ".png";
        }
        public void Scan(PictureBox pictureBox, PictureBox product_image, CostumTextbox txt_code, CostumTextbox Quantity_txt)
        {
            if (device == null || !device.IsRunning)
            {
                this.txt_code = txt_code;
                Picture = pictureBox;
                product = product_image;
                this.Quantity_txt = Quantity_txt;
                device.Start();
            }
        }

        private void Device_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                string old_ID = txt_code.Texts;
                txt_code.Invoke(new MethodInvoker(delegate ()
                {
                    txt_code.Texts = result.ToString();
                }));

                Quantity_txt.Invoke(new MethodInvoker(delegate ()
                {
                    if (old_ID != txt_code.Texts)
                        Quantity_txt.Texts = "1";
                    else
                    {
                        Quantity_txt.Texts = int.Parse(Quantity_txt.Texts) + 1 + "";
                    }
                }));
                product.Invoke(new MethodInvoker(delegate ()
                {
                    product.ImageLocation = (ProductBUS.getProduct(result.ToString()).Imgdir);
                }));
                Console.Beep();
                device.SignalToStop();
            }
            Picture.Image = (Bitmap)bitmap.Clone();
        }

        public void Stop()
        {
            if (device != null)
            {
                if (device.IsRunning)
                {
                    device.SignalToStop();
                }
            }

        }
    }

}
