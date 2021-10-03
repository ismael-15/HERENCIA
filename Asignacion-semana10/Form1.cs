using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asignacion_semana10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // instancia
            Cd cd = new Cd();

            cd.settitle("MINUTOS");
            cd.setcomment("esta bonita ");
            cd._playinTime = "2 horas";
            cd._artist = "RICARDO ARJONA";
            cd._numberOfTracks = "10";

            MessageBox.Show(cd.gettitle());
            MessageBox.Show(cd.getcomment());
            MessageBox.Show(cd._playinTime);
            MessageBox.Show(cd.getartist());
            MessageBox.Show(cd.getnumberOfTracsk());
            MessageBox.Show(cd.print());

            


 
        }
    }
}
