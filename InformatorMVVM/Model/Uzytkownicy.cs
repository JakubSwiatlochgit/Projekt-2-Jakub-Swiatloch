using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace InformatorMVVM.Model;
public class Uzytkownicy
{
    [Key]
    [Column("id_uzytkownika")]
    [Required]
    public int FKID { get; set; }

    [MaxLength(1019)]
    public int imie { get; set; }

    [MaxLength(51)]
    public int nazwisko { get; set; }

    public virtual ICollection<Rezerwacje> Rezerwacje { get; set; } = new List<Rezerwacje>();

    public virtual ICollection<Oceny_Uzytkownikow> Oceny_Uzytkownikow { get; set; } = new List<Oceny_Uzytkownikow>();

    public virtual Tabela_Kont? id_konta { get; set; }
}
