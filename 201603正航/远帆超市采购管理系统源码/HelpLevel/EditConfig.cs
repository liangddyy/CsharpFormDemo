using System;
using System.Configuration;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.Text;

namespace HelpLevel
{
    public class EditConfig
    {

        

        /// <summary>
        /// 提取连接配置(ConnectionStrings)信息
        /// </summary>
        /// <param name="name">连接名字</param>
        /// <returns></returns>
        public static string ReadConnectionString()
        {
            ConnectionStringSettings css = ConfigurationManager.ConnectionStrings["SqlConn"];
            if (css == null)
                throw new ArgumentException("不存在这样的节点");
            return css.ConnectionString;
        }
        /// <summary>
        /// 保存连接字符串
        /// </summary>
        /// <param name="path">配置文件的完成路径</param>
        /// <param name="name">节点名称</param>
        /// <param name="value">节点值</param>
        /// <param name="exist">如果不存在是否创建</param>
        /// <returns>保存是否成功</returns>
        public static bool WriteConnectionString(string path, string name, string value, bool exist)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(path);

                if (!fileInfo.Exists)
                    throw new ArgumentException("没有找到配置文件");

                //保存记录总数信息
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(path);

                XmlNode xNode;
                XmlElement xElem;
                XmlElement xElemNew;

                xNode = xDoc.SelectSingleNode("//connectionStrings");

                xElem = (XmlElement)xNode.SelectSingleNode("//add[@name='" + name + "']");
                if (xElem != null)
                    xElem.SetAttribute("connectionString", value);
                else if (!exist)
                    throw new ArgumentException("节点错误,保存失败");
                else
                {
                    xElemNew = xDoc.CreateElement("add");
                    xElemNew.SetAttribute("name", name);
                    xElemNew.SetAttribute("connectionString", value);
                    xNode.AppendChild(xElemNew);
                }
                xDoc.Save(path);
                return true;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        /// <summary>
        /// 保存配置文件信息
        /// </summary>
        /// <param name="path">配置文件完成路径</param>
        /// <param name="key">键值</param>
        /// <param name="value">保存值</param>
        /// <param name="exist">如果键值不存在是否创建</param>
        /// <returns>保存是否成功</returns>
        public static bool WriteAppSettings(string path, string key, string value, bool exist)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(path);

                if (!fileInfo.Exists)
                    throw new ArgumentException("没有找到配置文件");

                //保存记录总数信息
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(path);

                XmlNode xNode;
                XmlElement xElem;
                XmlElement xElemNew;

                xNode = xDoc.SelectSingleNode("//appSettings");

                xElem = (XmlElement)xNode.SelectSingleNode("//add[@key='" + key + "']");
                if (xElem != null)
                    xElem.SetAttribute("value", value);
                else if (!exist)
                    throw new ArgumentException("节点错误,保存失败");
                else
                {
                    xElemNew = xDoc.CreateElement("add");
                    xElemNew.SetAttribute("key", key);
                    xElemNew.SetAttribute("value", value);
                    xNode.AppendChild(xElemNew);
                }
                xDoc.Save(path);
                return true;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
