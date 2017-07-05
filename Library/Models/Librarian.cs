using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;

namespace Library.Models
{
    public class Librarian
    {
        public virtual int Id { get; set; }
        public virtual string Surname { get; set; }
        public virtual string Name { get; set; }
        public virtual string MiddleName { get; set; }
        private UserL _userL;
        public virtual UserL UserL
        {
            get { return _userL ?? (_userL = new UserL()); }
            set { _userL = value; }
        }
    }

    public class LibrarianMap : ClassMap<Librarian>
    {
        public LibrarianMap()
        {
            Id(x => x.Id);
            Map(x => x.Surname);
            Map(x => x.Name);
            Map(x => x.MiddleName);
            HasOne(x => x.UserL).Cascade.All().Constrained();
        }
    }
}