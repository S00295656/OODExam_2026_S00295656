using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OODExam_2026_S00295656;

namespace OODExam_2026_S00295656.Database
{
    public class ClubData : DbContext
    {

        public ClubData() : base("OODExam_2026_Jean_HOKAYEM_S00295656")
        { 
            
        }
        public DbSet<Member> Members { get; set; }
        public DbSet<TrainingSession> TrainingSessions { get; set; }

    }
}
