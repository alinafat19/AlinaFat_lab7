using System;
using System.ComponentModel.DataAnnotations;
using SQLite;

namespace AlinaFat.Models
{
    public class ShopList
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        // Specifică namespace-ul complet pentru MaxLength din DataAnnotations
        [System.ComponentModel.DataAnnotations.MaxLength(250), Unique]
        public string Description { get; set; }

        public DateTime Date { get; set; }
    }
}
