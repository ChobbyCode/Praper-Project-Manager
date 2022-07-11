using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praper_Project_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BSD 2 - Clause License

            //Copyright(c) 2022, ChobbyCode All rights reserved.
            Console.WriteLine("BSD 2 - Clause License");
            Console.WriteLine("Copyright(c) 2022, ChobbyCode All rights reserved.");

            System.Threading.Thread.Sleep(2000);

            bool exit = false;
            bool submenu = false;
            string text = "";
            Console.Title = "Praper Version 0.0.1";
            Console.Clear();
            List<string> Projects_Name = new List<string>();
            List<string> Projects_Description = new List<string>();
            List<string> Project_Code = new List<string>();
            List<string> Project_Notes = new List<string>();
            List<string> Project_Date_Start = new List<string>();
            int Project_amount = 1000;
            

            while (exit == false)
            {
                //menu
                Console.Clear();
                Console.WriteLine("Praper");
                Console.WriteLine("Updates Available ----> https://github.com/ChobbyCode/Praper-Project-Manager");
                Console.WriteLine("Click Here To Keep Up With Development On Github ----> https://trello.com/b/xAnFgCJy/praper-project-manager");
                Console.WriteLine();
                Console.WriteLine("(1) - Projects");
                Console.WriteLine("(2) - ");
                Console.WriteLine("(3) - Notes");
                Console.WriteLine("(exit) - Close Program");

                text = Console.ReadLine();

                if(text.ToLower() == "exit")
                {
                    Console.Clear();
                    Console.WriteLine("Are You Sure You Want To Leave? (y/n)");
                    if(Console.ReadLine().ToLower() == "y")
                    {
                        exit = true;
                    }
                    else
                    {
                        exit = false;
                    }
                }else if(text == "1")
                {
                    submenu = true;
                    while(submenu == true)
                    {
                        Console.Clear();
                        Console.WriteLine("Praper");
                        Console.WriteLine();
                        Console.WriteLine("(1) - New Project");
                        Console.WriteLine("(2) - Edit Project");
                        Console.WriteLine("(3) - Add Developer Notes To Project");
                        Console.WriteLine("(4) - View Projects");
                        Console.WriteLine("(back) - Go To Main Menu");

                        text = Console.ReadLine();

                        if(text.ToLower() == "back")
                        {
                            submenu = false;
                        }else if(text.ToLower() == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("Step One: Please Name The Project");
                            Console.Write("Name...");
                            Projects_Name.Add(Console.ReadLine());
                            Console.WriteLine("Step Two: Add A Description To The Project");
                            Console.Write("Description...");
                            Projects_Description.Add(Console.ReadLine());
                            Console.WriteLine("Step Three: Any Extra Notes");
                            Console.Write("Notes...");
                            Project_Notes.Add(Console.ReadLine());
                            System.Threading.Thread.Sleep(1500);
                            Console.WriteLine("Finishing Up Project Template");
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("Adding Time");
                            string date = DateTime.UtcNow.ToString("MM-dd-yyyy");
                            Project_Date_Start.Add(date);
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("Generating Project Code");
                            Project_Code.Add(Convert.ToString(Project_amount));
                            Project_amount++;
                            System.Threading.Thread.Sleep(1500);
                        }else if(text.ToLower() == "2")
                        {

                        }else if(text.ToLower() == "3")
                        {

                        }else if(text.ToLower() == "4")
                        {
                            Console.Clear();
                            Console.WriteLine("|   Project Title   |   Description   |     Notes     |     Time     |  Code  |");
                            foreach(string i in Projects_Name)
                            {
                                int length = Projects_Name[Projects_Name.IndexOf(i)].Length;
                                string write = Projects_Name[Projects_Name.IndexOf(i)];
                                int spaces = 19 - length;
                                spaces = spaces / 2;
                                for(int j = 0; j < spaces; j++)
                                {
                                    write = " " + write;
                                    write = write + " ";
                                }
                                write = "|" + write;
                                write = write + "|";
                                Console.Write(write);

                                length = Projects_Description[Projects_Name.IndexOf(i)].Length;
                                write = Projects_Description[Projects_Name.IndexOf(i)];
                                spaces = 17 - length;
                                spaces = spaces / 2;
                                for (int j = 0; j < spaces; j++)
                                {
                                    write = " " + write;
                                    write = write + " ";
                                }
                                write = write + "|";
                                Console.Write(write);

                                length = Project_Notes[Projects_Name.IndexOf(i)].Length;
                                write = Project_Notes[Projects_Name.IndexOf(i)];
                                spaces = 15 - length;
                                spaces = spaces / 2;
                                for (int j = 0; j < spaces; j++)
                                {
                                    write = " " + write;
                                    write = write + " ";
                                }
                                write = write + "|";
                                Console.Write(write);

                                length = Project_Date_Start[Projects_Name.IndexOf(i)].Length;
                                write = Project_Date_Start[Projects_Name.IndexOf(i)];
                                spaces = 14 - length;
                                spaces = spaces / 2;
                                for (int j = 0; j < spaces; j++)
                                {
                                    write = " " + write;
                                    write = write + " ";
                                }
                                write = write + "|";
                                Console.Write(write);

                                length = Project_Code[Projects_Name.IndexOf(i)].Length;
                                write = Project_Code[Projects_Name.IndexOf(i)];
                                spaces = 8 - length;
                                spaces = spaces / 2;
                                for (int j = 0; j < spaces; j++)
                                {
                                    write = " " + write;
                                    write = write + " ";
                                }
                                write = write + "|";
                                Console.Write(write);
                            }
                            Console.ReadLine();
                        }

                    }
                }

            }
        }
    }
}
