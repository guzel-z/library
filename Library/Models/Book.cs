using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;

namespace Library.Models
{
    public class Book
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual int Year { get; set; }
        public virtual int PageNumber { get; set; }
        public virtual int InstancesNumber { get; set; }
        public virtual ISet<Genre> Genres { get; set; } 
        public virtual ISet<Author> Authors { get; set; }
        public virtual ISet<IssuingBook> IssuingBooks { get; set; }
        public Book()
        {
            Genres = new HashSet<Genre>();
            Authors = new HashSet<Author>();
            IssuingBooks = new HashSet<IssuingBook>();
        }
    }

    public class BookMap : ClassMap<Book>
    {
        public BookMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Description);
            Map(x => x.Year);
            Map(x => x.PageNumber);
            Map(x => x.InstancesNumber);
            HasManyToMany(x => x.Authors)
                .Cascade.SaveUpdate()
                .Table("Book_Author");
            HasManyToMany(x => x.Genres)
                .Cascade.SaveUpdate().
                Table("Book_Genre");
            HasMany(x => x.IssuingBooks).LazyLoad().Inverse().Cascade.All();
        }
    }
}