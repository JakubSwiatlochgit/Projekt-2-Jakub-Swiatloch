using InformatorMVVM.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Linq;

namespace InformatorMVVM.Model
{
    public class InformatorDbContext : DbContext
    {
        public InformatorDbContext()
        {
            if (this.Database.EnsureCreated())
                SeedData();
        }

        public void DodajOrganizatora(string nazwaOrganizatora, int idKonta)
        {
            var organizator = new Organizatorzy { nazwa_organizatora = nazwaOrganizatora };
            Organizatorzy.Attach(organizator);

            var konto = Tabela_Kont.Find(idKonta);
            organizator.id_konta = konto;

            SaveChanges();
        }

        public InformatorDbContext(DbContextOptions<InformatorDbContext> options) : base(options) { }

        public virtual DbSet<Wydarzenie> Wydarzenie { get; set; }
        public virtual DbSet<Rezerwacje> Rezerwacje { get; set; }
        public virtual DbSet<Uzytkownicy> Uzytkownicy { get; set; }
        public virtual DbSet<Tabela_Kont> Tabela_Kont { get; set; }
        public virtual DbSet<Organizatorzy> Organizatorzy { get; set; }
        public virtual DbSet<Kategorie> Kategorie { get; set; }
        public virtual DbSet<Oceny_Uzytkownikow> Oceny_Uzytkownikow { get; set; }

        
        public void SeedData()
        {

            Kategorie.Add(new Kategorie { nazwa_kategorii = "Teatr" });
            Kategorie.Add(new Kategorie { nazwa_kategorii = "Kino" });
            Kategorie.Add(new Kategorie { nazwa_kategorii = "Wystep" });
            Kategorie.Add(new Kategorie { nazwa_kategorii = "Wystep2" });
            Kategorie.Add(new Kategorie { nazwa_kategorii = "Inna Kategoria" });
            Kategorie.Add(new Kategorie { nazwa_kategorii = "Kategoria 3" });
            SaveChanges();

            Tabela_Kont.Add(new Tabela_Kont { email = "email1@spoko.pl", haslo = "haslo1", adres = "adres1" });
            Tabela_Kont.Add(new Tabela_Kont { email = "email2@spoko.pl", haslo = "haslo12", adres = "adres12" });
            Tabela_Kont.Add(new Tabela_Kont { email = "email3@spoko.pl", haslo = "haslo123", adres = "adres123" });
            Tabela_Kont.Add(new Tabela_Kont { email = "email4@spoko.pl", haslo = "haslo1234", adres = "adres1234" });
            Tabela_Kont.Add(new Tabela_Kont { email = "email5@spoko.pl", haslo = "haslo12345", adres = "adres12345" });
            SaveChanges();

            // Dodawanie Organizatora z kluczem obcym
            DodajOrganizatora("Organizator 1", 1);
            DodajOrganizatora("Organizator 2", 2);
            DodajOrganizatora("Organizator 3", 3);
            DodajOrganizatora("Organizator 4", 4);
            DodajOrganizatora("Organizator 5", 5);

            var kategoria = Kategorie.FirstOrDefault();
            var organizator = Organizatorzy.FirstOrDefault();
            if (kategoria != null || organizator != null)
            {

                Wydarzenie.Add(new Wydarzenie
                {
                    nazwa_wydarzenia = "Wydarzenie 1",
                    opis = "Opis Wydarzenia 1",
                    data_i_godzina_rozpoczecia = DateTime.Today.AddDays(-2),
                    data_i_godzina_zakonczenia = DateTime.Today,
                    id_kategorii = Kategorie.Find(1),
                    id_organizatora = Organizatorzy.Find(1)
                });
                Wydarzenie.Add(new Wydarzenie
                {
                    nazwa_wydarzenia = "Wydarzenie 2",
                    opis = "Opis Wydarzenia 2",
                    data_i_godzina_rozpoczecia = DateTime.Today.AddDays(-3),
                    data_i_godzina_zakonczenia = DateTime.Today.AddDays(2),
                    id_kategorii = Kategorie.Find(2), 
                    id_organizatora = Organizatorzy.Find(2)  
                });

                SaveChanges();

            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("" +
                "Data Source=(localdb)\\LocalServer;" +
                "Database=InformatorDB;" +
                "Trusted_Connection=True;" +
                "TrustServerCertificate=True;");

        }
    }
}
