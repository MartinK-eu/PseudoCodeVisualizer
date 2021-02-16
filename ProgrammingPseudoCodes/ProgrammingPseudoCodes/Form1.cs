using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingPseudoCodes
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
            listBox_main.Font = new Font("aerial", 14);
            for (int i = 0; i < tabControl_main.TabPages.Count; i++)
            {
                tabControl_main.TabPages[i].BackColor = Color.DarkGray;
            }
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
            
        }

        private void button_main_Click(object sender, EventArgs e)
        {
            listBox_main.Items.Clear();
            switch (tabControl_main.SelectedIndex)
            {
                case 0:
                    Pszeudok.Sorozatszamitas0(listBox_main, textBox_sorozatszamitas, RadioButtonSelectedIndex(radioButton_osszeadas, radioButton_szorzas));
                    break;
                default:
                    break;
            }

        }

        private void comboBox_main_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl_main.SelectedIndex = comboBox_main.SelectedIndex;
        }

        //methods
        private int RadioButtonSelectedIndex(RadioButton rB1, RadioButton rB2)
        {
            if (rB1.Checked)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
