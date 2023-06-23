using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace InformatorMVVM.Model;
public class Wydarzenie{
    [Key]
    [Column("id_wydarzenia")]
    [Required]
    public int FKID { get; set; }

    [MaxLength(50)]
    public string ?nazwa_wydarzenia { get; set; }

    [MaxLength(250)]
    public string ?opis { get; set; }

    public DateTime data_i_godzina_rozpoczecia { get; set; }

    public DateTime data_i_godzina_zakonczenia { get; set; }

    //1..N (Wydarzenia-> Rezerwacje)
    public virtual ICollection<Rezerwacje> Rezerwacje { get; set; } = new List<Rezerwacje>();
    public virtual ICollection<Oceny_Uzytkownikow> Oceny_Uzytkownikow { get; set; } = new List<Oceny_Uzytkownikow>();

    public virtual Kategorie? id_kategorii { get; set; }
    public virtual Organizatorzy? id_organizatora { get; set; }

}
