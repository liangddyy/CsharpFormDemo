using System;
using System.Collections.Generic;
using System.Text;
using model;
namespace IDAL
{
    public interface IUser
    {
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user">用户类</param>
        /// <returns></returns>
        int insertUser(UserData user);
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="user">用户类</param>
        /// <returns></returns>
        int delUser(UserData user);
        /// <summary>
        /// 更新用户
        /// </summary>
        /// <param name="user">用户类</param>
        /// <returns></returns>
        int updateUser(UserData user);
        /// <summary>
        /// 查询用户
        /// </summary>
        /// <param name="user">用户类</param>
        /// <returns>返回用户类的集合</returns>
        List<UserData> selUser();
        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="user">用户类</param>
        /// <returns>返回用户</returns>
        UserData logicUser(UserData user);
    }
}
