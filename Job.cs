namespace Roleplay.Business
{
    public class Job {
        public long Id;
        public string Title;
        public List<JobGrade> Grades;

        public Job(long id, string title, IEnumerable<JobGrade> grades) {
            this.Id = id;
            this.Title = title;
            this.Grades = new List<JobGrade>(grades);
        }
    }

    public class JobGrade {
        public long Id;
        public int Priority;
        public string Title;

        public JobGrade(long id, string title, int priority)
        {
            this.Id = id;
            this.Title = title;
            this.Priority = priority;
        }
    }
}