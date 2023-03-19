using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactInfoManagementSystem.Migrations
{
    public partial class AddContactInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("14ad1d2f-852e-469e-94c2-7d969702eef5"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("191895b4-7207-40a2-9203-24d1e65b3991"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("1f9119bf-e246-4d7e-b5b5-a88749baf24a"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("73b5e8fb-4735-48cd-ae70-ec89618d77a8"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("da5d6fc6-a958-4892-b243-f1ec229456cc"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e500d81b-6785-46fa-aa14-1d64f9abc8c0"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ee989106-2bf5-48b1-840d-350c3d26b34b"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("107f699d-7bb4-489d-8694-f3017727284e"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("57b1e4bf-3818-4bd1-a854-8c61070d057c"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("6248fae6-f98a-4775-b534-d12c96da8b12"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("987eef1c-e372-4b6a-8e6f-1dafe6e1c3ad"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("9b17d0d5-8eba-4075-9d91-bc281ef3ac4b"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("c6618c14-929b-4568-b12f-ea7f7ebb748b"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("cafd071d-9f9a-4cf4-af20-894d5af75ab5"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("619b7fee-9dfc-424a-b2af-e9dc2f89f0a2"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("aed332fe-d264-4f9f-9a54-ecf8a878dbbe"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("bc9b3642-25cd-4b33-af7c-4861519bd7d4"));

            migrationBuilder.CreateTable(
                name: "ContactInfos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmailAddresses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillingAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobilePhone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInfos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ContactInfos",
                columns: new[] { "Id", "BillingAddress", "DeliveryAddress", "EmailAddresses", "HomePhone", "MobilePhone", "WorkPhone" },
                values: new object[,]
                {
                    { new Guid("30f3cf53-186b-4d46-b964-1d72a44a29bd"), "BillingAddress 5", "DeliveryAddress 5", "user5@test.com", "1234564345", "3556351235", "4234452344" },
                    { new Guid("5f386cb0-5653-4a2a-a50e-0a972e4942bb"), "BillingAddress 3", "DeliveryAddress 3", "user3@test.com", "1234564345", "3556351235", "4234452344" },
                    { new Guid("afe9dc95-e79b-4a66-8222-d7235c259bc9"), "BillingAddress 1", "DeliveryAddress 1", "user1@test.com", "1234564345", "3556351235", "4234452344" },
                    { new Guid("d6b1e73b-c74e-4fc5-bf02-9ebf141b107b"), "BillingAddress 2", "DeliveryAddress 2", "user2@test.com", "1234564345", "3556351235", "4234452344" },
                    { new Guid("d7fcb124-d06c-4cb0-b17d-2282a14a58a5"), "BillingAddress 4", "DeliveryAddress 4", "user4@test.com", "1234564345", "3556351235", "4234452344" }
                });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[,]
                {
                    { new Guid("61e7bbd3-e721-435e-a338-bfc47a1684f3"), "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.", 1.7, "Black Widow" },
                    { new Guid("7ca9bb0e-2600-4af9-aab3-f44a15923e7b"), "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.", 1.7, "Luke Skywalker" },
                    { new Guid("b26afc7c-4e32-47b3-af78-3719e6c87693"), "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.", 1.9299999999999999, "Batman" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "SuperheroId", "Title" },
                values: new object[,]
                {
                    { new Guid("3a945b2b-f5b1-4553-ba2c-55f54c323a20"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b26afc7c-4e32-47b3-af78-3719e6c87693"), "The Dark Knight" },
                    { new Guid("406ec7bf-73b5-4ff3-96ba-1f4b50950d2f"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7ca9bb0e-2600-4af9-aab3-f44a15923e7b"), "Star Wars: Episode V – The Empire Strikes Back" },
                    { new Guid("5fc6ff36-2a02-4a98-a5d6-68d8ce5362f1"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7ca9bb0e-2600-4af9-aab3-f44a15923e7b"), "Star Wars: Episode IV – A New Hope" },
                    { new Guid("65342591-b3d6-4949-95c9-d93d3e1463c6"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b26afc7c-4e32-47b3-af78-3719e6c87693"), "Batman Begins" },
                    { new Guid("986c9d8b-7bcb-4243-bcf3-4b3a7b87632f"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7ca9bb0e-2600-4af9-aab3-f44a15923e7b"), "Star Wars: Episode VI – Return of the Jedi" },
                    { new Guid("e0cd1c2b-a9ec-486c-aeeb-4feb9dc7a947"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("61e7bbd3-e721-435e-a338-bfc47a1684f3"), "Black Widow" },
                    { new Guid("ffb8b4a6-59ef-4fb3-95a6-2ec3fb96b66e"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b26afc7c-4e32-47b3-af78-3719e6c87693"), "The Dark Knight Rises" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperPower", "SuperheroId" },
                values: new object[,]
                {
                    { new Guid("0183065d-154a-4d26-ba37-28ee5f5255e1"), "He got a lot of money", "Wealth.", new Guid("b26afc7c-4e32-47b3-af78-3719e6c87693") },
                    { new Guid("14c01d93-a149-4580-a8a5-6c44c7028f77"), "She's good at spying at people.", "Espionage", new Guid("61e7bbd3-e721-435e-a338-bfc47a1684f3") },
                    { new Guid("b2562795-a02e-4582-bf35-2eedef632869"), "She knows how to infiltrate the enemy.", "Infiltration", new Guid("61e7bbd3-e721-435e-a338-bfc47a1684f3") },
                    { new Guid("b7cd493f-b68e-41ce-a5d7-167df04ec8da"), "The knowledge of how to undermine others.", "Subterfuge", new Guid("61e7bbd3-e721-435e-a338-bfc47a1684f3") },
                    { new Guid("ba0ac46d-8701-48d4-ab40-d317755eb8b9"), "He's always a step ahead.", "Intellect.", new Guid("b26afc7c-4e32-47b3-af78-3719e6c87693") },
                    { new Guid("c60cbbdb-d98d-43df-975a-945568bc760c"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", "Deflect blaster power.", new Guid("7ca9bb0e-2600-4af9-aab3-f44a15923e7b") },
                    { new Guid("d5f22d16-24cf-4a15-b228-28f5256abca7"), "Sublime fighting skills.", "Fighting", new Guid("b26afc7c-4e32-47b3-af78-3719e6c87693") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactInfos");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3a945b2b-f5b1-4553-ba2c-55f54c323a20"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("406ec7bf-73b5-4ff3-96ba-1f4b50950d2f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5fc6ff36-2a02-4a98-a5d6-68d8ce5362f1"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("65342591-b3d6-4949-95c9-d93d3e1463c6"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("986c9d8b-7bcb-4243-bcf3-4b3a7b87632f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e0cd1c2b-a9ec-486c-aeeb-4feb9dc7a947"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ffb8b4a6-59ef-4fb3-95a6-2ec3fb96b66e"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("0183065d-154a-4d26-ba37-28ee5f5255e1"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("14c01d93-a149-4580-a8a5-6c44c7028f77"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("b2562795-a02e-4582-bf35-2eedef632869"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("b7cd493f-b68e-41ce-a5d7-167df04ec8da"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("ba0ac46d-8701-48d4-ab40-d317755eb8b9"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("c60cbbdb-d98d-43df-975a-945568bc760c"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("d5f22d16-24cf-4a15-b228-28f5256abca7"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("61e7bbd3-e721-435e-a338-bfc47a1684f3"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("7ca9bb0e-2600-4af9-aab3-f44a15923e7b"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("b26afc7c-4e32-47b3-af78-3719e6c87693"));

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[] { new Guid("619b7fee-9dfc-424a-b2af-e9dc2f89f0a2"), "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.", 1.7, "Black Widow" });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[] { new Guid("aed332fe-d264-4f9f-9a54-ecf8a878dbbe"), "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.", 1.7, "Luke Skywalker" });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[] { new Guid("bc9b3642-25cd-4b33-af7c-4861519bd7d4"), "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.", 1.9299999999999999, "Batman" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "SuperheroId", "Title" },
                values: new object[,]
                {
                    { new Guid("14ad1d2f-852e-469e-94c2-7d969702eef5"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("619b7fee-9dfc-424a-b2af-e9dc2f89f0a2"), "Black Widow" },
                    { new Guid("191895b4-7207-40a2-9203-24d1e65b3991"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bc9b3642-25cd-4b33-af7c-4861519bd7d4"), "Batman Begins" },
                    { new Guid("1f9119bf-e246-4d7e-b5b5-a88749baf24a"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bc9b3642-25cd-4b33-af7c-4861519bd7d4"), "The Dark Knight Rises" },
                    { new Guid("73b5e8fb-4735-48cd-ae70-ec89618d77a8"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("aed332fe-d264-4f9f-9a54-ecf8a878dbbe"), "Star Wars: Episode IV – A New Hope" },
                    { new Guid("da5d6fc6-a958-4892-b243-f1ec229456cc"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bc9b3642-25cd-4b33-af7c-4861519bd7d4"), "The Dark Knight" },
                    { new Guid("e500d81b-6785-46fa-aa14-1d64f9abc8c0"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("aed332fe-d264-4f9f-9a54-ecf8a878dbbe"), "Star Wars: Episode VI – Return of the Jedi" },
                    { new Guid("ee989106-2bf5-48b1-840d-350c3d26b34b"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("aed332fe-d264-4f9f-9a54-ecf8a878dbbe"), "Star Wars: Episode V – The Empire Strikes Back" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperPower", "SuperheroId" },
                values: new object[,]
                {
                    { new Guid("107f699d-7bb4-489d-8694-f3017727284e"), "Sublime fighting skills.", "Fighting", new Guid("bc9b3642-25cd-4b33-af7c-4861519bd7d4") },
                    { new Guid("57b1e4bf-3818-4bd1-a854-8c61070d057c"), "She knows how to infiltrate the enemy.", "Infiltration", new Guid("619b7fee-9dfc-424a-b2af-e9dc2f89f0a2") },
                    { new Guid("6248fae6-f98a-4775-b534-d12c96da8b12"), "He's always a step ahead.", "Intellect.", new Guid("bc9b3642-25cd-4b33-af7c-4861519bd7d4") },
                    { new Guid("987eef1c-e372-4b6a-8e6f-1dafe6e1c3ad"), "She's good at spying at people.", "Espionage", new Guid("619b7fee-9dfc-424a-b2af-e9dc2f89f0a2") },
                    { new Guid("9b17d0d5-8eba-4075-9d91-bc281ef3ac4b"), "The knowledge of how to undermine others.", "Subterfuge", new Guid("619b7fee-9dfc-424a-b2af-e9dc2f89f0a2") },
                    { new Guid("c6618c14-929b-4568-b12f-ea7f7ebb748b"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", "Deflect blaster power.", new Guid("aed332fe-d264-4f9f-9a54-ecf8a878dbbe") },
                    { new Guid("cafd071d-9f9a-4cf4-af20-894d5af75ab5"), "He got a lot of money", "Wealth.", new Guid("bc9b3642-25cd-4b33-af7c-4861519bd7d4") }
                });
        }
    }
}
