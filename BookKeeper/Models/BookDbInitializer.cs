using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BookKeeper.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Title = "Война и мир", Author = "Л. Толстой", Genre = "" });
            db.Books.Add(new Book { Title = "Отцы и дети", Author = "И. Тургенев", Genre = "" });
            db.Books.Add(new Book { Title = "Чайка", Author = "А. Чехов", Genre = "" });

            base.Seed(db);
        }
    }
}