using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assessment2Maria
{
    public partial class formDragDrop : Form
    {
        public formDragDrop()
        {
            InitializeComponent();
            //Setting up form
            this.Text = " Drag and Drop Image";
            


        }
         
        private bool IsImageFile(string path)
        {
            string[] ok = { ".jpg", ".jpeg", ".png", ".bmp" };
            string ext = Path.GetExtension(path)?.ToLowerInvariant() ?? "";
            return ok.Contains(ext);
        }
       

        private void formDragDrop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files != null && files.Length > 0 && IsImageFile(files[0]))
                {
                    e.Effect = DragDropEffects.Copy; // Show the + to the user indicating that the file was allowed
                    return;
                }
            }
            e.Effect = DragDropEffects.None; // show no cursor, meaning that the fie wasnt allowed
        }

        private void formDragDrop_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files == null || files.Length == 0) return;

            string first = files[0];

            if (!IsImageFile(first))
            {
                MessageBox.Show("please drop a JPG or  PNG image", "not an image",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (pictureBox.Image != null)
                {
                    var old = pictureBox.Image;
                    pictureBox.Image = null;  //dispose previus image 
                    old.Dispose();
                }

                using (var temp = Image.FromFile(first))
                {
                    pictureBox.Image = new Bitmap(temp);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Could not load image.\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
