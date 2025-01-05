using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>();
            while (true)
            {
                
                
                    Console.WriteLine("\nTo-Do List\n");
                    Console.WriteLine("1.add task");
                    Console.WriteLine("2.mark task as complete");
                    Console.WriteLine("3.Delete task");
                    Console.WriteLine("4.view all tasks");
                    Console.WriteLine("5.Exit");
                    Console.WriteLine("enter your choice");

                
                    int choice = int.Parse(Console.ReadLine());
                
                

                switch (choice)
                {
                    case 1:

                        var task = new Task();
                        Console.WriteLine("enter id:");
                        int id3 = int.Parse(Console.ReadLine());
                        if (tasks.Any(x => x.Id == id3))
                        {
                            Console.WriteLine("Duplicate id!");
                            break;
                        }
                        task.Id = id3;
                        Console.WriteLine("enter Title:");
                        task.Title = Console.ReadLine();
                        Console.WriteLine("enter description :");
                        task.Description = Console.ReadLine();
                        tasks.Add(task);
                        Console.WriteLine("Task Added");
                        break;

                    case 2:
                        if (!tasks.Any())
                        {
                            Console.WriteLine("No task available");
                            break;
                        }
                        Console.WriteLine("enter the task id to mark completed");
                        int id = int.Parse(Console.ReadLine());
                        if (tasks.Any(x=>x.Id==id))
                        {
                            var taskmark = tasks.FirstOrDefault(x => x.Id == id);
                            taskmark.Iscompleted = true;
                            Console.WriteLine("marked task as complete");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("No task With that id");
                            break;
                        }

                       

                    case 3:
                        if (!tasks.Any())
                        {
                            Console.WriteLine("No task available to delete");
                            break;
                        }
                       
                            Console.WriteLine("enter the task id to delete");
                            int id2 = int.Parse(Console.ReadLine());

                        if (tasks.Any(x=>x.Id==id2))
                        {
                            var taskdel = tasks.FirstOrDefault(x => x.Id == id2);
                            tasks.Remove(taskdel);
                            Console.WriteLine("task deleted");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("there is no task to delete with that id");
                            break;
                        }
                       

                    case 4:
                        if (!tasks.Any())
                        {
                            Console.WriteLine("No task available");
                            break;
                        }
                        Console.WriteLine("Completed tasks are:");
                        if (tasks.Any(x => x.Iscompleted == true))
                        {
                            foreach (var t in tasks.Where(x => x.Iscompleted == true))
                            {
                                t.Display();
                            }

                        }
                        else
                        {
                            Console.WriteLine("No completed tasks are available");
                        }
                        Console.WriteLine("Pending tasks are:");
                        foreach (var t in tasks.Where(x => x.Iscompleted == false))
                        {
                            t.Display();
                        }
                        break;

                    case 5: Environment.Exit(0);
                        break;


                    default:
                        Console.WriteLine("invalid choice");
                        break;



                }

            }


        }
    }
}
