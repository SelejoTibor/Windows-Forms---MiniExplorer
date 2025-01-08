using System.Reflection.Metadata;
using System.Xml.Linq;

namespace WinFormsApp
{
    public partial class MainForm : Form
    {
        private FileInfo[] files = null;
        private FileInfo loadedFile = null;
        int counter;
        readonly int counterInitialValue;

        public MainForm()
        {
            InitializeComponent();
            counterInitialValue = 60;
        }
        private FileInfo GetFile(string fName)
        {
            for (int i = 0; i < files.Length; i++)
            {
                if (fName == files[i].Name)
                {
                    return files[i];
                }
            }
            return null;
        }

        private void ListViewerGetFiles(string result)
        {
            if (Directory.Exists(result))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(result);
                files = directoryInfo.GetFiles();
                listView1.Items.Clear();
                foreach (FileInfo file in files)
                {
                    listView1.Items.Add(
                    new ListViewItem(new string[]
                    {
                        file.Name,
                        file.Length.ToString(),
                    }));
                }
            }
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            var dlg = new InputDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string result = dlg.Path;
                ListViewerGetFiles(result);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                lName.Text = listView1.SelectedItems[0].SubItems[0].Text;
                FileInfo file = GetFile(lName.Text);
                lCreated.Text = file.CreationTime.ToString();
            }

        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo hitTestInfo = listView1.HitTest(e.X, e.Y);
            if (hitTestInfo.Item != null)
            {
                loadedFile = GetFile(lName.Text);
                tContent.Text = File.ReadAllText(loadedFile.FullName);
                reloadTimer.Start();
                counter = counterInitialValue;
            }
        }

        private void reloadTimer_Tick(object sender, EventArgs e)
        {
            counter--;

            // Fontos! Ez váltja ki a Paint eseményt
            // és ezzel a téglalap újrarajzolását
            detailsPanel.Invalidate();

            if (counter <= 0)
            {
                counter = counterInitialValue;
                tContent.Text = File.ReadAllText(loadedFile.FullName);
            }
        }

        private void detailsPanel_Paint(object sender, PaintEventArgs e)
        {
            if (loadedFile != null)
            {
                // A téglalap szélessége a téglalap kezdõhosszúságából (adott a feladatkiírásban) számítható,
                // szorozva a számláló aktuális és max értékének arányával
                e.Graphics.FillRectangle(new SolidBrush(Color.Brown), 0, 0, 125*((float)counter/60), 5);
            }
        }
    }
}