using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;

namespace Library.Models
{
    public class UserL
    {
        public virtual int Id { get; set; }
        public virtual Librarian Librarian { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }

    }
    public class UserLMap : ClassMap<UserL>
    {
        public UserLMap()
        {
            Id(x => x.Id);
            HasOne(x => x.Id);
            Map(x => x.Email);
            Map(x => x.Password);
        }
    }
}