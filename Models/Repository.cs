namespace crud_mvc.Models
{
    public class Repository
    {
        private static List<Employee> allEmpoyees = new List<Employee>();
        public static IEnumerable<Employee> AllEmpoyees
        {
            get { return allEmpoyees; }
        }
        public static void Create(Employee Employee)
        {
            allEmpoyees.Add(Employee);
        }
        public static void Delete(Employee Employee)
        {
            allEmpoyees.Remove(Employee);
        }

    }
}
