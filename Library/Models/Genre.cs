﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;

namespace Library.Models
{
    public class Genre
    {
        public virtual int Id { set; get; }
        public virtual string Name { get; set; }
        public virtual ISet<Book> Books { get; set; }
        public Genre()
        {
            Books = new HashSet<Book>();
        }
    }

    public class GenreMap : ClassMap<Genre>
    {
        public GenreMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            HasManyToMany(x => x.Books)
                .Cascade.All()
                .Inverse()
                .Table("Book_Genre");
        }
    }
}