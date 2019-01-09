using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPAM.Task7.Awards.BLL.Interface;
using EPAM.Task7.Common;
using EPAM.Task7.Entities;
using EPAM.Task7.Users.BLL;
using EPAM.Task7.Users.BLL.Interface;

namespace Epam.Task7.ConsolePL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var userLogic = DependencyResolver.UserLogic;
            var awardLogic = DependencyResolver.AwardLogic;

            Console.WriteLine($"This program shows the realization of Three-Layer Architecture programm named 'Users'{Environment.NewLine}{Environment.NewLine}" +
                $"There is a list of commands you can enter: {Environment.NewLine}{Environment.NewLine}" +
                $"Users management commands:{Environment.NewLine}{Environment.NewLine}" +
                $"To add user - enter AU,{Environment.NewLine}" +
                $"To delete user - enter DU,{Environment.NewLine}" +
                $"To show all users - enter SAU,{Environment.NewLine}" +
                $"To get user by ID - enter GUID.{Environment.NewLine}");

            Console.WriteLine($"Awards management commands:{Environment.NewLine}{Environment.NewLine}" +
                $"To add award - enter AA,{Environment.NewLine}" +
                $"To delete award - enter DA,{Environment.NewLine}" +
                $"To show all awards - enter SAA,{Environment.NewLine}" +
                $"To get award by ID - enter GAID,{Environment.NewLine}" +
                $"To add award to user - enter AAU. {Environment.NewLine}{Environment.NewLine}" +
                $"To stop programm - enter S!{Environment.NewLine}{Environment.NewLine}");

            string inp_key = "default";

            while (inp_key != "S")
            {
                Console.WriteLine("Enter your command: ");
                ReadKey(ref inp_key);
                switch (inp_key)
                {
                    case "AU":
                        {
                            AddUser(userLogic);
                            break;
                        }

                    case "DU":
                        {
                            DeleteUser(userLogic);
                            break;
                        }

                    case "SAU":
                        {
                            ShowUsers(userLogic, awardLogic);
                            break;
                        }

                    case "GUID":
                        {
                            ShowUserById(userLogic);
                            break;
                        }

                    case "AA":
                        {
                            AddAward(awardLogic);
                            break;
                        }

                    case "DA":
                        {
                            DeleteAward(awardLogic);
                            break;
                        }

                    case "SAA":
                        {
                            ShowAwards(awardLogic);
                            break;
                        }

                    case "GAID":
                        {
                            ShowAwardById(awardLogic);
                            break;
                        }

                    case "AAU":
                        {
                            AddAwardToUser(awardLogic);
                            break;
                        }

                    case "S":
                        {
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("The wrong input data. Try again.");
                        }

                        break;
                }

                Console.WriteLine("____________");
                DependencyResolver.SaveUserInfo();
                DependencyResolver.SaveAwardInfo();
                DependencyResolver.SaveAwardToUserInfo();
            }
        }

        private static void ShowUsers(IUserLogic userLogic, IAwardLogic awardLogic)
        {
            Console.WriteLine("Id|Name|Age");
            foreach (var user in userLogic.GetAll())
            {
                Console.WriteLine(user);
                Console.Write($"User's awards:");
                Dictionary<int, List<int>> awardId_UsersIDs = awardLogic.GetDictOfAwardsAndUsers();
                foreach (var item in awardId_UsersIDs)
                {
                    if (item.Value.Contains(user.Id))
                    {
                        Console.Write(awardLogic.GetById(item.Key));
                    }
                }

                Console.WriteLine();
            }
        }

        private static void ShowAwards(IAwardLogic awardLogic)
        {
            Console.WriteLine("Id|Title");
            foreach (var award in awardLogic.GetAll())
            {
                Console.WriteLine(award);
            }
        }

        private static void ShowUserById(IUserLogic userLogic)
        {
            Console.Write("Enter award ID: ");
            try
            {
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine(userLogic.GetById(id));
            }
            catch
            {
                Console.WriteLine($"ERROR. Wrong ID!{Environment.NewLine}");
            }
        }

        private static void ShowAwardById(IAwardLogic awardLogic)
        {
            Console.Write("Enter award ID: ");
            try
            {
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine(awardLogic.GetById(id));
            }
            catch
            {
                Console.WriteLine($"ERROR. Wrong ID!{Environment.NewLine}");
            }
        }

        private static void AddUser(IUserLogic userLogic)
        {
            var user = new User();

            Console.Write("Enter user name: ");
            user.Name = Console.ReadLine();
            Console.Write("Enter user BirthDay(format: DD/MM/YYYY)): ");
            try
            {
                user.DateOfBirth = DateTime.Parse(Console.ReadLine());
                userLogic.Add(user);
            }
            catch
            {
                Console.WriteLine($"ERROR. Wrong Date! User was not added.{Environment.NewLine}");
            }
        }

        private static void AddAward(IAwardLogic awardLogic)
        {
            var award = new Award();

            Console.Write("Enter award title: ");
            award.Title = Console.ReadLine();
            awardLogic.Add(award);
        }

        private static void DeleteUser(IUserLogic userLogic)
        {
            Console.Write("Enter user ID: ");
            try
            {
                int id = int.Parse(Console.ReadLine());
                userLogic.Delete(id);
            }
            catch
            {
                Console.WriteLine($"ERROR. Wrong ID! User was not deleted.{Environment.NewLine}");
            }
        }

        private static void DeleteAward(IAwardLogic awardLogic)
        {
            Console.Write("Enter award ID: ");
            try
            {
                int id = int.Parse(Console.ReadLine());
                awardLogic.Delete(id);
            }
            catch
            {
                Console.WriteLine($"ERROR. Wrong ID! Award was not deleted.{Environment.NewLine}");
            }
        }

        private static void AddAwardToUser(IAwardLogic awardLogic)
        {
            Console.Write("Enter award ID: ");
            int aid = int.Parse(Console.ReadLine());

            Console.Write("Enter user ID: ");
            int uid = int.Parse(Console.ReadLine());

            awardLogic.AddAwardToUser(aid, uid);
        }

        private static string ReadKey(ref string inp_key)
        {
            inp_key = Console.ReadLine().ToUpper();
            return inp_key;
        }
    }
}
