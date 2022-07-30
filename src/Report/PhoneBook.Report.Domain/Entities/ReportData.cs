namespace PhoneBook.Report.Domain.Entities;

public class ReportData
{
    public Guid ReportId { get; set; }
    public string Location { get; set; }
    public int RegisteredPersonCount { get; set; }
    public int RegisteredPersonPhoneCount { get; set; }

    public virtual Report Report { get; set; }
}