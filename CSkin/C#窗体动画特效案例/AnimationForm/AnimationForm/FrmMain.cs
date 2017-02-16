using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AnimationForm
{
    public partial class FrmMain : Form
    {
        public FrmMain() {
            InitializeComponent();
        }

        #region 控制改变窗体拉伸和移动
        const int HTLEFT = 10;
        const int HTRIGHT = 11;
        const int HTTOP = 12;
        const int HTTOPLEFT = 13;
        const int HTTOPRIGHT = 14;
        const int HTBOTTOM = 15;
        const int HTBOTTOMLEFT = 0x10;
        const int HTBOTTOMRIGHT = 17;
        protected override void WndProc(ref Message m) {
            switch (m.Msg) {
                case 0x0084:
                    base.WndProc(ref m);
                    Point vPoint = new Point((int)m.LParam & 0xFFFF,
                        (int)m.LParam >> 16 & 0xFFFF);
                    vPoint = PointToClient(vPoint);
                    if (vPoint.X <= 5)
                        if (vPoint.Y <= 5)
                            m.Result = (IntPtr)HTTOPLEFT;
                        else if (vPoint.Y >= ClientSize.Height - 5)
                            m.Result = (IntPtr)HTBOTTOMLEFT;
                        else m.Result = (IntPtr)HTLEFT;
                    else if (vPoint.X >= ClientSize.Width - 5)
                        if (vPoint.Y <= 5)
                            m.Result = (IntPtr)HTTOPRIGHT;
                        else if (vPoint.Y >= ClientSize.Height - 5)
                            m.Result = (IntPtr)HTBOTTOMRIGHT;
                        else m.Result = (IntPtr)HTRIGHT;
                    else if (vPoint.Y <= 5)
                        m.Result = (IntPtr)HTTOP;
                    else if (vPoint.Y >= ClientSize.Height - 5)
                        m.Result = (IntPtr)HTBOTTOM;
                    break;
                case 0x0201://鼠标左键按下的消息 
                    m.Msg = 0x00A1;//更改消息为非客户区按下鼠标 
                    m.LParam = IntPtr.Zero;//默认值 
                    m.WParam = new IntPtr(2);//鼠标放在标题栏内 
                    base.WndProc(ref m);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        #endregion

        /// <summary>
        /// AW_SLIDE: 使用滑动类型。缺省则为滚动动画类型。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e) {
            //内向外扩展特效
            Win32.AnimateWindow(this.Handle, 300, Win32.AW_CENTER | Win32.AW_ACTIVATE | Win32.AW_SLIDE);
        }

        /// <summary>
        /// 淡入淡出特效
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJb_Click(object sender, EventArgs e) {
            //淡出特效隐藏
            if (Win32.AnimateWindow(this.Handle, 300, Win32.AW_BLEND | Win32.AW_HIDE)) {
                //淡入特效显示
                Win32.AnimateWindow(this.Handle, 300, Win32.AW_BLEND | Win32.AW_ACTIVATE);
            }
        }

        /// <summary>
        /// 右到左特效
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYdz_Click(object sender, EventArgs e) {
            //右到左特效隐藏
            if (Win32.AnimateWindow(this.Handle, 300, Win32.AW_HOR_NEGATIVE | Win32.AW_HIDE | Win32.AW_SLIDE)) {
                //右到左特效显示
                Win32.AnimateWindow(this.Handle, 300, Win32.AW_HOR_NEGATIVE | Win32.AW_ACTIVATE | Win32.AW_SLIDE);
            }
        }

        /// <summary>
        /// 左到右特效
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZdy_Click(object sender, EventArgs e) {
            //左到右特效隐藏
            if (Win32.AnimateWindow(this.Handle, 300, Win32.AW_HOR_POSITIVE | Win32.AW_HIDE | Win32.AW_SLIDE)) {
                //左到右特效显示
                Win32.AnimateWindow(this.Handle, 300, Win32.AW_HOR_POSITIVE | Win32.AW_ACTIVATE | Win32.AW_SLIDE);
            }
        }

        /// <summary>
        /// 收缩扩张特效
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKz_Click(object sender, EventArgs e) {
            //收缩特效隐藏
            if (Win32.AnimateWindow(this.Handle, 300, Win32.AW_CENTER | Win32.AW_HIDE | Win32.AW_SLIDE)) {
                //扩张特效显示
                Win32.AnimateWindow(this.Handle, 300, Win32.AW_CENTER | Win32.AW_ACTIVATE | Win32.AW_SLIDE);
            }
        }

        /// <summary>
        /// 上到下特效
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSx_Click(object sender, EventArgs e) {
            //上到下特效隐藏
            if (Win32.AnimateWindow(this.Handle, 300, Win32.AW_HIDE | Win32.AW_VER_POSITIVE | Win32.AW_SLIDE)) {
                //上到下特效显示
                Win32.AnimateWindow(this.Handle, 300, Win32.AW_ACTIVATE | Win32.AW_VER_POSITIVE | Win32.AW_SLIDE);
            }
        }

        /// <summary>
        /// 下到上特效
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXs_Click(object sender, EventArgs e) {
            //下到上特效隐藏
            if (Win32.AnimateWindow(this.Handle, 300, Win32.AW_HIDE | Win32.AW_VER_NEGATIVE | Win32.AW_SLIDE)) {
                //下到上特效显示
                Win32.AnimateWindow(this.Handle, 300, Win32.AW_ACTIVATE | Win32.AW_VER_NEGATIVE | Win32.AW_SLIDE);
            }
        }
    }
}
