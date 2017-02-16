using System;
using System.Collections.Generic;
using System.Net.Mime;
using Demo.model;

namespace Demo.ibusiness
{
    public interface IFileManage
    {
        
        void setTextFilePath(String path);
        void setTextFileText(String text);
        void setTextName(String name);
        String getTextName();
        String getTextFileText();
        String getTextFilePath();


        void addImgItem(ImgFileMsg item);
        List<ImgFileMsg> getImgFileList();
        int getImgCount();
    }
}