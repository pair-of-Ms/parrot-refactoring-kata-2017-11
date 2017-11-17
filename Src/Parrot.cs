using System;

namespace parrot_refactoring_kata_2017_11
{
	public class Parrot
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

		public virtual double GetSpeed()
		{
			switch (Type)
			{
				case ParrotTypeEnum.EUROPEAN:
					return GetSpeed();
				case ParrotTypeEnum.AFRICAN:
					return GetSpeed();
				case ParrotTypeEnum.NORWEGIAN_BLUE:
					return GetSpeed();
			}
			throw new Exception("Should be unreachable");
		}

		protected double GetBaseSpeed(double voltage)
		{
			return Math.Min(24.0, voltage * GetBaseSpeed());
		}

		protected double GetBaseSpeed()
		{
			return 12.0;
		}
	}
}