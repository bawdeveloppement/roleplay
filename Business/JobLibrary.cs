namespace Roleplay.Business
{
    public static class JobLibrary
    {
        public static JobGrade Chief = new(0, "Chief", 2);
        public static JobGrade Manager = new(1, "Manager", 1);
        public static JobGrade Novice = new(2, "Novice", 0);

        public static Job ButcherJob = new(0, "Butcher", new List<JobGrade>
        {
            Chief,
            Manager,
            Novice
        });

        public static Job PoliceJob = new(1, "Police", new List<JobGrade>
        {
            Chief,
            Manager,
            Novice
        });
    }
}