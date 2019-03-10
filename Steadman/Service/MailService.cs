using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Steadman.Data;
using Steadman.Entity;

namespace Steadman.Service
{
    public class MailService : IMailService
    {
        private readonly SteadmanDataContext _dataContext;

        public MailService(SteadmanDataContext dataContext)
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
