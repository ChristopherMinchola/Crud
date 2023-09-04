using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrudApp.Models
{
    internal class Company
    {

        [PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return this.Name + "(" + this.Address + ")";
        }
    }
}
