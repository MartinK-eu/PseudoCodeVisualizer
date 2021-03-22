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

        public static void Eldontes1(ListBox listBox_main, TextBox textboxIn, int rB_index)
        {
            int[] tomb = TombGeneralas(textboxIn);
            int i = 0;
            if (rB_index == 0) //páros keresése
            {
                while ((i <= (tomb.Length - 1)) && !(tomb[i] % 2 == 0))
                {
                    listBox_main.Items.Add($"{i + 1}. lefutás, a {tomb[i]} % 2 != 0, tehát a szám ({tomb[i]}) páratlan.");
                    i++;
                }
                bool found = i <= (tomb.Length - 1);
                switch (found)
                {
                    case true:
                        listBox_main.Items.Add($"{i + 1}. lefutás, {tomb[i]} % 2 == 0, tehát páros.");
                        listBox_main.Items.Add($"Van páros szám, az első ilyen a {tomb[i]}");
                        break;
                    case false:
                        listBox_main.Items.Add($"A ciklus lefutott {i} alkalommal. Nincs páros szám.");
                        break;
                    default:
                        break;
                }
            }
            else // páratlan keresése
            {
                while ((i <= (tomb.Length - 1)) && !(tomb[i] % 2 == 1))
                {
                    listBox_main.Items.Add($"{i + 1}. lefutás, a {tomb[i]} % 2 != 1, tehát a szám ({tomb[i]}) páros.");
                    i++;
                }
                bool found = i <= (tomb.Length - 1);
                switch (found)
                {
                    case true:
                        listBox_main.Items.Add($"{i + 1}. lefutás, {tomb[i]} % 2 == 0, tehát páratlan.");
                        listBox_main.Items.Add($"Van páratlan szám, az első ilyen a {tomb[i]}");
                        break;
                    case false:
                        listBox_main.Items.Add($"A ciklus lefutott {i} alkalommal. Nincs páratlan szám.");
                        break;
                    default:
                        break;
                }
            }
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
