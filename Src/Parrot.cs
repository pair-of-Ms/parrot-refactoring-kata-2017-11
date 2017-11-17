using System;

namespace parrot_refactoring_kata_2017_11
{
	public class Parrot
	{
		public static Parrot Create(ParrotTypeEnum type, int numberOfCoconuts, double voltage, bool isNailed)
		{
			if (type == ParrotTypeEnum.EUROPEAN)
			{
				return new EuropeanParrot();
			}
			if (type == ParrotTypeEnum.AFRICAN)
			{
				return new AfricanParrot(numberOfCoconuts);
			}
			return new Parrot(type, numberOfCoconuts, voltage, isNailed);
		}

		public virtual ParrotTypeEnum Type { get; }

		public virtual int NumberOfCoconuts { get; }
		
		readonly double _voltage;
		readonly bool _isNailed;


		private Parrot(ParrotTypeEnum type, int numberOfCoconuts, double voltage, bool isNailed)
		{
			Type = type;
			NumberOfCoconuts = numberOfCoconuts;
			_voltage = voltage;
			_isNailed = isNailed; 
		}
		
		protected Parrot()
		{
		}

		public double GetSpeed()
		{
			switch (Type)
			{
				case ParrotTypeEnum.EUROPEAN:
					return GetBaseSpeed();
				case ParrotTypeEnum.AFRICAN:
					return Math.Max(0, GetBaseSpeed() - GetLoadFactor() * NumberOfCoconuts);
				case ParrotTypeEnum.NORWEGIAN_BLUE:
					return (_isNailed) ? 0 : GetBaseSpeed(_voltage);
			}

			throw new Exception("Should be unreachable");
		}

		private double GetBaseSpeed(double voltage)
		{
			return Math.Min(24.0, voltage * GetBaseSpeed());
		}

		private double GetLoadFactor()
		{
			return 9.0;
		}

		private double GetBaseSpeed()
		{
			return 12.0;
		}
	}
}