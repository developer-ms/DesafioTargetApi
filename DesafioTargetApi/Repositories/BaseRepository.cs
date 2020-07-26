using DesafioTargetApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTargetApi.Repositories
{
    public class BaseRepository
    {
        protected readonly DesafioTargetContext _context;

        public BaseRepository(DesafioTargetContext context)
        {
            _context = context;
        }
    }
}
