using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace kvalKozlova
{
    public class Player
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Player(string nm, string dscp)
        {
            Name = nm;
            Description = dscp;
        }
        public void Show()
        {
            Console.WriteLine(
                 $"Название: {Name}, Описание - {Description}");
        }
    }
}
