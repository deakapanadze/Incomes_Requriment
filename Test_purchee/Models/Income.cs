using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_purchee.Models
{
    public class Income
    {
        public int ID { get; set; }
        public int CategoryId { get; set; }
        public int Quantity { get; set; }
        public int StructureID { get; set; }
        public DateTime DateCreated { get; set; }
        public string UserName { get; set; }
        public int RequestId { get; set; }
        public string StructureName { get; set; }
        public string CategoryName { get; set; }



    }
}
