using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solid_Example
{
    public partial class Form1 : Form
    {
        List<VideoGames> juego;
        VideoGames ju;
        public Form1()
        {
            InitializeComponent();
            juego = new List<VideoGames>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ju = new VideoGames(txtNombre.Text,txtCategoria.Text,Convert.ToDouble(txtPrecio.Text));
            juego.Add(ju);
            foreach (VideoGames ju in juego)
            {
                listBox1.Items.Add(ju.nombre);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            
        }
    }
}
