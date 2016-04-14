using System.Linq;
using libTestBed.Entities;

namespace libTestBed.Abstract
{
    public interface IPeople
    {
        IQueryable<People> People { get; }
        void Save(People person);
        void CallUpdateGraph(People personToSave)
    }
}