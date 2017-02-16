using System;
using System.Collections.Generic;
using System.Text;
using model;


namespace SQLServerDAL
{
    public class User:IDAL.IUser
    {
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user">用户类</param>
        /// <returns></returns>
        public int insertUser(UserData user)
        {
            return 0;
        }
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="user">用户类</param>
        /// <returns></returns>
        public int delUser(UserData user)
        {
            return 0;
        }
        /// <summary>
        /// 更新用户
        /// </summary>
        /// <param name="user">用户类</param>
        /// <returns></returns>
        public int updateUser(UserData user)
        {
            return 0;
        }
        /// <summary>
        /// 查询用户
        /// </summary>
        /// <param name="user">用户类</param>
        /// <returns>返回用户类的集合</returns>
        public List<UserData> selUser(UserData user)
        {
            return new List<UserData>();
        }
        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="user">用户类</param>
        /// <returns>返回真为验证成功，否则失败</returns>
        public bool logicUser(UserData user)
        {
            return true;
        }
    }
}
