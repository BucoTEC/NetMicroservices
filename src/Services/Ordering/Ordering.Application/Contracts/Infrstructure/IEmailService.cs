using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ordering.Application.Models;

namespace Ordering.Application.Contracts.Infrstructure
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
