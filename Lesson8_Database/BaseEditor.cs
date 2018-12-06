using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson8_Database
{
    public partial class BaseEditor : Form
    {
        Timer timer = new Timer();
        TrueFalse database;
        BindingSource bs = new BindingSource();

        public BaseEditor()
        {
            InitializeComponent();
            timer.Start();
            timer.Tick += Timer_Tick;
            tsslCurrentTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tsslCurrentTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Только *.XML|*.XML|All files|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                tsslCurrentFile.Text = dialog.FileName;
                database = new TrueFalse(dialog.FileName);
                bs.DataSource = database;
                bs.DataMember = "List";
                DGV.DataSource = bs;

                if (bs.Count > 0) tsbDel.Enabled = true; else tsbDel.Enabled = false;

            };
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            database.Save();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Только *.XML|*.XML|All files|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                tsslCurrentFile.Text = dialog.FileName;
                database = new TrueFalse(dialog.FileName);
                database.Load();
                bs.DataSource = database;
                bs.DataMember = "List";
                DGV.DataSource = bs;

                if (bs.Count > 0) tsbDel.Enabled = true; else tsbDel.Enabled = false;

            };
        }

        private void опрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void выходToolStripMenuItem_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void tsbDel_Click( object sender, EventArgs e )
        {
            if (MessageBox.Show( "Sure you wanna delete?", "Warning", MessageBoxButtons.YesNo ) == System.Windows.Forms.DialogResult.Yes)
            {
                if( bs.Count >0 )
                {
                    bs.RemoveCurrent();
                }
            }
        }

        private void BaseEditor_Load( object sender, EventArgs e )
        {
            tsslCurrentFile.Text = Lesson8_Database.Program.basePath;
            database = new TrueFalse( Lesson8_Database.Program.basePath );
            database.Load();
            bs.DataSource = database;
            bs.DataMember = "List";
            DGV.DataSource = bs;

            tbText.DataBindings.Add( "Text", bs, "Text" );
            cbTrueFalse.DataBindings.Add( "Checked", bs, "TrueFalse" );
            tbDescription.DataBindings.Add( "Text", bs, "Description" );
            bindingNavigator1.BindingSource = bs;

            if (bs.Count > 0) tsbDel.Enabled = true; else tsbDel.Enabled = false;
        }

        private void bindingNavigatorAddNewItem_Click( object sender, EventArgs e )
        {
            if (bs.Count > 0) tsbDel.Enabled = true; else tsbDel.Enabled = false;
        }

        private void сохранитькакToolStripMenuItem_Click( object sender, EventArgs e )
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Только *.XML|*.XML|All files|*.*";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                database.FileName = saveFile.FileName;
                database.Save();
                tsslCurrentFile.Text = database.FileName;
            };
        }
    }
}
