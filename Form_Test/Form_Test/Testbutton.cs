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
    internal class TestButton : Button
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
    
    //Buttonクラスを継承した
    //TestButtonクラスを作成してください
    public TestButton(Point position, Size size, string text)
        {
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
            SetEnable(!_enable);
        }
    }
}
