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
    public partial class DataControl : Form
    {
        public DataControl()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.characterDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'characterDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.characterDataSet.Table);

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Output character = new Output();
            character.Name = nameTextBox.Text;
            character.Class = classTextBox.Text;
            character.Race = raceTextBox.Text;
            character.Health = healthTextBox.Text;
            character.Speed = speedTextBox.Text;
            character.Tdamage = (Convert.ToDouble(damageTextBox.Text) * Convert.ToDouble(accuracyTextBox.Text));
            character.Show();

        }
    }
}
