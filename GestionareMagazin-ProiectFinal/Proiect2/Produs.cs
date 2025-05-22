using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using Proiect2;

namespace Proiect2
{
    [Table("Produs")]

    public class Produs
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Denumire { get; set; }
        [Required]
        public string Descriere { get; set; }
        [Required]
        public string DataIntrare { get; set; }
        [Required]
        public string DataExpirare { get; set; }
        [Required]
        public int Cantitate { get; set; }
        public int IdCategorie { get; set; }

        [ForeignKey("IdCategorie")]
        public virtual CategorieProdus CategorieProdus { get; set; }
    }

    [Table("CategorieProdus")]
    public class CategorieProdus
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Denumire { get; set; }
 
    }

    [Table("IstoricVanzari")]
    public class IstoricVanzari
    {
     [Key]
      public int Id { set; get; }
      public int IdProdus { set; get; }

      [Required]
      public int Cantitate { set; get; }
  

     [ForeignKey("IdProdus")]
      public Produs Produs { get; set; }
    }
    [Table("Utilizator")]
    public class Utilizator
    {
        [Key]
        public int Id { set; get; }
        [Required]
        public string Nume { set; get; }
        [Required]
        public string Parola {  set; get; }
        [Required]
        public string Email {  set; get; }
        [Required]
        public int Admin { set; get; }

    }
    

        public class MyDBContext : DbContext
    {
        public MyDBContext() : base("name=MyDBContext")
        { }
        public DbSet<Produs> Produs { get; set; }
        public DbSet<CategorieProdus> CategorieProdus { get;set; }
        public DbSet<IstoricVanzari> IstoricVanzari {  get; set; }
        public DbSet<Utilizator> Utilizator { get; set; }
    }
}
