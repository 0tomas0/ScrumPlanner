namespace ScrumPlanner.Models
{
    public class HistoryVelocity
    {
        public int SprintIndex { get; set; }

        public string SprintName { get; set; }

        public double CapacityActual { get; set; }

        public double CapacityFull { get; set; }

        public double VelocityActual { get; set; }

        public double VelocityFull { get; set; }

        public double PredictionActual { get; set; }

        public double PredictionFull { get; set; }
    }
}
