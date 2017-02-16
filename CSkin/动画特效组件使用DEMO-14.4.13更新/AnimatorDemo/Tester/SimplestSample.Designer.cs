/********************************************************************
 * *
 * * 使本项目源码或本项目生成的DLL前请仔细阅读以下协议内容，如果你同意以下协议才能使用本项目所有的功能，
 * * 否则如果你违反了以下协议，有可能陷入法律纠纷和赔偿，作者保留追究法律责任的权利。
 * *
 * * 1、你可以在开发的软件产品中使用和修改本项目的源码和DLL，但是请保留所有相关的版权信息。
 * * 2、不能将本项目源码与作者的其他项目整合作为一个单独的软件售卖给他人使用。
 * * 3、不能传播本项目的源码和DLL，包括上传到网上、拷贝给他人等方式。
 * * 4、以上协议暂时定制，由于还不完善，作者保留以后修改协议的权利。
 * *
 * * Copyright (C) 2013-? cskin Corporation All rights reserved.
 * * 网站：CSkin界面库 http://www.cskin.net
 * * 作者： 乔克斯 QQ：345015918 .Net项目技术组群：306485590
 * * 请保留以上版权信息，否则作者将保留追究法律责任。
 * *
 * * 创建时间：2014-04-13
 * * 说明：SimplestSample.Designer.cs
 * *
********************************************************************/

namespace Tester
{
    partial class SimplestSample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            CCWin.SkinControl.Animation animation1 = new CCWin.SkinControl.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimplestSample));
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.btHide = new System.Windows.Forms.Button();
            this.btShow = new System.Windows.Forms.Button();
            this.animator = new CCWin.SkinControl.SkinAnimator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.animator.SetDecoration(this.pb1, CCWin.SkinControl.DecorationType.None);
            this.pb1.Image = global::Tester.Properties.Resources.cat_and_flowers;
            this.pb1.Location = new System.Drawing.Point(49, 72);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(200, 150);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // btHide
            // 
            this.animator.SetDecoration(this.btHide, CCWin.SkinControl.DecorationType.None);
            this.btHide.Location = new System.Drawing.Point(52, 242);
            this.btHide.Name = "btHide";
            this.btHide.Size = new System.Drawing.Size(75, 21);
            this.btHide.TabIndex = 1;
            this.btHide.Text = "Hide";
            this.btHide.UseVisualStyleBackColor = true;
            this.btHide.Click += new System.EventHandler(this.btHide_Click);
            // 
            // btShow
            // 
            this.animator.SetDecoration(this.btShow, CCWin.SkinControl.DecorationType.None);
            this.btShow.Location = new System.Drawing.Point(163, 242);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(75, 21);
            this.btShow.TabIndex = 2;
            this.btShow.Text = "Show";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // animator
            // 
            this.animator.AnimationType = CCWin.SkinControl.AnimationType.Mosaic;
            this.animator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 20;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.animator.DefaultAnimation = animation1;
            // 
            // SimplestSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 311);
            this.Controls.Add(this.btShow);
            this.Controls.Add(this.btHide);
            this.Controls.Add(this.pb1);
            this.animator.SetDecoration(this, CCWin.SkinControl.DecorationType.None);
            this.Name = "SimplestSample";
            this.Text = "SimplestSample";
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Button btHide;
        private System.Windows.Forms.Button btShow;
        private CCWin.SkinControl.SkinAnimator animator;
    }
}