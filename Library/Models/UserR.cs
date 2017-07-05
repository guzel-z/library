using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;

namespace Library.Models
{
    public class UserR
    {
        public virtual int Id { get; set; }
        public virtual Reader Reader { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
    }
    public class UserRMap : ClassMap<UserR>
    {
        public UserRMap()
        {
            Id(x => x.Id);
            HasOne(x => x.Reader);
            Map(x => x.Email);
            Map(x => x.Password);
        }
    }
}