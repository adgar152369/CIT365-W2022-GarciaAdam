using System;
using System.ComponentModel.DataAnnotations;

namespace ScriptureJournal.Models
{
    public class Scripture
    {
        public int ID { get; set; }
        public string Book { get; set; } = string.Empty;
        public int Chapter { get; set; }
        public int Verse { get; set; }


        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }

        public string Notes { get; set; }
    }

}
