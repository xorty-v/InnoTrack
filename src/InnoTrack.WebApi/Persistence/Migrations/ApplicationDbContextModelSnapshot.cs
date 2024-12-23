﻿// <auto-generated />
using System;
using InnoTrack.WebApi.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using NpgsqlTypes;

#nullable disable

namespace InnoTrack.WebApi.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        .HasAnnotation("Npgsql:TsVectorConfig", "russian")
                        .HasAnnotation("Npgsql:TsVectorProperties", new[] { "AuthorName", "OrganizationName", "TechnologyName" });

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
                            AuthorName = "Владислав Костин",
                            DateTime = new DateTime(2023, 11, 7, 3, 16, 15, 716, DateTimeKind.Utc).AddTicks(1236),
                            OrganizationEmail = "georgii22@hotmail.com",
                            OrganizationName = "МегаТехнологии",
                            ProductName = "Сенсор",
                            TechnologyName = "Квантовые вычисления"
                        },
                        new
                        {
                            Id = 2,
                            AuthorName = "Егор Петров",
                            DateTime = new DateTime(2021, 6, 23, 21, 25, 28, 24, DateTimeKind.Utc).AddTicks(7370),
                            OrganizationEmail = "grigorii_isakov91@hotmail.com",
                            OrganizationName = "ГлобалТех",
                            ProductName = "Система мониторинга",
                            TechnologyName = "Нейросеть"
                        },
                        new
                        {
                            Id = 3,
                            AuthorName = "Василий Мельникова",
                            DateTime = new DateTime(2022, 5, 31, 13, 26, 6, 478, DateTimeKind.Utc).AddTicks(8809),
                            OrganizationEmail = "angelina.potapov@yahoo.com",
                            OrganizationName = "ИнфоСистемы",
                            ProductName = "Аналитическая платформа",
                            TechnologyName = "Распознавание речи"
                        },
                        new
                        {
                            Id = 4,
                            AuthorName = "Аркадий Гусева",
                            DateTime = new DateTime(2021, 10, 31, 15, 17, 49, 38, DateTimeKind.Utc).AddTicks(9551),
                            OrganizationEmail = "vyacheslav.anisimov@ya.ru",
                            OrganizationName = "ИнтелСистемы",
                            ProductName = "Система мониторинга",
                            TechnologyName = "Нейросеть"
                        },
                        new
                        {
                            Id = 5,
                            AuthorName = "Роман Дорофеев",
                            DateTime = new DateTime(2024, 7, 15, 8, 13, 32, 545, DateTimeKind.Utc).AddTicks(3851),
                            OrganizationEmail = "roman_lukina22@hotmail.com",
                            OrganizationName = "ИнноТех",
                            ProductName = "Устройство связи",
                            TechnologyName = "Доставка"
                        },
                        new
                        {
                            Id = 6,
                            AuthorName = "Ирина Воронова",
                            DateTime = new DateTime(2020, 9, 14, 19, 46, 28, 40, DateTimeKind.Utc).AddTicks(121),
                            OrganizationEmail = "anton.kolesnikov71@hotmail.com",
                            OrganizationName = "ИнноТех",
                            ProductName = "Графический чип",
                            TechnologyName = "IoT платформа"
                        },
                        new
                        {
                            Id = 7,
                            AuthorName = "Эдуард Ларионов",
                            DateTime = new DateTime(2021, 10, 17, 10, 3, 58, 742, DateTimeKind.Utc).AddTicks(8094),
                            OrganizationEmail = "raisa68@ya.ru",
                            OrganizationName = "МегаТехнологии",
                            ProductName = "Система мониторинга",
                            TechnologyName = "ИИ"
                        },
                        new
                        {
                            Id = 8,
                            AuthorName = "Вадим Суворов",
                            DateTime = new DateTime(2022, 10, 29, 22, 56, 26, 497, DateTimeKind.Utc).AddTicks(5373),
                            OrganizationEmail = "viktoriya_naumov57@ya.ru",
                            OrganizationName = "ТехноСтар",
                            ProductName = "Система мониторинга",
                            TechnologyName = "Нейросеть"
                        },
                        new
                        {
                            Id = 9,
                            AuthorName = "Владимир Трофимова",
                            DateTime = new DateTime(2020, 5, 11, 21, 43, 44, 89, DateTimeKind.Utc).AddTicks(8971),
                            OrganizationEmail = "aleksandra_voronov@yandex.ru",
                            OrganizationName = "СофтТек",
                            ProductName = "Программное обеспечение",
                            TechnologyName = "Квантовые вычисления"
                        },
                        new
                        {
                            Id = 10,
                            AuthorName = "Зинаида Игнатова",
                            DateTime = new DateTime(2022, 10, 6, 22, 39, 40, 739, DateTimeKind.Utc).AddTicks(1075),
                            OrganizationEmail = "ulyana_simonov55@hotmail.com",
                            OrganizationName = "ГиперСофт",
                            ProductName = "Устройство связи",
                            TechnologyName = "Доставка"
                        },
                        new
                        {
                            Id = 11,
                            AuthorName = "Елена Фролова",
                            DateTime = new DateTime(2020, 10, 12, 7, 24, 24, 717, DateTimeKind.Utc).AddTicks(1130),
                            OrganizationEmail = "marina_agafonova@yahoo.com",
                            OrganizationName = "МегаТехнологии",
                            ProductName = "Система мониторинга",
                            TechnologyName = "ИИ"
                        },
                        new
                        {
                            Id = 12,
                            AuthorName = "Алевтина Зиновьев",
                            DateTime = new DateTime(2023, 5, 23, 21, 49, 4, 415, DateTimeKind.Utc).AddTicks(3063),
                            OrganizationEmail = "sofiya_ryabov20@ya.ru",
                            OrganizationName = "МегаТехнологии",
                            ProductName = "Система мониторинга",
                            TechnologyName = "IoT платформа"
                        },
                        new
                        {
                            Id = 13,
                            AuthorName = "Лаврентий Рябов",
                            DateTime = new DateTime(2021, 3, 24, 21, 51, 40, 828, DateTimeKind.Utc).AddTicks(3360),
                            OrganizationEmail = "natalya96@gmail.com",
                            OrganizationName = "ИнфоСистемы",
                            ProductName = "Программное обеспечение",
                            TechnologyName = "IoT платформа"
                        },
                        new
                        {
                            Id = 14,
                            AuthorName = "Владимир Сорокина",
                            DateTime = new DateTime(2020, 4, 15, 20, 27, 26, 56, DateTimeKind.Utc).AddTicks(4264),
                            OrganizationEmail = "valeriya_ershov31@yandex.ru",
                            OrganizationName = "НаноТех",
                            ProductName = "Аналитическая платформа",
                            TechnologyName = "Доставка"
                        },
                        new
                        {
                            Id = 15,
                            AuthorName = "Светлана Брагин",
                            DateTime = new DateTime(2023, 8, 28, 13, 8, 36, 536, DateTimeKind.Utc).AddTicks(123),
                            OrganizationEmail = "arina35@yandex.ru",
                            OrganizationName = "ТехноСтар",
                            ProductName = "Графический чип",
                            TechnologyName = "Доставка"
                        },
                        new
                        {
                            Id = 16,
                            AuthorName = "Лаврентий Савельев",
                            DateTime = new DateTime(2023, 4, 1, 4, 46, 9, 952, DateTimeKind.Utc).AddTicks(9947),
                            OrganizationEmail = "alina.mironova@yandex.ru",
                            OrganizationName = "РобоТех",
                            ProductName = "Графический чип",
                            TechnologyName = "Доставка"
                        },
                        new
                        {
                            Id = 17,
                            AuthorName = "Людмила Исаков",
                            DateTime = new DateTime(2020, 5, 5, 19, 7, 53, 907, DateTimeKind.Utc).AddTicks(5932),
                            OrganizationEmail = "denis13@gmail.com",
                            OrganizationName = "ГлобалТех",
                            ProductName = "Программное обеспечение",
                            TechnologyName = "Нейросеть"
                        },
                        new
                        {
                            Id = 18,
                            AuthorName = "Альберт Комиссарова",
                            DateTime = new DateTime(2022, 8, 7, 22, 53, 9, 526, DateTimeKind.Utc).AddTicks(6933),
                            OrganizationEmail = "zoya74@hotmail.com",
                            OrganizationName = "ИнтелСистемы",
                            ProductName = "Процессор",
                            TechnologyName = "IoT платформа"
                        },
                        new
                        {
                            Id = 19,
                            AuthorName = "Станислав Лукин",
                            DateTime = new DateTime(2023, 11, 6, 3, 6, 38, 34, DateTimeKind.Utc).AddTicks(9828),
                            OrganizationEmail = "raisa_belyaev56@yandex.ru",
                            OrganizationName = "ИнноТех",
                            ProductName = "Устройство связи",
                            TechnologyName = "ИИ"
                        },
                        new
                        {
                            Id = 20,
                            AuthorName = "Мария Гусева",
                            DateTime = new DateTime(2022, 10, 30, 7, 51, 15, 214, DateTimeKind.Utc).AddTicks(1045),
                            OrganizationEmail = "margarita.gorshkov@ya.ru",
                            OrganizationName = "СофтТек",
                            ProductName = "Аналитическая платформа",
                            TechnologyName = "IoT платформа"
                        },
                        new
                        {
                            Id = 21,
                            AuthorName = "Максим Тимофеев",
                            DateTime = new DateTime(2020, 5, 3, 5, 5, 36, 862, DateTimeKind.Utc).AddTicks(576),
                            OrganizationEmail = "aleksei_rodionova@yandex.ru",
                            OrganizationName = "СофтТек",
                            ProductName = "Устройство связи",
                            TechnologyName = "Нейросеть"
                        },
                        new
                        {
                            Id = 22,
                            AuthorName = "Галина Сорокин",
                            DateTime = new DateTime(2024, 6, 16, 20, 2, 11, 335, DateTimeKind.Utc).AddTicks(5448),
                            OrganizationEmail = "yurii64@yandex.ru",
                            OrganizationName = "ИнфоСистемы",
                            ProductName = "Программное обеспечение",
                            TechnologyName = "ИИ"
                        },
                        new
                        {
                            Id = 23,
                            AuthorName = "Семён Емельянова",
                            DateTime = new DateTime(2024, 11, 28, 5, 57, 40, 509, DateTimeKind.Utc).AddTicks(175),
                            OrganizationEmail = "stepan.vinogradov6@yahoo.com",
                            OrganizationName = "ГиперСофт",
                            ProductName = "Аналитическая платформа",
                            TechnologyName = "Нейросеть"
                        },
                        new
                        {
                            Id = 24,
                            AuthorName = "Мария Муравьева",
                            DateTime = new DateTime(2022, 12, 2, 19, 30, 28, 713, DateTimeKind.Utc).AddTicks(7928),
                            OrganizationEmail = "zoya.baranov@ya.ru",
                            OrganizationName = "ГиперСофт",
                            ProductName = "Аналитическая платформа",
                            TechnologyName = "IoT платформа"
                        },
                        new
                        {
                            Id = 25,
                            AuthorName = "Алина Харитонова",
                            DateTime = new DateTime(2023, 8, 1, 15, 7, 44, 819, DateTimeKind.Utc).AddTicks(2415),
                            OrganizationEmail = "valentina_mukhin@yandex.ru",
                            OrganizationName = "НаноТех",
                            ProductName = "Сенсор",
                            TechnologyName = "Машинное обучение"
                        },
                        new
                        {
                            Id = 26,
                            AuthorName = "Валентина Якушев",
                            DateTime = new DateTime(2024, 5, 16, 23, 52, 48, 710, DateTimeKind.Utc).AddTicks(7288),
                            OrganizationEmail = "anastasiya_rybakov@hotmail.com",
                            OrganizationName = "НаноТех",
                            ProductName = "Сенсор",
                            TechnologyName = "Машинное обучение"
                        },
                        new
                        {
                            Id = 27,
                            AuthorName = "Виктория Жданова",
                            DateTime = new DateTime(2022, 7, 29, 5, 56, 6, 109, DateTimeKind.Utc).AddTicks(4283),
                            OrganizationEmail = "oksana_zueva@yahoo.com",
                            OrganizationName = "РобоТех",
                            ProductName = "Сенсор",
                            TechnologyName = "Квантовые вычисления"
                        },
                        new
                        {
                            Id = 28,
                            AuthorName = "Нина Белоусов",
                            DateTime = new DateTime(2020, 6, 3, 9, 20, 28, 665, DateTimeKind.Utc).AddTicks(6842),
                            OrganizationEmail = "artyom93@hotmail.com",
                            OrganizationName = "ГиперСофт",
                            ProductName = "Графический чип",
                            TechnologyName = "Доставка"
                        },
                        new
                        {
                            Id = 29,
                            AuthorName = "Мария Горбачева",
                            DateTime = new DateTime(2023, 11, 25, 12, 44, 39, 41, DateTimeKind.Utc).AddTicks(8914),
                            OrganizationEmail = "ivan_nesterova88@gmail.com",
                            OrganizationName = "СофтТек",
                            ProductName = "Система мониторинга",
                            TechnologyName = "Машинное обучение"
                        },
                        new
                        {
                            Id = 30,
                            AuthorName = "Алла Потапов",
                            DateTime = new DateTime(2020, 1, 30, 20, 57, 2, 154, DateTimeKind.Utc).AddTicks(4318),
                            OrganizationEmail = "darya_popova76@gmail.com",
                            OrganizationName = "ИнноТех",
                            ProductName = "Сенсор",
                            TechnologyName = "Распознавание речи"
                        },
                        new
                        {
                            Id = 31,
                            AuthorName = "Степан Соболев",
                            DateTime = new DateTime(2024, 6, 3, 15, 58, 2, 353, DateTimeKind.Utc).AddTicks(5306),
                            OrganizationEmail = "semyon_nesterov31@yandex.ru",
                            OrganizationName = "МегаТехнологии",
                            ProductName = "Аналитическая платформа",
                            TechnologyName = "Машинное обучение"
                        },
                        new
                        {
                            Id = 32,
                            AuthorName = "Антонида Киселева",
                            DateTime = new DateTime(2021, 1, 29, 8, 48, 22, 148, DateTimeKind.Utc).AddTicks(9217),
                            OrganizationEmail = "anna_ivanov@gmail.com",
                            OrganizationName = "ГиперСофт",
                            ProductName = "Сенсор",
                            TechnologyName = "Машинное обучение"
                        },
                        new
                        {
                            Id = 33,
                            AuthorName = "Зинаида Вишняков",
                            DateTime = new DateTime(2022, 11, 23, 14, 1, 12, 44, DateTimeKind.Utc).AddTicks(8475),
                            OrganizationEmail = "sofiya.bespalov@gmail.com",
                            OrganizationName = "НаноТех",
                            ProductName = "Сенсор",
                            TechnologyName = "IoT платформа"
                        },
                        new
                        {
                            Id = 34,
                            AuthorName = "Анастасия Субботин",
                            DateTime = new DateTime(2021, 5, 4, 13, 51, 28, 738, DateTimeKind.Utc).AddTicks(9125),
                            OrganizationEmail = "viktor.vladimirov75@mail.ru",
                            OrganizationName = "ИнфоСистемы",
                            ProductName = "Устройство связи",
                            TechnologyName = "Распознавание речи"
                        },
                        new
                        {
                            Id = 35,
                            AuthorName = "Василиса Тарасова",
                            DateTime = new DateTime(2020, 10, 15, 7, 53, 29, 676, DateTimeKind.Utc).AddTicks(4028),
                            OrganizationEmail = "dmitrii_fedotov@yandex.ru",
                            OrganizationName = "ГиперСофт",
                            ProductName = "Программное обеспечение",
                            TechnologyName = "Распознавание речи"
                        },
                        new
                        {
                            Id = 36,
                            AuthorName = "Ангелина Кулагин",
                            DateTime = new DateTime(2024, 2, 5, 1, 21, 38, 154, DateTimeKind.Utc).AddTicks(1331),
                            OrganizationEmail = "taisiya_fedorova@gmail.com",
                            OrganizationName = "ИнфоСистемы",
                            ProductName = "Устройство связи",
                            TechnologyName = "IoT платформа"
                        },
                        new
                        {
                            Id = 37,
                            AuthorName = "Василий Маслов",
                            DateTime = new DateTime(2022, 4, 10, 16, 54, 31, 767, DateTimeKind.Utc).AddTicks(7328),
                            OrganizationEmail = "fyodor11@yandex.ru",
                            OrganizationName = "ГлобалТех",
                            ProductName = "Программное обеспечение",
                            TechnologyName = "Нейросеть"
                        },
                        new
                        {
                            Id = 38,
                            AuthorName = "Сергей Козлов",
                            DateTime = new DateTime(2020, 5, 27, 1, 53, 26, 652, DateTimeKind.Utc).AddTicks(8218),
                            OrganizationEmail = "klavdiya_evdokimova44@yandex.ru",
                            OrganizationName = "ГиперСофт",
                            ProductName = "Сенсор",
                            TechnologyName = "IoT платформа"
                        },
                        new
                        {
                            Id = 39,
                            AuthorName = "Герман Дроздов",
                            DateTime = new DateTime(2022, 10, 1, 21, 15, 3, 316, DateTimeKind.Utc).AddTicks(1835),
                            OrganizationEmail = "luka12@ya.ru",
                            OrganizationName = "СофтТек",
                            ProductName = "Процессор",
                            TechnologyName = "Распознавание речи"
                        },
                        new
                        {
                            Id = 40,
                            AuthorName = "Алина Попова",
                            DateTime = new DateTime(2021, 7, 18, 0, 25, 58, 961, DateTimeKind.Utc).AddTicks(9580),
                            OrganizationEmail = "vasilii48@gmail.com",
                            OrganizationName = "ГлобалТех",
                            ProductName = "Аналитическая платформа",
                            TechnologyName = "ИИ"
                        },
                        new
                        {
                            Id = 41,
                            AuthorName = "Ульяна Щербакова",
                            DateTime = new DateTime(2020, 6, 25, 9, 19, 30, 629, DateTimeKind.Utc).AddTicks(634),
                            OrganizationEmail = "vasilii74@gmail.com",
                            OrganizationName = "НаноТех",
                            ProductName = "Аналитическая платформа",
                            TechnologyName = "ИИ"
                        },
                        new
                        {
                            Id = 42,
                            AuthorName = "Валентина Коновалова",
                            DateTime = new DateTime(2021, 2, 28, 18, 7, 28, 965, DateTimeKind.Utc).AddTicks(5968),
                            OrganizationEmail = "grigorii.grishina@gmail.com",
                            OrganizationName = "НаноТех",
                            ProductName = "Аналитическая платформа",
                            TechnologyName = "Распознавание речи"
                        },
                        new
                        {
                            Id = 43,
                            AuthorName = "Лариса Степанов",
                            DateTime = new DateTime(2021, 1, 28, 13, 27, 16, 799, DateTimeKind.Utc).AddTicks(7465),
                            OrganizationEmail = "alevtina.kulakova75@ya.ru",
                            OrganizationName = "ИнноТех",
                            ProductName = "Аналитическая платформа",
                            TechnologyName = "Распознавание речи"
                        },
                        new
                        {
                            Id = 44,
                            AuthorName = "Татьяна Денисов",
                            DateTime = new DateTime(2021, 4, 5, 6, 44, 52, 282, DateTimeKind.Utc).AddTicks(5957),
                            OrganizationEmail = "nikolai_blokhina11@yandex.ru",
                            OrganizationName = "СофтТек",
                            ProductName = "Сенсор",
                            TechnologyName = "Распознавание речи"
                        },
                        new
                        {
                            Id = 45,
                            AuthorName = "Зинаида Трофимова",
                            DateTime = new DateTime(2020, 1, 27, 4, 18, 44, 179, DateTimeKind.Utc).AddTicks(2745),
                            OrganizationEmail = "anatolii66@ya.ru",
                            OrganizationName = "ИнфоСистемы",
                            ProductName = "Сенсор",
                            TechnologyName = "Нейросеть"
                        },
                        new
                        {
                            Id = 46,
                            AuthorName = "Валентина Комаров",
                            DateTime = new DateTime(2020, 10, 18, 16, 45, 26, 54, DateTimeKind.Utc).AddTicks(5894),
                            OrganizationEmail = "angelina.kryukov@mail.ru",
                            OrganizationName = "РобоТех",
                            ProductName = "Аналитическая платформа",
                            TechnologyName = "ИИ"
                        },
                        new
                        {
                            Id = 47,
                            AuthorName = "Анна Горбачева",
                            DateTime = new DateTime(2024, 5, 23, 0, 53, 38, 196, DateTimeKind.Utc).AddTicks(6075),
                            OrganizationEmail = "evgenii.lebeeva@ya.ru",
                            OrganizationName = "ИнфоСистемы",
                            ProductName = "Устройство связи",
                            TechnologyName = "Машинное обучение"
                        },
                        new
                        {
                            Id = 48,
                            AuthorName = "Римма Кошелев",
                            DateTime = new DateTime(2021, 6, 25, 17, 5, 28, 318, DateTimeKind.Utc).AddTicks(3414),
                            OrganizationEmail = "matvei42@gmail.com",
                            OrganizationName = "НаноТех",
                            ProductName = "Графический чип",
                            TechnologyName = "Распознавание речи"
                        },
                        new
                        {
                            Id = 49,
                            AuthorName = "Юлия Кулагина",
                            DateTime = new DateTime(2023, 1, 28, 12, 43, 16, 298, DateTimeKind.Utc).AddTicks(8125),
                            OrganizationEmail = "aleksandra.shukin19@mail.ru",
                            OrganizationName = "РобоТех",
                            ProductName = "Устройство связи",
                            TechnologyName = "ИИ"
                        },
                        new
                        {
                            Id = 50,
                            AuthorName = "Никита Кузьмина",
                            DateTime = new DateTime(2020, 5, 1, 4, 1, 17, 840, DateTimeKind.Utc).AddTicks(7820),
                            OrganizationEmail = "vadim50@ya.ru",
                            OrganizationName = "ИнтелСистемы",
                            ProductName = "Аналитическая платформа",
                            TechnologyName = "Машинное обучение"
                        },
                        new
                        {
                            Id = 51,
                            AuthorName = "Герман Кудряшов",
                            DateTime = new DateTime(2023, 11, 28, 16, 32, 46, 498, DateTimeKind.Utc).AddTicks(663),
                            OrganizationEmail = "arsenii.uvarova21@hotmail.com",
                            OrganizationName = "СофтТек",
                            ProductName = "Система мониторинга",
                            TechnologyName = "Квантовые вычисления"
                        },
                        new
                        {
                            Id = 52,
                            AuthorName = "Раиса Рябов",
                            DateTime = new DateTime(2020, 5, 15, 8, 0, 23, 802, DateTimeKind.Utc).AddTicks(2252),
                            OrganizationEmail = "elizaveta77@mail.ru",
                            OrganizationName = "НаноТех",
                            ProductName = "Процессор",
                            TechnologyName = "Распознавание речи"
                        },
                        new
                        {
                            Id = 53,
                            AuthorName = "Аркадий Мамонтов",
                            DateTime = new DateTime(2022, 8, 22, 3, 47, 21, 655, DateTimeKind.Utc).AddTicks(3960),
                            OrganizationEmail = "gennadii49@ya.ru",
                            OrganizationName = "СофтТек",
                            ProductName = "Графический чип",
                            TechnologyName = "ИИ"
                        },
                        new
                        {
                            Id = 54,
                            AuthorName = "Жанна Цветков",
                            DateTime = new DateTime(2021, 6, 9, 18, 10, 23, 723, DateTimeKind.Utc).AddTicks(2635),
                            OrganizationEmail = "zoya.timofeeva@mail.ru",
                            OrganizationName = "ИнноТех",
                            ProductName = "Система мониторинга",
                            TechnologyName = "Распознавание речи"
                        },
                        new
                        {
                            Id = 55,
                            AuthorName = "Дмитрий Муравьева",
                            DateTime = new DateTime(2022, 7, 16, 5, 27, 1, 713, DateTimeKind.Utc).AddTicks(3892),
                            OrganizationEmail = "regina.zimina92@ya.ru",
                            OrganizationName = "СофтТек",
                            ProductName = "Сенсор",
                            TechnologyName = "Машинное обучение"
                        },
                        new
                        {
                            Id = 56,
                            AuthorName = "Игнатий Киселев",
                            DateTime = new DateTime(2021, 2, 1, 13, 8, 25, 681, DateTimeKind.Utc).AddTicks(6522),
                            OrganizationEmail = "anzhela.artemev@mail.ru",
                            OrganizationName = "ГлобалТех",
                            ProductName = "Аналитическая платформа",
                            TechnologyName = "Доставка"
                        },
                        new
                        {
                            Id = 57,
                            AuthorName = "Семён Дорофеева",
                            DateTime = new DateTime(2023, 8, 19, 14, 27, 18, 429, DateTimeKind.Utc).AddTicks(4422),
                            OrganizationEmail = "german_samoilova@yahoo.com",
                            OrganizationName = "ИнфоСистемы",
                            ProductName = "Процессор",
                            TechnologyName = "Распознавание речи"
                        },
                        new
                        {
                            Id = 58,
                            AuthorName = "Сергей Зуева",
                            DateTime = new DateTime(2020, 4, 25, 7, 55, 7, 289, DateTimeKind.Utc).AddTicks(8200),
                            OrganizationEmail = "makar_fedotova@yandex.ru",
                            OrganizationName = "ТехноСтар",
                            ProductName = "Система мониторинга",
                            TechnologyName = "Нейросеть"
                        },
                        new
                        {
                            Id = 59,
                            AuthorName = "Сергей Веселова",
                            DateTime = new DateTime(2024, 5, 23, 7, 59, 7, 541, DateTimeKind.Utc).AddTicks(1679),
                            OrganizationEmail = "sergei_nesterova98@yandex.ru",
                            OrganizationName = "ИнтелСистемы",
                            ProductName = "Аналитическая платформа",
                            TechnologyName = "Квантовые вычисления"
                        },
                        new
                        {
                            Id = 60,
                            AuthorName = "Владислав Киселев",
                            DateTime = new DateTime(2020, 12, 25, 6, 33, 42, 705, DateTimeKind.Utc).AddTicks(3928),
                            OrganizationEmail = "vadim82@ya.ru",
                            OrganizationName = "ГлобалТех",
                            ProductName = "Аналитическая платформа",
                            TechnologyName = "ИИ"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
