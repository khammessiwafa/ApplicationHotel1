using System;
using hotel;
using hotelClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationHotel1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel1 = new Hotel("hotel1");

            // Créer un nouveau client
            Client client1 = new Client("Khammessi", "Wafa", "wafa@gmail.com", "12345678912345678912", 120);
            Client client2 = new Client("Furgueson", "Jean", "jean@gmail.com", "98765432198765432198", 90);

            Console.WriteLine(client1);
            Console.WriteLine(client2);

            // Ajouter le client à l'hôtel
            hotel1.AddClient(client1);
            hotel1.AddClient(client2);


            Console.WriteLine(hotel1);

            Console.ReadKey();


        }
    }
}
