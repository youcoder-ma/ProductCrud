using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductMg.Model
{
    public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string PhotoPath { get; set; }
    }
}
