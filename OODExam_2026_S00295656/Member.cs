using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODExam_2026_S00295656
{
    public class Member
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ContactNumber { get; set; }
        public string MembershipType { get; set; }

        //A member can have one to many training sessions
        public virtual List<TrainingSession> TrainingSessions { get; set; }

        public Member() 
        {
            TrainingSessions = new List<TrainingSession>();
        }

        public override string ToString()
        {
            return $"{Surname}, {FirstName} - {ContactNumber}";
        }
    }
}
