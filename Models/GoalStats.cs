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
        [DataMember]
        double TotalProgress;

        public GoalStats(int total, int work, int done, double progress)
        {
            Total = total;
            Work = work;
            Done = done;
            TotalProgress = progress;
        }
    }   
}