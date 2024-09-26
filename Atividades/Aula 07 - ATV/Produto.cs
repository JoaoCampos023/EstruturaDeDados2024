using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_07___ATV
{
    public class Produto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Barcode { get; set; }


        public Produto (int id, string name, string location, string barcode)
        {
            Id = id;
            Name = name;
            Location = location;
            Barcode = barcode;
        }
    }
}