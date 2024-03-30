using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Proxy;
using DesignPatterns.Structural.Adapter;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Structural.Facade;
using DesignPatterns.Structural.Flyweight;
using DesignPatterns.Behavioral.Memento;
using DesignPatterns.Behavioral.State;
using DesignPatterns.Behavioral.Iterator;
using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Behavioral.TemplateMethod;
using DesignPatterns.Behavioral.Command;

namespace DesignPatterns
{
    class Program
    {
        public static object TransfateMonyTask { get; private set; }

        static void Main(string[] args)
        {
            #region Creational Desgin Pattern

            #region singleton 
            //Task task1 = Task.Factory.StartNew(() =>
            //{
            //    Counter counter1 = Counter.GetInstance();
            //    counter1.AddOne();
            //    Console.WriteLine("c1 " + Counter.count);
            //});

            //Task task2 = Task.Factory.StartNew(() =>
            //{
            //    Counter counter2 = Counter.GetInstance();
            //    counter2.AddOne();
            //    Console.WriteLine("c2 " + Counter.count);
            //});

            //Console.ReadKey();
            #endregion

            #region Prototype
            //Employee e1 = new RegularEmployee();
            //e1.Id = 1;
            //e1.Name = "ahmed";
            //e1.EmpAddress = new Address { City = "city 1", Building = "B1", StreetName = "S1" };

            //Employee e2 = e1.DeepCopy();
            //e2.Id = 2;
            //e2.Name = "ali";
            //e2.EmpAddress.City = "c2";
            //Console.WriteLine(e1);
            //Console.WriteLine("------------");
            //Console.WriteLine(e2);
            #endregion

            #region Builder
            //Director director = new Director();
            //IBuilder builder = new ConcreteBuilder();
            //director.Construct(builder);
            //Product product = builder.GetProduct();
            //Console.WriteLine(product.Part1);
            #endregion

            #region Factory Method
            //Console.WriteLine("Enter Card Number: ");
            //string cardNumber = Console.ReadLine();
            //BankFactory factory = new BankFactory();
            //IBank bank = factory.GetBank(cardNumber);
            //bank.Withdraw();
            #endregion

            #region Abstract Factory 
            //Console.WriteLine("Enter Card Number: ");
            //string cardNumber = Console.ReadLine();
            //BankFactory factory = new BankFactory();
            //IBank bank = factory.GetBank(cardNumber);
            //IPaymentCard paymentCard = factory.GetPaymentCard(cardNumber);
            //bank.Withdraw();
            #endregion

            #endregion

            #region Structural Design Pattern

            #region Proxy
            //SMSServiceProxy serviceProxy = new SMSServiceProxy();
            //serviceProxy.SendSMS("123", "111", "massage 1");
            //serviceProxy.SendSMS("123", "111", "massage 1");
            //serviceProxy.SendSMS("123", "111", "massage 1");
            //serviceProxy.SendSMS("123", "111", "massage 1");
            #endregion

            #region Decorator
            //SMSService service = new SMSService();
            //EmailDecorator email = new EmailDecorator();
            //email.SetService(service);
            //email.SendSMS("123", "111", "massage 1");
            #endregion

            #region Adapter
            //Structural.Adapter.Employee employee = new Structural.Adapter.Employee();
            //employee.Salary = 1000;
            //SalaryCalculator calc = new SalaryCalculator();
            //MachineOperator _operator = new MachineOperator();
            //_operator.Salary = 1000;
            //SalaryAdapter adapter = new SalaryAdapter();
            //var salay = adapter.CalcSalary(_operator);
            //Console.WriteLine(salay);
            #endregion

            #region Facade 

            //ShoppingBasket basket = new ShoppingBasket();
            //basket.AddItem(new BasketItem { ItemID = "123", Price = 50, Quantity = 3 });
            //basket.AddItem(new BasketItem { ItemID = "456", Price = 40, Quantity = 2 });

            //PurchaseOrder order = new PurchaseOrder();
            //order.CreateOrder(basket, "name:mohammed,bank:123456789,mobile:0100000");

            #endregion

            #region Flyweight
            //DiscountCalcFactory discountFactory = new DiscountCalcFactory();
            //var calculator = discountFactory.GetDiscountCalc("day");
            //var val = calculator.GetDiscountValue(DateTime.Now.Date);
            //Console.WriteLine(val.ToString());
            #endregion


            #endregion

            #region Structural Design Pattern

            #region Memento 

            //Editor editor = new Editor();
            //History history = new History();
            //editor.SetContent("a");
            //history.Push(editor.CreateState());

            //editor.SetContent("b");
            //history.Push(editor.CreateState());

            //editor.SetContent("c");
            //editor.Restor(history.Pop());

            //Console.WriteLine(editor.GetContent());

            #endregion

            #region State 
            //Canvas canvas = new Canvas();
            //canvas.SetTool(new SelectionTool());
            //canvas.MouseDown();
            //canvas.MouseUp();
            #endregion

            #region Iterator
            //BrowserHistory history = new BrowserHistory();
            //history.Push("a");
            //history.Push("b");
            //history.Push("c");

            //Iterator iterator = history.CreateIterator();
            //while (iterator.HasNext())
            //{
            //    var current = iterator.Current();
            //    Console.WriteLine(current);
            //    iterator.Next(); 
            //}
            #endregion

            #region Strategy
            //ImageStorage image = new ImageStorage();
            //image.Store("a" , new JpegCompressor(), new BlackAndWhiteFilter());
            #endregion

            #region TemplateMethod
            //TransfareMonyTask task = new TransfareMonyTask();
            //task.Execute();
            #endregion

            #region Command
            //CustomerServices service = new CustomerServices();
            //ICommand command = new AddCustomerCommand(service);
            //Button button = new Button(command);
            //button.Click();
            #endregion

            #endregion
        }
    }
}
