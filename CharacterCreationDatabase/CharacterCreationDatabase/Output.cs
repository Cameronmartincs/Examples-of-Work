using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreationDatabase
{
    public partial class Output : Form
    {
        public Output()
        {
            InitializeComponent();
        }

        public String Name
        {
            set { txtName.Text = value; }
        }
        public String Class
        {
            set { txtClass.Text = value; }
        }
        public String Race
        {
            set { txtRace.Text = value; }
        }
        public String Health
        {
            set { txtHealth.Text = value; }
        }
        public Double Tdamage
        {
            set { txtDamage.Text = value.ToString(); }
        }
        public String Speed
        {
            set { txtSpeed.Text = value; }
        }
    }
}
