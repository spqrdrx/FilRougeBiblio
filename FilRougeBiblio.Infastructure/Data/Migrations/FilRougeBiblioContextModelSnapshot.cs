﻿// <auto-generated />
using System;
using FilRougeBiblio.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FilRougeBiblio.Infrastructure.Data.Migrations
{
    [DbContext(typeof(FilRougeBiblioContext))]
    partial class FilRougeBiblioContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AuteurLivre", b =>
                {
                    b.Property<int>("AuteursId")
                        .HasColumnType("int");

                    b.Property<int>("LivresId")
                        .HasColumnType("int");

                    b.HasKey("AuteursId", "LivresId");

                    b.HasIndex("LivresId");

                    b.ToTable("AuteurLivre");
                });

            modelBuilder.Entity("FilRougeBiblio.Core.Entities.Auteur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Auteurs");
                });

            modelBuilder.Entity("FilRougeBiblio.Core.Entities.Bibliothecaire", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotDePasse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Bibliothecaires");
                });

            modelBuilder.Entity("FilRougeBiblio.Core.Entities.Emprunt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("DateEmprunt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateRetour")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateRetourReel")
                        .HasColumnType("datetime2");

                    b.Property<int>("ExemplaireId")
                        .HasColumnType("int");

                    b.Property<int>("LecteurId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExemplaireId");

                    b.HasIndex("LecteurId");

                    b.ToTable("Emprunts");
                });

            modelBuilder.Entity("FilRougeBiblio.Core.Entities.Exemplaire", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("LivreId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("MiseEnService")
                        .HasColumnType("datetime2");

                    b.Property<string>("NumeroInventaire")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LivreId");

                    b.ToTable("Exemplaires");
                });

            modelBuilder.Entity("FilRougeBiblio.Core.Entities.Lecteur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Cotisation")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Lecteurs");
                });

            modelBuilder.Entity("FilRougeBiblio.Core.Entities.Livre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Livres");
                });

            modelBuilder.Entity("FilRougeBiblio.Core.Entities.MotClef", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MotClefs");
                });

            modelBuilder.Entity("FilRougeBiblio.Core.Entities.Theme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Themes");
                });

            modelBuilder.Entity("LivreMotClef", b =>
                {
                    b.Property<int>("LivresId")
                        .HasColumnType("int");

                    b.Property<int>("TagsId")
                        .HasColumnType("int");

                    b.HasKey("LivresId", "TagsId");

                    b.HasIndex("TagsId");

                    b.ToTable("LivreMotClef");
                });

            modelBuilder.Entity("LivreTheme", b =>
                {
                    b.Property<int>("LivresId")
                        .HasColumnType("int");

                    b.Property<int>("ThemesId")
                        .HasColumnType("int");

                    b.HasKey("LivresId", "ThemesId");

                    b.HasIndex("ThemesId");

                    b.ToTable("LivreTheme");
                });

            modelBuilder.Entity("AuteurLivre", b =>
                {
                    b.HasOne("FilRougeBiblio.Core.Entities.Auteur", null)
                        .WithMany()
                        .HasForeignKey("AuteursId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilRougeBiblio.Core.Entities.Livre", null)
                        .WithMany()
                        .HasForeignKey("LivresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FilRougeBiblio.Core.Entities.Emprunt", b =>
                {
                    b.HasOne("FilRougeBiblio.Core.Entities.Exemplaire", "Exemplaire")
                        .WithMany()
                        .HasForeignKey("ExemplaireId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilRougeBiblio.Core.Entities.Lecteur", "Lecteur")
                        .WithMany("ListEmprunts")
                        .HasForeignKey("LecteurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exemplaire");

                    b.Navigation("Lecteur");
                });

            modelBuilder.Entity("FilRougeBiblio.Core.Entities.Exemplaire", b =>
                {
                    b.HasOne("FilRougeBiblio.Core.Entities.Livre", "Livre")
                        .WithMany("Exemplaires")
                        .HasForeignKey("LivreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Livre");
                });

            modelBuilder.Entity("LivreMotClef", b =>
                {
                    b.HasOne("FilRougeBiblio.Core.Entities.Livre", null)
                        .WithMany()
                        .HasForeignKey("LivresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilRougeBiblio.Core.Entities.MotClef", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LivreTheme", b =>
                {
                    b.HasOne("FilRougeBiblio.Core.Entities.Livre", null)
                        .WithMany()
                        .HasForeignKey("LivresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilRougeBiblio.Core.Entities.Theme", null)
                        .WithMany()
                        .HasForeignKey("ThemesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FilRougeBiblio.Core.Entities.Lecteur", b =>
                {
                    b.Navigation("ListEmprunts");
                });

            modelBuilder.Entity("FilRougeBiblio.Core.Entities.Livre", b =>
                {
                    b.Navigation("Exemplaires");
                });
#pragma warning restore 612, 618
        }
    }
}
