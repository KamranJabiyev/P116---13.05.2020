using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework
            //1 task
            //string word = "HelloL";
            //Console.WriteLine(word[2]);

            //char letter = 'l';
            //int count = 0;

            //foreach (char item in word.ToLower())
            //{
            //    if (item == letter)
            //        count++;
            //}

            //for (int i = 0; i < word.Length; i++)
            //{
            //    if (word[i] == letter)
            //        count++;
            //}
            //Console.WriteLine(count);

            //2 task
            //string[] names = { "Miryasin", "Elgun", "Elshen","Ulvi","abcdefgh" };
            //string letter = "e";
            //string maxLenght = names[0];

            //foreach (string item in names)
            //{
            //    if (maxLenght.Length < item.Length)
            //        maxLenght = item;
            //}

            //Console.WriteLine(maxLenght);
            //foreach (string item in names)
            //{
            //    if(item.ToLower().Contains(letter))
            //        Console.WriteLine(item);
            //}
            #endregion

            #region try,catch,finally
            //int[] arr = { 1, 2, 3 };
            //try
            //{
            //    Console.WriteLine(arr[2]);
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Sehv index daxil etmisiniz");
            //}
            //finally
            //{
            //    Console.WriteLine("finnally ishledi");
            //}

            //Console.WriteLine("Eded daxil edin:");
            //string num = Console.ReadLine();
            //bool loop = true;
            //while (loop)
            //{
            //    try
            //    {
            //        int result = int.Parse(num);
            //        Console.WriteLine(result);
            //        loop = false;
            //    }
            //    catch (Exception)
            //    {

            //        Console.WriteLine("Zehmet olmasa duzgun eded daxil edin:");
            //        num = Console.ReadLine();
            //    }
            //}



            #endregion

            #region methods
            // gonderdiyimiz deyerler(yeni 15,5) argument
            //Console.WriteLine(Sum(8, 5));
            //Sum(5, 7);
            //string result = Info("Zaur", "Ferruxzade");
            //Console.WriteLine(result);
            //Info("Elgun", "Ferruxzade");
            //Test("word1");
            //Info("Kamran", "Jabiyev", 30);
            //string[] stu = { "Miryasin", "Ulvi", "Elshen", "Elgun" };
            //JoinString(stu);
            JoinString1("Ferid", "Orxan", "Hesen", "Tural","Elshen","Zaur");
            #endregion
        }

        static void JoinString(string[] arr)
        {
            foreach (string item in arr)
            {
                Console.WriteLine(item);
            }
        }

        static void JoinString1(params string[] arr)
        {
            foreach (string item in arr)
            {
                Console.WriteLine(item);
            }
        }

        //method signature - method name,parametrs count, parametrs datatype
        //method overloading - eyni adli metodlarin yazilmasi(eyni classin ichinde)
        static void Info(string name, string surname)
        {
            if (name == "Elgun")
            {
                //Console.WriteLine(name+" "+surname);
                Console.WriteLine($"Adi:{name}, Soyadi:{surname}");
            }
            else
            {
                Console.WriteLine("Elgun deyil");
            }

        }

        static void Info(string name, int age)
        {
            Console.WriteLine($"{name} {age}");
        }

        static void Info(string name,string surname,int age)
        {
            Console.WriteLine($"{name} {surname} {age}");
        }

        //x,y - parametr
        //static int Sum(int x,int y)
        //{
        //    if (x > y)
        //    {
        //        return x - y;
        //    }
        //    else
        //    {
        //        return y-x;
        //    }
        //}

        //static string Info(string name,string surname)
        //{
        //    return $"{name} {surname}";
        //}

        //static void Test(string w1,string w2="test",int a=5,bool isMaried=true)
        //{
        //    Console.WriteLine($"{w1} {w2} {a} {isMaried}");
        //}



    }
}
