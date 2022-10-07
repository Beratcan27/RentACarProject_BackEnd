using System;

class Program
{
    static void Main(string[] args)
    {
        MyList<string> arabalar = new MyList<string>();

        arabalar.Add("Opel");
        arabalar.Add("Renault");
        arabalar.Add("Nissan");
        arabalar.Add("Peugeot");
        arabalar.Add("Hyundai");
        arabalar.Add("BMW");


        Console.WriteLine(arabalar.Contains("Opel"));

        Console.WriteLine(arabalar.Count);

        foreach (var araba in arabalar.Items)
        {
            Console.WriteLine(araba);
        }

        arabalar.RemoveAt(0);

        Console.WriteLine("------------------");

        foreach (var araba in arabalar.Items)
        {
            Console.WriteLine(araba);
        }
        Console.WriteLine(arabalar.Count);

    }

    class MyList<T>
    {

        T[] items;

        public MyList()
        {
            items = new T[0];
        }

        public void Add(T entity)
        {

            T[] tempDatas = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempDatas.Length; i++)
            {
                items[i] = tempDatas[i];
            }
            items[items.Length - 1] = entity;
        }

        public void Remove()
        {
            T[] tempDatas = items;
            items = new T[items.Length - 1];
            for (int i = 0; i < tempDatas.Length - 1; i++)
            {
                items[i] = tempDatas[i];
            }
        }

        public bool Contains(T entity)
        {
            int available = 0;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Equals(entity))
                {
                    available = 1;
                    break;
                }
            }
            if (available == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RemoveAt(int index)
        {


            if (index >= items.Length)
            {
                Console.WriteLine("Dizinin Sınırları dışında index belirlediniz!");
            }
            else
            {
                T[] tempData = items;
                items = new T[items.Length - 1];
                for (int i = 0; i < items.Length; i++)
                {

                    if (i == index)
                    {
                        for (int j = i; j < items.Length; j++)
                        {
                            items[j] = tempData[j + 1];
                        }
                        break;
                    }
                    else
                    {
                        items[i] = tempData[i];
                    }
                }
            }

        }
        public void Clear()
        {

            items = new T[0];

        }


        public int Count
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }


    }
}
