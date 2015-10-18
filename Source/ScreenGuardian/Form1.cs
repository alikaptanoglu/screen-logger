using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Imaging;
using System.IO;
using System.Xml;

namespace ScreenLogger
{
  public partial class Form1 : Form
  {
    enum TimeFormat { MilliSecond, Second, Minute, Hour }

    // DATA MEMEBERS:
    #region
    string saveFolder = "";
    string settingsFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ScreenLogger\\Settings.xml";
    XmlDocument xDoc = new XmlDocument();
    string TurnOffFile = "";
    ImageFormat imageFormat;
    ScreenCapture screenCapture;
    long imageQuality = 0;
    #endregion

    // PROPERTIES:
    #region
    string SaveFolder
    { set { saveFolder = value; saveFolder_textBox.Text = saveFolder; } get { return saveFolder; } }
    long ImageQuality
    { set { imageQuality = value; numericUpDown1.Value = imageQuality; } get { return imageQuality; } }
    #endregion

    // CONSTRUCTOR(S):
    #region
    public Form1()
    {
      InitializeComponent();

      // SaveFolder/SettingsFile checking:
      #region
      if (saveFolder != "")
        if (!DoesPathExist(saveFolder))
          CreateDirectory(saveFolder);

      if (!DoesPathExist(settingsFile))
        CreateSettingsFile();
      #endregion

      // loading only the most important settings which are the SaveFolder path and the ImageQuality
      LoadSettingsFromDatabase();

      // default values:
      pictureFormat_comboBox.SelectedIndex = 0; // jpeg 
      timeFormat_comboBox.SelectedIndex = 1; // seconds
      timeInterval_textBox.Text = "2"; // 2 sec 
    }
    #endregion

