using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba
{
    internal class Storage
    {
        
        private string adressStorage;
        private int idStorage;
        private List<Product> products;

        public Storage(string adressStorage, int idStorage, List<Product> products)
        {
            this.adressStorage = adressStorage;
            this.idStorage = idStorage;
            this.products = products;
        }
        public string AdressStorage { get => adressStorage; set => adressStorage = value; }
        public int IdStorage { get => idStorage; set => idStorage = value; }
        internal List<Product> Products { get => products; set => products = value; }

    }
}
