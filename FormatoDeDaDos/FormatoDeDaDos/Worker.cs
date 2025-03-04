
namespace Course {
    internal class Worker {
        private string? name;
        private WorkerLevel level;
        private double baseSalary;
        private Department dept;

        public Worker(string? name, WorkerLevel level, double baseSalary, Department dept) {
            this.name = name;
            this.level = level;
            this.baseSalary = baseSalary;
            this.dept = dept;
        }

        public string Name { get; internal set; }
        public object Department { get; internal set; }

        internal void AddContract(HourContract contract) {
            throw new NotImplementedException();
        }

        internal object Income(int year, int month) {
            throw new NotImplementedException();
        }
    }
}