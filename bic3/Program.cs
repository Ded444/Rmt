using System;

namespace MyApp
{
    internal class Program
    {
         class Person{
            string name;
            string surname;
            public int age;
            public int height;
            public Company nazvanie ;
            

             public Person(string name,string surname,int age,int height,Company nazvanie){
                this.name=name;
                this.surname=surname;
                this.age=age;
                this.height=height; 
                this.nazvanie=nazvanie;
            }

            public void Printfullname(){
            Console.WriteLine($"Имя: {name}");
            }
            public void Printfullsurname(){
            Console.WriteLine($"Фамилия: {surname}");
            }

            public void PrintAge(){
                Console.WriteLine($"Возраст: {age}");
            }


            public void PrintHeight(){
                Console.WriteLine($"Рост: {height}");
            }

            public void PrintNazhanie(){
                Console.WriteLine($"Название компании: {nazvanie.title}");
            }
        }

        class Company{
            public string title = "OOO Машка";
            public void PrintTitle(){
                Console.WriteLine($"Название компании: {title}");
            }
             public Company(string title){
                this.title=title;
            }            
        }


        class Kalk{
            public int result=0;
        }

    
        static void Main(string[] args)
        {
            Company alesha= new Company("OOO Пашка");
            Person sergey= new Person("Сергей","Крюхрю",18,182,alesha);
            sergey.Printfullname();
            sergey.Printfullsurname();
            sergey.PrintAge();
            sergey.PrintHeight();
            sergey.PrintNazhanie();


            //Company alesha= new Company("OOO Машка");
            //alesha.PrintTitle();
        }
    }
}