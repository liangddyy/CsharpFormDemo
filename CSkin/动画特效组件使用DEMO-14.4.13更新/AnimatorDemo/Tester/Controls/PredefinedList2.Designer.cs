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
 * * 说明：PredefinedList2.Designer.cs
 * *
********************************************************************/

namespace Tester.Controls
{
    partial class PredefinedList2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbRotate = new System.Windows.Forms.CheckBox();
            this.rbHorizSlide = new System.Windows.Forms.CheckBox();
            this.rbVertSlide = new System.Windows.Forms.CheckBox();
            this.rbScale = new System.Windows.Forms.CheckBox();
            this.rbScaleAndRotate = new System.Windows.Forms.CheckBox();
            this.rbHorizSlideAndRotate = new System.Windows.Forms.CheckBox();
            this.rbScaleAndHorizSlide = new System.Windows.Forms.CheckBox();
            this.rbTransparent = new System.Windows.Forms.CheckBox();
            this.rbLeaf = new System.Windows.Forms.CheckBox();
            this.rbMosaic = new System.Windows.Forms.CheckBox();
            this.rbVertBlind = new System.Windows.Forms.CheckBox();
            this.rbHorizBlind = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbParticles = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // rbRotate
            // 
            this.rbRotate.AutoSize = true;
            this.rbRotate.Location = new System.Drawing.Point(15, 27);
            this.rbRotate.Name = "rbRotate";
            this.rbRotate.Size = new System.Drawing.Size(60, 16);
            this.rbRotate.TabIndex = 0;
            this.rbRotate.Text = "Rotate";
            this.rbRotate.UseVisualStyleBackColor = true;
            this.rbRotate.CheckedChanged += new System.EventHandler(this.rbHorizBlind_CheckedChanged);
            // 
            // rbHorizSlide
            // 
            this.rbHorizSlide.AutoSize = true;
            this.rbHorizSlide.Location = new System.Drawing.Point(15, 48);
            this.rbHorizSlide.Name = "rbHorizSlide";
            this.rbHorizSlide.Size = new System.Drawing.Size(84, 16);
            this.rbHorizSlide.TabIndex = 1;
            this.rbHorizSlide.Text = "HorizSlide";
            this.rbHorizSlide.UseVisualStyleBackColor = true;
            this.rbHorizSlide.CheckedChanged += new System.EventHandler(this.rbHorizBlind_CheckedChanged);
            // 
            // rbVertSlide
            // 
            this.rbVertSlide.AutoSize = true;
            this.rbVertSlide.Location = new System.Drawing.Point(15, 69);
            this.rbVertSlide.Name = "rbVertSlide";
            this.rbVertSlide.Size = new System.Drawing.Size(78, 16);
            this.rbVertSlide.TabIndex = 2;
            this.rbVertSlide.Text = "VertSlide";
            this.rbVertSlide.UseVisualStyleBackColor = true;
            this.rbVertSlide.CheckedChanged += new System.EventHandler(this.rbHorizBlind_CheckedChanged);
            // 
            // rbScale
            // 
            this.rbScale.AutoSize = true;
            this.rbScale.Location = new System.Drawing.Point(15, 90);
            this.rbScale.Name = "rbScale";
            this.rbScale.Size = new System.Drawing.Size(54, 16);
            this.rbScale.TabIndex = 3;
            this.rbScale.Text = "Scale";
            this.rbScale.UseVisualStyleBackColor = true;
            this.rbScale.CheckedChanged += new System.EventHandler(this.rbHorizBlind_CheckedChanged);
            // 
            // rbScaleAndRotate
            // 
            this.rbScaleAndRotate.AutoSize = true;
            this.rbScaleAndRotate.Location = new System.Drawing.Point(15, 112);
            this.rbScaleAndRotate.Name = "rbScaleAndRotate";
            this.rbScaleAndRotate.Size = new System.Drawing.Size(108, 16);
            this.rbScaleAndRotate.TabIndex = 4;
            this.rbScaleAndRotate.Text = "ScaleAndRotate";
            this.rbScaleAndRotate.UseVisualStyleBackColor = true;
            this.rbScaleAndRotate.CheckedChanged += new System.EventHandler(this.rbHorizBlind_CheckedChanged);
            // 
            // rbHorizSlideAndRotate
            // 
            this.rbHorizSlideAndRotate.AutoSize = true;
            this.rbHorizSlideAndRotate.Location = new System.Drawing.Point(15, 133);
            this.rbHorizSlideAndRotate.Name = "rbHorizSlideAndRotate";
            this.rbHorizSlideAndRotate.Size = new System.Drawing.Size(138, 16);
            this.rbHorizSlideAndRotate.TabIndex = 5;
            this.rbHorizSlideAndRotate.Text = "HorizSlideAndRotate";
            this.rbHorizSlideAndRotate.UseVisualStyleBackColor = true;
            this.rbHorizSlideAndRotate.CheckedChanged += new System.EventHandler(this.rbHorizBlind_CheckedChanged);
            // 
            // rbScaleAndHorizSlide
            // 
            this.rbScaleAndHorizSlide.AutoSize = true;
            this.rbScaleAndHorizSlide.Location = new System.Drawing.Point(15, 154);
            this.rbScaleAndHorizSlide.Name = "rbScaleAndHorizSlide";
            this.rbScaleAndHorizSlide.Size = new System.Drawing.Size(132, 16);
            this.rbScaleAndHorizSlide.TabIndex = 6;
            this.rbScaleAndHorizSlide.Text = "ScaleAndHorizSlide";
            this.rbScaleAndHorizSlide.UseVisualStyleBackColor = true;
            this.rbScaleAndHorizSlide.CheckedChanged += new System.EventHandler(this.rbHorizBlind_CheckedChanged);
            // 
            // rbTransparent
            // 
            this.rbTransparent.AutoSize = true;
            this.rbTransparent.Location = new System.Drawing.Point(15, 175);
            this.rbTransparent.Name = "rbTransparent";
            this.rbTransparent.Size = new System.Drawing.Size(90, 16);
            this.rbTransparent.TabIndex = 7;
            this.rbTransparent.Text = "Transparent";
            this.rbTransparent.UseVisualStyleBackColor = true;
            this.rbTransparent.CheckedChanged += new System.EventHandler(this.rbHorizBlind_CheckedChanged);
            // 
            // rbLeaf
            // 
            this.rbLeaf.AutoSize = true;
            this.rbLeaf.Location = new System.Drawing.Point(15, 197);
            this.rbLeaf.Name = "rbLeaf";
            this.rbLeaf.Size = new System.Drawing.Size(48, 16);
            this.rbLeaf.TabIndex = 8;
            this.rbLeaf.Text = "Leaf";
            this.rbLeaf.UseVisualStyleBackColor = true;
            this.rbLeaf.CheckedChanged += new System.EventHandler(this.rbHorizBlind_CheckedChanged);
            // 
            // rbMosaic
            // 
            this.rbMosaic.AutoSize = true;
            this.rbMosaic.Location = new System.Drawing.Point(15, 218);
            this.rbMosaic.Name = "rbMosaic";
            this.rbMosaic.Size = new System.Drawing.Size(60, 16);
            this.rbMosaic.TabIndex = 9;
            this.rbMosaic.Text = "Mosaic";
            this.rbMosaic.UseVisualStyleBackColor = true;
            this.rbMosaic.CheckedChanged += new System.EventHandler(this.rbHorizBlind_CheckedChanged);
            // 
            // rbVertBlind
            // 
            this.rbVertBlind.AutoSize = true;
            this.rbVertBlind.Location = new System.Drawing.Point(15, 283);
            this.rbVertBlind.Name = "rbVertBlind";
            this.rbVertBlind.Size = new System.Drawing.Size(78, 16);
            this.rbVertBlind.TabIndex = 10;
            this.rbVertBlind.Text = "VertBlind";
            this.rbVertBlind.UseVisualStyleBackColor = true;
            this.rbVertBlind.CheckedChanged += new System.EventHandler(this.rbHorizBlind_CheckedChanged);
            // 
            // rbHorizBlind
            // 
            this.rbHorizBlind.AutoSize = true;
            this.rbHorizBlind.Location = new System.Drawing.Point(15, 262);
            this.rbHorizBlind.Name = "rbHorizBlind";
            this.rbHorizBlind.Size = new System.Drawing.Size(84, 16);
            this.rbHorizBlind.TabIndex = 11;
            this.rbHorizBlind.Text = "HorizBlind";
            this.rbHorizBlind.UseVisualStyleBackColor = true;
            this.rbHorizBlind.CheckedChanged += new System.EventHandler(this.rbHorizBlind_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "预定义的动画";
            // 
            // cbParticles
            // 
            this.cbParticles.AutoSize = true;
            this.cbParticles.Location = new System.Drawing.Point(15, 241);
            this.cbParticles.Name = "cbParticles";
            this.cbParticles.Size = new System.Drawing.Size(78, 16);
            this.cbParticles.TabIndex = 13;
            this.cbParticles.Text = "Particles";
            this.cbParticles.UseVisualStyleBackColor = true;
            this.cbParticles.CheckedChanged += new System.EventHandler(this.rbHorizBlind_CheckedChanged);
            // 
            // PredefinedList2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbParticles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbHorizBlind);
            this.Controls.Add(this.rbVertBlind);
            this.Controls.Add(this.rbMosaic);
            this.Controls.Add(this.rbLeaf);
            this.Controls.Add(this.rbTransparent);
            this.Controls.Add(this.rbScaleAndHorizSlide);
            this.Controls.Add(this.rbHorizSlideAndRotate);
            this.Controls.Add(this.rbScaleAndRotate);
            this.Controls.Add(this.rbScale);
            this.Controls.Add(this.rbVertSlide);
            this.Controls.Add(this.rbHorizSlide);
            this.Controls.Add(this.rbRotate);
            this.Name = "PredefinedList2";
            this.Size = new System.Drawing.Size(175, 321);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox rbRotate;
        private System.Windows.Forms.CheckBox rbHorizSlide;
        private System.Windows.Forms.CheckBox rbVertSlide;
        private System.Windows.Forms.CheckBox rbScale;
        private System.Windows.Forms.CheckBox rbScaleAndRotate;
        private System.Windows.Forms.CheckBox rbHorizSlideAndRotate;
        private System.Windows.Forms.CheckBox rbScaleAndHorizSlide;
        private System.Windows.Forms.CheckBox rbTransparent;
        private System.Windows.Forms.CheckBox rbLeaf;
        private System.Windows.Forms.CheckBox rbMosaic;
        private System.Windows.Forms.CheckBox rbVertBlind;
        private System.Windows.Forms.CheckBox rbHorizBlind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbParticles;
    }
}
