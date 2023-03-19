﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ContactInfoManagementSystem.Data;

#nullable disable

namespace ContactInfoManagementSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220122115234_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ContactInfoManagementSystem.Models.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instructor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("SuperheroId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SuperheroId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("191895b4-7207-40a2-9203-24d1e65b3991"),
                            Description = "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,",
                            Instructor = "Christopher Nolan",
                            ReleaseDate = new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("bc9b3642-25cd-4b33-af7c-4861519bd7d4"),
                            Title = "Batman Begins"
                        },
                        new
                        {
                            Id = new Guid("da5d6fc6-a958-4892-b243-f1ec229456cc"),
                            Description = "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.",
                            Instructor = "Christopher Nolan",
                            ReleaseDate = new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("bc9b3642-25cd-4b33-af7c-4861519bd7d4"),
                            Title = "The Dark Knight"
                        },
                        new
                        {
                            Id = new Guid("1f9119bf-e246-4d7e-b5b5-a88749baf24a"),
                            Description = "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.",
                            Instructor = "Christopher Nolan",
                            ReleaseDate = new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("bc9b3642-25cd-4b33-af7c-4861519bd7d4"),
                            Title = "The Dark Knight Rises"
                        },
                        new
                        {
                            Id = new Guid("73b5e8fb-4735-48cd-ae70-ec89618d77a8"),
                            Description = "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.",
                            Instructor = "George Lucas",
                            ReleaseDate = new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("aed332fe-d264-4f9f-9a54-ecf8a878dbbe"),
                            Title = "Star Wars: Episode IV – A New Hope"
                        },
                        new
                        {
                            Id = new Guid("ee989106-2bf5-48b1-840d-350c3d26b34b"),
                            Description = "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.",
                            Instructor = "Irvin Kershner",
                            ReleaseDate = new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("aed332fe-d264-4f9f-9a54-ecf8a878dbbe"),
                            Title = "Star Wars: Episode V – The Empire Strikes Back"
                        },
                        new
                        {
                            Id = new Guid("e500d81b-6785-46fa-aa14-1d64f9abc8c0"),
                            Description = "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.",
                            Instructor = "Richard Marquand",
                            ReleaseDate = new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("aed332fe-d264-4f9f-9a54-ecf8a878dbbe"),
                            Title = "Star Wars: Episode VI – Return of the Jedi"
                        },
                        new
                        {
                            Id = new Guid("14ad1d2f-852e-469e-94c2-7d969702eef5"),
                            Description = "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).",
                            Instructor = "Cate Shortland",
                            ReleaseDate = new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("619b7fee-9dfc-424a-b2af-e9dc2f89f0a2"),
                            Title = "Black Widow"
                        });
                });

            modelBuilder.Entity("ContactInfoManagementSystem.Models.Superhero", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Superheroes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bc9b3642-25cd-4b33-af7c-4861519bd7d4"),
                            Description = "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.",
                            Height = 1.9299999999999999,
                            Name = "Batman"
                        },
                        new
                        {
                            Id = new Guid("aed332fe-d264-4f9f-9a54-ecf8a878dbbe"),
                            Description = "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.",
                            Height = 1.7,
                            Name = "Luke Skywalker"
                        },
                        new
                        {
                            Id = new Guid("619b7fee-9dfc-424a-b2af-e9dc2f89f0a2"),
                            Description = "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.",
                            Height = 1.7,
                            Name = "Black Widow"
                        });
                });

            modelBuilder.Entity("ContactInfoManagementSystem.Models.Superpower", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SuperPower")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SuperheroId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SuperheroId");

                    b.ToTable("Superpowers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6248fae6-f98a-4775-b534-d12c96da8b12"),
                            Description = "He's always a step ahead.",
                            SuperPower = "Intellect.",
                            SuperheroId = new Guid("bc9b3642-25cd-4b33-af7c-4861519bd7d4")
                        },
                        new
                        {
                            Id = new Guid("107f699d-7bb4-489d-8694-f3017727284e"),
                            Description = "Sublime fighting skills.",
                            SuperPower = "Fighting",
                            SuperheroId = new Guid("bc9b3642-25cd-4b33-af7c-4861519bd7d4")
                        },
                        new
                        {
                            Id = new Guid("cafd071d-9f9a-4cf4-af20-894d5af75ab5"),
                            Description = "He got a lot of money",
                            SuperPower = "Wealth.",
                            SuperheroId = new Guid("bc9b3642-25cd-4b33-af7c-4861519bd7d4")
                        },
                        new
                        {
                            Id = new Guid("c6618c14-929b-4568-b12f-ea7f7ebb748b"),
                            Description = "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.",
                            SuperPower = "Deflect blaster power.",
                            SuperheroId = new Guid("aed332fe-d264-4f9f-9a54-ecf8a878dbbe")
                        },
                        new
                        {
                            Id = new Guid("987eef1c-e372-4b6a-8e6f-1dafe6e1c3ad"),
                            Description = "She's good at spying at people.",
                            SuperPower = "Espionage",
                            SuperheroId = new Guid("619b7fee-9dfc-424a-b2af-e9dc2f89f0a2")
                        },
                        new
                        {
                            Id = new Guid("57b1e4bf-3818-4bd1-a854-8c61070d057c"),
                            Description = "She knows how to infiltrate the enemy.",
                            SuperPower = "Infiltration",
                            SuperheroId = new Guid("619b7fee-9dfc-424a-b2af-e9dc2f89f0a2")
                        },
                        new
                        {
                            Id = new Guid("9b17d0d5-8eba-4075-9d91-bc281ef3ac4b"),
                            Description = "The knowledge of how to undermine others.",
                            SuperPower = "Subterfuge",
                            SuperheroId = new Guid("619b7fee-9dfc-424a-b2af-e9dc2f89f0a2")
                        });
                });

            modelBuilder.Entity("ContactInfoManagementSystem.Models.Movie", b =>
                {
                    b.HasOne("ContactInfoManagementSystem.Models.Superhero", "Superhero")
                        .WithMany("Movies")
                        .HasForeignKey("SuperheroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Superhero");
                });

            modelBuilder.Entity("ContactInfoManagementSystem.Models.Superpower", b =>
                {
                    b.HasOne("ContactInfoManagementSystem.Models.Superhero", "Superhero")
                        .WithMany("Superpowers")
                        .HasForeignKey("SuperheroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Superhero");
                });

            modelBuilder.Entity("ContactInfoManagementSystem.Models.Superhero", b =>
                {
                    b.Navigation("Movies");

                    b.Navigation("Superpowers");
                });
#pragma warning restore 612, 618
        }
    }
}
