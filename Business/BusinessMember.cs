namespace Roleplay.Business
{

    public class BusinessMember
    {
        public long ClientId;
        public List<Job> activeJobs = new();
        public Dictionary<long, JobGrade> activeGrades = new();

        public BusinessMember(long clientId)
        {
            this.ClientId = clientId;
        }

        public Job? GetActiveJobById(long jobId)
        {
            foreach (var job in activeJobs)
            {
                if (job.Id == jobId) {
                    return job;
                }
            }

            return null;
        }

        public bool SetActiveJob(Job jobToSet)
        {
            if (this.GetActiveJobById(jobToSet.Id) != null)
            {
                this.activeJobs.Add(jobToSet);
                return true;
            }

            return false;
        }

        public bool RemoveActiveJob(long jobToRemoveId)
        {
            if (this.GetActiveJobById(jobToRemoveId) != null)
            {
                this.activeJobs.RemoveAll((job) => job.Id == jobToRemoveId);
                return true;
            }

            return false;
        }
    }
}