using System.IO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ScreenLogger
{
  public class ScreenCapture
  {
    // DATA MEMBERS:
    #region
    long imageQuality = 0;
    int screenWidth = 0;
    int screenHeight = 0;
    Bitmap bmp;
    public Graphics screenShot;
    public Size screenSize;
    #endregion

    // PROPERTIES:
    #region
    public ImageFormat PictureFormat
    { set; get; }
    public string SaveFolder
    { set; get; }
    public long ImageQuality
    { set { if (value >= 0 && value <= 100) imageQuality = value; } get { return imageQuality; } }
    #endregion

    // CONSTRUCTOR(S):
    #region
    public ScreenCapture(ImageFormat PictureFormat, long ImageQuality, string SaveFolder)
    {
      this.PictureFormat = PictureFormat;
      this.SaveFolder = SaveFolder;
      this.ImageQuality = ImageQuality;
      screenWidth = Screen.PrimaryScreen.Bounds.Width;
      screenHeight = Screen.PrimaryScreen.Bounds.Height;
      screenSize = Screen.PrimaryScreen.Bounds.Size;
      bmp = new Bitmap(screenWidth, screenHeight, PixelFormat.Format16bppRgb555); // Format16bppRgb555 makes it kinda, low quality
      screenShot = Graphics.FromImage(bmp);
    }
    #endregion

    // METHODS:
    #region
    public Bitmap TakeScreenShot()
    {
      screenShot.CopyFromScreen(0, 0, 0, 0, screenSize, CopyPixelOperation.SourceCopy);
      string year = DateTime.Now.Year.ToString();
      string month = DateTime.Now.Month.ToString();
      string day = DateTime.Now.Day.ToString();
      string hour = DateTime.Now.TimeOfDay.Hours.ToString();
      string minute = DateTime.Now.TimeOfDay.Minutes.ToString();
      string second = DateTime.Now.TimeOfDay.Seconds.ToString();
      string path = SaveFolder + "\\image_" + day + "_" + month + "_" + year
                                 + "_" + hour + "_" + minute + "_" + second
                                 + "_." + PictureFormat.ToString();
      if (PictureFormat == ImageFormat.Jpeg)
        ChangeImageQuality(bmp, ImageQuality, path);
      else
        bmp.Save(path);
      return bmp;
    }
    void ChangeImageQuality(Bitmap bmp, long quality, string imageSavePath)
    {
      ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

      // Create an Encoder object based on the GUID 
      // for the Quality parameter category.
      Encoder myEncoder = Encoder.Quality;

      // Create an EncoderParameters object. 
      // An EncoderParameters object has an array of EncoderParameter 
      // objects. In this case, there is only one 
      // EncoderParameter object in the array.
      EncoderParameters myEncoderParameters = new EncoderParameters(1);

      EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, quality);
      myEncoderParameters.Param[0] = myEncoderParameter;
      bmp.Save(imageSavePath, jpgEncoder, myEncoderParameters);
    }
    ImageCodecInfo GetEncoder(ImageFormat format)
    {
      ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
      foreach (ImageCodecInfo codec in codecs)
      {
        if (codec.FormatID == format.Guid)
        {
          return codec;
        }
      }
      return null;
    }
    #endregion
  }
}
