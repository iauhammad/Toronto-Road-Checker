using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTTP5203_FinalProject.Services
{
    public class ManageRoadblocks
    {
        // --- List of distances to load Roadblocks
        // --- ------------------------------------
        /// <summary>List of distances within which to load roadblocks</summary>
        public static List<SelectListItem> RoadblockDistance = new List<SelectListItem>()
        {
            new SelectListItem() {Text="500 M", Value="0.5" },
            new SelectListItem() {Text="1 KM", Value="1" },
            new SelectListItem() {Text="2 KM", Value="2" },
            new SelectListItem() {Text="3 KM", Value="3" },
            new SelectListItem() {Text="5 KM", Value="5" },
            new SelectListItem() {Text="7 KM", Value="7" },
            new SelectListItem() {Text="10 KM", Value="10" },
            new SelectListItem() {Text="15 KM", Value="15" },
            new SelectListItem() {Text="20 KM", Value="20" },
            new SelectListItem() {Text="25 KM", Value="25" },
            new SelectListItem() {Text="30 KM", Value="30" },
            new SelectListItem() {Text="35 KM", Value="35" },
            new SelectListItem() {Text="40 KM", Value="40" },
            new SelectListItem() {Text="45 KM", Value="45" },
            new SelectListItem() {Text="50 KM", Value="50" },
            new SelectListItem() {Text="All Roadblocks", Value="0" },
        };

    }
}