﻿using System;

namespace parrot_refactoring_kata_2017_11
{
	public class Parrot
	{
		public static Parrot AParrot(ParrotTypeEnum type, int numberOfCoconuts, double voltage, bool isNailed)
		{
			return new Parrot(type, numberOfCoconuts, voltage, isNailed);
		}

		readonly ParrotTypeEnum _type;
		readonly int _numberOfCoconuts;
		readonly double _voltage;
		readonly bool _isNailed;

		private Parrot(ParrotTypeEnum type, int numberOfCoconuts, double voltage, bool isNailed)
		{
			_type = type;
			_numberOfCoconuts = numberOfCoconuts;
			_voltage = voltage;
			_isNailed = isNailed; 
		}

		public double GetSpeed()
		{
			switch (_type)
			{
				case ParrotTypeEnum.EUROPEAN:
					return GetBaseSpeed();
				case ParrotTypeEnum.AFRICAN:
					return Math.Max(0, GetBaseSpeed() - GetLoadFactor() * _numberOfCoconuts);
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