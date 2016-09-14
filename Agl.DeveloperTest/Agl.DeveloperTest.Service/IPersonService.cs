using Agl.DeveloperTest.Service.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Agl.DeveloperTest.Service
{
    public interface IPersonService
    {
        Task<List<PersonPets>> GetPersonData();
    }
}
