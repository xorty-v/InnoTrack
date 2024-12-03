using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using NpgsqlTypes;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InnoTrack.WebApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Innovations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AuthorName = table.Column<string>(type: "text", nullable: false),
                    OrganizationName = table.Column<string>(type: "text", nullable: false),
                    OrganizationEmail = table.Column<string>(type: "text", nullable: false),
                    TechnologyName = table.Column<string>(type: "text", nullable: false),
                    ProductName = table.Column<string>(type: "text", nullable: false),
                    DateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "AuthorName", "ProductName", "TechnologyName", "OrganizationName" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Innovations", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Innovations",
                columns: new[] { "Id", "AuthorName", "DateTime", "OrganizationEmail", "OrganizationName", "ProductName", "TechnologyName" },
                values: new object[,]
                {
                    { 1, "Damian Crist", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(1178), "catalina_halvorson@yahoo.com", "Kessler, Willms and Harber", "Handmade Fresh Bacon", "Bike" },
                    { 2, "Antonia Pfeffer", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(2498), "tavares20@gmail.com", "D'Amore Group", "Intelligent Cotton Table", "Towels" },
                    { 3, "Peggie Littel", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(2756), "lilla44@yahoo.com", "Pouros - Strosin", "Refined Frozen Pants", "Keyboard" },
                    { 4, "Stacey Morar", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(2911), "leanna_thompson@yahoo.com", "Turner - Bauch", "Practical Frozen Car", "Sausages" },
                    { 5, "Vergie White", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(3083), "gust_greenholt16@hotmail.com", "Osinski - Nicolas", "Tasty Concrete Gloves", "Computer" },
                    { 6, "Jessika Hahn", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(3462), "brooklyn5@gmail.com", "O'Connell, Heidenreich and Kassulke", "Unbranded Concrete Towels", "Shoes" },
                    { 7, "Elwyn Weimann", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(3679), "clark.paucek@hotmail.com", "Lubowitz, Mante and Goldner", "Fantastic Soft Table", "Computer" },
                    { 8, "Rosa Ernser", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(3976), "anibal56@hotmail.com", "Auer, Miller and Oberbrunner", "Small Metal Shirt", "Tuna" },
                    { 9, "Willis Wolf", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(4296), "jacey.stanton83@yahoo.com", "Monahan and Sons", "Generic Concrete Sausages", "Ball" },
                    { 10, "Elizabeth Baumbach", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(4483), "destiny14@gmail.com", "Wiegand, Berge and Ratke", "Incredible Soft Keyboard", "Salad" },
                    { 11, "Marian Olson", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(4661), "modesta75@gmail.com", "Murray - Mayer", "Fantastic Steel Table", "Gloves" },
                    { 12, "Mia Quigley", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(4838), "kenton.sanford@yahoo.com", "Stamm and Sons", "Handcrafted Wooden Fish", "Pants" },
                    { 13, "Leonora Greenholt", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(5018), "mathias75@hotmail.com", "Zulauf Inc", "Rustic Fresh Computer", "Bacon" },
                    { 14, "Elliot Harvey", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(5156), "michelle.sipes@yahoo.com", "Collins - Gusikowski", "Small Cotton Ball", "Hat" },
                    { 15, "Jeffrey Gerhold", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(5310), "presley_turner@gmail.com", "Cremin - Schiller", "Generic Wooden Fish", "Computer" },
                    { 16, "Burnice Friesen", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(5467), "godfrey.ryan@hotmail.com", "Pouros Inc", "Fantastic Cotton Salad", "Cheese" },
                    { 17, "Brian Pagac", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(5634), "jacinthe32@yahoo.com", "Fay - Renner", "Intelligent Fresh Fish", "Computer" },
                    { 18, "Kaya Krajcik", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(5804), "francesca.kerluke71@hotmail.com", "Hoppe - Hodkiewicz", "Unbranded Steel Tuna", "Computer" },
                    { 19, "Alycia Connelly", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(5947), "modesta23@yahoo.com", "Johnston - Kutch", "Ergonomic Granite Pizza", "Pizza" },
                    { 20, "Jailyn Murazik", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(6099), "jacynthe_lakin@hotmail.com", "Corkery LLC", "Intelligent Plastic Chicken", "Fish" },
                    { 21, "Aurelie Stokes", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(6272), "mekhi23@yahoo.com", "Sauer Inc", "Ergonomic Soft Towels", "Fish" },
                    { 22, "Mallory Johnson", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(6446), "destini.strosin73@gmail.com", "Monahan LLC", "Awesome Wooden Chicken", "Hat" },
                    { 23, "Graham Weimann", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(6571), "ena.hackett@gmail.com", "Walsh - Bergnaum", "Intelligent Fresh Car", "Salad" },
                    { 24, "Hector Keebler", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(6797), "curtis_lockman@yahoo.com", "Abshire, Runolfsson and Turcotte", "Intelligent Plastic Bacon", "Fish" },
                    { 25, "Litzy Okuneva", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(6986), "keyon_weissnat32@yahoo.com", "Carter, Klocko and Stokes", "Intelligent Plastic Shoes", "Keyboard" },
                    { 26, "Lula Schumm", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(7126), "chaya.aufderhar@gmail.com", "Spencer and Sons", "Intelligent Plastic Bacon", "Pants" },
                    { 27, "William Dooley", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(7364), "lemuel_breitenberg@gmail.com", "Murphy - Brekke", "Licensed Plastic Ball", "Computer" },
                    { 28, "Keshawn Bogisich", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(7594), "ronny3@hotmail.com", "Jacobi, Kuvalis and Armstrong", "Rustic Rubber Shoes", "Towels" },
                    { 29, "Jazmin Fahey", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(7768), "mac_baumbach48@gmail.com", "Gusikowski - Friesen", "Generic Rubber Shoes", "Pizza" },
                    { 30, "Khalid Bartell", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(7965), "janiya_berge97@hotmail.com", "Schimmel, Purdy and Terry", "Tasty Concrete Shirt", "Table" },
                    { 31, "Felicia Bahringer", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(8129), "jamie97@hotmail.com", "Waelchi Inc", "Practical Frozen Chicken", "Sausages" },
                    { 32, "Raquel Nolan", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(8296), "providenci.trantow@gmail.com", "Satterfield - Farrell", "Licensed Frozen Bacon", "Chair" },
                    { 33, "Margie Mante", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(8459), "herminia80@hotmail.com", "VonRueden Inc", "Generic Granite Tuna", "Shoes" },
                    { 34, "Elissa West", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(8591), "keshawn64@gmail.com", "Cartwright - Aufderhar", "Ergonomic Metal Keyboard", "Shoes" },
                    { 35, "Jena Von", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(8746), "allene16@gmail.com", "Swift - O'Kon", "Ergonomic Concrete Pants", "Pizza" },
                    { 36, "Idella Cassin", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(8989), "katelynn_stracke47@hotmail.com", "Oberbrunner - Grimes", "Unbranded Steel Hat", "Car" },
                    { 37, "Margot Schoen", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(9179), "abdullah.kuhn@yahoo.com", "Hammes - Nicolas", "Incredible Concrete Chicken", "Chicken" },
                    { 38, "Ned Labadie", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(9384), "queenie.bartoletti@hotmail.com", "Altenwerth, Bernhard and Reinger", "Small Steel Ball", "Table" },
                    { 39, "Olaf Wyman", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(9683), "josefina10@yahoo.com", "Schroeder - Moen", "Small Rubber Chips", "Chips" },
                    { 40, "Benedict Stark", new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(9926), "kaylah74@yahoo.com", "Bins Group", "Awesome Soft Tuna", "Gloves" },
                    { 41, "Meghan Turcotte", new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(99), "ewell.bahringer3@hotmail.com", "Mertz and Sons", "Intelligent Frozen Fish", "Car" },
                    { 42, "Chester Oberbrunner", new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(281), "david94@yahoo.com", "Hammes, Sipes and Walter", "Incredible Cotton Shoes", "Soap" },
                    { 43, "Estelle Funk", new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(458), "velda_ziemann@hotmail.com", "Rath and Sons", "Gorgeous Steel Keyboard", "Gloves" },
                    { 44, "Warren Murphy", new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(614), "sadye.kerluke45@yahoo.com", "Hintz and Sons", "Intelligent Steel Mouse", "Fish" },
                    { 45, "Ubaldo Swift", new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(775), "benedict.bradtke37@gmail.com", "Towne and Sons", "Incredible Plastic Keyboard", "Chair" },
                    { 46, "Floy Luettgen", new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(906), "erin.littel@gmail.com", "Hintz - Lind", "Fantastic Soft Chicken", "Salad" },
                    { 47, "Valerie Stracke", new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(1062), "shanna.welch51@yahoo.com", "Cormier Inc", "Refined Cotton Bacon", "Gloves" },
                    { 48, "Arlo Langworth", new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(1268), "oma18@hotmail.com", "Senger Inc", "Practical Fresh Hat", "Gloves" },
                    { 49, "Wilburn Weber", new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(1443), "ed_robel49@hotmail.com", "Okuneva - Koss", "Sleek Cotton Ball", "Gloves" },
                    { 50, "Camila Rath", new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(1578), "eudora.mcclure@yahoo.com", "McClure Group", "Fantastic Wooden Soap", "Pizza" },
                    { 51, "Wilfredo Labadie", new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(1756), "orland.yost@gmail.com", "Wiegand - Greenholt", "Unbranded Rubber Tuna", "Pizza" },
                    { 52, "Gaetano Stroman", new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(1947), "cindy_gutkowski77@gmail.com", "Davis, Kuhic and Nienow", "Sleek Plastic Tuna", "Pants" },
                    { 53, "Lionel Treutel", new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(2150), "abel_larkin25@gmail.com", "O'Reilly, Moen and Hegmann", "Incredible Rubber Hat", "Cheese" },
                    { 54, "Robbie Braun", new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(2320), "lauren_fadel@hotmail.com", "Smitham - Wisoky", "Ergonomic Concrete Soap", "Bike" },
                    { 55, "Ramona Huel", new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(2496), "timothy91@gmail.com", "D'Amore Inc", "Licensed Concrete Cheese", "Mouse" },
                    { 56, "Cyril O'Conner", new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(2685), "annabelle3@hotmail.com", "Okuneva - Bergnaum", "Refined Metal Pizza", "Fish" },
                    { 57, "Karen Muller", new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(2880), "joana5@hotmail.com", "Swaniawski, Bradtke and Beier", "Ergonomic Granite Bike", "Shoes" },
                    { 58, "Mozell Little", new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(3013), "edna32@yahoo.com", "Thiel Group", "Practical Steel Mouse", "Keyboard" },
                    { 59, "Jarret Wiegand", new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(3201), "russel.willms24@gmail.com", "Greenfelder - Rutherford", "Small Steel Mouse", "Bacon" },
                    { 60, "Alayna Heaney", new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(3380), "carol_mills@hotmail.com", "Bosco LLC", "Incredible Granite Bike", "Bacon" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Innovations_SearchVector",
                table: "Innovations",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Innovations");
        }
    }
}
