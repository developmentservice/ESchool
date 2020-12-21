using System;

namespace ESchool.Models
{
    public class JournalMain
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public SchoolEvent schoolEvent { get; set; }
    }
}
