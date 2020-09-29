using DataAcces;
using Microsoft.EntityFrameworkCore;
using Repoistory.IRepository;
using Repoistory.Repository;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Services.Services
{
    public class Services<T> : IServices<T> where T : class
    {
      
    }
}
