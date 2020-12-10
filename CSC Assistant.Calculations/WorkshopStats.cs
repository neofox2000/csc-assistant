using System;

namespace CSC_Assistant.Calculations
{
    public struct WorkshopStats
    {
        public double AugInput { get; set; }
        public double AugTime{ get; set; }
        public double AugYield { get; set; }
        public double Efficiency { get; set; }
        public int BaseTime { get; set; }

        public double AugmentedRatio(double ratio) => 
            AugInput / 100f * ratio / Efficiency;

        public double ProjectedYield(double input, double augRatio) =>
            Math.Ceiling(input / augRatio * (1f + AugYield / 100f));

        public int ProjectedTime(double projYield, int unitTime) =>
            (int)Math.Ceiling(BaseTime + unitTime * projYield * (1f - AugTime / 100f));
    }
}
