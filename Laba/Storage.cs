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

        public Storage(string adressStorage)
        {
            this.adressStorage = adressStorage;
        }

        private int idStorage;

        public Storage(int idStorage)
        {
            this.idStorage = idStorage;
        }

        private List<Product> products;

        public Storage(List<Product> products)
        {
            this.products = products;
        }

        public string AdressStorage { get => adressStorage; set => adressStorage = value; }
        public int IdStorage { get => idStorage; set => idStorage = value; }
        internal List<Product> Products { get => products; set => products = value; }

    }
}
