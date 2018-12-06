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
    public partial class GameWindow : Form
    {
        private TrueFalse tf;
        private int counterQ;
        private int counterSuccess;

        public GameWindow()
        {
            InitializeComponent();
            
        }

        private bool Init()
        {
            tf = new TrueFalse( Lesson8_Database.Program.basePath );
            tf.Load();
            if (tf.List.Count == 0)
            {
                MessageBox.Show( "Ошибка загрузки базы вопросов!" );
                return false;
            }
            else
            {
                counterSuccess = 0;
                counterQ = -1;
                NextQ();
                return true;
            }
        }

        private void GameWindow_Load( object sender, EventArgs e )
        {
            if (!( Init() )) this.Close();
        }

        private void NextQ()
        {
            if(counterQ < tf.Count - 1)
            {
                counterQ++;
                txtbQuestion.Text = tf[counterQ].Text;
            }
            else
            {
                if(counterSuccess == tf.Count)
                {
                    MessageBox.Show( "Вы выиграли!" );
                }
                else
                {
                    MessageBox.Show( "Вы проиграли!" );
                }

                txtbQuestion.Text = "Игра окончена";
                btTrue.Enabled = false;
                btFalse.Enabled = false;
            }
        }

        private void QReaction(bool userChoose)
        {
            if (tf[counterQ].TrueFalse == userChoose)
            { 
                counterSuccess++;
                MessageBox.Show( "Вы совершенно правы!\n" + tf[counterQ].Description );
            }
            else
            {
                MessageBox.Show( "Увы, Вы ошиблись!\n" + tf[counterQ].Description );
            }

            NextQ();
        }

        private void btTrue_Click( object sender, EventArgs e )
        {
            QReaction( true );
        }

        private void btFalse_Click( object sender, EventArgs e )
        {
            QReaction( false );
        }
    }
}
