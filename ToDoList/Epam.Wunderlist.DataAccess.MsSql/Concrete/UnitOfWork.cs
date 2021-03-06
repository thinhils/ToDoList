﻿using Epam.Wunderlist.DataAccess.Interfaces.Repository;
using System.Data.Entity;

namespace Epam.Wunderlist.DataAccess.MsSql.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        public DbContext Context { get; private set; }

        public UnitOfWork(DbContext context)
        {
            Context = context;
        }

        public void Commit()
        {
            if (Context != null)
            {
                Context.SaveChanges();
            }
        }
    }
}
