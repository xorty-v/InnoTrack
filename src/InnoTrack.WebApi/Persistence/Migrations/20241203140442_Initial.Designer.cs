﻿// <auto-generated />
using System;
using InnoTrack.WebApi.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using NpgsqlTypes;

#nullable disable

namespace InnoTrack.WebApi.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241203140442_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("InnoTrack.WebApi.Entities.Innovation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("OrganizationEmail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OrganizationName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<NpgsqlTsVector>("SearchVector")
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("tsvector")
                        .HasAnnotation("Npgsql:TsVectorConfig", "english")
                        .HasAnnotation("Npgsql:TsVectorProperties", new[] { "AuthorName", "ProductName", "TechnologyName", "OrganizationName" });

                    b.Property<string>("TechnologyName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("SearchVector");

                    NpgsqlIndexBuilderExtensions.HasMethod(b.HasIndex("SearchVector"), "GIN");

                    b.ToTable("Innovations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorName = "Damian Crist",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(1178),
                            OrganizationEmail = "catalina_halvorson@yahoo.com",
                            OrganizationName = "Kessler, Willms and Harber",
                            ProductName = "Handmade Fresh Bacon",
                            TechnologyName = "Bike"
                        },
                        new
                        {
                            Id = 2,
                            AuthorName = "Antonia Pfeffer",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(2498),
                            OrganizationEmail = "tavares20@gmail.com",
                            OrganizationName = "D'Amore Group",
                            ProductName = "Intelligent Cotton Table",
                            TechnologyName = "Towels"
                        },
                        new
                        {
                            Id = 3,
                            AuthorName = "Peggie Littel",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(2756),
                            OrganizationEmail = "lilla44@yahoo.com",
                            OrganizationName = "Pouros - Strosin",
                            ProductName = "Refined Frozen Pants",
                            TechnologyName = "Keyboard"
                        },
                        new
                        {
                            Id = 4,
                            AuthorName = "Stacey Morar",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(2911),
                            OrganizationEmail = "leanna_thompson@yahoo.com",
                            OrganizationName = "Turner - Bauch",
                            ProductName = "Practical Frozen Car",
                            TechnologyName = "Sausages"
                        },
                        new
                        {
                            Id = 5,
                            AuthorName = "Vergie White",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(3083),
                            OrganizationEmail = "gust_greenholt16@hotmail.com",
                            OrganizationName = "Osinski - Nicolas",
                            ProductName = "Tasty Concrete Gloves",
                            TechnologyName = "Computer"
                        },
                        new
                        {
                            Id = 6,
                            AuthorName = "Jessika Hahn",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(3462),
                            OrganizationEmail = "brooklyn5@gmail.com",
                            OrganizationName = "O'Connell, Heidenreich and Kassulke",
                            ProductName = "Unbranded Concrete Towels",
                            TechnologyName = "Shoes"
                        },
                        new
                        {
                            Id = 7,
                            AuthorName = "Elwyn Weimann",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(3679),
                            OrganizationEmail = "clark.paucek@hotmail.com",
                            OrganizationName = "Lubowitz, Mante and Goldner",
                            ProductName = "Fantastic Soft Table",
                            TechnologyName = "Computer"
                        },
                        new
                        {
                            Id = 8,
                            AuthorName = "Rosa Ernser",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(3976),
                            OrganizationEmail = "anibal56@hotmail.com",
                            OrganizationName = "Auer, Miller and Oberbrunner",
                            ProductName = "Small Metal Shirt",
                            TechnologyName = "Tuna"
                        },
                        new
                        {
                            Id = 9,
                            AuthorName = "Willis Wolf",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(4296),
                            OrganizationEmail = "jacey.stanton83@yahoo.com",
                            OrganizationName = "Monahan and Sons",
                            ProductName = "Generic Concrete Sausages",
                            TechnologyName = "Ball"
                        },
                        new
                        {
                            Id = 10,
                            AuthorName = "Elizabeth Baumbach",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(4483),
                            OrganizationEmail = "destiny14@gmail.com",
                            OrganizationName = "Wiegand, Berge and Ratke",
                            ProductName = "Incredible Soft Keyboard",
                            TechnologyName = "Salad"
                        },
                        new
                        {
                            Id = 11,
                            AuthorName = "Marian Olson",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(4661),
                            OrganizationEmail = "modesta75@gmail.com",
                            OrganizationName = "Murray - Mayer",
                            ProductName = "Fantastic Steel Table",
                            TechnologyName = "Gloves"
                        },
                        new
                        {
                            Id = 12,
                            AuthorName = "Mia Quigley",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(4838),
                            OrganizationEmail = "kenton.sanford@yahoo.com",
                            OrganizationName = "Stamm and Sons",
                            ProductName = "Handcrafted Wooden Fish",
                            TechnologyName = "Pants"
                        },
                        new
                        {
                            Id = 13,
                            AuthorName = "Leonora Greenholt",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(5018),
                            OrganizationEmail = "mathias75@hotmail.com",
                            OrganizationName = "Zulauf Inc",
                            ProductName = "Rustic Fresh Computer",
                            TechnologyName = "Bacon"
                        },
                        new
                        {
                            Id = 14,
                            AuthorName = "Elliot Harvey",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(5156),
                            OrganizationEmail = "michelle.sipes@yahoo.com",
                            OrganizationName = "Collins - Gusikowski",
                            ProductName = "Small Cotton Ball",
                            TechnologyName = "Hat"
                        },
                        new
                        {
                            Id = 15,
                            AuthorName = "Jeffrey Gerhold",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(5310),
                            OrganizationEmail = "presley_turner@gmail.com",
                            OrganizationName = "Cremin - Schiller",
                            ProductName = "Generic Wooden Fish",
                            TechnologyName = "Computer"
                        },
                        new
                        {
                            Id = 16,
                            AuthorName = "Burnice Friesen",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(5467),
                            OrganizationEmail = "godfrey.ryan@hotmail.com",
                            OrganizationName = "Pouros Inc",
                            ProductName = "Fantastic Cotton Salad",
                            TechnologyName = "Cheese"
                        },
                        new
                        {
                            Id = 17,
                            AuthorName = "Brian Pagac",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(5634),
                            OrganizationEmail = "jacinthe32@yahoo.com",
                            OrganizationName = "Fay - Renner",
                            ProductName = "Intelligent Fresh Fish",
                            TechnologyName = "Computer"
                        },
                        new
                        {
                            Id = 18,
                            AuthorName = "Kaya Krajcik",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(5804),
                            OrganizationEmail = "francesca.kerluke71@hotmail.com",
                            OrganizationName = "Hoppe - Hodkiewicz",
                            ProductName = "Unbranded Steel Tuna",
                            TechnologyName = "Computer"
                        },
                        new
                        {
                            Id = 19,
                            AuthorName = "Alycia Connelly",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(5947),
                            OrganizationEmail = "modesta23@yahoo.com",
                            OrganizationName = "Johnston - Kutch",
                            ProductName = "Ergonomic Granite Pizza",
                            TechnologyName = "Pizza"
                        },
                        new
                        {
                            Id = 20,
                            AuthorName = "Jailyn Murazik",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(6099),
                            OrganizationEmail = "jacynthe_lakin@hotmail.com",
                            OrganizationName = "Corkery LLC",
                            ProductName = "Intelligent Plastic Chicken",
                            TechnologyName = "Fish"
                        },
                        new
                        {
                            Id = 21,
                            AuthorName = "Aurelie Stokes",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(6272),
                            OrganizationEmail = "mekhi23@yahoo.com",
                            OrganizationName = "Sauer Inc",
                            ProductName = "Ergonomic Soft Towels",
                            TechnologyName = "Fish"
                        },
                        new
                        {
                            Id = 22,
                            AuthorName = "Mallory Johnson",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(6446),
                            OrganizationEmail = "destini.strosin73@gmail.com",
                            OrganizationName = "Monahan LLC",
                            ProductName = "Awesome Wooden Chicken",
                            TechnologyName = "Hat"
                        },
                        new
                        {
                            Id = 23,
                            AuthorName = "Graham Weimann",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(6571),
                            OrganizationEmail = "ena.hackett@gmail.com",
                            OrganizationName = "Walsh - Bergnaum",
                            ProductName = "Intelligent Fresh Car",
                            TechnologyName = "Salad"
                        },
                        new
                        {
                            Id = 24,
                            AuthorName = "Hector Keebler",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(6797),
                            OrganizationEmail = "curtis_lockman@yahoo.com",
                            OrganizationName = "Abshire, Runolfsson and Turcotte",
                            ProductName = "Intelligent Plastic Bacon",
                            TechnologyName = "Fish"
                        },
                        new
                        {
                            Id = 25,
                            AuthorName = "Litzy Okuneva",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(6986),
                            OrganizationEmail = "keyon_weissnat32@yahoo.com",
                            OrganizationName = "Carter, Klocko and Stokes",
                            ProductName = "Intelligent Plastic Shoes",
                            TechnologyName = "Keyboard"
                        },
                        new
                        {
                            Id = 26,
                            AuthorName = "Lula Schumm",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(7126),
                            OrganizationEmail = "chaya.aufderhar@gmail.com",
                            OrganizationName = "Spencer and Sons",
                            ProductName = "Intelligent Plastic Bacon",
                            TechnologyName = "Pants"
                        },
                        new
                        {
                            Id = 27,
                            AuthorName = "William Dooley",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(7364),
                            OrganizationEmail = "lemuel_breitenberg@gmail.com",
                            OrganizationName = "Murphy - Brekke",
                            ProductName = "Licensed Plastic Ball",
                            TechnologyName = "Computer"
                        },
                        new
                        {
                            Id = 28,
                            AuthorName = "Keshawn Bogisich",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(7594),
                            OrganizationEmail = "ronny3@hotmail.com",
                            OrganizationName = "Jacobi, Kuvalis and Armstrong",
                            ProductName = "Rustic Rubber Shoes",
                            TechnologyName = "Towels"
                        },
                        new
                        {
                            Id = 29,
                            AuthorName = "Jazmin Fahey",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(7768),
                            OrganizationEmail = "mac_baumbach48@gmail.com",
                            OrganizationName = "Gusikowski - Friesen",
                            ProductName = "Generic Rubber Shoes",
                            TechnologyName = "Pizza"
                        },
                        new
                        {
                            Id = 30,
                            AuthorName = "Khalid Bartell",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(7965),
                            OrganizationEmail = "janiya_berge97@hotmail.com",
                            OrganizationName = "Schimmel, Purdy and Terry",
                            ProductName = "Tasty Concrete Shirt",
                            TechnologyName = "Table"
                        },
                        new
                        {
                            Id = 31,
                            AuthorName = "Felicia Bahringer",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(8129),
                            OrganizationEmail = "jamie97@hotmail.com",
                            OrganizationName = "Waelchi Inc",
                            ProductName = "Practical Frozen Chicken",
                            TechnologyName = "Sausages"
                        },
                        new
                        {
                            Id = 32,
                            AuthorName = "Raquel Nolan",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(8296),
                            OrganizationEmail = "providenci.trantow@gmail.com",
                            OrganizationName = "Satterfield - Farrell",
                            ProductName = "Licensed Frozen Bacon",
                            TechnologyName = "Chair"
                        },
                        new
                        {
                            Id = 33,
                            AuthorName = "Margie Mante",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(8459),
                            OrganizationEmail = "herminia80@hotmail.com",
                            OrganizationName = "VonRueden Inc",
                            ProductName = "Generic Granite Tuna",
                            TechnologyName = "Shoes"
                        },
                        new
                        {
                            Id = 34,
                            AuthorName = "Elissa West",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(8591),
                            OrganizationEmail = "keshawn64@gmail.com",
                            OrganizationName = "Cartwright - Aufderhar",
                            ProductName = "Ergonomic Metal Keyboard",
                            TechnologyName = "Shoes"
                        },
                        new
                        {
                            Id = 35,
                            AuthorName = "Jena Von",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(8746),
                            OrganizationEmail = "allene16@gmail.com",
                            OrganizationName = "Swift - O'Kon",
                            ProductName = "Ergonomic Concrete Pants",
                            TechnologyName = "Pizza"
                        },
                        new
                        {
                            Id = 36,
                            AuthorName = "Idella Cassin",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(8989),
                            OrganizationEmail = "katelynn_stracke47@hotmail.com",
                            OrganizationName = "Oberbrunner - Grimes",
                            ProductName = "Unbranded Steel Hat",
                            TechnologyName = "Car"
                        },
                        new
                        {
                            Id = 37,
                            AuthorName = "Margot Schoen",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(9179),
                            OrganizationEmail = "abdullah.kuhn@yahoo.com",
                            OrganizationName = "Hammes - Nicolas",
                            ProductName = "Incredible Concrete Chicken",
                            TechnologyName = "Chicken"
                        },
                        new
                        {
                            Id = 38,
                            AuthorName = "Ned Labadie",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(9384),
                            OrganizationEmail = "queenie.bartoletti@hotmail.com",
                            OrganizationName = "Altenwerth, Bernhard and Reinger",
                            ProductName = "Small Steel Ball",
                            TechnologyName = "Table"
                        },
                        new
                        {
                            Id = 39,
                            AuthorName = "Olaf Wyman",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(9683),
                            OrganizationEmail = "josefina10@yahoo.com",
                            OrganizationName = "Schroeder - Moen",
                            ProductName = "Small Rubber Chips",
                            TechnologyName = "Chips"
                        },
                        new
                        {
                            Id = 40,
                            AuthorName = "Benedict Stark",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 795, DateTimeKind.Utc).AddTicks(9926),
                            OrganizationEmail = "kaylah74@yahoo.com",
                            OrganizationName = "Bins Group",
                            ProductName = "Awesome Soft Tuna",
                            TechnologyName = "Gloves"
                        },
                        new
                        {
                            Id = 41,
                            AuthorName = "Meghan Turcotte",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(99),
                            OrganizationEmail = "ewell.bahringer3@hotmail.com",
                            OrganizationName = "Mertz and Sons",
                            ProductName = "Intelligent Frozen Fish",
                            TechnologyName = "Car"
                        },
                        new
                        {
                            Id = 42,
                            AuthorName = "Chester Oberbrunner",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(281),
                            OrganizationEmail = "david94@yahoo.com",
                            OrganizationName = "Hammes, Sipes and Walter",
                            ProductName = "Incredible Cotton Shoes",
                            TechnologyName = "Soap"
                        },
                        new
                        {
                            Id = 43,
                            AuthorName = "Estelle Funk",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(458),
                            OrganizationEmail = "velda_ziemann@hotmail.com",
                            OrganizationName = "Rath and Sons",
                            ProductName = "Gorgeous Steel Keyboard",
                            TechnologyName = "Gloves"
                        },
                        new
                        {
                            Id = 44,
                            AuthorName = "Warren Murphy",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(614),
                            OrganizationEmail = "sadye.kerluke45@yahoo.com",
                            OrganizationName = "Hintz and Sons",
                            ProductName = "Intelligent Steel Mouse",
                            TechnologyName = "Fish"
                        },
                        new
                        {
                            Id = 45,
                            AuthorName = "Ubaldo Swift",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(775),
                            OrganizationEmail = "benedict.bradtke37@gmail.com",
                            OrganizationName = "Towne and Sons",
                            ProductName = "Incredible Plastic Keyboard",
                            TechnologyName = "Chair"
                        },
                        new
                        {
                            Id = 46,
                            AuthorName = "Floy Luettgen",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(906),
                            OrganizationEmail = "erin.littel@gmail.com",
                            OrganizationName = "Hintz - Lind",
                            ProductName = "Fantastic Soft Chicken",
                            TechnologyName = "Salad"
                        },
                        new
                        {
                            Id = 47,
                            AuthorName = "Valerie Stracke",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(1062),
                            OrganizationEmail = "shanna.welch51@yahoo.com",
                            OrganizationName = "Cormier Inc",
                            ProductName = "Refined Cotton Bacon",
                            TechnologyName = "Gloves"
                        },
                        new
                        {
                            Id = 48,
                            AuthorName = "Arlo Langworth",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(1268),
                            OrganizationEmail = "oma18@hotmail.com",
                            OrganizationName = "Senger Inc",
                            ProductName = "Practical Fresh Hat",
                            TechnologyName = "Gloves"
                        },
                        new
                        {
                            Id = 49,
                            AuthorName = "Wilburn Weber",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(1443),
                            OrganizationEmail = "ed_robel49@hotmail.com",
                            OrganizationName = "Okuneva - Koss",
                            ProductName = "Sleek Cotton Ball",
                            TechnologyName = "Gloves"
                        },
                        new
                        {
                            Id = 50,
                            AuthorName = "Camila Rath",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(1578),
                            OrganizationEmail = "eudora.mcclure@yahoo.com",
                            OrganizationName = "McClure Group",
                            ProductName = "Fantastic Wooden Soap",
                            TechnologyName = "Pizza"
                        },
                        new
                        {
                            Id = 51,
                            AuthorName = "Wilfredo Labadie",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(1756),
                            OrganizationEmail = "orland.yost@gmail.com",
                            OrganizationName = "Wiegand - Greenholt",
                            ProductName = "Unbranded Rubber Tuna",
                            TechnologyName = "Pizza"
                        },
                        new
                        {
                            Id = 52,
                            AuthorName = "Gaetano Stroman",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(1947),
                            OrganizationEmail = "cindy_gutkowski77@gmail.com",
                            OrganizationName = "Davis, Kuhic and Nienow",
                            ProductName = "Sleek Plastic Tuna",
                            TechnologyName = "Pants"
                        },
                        new
                        {
                            Id = 53,
                            AuthorName = "Lionel Treutel",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(2150),
                            OrganizationEmail = "abel_larkin25@gmail.com",
                            OrganizationName = "O'Reilly, Moen and Hegmann",
                            ProductName = "Incredible Rubber Hat",
                            TechnologyName = "Cheese"
                        },
                        new
                        {
                            Id = 54,
                            AuthorName = "Robbie Braun",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(2320),
                            OrganizationEmail = "lauren_fadel@hotmail.com",
                            OrganizationName = "Smitham - Wisoky",
                            ProductName = "Ergonomic Concrete Soap",
                            TechnologyName = "Bike"
                        },
                        new
                        {
                            Id = 55,
                            AuthorName = "Ramona Huel",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(2496),
                            OrganizationEmail = "timothy91@gmail.com",
                            OrganizationName = "D'Amore Inc",
                            ProductName = "Licensed Concrete Cheese",
                            TechnologyName = "Mouse"
                        },
                        new
                        {
                            Id = 56,
                            AuthorName = "Cyril O'Conner",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(2685),
                            OrganizationEmail = "annabelle3@hotmail.com",
                            OrganizationName = "Okuneva - Bergnaum",
                            ProductName = "Refined Metal Pizza",
                            TechnologyName = "Fish"
                        },
                        new
                        {
                            Id = 57,
                            AuthorName = "Karen Muller",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(2880),
                            OrganizationEmail = "joana5@hotmail.com",
                            OrganizationName = "Swaniawski, Bradtke and Beier",
                            ProductName = "Ergonomic Granite Bike",
                            TechnologyName = "Shoes"
                        },
                        new
                        {
                            Id = 58,
                            AuthorName = "Mozell Little",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(3013),
                            OrganizationEmail = "edna32@yahoo.com",
                            OrganizationName = "Thiel Group",
                            ProductName = "Practical Steel Mouse",
                            TechnologyName = "Keyboard"
                        },
                        new
                        {
                            Id = 59,
                            AuthorName = "Jarret Wiegand",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(3201),
                            OrganizationEmail = "russel.willms24@gmail.com",
                            OrganizationName = "Greenfelder - Rutherford",
                            ProductName = "Small Steel Mouse",
                            TechnologyName = "Bacon"
                        },
                        new
                        {
                            Id = 60,
                            AuthorName = "Alayna Heaney",
                            DateTime = new DateTime(2024, 12, 3, 14, 4, 36, 796, DateTimeKind.Utc).AddTicks(3380),
                            OrganizationEmail = "carol_mills@hotmail.com",
                            OrganizationName = "Bosco LLC",
                            ProductName = "Incredible Granite Bike",
                            TechnologyName = "Bacon"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
