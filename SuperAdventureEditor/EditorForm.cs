using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperAdventureEditor
{
    public partial class EditorForm : Form
    {
        private const int bs = 60;
        private int rowCount = 7;
        private int colCount = 7;

        public EditorForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pMainPanel.SuspendLayout();
            pMainPanel.Controls.Clear();

            for (int x = 0; x < colCount; x++)
                for (int y = 0; y < rowCount; y++)
                {
                    PictureBox box = new PictureBox();
                    //box.BackgroundImage = Properties.Resources.none;
                    //box.BackgroundImageLayout = ImageLayout.Zoom;
                    box.BorderStyle = BorderStyle.FixedSingle;
                    box.Location = new Point(x * (bs) , y * (bs) );
                    box.Size = new Size(bs, bs);
                    box.SizeMode = PictureBoxSizeMode.Zoom;
                    box.TabIndex = 0;
                    box.TabStop = false;
                    box.MouseClick += new MouseEventHandler(box_MouseClick);
                    //box.MouseEnter += new EventHandler(picture_MouseEnter);
                    //box.MouseLeave += new EventHandler(picture_MouseLeave);
                    //box.MouseDown += new MouseEventHandler(picture_MouseDown);
                    //box.MouseUp += new MouseEventHandler(picture_MouseUp);
                    //box.MouseMove += new MouseEventHandler(picture_MouseMove);
                    box.Tag = new Point(x, y);
                    pMainPanel.Controls.Add(box);
                    //boxes[x, y] = picture;
                    //boxes[x, y].Image = CellToPicture(cells[x, y]);
                }
            pMainPanel.ResumeLayout();

        }



        private void box_MouseClick(object sender, EventArgs e)
        {
            int x = ((Point)((PictureBox)sender).Tag).X;
            int y = ((Point)((PictureBox)sender).Tag).Y;
            MessageBox.Show(x.ToString() + " " + y.ToString());

        }
    }
}
