namespace ReaderLogFilesByPatterns.Builder
{
    using System;
    using System.Linq;
    using System.Net.Mail;
    using System.Text;

    public sealed class MailMessageBuilder
    {
        private readonly MailMessage _mailMessage;
        
        internal MailMessageBuilder(MailMessage mailMessage)
        {
            _mailMessage = mailMessage;
        }

        public MailMessageBuilder From(string address)
        {
            _mailMessage.From = new MailAddress(address);
            return this;
        }
        
        public FinalMailMessageBuilder To(string address)
        {
            _mailMessage.To(address);
            // Для большей эффективности может быть добавлено кэширование
            return new FinalMailMessageBuilder(_mailMessage);
        }

        public MailMessageBuilder Cc(string address)
        {
            _mailMessage.CC.Add(address);
            return this;
        }
        
        public MailMessageBuilder Subject(string subject)
        {
            _mailMessage.Subject = subject;
            return this;
        }
        
        public MailMessageBuilder Body(string body, Encoding encoding)
        {
            _mailMessage.Body = body;
            _mailMessage.BodyEncoding = encoding;
            return this;
        }
        
        public MailMessage Build()
        {
            if (!_mailMessage.To.Any())
            {
                throw new InvalidOperationException(
                    "Can't create a mail message with empty To. Please call 'To' method first");
            }
            
            return _mailMessage;
        }
    }
}