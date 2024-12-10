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
                        .Annotation("Npgsql:TsVectorConfig", "russian")
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
                    { 1, "Марина Галкина", new DateTime(2021, 2, 7, 14, 48, 37, 333, DateTimeKind.Utc).AddTicks(4046), "elizaveta_turova@mail.ru", "ИнноТех", "Графический чип", "Нейросеть" },
                    { 2, "Виталий Кондратьев", new DateTime(2021, 10, 23, 3, 33, 20, 196, DateTimeKind.Utc).AddTicks(3142), "vladimir_odincov88@gmail.com", "СофтТек", "Устройство связи", "Нейросеть" },
                    { 3, "Евгений Матвеев", new DateTime(2023, 5, 29, 10, 38, 4, 983, DateTimeKind.Utc).AddTicks(4273), "arsenii.bespalova@hotmail.com", "ИнфоСистемы", "Аналитическая платформа", "Машинное обучение" },
                    { 4, "Сергей Агафонов", new DateTime(2021, 1, 7, 20, 56, 26, 82, DateTimeKind.Utc).AddTicks(2865), "darya96@yahoo.com", "НаноТех", "Сенсор", "Машинное обучение" },
                    { 5, "Анастасия Дмитриев", new DateTime(2021, 5, 8, 2, 25, 16, 606, DateTimeKind.Utc).AddTicks(5312), "egor_kiseleva@yandex.ru", "ГлобалТех", "Программное обеспечение", "ИИ" },
                    { 6, "Даниил Брагина", new DateTime(2024, 4, 11, 21, 28, 0, 834, DateTimeKind.Utc).AddTicks(4279), "ignatii29@hotmail.com", "НаноТех", "Программное обеспечение", "Нейросеть" },
                    { 7, "Георгий Рожкова", new DateTime(2021, 9, 20, 20, 58, 25, 903, DateTimeKind.Utc).AddTicks(281), "varvara.shiryaev@yandex.ru", "ИнфоСистемы", "Система мониторинга", "Машинное обучение" },
                    { 8, "Раиса Калинин", new DateTime(2021, 1, 26, 19, 33, 9, 205, DateTimeKind.Utc).AddTicks(8963), "vitalii40@mail.ru", "ИнфоСистемы", "Сенсор", "Нейросеть" },
                    { 9, "Анфиса Константинова", new DateTime(2023, 5, 26, 12, 54, 51, 828, DateTimeKind.Utc).AddTicks(1530), "zhanna_panfilova@yahoo.com", "ИнтелСистемы", "Графический чип", "Доставка" },
                    { 10, "Лариса Филиппова", new DateTime(2023, 5, 10, 21, 21, 35, 216, DateTimeKind.Utc).AddTicks(105), "vera.orekhov@hotmail.com", "ИнтелСистемы", "Устройство связи", "ИИ" },
                    { 11, "Фёдор Моисеев", new DateTime(2020, 5, 28, 18, 58, 4, 588, DateTimeKind.Utc).AddTicks(6270), "semyon33@yahoo.com", "РобоТех", "Сенсор", "Распознавание речи" },
                    { 12, "Арина Филатов", new DateTime(2024, 2, 4, 23, 20, 3, 751, DateTimeKind.Utc).AddTicks(2911), "vladislav_panfilova52@mail.ru", "ИнфоСистемы", "Устройство связи", "Нейросеть" },
                    { 13, "Регина Никифорова", new DateTime(2024, 4, 4, 1, 29, 23, 332, DateTimeKind.Utc).AddTicks(9672), "arkadii.tikhonov39@ya.ru", "ГлобалТех", "Программное обеспечение", "IoT платформа" },
                    { 14, "Зинаида Моисеева", new DateTime(2024, 3, 2, 13, 15, 32, 248, DateTimeKind.Utc).AddTicks(3598), "regina_kosheleva59@hotmail.com", "РобоТех", "Система мониторинга", "Распознавание речи" },
                    { 15, "Геннадий Иванова", new DateTime(2023, 2, 7, 8, 3, 19, 703, DateTimeKind.Utc).AddTicks(3634), "marina54@gmail.com", "РобоТех", "Сенсор", "Квантовые вычисления" },
                    { 16, "Герман Королев", new DateTime(2021, 2, 25, 6, 26, 51, 664, DateTimeKind.Utc).AddTicks(7811), "igor_dementeva29@mail.ru", "ГиперСофт", "Сенсор", "IoT платформа" },
                    { 17, "Анжелика Лаврентьев", new DateTime(2020, 5, 24, 14, 19, 39, 956, DateTimeKind.Utc).AddTicks(6736), "lavrentii_rogov@yandex.ru", "ИнтелСистемы", "Программное обеспечение", "Машинное обучение" },
                    { 18, "Антонина Ефимов", new DateTime(2024, 11, 1, 0, 8, 53, 856, DateTimeKind.Utc).AddTicks(5098), "leonid45@yandex.ru", "ГлобалТех", "Процессор", "Квантовые вычисления" },
                    { 19, "Ольга Крылов", new DateTime(2021, 6, 20, 5, 9, 58, 998, DateTimeKind.Utc).AddTicks(3575), "lyudmila.subbotina64@ya.ru", "МегаТехнологии", "Программное обеспечение", "ИИ" },
                    { 20, "Фёдор Анисимова", new DateTime(2022, 9, 24, 3, 48, 23, 366, DateTimeKind.Utc).AddTicks(7817), "georgii_pestova50@ya.ru", "ИнноТех", "Система мониторинга", "ИИ" },
                    { 21, "Василий Блохин", new DateTime(2022, 3, 23, 4, 42, 28, 272, DateTimeKind.Utc).AddTicks(5414), "aleksandr19@mail.ru", "ИнтелСистемы", "Сенсор", "Распознавание речи" },
                    { 22, "Вячеслав Соколова", new DateTime(2020, 8, 30, 1, 17, 34, 144, DateTimeKind.Utc).AddTicks(2715), "ulyana.burova@ya.ru", "МегаТехнологии", "Аналитическая платформа", "IoT платформа" },
                    { 23, "Анатолий Щербакова", new DateTime(2024, 6, 8, 0, 33, 43, 467, DateTimeKind.Utc).AddTicks(3604), "roman.sysoeva29@yahoo.com", "ТехноСтар", "Графический чип", "Нейросеть" },
                    { 24, "Матвей Селезнева", new DateTime(2024, 8, 24, 21, 53, 9, 641, DateTimeKind.Utc).AddTicks(6384), "veronika_agafonov49@mail.ru", "ИнтелСистемы", "Сенсор", "ИИ" },
                    { 25, "Надежда Богданов", new DateTime(2024, 12, 9, 23, 9, 9, 684, DateTimeKind.Utc).AddTicks(4656), "olga.belyakova65@ya.ru", "МегаТехнологии", "Система мониторинга", "IoT платформа" },
                    { 26, "Виталий Кулагина", new DateTime(2022, 7, 17, 1, 16, 38, 551, DateTimeKind.Utc).AddTicks(2612), "alla_knyazeva77@mail.ru", "ИнтелСистемы", "Процессор", "Квантовые вычисления" },
                    { 27, "Ангелина Капустина", new DateTime(2022, 10, 3, 20, 59, 13, 393, DateTimeKind.Utc).AddTicks(8434), "mikhail.belozerova@yahoo.com", "ИнфоСистемы", "Устройство связи", "ИИ" },
                    { 28, "Анна Абрамов", new DateTime(2021, 4, 30, 1, 2, 43, 108, DateTimeKind.Utc).AddTicks(5095), "roman52@mail.ru", "ГлобалТех", "Графический чип", "ИИ" },
                    { 29, "Наталья Алексеева", new DateTime(2022, 9, 29, 18, 19, 7, 210, DateTimeKind.Utc).AddTicks(2309), "darya_petrov95@mail.ru", "ИнфоСистемы", "Система мониторинга", "ИИ" },
                    { 30, "Арсений Белов", new DateTime(2020, 2, 27, 5, 43, 42, 593, DateTimeKind.Utc).AddTicks(8260), "viktor_naumova49@hotmail.com", "НаноТех", "Графический чип", "ИИ" },
                    { 31, "Антон Дроздова", new DateTime(2022, 12, 9, 4, 13, 0, 838, DateTimeKind.Utc).AddTicks(431), "arina_seliverstov7@yahoo.com", "ТехноСтар", "Система мониторинга", "ИИ" },
                    { 32, "Даниил Веселова", new DateTime(2020, 2, 11, 3, 56, 18, 913, DateTimeKind.Utc).AddTicks(2321), "albert8@yahoo.com", "ТехноСтар", "Программное обеспечение", "Доставка" },
                    { 33, "Юлия Сергеева", new DateTime(2020, 5, 26, 23, 51, 32, 699, DateTimeKind.Utc).AddTicks(9874), "andrei_bykov@ya.ru", "ИнноТех", "Программное обеспечение", "Распознавание речи" },
                    { 34, "Степан Белозеров", new DateTime(2022, 8, 3, 21, 36, 30, 421, DateTimeKind.Utc).AddTicks(9147), "kira.chernov0@gmail.com", "ГлобалТех", "Графический чип", "Распознавание речи" },
                    { 35, "Виктор Аксенова", new DateTime(2021, 8, 5, 19, 30, 13, 196, DateTimeKind.Utc).AddTicks(7770), "alyona_naumova@gmail.com", "ИнноТех", "Процессор", "IoT платформа" },
                    { 36, "Артём Ширяев", new DateTime(2022, 12, 22, 5, 58, 57, 992, DateTimeKind.Utc).AddTicks(1948), "anton.kharitonova@ya.ru", "СофтТек", "Графический чип", "IoT платформа" },
                    { 37, "Константин Быков", new DateTime(2020, 12, 27, 2, 31, 27, 430, DateTimeKind.Utc).AddTicks(6819), "rimma.mishina@yandex.ru", "МегаТехнологии", "Аналитическая платформа", "Машинное обучение" },
                    { 38, "Валерий Власов", new DateTime(2021, 3, 3, 23, 58, 55, 503, DateTimeKind.Utc).AddTicks(7978), "artyom41@ya.ru", "МегаТехнологии", "Сенсор", "Нейросеть" },
                    { 39, "Зоя Киселев", new DateTime(2021, 1, 11, 3, 17, 6, 31, DateTimeKind.Utc).AddTicks(2007), "marina_eliseev@yahoo.com", "ГиперСофт", "Сенсор", "Нейросеть" },
                    { 40, "Ярослав Шилов", new DateTime(2020, 7, 9, 12, 24, 5, 978, DateTimeKind.Utc).AddTicks(3430), "leonid.bogdanov58@gmail.com", "ГлобалТех", "Процессор", "Нейросеть" },
                    { 41, "Лариса Веселов", new DateTime(2021, 4, 3, 16, 24, 54, 340, DateTimeKind.Utc).AddTicks(1355), "grigorii.davydov@ya.ru", "НаноТех", "Графический чип", "Машинное обучение" },
                    { 42, "Олег Агафонова", new DateTime(2023, 8, 26, 10, 2, 24, 856, DateTimeKind.Utc).AddTicks(3884), "olga.kulagin@gmail.com", "ГлобалТех", "Система мониторинга", "Доставка" },
                    { 43, "Антонина Беспалов", new DateTime(2023, 7, 12, 8, 47, 53, 207, DateTimeKind.Utc).AddTicks(9367), "naezhda.sitnikov89@yandex.ru", "ИнноТех", "Процессор", "ИИ" },
                    { 44, "Виталий Мартынов", new DateTime(2021, 1, 11, 11, 55, 12, 464, DateTimeKind.Utc).AddTicks(2380), "anatolii24@yahoo.com", "ГиперСофт", "Система мониторинга", "Квантовые вычисления" },
                    { 45, "Денис Селиверстов", new DateTime(2020, 1, 25, 1, 12, 10, 332, DateTimeKind.Utc).AddTicks(7704), "valentin_korolev28@mail.ru", "ИнфоСистемы", "Система мониторинга", "Распознавание речи" },
                    { 46, "Наталья Корнилов", new DateTime(2021, 5, 31, 3, 24, 37, 452, DateTimeKind.Utc).AddTicks(7971), "evgeniya_arkhipov@yandex.ru", "НаноТех", "Система мониторинга", "Распознавание речи" },
                    { 47, "Лариса Марков", new DateTime(2024, 9, 15, 3, 47, 6, 97, DateTimeKind.Utc).AddTicks(9268), "viktor.sharov@hotmail.com", "МегаТехнологии", "Сенсор", "IoT платформа" },
                    { 48, "Дарья Калинина", new DateTime(2020, 5, 15, 20, 25, 34, 262, DateTimeKind.Utc).AddTicks(7709), "semyon.timofeeva38@mail.ru", "ТехноСтар", "Аналитическая платформа", "Машинное обучение" },
                    { 49, "Антонина Маслов", new DateTime(2022, 3, 26, 17, 56, 58, 503, DateTimeKind.Utc).AddTicks(6005), "maksim.krylova26@yandex.ru", "ТехноСтар", "Программное обеспечение", "ИИ" },
                    { 50, "Борис Селиверстова", new DateTime(2024, 3, 27, 23, 26, 36, 385, DateTimeKind.Utc).AddTicks(2384), "vera53@mail.ru", "ИнноТех", "Графический чип", "ИИ" },
                    { 51, "Александра Коновалова", new DateTime(2021, 7, 19, 16, 47, 28, 332, DateTimeKind.Utc).AddTicks(7535), "lidiya20@hotmail.com", "НаноТех", "Программное обеспечение", "Доставка" },
                    { 52, "Таисия Богданова", new DateTime(2023, 6, 30, 16, 52, 7, 656, DateTimeKind.Utc).AddTicks(5558), "rimma_sysoev43@hotmail.com", "ИнфоСистемы", "Сенсор", "IoT платформа" },
                    { 53, "Никита Блохин", new DateTime(2022, 7, 23, 19, 20, 13, 75, DateTimeKind.Utc).AddTicks(9590), "alevtina_silin11@hotmail.com", "СофтТек", "Система мониторинга", "Квантовые вычисления" },
                    { 54, "Степан Бобылева", new DateTime(2024, 8, 11, 12, 20, 57, 468, DateTimeKind.Utc).AddTicks(4623), "ignatii82@ya.ru", "ГиперСофт", "Процессор", "Нейросеть" },
                    { 55, "Нина Савельев", new DateTime(2020, 2, 23, 11, 17, 10, 555, DateTimeKind.Utc).AddTicks(8556), "taisiya55@hotmail.com", "ИнноТех", "Процессор", "Доставка" },
                    { 56, "Даниил Петухов", new DateTime(2022, 3, 23, 14, 33, 41, 654, DateTimeKind.Utc).AddTicks(352), "lavrentii_kovalev86@gmail.com", "МегаТехнологии", "Устройство связи", "Квантовые вычисления" },
                    { 57, "Жанна Федоров", new DateTime(2021, 7, 25, 14, 48, 29, 350, DateTimeKind.Utc).AddTicks(2), "ulyana15@mail.ru", "ГлобалТех", "Процессор", "Машинное обучение" },
                    { 58, "Анна Константинова", new DateTime(2022, 11, 16, 13, 17, 53, 992, DateTimeKind.Utc).AddTicks(3747), "artyom37@ya.ru", "РобоТех", "Процессор", "Доставка" },
                    { 59, "Дмитрий Быкова", new DateTime(2019, 12, 27, 12, 44, 50, 997, DateTimeKind.Utc).AddTicks(581), "arina.zimina7@hotmail.com", "ИнноТех", "Устройство связи", "Машинное обучение" },
                    { 60, "Валерий Фокина", new DateTime(2020, 8, 22, 21, 12, 11, 285, DateTimeKind.Utc).AddTicks(5531), "arsenii_kuznecova@yahoo.com", "ИнфоСистемы", "Сенсор", "Квантовые вычисления" }
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
