using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Core.Entities;
using Clinic.Core.Repositories;
using Clinic.Core.Services;
namespace Clinic.Service
{
    public class TurnService : ITurnService
    {

        private ITurnRepository _turnRepository;
        public TurnService(ITurnRepository turnRepository)
        {
            _turnRepository = turnRepository;
        }
        public IEnumerable<TurnClass> GetTurn()
        {
            return _turnRepository.GetTurn();
        }
        public TurnClass AddTurn(TurnClass turn)
        {
            //var turns = _turnRepository.GetTurn();
            //var exist = turns.Contains(turn);
            //if (exist)
            //{
            //    return new TurnClass();
            ////}
            return _turnRepository.Add(turn);
        }
        //public bool IsExist(TurnClass turn)
        //{
        //    var turns = _turnRepository.GetTurn();
        //    var exist = turns.Contains(turn);
        //    if (exist)
        //        return false;
        //    return true;
        //}
    }
}

