using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankModel
{
    public class StandardUser
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string PostCode { get; set; }
        public string Town { get; set; }
        public string NIP { get; set; }
        public string PESEL { get; set; }
        public int points { get; set; }
        [MaxLength(255)]
        public string Email { get; set; }
        public List<int> Tranactions { get; set; }
    }
}
