using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace 弹窗控件
{
    public partial class TaskbarNotifier : Form
    {

        #region 控件保护成员变量
        protected Bitmap BackgroundBitmap = null;
        protected Bitmap CloseBitmap = null;
        protected Point CloseBitmapLocation;
        protected Size CloseBitmapSize;
        protected Rectangle RealTitleRectangle;
        protected Rectangle RealContentRectangle;
        protected Rectangle WorkAreaRectangle;
        protected Timer timer = new Timer();
        protected TaskbarStates taskbarState = TaskbarStates.hidden;
        protected string titleText;
        protected string contentText;
        protected Color normalTitleColor = Color.FromArgb(255, 255, 255);
        protected Color hoverTitleColor = Color.FromArgb(255, 255, 0);
        protected Color normalContentColor = Color.FromArgb(0, 0, 0);
        protected Color hoverContentColor = Color.FromArgb(0, 0, 0x66);
        protected Font normalTitleFont = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Pixel);
        protected Font hoverTitleFont = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Pixel);
        protected Font normalContentFont = new Font("Arial", 11, FontStyle.Regular, GraphicsUnit.Pixel);
        protected Font hoverContentFont = new Font("Arial", 11, FontStyle.Regular, GraphicsUnit.Pixel);
        protected int nShowEvents;
        protected int nHideEvents;
        protected int nVisibleEvents;
        protected int nIncrementShow;
        protected int nIncrementHide;
        protected bool bIsMouseOverPopup = false;
        protected bool bIsMouseOverClose = false;
        protected bool bIsMouseOverContent = false;
        protected bool bIsMouseOverTitle = false;
        protected bool bIsMouseDown = false;
        protected bool bKeepVisibleOnMouseOver = true;			
        protected bool bReShowOnMouseOver = false;	
        #endregion

        #region 控件公共成员变量
        public Rectangle TitleRectangle;
        public Rectangle ContentRectangle;
        public bool TitleClickable = false;
        public bool ContentClickable = true;
        public bool CloseClickable = true;
        public bool EnableSelectionRectangle = true;
        public event EventHandler CloseClick = null;
        public event EventHandler TitleClick = null;
        public event EventHandler ContentClick = null;
        #endregion

        //public enum nCmdShow_
        //{
        //    SW_HIDE = 0,
        //    SW_SHOWNORMAL = 1,
        //    SW_NORMAL = 1,
        //    SW_SHOWMINIMIZED = 2,
        //    SW_SHOWMAXIMIZED = 3,
        //    SW_MAXIMIZE = 3,
        //    SW_SHOWNOACTIVATE = 4,
        //    SW_SHOW = 5,
        //    SW_MINIMIZE = 6,
        //    SW_SHOWMINNOACTIVE = 7,
        //    SW_SHOWNA = 8,
        //    SW_RESTORE = 9,
        //    SW_SHOWDEFAULT = 10,
        //    SW_FORCEMINIMIZE = 11,
        //    SW_MAX = 11,
        //    SE_ERR_NOASSOC = 31
        //}

      
        #region 控件弹出动画状态列表枚举
        /// <summary>
        /// 弹出动画状态列表枚举
        /// </summary>
        public enum TaskbarStates
        {
            /// <summary>
            /// 隐藏
            /// </summary>
            hidden = 0,
            /// <summary>
            /// 正在弹出
            /// </summary>
            appearing = 1,
            /// <summary>
            /// 可见
            /// </summary>
            visible = 2,
            /// <summary>
            /// 正在消失
            /// </summary>
            disappearing = 3
        }
        #endregion

        #region 控件构造函数
        /// <summary>
        /// 控件构造函数
        /// </summary>
        public TaskbarNotifier()
        {
            // 窗体样式
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Minimized;
            base.Show();
            base.Hide();
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = false;
            TopMost = true;
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;

            timer.Enabled = true;
            timer.Tick += new EventHandler(OnTimer);
        }
        #endregion

        #region 控件属性
        /// <summary>
        /// 获取当前动画状态(隐藏,正在弹出,可见,正在隐藏)
        /// </summary>
        public TaskbarStates TaskbarState
        {
            get
            {
                return taskbarState;
            }
        }

        /// <summary>
        /// 获取/设置弹出标题文本
        /// </summary>
        public string TitleText
        {
            get
            {
                return titleText;
            }
            set
            {
                titleText = value;
                Refresh();
            }
        }

        /// <summary>
        /// 获取/设置弹出正文文本
        /// </summary>
        public string ContentText
        {
            get
            {
                return contentText;
            }
            set
            {
                contentText = value;
                Refresh();
            }
        }

        /// <summary>
        /// 获取/设置正常的标题颜色
        /// </summary>
        public Color NormalTitleColor
        {
            get
            {
                return normalTitleColor;
            }
            set
            {
                normalTitleColor = value;
                Refresh();
            }
        }

        /// <summary>
        /// 获取/设置悬停的标题颜色
        /// </summary>
        public Color HoverTitleColor
        {
            get
            {
                return hoverTitleColor;
            }
            set
            {
                hoverTitleColor = value;
                Refresh();
            }
        }

        /// <summary>
        /// 获取/设置正常的正文颜色
        /// </summary>
        public Color NormalContentColor
        {
            get
            {
                return normalContentColor;
            }
            set
            {
                normalContentColor = value;
                Refresh();
            }
        }

        /// <summary>
        /// 获取/设置悬停的正文颜色
        /// </summary>
        public Color HoverContentColor
        {
            get
            {
                return hoverContentColor;
            }
            set
            {
                hoverContentColor = value;
                Refresh();
            }
        }

        /// <summary>
        /// 获取/设置正常的标题字体
        /// </summary>
        public Font NormalTitleFont
        {
            get
            {
                return normalTitleFont;
            }
            set
            {
                normalTitleFont = value;
                Refresh();
            }
        }

        /// <summary>
        /// 获取/设置悬停的标题字体
        /// </summary>
        public Font HoverTitleFont
        {
            get
            {
                return hoverTitleFont;
            }
            set
            {
                hoverTitleFont = value;
                Refresh();
            }
        }

        /// <summary>
        /// 获取/设置正常的正文字体
        /// </summary>
        public Font NormalContentFont
        {
            get
            {
                return normalContentFont;
            }
            set
            {
                normalContentFont = value;
                Refresh();
            }
        }

        /// <summary>
        /// 获取/设置悬停的正文字体
        /// </summary>
        public Font HoverContentFont
        {
            get
            {
                return hoverContentFont;
            }
            set
            {
                hoverContentFont = value;
                Refresh();
            }
        }

        /// <summary>
        /// 鼠标停留保持窗口是否可见
        /// </summary>
        public bool KeepVisibleOnMousOver
        {
            get
            {
                return bKeepVisibleOnMouseOver;
            }
            set
            {
                bKeepVisibleOnMouseOver = value;
            }
        }

        /// <summary>
        /// 鼠标划过是否再次激活窗口
        /// </summary>
        public bool ReShowOnMouseOver
        {
            get
            {
                return bReShowOnMouseOver;
            }
            set
            {
                bReShowOnMouseOver = value;
            }
        }

        #endregion

        #region 控件公共方法
        /// <summary>
        /// 显示窗口
        /// </summary>
        /// <param name="hWnd">窗口句柄</param>
        /// <param name="nCmdShow">显示方式</param>
        /// <returns></returns>
        [DllImport("user32.dll")]
       
        private static extern Boolean ShowWindow(IntPtr hWnd, Int32 nCmdShow);
        /// <summary>
        /// 显示弹窗和时间参数
        /// </summary>
        /// <param name="strTitle">弹窗标题</param>
        /// <param name="strContent">弹窗正文</param>
        /// <param name="nTimeToShow">延迟时间(毫秒)</param>
        /// <param name="nTimeToStay">停留时间(毫秒)</param>
        /// <param name="nTimeToHide">消失时间(毫秒)</param>
        /// <returns></returns>
        public void Show(string strTitle, string strContent, int nTimeToShow, int nTimeToStay, int nTimeToHide)
        {
            WorkAreaRectangle = Screen.GetWorkingArea(WorkAreaRectangle);
            titleText = strTitle;
            contentText = strContent;
            nVisibleEvents = nTimeToStay;
            CalculateMouseRectangles();

            // We calculate the pixel increment and the timer value for the showing animation
            int nEvents;
            if (nTimeToShow > 10)
            {
                nEvents = Math.Min((nTimeToShow / 10), BackgroundBitmap.Height);
                nShowEvents = nTimeToShow / nEvents;
                nIncrementShow = BackgroundBitmap.Height / nEvents;
            }
            else
            {
                nShowEvents = 10;
                nIncrementShow = BackgroundBitmap.Height;
            }

            // We calculate the pixel increment and the timer value for the hiding animation
            if (nTimeToHide > 10)
            {
                nEvents = Math.Min((nTimeToHide / 10), BackgroundBitmap.Height);
                nHideEvents = nTimeToHide / nEvents;
                nIncrementHide = BackgroundBitmap.Height / nEvents;
            }
            else
            {
                nHideEvents = 10;
                nIncrementHide = BackgroundBitmap.Height;
            }

            switch (taskbarState)
            {
                case TaskbarStates.hidden://检测状态隐藏时
                    taskbarState = TaskbarStates.appearing;//设置正在弹出
                    SetBounds(WorkAreaRectangle.Right - BackgroundBitmap.Width - 17, WorkAreaRectangle.Bottom - 1, BackgroundBitmap.Width, 0);
                    timer.Interval = nShowEvents;
                    timer.Start();
                    // We Show the popup without stealing focus
                    ShowWindow(this.Handle, 4);
                    break;

                case TaskbarStates.appearing://检测状态正在弹出时
                    Refresh();
                    break;

                case TaskbarStates.visible://检测状态为可见
                    timer.Stop();
                    timer.Interval = nVisibleEvents;
                    timer.Start();
                    Refresh();
                    break;

                case TaskbarStates.disappearing://检测状态为正在消失时
                    timer.Stop();
                    taskbarState = TaskbarStates.visible;
                    SetBounds(WorkAreaRectangle.Right - BackgroundBitmap.Width - 17, WorkAreaRectangle.Bottom - BackgroundBitmap.Height - 1, BackgroundBitmap.Width, BackgroundBitmap.Height);
                    timer.Interval = nVisibleEvents;
                    timer.Start();
                    Refresh();
                    break;
            }
        }

        /// <summary>
        /// 隐藏弹窗
        /// </summary>
        /// <returns></returns>
        public new void Hide()
        {
            if (taskbarState != TaskbarStates.hidden)
            {
                timer.Stop();
                taskbarState = TaskbarStates.hidden;
                //this.Dispose();//此处应该释放资源,待续
                
                base.Hide();
            }
        }

        /// <summary>
        /// Sets the background bitmap and its transparency color
        /// </summary>
        /// <param name="strFilename">Path of the Background Bitmap on the disk</param>
        /// <param name="transparencyColor">Color of the Bitmap which won't be visible</param>
        /// <returns>Nothing</returns>
        public void SetBackgroundBitmap(string strFilename, Color transparencyColor)
        {
            BackgroundBitmap = new Bitmap(strFilename);
            Width = BackgroundBitmap.Width;
            Height = BackgroundBitmap.Height;
            Region = BitmapToRegion(BackgroundBitmap, transparencyColor);
        }

        /// <summary>
        /// Sets the background bitmap and its transparency color
        /// </summary>
        /// <param name="image">Image/Bitmap object which represents the Background Bitmap</param>
        /// <param name="transparencyColor">Color of the Bitmap which won't be visible</param>
        /// <returns>Nothing</returns>
        public void SetBackgroundBitmap(Image image, Color transparencyColor)
        {
            BackgroundBitmap = new Bitmap(image);
            Width = BackgroundBitmap.Width;
            Height = BackgroundBitmap.Height;
            Region = BitmapToRegion(BackgroundBitmap, transparencyColor);
        }

        /// <summary>
        /// Sets the 3-State Close Button bitmap, its transparency color and its coordinates
        /// </summary>
        /// <param name="strFilename">Path of the 3-state Close button Bitmap on the disk (width must a multiple of 3)</param>
        /// <param name="transparencyColor">Color of the Bitmap which won't be visible</param>
        /// <param name="position">Location of the close button on the popup</param>
        /// <returns>Nothing</returns>
        public void SetCloseBitmap(string strFilename, Color transparencyColor, Point position)
        {
            CloseBitmap = new Bitmap(strFilename);
            CloseBitmap.MakeTransparent(transparencyColor);
            CloseBitmapSize = new Size(CloseBitmap.Width / 3, CloseBitmap.Height);
            CloseBitmapLocation = position;
        }

        /// <summary>
        /// Sets the 3-State Close Button bitmap, its transparency color and its coordinates
        /// </summary>
        /// <param name="image">Image/Bitmap object which represents the 3-state Close button Bitmap (width must be a multiple of 3)</param>
        /// <param name="transparencyColor">Color of the Bitmap which won't be visible</param>
        /// /// <param name="position">Location of the close button on the popup</param>
        /// <returns>Nothing</returns>
        public void SetCloseBitmap(Image image, Color transparencyColor, Point position)
        {
            CloseBitmap = new Bitmap(image);
            CloseBitmap.MakeTransparent(transparencyColor);
            CloseBitmapSize = new Size(CloseBitmap.Width / 3, CloseBitmap.Height);
            CloseBitmapLocation = position;
        }
        #endregion

        #region 控件保护成员方法
        /// <summary>
        /// 绘制关闭按钮
        /// </summary>
        /// <param name="grfx">绘制图面(背景底层)</param>
        protected void DrawCloseButton(Graphics grfx)
        {
            if (CloseBitmap != null)
            {
                Rectangle rectDest = new Rectangle(CloseBitmapLocation, CloseBitmapSize);
                Rectangle rectSrc;

                if (bIsMouseOverClose)
                {
                    if (bIsMouseDown)
                        rectSrc = new Rectangle(new Point(CloseBitmapSize.Width * 2, 0), CloseBitmapSize);
                    else
                        rectSrc = new Rectangle(new Point(CloseBitmapSize.Width, 0), CloseBitmapSize);
                }
                else
                    rectSrc = new Rectangle(new Point(0, 0), CloseBitmapSize);


                grfx.DrawImage(CloseBitmap, rectDest, rectSrc, GraphicsUnit.Pixel);
            }
        }

        /// <summary>
        /// 绘制标题/正文
        /// </summary>
        /// <param name="grfx">绘制图面(背景底层)</param>
        protected void DrawText(Graphics grfx)
        {
            if (titleText != null && titleText.Length != 0)
            {
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Near;
                sf.LineAlignment = StringAlignment.Center;
                sf.FormatFlags = StringFormatFlags.NoWrap;
                sf.Trimming = StringTrimming.EllipsisCharacter;				// Added Rev 002
                if (bIsMouseOverTitle)
                    grfx.DrawString(titleText, hoverTitleFont, new SolidBrush(hoverTitleColor), TitleRectangle, sf);
                else
                    grfx.DrawString(titleText, normalTitleFont, new SolidBrush(normalTitleColor), TitleRectangle, sf);
            }

            if (contentText != null && contentText.Length != 0)
            {
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                sf.FormatFlags = StringFormatFlags.MeasureTrailingSpaces;
                sf.Trimming = StringTrimming.Word;							

                if (bIsMouseOverContent)
                {
                    grfx.DrawString(contentText, hoverContentFont, new SolidBrush(hoverContentColor), ContentRectangle, sf);
                    if (EnableSelectionRectangle)
                        ControlPaint.DrawBorder3D(grfx, RealContentRectangle, Border3DStyle.Etched, Border3DSide.Top | Border3DSide.Bottom | Border3DSide.Left | Border3DSide.Right);

                }
                else
                    grfx.DrawString(contentText, normalContentFont, new SolidBrush(normalContentColor), ContentRectangle, sf);
            }
        }

        /// <summary>
        /// 计算鼠标矩形
        /// </summary>
        protected void CalculateMouseRectangles()
        {
            Graphics grfx = CreateGraphics();
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            sf.FormatFlags = StringFormatFlags.MeasureTrailingSpaces;
            SizeF sizefTitle = grfx.MeasureString(titleText, hoverTitleFont, TitleRectangle.Width, sf);
            SizeF sizefContent = grfx.MeasureString(contentText, hoverContentFont, ContentRectangle.Width, sf);
            grfx.Dispose();

            //检测标题矩形是否适合预置的标题矩形
            if (sizefTitle.Height > TitleRectangle.Height)
            {
                RealTitleRectangle = new Rectangle(TitleRectangle.Left, TitleRectangle.Top, TitleRectangle.Width, TitleRectangle.Height);
            }
            else
            {
                RealTitleRectangle = new Rectangle(TitleRectangle.Left, TitleRectangle.Top, (int)sizefTitle.Width, (int)sizefTitle.Height);
            }
            RealTitleRectangle.Inflate(0, 2);

            //检测正文矩形是否适合预置的正文矩形
            if (sizefContent.Height > ContentRectangle.Height)
            {
                RealContentRectangle = new Rectangle((ContentRectangle.Width - (int)sizefContent.Width) / 2 + ContentRectangle.Left, ContentRectangle.Top, (int)sizefContent.Width, ContentRectangle.Height);
            }
            else
            {
                RealContentRectangle = new Rectangle((ContentRectangle.Width - (int)sizefContent.Width) / 2 + ContentRectangle.Left, (ContentRectangle.Height - (int)sizefContent.Height) / 2 + ContentRectangle.Top, (int)sizefContent.Width, (int)sizefContent.Height);
            }
            RealContentRectangle.Inflate(0, 2);
        }

        /// <summary>
        /// 位图区域
        /// </summary>
        /// <param name="bitmap">位图</param>
        /// <param name="transparencyColor">透明颜色</param>
        /// <returns></returns>
        protected Region BitmapToRegion(Bitmap bitmap, Color transparencyColor)
        {
            if (bitmap == null)
                throw new ArgumentNullException("位图", "位图不能为空!");

            int height = bitmap.Height;
            int width = bitmap.Width;

            GraphicsPath path = new GraphicsPath();

            for (int j = 0; j < height; j++)
                for (int i = 0; i < width; i++)
                {
                    if (bitmap.GetPixel(i, j) == transparencyColor)
                        continue;

                    int x0 = i;

                    while ((i < width) && (bitmap.GetPixel(i, j) != transparencyColor))
                        i++;

                    path.AddRectangle(new Rectangle(x0, j, i - x0, 1));
                }

            Region region = new Region(path);
            path.Dispose();
            return region;
        }
        #endregion

        #region 控件重写事件
        /// <summary>
        /// 定时器事件重写
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="ea"></param>
        protected void OnTimer(Object obj, EventArgs ea)
        {
            switch (taskbarState)
            {
                case TaskbarStates.appearing:
                    if (Height < BackgroundBitmap.Height)
                        SetBounds(Left, Top - nIncrementShow, Width, Height + nIncrementShow);
                    else
                    {
                        timer.Stop();
                        Height = BackgroundBitmap.Height;
                        timer.Interval = nVisibleEvents;
                        taskbarState = TaskbarStates.visible;
                        timer.Start();
                    }
                    break;

                case TaskbarStates.visible:
                    timer.Stop();
                    timer.Interval = nHideEvents;
                    // Added Rev 002
                    if ((bKeepVisibleOnMouseOver && !bIsMouseOverPopup) || (!bKeepVisibleOnMouseOver))
                    {
                        taskbarState = TaskbarStates.disappearing;
                    }
                    //taskbarState = TaskbarStates.disappearing;		// Rev 002
                    timer.Start();
                    break;

                case TaskbarStates.disappearing:
                    // Added Rev 002
                    if (bReShowOnMouseOver && bIsMouseOverPopup)
                    {
                        taskbarState = TaskbarStates.appearing;
                    }
                    else
                    {
                        if (Top < WorkAreaRectangle.Bottom)
                            SetBounds(Left, Top + nIncrementHide, Width, Height - nIncrementHide);
                        else
                            Hide();
                    }
                    break;
            }

        }

        /// <summary>
        /// 鼠标进入控件事件重写
        /// </summary>
        /// <param name="ea"></param>
        protected override void OnMouseEnter(EventArgs ea)
        {
            base.OnMouseEnter(ea);
            bIsMouseOverPopup = true;
            Refresh();
        }

        /// <summary>
        /// 鼠标离开组件事件重写
        /// </summary>
        /// <param name="ea"></param>
        protected override void OnMouseLeave(EventArgs ea)
        {
            base.OnMouseLeave(ea);
            bIsMouseOverPopup = false;
            bIsMouseOverClose = false;
            bIsMouseOverTitle = false;
            bIsMouseOverContent = false;
            Refresh();
        }

        /// <summary>
        /// 鼠标移过组件事件重写
        /// </summary>
        /// <param name="mea"></param>
        protected override void OnMouseMove(MouseEventArgs mea)
        {
            base.OnMouseMove(mea);

            bool bContentModified = false;

            if ((mea.X > CloseBitmapLocation.X) && (mea.X < CloseBitmapLocation.X + CloseBitmapSize.Width) && (mea.Y > CloseBitmapLocation.Y) && (mea.Y < CloseBitmapLocation.Y + CloseBitmapSize.Height) && CloseClickable)
            {
                if (!bIsMouseOverClose)
                {
                    bIsMouseOverClose = true;
                    bIsMouseOverTitle = false;
                    bIsMouseOverContent = false;
                    Cursor = Cursors.Hand;
                    bContentModified = true;
                }
            }
            else if (RealContentRectangle.Contains(new Point(mea.X, mea.Y)) && ContentClickable)
            {
                if (!bIsMouseOverContent)
                {
                    bIsMouseOverClose = false;
                    bIsMouseOverTitle = false;
                    bIsMouseOverContent = true;
                    Cursor = Cursors.Hand;
                    bContentModified = true;
                }
            }
            else if (RealTitleRectangle.Contains(new Point(mea.X, mea.Y)) && TitleClickable)
            {
                if (!bIsMouseOverTitle)
                {
                    bIsMouseOverClose = false;
                    bIsMouseOverTitle = true;
                    bIsMouseOverContent = false;
                    Cursor = Cursors.Hand;
                    bContentModified = true;
                }
            }
            else
            {
                if (bIsMouseOverClose || bIsMouseOverTitle || bIsMouseOverContent)
                    bContentModified = true;

                bIsMouseOverClose = false;
                bIsMouseOverTitle = false;
                bIsMouseOverContent = false;
                Cursor = Cursors.Default;
            }

            if (bContentModified)
                Refresh();
        }

        /// <summary>
        /// 鼠标在组件按下事件重写
        /// </summary>
        /// <param name="mea"></param>
        protected override void OnMouseDown(MouseEventArgs mea)
        {
            base.OnMouseDown(mea);
            bIsMouseDown = true;

            if (bIsMouseOverClose)
                Refresh();
        }

        /// <summary>
        /// 鼠标在组件谈起事件重写
        /// </summary>
        /// <param name="mea"></param>
        protected override void OnMouseUp(MouseEventArgs mea)
        {
            base.OnMouseUp(mea);
            bIsMouseDown = false;

            if (bIsMouseOverClose)
            {
                Hide();

                if (CloseClick != null)
                    CloseClick(this, new EventArgs());
            }
            else if (bIsMouseOverTitle)
            {
                if (TitleClick != null)
                    TitleClick(this, new EventArgs());
            }
            else if (bIsMouseOverContent)
            {
                if (ContentClick != null)
                    ContentClick(this, new EventArgs());
            }
        }

        /// <summary>
        /// 重绘背景
        /// </summary>
        /// <param name="pea"></param>
        protected override void OnPaintBackground(PaintEventArgs pea)
        {
            Graphics grfx = pea.Graphics;
            grfx.PageUnit = GraphicsUnit.Pixel;

            Graphics offScreenGraphics;
            Bitmap offscreenBitmap;

            offscreenBitmap = new Bitmap(BackgroundBitmap.Width, BackgroundBitmap.Height);
            offScreenGraphics = Graphics.FromImage(offscreenBitmap);

            if (BackgroundBitmap != null)
            {
                offScreenGraphics.DrawImage(BackgroundBitmap, 0, 0, BackgroundBitmap.Width, BackgroundBitmap.Height);
            }

            DrawCloseButton(offScreenGraphics);
            DrawText(offScreenGraphics);

            grfx.DrawImage(offscreenBitmap, 0, 0);
        }
        #endregion

        private void TaskbarNotifier_Load(object sender, EventArgs e)
        {

        }
    }
}
