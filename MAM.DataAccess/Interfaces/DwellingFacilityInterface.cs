using MAM.DataAccess.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAM.DataAccess.Interfaces
{
    public interface DwellingFacilityInterface
    {
        void AddDwellingFacility(DwellingFacility dwellingFacility);
        void UpdateDwellingFacility(DwellingFacility dwellingFacility);
        List<DwellingFacility> GetDwellingFacilities();
        DwellingFacility GetDwellingFacilityById(int id);
        List<DwellingFacility> GetDwellingFacilities(string clientCode);
    }
}
