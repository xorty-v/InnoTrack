namespace InnoTrack.WebApi.Services;

public interface IReportService
{
    public byte[] GenerateReport(
        string author,
        string organizationName,
        string email,
        string technologyName,
        string productName,
        int year);
}