using System;

namespace AllListCostum
{
   public class Program
   {
     public static void Main(string[] args)
     {
            MyList<string> mylist = new MyList<string>();


            mylist.Add("Uzeyir");
            mylist.Add("Cavansir");
            mylist.Add("Cavid");
            mylist.Clear("Cemsid");
            mylist.Clear("Uzeyir");
            mylist.Find("Uzeyir");
            mylist.AddRange("Abdulla");

            mylist.GetAll();


           
     }
   }





    public class MyList<T>
    {
        public string[] arr;

        public MyList()
        {
            arr = new string[0];
        }

        public void Add(string str)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = str;
        }

        public void Clear(string str)
        {
            foreach (var item in arr)
            {
                if (item != str)
                {
                    Console.WriteLine(item);
                }
            }
        }

       
        public void Find(string str)
        {
           
            foreach (var item in arr)
            {
                if (item == str)
                {
                     
                    Console.WriteLine(item);
                    break;
                }
                
            }
            
        }

        public void AddRange(string str)
        {
            string[] arr = { "Qafur", "Emil" };

            foreach (var item in arr)
            {
                if (item == str)
                {
                    Console.WriteLine(item);
                }
            }


           
        }

        public void GetAll()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}