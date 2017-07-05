using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;

namespace Library.Models
{
    public class Author
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string BirthDate { get; set; }
        public virtual string Biography { get; set; }
        public virtual ISet<Book> Books { get; set; }
        public Author()
        {
            Books = new HashSet<Book>();
        }
    }

    public class AuthorMap : ClassMap<Author>
    {
        public AuthorMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.BirthDate);
            Map(x => x.Biography);
            HasManyToMany(x => x.Books)
                .Cascade.All()
                .Inverse()
                .Table("Book_Author");
        }
    }
}