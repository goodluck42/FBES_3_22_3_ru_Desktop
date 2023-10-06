using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace App
{
    public class User
    {
        private int _id;

        [AttributeDisplayable]
        public int Id
        {
            get => _id;
            set => _id = value;
        }

        [AttributeDisplayable] public string Login { get; set; }
        public string Password { get; set; }

        private void Print(int test)
        {
            Console.WriteLine($"{Login} : {Password} : {test}");
        }
    }


    public class Person
    {
        [AttributeDisplayable] public int Blabla { get; set; }

        [AttributeDisplayable] public string Blabla2 { get; set; }
        public string Password { get; set; }
    }

    public class UserPrinter
    {
        public static void Print(object data)
        {
            var builder = new StringBuilder();
            Type type = data.GetType();
            var properties = type.GetProperties(); // Id, Login, Password

            foreach (var prop in properties)
            {
                IEnumerable<Attribute> attributes = prop.GetCustomAttributes(); // 

                var result = attributes.FirstOrDefault(a => a.GetType() == typeof(AttributeDisplayable));

                if (result == null)
                {
                    continue;
                }

                var propValue = prop.GetValue(data);

                if (propValue is string login)
                {
                    builder.Append($"{login} : ");
                }
                else if (propValue is int id)
                {
                    builder.Append($"{id} : ");
                }
            }

            Console.WriteLine(builder.ToString());
        }

        public static void Display(object obj, string prop)
        {
            var type = obj.GetType();

            var propInfo = type.GetProperty(prop);

            if (propInfo != null)
            {
                Console.WriteLine(propInfo.GetValue(obj).ToString());
            }
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class AttributeDisplayable : Attribute
    {
        
    }
}

namespace Reflection
{
    using App;

    internal class Program
    {
        public static void Main(string[] args)
        {
            User user = new User
            {
                Id = 42,
                Login = "superlogin",
                Password = "vadik1337"
            };

            Type type = user.GetType(); // runtime
            //Type type = typeof(User); // compile time

            Console.WriteLine(type.FullName);
            Console.WriteLine(type.Name);

            // {
            //     Console.WriteLine("Methods: ");
            //     MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            //
            //     foreach (MethodInfo info in methods)
            //     {
            //         Console.WriteLine(info.Name);
            //     }
            // }
            //
            // {
            //     Console.WriteLine("Properties: ");
            //     
            //     PropertyInfo[] props = type.GetProperties();
            //
            //     foreach (var prop in props)
            //     {
            //         Console.WriteLine(prop.Name);
            //     }
            // }

            /*{
                var method = type.GetMethod("Print", BindingFlags.NonPublic | BindingFlags.Instance);

                if (method == null)
                {
                    Console.WriteLine("Method not found");
                }
                else
                {
                    method.Invoke(user, new object[] { 10 }); // user.Print(10);
                }
            }*/

            // {
            //     FieldInfo field = type.GetField("_id", BindingFlags.NonPublic | BindingFlags.Instance);
            //
            //     if (field != null)
            //     {
            //         field.SetValue(user, 1337);
            //
            //         Console.WriteLine(user.Id);
            //         int data = (int)field.GetValue(user);
            //
            //         Console.WriteLine(data);
            //     }
            // }

            // UserPrinter.Print(new Person()
            // {
            //     Blabla = 10,
            //     Password = "personpass",
            //     Blabla2 = "personlogin"
            // });
            //
            // UserPrinter.Print(new User()
            // {
            //     Id = 10,
            //     Password = "userpass",
            //     Login = "userlogin"
            // });
            
            UserPrinter.Display(new User
            {
                Id = 1337,
                Login = "vadi",
                Password = "stAss"
            }, "Password");
        }
    }
}