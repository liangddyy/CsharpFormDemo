using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using _01订单.其他;
using _01订单.数据库;
using _01订单.订单管理;

namespace _01订单
{
    public partial class OrderAdd : Form
    {
        private Opreate op = new Opreate();
        private Order od=new Order();
        public OrderAdd()
        {
            InitializeComponent();
        }

        
        private void OrderAdd_Load(object sender, EventArgs e)
        {
            this.Text = MenuManager.getNameAddOrder();    
            loadGridView();
            loadCombox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String idGoods = (comboBox1.Text.ToString()).Split('-')[0];
            String idUser = (comboBox2.Text.ToString()).Split('-')[0];
            String amount = textBox1.Text.ToString();
            if (idGoods == "" || idUser == "" || amount == "")
            {
                MessageBox.Show("商品、客户、订购数量不能为空！！！");
                return;
            }
            

            if(op.OPSQL(od.getCmdInsertOrder(idGoods, idUser, amount)))
                MessageBox.Show("添加成功");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //获取一些客户信息 显示
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = (comboBox1.Text.ToString()).Split('-')[0];
            label3.Text = "单价：" + op.FiledValue(od.getCmdPrice(id));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadGridView();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public void loadGridView()
        {
            DataTable dt = op.GetDataTable(od.getCmdAllOrder(), "order1");
            dataGridView1.DataSource = dt;

            /* 不可直接修改表信息 */
            dataGridView1.Columns[0].HeaderText = "订单号";
            dataGridView1.Columns[1].HeaderText = "商品";
            dataGridView1.Columns[2].HeaderText = "单价";
            dataGridView1.Columns[3].HeaderText = "数量";
            dataGridView1.Columns[4].HeaderText = "客户";
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
        }

        public void loadCombox()
        {
            //初始化添加订单部分 combobox
            List<string> goodsList = op.getGoodsNumName();
            comboBox1.Items.Clear();
            for (int i = 0; i < goodsList.Count; i++)
            {
                comboBox1.Items.Add(goodsList[i]);
            }
            List<string> userList = op.getUserNumName();
            comboBox2.Items.Clear();
            for (int i = 0; i < userList.Count; i++)
            {
                comboBox2.Items.Add(userList[i]);
            }
        }
    }
}
