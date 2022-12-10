using notification.Properties;
using System;
using System.Drawing;
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

                    if (Opacity == 0.0)
                        Close();

                    break;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Timer.Interval = 1;
            action = frm_notification.actionEnum.close;
        }

        public void setAlert(string msg, frm_notification.alertTypeEnum type)
        {
            if (Application.OpenForms["frm_notification"] != null)
            {
                Dispose();
            }
            else
            {
                Opacity = 0.0;
                StartPosition = FormStartPosition.Manual;

                x = Screen.PrimaryScreen.WorkingArea.Width - Width - 5;
                y = Screen.PrimaryScreen.WorkingArea.Height - Height + 20;

                Location = new Point(x, y);

                switch (type)
                {
                    case frm_notification.alertTypeEnum.Success:
                        picture_box.Image = Resources.done_64px;
                        BackColor = Color.FromArgb(42, 171, 160);
                        break;
                    case frm_notification.alertTypeEnum.Warning:
                        picture_box.Image = Resources.error_64px;
                        BackColor = Color.FromArgb(255, 179, 2);
                        break;
                    case frm_notification.alertTypeEnum.Error:
                        picture_box.Image = Resources.cancel_64px;
                        BackColor = Color.FromArgb(255, 121, 70);
                        break;
                    case frm_notification.alertTypeEnum.Info:
                        picture_box.Image = Resources.info_64px;
                        BackColor = Color.FromArgb(71, 169, 248);
                        break;
                }

                txt_message.Text = msg;
                Show();

                action = actionEnum.start;
                Timer.Interval = 1;
                Timer.Start();
            }
        }


        //custom notification event
        public static void Alert(string msg, frm_notification.alertTypeEnum type)
        {
            frm_notification f = new frm_notification();
            f.setAlert(msg, type);
        }

        //example of utilization
        //Notification.Alert("Your Text", frm_notification.alertTypeEnum.Warning);
    }
}
