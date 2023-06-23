using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace InformatorMVVM.Model;
public class Organizatorzy
{
    [Key]
    [Column("id_organizatora")]
    [Required]
    //kolumna w bazie bedzie miała nazwe id_organizatora a wartosc tej kolumny bedzie w FKID
    public int FKID { get; set; }

    [MaxLength(50)]
    public string ?nazwa_organizatora { get; set; }

    public virtual Tabela_Kont? id_konta { get; set; }
    public virtual ICollection<Wydarzenie> Wydarzenie { get; set; } = new List<Wydarzenie>();

}
