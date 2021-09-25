using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string pattern = @"[^0-9]+";
        private async void button1_Click(object sender, System.EventArgs e)
        {
            textBox2.Text = "";
            label1.Text = "Стало: считаю...";
            label3.Text = "Удалил: пока не удалил, подожди....";
            int le = 0;
            List<string> withDupes = new List<string>();
            await Task.Run(() => 
            {
                if (начинаетсяС79ToolStripMenuItem.Checked)
                    foreach (string nums in textBox1.Lines)
                    {
                        le++;
                        string numbe = Regex.Replace(nums, pattern, "");
                        int c_l = numbe.Length;
                        if (c_l > 9)
                        {
                            try
                            {
                                withDupes.Add(method_79(numbe, c_l));
                            }
                            catch { };
                        }
                    }
                else if (начинаетсяС89ToolStripMenuItem.Checked)
                    foreach (string nums in textBox1.Lines)
                    {
                        le++;
                        string numbe = Regex.Replace(nums, pattern, "");
                        int c_l = numbe.Length;
                        if (c_l > 9)
                        {
                            try
                            {
                                withDupes.Add(method_89(numbe, c_l));
                            }
                            catch { };
                        }
                    }
                else
                    foreach (string nums in textBox1.Lines)
                    {
                        le++;
                        string numbe = Regex.Replace(nums, pattern, "");
                        int c_l = numbe.Length;
                        if (c_l > 9)
                        {
                            try
                            {
                                withDupes.Add(method_un(numbe, c_l));
                            }
                            catch { };
                        }
                    }
                List<string> noDupes = withDupes.Distinct().ToList();
                int range_list = noDupes.Count;

                foreach (string n in noDupes)
                    try
                    {
                        textBox2.AppendText(n);
                    }
                    catch { };
            label2.Text = "Было: " + le.ToString();
            label1.Text = "Стало: " + range_list.ToString();
            label3.Text = "Удалил: " + (le - range_list).ToString();
            });
            




        }

        string method_un(string c, int c_l)
        {
            if  (c_l == 11)
            {
                if (Regex.IsMatch(c, @"^79\w*"))
                    return c + Environment.NewLine;
                else if (Regex.IsMatch(c, @"^89\w*"))
                    return Regex.Replace(c, "^8", "7") + Environment.NewLine;
                else return null;
            }
            else if (c_l == 10 & Regex.IsMatch(c, @"^9\w*"))
            {
                return c.Insert(0, "7") + Environment.NewLine;
            }
            else return null;
        }

        string method_79(string c, int c_l)
        {
            if (Regex.IsMatch(c, @"^9\w*"))
            {
                Match match = Regex.Match(c, @"^9\w*");
                if (match.Value.Length == 10)
                    return c.Insert(0, "7") + Environment.NewLine;
                if (match.Value.Length > 10)
                {
                    return match.Value.Remove(10, match.Value.Length - 10).Insert(0, "7");
                }
                else return null;
            }
            else if (Regex.IsMatch(c, @"79\w*"))
            {
                Match match = Regex.Match(c, @"79\w*");
                if (match.Value.Length == 11)
                    return match.Value;
                if (match.Value.Length > 11)
                    return match.Value.Remove(11, match.Value.Length - 11) + Environment.NewLine;
                else return null;
            }
            else return null;
        }
        string method_89(string c, int c_l)
        {
            if (Regex.IsMatch(c, @"^9\w*"))
            {
                Match match = Regex.Match(c, @"^9\w*");
                if (match.Value.Length == 10)
                    return c.Insert(0, "7") + Environment.NewLine;
                if (match.Value.Length > 10)
                {
                    return match.Value.Remove(10, match.Value.Length - 10).Insert(0, "7") + Environment.NewLine;
                }
                else return null;
            }
            else if (Regex.IsMatch(c, @"89\w*"))
            {
                Match match = Regex.Match(c, @"89\w*");
                if (match.Value.Length == 11)
                    return Regex.Replace(match.Value, "^8", "7") + Environment.NewLine;
                if (match.Value.Length > 11)
                    return Regex.Replace(match.Value.Remove(11, match.Value.Length - 11),"^8", "7") + Environment.NewLine;
                else return null;
            }
            else return null;
        }

        private void поверхВсехОконToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(поверхВсехОконToolStripMenuItem.Checked == true)
            {
                поверхВсехОконToolStripMenuItem.Checked = false;
                TopMost = false;
            }
            else
            {
            поверхВсехОконToolStripMenuItem.Checked = true;
            TopMost = true;
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            try { 
                Clipboard.SetText(textBox2.Text);
                for (byte r = 0, g = 0, b = 0; r <= 176 & g <= 224 & b <= 230; r += 7, g += 12, b += 13, await Task.Delay(10))
                {
                    button2.ForeColor = Color.FromArgb(r, g, b);
                }
                button2.ForeColor = Color.FromArgb(176, 224, 230);

                button2.Text = "Скопировал";
                await Task.Delay(80);

                for (int r = 176, g = 224, b = 230; r >= 7 & g >= 12 & b >= 13; r -= 7, g -= 12, b -= 13, await Task.Delay(10))
                {
                    button2.ForeColor = Color.FromArgb(r, g, b);
                }
                button2.ForeColor = Color.FromArgb(0, 0, 0);

                Clipboard.SetText(textBox2.Text);
                for (byte r = 0, g = 0, b = 0; r <= 176 & g <= 224 & b <= 230; r += 7, g += 12, b += 13, await Task.Delay(10))
                {
                    button2.ForeColor = Color.FromArgb(r, g, b);
                }
                button2.ForeColor = Color.FromArgb(176, 224, 230);

                button2.Text = "Скопировать";
                await Task.Delay(80);

                for (int r = 176, g = 224, b = 230; r >= 7 & g >= 12 & b >= 13; r -= 7, g -= 12, b -= 13, await Task.Delay(10))
                {
                    button2.ForeColor = Color.FromArgb(r, g, b);
                }
                button2.ForeColor = Color.FromArgb(0, 0, 0);


            } 
            catch { MessageBox.Show("Тут, как бы, пусто"); }
        }

        private void начинаетсяС79ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (начинаетсяС79ToolStripMenuItem.Checked == true)
            {
                начинаетсяС79ToolStripMenuItem.Checked = false;
            }
            else
            {
                начинаетсяС79ToolStripMenuItem.Checked = true;
                начинаетсяС89ToolStripMenuItem.Checked = false;
            }
        }

        private void начинаетсяС89ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (начинаетсяС89ToolStripMenuItem.Checked == true)
            {
                начинаетсяС89ToolStripMenuItem.Checked = false;
            }
            else
            {
                начинаетсяС79ToolStripMenuItem.Checked = false;
                начинаетсяС89ToolStripMenuItem.Checked = true;
            }
        }
    }
}


