using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Core.Entities;
using Clinic.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Clinic.Data.Repositories
{
    public class TurnRepository : ITurnRepository
    {
        private DataContext _context;

        public TurnRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<TurnClass> GetTurn()
        {
            return _context.List_turn.Include(r=>r.Doctor);
        }
        public TurnClass Add(TurnClass turn)
        {
            _context.List_turn.Add(turn);
            _context.SaveChanges();
            return turn;
        }
    }
}
