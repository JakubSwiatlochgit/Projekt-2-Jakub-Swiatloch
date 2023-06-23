﻿// <auto-generated />
using System;
using InformatorMVVM.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InformatorMVVM.Migrations
{
    [DbContext(typeof(InformatorDbContext))]
    [Migration("20230623154906_Test")]
    partial class Test
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InformatorMVVM.Model.Kategorie", b =>
                {
                    b.Property<int>("FKID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_kategorii");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FKID"));

                    b.Property<string>("nazwa_kategorii")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("FKID");

                    b.ToTable("Kategorie");
                });

            modelBuilder.Entity("InformatorMVVM.Model.Oceny_Uzytkownikow", b =>
                {
                    b.Property<int>("FKID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_oceny");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FKID"));

                    b.Property<int?>("id_uzytkownikaFKID")
                        .HasColumnType("int");

                    b.Property<int?>("id_wydarzeniaFKID")
                        .HasColumnType("int");

                    b.Property<int>("ocena")
                        .HasMaxLength(5)
                        .HasColumnType("int");

                    b.HasKey("FKID");

                    b.HasIndex("id_uzytkownikaFKID");

                    b.HasIndex("id_wydarzeniaFKID");

                    b.ToTable("Oceny_Uzytkownikow");
                });

            modelBuilder.Entity("InformatorMVVM.Model.Organizatorzy", b =>
                {
                    b.Property<int>("FKID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_organizatora");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FKID"));

                    b.Property<int?>("id_kontaFKID")
                        .HasColumnType("int");

                    b.Property<string>("nazwa_organizatora")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("FKID");

                    b.HasIndex("id_kontaFKID");

                    b.ToTable("Organizatorzy");
                });

            modelBuilder.Entity("InformatorMVVM.Model.Rezerwacje", b =>
                {
                    b.Property<int>("FKID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_rezerwacji");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FKID"));

                    b.Property<int?>("id_uzytkownikaFKID")
                        .HasColumnType("int");

                    b.Property<int>("id_wydarzeniaFKID")
                        .HasColumnType("int");

                    b.Property<int>("ilosc_miejsc")
                        .HasMaxLength(100000)
                        .HasColumnType("int");

                    b.HasKey("FKID");

                    b.HasIndex("id_uzytkownikaFKID");

                    b.HasIndex("id_wydarzeniaFKID");

                    b.ToTable("Rezerwacje");
                });

            modelBuilder.Entity("InformatorMVVM.Model.Tabela_Kont", b =>
                {
                    b.Property<int>("FKID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_konta");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FKID"));

                    b.Property<string>("adres")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("haslo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("FKID");

                    b.ToTable("Tabela_Kont");
                });

            modelBuilder.Entity("InformatorMVVM.Model.Uzytkownicy", b =>
                {
                    b.Property<int>("FKID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_uzytkownika");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FKID"));

                    b.Property<int?>("id_kontaFKID")
                        .HasColumnType("int");

                    b.Property<int>("imie")
                        .HasMaxLength(1019)
                        .HasColumnType("int");

                    b.Property<int>("nazwisko")
                        .HasMaxLength(51)
                        .HasColumnType("int");

                    b.HasKey("FKID");

                    b.HasIndex("id_kontaFKID");

                    b.ToTable("Uzytkownicy");
                });

            modelBuilder.Entity("InformatorMVVM.Model.Wydarzenie", b =>
                {
                    b.Property<int>("FKID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_wydarzenia");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FKID"));

                    b.Property<DateTime>("data_i_godzina_rozpoczecia")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("data_i_godzina_zakonczenia")
                        .HasColumnType("datetime2");

                    b.Property<int?>("id_kategoriiFKID")
                        .HasColumnType("int");

                    b.Property<int?>("id_organizatoraFKID")
                        .HasColumnType("int");

                    b.Property<string>("nazwa_wydarzenia")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("opis")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("FKID");

                    b.HasIndex("id_kategoriiFKID");

                    b.HasIndex("id_organizatoraFKID");

                    b.ToTable("Wydarzenie");
                });

            modelBuilder.Entity("InformatorMVVM.Model.Oceny_Uzytkownikow", b =>
                {
                    b.HasOne("InformatorMVVM.Model.Uzytkownicy", "id_uzytkownika")
                        .WithMany("Oceny_Uzytkownikow")
                        .HasForeignKey("id_uzytkownikaFKID");

                    b.HasOne("InformatorMVVM.Model.Wydarzenie", "id_wydarzenia")
                        .WithMany("Oceny_Uzytkownikow")
                        .HasForeignKey("id_wydarzeniaFKID");

                    b.Navigation("id_uzytkownika");

                    b.Navigation("id_wydarzenia");
                });

            modelBuilder.Entity("InformatorMVVM.Model.Organizatorzy", b =>
                {
                    b.HasOne("InformatorMVVM.Model.Tabela_Kont", "id_konta")
                        .WithMany("Organizatorzy")
                        .HasForeignKey("id_kontaFKID");

                    b.Navigation("id_konta");
                });

            modelBuilder.Entity("InformatorMVVM.Model.Rezerwacje", b =>
                {
                    b.HasOne("InformatorMVVM.Model.Uzytkownicy", "id_uzytkownika")
                        .WithMany("Rezerwacje")
                        .HasForeignKey("id_uzytkownikaFKID");

                    b.HasOne("InformatorMVVM.Model.Wydarzenie", "id_wydarzenia")
                        .WithMany("Rezerwacje")
                        .HasForeignKey("id_wydarzeniaFKID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("id_uzytkownika");

                    b.Navigation("id_wydarzenia");
                });

            modelBuilder.Entity("InformatorMVVM.Model.Uzytkownicy", b =>
                {
                    b.HasOne("InformatorMVVM.Model.Tabela_Kont", "id_konta")
                        .WithMany("Uzytkownicy")
                        .HasForeignKey("id_kontaFKID");

                    b.Navigation("id_konta");
                });

            modelBuilder.Entity("InformatorMVVM.Model.Wydarzenie", b =>
                {
                    b.HasOne("InformatorMVVM.Model.Kategorie", "id_kategorii")
                        .WithMany("Wydarzenie")
                        .HasForeignKey("id_kategoriiFKID");

                    b.HasOne("InformatorMVVM.Model.Organizatorzy", "id_organizatora")
                        .WithMany("Wydarzenie")
                        .HasForeignKey("id_organizatoraFKID");

                    b.Navigation("id_kategorii");

                    b.Navigation("id_organizatora");
                });

            modelBuilder.Entity("InformatorMVVM.Model.Kategorie", b =>
                {
                    b.Navigation("Wydarzenie");
                });

            modelBuilder.Entity("InformatorMVVM.Model.Organizatorzy", b =>
                {
                    b.Navigation("Wydarzenie");
                });

            modelBuilder.Entity("InformatorMVVM.Model.Tabela_Kont", b =>
                {
                    b.Navigation("Organizatorzy");

                    b.Navigation("Uzytkownicy");
                });

            modelBuilder.Entity("InformatorMVVM.Model.Uzytkownicy", b =>
                {
                    b.Navigation("Oceny_Uzytkownikow");

                    b.Navigation("Rezerwacje");
                });

            modelBuilder.Entity("InformatorMVVM.Model.Wydarzenie", b =>
                {
                    b.Navigation("Oceny_Uzytkownikow");

                    b.Navigation("Rezerwacje");
                });
#pragma warning restore 612, 618
        }
    }
}
