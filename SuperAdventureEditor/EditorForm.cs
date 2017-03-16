using Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private EditorWorld world;

        public EditorForm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbDataFolderPath.Text = Properties.Settings.Default.DataFolderPath ;
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
            //MessageBox.Show(x.ToString() + " " + y.ToString());

        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(tbDataFolderPath.Text))
            {
                MessageBox.Show("Actung");
                return;
            }
            world = new EditorWorld(tbDataFolderPath.Text);
            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                if (row.Cells[1].Value == null)
                    continue;

                string type = row.Cells[1].Value.ToString();
                if (type == "Weapon")
                   world.AddWeaponToList(int.Parse(row.Cells[0].Value.ToString()), 
                                        row.Cells[2].Value.ToString(), 
                                        row.Cells[3].Value.ToString(),
                                        int.Parse(row.Cells[4].Value.ToString()),
                                        int.Parse(row.Cells[6].Value.ToString()),
                                        int.Parse(row.Cells[7].Value.ToString())
                    );
            }
            world.SaveWorldData();
            //File.WriteAllText(PLAYER_DATA_FILE_NAME, World.ToXmlString());
        }

        private void EditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.DataFolderPath = tbDataFolderPath.Text;
            Properties.Settings.Default.Save();
        }

        private void dgvItems_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridViewRow row = dgvItems.Rows[e.RowIndex];
            if (dgvItems.RowCount == 1)
                row.Cells["cItemsID"].Value = 1;
            else
                row.Cells["cItemsID"].Value = (int)dgvItems.Rows[dgvItems.RowCount - 2].Cells["cItemsID"].Value + 1;

        }

        private void tsmiAddRow_Click(object sender, EventArgs e)
        {
            dgvItems.Rows.Add();
        }
    }
}
