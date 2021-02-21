using RestWithASPNET.Data.VO;
using RestWithASPNET.HyperMedia.Utils;
using System.Collections.Generic;

namespace RestWithASPNET.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO FindByID(long id);
        List<PersonVO> FindAll();
        PersonVO Update(PersonVO person);
        void Delete(long id);
        PersonVO Disable(long id);
        List<PersonVO> FindByName(string firstname, string lastname);
        PagedSearchVO<PersonVO> FindWithPagedSearch(string name, string sortDirection, int pagesize, int page);
    }
}
