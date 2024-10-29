using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char input;
       
        private int NumberSymbols(string stroka, string symbol, string symbol2) 
        {
            int k = 0;
            int b = 0;
            for (int i = 0; i < stroka.Length; i++)
            {
                if (stroka[i] == symbol )
                {
                    k++;
                }
                for (int a = 0; a < stroka.Length; a++)
                {
                    if (stroka[a] == symbol2)
                    {
                        b++;
                    }
                }
                return b;
            }
            return k;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txt2.Text = NumberSymbols(txt1.Text, 'м','а').ToString();
        }
       

       
    }
}
 