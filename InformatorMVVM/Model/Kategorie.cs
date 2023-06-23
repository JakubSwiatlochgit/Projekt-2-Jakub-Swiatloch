using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace InformatorMVVM.Model;
public class Kategorie
{
    [Key]
    [Column("id_kategorii")]
    [Required]
    public int FKID { get; set; }

    [MaxLength(50)]
    public string? nazwa_kategorii { get; set; }

    public virtual ICollection<Wydarzenie> Wydarzenie { get; set; } = new List<Wydarzenie>();

}
