using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Market.Domain.Base.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> CommitAsync();
    }
}