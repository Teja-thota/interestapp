namespace interestapp.Models
{
    public class InterestCalc
    {
        public double Principal { get; set; }
        public double Time { get; set; }
        public double Rate { get; set; }

        public double SimpleInterest => (Principal * Time * Rate) / 100;
    }
}
