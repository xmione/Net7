﻿// <auto-generated />
using System;
using ContactInfoManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ContactInfoManagementSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230319054759_AddContactInfo")]
    partial class AddContactInfo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ContactInfoManagementSystem.Models.ContactInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BillingAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeliveryAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddresses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomePhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobilePhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkPhone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContactInfos");

                    b.HasData(
                        new
                        {
                            Id = new Guid("afe9dc95-e79b-4a66-8222-d7235c259bc9"),
                            BillingAddress = "BillingAddress 1",
                            DeliveryAddress = "DeliveryAddress 1",
                            EmailAddresses = "user1@test.com",
                            HomePhone = "1234564345",
                            MobilePhone = "3556351235",
                            WorkPhone = "4234452344"
                        },
                        new
                        {
                            Id = new Guid("d6b1e73b-c74e-4fc5-bf02-9ebf141b107b"),
                            BillingAddress = "BillingAddress 2",
                            DeliveryAddress = "DeliveryAddress 2",
                            EmailAddresses = "user2@test.com",
                            HomePhone = "1234564345",
                            MobilePhone = "3556351235",
                            WorkPhone = "4234452344"
                        },
                        new
                        {
                            Id = new Guid("5f386cb0-5653-4a2a-a50e-0a972e4942bb"),
                            BillingAddress = "BillingAddress 3",
                            DeliveryAddress = "DeliveryAddress 3",
                            EmailAddresses = "user3@test.com",
                            HomePhone = "1234564345",
                            MobilePhone = "3556351235",
                            WorkPhone = "4234452344"
                        },
                        new
                        {
                            Id = new Guid("d7fcb124-d06c-4cb0-b17d-2282a14a58a5"),
                            BillingAddress = "BillingAddress 4",
                            DeliveryAddress = "DeliveryAddress 4",
                            EmailAddresses = "user4@test.com",
                            HomePhone = "1234564345",
                            MobilePhone = "3556351235",
                            WorkPhone = "4234452344"
                        },
                        new
                        {
                            Id = new Guid("30f3cf53-186b-4d46-b964-1d72a44a29bd"),
                            BillingAddress = "BillingAddress 5",
                            DeliveryAddress = "DeliveryAddress 5",
                            EmailAddresses = "user5@test.com",
                            HomePhone = "1234564345",
                            MobilePhone = "3556351235",
                            WorkPhone = "4234452344"
                        });
                });

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
                            Id = new Guid("65342591-b3d6-4949-95c9-d93d3e1463c6"),
                            Description = "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,",
                            Instructor = "Christopher Nolan",
                            ReleaseDate = new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("b26afc7c-4e32-47b3-af78-3719e6c87693"),
                            Title = "Batman Begins"
                        },
                        new
                        {
                            Id = new Guid("3a945b2b-f5b1-4553-ba2c-55f54c323a20"),
                            Description = "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.",
                            Instructor = "Christopher Nolan",
                            ReleaseDate = new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("b26afc7c-4e32-47b3-af78-3719e6c87693"),
                            Title = "The Dark Knight"
                        },
                        new
                        {
                            Id = new Guid("ffb8b4a6-59ef-4fb3-95a6-2ec3fb96b66e"),
                            Description = "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.",
                            Instructor = "Christopher Nolan",
                            ReleaseDate = new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("b26afc7c-4e32-47b3-af78-3719e6c87693"),
                            Title = "The Dark Knight Rises"
                        },
                        new
                        {
                            Id = new Guid("5fc6ff36-2a02-4a98-a5d6-68d8ce5362f1"),
                            Description = "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.",
                            Instructor = "George Lucas",
                            ReleaseDate = new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("7ca9bb0e-2600-4af9-aab3-f44a15923e7b"),
                            Title = "Star Wars: Episode IV – A New Hope"
                        },
                        new
                        {
                            Id = new Guid("406ec7bf-73b5-4ff3-96ba-1f4b50950d2f"),
                            Description = "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.",
                            Instructor = "Irvin Kershner",
                            ReleaseDate = new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("7ca9bb0e-2600-4af9-aab3-f44a15923e7b"),
                            Title = "Star Wars: Episode V – The Empire Strikes Back"
                        },
                        new
                        {
                            Id = new Guid("986c9d8b-7bcb-4243-bcf3-4b3a7b87632f"),
                            Description = "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.",
                            Instructor = "Richard Marquand",
                            ReleaseDate = new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("7ca9bb0e-2600-4af9-aab3-f44a15923e7b"),
                            Title = "Star Wars: Episode VI – Return of the Jedi"
                        },
                        new
                        {
                            Id = new Guid("e0cd1c2b-a9ec-486c-aeeb-4feb9dc7a947"),
                            Description = "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).",
                            Instructor = "Cate Shortland",
                            ReleaseDate = new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("61e7bbd3-e721-435e-a338-bfc47a1684f3"),
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
                            Id = new Guid("b26afc7c-4e32-47b3-af78-3719e6c87693"),
                            Description = "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.",
                            Height = 1.9299999999999999,
                            Name = "Batman"
                        },
                        new
                        {
                            Id = new Guid("7ca9bb0e-2600-4af9-aab3-f44a15923e7b"),
                            Description = "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.",
                            Height = 1.7,
                            Name = "Luke Skywalker"
                        },
                        new
                        {
                            Id = new Guid("61e7bbd3-e721-435e-a338-bfc47a1684f3"),
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
                            Id = new Guid("ba0ac46d-8701-48d4-ab40-d317755eb8b9"),
                            Description = "He's always a step ahead.",
                            SuperPower = "Intellect.",
                            SuperheroId = new Guid("b26afc7c-4e32-47b3-af78-3719e6c87693")
                        },
                        new
                        {
                            Id = new Guid("d5f22d16-24cf-4a15-b228-28f5256abca7"),
                            Description = "Sublime fighting skills.",
                            SuperPower = "Fighting",
                            SuperheroId = new Guid("b26afc7c-4e32-47b3-af78-3719e6c87693")
                        },
                        new
                        {
                            Id = new Guid("0183065d-154a-4d26-ba37-28ee5f5255e1"),
                            Description = "He got a lot of money",
                            SuperPower = "Wealth.",
                            SuperheroId = new Guid("b26afc7c-4e32-47b3-af78-3719e6c87693")
                        },
                        new
                        {
                            Id = new Guid("c60cbbdb-d98d-43df-975a-945568bc760c"),
                            Description = "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.",
                            SuperPower = "Deflect blaster power.",
                            SuperheroId = new Guid("7ca9bb0e-2600-4af9-aab3-f44a15923e7b")
                        },
                        new
                        {
                            Id = new Guid("14c01d93-a149-4580-a8a5-6c44c7028f77"),
                            Description = "She's good at spying at people.",
                            SuperPower = "Espionage",
                            SuperheroId = new Guid("61e7bbd3-e721-435e-a338-bfc47a1684f3")
                        },
                        new
                        {
                            Id = new Guid("b2562795-a02e-4582-bf35-2eedef632869"),
                            Description = "She knows how to infiltrate the enemy.",
                            SuperPower = "Infiltration",
                            SuperheroId = new Guid("61e7bbd3-e721-435e-a338-bfc47a1684f3")
                        },
                        new
                        {
                            Id = new Guid("b7cd493f-b68e-41ce-a5d7-167df04ec8da"),
                            Description = "The knowledge of how to undermine others.",
                            SuperPower = "Subterfuge",
                            SuperheroId = new Guid("61e7bbd3-e721-435e-a338-bfc47a1684f3")
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
