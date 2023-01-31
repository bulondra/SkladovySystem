using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace SkladovySystem
{
    public partial class Form1 : Form
    {

        DbManager dbManager;
        public Form1()
        {
            InitializeComponent();
            dbManager = new DbManager(this);
            dbManager.init();
            dbManager.connect();
        }

        string endCode = "939393353535";

        StringBuilder sb = new StringBuilder();
        string currentCode = "";

        string loggedWorkerUID = "";

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            int key = e.KeyValue;
            if (key == 13)
            {
                currentCode = sb.ToString();
                sb = new StringBuilder();
                textBox1.Text = currentCode;

                if (currentCode.Equals(endCode))
                {
                    
                    return;
                }

                if (!currentCode.Contains("UID"))
                {
                    if (isAuthorized())
                    {
                        if (dbManager.isOrder(currentCode))
                        {
                            Order order = dbManager.getOrder(currentCode);
                            if (orderLabel.Text.Equals("ŽÁDNÁ")) selectOrder(order);
                            else deselectOrder();
                        }
                        else if (dbManager.isProduct(currentCode))
                        {
                            Stock product = dbManager.getProduct(currentCode);
                            if (productLabel.Text.Equals("ŽÁDNÝ")) selectProduct(product);
                            else deselectProduct();
                            Debug.WriteLine(product != null ? "Produkt: " + product.name + ", skladem: " + product.quantity : "Produkt nenalezen v databazi");
                        }
                        else
                        {
                            if (!orderLabel.Text.Equals("ŽÁDNÁ") && !productLabel.Text.Equals("ŽÁDNÝ"))
                            {
                                if (currentCode.Equals("")) // ukončit aktuální produkt
                                {
                                    deselectProduct();
                                }
                                else
                                {
                                    int count = 0;
                                    int.TryParse(currentCode, out count);

                                    if (count > 0)
                                    {
                                        string orderCode = orderLabel.Text;
                                        Stock product = new Stock();
                                        product.name = productNameLabel.Text;
                                        product.quantity = int.Parse(productQuantityLabel.Text);
                                        dbManager.updateOrderProduct(orderCode, product);
                                    }
                                    else
                                    {
                                        deselectProduct();
                                    }
                                }
                            }
                            else if (!orderLabel.Text.Equals("ŽÁDNÁ") && productLabel.Text.Equals("ŽÁDNÝ"))
                            {
                                if (currentCode.Equals("")) // ukončit aktuální produkt
                                {
                                    deselectOrder();
                                }
                            } else if (orderLabel.Text.Equals("ŽÁDNÁ") && productLabel.Text.Equals("ŽÁDNÝ"))
                            {
                                if (currentCode.Equals(""))
                                {
                                    logOut();
                                }
                            }
                        }
                    }
                } else
                {
                    authorizeUser(currentCode);
                }

                textBox1.Text = "";

                return;
            }
            
            char value = (char)e.KeyValue;

            sb.Append(value);

            return;
        }

        public void authorizeUser(string code)
        {
            string UID = code.Replace("UIDº ", "").Replace(System.Environment.NewLine, "");

            Worker worker = dbManager.getWorker(UID);
            if (worker == null)
            {
                Debug.WriteLine("Pracovník nenalezen!");
                return;
            }

            if (loggedWorkerUID.Equals(""))
            {
                workerLabel.Text = worker.name;
                loggedWorkerUID = worker.name;
                startedLabel.Text = DateTime.Now.ToString("HH:mm:ss dd.MM.yyyy");
                Debug.WriteLine("Přihlášen: " + worker.name);
            } else
            {
                if (loggedWorkerUID.Equals(worker.uid))
                {
                    loggedWorkerUID = "";
                    workerLabel.Text = "NIKDO";
                    Debug.WriteLine("Odhlášen: " + worker.name);
                    orderLabel.Text = "ŽÁDNÁ";
                    customerLabel.Text = "ŽÁDNÝ";
                    addressLabel.Text = "ŽÁDNÁ";
                    remainingProductsList.Items.Clear();
                    doneProductsList.Items.Clear();
                    productLabel.Text = "ŽÁDNÝ";
                    productNameLabel.Text = "ŽÁDNÝ";
                    productQuantityLabel.Text = "ŽÁDNÝ";
                    startedLabel.Text = "ŽÁDNÝ";
                }
            }
        }

        public void logOut()
        {
            loggedWorkerUID = "";
            Debug.WriteLine("Odhlášen: " + workerLabel.Text);
            workerLabel.Text = "NIKDO";
            orderLabel.Text = "ŽÁDNÁ";
            customerLabel.Text = "ŽÁDNÝ";
            addressLabel.Text = "ŽÁDNÁ";
            remainingProductsList.Items.Clear();
            doneProductsList.Items.Clear();
            productLabel.Text = "ŽÁDNÝ";
            productNameLabel.Text = "ŽÁDNÝ";
            productQuantityLabel.Text = "ŽÁDNÝ";
            startedLabel.Text = "ŽÁDNÝ";
        }

        public bool isAuthorized()
        {
            return (!loggedWorkerUID.Equals(""));
        }

        public void selectOrder(Order order)
        {
            if (order == null) return;
            orderLabel.Text = order.code + "";
            customerLabel.Text = order.surname + " " + order.vorname;
            addressLabel.Text = order.street + ", " + order.city + ", " + order.country;
            remainingProductsList.Items.Clear();
            doneProductsList.Items.Clear();
            foreach (Stock product in order.neededProducts)
            {
                remainingProductsList.Items.Add(product.quantity + "x " + product.name);
            }

            foreach (Stock product in order.doneProducts)
            {
                doneProductsList.Items.Add(product.quantity + "x " + product.name);
            }
        }

        public void deselectOrder()
        {
            orderLabel.Text = "ŽÁDNÁ";
            customerLabel.Text = "ŽÁDNÝ";
            addressLabel.Text = "ŽÁDNÁ";
            remainingProductsList.Items.Clear();
            doneProductsList.Items.Clear();
        }

        public void deselectProduct()
        {
            productLabel.Text = "ŽÁDNÝ";
            productNameLabel.Text = "ŽÁDNÝ";
            productQuantityLabel.Text = "ŽÁDNÝ";
        }

        public void selectProduct(Stock product)
        {
            if (product == null) return;
            productLabel.Text = product.code;
            productNameLabel.Text = product.name;
            productQuantityLabel.Text = product.quantity + "";
        }
    }
}
