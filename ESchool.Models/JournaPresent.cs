using System;
using System.Collections.Generic;
using System.Text;

namespace ESchool.Models
{
    public class JournaPresent
    {
        public int Id { get; set; }
        public JournalMain jurnalMain { get; set; }
        public Person Person { get; set; }
        public bool Present { get; set; }
        public string Description { get; set; }
    }
}
