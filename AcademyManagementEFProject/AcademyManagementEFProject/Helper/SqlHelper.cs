namespace AcademyManagementEFProject.Helper;

public static class SqlHelper
{
    private readonly static string _msSqlConnectionStr = @"Server=localhost;Database=AcademyManagementDBEF;Trusted_Connection=True;TrustServerCertificate=True;";

    public static string GetMsSqlConnectionStr()
    {
        return _msSqlConnectionStr;
    }
}
