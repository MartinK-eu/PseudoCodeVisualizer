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
    static class Pszeudok
    {
        public static int[] TombGeneralas(TextBox be)
        {
            string[] split = be.Text.Split(',');
            int[] ki = new int[split.Length];
            for (int i = 0; i < ki.Length; i++)
            {
                ki[i] = int.Parse(split[i]);
            }
            return ki;
        }

        public static void Sorozatszamitas0(ListBox listBox_main, TextBox textboxIn, int rB_index)
        {
            int[] tomb = TombGeneralas(textboxIn);
            int ertek;
            if (rB_index == 0) //összeadás
            {
                ertek = 0;
                listBox_main.Items.Add("Alap érték = 0");
                for (int i = 0; i < tomb.Length; i++)
                {
                    listBox_main.Items.Add($"{i + 1}. számítás: {ertek} + {tomb[i]} = {ertek + tomb[i]}");
                    ertek += tomb[i];
                }
            }
            else //szorzás
            {
                ertek = 1;
                listBox_main.Items.Add("Alap érték = 1");
                for (int i = 0; i < tomb.Length; i++)
                {
                    listBox_main.Items.Add($"{i + 1}. számítás: {ertek} * {tomb[i]} = {ertek * tomb[i]}");
                    ertek = ertek * tomb[i];
                }
            }
            listBox_main.Items.Add("\nVégeredmény: " + ertek);
        }

        public static void Eldontes1(ListBox listBox_main, TextBox textboxIn)
        {
            listBox_main.Items.Add("test");
        }

        public static void Modositott_eldontes2(ListBox listBox_main, TextBox textboxIn)
        {
            listBox_main.Items.Add("test");
        }

        public static void Novekvo_rendezettseg3(ListBox listBox_main, TextBox textboxIn)
        {
            listBox_main.Items.Add("test");
        }

        public static void Kivalasztas4(ListBox listBox_main, TextBox textboxIn)
        {
            listBox_main.Items.Add("test");
        }

        public static void Linearis_kereses5(ListBox listBox_main, TextBox textboxIn)
        {
            listBox_main.Items.Add("test");
        }

        public static void Megszamlalas6(ListBox listBox_main, TextBox textboxIn)
        {
            listBox_main.Items.Add("test");
        }

        public static void Maximumkiv7(ListBox listBox_main, TextBox textboxIn)
        {
            listBox_main.Items.Add("test");
        }

        public static void Masolas8(ListBox listBox_main, TextBox textboxIn)
        {
            listBox_main.Items.Add("test");
        }
    }
}
