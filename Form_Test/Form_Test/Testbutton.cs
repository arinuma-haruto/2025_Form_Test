using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Test
{
    public class TestButton : Button
    {
        private Color onColor = Color.LightBlue;
        private Color offColor = Color.Blue;
        private bool _enable;

        public void SetEnable(bool on)
        {
            _enable = on;
            if (on)
            {
                BackColor = onColor;
            }
            else
            {
                BackColor = offColor;
            }
        }

        public void Toggle()
        {
            SetEnable(!_enable);
        }

        //Buttonクラスを継承した
        //TestButtonクラスを作成してください
        private Form1 _form1;

        private int _x;

        private int _y;
    public TestButton(Form1 form1,int x, int y,Point position, Size size, string text)
        {
            _form1 = form1;
            _x = x;
            _y = y;
            //Form1の参照を保管
            _form1 = form1;

            //ボタンの位置を設定
            Location = position;
            //ボタンの大きさを設定
            Size  =size;
            //ボタン内のテキストを設定
            Text = text;

            SetEnable(false);

            Click += ClickEvent;
        }

        //自分で作成することも可能
        private void ClickEvent(object sender, EventArgs e)
        {
            //楽な書き方
              _form1.GetTestButton(_x, _y)?.Toggle();
              _form1.GetTestButton(_x+1, _y)?.Toggle();
              _form1.GetTestButton(_x+2, _y)?.Toggle();
              _form1.GetTestButton(_x, _y+1)?.Toggle();
              _form1.GetTestButton(_x, _y+2)?.Toggle();

           
            
        }

        

        }
    }

