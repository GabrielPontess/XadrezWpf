using System;
using System.Drawing;
using System.Windows.Media.Imaging;
using System.Windows;
using System.IO;

namespace XadrezWpf.Utils
{
    public class Convert
    {
        private static extern int DeleteObject(IntPtr o);

        public static BitmapSource ImagetoImageSource(byte[] img)
        {

            IntPtr ip = IntPtr.Zero;    
            BitmapSource bs = null;
            System.Drawing.Bitmap source = null;
            try
            {
                source = byteArrayToImage(img);
                ip = source.GetHbitmap();
                bs = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(ip,
                   IntPtr.Zero, Int32Rect.Empty,
                   System.Windows.Media.Imaging.BitmapSizeOptions.FromEmptyOptions());
            }
            finally
            {
                DeleteObject(ip);
            }

            return bs;
        }

        public static Bitmap byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            try
            {
                Bitmap bmp = new Bitmap(ms);
                return bmp;
            }
            catch (Exception ex)
            {

                throw new Exception(String.Format("Erro ao converter a imagem de byte[] para ImageSource {0}:", ex.Message));
            }


        }
    }
}
