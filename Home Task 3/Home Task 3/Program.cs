using System.Runtime.CompilerServices;
using System;
using System.Threading.Channels;

namespace Home_Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] uppercaseLetters = { 'A', 'B', 'C', 'D', 'E',
                'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O',
                'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
         

            while (true)
            {

                
                Console.Write(" Enter first name:");
                string firstName = Console.ReadLine();


                ExecuteNameAndFatherCheck(uppercaseLetters, firstName);
                Console.WriteLine(ExecuteNameAndFatherCheck(uppercaseLetters, firstName));


                Console.Write("Enter last name:");
                string lastName = Console.ReadLine();


                ExecuteLastNameCheck(uppercaseLetters, lastName);
                Console.WriteLine(ExecuteLastNameCheck(uppercaseLetters, lastName));

                Console.Write("Enter father's name :");
                string fatherName = Console.ReadLine();


                ExecuteNameAndFatherCheck(uppercaseLetters, fatherName);
                Console.WriteLine(ExecuteNameAndFatherCheck(uppercaseLetters, fatherName));

                Console.Write("Enter age:");
                int age = int.Parse(Console.ReadLine());

                ExecuteAgeCheck( age);
                Console.WriteLine(ExecuteAgeCheck( age));

                Console.Write("Enter FIN:");
                string fin = Console.ReadLine();


                ExecuteFinCodeCheck(uppercaseLetters, fin, numbers);
                Console.WriteLine(ExecuteFinCodeCheck(uppercaseLetters, fin, numbers));

                Console.Write("Enter phone number:");
                string phoneNumber = Console.ReadLine();

                ExecutePhoneNumberCheck( phoneNumber);
                Console.WriteLine(ExecutePhoneNumberCheck( phoneNumber));

                Console.WriteLine("Aviable position: HR, Audit, Engineer");
                Console.Write("Enter the position:");
                string position = Console.ReadLine();

                ExecutePositionCheck(position);
                Console.WriteLine(ExecutePositionCheck(position));


                Console.Write("Enter salary:");
                decimal salary = decimal.Parse(Console.ReadLine());

                ExecuteSalary(salary);
                Console.WriteLine(ExecuteSalary(salary));
            }





            static bool ExecuteNameAndFatherCheck(char[] uppercaseLetters, string firstName)
            {
                for (int i = 0; i < firstName.Length; i++)
                {
                    for (int j = 0; j < uppercaseLetters.Length; j++)
                    {
                        if (i == 0 && uppercaseLetters[j] == firstName[i] && firstName.Length >= 2 && firstName.Length <= 20)
                        {

                            return true;
                        }

                        else if (i != 0 && uppercaseLetters[j] == firstName[i])
                        {
                            return false;

                        }
                    }

                    return false;

                }
                return true;
            }

            static bool ExecuteLastNameCheck(char[] uppercaseLetters, string lastName)
            {
                for (int i = 0; i < lastName.Length; i++)
                {
                    for (int j = 0; j < uppercaseLetters.Length; j++)
                    {
                        if (i == 0 && uppercaseLetters[j] == lastName[i] && lastName.Length >= 2 && lastName.Length <= 35)
                        {
                            return true;
                        }

                        else if (i != 0 && uppercaseLetters[j] == lastName[i])
                        {
                            return false;

                        }
                    }


                }
                return false;
            }          

            static bool ExecuteAgeCheck( int age)
            {

                if (age >= 18 && age <= 65)
                {
                    return true;
                }
                return false;
            }

            static bool ExecuteFinCodeCheck(char[] uppercaseLetters, string fin, char[] numbers)
            {
                if (fin.Length != 7)
                {
                    return false;
                }



                for (int i = 0; i < fin.Length; i++)
                {
                    for (int j = 0; j < uppercaseLetters.Length; j++)
                    {
                        for(int k = 0; k < numbers.Length; k++)
                        {
                        if (fin[i] == uppercaseLetters[j]&& fin[i] == numbers[k])
                        {
                            return true;

                        }
                        if (j == uppercaseLetters.Length - 1)
                        {
                            return false;
                        }

                        }

                    }


                }
                return false;
            }

            static bool ExecutePhoneNumberCheck( string phoneNumber)
            {
                for (int i = 0; i < phoneNumber.Length; i++)
                {


                    if (phoneNumber[0] == '+' && phoneNumber[1] == '9' && phoneNumber[2] == '9' && phoneNumber[3] == '4')
                    {
                        return true;
                    }
                    if (phoneNumber.Length != 13)
                    {
                        return false;
                    }

                }
                return false;
            }

            static bool ExecutePositionCheck(string position)
            {
                if (position == "HR" || position == "Audit" || position == "Engineer")
                {
                    return true;
                }
                return false;
            }

            static bool ExecuteSalary(decimal salary)
            {
                if (salary >= 1500 && salary <= 5000)
                {
                    return true;
                }

                return false;
            }
        }

    }
}