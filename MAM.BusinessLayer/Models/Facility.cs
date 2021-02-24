using EnumsNET;
using MAM.BusinessLayer.Models.Enums;
using MAM.DataAccess.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MAM.BusinessLayer.Models
{
    public class Facility
    {
        public int Id { get; set; }
        public string FileReference { get; set; }
        public string Name { get; set; }
        public string ClientCode { get; set; }
        public string PropType { get; set; }
        public string Parcel { get; set; }
        public string Portion { get; set; }
        public string FarmName { get; set; }
        public string LandLoc { get; set; }
        public string Type { get; set; }
        public string ValuationDate { get; set; }
        public string SGDiagram { get; set; }
        public string AreaHA { get; set; }
        public string RegOwner { get; set; }
        public string OwnershipCategory { get; set; }
        public string Zoning { get; set; }
        public string RegDivision { get; set; }
        public string UserDept { get; set; }
        public string ConditionRating { get; set; }
        public string IntendUseOfTheProperty { get; set; }
        public string CurrentUse { get; set; }
        public MapCoordinate MapCoordinate { get; set; }
        public string VestingInformation { get; set; }
        public string Comments { get; set; }
        public int UserId { get; set; }
        public string Status { get; set; }
        public string FacilityType { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public List<Facility> ConvertDwellingToFacility(List<DwellingFacility> dwellingFacilities)
        {
            return dwellingFacilities.Select(f => new Facility() { Id = f.Id,
                FileReference = "D/" + f.Id,
                Name = f.Name,
                ClientCode = f.ClientCode,
                PropType = f.PropType,
                Parcel = f.Parcel,
                Portion = f.Portion,
                FarmName = f.FarmName,
                LandLoc = f.LandLoc,
                Type = f.Type,
                ValuationDate = f.ValuationDate.ToString(),
                SGDiagram = f.SGDiagram,
                AreaHA = f.AreaHA,
                RegOwner = f.RegOwner,
                OwnershipCategory = f.OwnershipCategory,
                Zoning = f.Zoning,
                RegDivision = f.RegDivision,
                UserDept = f.UserDept,
                ConditionRating = f.ConditionRating,
                IntendUseOfTheProperty = f.IntendUseOfTheProperty,
                CurrentUse = f.CurrentUse,
                FacilityType = "Dwelling",
                MapCoordinate = new MapCoordinate() {
                    Longitude = f.GPSCoordinatesEast.Replace(",", "."),
                    Latitude = f.GPSCoordinatesSouth.Replace(",", "."),
                },
                VestingInformation = f.VestingInformation,
                Comments = f.Comments,
                UserId = f.UserId,
                Status = ((FacilityStatus)f.Status).AsString(EnumFormat.Description),
                CreatedBy = f.CreatedBy,
                CreatedDate = f.CreatedDate,
                ModifiedBy = f.ModifiedBy,
                ModifiedDate = f.ModifiedDate
            }).ToList();
        }

        public List<Facility> ConvertLandToFacility(List<LandFacility> landFacilities)
        {
            return landFacilities.Select(f => new Facility()
            {
                Id = f.Id,
                FileReference = "L/" + f.Id,
                Name = f.Name,
                ClientCode = f.ClientCode,
                PropType = f.PropType,
                Parcel = f.Parcel,
                Portion = f.Portion,
                FarmName = f.FarmName,
                LandLoc = f.LandLoc,
                Type = f.Type,
                ValuationDate = f.ValuationDate,
                SGDiagram = f.SGDiagram,
                AreaHA = f.AreaHA,
                RegOwner = f.RegOwner,
                OwnershipCategory = f.OwnershipCategory,
                Zoning = f.Zoning,
                RegDivision = f.RegDivision,
                UserDept = f.UserDept,
                ConditionRating = f.ConditionRating,
                IntendUseOfTheProperty = f.IntendUseOfTheProperty,
                CurrentUse = f.CurrentUse,
                FacilityType = "Land",
                MapCoordinate = new MapCoordinate()
                {
                    Longitude = f.GPSCoordinatesEast.Replace(",", "."),
                    Latitude = f.GPSCoordinatesSouth.Replace(",", "."),
                },
                VestingInformation = f.VestingInformation,
                Comments = f.Comments,
                UserId = f.UserId,
                Status = ((FacilityStatus)f.Status).AsString(EnumFormat.Description),
                CreatedBy = f.CreatedBy,
                CreatedDate = f.CreatedDate,
                ModifiedBy = f.ModifiedBy,
                ModifiedDate = f.ModifiedDate
            }).ToList();
        }

        public List<Facility> ConvertNonResidentialToFacility(List<NonResidentialFacility> nonResidentialFacilities)
        {
            return nonResidentialFacilities.Select(f => new Facility()
            {
                Id = f.Id,
                FileReference = "NR/" + f.Id,
                Name = f.Name,
                ClientCode = f.ClientCode,
                PropType = f.PropType,
                Parcel = f.Parcel,
                Portion = f.Portion,
                FarmName = f.FarmName,
                LandLoc = f.LandLoc,
                Type = f.Type,
                ValuationDate = f.ValuationDate,
                SGDiagram = f.SGDiagram,
                AreaHA = f.AreaHA,
                RegOwner = f.RegOwner,
                OwnershipCategory = f.OwnershipCategory,
                Zoning = f.Zoning,
                RegDivision = f.RegDivision,
                UserDept = f.UserDept,
                ConditionRating = f.ConditionRating,
                IntendUseOfTheProperty = f.IntendUseOfTheProperty,
                CurrentUse = f.CurrentUse,
                FacilityType = "NonResidential",
                MapCoordinate = new MapCoordinate()
                {
                    Longitude = f.GPSCoordinatesEast.Replace(",", "."),
                    Latitude = f.GPSCoordinatesSouth.Replace(",", "."),
                },
                VestingInformation = f.VestingInformation,
                Comments = f.Comments,
                UserId = f.UserId,
                Status = ((FacilityStatus)f.Status).AsString(EnumFormat.Description),
                CreatedBy = f.CreatedBy,
                CreatedDate = f.CreatedDate,
                ModifiedBy = f.ModifiedBy,
                ModifiedDate = f.ModifiedDate
            }).ToList();
        }
    }   
}
