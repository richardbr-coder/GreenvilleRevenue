using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleLinq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'greenvilledatabase1DataSet.contestbl' table. You can move, or remove it, as needed.
            this.contestblTableAdapter.Fill(this.greenvilledatabase1DataSet.contestbl);

        }
        //If the Name button is pressed do this
        private void btnName_Click(object sender, EventArgs e)
        {
            //clear the box before diaplying this info
            outputListBox.Items.Add("The Contestants in the Talant Competition are: (Ordered A-Z)");

            var cont = 
                from c in this.greenvilledatabase1DataSet.contestbl
                orderby c.Name//(A -Z ordering)
                select c;

            foreach (var i in cont)
                outputListBox.Items.Add(i.Name);
        }
        //If the code button is pressed do this
        private void btnCode_Click(object sender, EventArgs e)
        {
            //clear the box before diaplying this info
            outputListBox.Items.Clear();

            var cont =
                from c in this.greenvilledatabase1DataSet.contestbl
                group c by c.TalentCode;

            foreach(var i in cont)
            {
                outputListBox.Items.Add("Their Talent Code is: " + i.Key);
                foreach (var x in i)
                    outputListBox.Items.Add(x.Name);
            }


        }
        //if the box is checked do this
        private void checkBoxSinging_CheckedChanged(object sender, EventArgs e)
        {
            //clear the box before diaplying this info
            outputListBox.Items.Clear();

            var cont =
                from c in this.greenvilledatabase1DataSet.contestbl
                where c.TalentCode == "S"
                select c;

            if (checkBoxSinging.Checked)
            {
                checkBoxDancing.Checked = false;
                checkBoxInstrument.Checked = false;
                outputListBox.Items.Add("Contestant with talent Code 'S' for Singing: ");
                foreach(var i in cont)
                {
                    outputListBox.Items.Add(i.Name);
                }
            }
        }
        //if the box is checked do this
        private void checkBoxDancing_CheckedChanged(object sender, EventArgs e)
        {
            //clear the box before diaplying this info
            outputListBox.Items.Clear();

            var cont =
                from c in this.greenvilledatabase1DataSet.contestbl
                where c.TalentCode == "D"
                select c;

            if (checkBoxDancing.Checked)
            {
                checkBoxSinging.Checked = false;
                checkBoxInstrument.Checked = false;
                outputListBox.Items.Add("Contestant with talent Code 'D' for Dancing: ");
                foreach (var i in cont)
                {
                    outputListBox.Items.Add(i.Name);
                }
            }
        }
        //if the box is checked do this
        private void checkBoxInstrument_CheckedChanged(object sender, EventArgs e)
        {
            //clear the box before diaplying this info
            outputListBox.Items.Clear();

            var cont =
                from c in this.greenvilledatabase1DataSet.contestbl
                where c.TalentCode == "M"
                select c;

            if (checkBoxInstrument.Checked)
            {
                checkBoxDancing.Checked = false;
                checkBoxSinging.Checked = false;
                outputListBox.Items.Add("Contestant with talent Code 'M' for Musical Instruments: ");
                foreach (var i in cont)
                {
                    outputListBox.Items.Add(i.Name);
                }
            }
        }
    }
}
