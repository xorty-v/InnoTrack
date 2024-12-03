using QuestPDF.Fluent;
using QuestPDF.Helpers;

namespace InnoTrack.WebApi.Services;

public class PdfReportService : IReportService
{
    public byte[] GenerateReport(
        string author, string organizationName,
        string email, string technologyName,
        string productName, int year)
    {
        return Document.Create(container =>
            container.Page(page =>
            {
                page.Size(PageSizes.A4);
                page.Margin(20);
                page.DefaultTextStyle(x => x.FontSize(14));

                page.Header().Text("Отчет о технологии и продукте").FontSize(20).Bold().AlignCenter();

                page.Content().PaddingVertical(20).Column(column =>
                {
                    column.Spacing(10);

                    column.Item().Table(table =>
                    {
                        table.ColumnsDefinition(columns =>
                        {
                            columns.RelativeColumn(1);
                            columns.RelativeColumn(2);
                        });

                        AddRow(table, "Автор", author);
                        AddRow(table, "Наименование организации", organizationName);
                        AddRow(table, "Электронная почта", email);
                        AddRow(table, "Название технологии", $"{technologyName}");
                        AddRow(table, "Название продукта", $"{productName}");
                        AddRow(table, "Год", year.ToString());
                    });
                });
                page.Footer().AlignRight().Text("by Ramaz Gvindzhiliya").Italic();
            })).GeneratePdf();
    }

    private void AddRow(TableDescriptor table, string header, string value)
    {
        table.Cell().Border(1).Padding(5).Text(header);
        table.Cell().Border(1).Padding(5).Text(value);
    }
}