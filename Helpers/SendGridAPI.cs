using SendGrid;
using SendGrid.Helpers.Mail;

namespace CimaMoviesApi.Helpers;
public static class SendGridAPI
{
    public static async Task<bool> Execute(string userEmail, string userName, string plainTextContent,
        string htmlContent, string subject)
    {
        var apiKey = "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";
        var client = new SendGridClient(apiKey);
        var from = new EmailAddress("test@test.com", "Alaa_Yahia");
        var to = new EmailAddress(userEmail, userName);
        var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
        var response = await client.SendEmailAsync(msg);
        return await Task.FromResult(true);
    }
}
