﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Infrastructure.Data
{
    public class DbFactory : IDisposable
    {
        private bool _disposed;
        private Func<AppDbContext> _instanceFunc;
        private DbContext _dbContext;
        public DbContext DbContext => _dbContext ?? (_dbContext = _instanceFunc.Invoke());

        public DbFactory(Func<AppDbContext> dbContextFactory)
        {
            _instanceFunc = dbContextFactory;
        }

        public void Dispose()
        {
            if (!_disposed && _dbContext != null)
            {
                _disposed = true;
                _dbContext.Dispose();
            }
        }
    }
}
