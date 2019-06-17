using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace pda_backend.Models
{
    [DataContract]
    public class GoalStats 
    {
        [DataMember]
        int Total;
        [DataMember]
        int Work;
        [DataMember]
        int Done;
        // [DataMember]
        // double TotalProgress;
        [DataMember]
        double PersonalEfficiency;

        public GoalStats(int total, int work, int done, double personalEfficiency)
        {
            Total = total;
            Work = work;
            Done = done;
            // TotalProgress = totalProgress;
            PersonalEfficiency = personalEfficiency;
        }
    }   
}