using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo
{
    internal class Task
    {
        
      public  int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Iscompleted { get; set; } = false;

       public void Display()
        {
            Console.WriteLine($"Id : {Id} , Title : {Title} , Description : {Description}");
        }

    }
}
