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
                        .Annotation("Npgsql:TsVectorProperties", new[] { "AuthorName", "OrganizationName", "TechnologyName" })
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
                    { 1, "Владислав Костин", new DateTime(2023, 11, 7, 3, 16, 15, 716, DateTimeKind.Utc).AddTicks(1236), "georgii22@hotmail.com", "МегаТехнологии", "Сенсор", "Квантовые вычисления" },
                    { 2, "Егор Петров", new DateTime(2021, 6, 23, 21, 25, 28, 24, DateTimeKind.Utc).AddTicks(7370), "grigorii_isakov91@hotmail.com", "ГлобалТех", "Система мониторинга", "Нейросеть" },
                    { 3, "Василий Мельникова", new DateTime(2022, 5, 31, 13, 26, 6, 478, DateTimeKind.Utc).AddTicks(8809), "angelina.potapov@yahoo.com", "ИнфоСистемы", "Аналитическая платформа", "Распознавание речи" },
                    { 4, "Аркадий Гусева", new DateTime(2021, 10, 31, 15, 17, 49, 38, DateTimeKind.Utc).AddTicks(9551), "vyacheslav.anisimov@ya.ru", "ИнтелСистемы", "Система мониторинга", "Нейросеть" },
                    { 5, "Роман Дорофеев", new DateTime(2024, 7, 15, 8, 13, 32, 545, DateTimeKind.Utc).AddTicks(3851), "roman_lukina22@hotmail.com", "ИнноТех", "Устройство связи", "Доставка" },
                    { 6, "Ирина Воронова", new DateTime(2020, 9, 14, 19, 46, 28, 40, DateTimeKind.Utc).AddTicks(121), "anton.kolesnikov71@hotmail.com", "ИнноТех", "Графический чип", "IoT платформа" },
                    { 7, "Эдуард Ларионов", new DateTime(2021, 10, 17, 10, 3, 58, 742, DateTimeKind.Utc).AddTicks(8094), "raisa68@ya.ru", "МегаТехнологии", "Система мониторинга", "ИИ" },
                    { 8, "Вадим Суворов", new DateTime(2022, 10, 29, 22, 56, 26, 497, DateTimeKind.Utc).AddTicks(5373), "viktoriya_naumov57@ya.ru", "ТехноСтар", "Система мониторинга", "Нейросеть" },
                    { 9, "Владимир Трофимова", new DateTime(2020, 5, 11, 21, 43, 44, 89, DateTimeKind.Utc).AddTicks(8971), "aleksandra_voronov@yandex.ru", "СофтТек", "Программное обеспечение", "Квантовые вычисления" },
                    { 10, "Зинаида Игнатова", new DateTime(2022, 10, 6, 22, 39, 40, 739, DateTimeKind.Utc).AddTicks(1075), "ulyana_simonov55@hotmail.com", "ГиперСофт", "Устройство связи", "Доставка" },
                    { 11, "Елена Фролова", new DateTime(2020, 10, 12, 7, 24, 24, 717, DateTimeKind.Utc).AddTicks(1130), "marina_agafonova@yahoo.com", "МегаТехнологии", "Система мониторинга", "ИИ" },
                    { 12, "Алевтина Зиновьев", new DateTime(2023, 5, 23, 21, 49, 4, 415, DateTimeKind.Utc).AddTicks(3063), "sofiya_ryabov20@ya.ru", "МегаТехнологии", "Система мониторинга", "IoT платформа" },
                    { 13, "Лаврентий Рябов", new DateTime(2021, 3, 24, 21, 51, 40, 828, DateTimeKind.Utc).AddTicks(3360), "natalya96@gmail.com", "ИнфоСистемы", "Программное обеспечение", "IoT платформа" },
                    { 14, "Владимир Сорокина", new DateTime(2020, 4, 15, 20, 27, 26, 56, DateTimeKind.Utc).AddTicks(4264), "valeriya_ershov31@yandex.ru", "НаноТех", "Аналитическая платформа", "Доставка" },
                    { 15, "Светлана Брагин", new DateTime(2023, 8, 28, 13, 8, 36, 536, DateTimeKind.Utc).AddTicks(123), "arina35@yandex.ru", "ТехноСтар", "Графический чип", "Доставка" },
                    { 16, "Лаврентий Савельев", new DateTime(2023, 4, 1, 4, 46, 9, 952, DateTimeKind.Utc).AddTicks(9947), "alina.mironova@yandex.ru", "РобоТех", "Графический чип", "Доставка" },
                    { 17, "Людмила Исаков", new DateTime(2020, 5, 5, 19, 7, 53, 907, DateTimeKind.Utc).AddTicks(5932), "denis13@gmail.com", "ГлобалТех", "Программное обеспечение", "Нейросеть" },
                    { 18, "Альберт Комиссарова", new DateTime(2022, 8, 7, 22, 53, 9, 526, DateTimeKind.Utc).AddTicks(6933), "zoya74@hotmail.com", "ИнтелСистемы", "Процессор", "IoT платформа" },
                    { 19, "Станислав Лукин", new DateTime(2023, 11, 6, 3, 6, 38, 34, DateTimeKind.Utc).AddTicks(9828), "raisa_belyaev56@yandex.ru", "ИнноТех", "Устройство связи", "ИИ" },
                    { 20, "Мария Гусева", new DateTime(2022, 10, 30, 7, 51, 15, 214, DateTimeKind.Utc).AddTicks(1045), "margarita.gorshkov@ya.ru", "СофтТек", "Аналитическая платформа", "IoT платформа" },
                    { 21, "Максим Тимофеев", new DateTime(2020, 5, 3, 5, 5, 36, 862, DateTimeKind.Utc).AddTicks(576), "aleksei_rodionova@yandex.ru", "СофтТек", "Устройство связи", "Нейросеть" },
                    { 22, "Галина Сорокин", new DateTime(2024, 6, 16, 20, 2, 11, 335, DateTimeKind.Utc).AddTicks(5448), "yurii64@yandex.ru", "ИнфоСистемы", "Программное обеспечение", "ИИ" },
                    { 23, "Семён Емельянова", new DateTime(2024, 11, 28, 5, 57, 40, 509, DateTimeKind.Utc).AddTicks(175), "stepan.vinogradov6@yahoo.com", "ГиперСофт", "Аналитическая платформа", "Нейросеть" },
                    { 24, "Мария Муравьева", new DateTime(2022, 12, 2, 19, 30, 28, 713, DateTimeKind.Utc).AddTicks(7928), "zoya.baranov@ya.ru", "ГиперСофт", "Аналитическая платформа", "IoT платформа" },
                    { 25, "Алина Харитонова", new DateTime(2023, 8, 1, 15, 7, 44, 819, DateTimeKind.Utc).AddTicks(2415), "valentina_mukhin@yandex.ru", "НаноТех", "Сенсор", "Машинное обучение" },
                    { 26, "Валентина Якушев", new DateTime(2024, 5, 16, 23, 52, 48, 710, DateTimeKind.Utc).AddTicks(7288), "anastasiya_rybakov@hotmail.com", "НаноТех", "Сенсор", "Машинное обучение" },
                    { 27, "Виктория Жданова", new DateTime(2022, 7, 29, 5, 56, 6, 109, DateTimeKind.Utc).AddTicks(4283), "oksana_zueva@yahoo.com", "РобоТех", "Сенсор", "Квантовые вычисления" },
                    { 28, "Нина Белоусов", new DateTime(2020, 6, 3, 9, 20, 28, 665, DateTimeKind.Utc).AddTicks(6842), "artyom93@hotmail.com", "ГиперСофт", "Графический чип", "Доставка" },
                    { 29, "Мария Горбачева", new DateTime(2023, 11, 25, 12, 44, 39, 41, DateTimeKind.Utc).AddTicks(8914), "ivan_nesterova88@gmail.com", "СофтТек", "Система мониторинга", "Машинное обучение" },
                    { 30, "Алла Потапов", new DateTime(2020, 1, 30, 20, 57, 2, 154, DateTimeKind.Utc).AddTicks(4318), "darya_popova76@gmail.com", "ИнноТех", "Сенсор", "Распознавание речи" },
                    { 31, "Степан Соболев", new DateTime(2024, 6, 3, 15, 58, 2, 353, DateTimeKind.Utc).AddTicks(5306), "semyon_nesterov31@yandex.ru", "МегаТехнологии", "Аналитическая платформа", "Машинное обучение" },
                    { 32, "Антонида Киселева", new DateTime(2021, 1, 29, 8, 48, 22, 148, DateTimeKind.Utc).AddTicks(9217), "anna_ivanov@gmail.com", "ГиперСофт", "Сенсор", "Машинное обучение" },
                    { 33, "Зинаида Вишняков", new DateTime(2022, 11, 23, 14, 1, 12, 44, DateTimeKind.Utc).AddTicks(8475), "sofiya.bespalov@gmail.com", "НаноТех", "Сенсор", "IoT платформа" },
                    { 34, "Анастасия Субботин", new DateTime(2021, 5, 4, 13, 51, 28, 738, DateTimeKind.Utc).AddTicks(9125), "viktor.vladimirov75@mail.ru", "ИнфоСистемы", "Устройство связи", "Распознавание речи" },
                    { 35, "Василиса Тарасова", new DateTime(2020, 10, 15, 7, 53, 29, 676, DateTimeKind.Utc).AddTicks(4028), "dmitrii_fedotov@yandex.ru", "ГиперСофт", "Программное обеспечение", "Распознавание речи" },
                    { 36, "Ангелина Кулагин", new DateTime(2024, 2, 5, 1, 21, 38, 154, DateTimeKind.Utc).AddTicks(1331), "taisiya_fedorova@gmail.com", "ИнфоСистемы", "Устройство связи", "IoT платформа" },
                    { 37, "Василий Маслов", new DateTime(2022, 4, 10, 16, 54, 31, 767, DateTimeKind.Utc).AddTicks(7328), "fyodor11@yandex.ru", "ГлобалТех", "Программное обеспечение", "Нейросеть" },
                    { 38, "Сергей Козлов", new DateTime(2020, 5, 27, 1, 53, 26, 652, DateTimeKind.Utc).AddTicks(8218), "klavdiya_evdokimova44@yandex.ru", "ГиперСофт", "Сенсор", "IoT платформа" },
                    { 39, "Герман Дроздов", new DateTime(2022, 10, 1, 21, 15, 3, 316, DateTimeKind.Utc).AddTicks(1835), "luka12@ya.ru", "СофтТек", "Процессор", "Распознавание речи" },
                    { 40, "Алина Попова", new DateTime(2021, 7, 18, 0, 25, 58, 961, DateTimeKind.Utc).AddTicks(9580), "vasilii48@gmail.com", "ГлобалТех", "Аналитическая платформа", "ИИ" },
                    { 41, "Ульяна Щербакова", new DateTime(2020, 6, 25, 9, 19, 30, 629, DateTimeKind.Utc).AddTicks(634), "vasilii74@gmail.com", "НаноТех", "Аналитическая платформа", "ИИ" },
                    { 42, "Валентина Коновалова", new DateTime(2021, 2, 28, 18, 7, 28, 965, DateTimeKind.Utc).AddTicks(5968), "grigorii.grishina@gmail.com", "НаноТех", "Аналитическая платформа", "Распознавание речи" },
                    { 43, "Лариса Степанов", new DateTime(2021, 1, 28, 13, 27, 16, 799, DateTimeKind.Utc).AddTicks(7465), "alevtina.kulakova75@ya.ru", "ИнноТех", "Аналитическая платформа", "Распознавание речи" },
                    { 44, "Татьяна Денисов", new DateTime(2021, 4, 5, 6, 44, 52, 282, DateTimeKind.Utc).AddTicks(5957), "nikolai_blokhina11@yandex.ru", "СофтТек", "Сенсор", "Распознавание речи" },
                    { 45, "Зинаида Трофимова", new DateTime(2020, 1, 27, 4, 18, 44, 179, DateTimeKind.Utc).AddTicks(2745), "anatolii66@ya.ru", "ИнфоСистемы", "Сенсор", "Нейросеть" },
                    { 46, "Валентина Комаров", new DateTime(2020, 10, 18, 16, 45, 26, 54, DateTimeKind.Utc).AddTicks(5894), "angelina.kryukov@mail.ru", "РобоТех", "Аналитическая платформа", "ИИ" },
                    { 47, "Анна Горбачева", new DateTime(2024, 5, 23, 0, 53, 38, 196, DateTimeKind.Utc).AddTicks(6075), "evgenii.lebeeva@ya.ru", "ИнфоСистемы", "Устройство связи", "Машинное обучение" },
                    { 48, "Римма Кошелев", new DateTime(2021, 6, 25, 17, 5, 28, 318, DateTimeKind.Utc).AddTicks(3414), "matvei42@gmail.com", "НаноТех", "Графический чип", "Распознавание речи" },
                    { 49, "Юлия Кулагина", new DateTime(2023, 1, 28, 12, 43, 16, 298, DateTimeKind.Utc).AddTicks(8125), "aleksandra.shukin19@mail.ru", "РобоТех", "Устройство связи", "ИИ" },
                    { 50, "Никита Кузьмина", new DateTime(2020, 5, 1, 4, 1, 17, 840, DateTimeKind.Utc).AddTicks(7820), "vadim50@ya.ru", "ИнтелСистемы", "Аналитическая платформа", "Машинное обучение" },
                    { 51, "Герман Кудряшов", new DateTime(2023, 11, 28, 16, 32, 46, 498, DateTimeKind.Utc).AddTicks(663), "arsenii.uvarova21@hotmail.com", "СофтТек", "Система мониторинга", "Квантовые вычисления" },
                    { 52, "Раиса Рябов", new DateTime(2020, 5, 15, 8, 0, 23, 802, DateTimeKind.Utc).AddTicks(2252), "elizaveta77@mail.ru", "НаноТех", "Процессор", "Распознавание речи" },
                    { 53, "Аркадий Мамонтов", new DateTime(2022, 8, 22, 3, 47, 21, 655, DateTimeKind.Utc).AddTicks(3960), "gennadii49@ya.ru", "СофтТек", "Графический чип", "ИИ" },
                    { 54, "Жанна Цветков", new DateTime(2021, 6, 9, 18, 10, 23, 723, DateTimeKind.Utc).AddTicks(2635), "zoya.timofeeva@mail.ru", "ИнноТех", "Система мониторинга", "Распознавание речи" },
                    { 55, "Дмитрий Муравьева", new DateTime(2022, 7, 16, 5, 27, 1, 713, DateTimeKind.Utc).AddTicks(3892), "regina.zimina92@ya.ru", "СофтТек", "Сенсор", "Машинное обучение" },
                    { 56, "Игнатий Киселев", new DateTime(2021, 2, 1, 13, 8, 25, 681, DateTimeKind.Utc).AddTicks(6522), "anzhela.artemev@mail.ru", "ГлобалТех", "Аналитическая платформа", "Доставка" },
                    { 57, "Семён Дорофеева", new DateTime(2023, 8, 19, 14, 27, 18, 429, DateTimeKind.Utc).AddTicks(4422), "german_samoilova@yahoo.com", "ИнфоСистемы", "Процессор", "Распознавание речи" },
                    { 58, "Сергей Зуева", new DateTime(2020, 4, 25, 7, 55, 7, 289, DateTimeKind.Utc).AddTicks(8200), "makar_fedotova@yandex.ru", "ТехноСтар", "Система мониторинга", "Нейросеть" },
                    { 59, "Сергей Веселова", new DateTime(2024, 5, 23, 7, 59, 7, 541, DateTimeKind.Utc).AddTicks(1679), "sergei_nesterova98@yandex.ru", "ИнтелСистемы", "Аналитическая платформа", "Квантовые вычисления" },
                    { 60, "Владислав Киселев", new DateTime(2020, 12, 25, 6, 33, 42, 705, DateTimeKind.Utc).AddTicks(3928), "vadim82@ya.ru", "ГлобалТех", "Аналитическая платформа", "ИИ" }
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
