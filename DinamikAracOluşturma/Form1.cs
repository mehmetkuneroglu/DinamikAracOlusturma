using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinamikAracOluşturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             for (int i = 0; i < 10; i++)
             {
                 Label lbl = new Label();
                 Point point = new Point(10, i*25+20);
                 lbl.Location = point;
                 lbl.Name = "label"+i;
                 lbl.Size = new Size(20, 30);
                 lbl.TabIndex = 0;
                 lbl.Text = "label"+i;
                 lbl.AutoSize = true;
                 lbl.BackColor = Color.Yellow;
                 lbl.ForeColor = Color.Black;
                 this.Controls.Add(lbl);
             }
             for (int i = 0; i < 10; i++)
             {
                 TextBox txt = new TextBox();
                 Point point = new Point(45, i * 25+20);
                 txt.Location = point;
                 txt.Name = "textbox"+i;
                 txt.Text = "";
                 this.Controls.Add(txt);
             }
             for (int i = 0; i < 10; i++)
             {
                 Button button = new Button();
                 Point point = new Point(150, i * 25+20);
                 button.Location = point;
                 button.Name = "button"+i;
                 button.Text = "button"+i;
                 this.Controls.Add(button);
             }
            */
            for (int i = 1; i < 55; i++)
            {
               
                Button button = new Button();
                button.Size = new Size(30, 30);
                button.Name = "button" + i;
                button.Text = (i).ToString();
                button.Margin = new Padding(1, 1, 1, 1);
                if (i == 31)
                {
                    flowLayoutPanel1.Controls.Add(label5);
                }
                if (i == 31)
                {
                    Label label = new Label();
                    label.Text = "KAPI";
                    label.BorderStyle = BorderStyle.FixedSingle;
                    label.Name = "label10";
                    label.BackColor = Color.White;
                    label.Width = 61;
                    label.Height = 30;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Margin = new Padding(1, 1, 1, 1);
                    flowLayoutPanel1.Controls.Add(label);
                }
                if (i == 2 || i == 6 || i == 10  || i == 40 || i == 44|| i == 48 || i == 52)
                {
                    button.Margin = new Padding(1, 1, 32, 1);

                }
                if (i==15)
                {
                    flowLayoutPanel1.Controls.Add(label1);
                }
                if (i == 19)
                {
                    flowLayoutPanel1.Controls.Add(label2);
                }
                if (i == 23)
                {
                    flowLayoutPanel1.Controls.Add(label3);
                }
                if (i == 27)
                {
                    flowLayoutPanel1.Controls.Add(label4);
                }
                
                if (i == 33)
                {
                    flowLayoutPanel1.Controls.Add(label6);
                }
                if (i == 37)
                {
                    flowLayoutPanel1.Controls.Add(label7);
                }

                flowLayoutPanel1.Controls.Add(button);
                flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
                





            }
        }     
    }
}
