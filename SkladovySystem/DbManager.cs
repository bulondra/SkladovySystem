using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkladovySystem
{
    class DbManager
    {
        private Form1 instance;
        public DbManager(Form1 instance)
        {
            this.instance = instance;
        }

        string cs = @"URI=file:C:\Users\bulka.ondrej3\source\repos\SkladovySystem\SkladovySystem\sklad.db";
        SQLiteConnection con;

        public void init()
        {
            con = new SQLiteConnection(cs);
        }

        public void connect()
        {
            con.Open();
        }


        public Worker getWorker(string uid)
        {
            Worker worker = null;
            string stm = "SELECT * FROM workers WHERE uid='" + uid + "';";

            var cmd = new SQLiteCommand(stm, con);
            SQLiteDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                worker = new Worker();
                worker.id = rdr.GetInt32(0);
                worker.name = rdr.GetString(2);
                worker.uid = rdr.GetString(1);
            }

            return worker;
        }

        public bool isProduct(string code)
        {
            bool result = false;
            string stm = "SELECT * FROM products WHERE code = '" + code + "';";

            var cmd = new SQLiteCommand(stm, con);
            SQLiteDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read()) result = true;

            return result;
        }

        public bool isOrder(string code)
        {
            bool result = false;
            string stm = "SELECT * FROM orders WHERE orders.code = '" + code + "';";

            var cmd = new SQLiteCommand(stm, con);
            SQLiteDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read()) result = true;

            return result;
        }

        public Stock getProduct(string code)
        {
            Stock product = null;
            string stm = "SELECT * FROM stock INNER JOIN products ON stock.product_id = products.id WHERE products.code = '" + code + "';";

            var cmd = new SQLiteCommand(stm, con);
            SQLiteDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                product = new Stock();
                product.id = rdr.GetInt32(0);
                product.name = rdr.GetString(5);
                product.code = rdr.GetString(4);
                product.quantity = rdr.GetInt32(2);
            }

            return product;
        }

        public void updateOrderProduct(string orderCode, Stock product)
        {
            //string stm = "UPDATE order_products SET ";
            //var cmd = new SQLiteCommand(stm, con);
            //cmd.ExecuteNonQuery();
        }


        public Order getOrder(string code)
        {
            Order order = null;
            List<Stock> neededProducts = new List<Stock>();
            List<Stock> doneProducts = new List<Stock>();
            string stm = "SELECT * FROM order_products INNER JOIN orders ON order_products.order_id = orders.id INNER JOIN addresses ON orders.address_id = addresses.id INNER JOIN workers ON order_products.worker_id = workers.id INNER JOIN users ON orders.user_id = users.id INNER JOIN products ON order_products.product_id = products.id WHERE orders.code = '" + code + "';";

            var cmd = new SQLiteCommand(stm, con);
            SQLiteDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                order = new Order();
                order.id = rdr.GetInt32(1);
                order.vorname = rdr.GetString(19);
                order.surname = rdr.GetString(20);
                order.worker = rdr.GetString(17);
                order.code = rdr.GetString(9);
                order.street = rdr.GetString(12);
                order.city = rdr.GetString(13);
                order.country = rdr.GetString(14);

                Stock product = new Stock();
                product.id = rdr.GetInt32(22);
                product.name = rdr.GetString(24);
                product.code = rdr.GetString(23);
                product.quantity = rdr.GetInt32(4);
                if (rdr.GetInt32(5) == 0) neededProducts.Add(product);
                else doneProducts.Add(product);

                while (rdr.Read())
                {
                    product = new Stock();
                    product.id = rdr.GetInt32(22);
                    product.name = rdr.GetString(24);
                    product.code = rdr.GetString(23);
                    product.quantity = rdr.GetInt32(4);
                    if (rdr.GetInt32(5) == 0) neededProducts.Add(product);
                    else doneProducts.Add(product);
                }
                order.doneProducts = doneProducts;
                order.neededProducts = neededProducts;
                //product.quantity = rdr.GetInt32(2);
            }

            return order;
        }

        public string getName(string uid)
        {
            string result = null;
            string stm = "SELECT * FROM workers WHERE uid='" + uid + "';";

            var cmd = new SQLiteCommand(stm, con);
            SQLiteDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                result = rdr.GetString(2);
            }

            return result;
        }

    }
}
