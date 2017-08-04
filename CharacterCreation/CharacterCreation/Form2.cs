using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        //I dont even want to bother will which each label represents. The designer shows the corresponding label
        public string Label1
        {
            set { label1.Text = value; }
        }
        public string Label2
        {
            set { label2.Text = value; }
        }
        public string Label3
        {
            set { label3.Text = value; }
        }
        public string Label4
        {
            set { label4.Text = value; }
        }
        public string Label5
        {
            set { label5.Text = value; }
        }
        public string TxtBio
        {
            set { txtBio.Text = value; }
        }

        public Image Image2
        {
            set { pictureBox1.Image = value; }
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        
                    
        
        
    }
}
