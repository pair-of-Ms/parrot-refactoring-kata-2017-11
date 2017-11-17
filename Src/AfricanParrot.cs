using System;

namespace parrot_refactoring_kata_2017_11
{
	public class AfricanParrot : Parrot
	{
		public int NumberOfCoconuts { get; }
		
		public AfricanParrot(int numberOfCoconuts)
		{
			NumberOfCoconuts = numberOfCoconuts;
		}

		public override double GetSpeed()
		{
			return Math.Max(0, GetBaseSpeed() - GetLoadFactor() * NumberOfCoconuts);
		}
		
		private double GetLoadFactor()
		{
			return 9.0;
		}
	}
}