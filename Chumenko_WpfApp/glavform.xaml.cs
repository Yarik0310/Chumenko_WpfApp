using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace WpfApp
{
    /// <summary>
    /// Логика взаимодействия для glavform.xaml
    /// </summary>
    public partial class glavform : Window
    {
        XDocument doc1;
        XDocument doc2;
        XDocument doc3;

        public ObservableCollection<object> CLIENTSCollection;
        public ObservableCollection<object> DEALSCollection;
        public ObservableCollection<object> YSLYGICollection;

        private int counter = 0;
        private bool yesno = false;
        public glavform()
        {
            InitializeComponent();
        }

        private void dg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void MenuItem1_Click(object sender, RoutedEventArgs e)
        {
            dg.Visibility = Visibility.Visible;
            notif.Visibility = Visibility.Hidden;
            dobavlenie1.Visibility = Visibility.Visible;
            dobavlenie2.Visibility = Visibility.Visible;
            dobavlenie3.Visibility = Visibility.Visible;
            dobavlenie4.Visibility = Visibility.Visible;
            dobavlenie5.Visibility = Visibility.Visible;
            dobavlenie6.Visibility = Visibility.Hidden;
            Clients.Visibility = Visibility.Visible;
            Deals.Visibility = Visibility.Hidden;
            Yslygi.Visibility = Visibility.Hidden;

            counter = 1;
            doc1 = XDocument.Load("C:\\Users\\Akell\\OneDrive\\Desktop\\Chumenko_WpfApp\\Клиенты.xml");
            var CLIENTS = (from x in doc1.Element("Clients").Elements("Client")
                           orderby x.Element("IdC").Value
                           select new
                           {
                               Код = x.Element("KodCL").Value,
                               Фамилия = x.Element("Surename").Value,
                               Имя = x.Element("Name").Value,
                               Отчество = x.Element("Thname").Value,
                               Номарпаспорта = x.Element("numpassport").Value,
                               Серияпаспорта = x.Element("serpassport").Value,
                               Датавыдачипаспорта = x.Element("date").Value

                           }).ToList();

            var CLIENTSCollection = new ObservableCollection<object>(CLIENTS);
            dg.ItemsSource = CLIENTSCollection;
        }
        private void MenuItem2_Click(object sender, RoutedEventArgs e)
        {
            dg.Visibility = Visibility.Visible;
            notif.Visibility = Visibility.Hidden;
            dobavlenie1.Visibility = Visibility.Visible;
            dobavlenie2.Visibility = Visibility.Visible;
            dobavlenie3.Visibility = Visibility.Visible;
            dobavlenie4.Visibility = Visibility.Visible;
            dobavlenie5.Visibility = Visibility.Visible;
            dobavlenie6.Visibility = Visibility.Visible;
            Clients.Visibility = Visibility.Hidden;
            Deals.Visibility = Visibility.Visible;
            Yslygi.Visibility = Visibility.Hidden;

            counter = 2;
            doc2 = XDocument.Load("C:\\Users\\Akell\\OneDrive\\Desktop\\Chumenko_WpfApp\\Категории товаров.xml");
            var DEALS = (from x in doc2.Element("Deals").Elements("Deal")
                         orderby x.Element("IdD").Value
                         select new
                         {
                             Код = x.Element("kodC").Value,
                             Название = x.Element("Name").Value,
                             Примечаание = x.Element("Add").Value

                         }).ToList();

            var DEALSCollection = new ObservableCollection<object>(DEALS);
            dg.ItemsSource = DEALSCollection;
        }
        private void MenuItem3_Click(object sender, RoutedEventArgs e)
        {
            dg.Visibility = Visibility.Visible;
            notif.Visibility = Visibility.Hidden;
            dobavlenie1.Visibility = Visibility.Visible;
            dobavlenie2.Visibility = Visibility.Visible;
            dobavlenie3.Visibility = Visibility.Visible;
            dobavlenie4.Visibility = Visibility.Hidden;
            dobavlenie5.Visibility = Visibility.Hidden;
            dobavlenie6.Visibility = Visibility.Hidden;
            Clients.Visibility = Visibility.Hidden;
            Deals.Visibility = Visibility.Hidden;
            Yslygi.Visibility = Visibility.Visible;

            counter = 3;
            doc3 = XDocument.Load("C:\\Users\\Akell\\OneDrive\\Desktop\\Chumenko_WpfApp\\Сдача в ломбард .xml");
            var YSLYGI = (from x in doc3.Element("Yslygi").Elements("Yslyga")
                          orderby x.Element("IdY").Value
                          select new
                          {
                              Код = x.Element("kodD").Value,
                              Код_товара = x.Element("kodC").Value,
                              Код_клиента = x.Element("KodCL").Value,
                              Описание = x.Element("Description").Value,
                              Дата_сдачи = x.Element("EntDate").Value,
                              Дата_выдачи = x.Element("EntDate").Value,
                              Сумма = x.Element("Sum").Value,
                              Комиссионные = x.Element("Comis").Value

                          }).ToList();

            var YSLYGICollection = new ObservableCollection<object>(YSLYGI);
            dg.ItemsSource = YSLYGICollection;
        }
        private void MenuItem4_Click(object sender, RoutedEventArgs e)
        {
            dg.Visibility = Visibility.Visible;
            notif.Visibility = Visibility.Hidden;
            dobavlenie1.Visibility = Visibility.Hidden;
            dobavlenie2.Visibility = Visibility.Hidden;
            dobavlenie3.Visibility = Visibility.Hidden;
            dobavlenie4.Visibility = Visibility.Hidden;
            dobavlenie5.Visibility = Visibility.Hidden;
            dobavlenie6.Visibility = Visibility.Hidden;
            Clients.Visibility = Visibility.Hidden;
            Deals.Visibility = Visibility.Hidden;
            Yslygi.Visibility = Visibility.Hidden;
            dobav.Visibility = Visibility.Hidden;
            red.Visibility = Visibility.Hidden;
            del.Visibility = Visibility.Hidden;
            poisk.Visibility = Visibility.Hidden;
            dopgc.Visibility = Visibility.Hidden;
            skidka.Visibility = Visibility.Visible;

            counter = 4;
            doc2 = XDocument.Load("D:\\МИРЭА\\Верстка\\3 семестр\\Оконное прилож\\WPF\\WpfApp\\WpfApp\\deals.xml");
            var DEALS = (from x in doc2.Element("Deals").Elements("Deal")
                         orderby x.Element("IdD").Value
                         select new
                         {
                             Сделка = x.Element("IdD").Value,
                             Клиент = x.Element("IdC").Value,
                             Услуга = x.Element("IdY").Value,
                             Сумма = x.Element("Sum").Value,
                             Комиссионные = x.Element("Comis").Value,
                             Описание = x.Element("About").Value

                         }).ToList();

            var DEALSCollection = new ObservableCollection<object>(DEALS);
            dg.ItemsSource = DEALSCollection;
        }
            private void MenuItemDobav_Click(object sender, RoutedEventArgs e)
        {
            dobav.Visibility = Visibility.Visible;
            red.Visibility = Visibility.Hidden;
            del.Visibility = Visibility.Hidden;
            poisk.Visibility = Visibility.Hidden;
            dopgc.Visibility = Visibility.Hidden;
            skidka.Visibility = Visibility.Hidden;
        }
        private void MenuItemRed_Click(object sender, RoutedEventArgs e)
        {
            dobav.Visibility = Visibility.Hidden;
            red.Visibility = Visibility.Visible;
            del.Visibility = Visibility.Hidden;
            poisk.Visibility = Visibility.Hidden;
            dopgc.Visibility = Visibility.Hidden;
            skidka.Visibility = Visibility.Hidden;

        }
        private void MenuItemDel_Click(object sender, RoutedEventArgs e)
        {
            dobav.Visibility = Visibility.Hidden;
            red.Visibility = Visibility.Hidden;
            del.Visibility = Visibility.Visible;
            poisk.Visibility = Visibility.Hidden;
            dopgc.Visibility = Visibility.Hidden;
            skidka.Visibility = Visibility.Hidden;

        }
        private void MenuItemPoisk_Click(object sender, RoutedEventArgs e)
        {
            dobav.Visibility = Visibility.Hidden;
            red.Visibility = Visibility.Hidden;
            del.Visibility = Visibility.Hidden;
            poisk.Visibility = Visibility.Visible;
            dopgc.Visibility = Visibility.Hidden;
            skidka.Visibility = Visibility.Hidden;

        }
        private void MenuItemDop_Click(object sender, RoutedEventArgs e)
        {
            dobav.Visibility = Visibility.Hidden;
            red.Visibility = Visibility.Hidden;
            del.Visibility = Visibility.Hidden;
            poisk.Visibility = Visibility.Hidden;
            dopgc.Visibility = Visibility.Visible;
            skidka.Visibility = Visibility.Hidden;
        }
        private void buttondobav_Click(object sender, RoutedEventArgs e)
        {
            if (counter == 1)
            {
                doc1.Element("Clients").Add(new XElement("Client",
                new XElement("IdC", dobavlenie1.Text),
                new XElement("Name", dobavlenie2.Text),
                new XElement("Type", dobavlenie3.Text),
                new XElement("Address", dobavlenie4.Text),
                new XElement("Number", dobavlenie5.Text)));

                doc1.Save("D:\\МИРЭА\\Верстка\\3 семестр\\Оконное прилож\\WPF\\WpfApp\\WpfApp\\clients.xml");

                MessageBox.Show("Данные добавлены!");

                var CLIENTS = (from x in doc1.Element("Clients").Elements("Client")
                               orderby x.Element("IdC").Value
                               select new
                               {
                                   Клиент = x.Element("IdC").Value,
                                   Название = x.Element("Name").Value,
                                   Деятельность = x.Element("Type").Value,
                                   Адрес = x.Element("Address").Value,
                                   Телефон = x.Element("Number").Value

                               }).ToList();

                var CLIENTSCollection = new ObservableCollection<object>(CLIENTS);
                dg.ItemsSource = CLIENTSCollection;

                dobavlenie1.Clear();
                dobavlenie2.Clear();
                dobavlenie3.Clear();
                dobavlenie4.Clear();
                dobavlenie5.Clear();
                dobavlenie6.Clear();
            }

            if (counter == 2)
            {
                doc2.Element("Deals").Add(new XElement("Deal",
                new XElement("IdD", dobavlenie1.Text),
                new XElement("IdC", dobavlenie2.Text),
                new XElement("IdY", dobavlenie3.Text),
                new XElement("Sum", dobavlenie4.Text),
                new XElement("Comis", dobavlenie5.Text),
                new XElement("About", dobavlenie6.Text)));

                doc2.Save("D:\\МИРЭА\\Верстка\\3 семестр\\Оконное прилож\\WPF\\WpfApp\\WpfApp\\deals.xml");

                MessageBox.Show("Данные добавлены!");

                var DEALS = (from x in doc2.Element("Deals").Elements("Deal")
                             orderby x.Element("IdD").Value
                             select new
                             {
                                 Сделка = x.Element("IdD").Value,
                                 Клиент = x.Element("IdC").Value,
                                 Услуга = x.Element("IdY").Value,
                                 Сумма = x.Element("Sum").Value,
                                 Комиссионные = x.Element("Comis").Value,
                                 Описание = x.Element("About").Value

                             }).ToList();

                var DEALSCollection = new ObservableCollection<object>(DEALS);
                dg.ItemsSource = DEALSCollection;

                dobavlenie1.Clear();
                dobavlenie2.Clear();
                dobavlenie3.Clear();
                dobavlenie4.Clear();
                dobavlenie5.Clear();
                dobavlenie6.Clear();
            }

            if (counter == 3)
            {
                doc3.Element("Yslygi").Add(new XElement("Yslyga",
                new XElement("IdY", dobavlenie1.Text),
                new XElement("Name", dobavlenie2.Text),
                new XElement("About", dobavlenie3.Text)));

                doc3.Save("D:\\МИРЭА\\Верстка\\3 семестр\\Оконное прилож\\WPF\\WpfApp\\WpfApp\\yslygi.xml");

                MessageBox.Show("Данные добавлены!");

                var YSLYGI = (from x in doc3.Element("Yslygi").Elements("Yslyga")
                              orderby x.Element("IdY").Value
                              select new
                              {
                                  Услуга = x.Element("IdY").Value,
                                  Название = x.Element("Name").Value,
                                  Описание = x.Element("About").Value

                              }).ToList();

                var YSLYGICollection = new ObservableCollection<object>(YSLYGI);
                dg.ItemsSource = YSLYGICollection;

                dobavlenie1.Clear();
                dobavlenie2.Clear();
                dobavlenie3.Clear();
                dobavlenie4.Clear();
                dobavlenie5.Clear();
                dobavlenie6.Clear();
            }

        }
        private void buttonred_Click(object sender, RoutedEventArgs e)
        {
            if (counter == 1)
            {
                IEnumerable<XElement> tests =
                    from el in doc1.Elements("Clients").Elements("Client")
                    where (string)el.Element("IdC") == dobavlenie1.Text
                    select el;
                foreach (XElement el in tests)
                    yesno = true;
                if (yesno == true)
                {
                    doc1.Elements("Clients").Elements("Client").First(b => ((string)b.Element("IdC")) == dobavlenie1.Text).SetElementValue("Name", dobavlenie2.Text);
                    doc1.Elements("Clients").Elements("Client").First(b => ((string)b.Element("IdC")) == dobavlenie1.Text).SetElementValue("Type", dobavlenie3.Text);
                    doc1.Elements("Clients").Elements("Client").First(b => ((string)b.Element("IdC")) == dobavlenie1.Text).SetElementValue("Address", dobavlenie4.Text);
                    doc1.Elements("Clients").Elements("Client").First(b => ((string)b.Element("IdC")) == dobavlenie1.Text).SetElementValue("Number", dobavlenie5.Text);

                    doc1.Save("D:\\МИРЭА\\Верстка\\3 семестр\\Оконное прилож\\WPF\\WpfApp\\WpfApp\\clients.xml");

                    var CLIENTS = (from x in doc1.Element("Clients").Elements("Client")
                                   orderby x.Element("IdC").Value
                                   select new
                                   {
                                       Клиент = x.Element("IdC").Value,
                                       Название = x.Element("Name").Value,
                                       Деятельность = x.Element("Type").Value,
                                       Адрес = x.Element("Address").Value,
                                       Телефон = x.Element("Number").Value

                                   }).ToList();

                    var CLIENTSCollection = new ObservableCollection<object>(CLIENTS);
                    dg.ItemsSource = CLIENTSCollection;

                    MessageBox.Show("Изменения сохранены!");
                    yesno = false;
                }
                else
                {
                    MessageBox.Show("Ошибка");
                }
                dobavlenie1.Clear();
                dobavlenie2.Clear();
                dobavlenie3.Clear();
                dobavlenie4.Clear();
                dobavlenie5.Clear();
                dobavlenie6.Clear();
            }
            if (counter == 2)
            {
                IEnumerable<XElement> tests =
                   from el in doc2.Elements("Deals").Elements("Deal")
                   where (string)el.Element("IdD") == dobavlenie1.Text
                   select el;
                foreach (XElement el in tests)
                    yesno = true;
                if (yesno == true)
                {
                    doc2.Elements("Deals").Elements("Deal").First(b => ((string)b.Element("IdD")) == dobavlenie1.Text).SetElementValue("IdC", dobavlenie2.Text);
                    doc2.Elements("Deals").Elements("Deal").First(b => ((string)b.Element("IdD")) == dobavlenie1.Text).SetElementValue("IdY", dobavlenie3.Text);
                    doc2.Elements("Deals").Elements("Deal").First(b => ((string)b.Element("IdD")) == dobavlenie1.Text).SetElementValue("Sum", dobavlenie4.Text);
                    doc2.Elements("Deals").Elements("Deal").First(b => ((string)b.Element("IdD")) == dobavlenie1.Text).SetElementValue("Comis", dobavlenie5.Text);
                    doc2.Elements("Deals").Elements("Deal").First(b => ((string)b.Element("IdD")) == dobavlenie1.Text).SetElementValue("About", dobavlenie6.Text);

                    doc2.Save("D:\\МИРЭА\\Верстка\\3 семестр\\Оконное прилож\\WPF\\WpfApp\\WpfApp\\deals.xml");

                    var DEALS = (from x in doc2.Element("Deals").Elements("Deal")
                                 orderby x.Element("IdD").Value
                                 select new
                                 {
                                     Сделка = x.Element("IdD").Value,
                                     Клиент = x.Element("IdC").Value,
                                     Услуга = x.Element("IdY").Value,
                                     Сумма = x.Element("Sum").Value,
                                     Комиссионные = x.Element("Comis").Value,
                                     Описание = x.Element("About").Value

                                 }).ToList();

                    var DEALSCollection = new ObservableCollection<object>(DEALS);
                    dg.ItemsSource = DEALSCollection;

                    MessageBox.Show("Изменения сохранены!");
                    yesno = false;
                }
                else
                {
                    MessageBox.Show("Ошибка");
                }
                dobavlenie1.Clear();
                dobavlenie2.Clear();
                dobavlenie3.Clear();
                dobavlenie4.Clear();
                dobavlenie5.Clear();
                dobavlenie6.Clear();
            }
            if (counter == 3)
            {
                IEnumerable<XElement> tests =
                   from el in doc3.Elements("Yslygi").Elements("Yslyga")
                   where (string)el.Element("IdY") == dobavlenie1.Text
                   select el;
                foreach (XElement el in tests)
                    yesno = true;
                if (yesno == true)
                {
                    doc3.Elements("Yslygi").Elements("Yslyga").First(b => ((string)b.Element("IdY")) == dobavlenie1.Text).SetElementValue("Name", dobavlenie2.Text);
                    doc3.Elements("Yslygi").Elements("Yslyga").First(b => ((string)b.Element("IdY")) == dobavlenie1.Text).SetElementValue("About", dobavlenie3.Text);

                    doc3.Save("D:\\МИРЭА\\Верстка\\3 семестр\\Оконное прилож\\WPF\\WpfApp\\WpfApp\\yslygi.xml");

                    var YSLYGI = (from x in doc3.Element("Yslygi").Elements("Yslyga")
                                  orderby x.Element("IdY").Value
                                  select new
                                  {
                                      Услуга = x.Element("IdY").Value,
                                      Название = x.Element("Name").Value,
                                      Описание = x.Element("About").Value

                                  }).ToList();

                    var YSLYGICollection = new ObservableCollection<object>(YSLYGI);
                    dg.ItemsSource = YSLYGICollection;

                    MessageBox.Show("Изменения сохранены!");
                    yesno = false;
                }
                else
                {
                    MessageBox.Show("Ошибка");
                }
                dobavlenie1.Clear();
                dobavlenie2.Clear();
                dobavlenie3.Clear();
                dobavlenie4.Clear();
                dobavlenie5.Clear();
                dobavlenie6.Clear();
            }
        }
        private void buttondel_Click(object sender, RoutedEventArgs e)
        {
            if (counter == 1)
            {
                IEnumerable<XElement> tests =
                    from el in doc1.Elements("Clients").Elements("Client")
                    where (string)el.Element("IdC") == dobavlenie1.Text
                    select el;
                foreach (XElement el in tests)
                    yesno = true;
                if (yesno == true)
                {
                    doc1.Elements("Clients").Elements("Client").First(b => ((string)b.Element("IdC")) == dobavlenie1.Text).Remove();

                    doc1.Save("D:\\МИРЭА\\Верстка\\3 семестр\\Оконное прилож\\WPF\\WpfApp\\WpfApp\\clients.xml");

                    var CLIENTS = (from x in doc1.Element("Clients").Elements("Client")
                                   orderby x.Element("IdC").Value
                                   select new
                                   {
                                       Клиент = x.Element("IdC").Value,
                                       Название = x.Element("Name").Value,
                                       Деятельность = x.Element("Type").Value,
                                       Адрес = x.Element("Address").Value,
                                       Телефон = x.Element("Number").Value

                                   }).ToList();

                    var CLIENTSCollection = new ObservableCollection<object>(CLIENTS);
                    dg.ItemsSource = CLIENTSCollection;

                    MessageBox.Show("Данные удалены!");
                    yesno = false;
                }
                else
                {
                    MessageBox.Show("Ошибка");
                }
                dobavlenie1.Clear();
                dobavlenie2.Clear();
                dobavlenie3.Clear();
                dobavlenie4.Clear();
                dobavlenie5.Clear();
                dobavlenie6.Clear();

            }
            if (counter == 2)
            {
                IEnumerable<XElement> tests =
                   from el in doc2.Elements("Deals").Elements("Deal")
                   where (string)el.Element("IdD") == dobavlenie1.Text
                   select el;
                foreach (XElement el in tests)
                    yesno = true;
                if (yesno == true)
                {
                    doc2.Elements("Deals").Elements("Deal").First(b => ((string)b.Element("IdD")) == dobavlenie1.Text).Remove();

                    doc2.Save("D:\\МИРЭА\\Верстка\\3 семестр\\Оконное прилож\\WPF\\WpfApp\\WpfApp\\deals.xml");

                    var DEALS = (from x in doc2.Element("Deals").Elements("Deal")
                                 orderby x.Element("IdD").Value
                                 select new
                                 {
                                     Сделка = x.Element("IdD").Value,
                                     Клиент = x.Element("IdC").Value,
                                     Услуга = x.Element("IdY").Value,
                                     Сумма = x.Element("Sum").Value,
                                     Комиссионные = x.Element("Comis").Value,
                                     Описание = x.Element("About").Value

                                 }).ToList();

                    var DEALSCollection = new ObservableCollection<object>(DEALS);
                    dg.ItemsSource = DEALSCollection;

                    MessageBox.Show("Данные удалены!");
                    yesno = false;
                }
                else
                {
                    MessageBox.Show("Ошибка");
                }
                dobavlenie1.Clear();
                dobavlenie2.Clear();
                dobavlenie3.Clear();
                dobavlenie4.Clear();
                dobavlenie5.Clear();
                dobavlenie6.Clear();

            }
            if (counter == 3)
            {
                IEnumerable<XElement> tests =
                   from el in doc3.Elements("Yslygi").Elements("Yslyga")
                   where (string)el.Element("IdY") == dobavlenie1.Text
                   select el;
                foreach (XElement el in tests)
                    yesno = true;
                if (yesno == true)
                {
                    doc3.Elements("Yslygi").Elements("Yslyga").First(b => ((string)b.Element("IdY")) == dobavlenie1.Text).Remove();

                    doc3.Save("D:\\МИРЭА\\Верстка\\3 семестр\\Оконное прилож\\WPF\\WpfApp\\WpfApp\\yslygi.xml");

                    var YSLYGI = (from x in doc3.Element("Yslygi").Elements("Yslyga")
                                  orderby x.Element("IdY").Value
                                  select new
                                  {
                                      Услуга = x.Element("IdY").Value,
                                      Название = x.Element("Name").Value,
                                      Описание = x.Element("About").Value

                                  }).ToList();

                    var YSLYGICollection = new ObservableCollection<object>(YSLYGI);
                    dg.ItemsSource = YSLYGICollection;

                    MessageBox.Show("Данные удалены!");
                    yesno = false;
                }
                else
                {
                    MessageBox.Show("Ошибка");
                }
                dobavlenie1.Clear();
                dobavlenie2.Clear();
                dobavlenie3.Clear();
                dobavlenie4.Clear();
                dobavlenie5.Clear();
                dobavlenie6.Clear();
            }
        }
        private void buttonpoisk_Click(object sender, RoutedEventArgs e)
        {
            if (counter == 1)
            {
                if (dobavlenie1 != null)
                {
                    var kod = (from x in doc1.Element("Clients").Elements("Client")
                               where (string)x.Element("IdC") == dobavlenie1.Text || (string)x.Element("Name") == dobavlenie2.Text || (string)x.Element("Type") == dobavlenie3.Text || (string)x.Element("Address") == dobavlenie4.Text || (string)x.Element("Number") == dobavlenie5.Text
                               select new
                               {
                                   Клиент = x.Element("IdC").Value,
                                   Название = x.Element("Name").Value,
                                   Деятельность = x.Element("Type").Value,
                                   Адрес = x.Element("Address").Value,
                                   Телефон = x.Element("Number").Value

                               }).ToList();

                    dg.ItemsSource = kod;
                }
                dobavlenie1.Clear();
                dobavlenie2.Clear();
                dobavlenie3.Clear();
                dobavlenie4.Clear();
                dobavlenie5.Clear();
                dobavlenie6.Clear();

            }
            if (counter == 2)
            {
                if (dobavlenie1 != null)
                {
                    var kod = (from x in doc2.Element("Deals").Elements("Deal")
                               where (string)x.Element("IdD") == dobavlenie1.Text || (string)x.Element("IdC") == dobavlenie2.Text || (string)x.Element("IdY") == dobavlenie3.Text || (string)x.Element("Sum") == dobavlenie4.Text || (string)x.Element("Comis") == dobavlenie5.Text || (string)x.Element("About") == dobavlenie6.Text
                               select new
                               {
                                   Сделка = x.Element("IdD").Value,
                                   Клиент = x.Element("IdC").Value,
                                   Услуга = x.Element("IdY").Value,
                                   Сумма = x.Element("Sum").Value,
                                   Комиссионные = x.Element("Comis").Value,
                                   Описание = x.Element("About").Value

                               }).ToList();

                    dg.ItemsSource = kod;
                }
                dobavlenie1.Clear();
                dobavlenie2.Clear();
                dobavlenie3.Clear();
                dobavlenie4.Clear();
                dobavlenie5.Clear();
                dobavlenie6.Clear();
            }
            if (counter == 3)
            {
                if (dobavlenie1 != null)
                {
                    var kod = (from x in doc3.Element("Yslygi").Elements("Yslyga")
                               where (string)x.Element("IdY") == dobavlenie1.Text || (string)x.Element("Name") == dobavlenie2.Text || (string)x.Element("About") == dobavlenie3.Text
                               select new
                               {
                                   Услуга = x.Element("IdY").Value,
                                   Название = x.Element("Name").Value,
                                   Описание = x.Element("About").Value

                               }).ToList();

                    dg.ItemsSource = kod;
                }
                dobavlenie1.Clear();
                dobavlenie2.Clear();
                dobavlenie3.Clear();
                dobavlenie4.Clear();
                dobavlenie5.Clear();
                dobavlenie6.Clear();
            }

        }
        private void buttondop_Click(object sender, RoutedEventArgs e)
        {
            if (counter == 1)
            {

                if (dop.Text == "Группировать")
                {
                    var type = (from x in doc1.Element("Clients").Elements("Client")
                                group x by x.Element("Type").Value into g
                                select new
                                {
                                    Группа = g.Key

                                }).ToList();

                    dg.ItemsSource = type;

                    dobavlenie1.Clear();
                    dobavlenie2.Clear();
                    dobavlenie3.Clear();
                    dobavlenie4.Clear();
                    dobavlenie5.Clear();
                    dobavlenie6.Clear();
                    dop.Clear();
                }
                
                if (dop.Text == "Количество")
                {
                    var type = (from x in doc1.Element("Clients").Elements("Client")
                                where (string)x.Element("IdC") == dobavlenie1.Text || (string)x.Element("Name") == dobavlenie2.Text || (string)x.Element("Type") == dobavlenie3.Text || (string)x.Element("Address") == dobavlenie4.Text || (string)x.Element("Number") == dobavlenie5.Text
                                group x by x.Element("IdC").Value into g
                                select new
                                {
                                    Клиент = g.Key,
                                    Количество = g.Count()

                                }).ToList();

                    dg.ItemsSource = type;

                    dobavlenie1.Clear();
                    dobavlenie2.Clear();
                    dobavlenie3.Clear();
                    dobavlenie4.Clear();
                    dobavlenie5.Clear();
                    dobavlenie6.Clear();
                    dop.Clear();

                }
                if (dop.Text == "Данные")
                {
                    var CLIENTS = (from x in doc1.Element("Clients").Elements("Client")
                                   orderby x.Element("IdC").Value
                                   select new
                                   {
                                       Клиент = x.Element("IdC").Value,
                                       Название = x.Element("Name").Value,
                                       Деятельность = x.Element("Type").Value,
                                       Адрес = x.Element("Address").Value,
                                       Телефон = x.Element("Number").Value

                                   }).ToList();

                    var CLIENTSCollection = new ObservableCollection<object>(CLIENTS);
                    dg.ItemsSource = CLIENTSCollection;

                    dobavlenie1.Clear();
                    dobavlenie2.Clear();
                    dobavlenie3.Clear();
                    dobavlenie4.Clear();
                    dobavlenie5.Clear();
                    dobavlenie6.Clear();
                    dop.Clear();
                }
            }
            if (counter == 2)

            {

                if (dop.Text == "Группировать")
                {
                    var type = (from x in doc2.Element("Deals").Elements("Deal")
                                group x by x.Element("Comis").Value into g
                                select new
                                {
                                    Группа = g.Key

                                }).ToList();

                    dg.ItemsSource = type;

                    dobavlenie1.Clear();
                    dobavlenie2.Clear();
                    dobavlenie3.Clear();
                    dobavlenie4.Clear();
                    dobavlenie5.Clear();
                    dobavlenie6.Clear();
                    dop.Clear();
                }
                if (dop.Text == "Количество")
                {
                    var type = (from x in doc2.Element("Deals").Elements("Deal")
                                where (string)x.Element("IdD") == dobavlenie1.Text || (string)x.Element("IdC") == dobavlenie2.Text || (string)x.Element("IdY") == dobavlenie3.Text || (string)x.Element("Sum") == dobavlenie4.Text || (string)x.Element("Comis") == dobavlenie5.Text || (string)x.Element("About") == dobavlenie6.Text
                                group x by x.Element("IdD").Value into g
                                select new
                                {
                                    Сделка = g.Key,
                                    Количество = g.Count()

                                }).ToList();

                    dg.ItemsSource = type;

                    dobavlenie1.Clear();
                    dobavlenie2.Clear();
                    dobavlenie3.Clear();
                    dobavlenie4.Clear();
                    dobavlenie5.Clear();
                    dobavlenie6.Clear();
                    dop.Clear();
                }
                if (dop.Text == "Данные")
                {
                    var DEALS = (from x in doc2.Element("Deals").Elements("Deal")
                                 orderby x.Element("IdD").Value
                                 select new
                                 {
                                     Сделка = x.Element("IdD").Value,
                                     Клиент = x.Element("IdC").Value,
                                     Услуга = x.Element("IdY").Value,
                                     Сумма = x.Element("Sum").Value,
                                     Комиссионные = x.Element("Comis").Value,
                                     Описание = x.Element("About").Value

                                 }).ToList();

                    var DEALSCollection = new ObservableCollection<object>(DEALS);
                    dg.ItemsSource = DEALSCollection;

                    dobavlenie1.Clear();
                    dobavlenie2.Clear();
                    dobavlenie3.Clear();
                    dobavlenie4.Clear();
                    dobavlenie5.Clear();
                    dobavlenie6.Clear();
                    dop.Clear();
                }
            }

            if (counter == 3)
            {

                if (dop.Text == "Группировать")
                {
                    var type = (from x in doc3.Element("Yslygi").Elements("Yslyga")
                                group x by x.Element("Name").Value into g
                                select new
                                {
                                    Группа = g.Key

                                }).ToList();

                    dg.ItemsSource = type;

                    dobavlenie1.Clear();
                    dobavlenie2.Clear();
                    dobavlenie3.Clear();
                    dobavlenie4.Clear();
                    dobavlenie5.Clear();
                    dobavlenie6.Clear();
                    dop.Clear();
                }
                if (dop.Text == "Количество")
                {
                    var type = (from x in doc3.Element("Yslygi").Elements("Yslyga")
                                where (string)x.Element("IdY") == dobavlenie1.Text || (string)x.Element("Name") == dobavlenie2.Text || (string)x.Element("About") == dobavlenie3.Text
                                group x by x.Element("IdY").Value into g
                                select new
                                {
                                    Услуга = g.Key,
                                    Количество = g.Count()

                                }).ToList();

                    dg.ItemsSource = type;

                    dobavlenie1.Clear();
                    dobavlenie2.Clear();
                    dobavlenie3.Clear();
                    dobavlenie4.Clear();
                    dobavlenie5.Clear();
                    dobavlenie6.Clear();
                    dop.Clear();
                }
                if (dop.Text == "Данные")
                {
                    var YSLYGI = (from x in doc3.Element("Yslygi").Elements("Yslyga")
                                     orderby x.Element("IdY").Value
                                     select new
                                     {
                                         Услуга = x.Element("IdY").Value,
                                         Название = x.Element("Name").Value,
                                         Описание = x.Element("About").Value

                                     }).ToList();

                    var YSLYGICollection = new ObservableCollection<object>(YSLYGI);
                    dg.ItemsSource = YSLYGICollection;

                    dobavlenie1.Clear();
                    dobavlenie2.Clear();
                    dobavlenie3.Clear();
                    dobavlenie4.Clear();
                    dobavlenie5.Clear();
                    dobavlenie6.Clear();
                    dop.Clear();
                }
            }
        }

        private void buttonskidka_Click(object sender, RoutedEventArgs e)
        {
            int x, y, z;

            if ((num.Text != "") && (perc.Text != "")) 
            { 
                string S1 = num.Text;
                x = Convert.ToInt32(S1);

                string S2 = perc.Text;
                y = Convert.ToInt32(S2);

                z = x - (x * y)/100;

                rez.Text = z.ToString();
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
           
        }
    }
}