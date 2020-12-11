using System;

namespace CSC_Assistant.Calculations
{
    public record WorkshopStats
    {
        public double AugInput { get; }
        public double AugTime { get; }
        public double AugYield { get; }
        public double Efficiency { get; }
        public int BaseTime { get; }

        public WorkshopStats(double augInput, double augTime, double augYield, double efficiency, int baseTime)
        {
            AugInput = augInput;
            AugTime = augTime;
            AugYield = augYield;
            Efficiency = efficiency;
            BaseTime = baseTime;
        }

        public double AugmentedRatio(double ratio) =>
            AugInput / 100f * ratio / Efficiency;

        public double ProjectedYield(double input, double augRatio) =>
            Math.Ceiling(input / augRatio * (1f + AugYield / 100f));

        public int ProjectedTime(double projYield, int unitTime) =>
            (int)Math.Ceiling(BaseTime + unitTime * projYield * (1f - AugTime / 100f));
    }
}
