using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Core.Entities;
using Clinic.Core.Repositories;

namespace Clinic.Data.Repositories
{
    public class TurnRepository : ITurnRepository
    {
        private DataContext _context;

        public TurnRepository(DataContext context)
        {
            _context = context;
        }
        public List<TurnClass> GetTurn()
        {
            return _context.List_turn;
        }
        public TurnClass Add(TurnClass turn)
        {
            _context.List_turn.Add(turn);
            return turn;
        }
    }
}
