using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RouteOnMap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public UserInput UserInput { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void txt_userinput_TextChanged(object sender, EventArgs e)
        {
            UserInput.userinput = txt_userinput.Text;
        }

        private void btn_map_Click(object sender, EventArgs e)
        {
            
            if (UserInput.userinput != null)
            {
                MessageBox.Show("Loading Map of " + UserInput.userinput);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Fill up address");
            }
            

        }
    }
}
