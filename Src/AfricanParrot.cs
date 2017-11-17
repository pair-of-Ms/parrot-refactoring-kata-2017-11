namespace parrot_refactoring_kata_2017_11
{
	public class AfricanParrot : Parrot
	{
		public override ParrotTypeEnum Type => ParrotTypeEnum.AFRICAN;
		
		public override int NumberOfCoconuts { get; }
		
		public AfricanParrot(int numberOfCoconuts)
		{
			NumberOfCoconuts = numberOfCoconuts;
		}
	}
}