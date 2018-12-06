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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btExit_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void btBaseEditor_Click( object sender, EventArgs e )
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form item in fc)
            {
                if (item is BaseEditor)
                {
                    item.Activate();
                    return;
                }
            }

            BaseEditor be = new BaseEditor();
            be.Show( this );
        }

        private void btGame_Click( object sender, EventArgs e )
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form item in fc)
            {
                if (item is GameWindow)
                {
                    item.Activate();
                    return;
                }
            }

            GameWindow gw = new GameWindow();
            gw.Show( this );

        }
    }
}
