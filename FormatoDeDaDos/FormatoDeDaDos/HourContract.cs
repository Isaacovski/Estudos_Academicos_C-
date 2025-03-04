
namespace Course {
    internal class HourContract {
        private DateTime date;
        private double valuePerHour;
        private int hours;

        public HourContract(DateTime date, double valuePerHour, int hours) {
            this.date = date;
            this.valuePerHour = valuePerHour;
            this.hours = hours;
        }
    }
}