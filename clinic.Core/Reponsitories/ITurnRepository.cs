using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Core.Entities;

namespace Clinic.Core.Repositories
{
    public interface ITurnRepository
    {
        public List<TurnClass> GetTurn();
        public TurnClass Add(TurnClass turn);

    }
}
