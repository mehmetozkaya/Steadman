using System;
using Mosh.Data;
using Mosh.Entity;

namespace Mosh.Service
{
    public class MailService : IMailService
    {
        private readonly MoshDataContext _dataContext;

        public MailService(MoshDataContext dataContext)
        {
            _dataContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
        }

        public void Insert(Mail mail)
        {
            _dataContext.Mails.Add(mail);
            _dataContext.SaveChanges();
        }
    }
}
