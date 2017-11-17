using System;

namespace parrot_refactoring_kata_2017_11
{
	public abstract class Parrot
	{
		protected double BaseSpeed => 12.0;

		public static Parrot Create(ParrotTypeEnum type, int numberOfCoconuts, double voltage, bool isNailed)
		{
			switch (type)
			{
				case ParrotTypeEnum.EUROPEAN:
					return new EuropeanParrot();
				case ParrotTypeEnum.AFRICAN:
					return new AfricanParrot(numberOfCoconuts);
				case ParrotTypeEnum.NORWEGIAN_BLUE:
					return new EuropeanBlueParrot(voltage, isNailed);
				default:
					throw new ArgumentException("Given Parrot Type is not valid");
			}
		}

		public abstract double GetSpeed();
	}
}