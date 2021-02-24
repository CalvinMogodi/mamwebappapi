﻿using MAM.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAM.BusinessLayer.Interfaces
{
    public interface FacilityInterface
    {
        List<FacilityType> GetFacilityZonings();
        List<DashboardWedge> GetDashboardWedges();
        List<FacilitySummaryChart> GetFacilitySummaries();
        List<MapCoordinate> GetMapCoordinates();
    }
}
