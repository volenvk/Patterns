using System;
using System.Threading.Tasks;
using ReaderLogFilesByPatterns.Interfaces;
using ReaderLogFilesByPatterns.Models;

namespace ReaderLogFilesByPatterns.Decorator
{
    public class ThrottlingLogSaverDecorator : LogSaverDecorator
    {
        public ThrottlingLogSaverDecorator(ILogSavers decorate) : base(decorate){}
        
        public override async Task SaveLogEntry(string applicationId, LogEntry logEntry)
        {
            if (!QuotaReached(applicationId))
            {
                IncrementUsedQuota();
                // Сохраняем записи. Обращаемся к декорируемому объекту!
                await _decorate.SaveLogEntry(applicationId, logEntry);
                return;
            }

            throw new Exception("Сохранение невозможно! Лимит приложения исчерпан!");
        }

        private bool QuotaReached(string applicationId)
        {
            // Проверяем, израсходована ли квота приложения
            return false;
        }

        private void IncrementUsedQuota()
        {
            //...
        }
    }
}
