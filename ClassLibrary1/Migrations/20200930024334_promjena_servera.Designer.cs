// <auto-generated />
using System;
using ClassLibrary1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClassLibrary1.Migrations
{
    [DbContext(typeof(mojDbContext))]
    [Migration("20200930024334_promjena_servera")]
    partial class promjena_servera
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClassLibrary1.Models.BrojOsoba", b =>
                {
                    b.Property<int>("BrojOsobaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("brOsoba");

                    b.HasKey("BrojOsobaID");

                    b.ToTable("BrojOsoba");
                });

            modelBuilder.Entity("ClassLibrary1.Models.KapacitetStola", b =>
                {
                    b.Property<int>("KapacitetStolaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("maxBrStolica");

                    b.Property<int>("minBrStolica");

                    b.HasKey("KapacitetStolaID");

                    b.ToTable("KapacitetStola");
                });

            modelBuilder.Entity("ClassLibrary1.Models.Obavijest", b =>
                {
                    b.Property<int>("ObavijestID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naslov");

                    b.Property<string>("Sadrzaj");

                    b.Property<int?>("SlikaID");

                    b.Property<int?>("UserID");

                    b.Property<DateTime>("VrijemeObjave");

                    b.HasKey("ObavijestID");

                    b.HasIndex("SlikaID");

                    b.HasIndex("UserID");

                    b.ToTable("Obavijest");
                });

            modelBuilder.Entity("ClassLibrary1.Models.Poslovnica", b =>
                {
                    b.Property<int>("PoslovnicaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa");

                    b.Property<string>("Naziv")
                        .IsRequired();

                    b.Property<int?>("UserID");

                    b.HasKey("PoslovnicaID");

                    b.HasIndex("UserID");

                    b.ToTable("Poslovnica");
                });

            modelBuilder.Entity("ClassLibrary1.Models.Proizvod", b =>
                {
                    b.Property<int>("ProizvodID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cijena");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<int?>("SlikaID");

                    b.Property<int?>("TipProizvodaID");

                    b.Property<int?>("UserID");

                    b.HasKey("ProizvodID");

                    b.HasIndex("SlikaID");

                    b.HasIndex("TipProizvodaID");

                    b.HasIndex("UserID");

                    b.ToTable("Proizvod");
                });

            modelBuilder.Entity("ClassLibrary1.Models.Rezervacija", b =>
                {
                    b.Property<int>("RezervacijaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BrojOsobaID");

                    b.Property<string>("BrojTelefona")
                        .HasMaxLength(64);

                    b.Property<string>("DatumRezervacije");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("Ime")
                        .HasMaxLength(64);

                    b.Property<string>("Napomena")
                        .HasMaxLength(256);

                    b.Property<int?>("PoslovnicaID");

                    b.Property<string>("Prezime")
                        .HasMaxLength(64);

                    b.Property<int?>("TerminRezervacijeID");

                    b.Property<int?>("UserID");

                    b.Property<DateTime>("VrijemeZahtjeva");

                    b.HasKey("RezervacijaID");

                    b.HasIndex("BrojOsobaID");

                    b.HasIndex("PoslovnicaID");

                    b.HasIndex("TerminRezervacijeID");

                    b.HasIndex("UserID");

                    b.ToTable("Rezervacija");
                });

            modelBuilder.Entity("ClassLibrary1.Models.Slika", b =>
                {
                    b.Property<int>("SlikaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("UserID");

                    b.Property<DateTime>("datumPostavljanja");

                    b.Property<string>("lokacijaSlike")
                        .IsRequired();

                    b.Property<byte[]>("slika");

                    b.HasKey("SlikaID");

                    b.HasIndex("UserID");

                    b.ToTable("Slika");
                });

            modelBuilder.Entity("ClassLibrary1.Models.Stol", b =>
                {
                    b.Property<int>("StolID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Dostupan");

                    b.Property<int?>("KapacitetStolaID");

                    b.Property<int?>("PoslovnicaID");

                    b.HasKey("StolID");

                    b.HasIndex("KapacitetStolaID");

                    b.HasIndex("PoslovnicaID");

                    b.ToTable("Stol");
                });

            modelBuilder.Entity("ClassLibrary1.Models.TerminRezervacije", b =>
                {
                    b.Property<int>("TerminRezervacijeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("terminRez")
                        .IsRequired();

                    b.HasKey("TerminRezervacijeID");

                    b.ToTable("TerminRezervacije");
                });

            modelBuilder.Entity("ClassLibrary1.Models.TipProizvoda", b =>
                {
                    b.Property<int>("TipProizvodaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("TipProizvodaID");

                    b.ToTable("TipProizvoda");
                });

            modelBuilder.Entity("ClassLibrary1.Models.Uloga", b =>
                {
                    b.Property<int>("ulogaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nazivUloge")
                        .IsRequired();

                    b.HasKey("ulogaID");

                    b.ToTable("Uloga");
                });

            modelBuilder.Entity("ClassLibrary1.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("UlogaID");

                    b.Property<string>("adresaStanovanja")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("brojTelefona")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("ime")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("prezime")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("UserID");

                    b.HasIndex("UlogaID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ClassLibrary1.Models.Obavijest", b =>
                {
                    b.HasOne("ClassLibrary1.Models.Slika", "Slika")
                        .WithMany()
                        .HasForeignKey("SlikaID");

                    b.HasOne("ClassLibrary1.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("ClassLibrary1.Models.Poslovnica", b =>
                {
                    b.HasOne("ClassLibrary1.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("ClassLibrary1.Models.Proizvod", b =>
                {
                    b.HasOne("ClassLibrary1.Models.Slika", "Slika")
                        .WithMany()
                        .HasForeignKey("SlikaID");

                    b.HasOne("ClassLibrary1.Models.TipProizvoda", "TipProizvoda")
                        .WithMany()
                        .HasForeignKey("TipProizvodaID");

                    b.HasOne("ClassLibrary1.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("ClassLibrary1.Models.Rezervacija", b =>
                {
                    b.HasOne("ClassLibrary1.Models.BrojOsoba", "BrojOsoba")
                        .WithMany()
                        .HasForeignKey("BrojOsobaID");

                    b.HasOne("ClassLibrary1.Models.Poslovnica", "Poslovnica")
                        .WithMany()
                        .HasForeignKey("PoslovnicaID");

                    b.HasOne("ClassLibrary1.Models.TerminRezervacije", "TerminRezervacije")
                        .WithMany()
                        .HasForeignKey("TerminRezervacijeID");

                    b.HasOne("ClassLibrary1.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("ClassLibrary1.Models.Slika", b =>
                {
                    b.HasOne("ClassLibrary1.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("ClassLibrary1.Models.Stol", b =>
                {
                    b.HasOne("ClassLibrary1.Models.KapacitetStola", "KapacitetStola")
                        .WithMany()
                        .HasForeignKey("KapacitetStolaID");

                    b.HasOne("ClassLibrary1.Models.Poslovnica", "Poslovnica")
                        .WithMany()
                        .HasForeignKey("PoslovnicaID");
                });

            modelBuilder.Entity("ClassLibrary1.Models.User", b =>
                {
                    b.HasOne("ClassLibrary1.Models.Uloga", "Uloga")
                        .WithMany()
                        .HasForeignKey("UlogaID");
                });
#pragma warning restore 612, 618
        }
    }
}
