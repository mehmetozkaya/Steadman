using Steadman.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Steadman.Service
{
    public interface IMailService
    {
        void Insert(Mail mail);
    }
}
