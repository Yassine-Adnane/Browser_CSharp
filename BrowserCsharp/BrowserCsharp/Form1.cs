using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowserCsharp
{
    public partial class Form1 : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams Prmtr = base.CreateParams;
                Prmtr.ClassStyle |= 0x200;
                return Prmtr;
            }
        }

        private int _Ticks;
        Timer timer = new Timer();

        public Form1()
        {
            _Ticks = 0;

            InitializeComponent();
            webBrowser1.Navigate("https://www.youtube.com/?hl=FR");

            
            timer.Interval = (10 * 1000); // 10 secs
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
            _Ticks++;
            if(_Ticks == 10)
            {
                webBrowser1.Navigate("https://mail.google.com/mail/u/0/?tab=wm#inbox");
                _Ticks = 0;
            }
            */
            webBrowser1.Navigate("https://mail.google.com/mail/u/0/?tab=wm#inbox");
            //webBrowser1.Navigate("https://www.youtube.com/?hl=FR");

        }
    }
}
