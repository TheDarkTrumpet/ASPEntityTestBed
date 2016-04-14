using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libTestBed.Abstract;
using libTestBed.Entities;
using RefactorThis.GraphDiff;

namespace libTestBed.Concrete
{
    public class EFPeople : IPeople
    {
        private readonly EFLibTestBed _context;

        public EFPeople(EFLibTestBed context)
        {
            _context = context;
        }

        public virtual IQueryable<People> People => _context.People;

        public void Save(People person)
        {
            CallUpdateGraph(person);
            _context.SaveChanges();
        }

        protected virtual void CallUpdateGraph(People personToSave)
        {
            _context.UpdateGraph(personToSave);
        }
    }
}
