using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace InformatorMVVM.Model;
public class Tabela_Kont
{
    [Key]
    [Column("id_konta")]
    [Required]
    public int FKID { get; set; }

    [MaxLength(100)]
    public string? email { get; set; }

    [MaxLength(50)]
    public string ?haslo { get; set; }

    [MaxLength(50)]
    public string ?adres { get; set; }
    public virtual ICollection<Organizatorzy> Organizatorzy { get; set; } = new List<Organizatorzy>();
    public virtual ICollection<Uzytkownicy> Uzytkownicy { get; set; } = new List<Uzytkownicy>();

}
