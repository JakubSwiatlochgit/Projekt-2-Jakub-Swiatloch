using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace InformatorMVVM.Model;
public class Rezerwacje
{
    [Key]
    [Column("id_rezerwacji")]
    [Required]
    public int FKID { get; set; }

    [MaxLength(100_000)]
    public int ilosc_miejsc { get; set; } 

    public virtual Wydarzenie id_wydarzenia { get; set; }

    public virtual Uzytkownicy? id_uzytkownika { get; set; }

}
