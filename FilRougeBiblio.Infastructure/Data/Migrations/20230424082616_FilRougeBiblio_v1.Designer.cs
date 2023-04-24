﻿// <auto-generated />
using System;
using FilRougeBiblio.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FilRougeBiblio.Infrastructure.Data.Migrations
{
    [DbContext(typeof(FilRougeBiblioContext))]
    [Migration("20230424082616_FilRougeBiblio_v1")]
    partial class FilRougeBiblio_v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FilRougeBiblio.Core.Entities.Auteur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("LivreId")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LivreId");

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

                    b.Property<int?>("LivreId")
                        .HasColumnType("int");

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LivreId");

                    b.ToTable("MotsClefs");
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

                    b.Property<int?>("LivreId")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LivreId");

                    b.ToTable("Themes");
                });

            modelBuilder.Entity("FilRougeBiblio.Core.Entities.Auteur", b =>
                {
                    b.HasOne("FilRougeBiblio.Core.Entities.Livre", null)
                        .WithMany("Auteurs")
                        .HasForeignKey("LivreId");
                });

            modelBuilder.Entity("FilRougeBiblio.Core.Entities.Emprunt", b =>
                {
                    b.HasOne("FilRougeBiblio.Core.Entities.Exemplaire", "Exemplaire")
                        .WithMany()
                        .HasForeignKey("ExemplaireId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilRougeBiblio.Core.Entities.Lecteur", "Lecteur")
                        .WithMany()
                        .HasForeignKey("LecteurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exemplaire");

                    b.Navigation("Lecteur");
                });

            modelBuilder.Entity("FilRougeBiblio.Core.Entities.Exemplaire", b =>
                {
                    b.HasOne("FilRougeBiblio.Core.Entities.Livre", "Livre")
                        .WithMany()
                        .HasForeignKey("LivreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Livre");
                });

            modelBuilder.Entity("FilRougeBiblio.Core.Entities.MotClef", b =>
                {
                    b.HasOne("FilRougeBiblio.Core.Entities.Livre", null)
                        .WithMany("Tags")
                        .HasForeignKey("LivreId");
                });

            modelBuilder.Entity("FilRougeBiblio.Core.Entities.Theme", b =>
                {
                    b.HasOne("FilRougeBiblio.Core.Entities.Livre", null)
                        .WithMany("Themes")
                        .HasForeignKey("LivreId");
                });

            modelBuilder.Entity("FilRougeBiblio.Core.Entities.Livre", b =>
                {
                    b.Navigation("Auteurs");

                    b.Navigation("Tags");

                    b.Navigation("Themes");
                });
#pragma warning restore 612, 618
        }
    }
}
