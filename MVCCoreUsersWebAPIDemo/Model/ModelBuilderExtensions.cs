using Microsoft.EntityFrameworkCore;

namespace MVCCoreUsersWebAPIDemo.Model
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User() { id = 1, name = "Leanne Graham", username = "Bret", email = "Sincere@april.biz", phone = "1-770-736-8031", website = "hildegard.org" },
                new User() { id = 2, name = "Ervin Howell", username = "Antonette", email = "Shanna@melissa.tv", phone = "010-692-6593", website = "anastasia.net" },
                new User() { id = 3, name = "Clementine Bauch", username = "Samantha", email = "Nathan@yesenia.net", phone = "1-463-123-4447", website = "ramiro.info" },
                new User() { id = 4, name = "Patricia Lebsack", username = "Karianne", email = "Julianne.OConner@kory.org", phone = "493-170-9623", website = "kale.biz" },
                new User() { id = 5, name = "Chelsey Dietrich", username = "Kamren", email = "Lucio_Hettinger@annie.ca", phone = "(254)954-1289", website = "demarco.info" }
         );
        }
    }
}
