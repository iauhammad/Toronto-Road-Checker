using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using HTTP5203_FinalProject.Models;

namespace HTTP5203_FinalProject.Services
{
    public class XMLReader
    {
        private const string sXML_PATH = "http://www1.toronto.ca/transportation/roadrestrictions/RoadRestrictions.xml";

        /// <summary>
        /// Function to read roadrestrictions data from the city of toronto open data source.
        /// </summary>
        /// <returns>A list of closures with details.</returns>
        public List<Closures> getListOfRoadClosures()
        {
            DataSet dsRoadClosures = new DataSet();
            dsRoadClosures.ReadXml(sXML_PATH);

            var lstRoadClosures = new List<Closures>();
            lstRoadClosures = (from dsRow in dsRoadClosures.Tables[0].AsEnumerable()
                               select new Closures
                               {
                                   Id = dsRow[0].ToString(),
                                   Road = dsRow[1].ToString(),
                                   Name = dsRow[2].ToString(),
                                   District = dsRow[3].ToString(),
                                   Latitude = Convert.ToDouble(dsRow[4].ToString()),
                                   Longitute = Convert.ToDouble(dsRow[5].ToString()),
                                   RoadClass = dsRow[6].ToString(),
                                   Planned = Convert.ToInt32(dsRow[7].ToString()),
                                   SeverityOverride = Convert.ToInt32(dsRow[8].ToString()),
                                   Source = dsRow[9].ToString(),
                                   LastUpdated = dsRow[10].ToString(),
                                   StartTime = dsRow[11].ToString(),
                                   EndTime = dsRow[12].ToString(),
                                   WorkPeriod = dsRow[13].ToString(),
                                   Expired = Convert.ToInt32(dsRow[14].ToString()),
                                   Signing = dsRow[15].ToString(),
                                   Notification = dsRow[16].ToString(),
                                   WorkEventType = dsRow[17].ToString(),
                                   Contractor = dsRow[18].ToString(),
                                   PermitType = dsRow[19].ToString(),
                                   Description = dsRow[20].ToString(),
                                   SpecialEvent = dsRow[21].ToString(),
                               }).ToList();

            return lstRoadClosures;
        }
    }
}