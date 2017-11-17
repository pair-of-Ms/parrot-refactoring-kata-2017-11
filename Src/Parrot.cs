﻿using System;

namespace parrot_refactoring_kata_2017_11
{
	public class Parrot
	{
		public static Parrot Create(ParrotTypeEnum type, int numberOfCoconuts, double voltage, bool isNailed)
		{
			return new Parrot(type, numberOfCoconuts, voltage, isNailed);
		}

		readonly int _numberOfCoconuts;
		readonly double _voltage;
		readonly bool _isNailed;

		protected ParrotTypeEnum Type { get; }

		private Parrot(ParrotTypeEnum type, int numberOfCoconuts, double voltage, bool isNailed)
		{
			Type = type;
			_numberOfCoconuts = numberOfCoconuts;
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