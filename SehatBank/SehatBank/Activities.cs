using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SehatBank
{
    internal class Activities
    {
        public int ActivitiesID { get; }
        public string ActivitiesName { get; }
        public int ActivitiesDuration { get; }
        public Activities(int activitiesID, string activitiesName, int activitiesDuration){
            ActivitiesID = activitiesID;
            ActivitiesName = activitiesName;
            ActivitiesDuration = activitiesDuration;
        }
    }
}
