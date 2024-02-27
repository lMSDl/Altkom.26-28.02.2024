using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.StructuralPatterns.Adapter.II
{
    internal class DbPeopleServiceAdapter : IPeopleService
    {
        private readonly DbService _dbService;

        public DbPeopleServiceAdapter(DbService dbService)
        {
            _dbService = dbService;
        }

        public IEnumerable<Person> GetPeople()
        {
            var people = _dbService.Read();

            return people.Select(x => new Person { Name= $"{x.FirstName} {x.LastName}", Age = DateTime.Now.Year - x.BirthDate.Year });
        }
    }
}