    // EVENTS:
    #region
    private void imageFormat_comboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      // if the selected imageFormat is Jpeg, the ImageQuality will get enabled
      numericUpDown1.Enabled = (pictureFormat_comboBox.SelectedItem.ToString().Contains("Jpeg")) ? true : false;
      imageFormat = GetImageFormatFromComboBox();
    }
    private void imageQualityNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
      imageQuality = Convert.ToInt16(numericUpDown1.Value);
    }

    // this is the ScreenLogging timer, every tick it mades, a screenshot is taken
    private void timer1_Tick(object sender, EventArgs e)
    {
      if (DoesPathExist(TurnOffFile))
      {
        StopLogging();
        ShowWindow(true);
      }
      screenCapture.TakeScreenShot();
    }

    // when the form closes, the settings are saved to the database
    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      SaveSettingsToDatabase();
    }
    #endregion

    // CLICKS:
    #region

    // IMAGES FOLDER BUTTONS:
    #region
    private void clearImagesFolder_button_Click(object sender, EventArgs e)
    {
      if (!DoesPathExist(saveFolder))
      {
        MessageBox.Show("Images Folder doesn't exist, either you've deleted it or you still haven't specified one", "Folder Doesn't Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      DialogResult result = MessageBox.Show("Are you sure you want to delete every image in the images folder?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == DialogResult.No)
        return;
      foreach (string _imageFile in Directory.GetFiles(saveFolder))
        if (_imageFile.Contains("Jpg") || _imageFile.Contains("jpg") || _imageFile.Contains("Jpeg") || _imageFile.Contains("jpeg")
          || _imageFile.Contains("Tiff") || _imageFile.Contains("tiff")
          || _imageFile.Contains("Png") || _imageFile.Contains("png")
          || _imageFile.Contains("Bmp") || _imageFile.Contains("bmp")
          || _imageFile.Contains("Gif") || _imageFile.Contains("gif"))
          File.Delete(_imageFile);
    }
    private void openImagesFolder_button_Click(object sender, EventArgs e)
    {
      if (!DoesPathExist(saveFolder))
      {
        MessageBox.Show("Images Folder doesn't exist, either you've deleted it or you still haven't specified one", "Folder Doesn't Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      System.Diagnostics.Process.Start(saveFolder);
    }
    private void imagesFolderBrowse_button_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog fbd = new FolderBrowserDialog();
      if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
      {
        SaveFolder = fbd.SelectedPath;
        TurnOffFile = Directory.GetParent(saveFolder).ToString();
      }
    }
    #endregion

    private void takeScreenShot_button_Click(object sender, EventArgs e)
    {
      if (!DoesPathExist(saveFolder))
      {
        MessageBox.Show("Images Folder doesn't exist, either you've deleted it or you still haven't specified one", "Folder Doesn't Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      screenCapture = new ScreenCapture(imageFormat, imageQuality, saveFolder);
      this.Hide();
      Thread.Sleep(200);
      screenCapture.TakeScreenShot();
      this.Show();
    }
    private void startLogging_button_Click(object sender, EventArgs e)
    {
      if (!DoesPathExist(saveFolder))
      {
        MessageBox.Show("Images Folder doesn't exist, either you've deleted it or you still haven't specified one", "Folder Doesn't Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      TurnOffFile = Directory.GetParent(saveFolder).ToString() + "\\SilentMode.OFF";
      screenCapture = new ScreenCapture(imageFormat, imageQuality, saveFolder);
      ShowWindow(false);
      SetTimerIntervalFromTextDependingOnTimeFormat(GetTimeFormatFromComboBox());
      timer1.Start();
    }
    #endregion

    // METHODS:
    #region
    // this gets the current selected time format in the timeFormatComboBox.
    TimeFormat GetTimeFormatFromComboBox()
    {
      if (timeFormat_comboBox.SelectedIndex == 0)
        return TimeFormat.MilliSecond;
      else if (timeFormat_comboBox.SelectedIndex == 1)
        return TimeFormat.Second;
      else if (timeFormat_comboBox.SelectedIndex == 2)
        return TimeFormat.Minute;
      else return TimeFormat.Hour;
    }

    // same as above, but for imageFormat.
    ImageFormat GetImageFormatFromComboBox()
    {
      if (pictureFormat_comboBox.SelectedItem.ToString().Contains("Jpeg"))
        return ImageFormat.Jpeg;
      else if (pictureFormat_comboBox.SelectedItem.ToString().Contains("Bmp"))
        return ImageFormat.Bmp;
      else if (pictureFormat_comboBox.SelectedItem.ToString().Contains("Gif"))
        return ImageFormat.Gif;
      else if (pictureFormat_comboBox.SelectedItem.ToString().Contains("Tiff"))
        return ImageFormat.Tiff;
      else if (pictureFormat_comboBox.SelectedItem.ToString().Contains("Png"))
        return ImageFormat.Png;
      return null;
    }

    // very self explanitory.
    void SetTimerIntervalFromTextDependingOnTimeFormat(TimeFormat format)
    {
      if (format == TimeFormat.MilliSecond)
        timer1.Interval = Convert.ToInt32(timeInterval_textBox.Text);
      else if (format == TimeFormat.Second)
        timer1.Interval = Convert.ToInt32(timeInterval_textBox.Text) * 1000;
      else if (format == TimeFormat.Minute)
        timer1.Interval = Convert.ToInt32(timeInterval_textBox.Text) * 1000 * 1000;
      else timer1.Interval = Convert.ToInt32(timeInterval_textBox.Text) * 1000 * 1000 * 1000;
    }
    private void StopLogging()
    {
      timer1.Stop();
    }
    private void ShowWindow(bool show)
    {
      WindowState = (show) ? FormWindowState.Normal : FormWindowState.Minimized;
      ShowInTaskbar = show;
    }
    private bool DoesPathExist(string path)
    {
      return (File.Exists(path) || Directory.Exists(path));
    }
    private void CreateDirectory(string path)
    {
      Directory.CreateDirectory(path);
    }
    private void CreateSettingsFile()
    {
      string saveFolderParent = Directory.GetParent(settingsFile).ToString();
      if (!DoesPathExist(saveFolderParent))
        CreateDirectory(saveFolderParent);
      FileStream fs = File.Create(settingsFile);
      StreamWriter sw = new StreamWriter(fs);
      sw.WriteLine(Properties.Resources.Settings);
      sw.Close();
      fs.Close();
    }
    #endregion

    // DATABASE MANAGEMENT:
    #region
    private void LoadSettingsFromDatabase()
    {
      xDoc.Load(settingsFile);
      try
      {
        SaveFolder = xDoc.DocumentElement.SelectSingleNode("SaveFolder").InnerText;
        ImageQuality = Convert.ToInt16(xDoc.DocumentElement.SelectSingleNode("JpegQuality").InnerText);
      }
      catch { }
      // no need to save, cuz we're just loading.
    }
    private void SaveSettingsToDatabase()
    {
      xDoc.Load(settingsFile);
      xDoc.DocumentElement.SelectSingleNode("SaveFolder").InnerText = saveFolder;
      xDoc.DocumentElement.SelectSingleNode("JpegQuality").InnerText = imageQuality.ToString();
      xDoc.Save(settingsFile);
    }
    #endregion
  }
}
