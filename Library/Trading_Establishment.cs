/*
 * @author Shypunov Mykyta
 * @soauthot Arseniy Zaria
 */
using System;
namespace Library_Classes
{
    /// <summary>
    /// Родительский класс - торговая площадка
    /// </summary>
    public abstract class Trading_Establishment
    {
        /// <summary>
        /// Площадь территории торговой площадки (в квадрытных метрах)
        /// </summary>
        double area;
        /// <summary>
        /// Название торговой площадки
        /// </summary>
        string name;
        /// <summary>
        /// Владелец торговой площадки
        /// </summary>
        string owner;
        /// <summary>
        /// Адресс торговой площадки
        /// </summary>
        string location;
        /// <summary>
        /// Базовый конструктор
        /// </summary>
        public Trading_Establishment()
        {
            area = 0.0;
            name = "NotRegistred";
            owner = "Unknown";
            location = "NotArea";
        }
        /// <summary>
        /// Конструктор с именем и владельцем
        /// </summary>
        /// <param name="name"></param>
        /// <param name="owner"></param>
        public Trading_Establishment(string Name, string Owner)
        {
            if (name != "" && owner != "")
            {
                name = Name;
                owner = Owner;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введены не корректные данные!");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
        }
        /// <summary>
        /// Свойство для площади торговой площадки
        /// </summary>
        public double Area
        {
            set
            {
                if (value < 0.0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введён не правильный адрес!");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
                else
                    area = value;
            }
            get
            {
                return area;
            }
        }
        /// <summary>
        /// Свойство для названия торговой площадки
        /// </summary>
        public string Name
        {
            set
            {
                if (value == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введено не правильное название магазина!");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
                else
                    name = value;
            }
            get
            {
                return name;
            }
        }
        /// <summary>
        /// Свойство для имени владельца торговой площадки
        /// </summary>
        public string Owner
        {
            set
            {
                if (value == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введено не правильное имя владельца!");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
                else
                    owner = value;
            }
            get
            {
                return owner;
            }

        }
        /// <summary>
        /// Свойство для адреса торговой площадки
        /// </summary>
        public string Location
        {
            set
            {
                if (value == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введён не правильный адресс магазина!");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
                else
                    location = value;
            }
            get
            {
                return location;
            }
        }
        /// <summary>
        /// Виртуальный метод, возвращающий максимум информации о торговой площадке
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public virtual string PrintInfo(Trading_Establishment obj)
        {
            string s = "Название -> " + area + "\nВладелец -> " + owner + "\nАдресс -> " + area + "\nПлощадь торговой площадки -> " + area + "\n";
            return s;
        }
    }
    /// <summary>
    /// Дочерный класс торговой площадки - супермаркет
    /// </summary>
    public class Supermarket : Trading_Establishment
    {
        /// <summary>
        /// Иимеется ли мобильное приложение
        /// </summary>
        public bool mobileapp;
        /// <summary>
        /// Количество видов продукции, например: рыба, мясо, фрукты...
        /// </summary>
        int countofproducts;
        /// <summary>
        /// Есть ли бонусные карты
        /// </summary>
        public bool bonuscards;
        /// <summary>
        /// Количество кассиров
        /// </summary>
        int countofcashier;
        /// <summary>
        /// Базовый конструктор, который задаёт базовые значения для всех полей
        /// </summary>
        public Supermarket()
        {
            mobileapp = false;
            countofproducts = 0;
            bonuscards = false;
            countofcashier = 0;
        }
        /// <summary>
        /// Конструктор, которые принимает в параметрах все пначальные состояния полей класса
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Owner"></param>
        /// <param name="CountOfCashier"></param>
        /// <param name="BonusCards"></param>
        /// <param name="CountOfProducts"></param>
        /// <param name="MobileApp"></param>
        public Supermarket(string Name, string Owner, int CountOfCashier, bool BonusCards, int CountOfProducts, bool MobileApp) : base(Name, Owner)
        {
            if (CountOfCashier < 1 || CountsOfProducts < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введены не корректные данные");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            countofcashier = CountOfCashier;
            bonuscards = BonusCards;
            countofproducts = CountOfProducts;
            mobileapp = MobileApp;
        }
        /// <summary>
        /// Свойство для доступа к мобильному приложению, передавать 1, если оно есть и 0 если его нет
        /// </summary>
        public int MobileApp
        {
            set
            {
                switch (value)
                {
                    case 0: mobileapp = false; break;
                    case 1: mobileapp = true; break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Введены не корректные данные");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
            get
            {
                return Convert.ToInt32(mobileapp);
            }
        }
        /// <summary>
        /// Свойство для доступа к полю бонусные карты, передавать 1, если они есть и 0 если их нет
        /// </summary>
        public int BonusCards
        {
            set
            {
                switch (value)
                {
                    case 0: bonuscards = false; break;
                    case 1: bonuscards = true; break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Введены не корректные данные");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
            get
            {
                return Convert.ToInt32(bonuscards);
            }
        }
        /// <summary>
        /// Свойство для доступа к количеству видов продукции
        /// </summary>
        public int CountsOfProducts
        {
            set
            {
                if (value < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введено неправильное количество видов продукции!");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
                else
                    countofproducts = value;
            }
            get
            {
                return countofproducts;
            }
        }
        /// <summary>
        /// Свойство для доступа к количеству кассиров
        /// </summary>
        public int CountOfCashier
        {
            set
            {
                if (value < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введено не правильное количество кассиров");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
                else
                    countofcashier = value;
            }
            get
            {
                return countofcashier;
            }
        }
        /// <summary>
        /// Метод, возвращающий максимум информации из базового класса + дочерний класс
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override string PrintInfo(Trading_Establishment obj)
        {
            return base.PrintInfo(obj) + "Количество кассиров -> " + countofcashier + "\nМобильное приложение -> " + mobileapp + "\nКоличество видов продуктов -> " + countofproducts + "\nНаличие бонусных карт -> " + bonuscards + "\n";
        }
    }
    /// <summary>
    /// Дочерний класс торговой площадки - киоск(МАФ)
    /// </summary>
    public class Stall : Trading_Establishment
    {
        /// <summary>
        /// Тип продукции киоска (сигареты, алкоголь, книги, игрушки)
        /// </summary>
        string typeofproducts;
        /// <summary>
        /// Имя и фамилия продавца в киоске
        /// </summary>
        string nameofceller;
        /// <summary>
        /// Количество часов работы продавца в киоске
        /// </summary>
        int hoursofwork;
        /// <summary>
        /// Размер заработной платы продавца в киоске
        /// </summary>
        double salary;
        /// <summary>
        /// Базовый конструктор, задающий стандартные значения для всех полей
        /// </summary>
        public Stall()
        {
            typeofproducts = "Unknown";
            nameofceller = "Unknown";
            hoursofwork = 0;
            salary = 0.0;
        }
        /// <summary>
        /// Конструктор, которые принимает через параметры начальные состояния всех полей класса
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Owner"></param>
        /// <param name="TypeOfProducts"></param>
        /// <param name="NameOfCeller"></param>
        /// <param name="HoursOfWork"></param>
        /// <param name="Salary"></param>
        public Stall(string Name, string Owner, string TypeOfProducts, string NameOfCeller, int HoursOfWork, double Salary) : base(Name, Owner)
        {
            if (TypeOfProducts == "" || NameOfCeller == "" || HoursOfWork < 1 && HoursOfWork > 24 || Salary < 0.0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка при вводе данных");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            typeofproducts = TypeOfProducts;
            nameofceller = NameOfCeller;
            hoursofwork = HoursOfWork;
            salary = Salary;
        }
        /// <summary>
        /// Метод, возвращающий максимум информации из базового класса + дочерний класс
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override string PrintInfo(Trading_Establishment obj)
        {
            return base.PrintInfo(obj) + "Тип товаров -> " + typeofproducts + "\nИмя продавца -> " + nameofceller + "\nКоличество часов работы в день продавца -> " + hoursofwork + "\nЗарплата продавца -> " + salary + "\n";
        }
        /// <summary>
        /// свойство для доступа к зарплате продавца в киоске
        /// </summary>
        public double Salary
        {
            set
            {
                if (value < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введена не корректная зарплата!");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
                else
                    salary = value;
            }
            get
            {
                return salary;
            }
        }
        /// <summary>
        /// Свойство для доступа к часам работы продавца киоска
        /// </summary>
        public int HoursOfWork
        {
            set
            {
                if (value < 0 && value > 24)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введены не корректные часы работы!");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
                else
                    hoursofwork = value;
            }
            get
            {
                return hoursofwork;
            }
        }
        /// <summary>
        /// Доступ к имени продавца киоска
        /// </summary>
        public string NameOfCeller
        {
            set
            {
                if (value == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введено не корректное имя продавца!");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
                else
                    nameofceller = value;
            }
            get
            {
                return nameofceller;
            }
        }
        /// <summary>
        /// Доступ к типу товаров в киоске
        /// </summary>
        public string TypeOfProducts
        {
            set
            {
                if (value == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введён не правильный тип продуктов!");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
                else
                    typeofproducts = value;
            }
            get
            {
                return typeofproducts;
            }
        }
    }
}