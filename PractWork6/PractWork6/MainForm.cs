using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PractWork6
{
    public partial class MainForm : Form
    {
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        int p = 0, q = 0, n, o, ecs, d;
        List<int> decrypte = new List<int>();
        List<int> symbol = new List<int>();
        List<int> data2 = new List<int>();
        List<int> decrypteList = new List<int>();
        List<int> decrypteList2 = new List<int>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void chipherFileButton_Click(object sender, EventArgs e)
        {
            if (p != 0)
            {
                foreach (var item in Directory.GetFiles(fbd.SelectedPath))//
                {
                    decrypte.Clear();
                    data2.Clear();
                    decrypteList.Clear();
                    decrypteList2.Clear();
                    symbol.Clear();
                    var bytes = File.ReadAllBytes(item); // ШУУУУУУ
                    foreach (var files in bytes)
                    {
                        symbol.Add(Convert.ToInt32(files));
                    }
                    List<byte> decrypteSymbols = new List<byte>();
                    List<byte> data = new List<byte>();
                    Encrypte(symbol);
                    foreach (var item1 in decrypteList)
                    {
                        decrypteSymbols.Add(Convert.ToByte(item1));
                    }
                    String[] s = item.Split(Path.DirectorySeparatorChar);//
                    string trimmed = s[s.Length - 1];//                   
                    File.WriteAllBytes("C:\\Для студентов\\PKS-91\\Encrypte\\" + trimmed, decrypteSymbols.ToArray());//
                    var k = decrypte;
                    bytes = File.ReadAllBytes("C:\\Для студентов\\PKS-91\\Encrypte\\" + trimmed);//
                    decrypteList2 = new List<int>();
                    string b = "";
                    for (int i = 0; i < bytes.Count(); i += 2)
                    {
                        b = "";
                        while (Convert.ToString(bytes[i + 1], 2).Length + b.Length < 8)
                        {
                            b += "0";
                        }
                        b = b + Convert.ToString(bytes[i + 1], 2);
                        decrypteList2.Add(Convert.ToInt32(Convert.ToString(bytes[i], 2) + b, 2));
                    }
                    Decrypte();
                    foreach (var item1 in data2)
                    {
                        data.Add(Convert.ToByte(item1));
                    }
                    label2.Text = "p = " + p + ";" + "q = " + q + ";" + "n = " + n + ";" + "o = " + o + ";" + "e = " + ecs + ";" + "d = " + d;
                    File.WriteAllBytes("C:\\Для студентов\\PKS-91\\Decrypte\\"+trimmed,data.ToArray());
                    //File.WriteAllBytes("Расшифрованный файл." + item.Split('.')[item.Split('.').Count() - 1], data.ToArray());


                }
            }
            else
            {
                MessageBox.Show("Сгенерируйте числа");
            }
            MessageBox.Show("Готово, файл зашифрован и расшифрован");

        }

        private void generate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            while (n < 255)
            {
                int[] a = Sieve(100);
                p = a[rnd.Next(a.Length)];
                q = a[rnd.Next(a.Length)];
                n = q * p;
            }
            o = (p - 1) * (q - 1);
            int nod = 1;
            while (true)
            {
                ecs = rnd.Next(2, o);
                for (int i = 1; i <= o; i++)
                {
                    if (ecs % i == 0 && o % i == 0)
                    {
                        nod = i;

                    }

                }
                if (nod == 1)
                {
                    break;
                }
            }
            d = 1;

            while (true)
            {
                if ((d * ecs) % o == 1)
                {
                    break;
                }
                else
                {
                    d++;
                }
            }
        }

        static int[] Sieve(int n)
        {
            int[] S = Enumerable.Range(0, n + 1).ToArray();

            S[1] = 0;

            for (int k = 2; k * k <= n; k++)
            {
                if (S[k] != 0)
                {
                    for (int l = k * k; l <= n; l += k)
                    {
                        S[l] = 0;
                    }
                }
            }
            return S.Where(x => x != 0).ToArray();
        }

        private void openFileDialogButton_Click(object sender, EventArgs e)
        {
            decrypte.Clear();
            data2.Clear();
            decrypteList.Clear();
            decrypteList2.Clear();
            symbol.Clear();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                label1.Text = fbd.SelectedPath;

                /* var bytes = File.ReadAllBytes(folderBrowserDialog1.FileName);
                 foreach (var item in bytes)
                 {
                     symbol.Add(Convert.ToInt32(item));
                 }*/
            }
        }
        private void Encrypte(List<int> symbols)
        {
            decrypteList = new List<int>();
            int c, n2;

            c = 1;
            n2 = 0;
            string num1, num2;
            int num3, num4;
            string a1 = "";
            decrypteList = new List<int>();
            string binaryString;
            foreach (var itm in symbols)
            {
                a1 = "";
                do
                {
                    n2++;
                    c = (itm * c) % n;
                }
                while (n2 < ecs);
                binaryString = Convert.ToString(c, 2);
                string h = "";
                while (binaryString.Length + h.Length < 16)
                {
                    h += "0";
                }
                binaryString = h + binaryString;
                decrypte.Add(Convert.ToInt32(binaryString, 2));
                for (int i = 0; i < 8; i++)
                {
                    a1 += binaryString[i];
                }
                num1 = Convert.ToString(a1);
                a1 = "";
                for (int i = 8; i < 16; i++)
                {
                    a1 += binaryString[i];
                }
                num2 = Convert.ToString(a1);
                a1 = "";
                num3 = Convert.ToInt32(num1, 2);
                num4 = Convert.ToInt32(num2, 2);
                decrypteList.Add(num3);
                decrypteList.Add(num4);
                n2 = 0;
                c = 1;
            }
        }
        private void Decrypte()
        {
            int c = 1, n1 = 0;

            foreach (var itm in decrypteList2)
            {
                do
                {
                    n1++;
                    c = (Convert.ToInt32(itm) * c) % n;
                }
                while (n1 < d);
                data2.Add(c);
                n1 = 0;
                c = 1;
            }
        }
    }
}
