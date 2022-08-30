using System;

namespace _30082022
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int age = 50;
            string ageStr = Console.ReadLine();

            //if(TryParse(ageStr, out age))

            if(int.TryParse(ageStr,out age))
            {
                Console.WriteLine(age);
            }
            else{
                Console.WriteLine("Ededi duzgun daxil edin");
            }
            Console.WriteLine(age);


            int x = 45;
            var result = x.Add(56);
            Console.WriteLine(result);


            string str = "45";
            var number = str.ToInt32();

            string nameStr = "abbaS";

            Console.WriteLine(nameStr.ToCapitalize());

            Console.WriteLine(ExtentionMethods.Add(45,10));

            str = "Dff2g";
            Console.WriteLine(str.HasDigit());

            string name;
            do
            {
                Console.WriteLine("Ad:");
                name = Console.ReadLine();

            } while (!Human.CheckName(name));

            Human human = new Human
            {
                Name = name
            };

            Human human1 = new Human();

            Human human2 = new Human();
            Human human3 = new Human();

            Console.WriteLine(Human.Count);


            Student std1 = new Student();
            Student std2 = new Student();
            Student std3 = new Student();
            Student std4 = new Student
            {
                FullName = "Abbas Abbasov",
                GroupNo = "P132"
            };

            Console.WriteLine(std1.No);
            Console.WriteLine(std2.No);
            Console.WriteLine(std3.No);
            Console.WriteLine(std4.No);

            std4.ShowStudentInfo();

            enterGroupNo:
            Console.WriteLine("GroupNo:");
            string groupNo = Console.ReadLine();

            if (Student.CheckGroupNo(groupNo))
            {
                Student student = new Student
                {
                    GroupNo = groupNo
                };
                goto finish;
            }
            else
            {
                Console.WriteLine("Group no deyeri yanlisdir!");
                goto enterGroupNo;
            }


            int weekDay = 6;
            switch (weekDay)
            {
                case 1:
                    Console.WriteLine("Bze");
                    break;
                case 2:
                    Console.WriteLine("Ca");
                    break;
                case 3:
                    Console.WriteLine("C");
                    break;
                case 4:
                    Console.WriteLine("CumA");
                    break;
                case 5:
                    Console.WriteLine("Cum");
                    break;
                case 6:
                    goto case 7;
                case 7:
                    Console.WriteLine("Heftesonu");
                    break;
                default:
                    Console.WriteLine("Tanimiram");
                    break;
            }


            finish:
            Console.WriteLine(Calculator.Pow(2, 5));
            Console.WriteLine("Bitdi");




        }

        static bool TryParse(string str,out int num)
        {
            try
            {
                num = Convert.ToInt32(str);
                return true;
            }
            catch (Exception)
            {
                num = 0;
                return false;
            }
        }



        //static bool CheckName(string name)
        //{
        //    if (string.IsNullOrWhiteSpace(name) || name.Length < 3)
        //        return false;

        //    for (int i = 0; i < name.Length; i++)
        //    {
        //        if (!char.IsLetter(name[i]))
        //            return false;
        //    }

        //    return true;
        //}




    }
}
