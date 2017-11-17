namespace parrot_refactoring_kata_2017_11
{
	public class EuropeanBlueParrot : Parrot
	{
		public override ParrotTypeEnum Type => ParrotTypeEnum.NORWEGIAN_BLUE;

		public override double Voltage { get; }

		public override bool IsNailed { get; }

		public EuropeanBlueParrot(double voltage, bool isNailed)
		{
			Voltage = voltage;
			IsNailed = isNailed;
		}
	}
}