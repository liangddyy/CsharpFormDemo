// Demo02.cpp : 定义控制台应用程序的入口点。
//

#include "stdafx.h"
#include<iostream> 
#include <opencv2/core/core.hpp> 
#include <opencv2/opencv.hpp>
#include <opencv2/highgui/highgui.hpp> 
#include <opencv2/imgproc/imgproc.hpp>
#include <vector>

using namespace cv;
using namespace std;

void test01() {
	// 读入一张图片（游戏原画） 
	Mat img = imread("E:\\1.jpg");

	Mat src = img.clone();
	Mat src1 = img.clone();
	Mat img2 = img.clone();
	/*
	// 创建一个名为 "游戏原画"窗口
	namedWindow("游戏原画");
	// 在窗口中显示游戏原画
	imshow("游戏原画", img);
	// 等待6000 ms后窗口自动关闭
	waitKey(6000);
	*/

	//Canny(img2, img2, 3, 9, 3);
	//Canny(img2, img2, 150, 100, 3);
	//imshow("Canny边缘检测", img2);

	/* Canny边缘检测 Begin */
	Mat dst, edge, gray;

	// 【1】创建与src同类型和大小的矩阵(dst)   
	dst.create(src1.size(), src1.type());

	// 【2】将原图像转换为灰度图像   
	cvtColor(src1, gray, CV_BGR2GRAY);

	imshow("灰度图像", gray);

	// 【3】先用使用 3x3内核来降噪   
	blur(gray, edge, Size(3, 3));

	imshow("降噪", edge);

	// 【4】运行Canny算子  
	Canny(edge, edge, 3, 9, 3);

	imshow("canny算子", edge);

	//【5】将g_dstImage内的所有元素设置为0    
	dst = Scalar::all(0);

	//【6】使用Canny算子输出的边缘图g_cannyDetectedEdges作为掩码，来将原图g_srcImage拷到目标图g_dstImage中   
	src1.copyTo(dst, edge);

	//【7】显示效果图    
	imshow("【效果图】Canny边缘检测2", dst);

	/* canny边缘检测 END */


	/* 调用Sobel函数的实例代码 */
	//【0】创建 grad_x 和 grad_y 矩阵   
	Mat grad_x, grad_y;
	Mat abs_grad_x, abs_grad_y;

	//【2】显示原始图    
	imshow("【原始图】sobel边缘检测", src);

	//【3】求 X方向梯度   
	Sobel(src, grad_x, CV_16S, 1, 0, 3, 1, 1, BORDER_DEFAULT);
	convertScaleAbs(grad_x, abs_grad_x);
	imshow("【效果图】 X方向Sobel", abs_grad_x);

	//【4】求Y方向梯度   
	Sobel(src, grad_y, CV_16S, 0, 1, 3, 1, 1, BORDER_DEFAULT);
	convertScaleAbs(grad_y, abs_grad_y);
	imshow("【效果图】Y方向Sobel", abs_grad_y);

	//【5】合并梯度(近似)   
	addWeighted(abs_grad_x, 0.5, abs_grad_y, 0.5, 0, dst);
	imshow("【效果图】整体方向Sobel", dst);


	waitKey(6000000);
}

//改变图像大小
void test02() {
	//载入原始图     
	Mat srcImage = imread("E:\\1.jpg");  //工程目录下应该有一张名为1.jpg的素材图  
	Mat tmpImage, dstImage1, dstImage2;//临时变量和目标图的定义  
	tmpImage = srcImage;//将原始图赋给临时变量  

						//显示原始图    
	imshow("【原始图】", srcImage);

	//进行尺寸调整操作  
	resize(tmpImage, dstImage1, Size(tmpImage.cols / 2, tmpImage.rows / 2), (0, 0), (0, 0), 3);
	resize(tmpImage, dstImage2, Size(tmpImage.cols * 2, tmpImage.rows * 2), (0, 0), (0, 0), 3);

	//显示效果图    
	imshow("【效果图】之一", dstImage1);
	imshow("【效果图】之二", dstImage2);

	waitKey(1000000);
}
//pyrUP函数示例
void test03() {
	//载入原始图     
	Mat srcImage = imread("E:\\1.jpg");  //工程目录下应该有一张名为1.jpg的素材图  
	Mat tmpImage, dstImage;//临时变量和目标图的定义  
	tmpImage = srcImage;//将原始图赋给临时变量  

						//显示原始图    
	imshow("【原始图】", srcImage);
	//进行向上取样操作  
	pyrUp(tmpImage, dstImage, Size(tmpImage.cols * 2, tmpImage.rows * 2));
	//显示效果图    
	imshow("【效果图】", dstImage);

	waitKey(99999990);
}

//
void test04() {
	Mat srcImage = imread("E:\\2.jpg");
	imshow("原始图", srcImage);
	waitKey(99999990);
}

int main() {
	Mat srcImage = imread("E:\\1.jpg");
	imshow("【原始图】", srcImage);
	//colorSplit(srcImage);

	return 0;
}