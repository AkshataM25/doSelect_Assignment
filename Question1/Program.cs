namespace Question1
{
    class Person
    {
        public string Name{ get; set;}
        public string Address { get; set;}
        public int Age { get; set;}
    }

    class PersonImplementation
    {
        public string GetName(IList<Person> person)
        {
            string result="";
            foreach (var item in person)
            {
                result +=$"{item.Name} {item.Address}";
            }
            return result;
        }

        public double Average(IList<Person> person)
        {
            double sum = 0;
            int count = 0;
            foreach (var item in person)
            {
                sum += item.Age;
                count++;  
            }
            return sum/count;
        }

        public int Max(IList<Person> person)
        {
            int max = 0;
            foreach (var item in person)
            {
                if (item.Age > max)
                {
                    max = item.Age;
                }
            }
            return max;
        }
          
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<Person> p = new List<Person>();
            p.Add(new Person { Name = "Aarya", Address = "A2101", Age=69 });
            p.Add(new Person { Name = "Daniel", Address = "D104", Age = 40 });
            p.Add(new Person { Name = "Ira", Address = "H801", Age = 25 });
            p.Add(new Person { Name = "Jennifer", Address = "I1704", Age = 33 });

            var personImpl = new PersonImplementation();

            string name = personImpl.GetName(p);
            double averageAge = personImpl.Average(p);
            int maxAge = personImpl.Max(p);

            Console.WriteLine(name);
            Console.WriteLine(averageAge);
            Console.WriteLine(maxAge);
        }
    }
}
