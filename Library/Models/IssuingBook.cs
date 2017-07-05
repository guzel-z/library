using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;

namespace Library.Models
{
    public class IssuingBook
    {
        public virtual int Id { get; set; }
        public virtual Reader ReaderID { get; set; }
        public virtual Book BookID { get; set; }
        public virtual DateTime IssueDate { get; set; }
        public virtual DateTime ReturnDate { get; set; }
    }

    public class IssuingBookMap : ClassMap<IssuingBook>
    {
        public IssuingBookMap()
        {
            Id(x => x.Id);
            References(x => x.ReaderID);
            References(x => x.BookID);
            Map(x => x.IssueDate);
            Map(x => x.ReturnDate);
            
        }
    }
}