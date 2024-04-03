namespace appointmnet_schdeular.Models
{
    public class Schedule
    {
        public int ScheduleId { get; set; }
        public int CourseId { get; set; }
        public int InstructorId { get; set; }
        public DateTime TimeSlot { get; set; }

    }
}
