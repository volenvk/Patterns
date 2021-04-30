namespace ReaderLogFilesByPatterns.Builder
{
    using System.Net.Mail;

    public class FinalMailMessageBuilder
    {
        private readonly MailMessage _mailMessage;
        
        internal FinalMailMessageBuilder(MailMessage mailMessage)
        {
            _mailMessage = mailMessage;
        }
        
        public MailMessage Build()
        {
            return _mailMessage;
        }
    }
}