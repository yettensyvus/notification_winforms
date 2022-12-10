using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notification
{
    public partial class frm_notification : Form
    {
        public frm_notification()
        {
            InitializeComponent();
            TopMost = true; //add form on foreground

        }
        private int x, y;

        public enum alertTypeEnum
        {
            Success, Warning, Error, Info
        }

        public enum actionEnum
        {
            start, wait, close
        }

        private frm_notification.actionEnum action;

        private void Timer_Tick(object sender, EventArgs e)
        {
            switch (action)
            {
                case frm_notification.actionEnum.wait:

                    Timer.Interval = 1500;
                    action = frm_notification.actionEnum.close;

                    break;

                case frm_notification.actionEnum.start:

                    Timer.Interval = 1;
                    Opacity += 0.1;

                    if (x < Location.X)
                        Left--;
                    else if (Opacity == 1.0)
                        action = frm_notification.actionEnum.wait;

                    break;

                case frm_notification.actionEnum.close:

                    Timer.Interval = 1;
                    Opacity -= 0.1;
                    Left -= 3;

                    if (base.Opacity == 0.0)
                        base.Close();

                    break;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Timer.Interval = 1;
            action = frm_notification.actionEnum.close;
        }
    }
}
