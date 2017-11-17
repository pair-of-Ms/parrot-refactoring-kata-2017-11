using System;

namespace parrot_refactoring_kata_2017_11
{
	public abstract class Parrot
	{
		public virtual ParrotTypeEnum Type { get; }

		public virtual int NumberOfCoconuts { get; }

		public virtual double Voltage { get; }

		public virtual bool IsNailed { get; }

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
		
		protected double GetBaseSpeed()
		{
			return 12.0;
		}
	}
}