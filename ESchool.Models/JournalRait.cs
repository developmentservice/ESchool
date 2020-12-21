using System;
using System.Collections.Generic;
using System.Text;

namespace ESchool.Models
{
    public class JournalRait

    {
        public int Id { get; set; }
        public JournalMain jurnalMain { get; set; }
        public Person Person { get; set; }
        public int Rait { get; set; }
        public string Description { get; set; }

    }
}
