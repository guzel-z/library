using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;

namespace Library.Models
{
    public class Reader
    {
        public virtual int Id { get; set; }
        public virtual string Surname { get; set; }
        public virtual string Name { get; set; }
        public virtual string MiddleName { get; set; }
        public virtual int PhoneNumber { get; set; }
        public virtual string BirthDate { get; set; }
        public virtual string Address { get; set; }
        private UserR _userR;
        public virtual UserR UserR
        {
            get { return _userR ?? (_userR = new UserR()); }
            set { _userR = value; }
        }
        public virtual ISet<IssuingBook> IssuingBooks { get; set; }
        public Reader()
        {
            IssuingBooks = new HashSet<IssuingBook>();
        }
    }

    public class ReaderMap : ClassMap<Reader>
    {
        public ReaderMap()
        {
            Id(x => x.Id);
            Map(x => x.Surname);
            Map(x => x.Name);
            Map(x => x.MiddleName);
            Map(x => x.PhoneNumber);
            Map(x => x.BirthDate);
            Map(x => x.Address);
            HasOne(x => x.UserR).Cascade.All().Constrained();
            HasMany(x => x.IssuingBooks).LazyLoad().Inverse().Cascade.All();
        }
    }
}