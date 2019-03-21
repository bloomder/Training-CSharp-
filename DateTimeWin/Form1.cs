using System;
using System.IO;
using System.Windows.Forms;

namespace DateTimeWin
{
    public partial class Form1 : Form
    {
        struct Human
        {
            public string Name;
            public string SurName;
            public string Patronymic;
            public string Address;
            public DateTime date;
        }
        public Form1()
        {
            InitializeComponent();
            ReadInfo();
        }
        String str,txt;
        int count = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Human human = new Human();
            DateTime today = DateTime.Now;
            TimeSpan left;count = 0;
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                human.date = DateTime.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                left = today - human.date;
                if (left.Days < 365 * 3 - 31)
                {
                    dataGridView1.Rows.RemoveAt(i); i--;
                }
                else
                {
                    if (left.Days < 365 * 3 + 31)
                    {
                        if (!today.Month.Equals(human.date.Month))
                        {
                            dataGridView1.Rows.RemoveAt(i); i--;
                        }
                    }
                }
            }
        }

        private void ReadInfo()
        {
            Human human = new Human();
            StreamReader sr = new StreamReader(Application.StartupPath + "\\date.txt");
            for (int i = 0; i < 20; i++)
            {
                str = sr.ReadLine();
                count = 0; txt = ""; human.Address = "";
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j].Equals(' '))
                    {
                        count++;
                        switch (count)
                        {
                            case 1:
                                human.SurName = txt;
                                break;
                            case 2:
                                human.Name = txt;
                                break;
                            case 3:
                                human.Patronymic = txt;
                                break;
                            case 4:
                                human.date = DateTime.Parse(txt);
                                break;
                            case 5:
                                human.Address += txt + " ";
                                break;
                        }
                        txt = "";
                    }
                    else
                    {
                        if(count>=5)
                        {
                            human.Address += str[j];
                        }
                        txt += str[j];
                    }
                }
                dataGridView1.Rows.Add(human.SurName,human.Name,human.Patronymic,human.Address,human.date.ToString("d"));
            }
        }
    }
}
