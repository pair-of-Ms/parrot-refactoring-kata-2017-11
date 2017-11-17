using System;

namespace parrot_refactoring_kata_2017_11
{
	public class EuropeanBlueParrot : Parrot
	{
		private double Voltage { get; }

		private bool IsNailed { get; }

		public EuropeanBlueParrot(double voltage, bool isNailed)
		{
			Voltage = voltage;
			IsNailed = isNailed;
		}

		public override double GetSpeed()
		{
			return (IsNailed) ? 0 : GetBaseSpeed(Voltage);
		}
		
		private double GetBaseSpeed(double voltage)
		{
			return Math.Min(24.0, voltage * base.BaseSpeed);
		}
	}
}