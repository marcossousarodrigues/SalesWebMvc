using System.Collections.Generic;
using System.Linq;


namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department() { 
        
        
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSaler(Seller saller)
        {
            Sellers.Add(saller);
        }

        public double TotalSeles(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }


    }
}
