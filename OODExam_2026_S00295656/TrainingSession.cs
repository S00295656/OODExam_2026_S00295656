using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODExam_2026_S00295656
{
    internal class TrainingSession
    {
        public int SessionId { get; set; }
        public DateTime Sessiondate { get; set; }
        public string SessionType { get; set; }
        public int DurationMinutes { get; set; }
        public string CoachNotes { get; set; }
    }
}
