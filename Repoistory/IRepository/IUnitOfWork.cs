using System;
using System.Collections.Generic;
using System.Text;

namespace Repoistory.IRepository
{
   public  interface IUnitOfWork : IDisposable 
    {
         IEmployeeRepoistory Employee { get;  }

        void Save();
       
    }
}
