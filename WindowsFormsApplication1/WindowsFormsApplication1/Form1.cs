using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1( )
        {
            InitializeComponent( );
        }

        void pictureBox1_Click( object sender, System.EventArgs e )
        {
            int X = this.pictureBox1.PointToClient( Cursor.Position ).X;
            int Y = this.pictureBox1.PointToClient( Cursor.Position ).Y;

            if( X < 400 )
            {
                Console.WriteLine( "TO DA LEFT" );
            }
            else
            {
                
                Form2 f = new Form2( );
                f.Show( );

                this.Hide( );
            }
            
        }
    }
}
