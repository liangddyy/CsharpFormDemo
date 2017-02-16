using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01订单.订单管理
{
    class Order
    {
        
        public String getCmdInsertOrder(String idGoods, String idUser, String amount)
        {
            //return "insert into order1(goodsNum,amount,userNum)values('" + idGoods + "','" + amount + "','" + idUser + "')";
            return "insert into order1(goodsNum,amount,userNum)values('" + idGoods +
                   "','" + amount + "','" + idUser + "');";
        }
        public String getCmdAllOrder()
        {
            return "SELECT order1.id,goods.name,goods.price,order1.amount,user1.name FROM order1,goods,user1 where order1.goodsNum=goods.id and order1.userNum=user1.id";
        }

        public String getCmdPrice(String id)
        {
            return "select price from goods where id = '" + id + "'";
        }
    }
}
