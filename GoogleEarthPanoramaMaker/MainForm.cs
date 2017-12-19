using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GoogleEarthPanoramaMaker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bttn_Submit_Click(object sender, EventArgs e)
        {
            if(txt_Name.Text == "")
            {
                MessageBox.Show("Please enter a valid project name", "Error Detected in Input" ,MessageBoxButtons.OK);
                return;
            }
            try
            {
                float lat = float.Parse(txt_Lat.Text);
                if(lat < -90 || lat > 90)
                {
                    throw new ArgumentException();
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid Latitude in +/- decimal degrees", "Error Detected in Input", MessageBoxButtons.OK);
                return;
            }
            try
            {
                float lon = float.Parse(txt_Long.Text);
                if (lon < -180 || lon > 180)
                {
                    throw new ArgumentException();
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid Longitude in +/- decimal degrees", "Error Detected in Input", MessageBoxButtons.OK);
                return;
            }
            if(nmc_FOV.Value < 20 || nmc_FOV.Value > 90)
            {
                DialogResult dialogResult = MessageBox.Show("FOV values smaller than 20 or larger than 90 may produce unexpected results. \n Would you like to proceed anyway?", "Warning", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.No)
                {
                    return;
                }

            }

            SaveKML();
        }

        private void SaveKML()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "kml files (*.kml)|*.kml";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter myStream = new StreamWriter(saveFileDialog1.FileName, false);
                myStream.Write(CreateKML());
                myStream.Close();
            }
        }

        private string CreateKML()
        {
            StringBuilder kmlStream = new StringBuilder();
            StringBuilder placemarkStream = new StringBuilder();
            int horizDivisions;
            int vertDivisions;
            double imageOverlap = (double)(1 + (nmc_Overlap.Value / 100));
            double aspectRatio = .5;
            int viewCount = 0;

            horizDivisions = (int)((360 / (int)nmc_FOV.Value) * imageOverlap);
            vertDivisions = (int)((180 / ((int)nmc_FOV.Value * aspectRatio)) * imageOverlap);

            kmlStream.AppendLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
            kmlStream.AppendLine("<kml xmlns=\"http://www.opengis.net/kml/2.2\" xmlns:gx=\"http://www.google.com/kml/ext/2.2>\">");
            kmlStream.AppendLine("  <Document>");
            kmlStream.AppendLine("  <open>1</open>");
            kmlStream.AppendLine("  <gx:Tour>");
            kmlStream.AppendLine($"    <name>{txt_Name.Text}</name>");
            kmlStream.AppendLine("    <gx:Playlist>");

            for( int j = 0; j <= vertDivisions; j++)
            {

                placemarkStream.AppendLine("  <Folder>");
                placemarkStream.AppendLine($"    <name>Vertical Division {j}</name>");

                double tilt = j * (180 / ((double)vertDivisions + 1));
                for (int i = 0; i <= horizDivisions; i++)
                {
                    double heading = i * (360 / ((double)horizDivisions + 1));

                    kmlStream.AppendLine("      <gx:FlyTo>");
                    kmlStream.AppendLine("        <gx:duration>0.0</gx:duration>");
                    kmlStream.AppendLine("        <Camera>");
                    kmlStream.AppendLine($"          <longitude>{txt_Long.Text}</longitude> ");
                    kmlStream.AppendLine($"          <latitude>{txt_Lat.Text}</latitude>");
                    kmlStream.AppendLine($"          <altitude>{nmc_Alt.Value}</altitude>");
                    kmlStream.AppendLine($"          <heading>{heading} </heading>");
                    kmlStream.AppendLine($"          <tilt>{tilt}</tilt>");
                    kmlStream.AppendLine($"          <gx:horizFov>{nmc_FOV.Value}</gx:horizFov>");
                    kmlStream.AppendLine("          <gx:altitudeMode>absolute</gx:altitudeMode>");
                    kmlStream.AppendLine("        </Camera>");
                    kmlStream.AppendLine("      </gx:FlyTo>");

                    kmlStream.AppendLine("      <gx:Wait>");
                    kmlStream.AppendLine($"        <gx:duration>{nmc_WaitSec.Value}</gx:duration>");
                    kmlStream.AppendLine("      </gx:Wait>");


                    viewCount++;

                    placemarkStream.AppendLine("      <Placemark>");
                    placemarkStream.AppendLine($"       <name>{viewCount}</name>");
                    placemarkStream.AppendLine("        <Camera>");
                    placemarkStream.AppendLine($"          <longitude>{txt_Long.Text}</longitude> ");
                    placemarkStream.AppendLine($"          <latitude>{txt_Lat.Text}</latitude>");
                    placemarkStream.AppendLine($"          <altitude>{nmc_Alt.Value}</altitude>");
                    placemarkStream.AppendLine($"          <heading>{heading} </heading>");
                    placemarkStream.AppendLine($"          <tilt>{tilt}</tilt>");
                    placemarkStream.AppendLine("          <altitudeMode>absolute</altitudeMode>");
                    placemarkStream.AppendLine("        </Camera>");
                    placemarkStream.AppendLine("      </Placemark>");

                }

                placemarkStream.AppendLine("  </Folder>");
            }

            kmlStream.AppendLine("    </gx:Playlist>");
            kmlStream.AppendLine("  </gx:Tour>");

            kmlStream.AppendLine("  <Folder>");
            kmlStream.AppendLine($"    <name>Individual Images (Vert:{vertDivisions} Horiz: {horizDivisions})</name>");
            kmlStream.AppendLine(placemarkStream.ToString());
            kmlStream.AppendLine("  </Folder>");

            kmlStream.AppendLine("</Document>");
            kmlStream.AppendLine("</kml>");

            return kmlStream.ToString();
        }

        private void bttn_openDialog_Click(object sender, EventArgs e)
        {
            // Show the FolderBrowserDialog.
            OpenFileDialog fileName = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txt_firstImageName.Text = openFileDialog1.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void bttn_deleteImages_Click(object sender, EventArgs e)
        {
            bttn_deleteImages.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            
            string directoryName = Path.GetDirectoryName(txt_firstImageName.Text);
            string fileName = Path.GetFileName(txt_firstImageName.Text);
            string root = fileName.Substring(0, fileName.LastIndexOf("-"));
            string[] files = Directory.GetFiles(directoryName, root + "-*.jpg", SearchOption.TopDirectoryOnly);
            files = files.OrderBy(x => x).ToArray();

            toolStripProgressBar1.Maximum = files.Length;

            int fileCounter = 0;
            for(int i = 0; i < files.Length; i++)
            {
                toolStripProgressBar1.Value = i;
                if(i % (nmc_WaitSec2.Value * Int32.Parse(cmb_RenderFPS.SelectedItem.ToString())) == 0)
                {
                    fileCounter++;
                    string f = Path.Combine(directoryName, fileCounter.ToString() + ".jpg");
                    File.Move(files[i], f);
                }
                else
                {
                    File.Delete(files[i]);
                }
            }

            bttn_deleteImages.Enabled = true;
            Cursor.Current = Cursors.Default;
            toolStripProgressBar1.Value = 0;
        }
    }
}
