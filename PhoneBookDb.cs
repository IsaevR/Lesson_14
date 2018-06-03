using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp.DAO
{
    // Класс PhoneBookDb наследуется от DbContext
    public class PhoneBookDb: DbContext
    {
        public DbSet<Person> People { get; set; }

        // Конструктор PhoneBookDb служит для обновления БД. Если данные в базе 
        // не соответстуют входным данным, то база данных стирается и записывает входные данные.
        // Это необходимо на уровне разработки для того что бы видеть изменения в базе данных.
        // Когда проект пройдет тестирование и сдаетя в эксплуатацию следует удалить этот конструктор.
        static PhoneBookDb()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<PhoneBookDb>());
        }
    }
}
