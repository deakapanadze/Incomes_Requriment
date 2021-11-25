using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_purchee.Models.JoinModels
{
    public class joinpurchase
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string NameInv { get; set; }


    }
}
