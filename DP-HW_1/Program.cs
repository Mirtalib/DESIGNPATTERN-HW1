interface IChair
{
	void SitOn();
	void HasLegs();
}

class VictorianChair : IChair
{
	public void HasLegs()
		=> Console.WriteLine("Has Legs VictorianChair");

	public void SitOn()
		=> Console.WriteLine("Sit On VictorianChair");
}

class ModernChair : IChair
{
	public void HasLegs()
		=> Console.WriteLine("Has No Legs ModernChair");
	public void SitOn() 
		=> Console.WriteLine("Sit on ModernChair");
}

class ArtDecoChair : IChair
{
	public void HasLegs() 
		=> Console.WriteLine("Has Legs ArtDecoChair");
	public void SitOn() 
		=> Console.WriteLine("Sit On ArtDecoChair");
}

interface ISofa
{
	void HasLegs();
	void SitOn();
}

class VictorianSofa : ISofa
{
	public void HasLegs() 
		=> Console.WriteLine("Has Legs VictorianSofa");
	public void SitOn() 
		=> Console.WriteLine("Sit On VictorianSofa");
}

class ModernSofa : ISofa
{
	public void HasLegs() 
		=> Console.WriteLine("Has No Legs ModernSofa");
	public void SitOn() 
		=> Console.WriteLine("Sit On ModernSofa");
}

class ArtDecoSofa : ISofa
{
	public void HasLegs() 
		=> Console.WriteLine("Has Legs ArtDecoSofa");
	public void SitOn() 
		=> Console.WriteLine("Sit OnArtDecoSofa");
}

interface ICoffeeTable
{
	void IsRound();
	void PlaceOn();
}

class VictorianCoffeeTable : ICoffeeTable
{
	public void IsRound() 
		=> Console.WriteLine("Is Round VictorianCoffeeTable");
	public void PlaceOn() 
		=> Console.WriteLine("Placed OnVictorianCoffeeTable");
}

class ModernCoffeeTable : ICoffeeTable
{
	public void IsRound() 
		=> Console.WriteLine("Is Round ModernCoffeeTable");
	public void PlaceOn() 
		=> Console.WriteLine("Placed On ModernCoffeeTable");
}

class ArtDecoCoffeeTable : ICoffeeTable
{
	public void IsRound() =>
		Console.WriteLine("Is Not Round ArtDecoCoffeeTable");
	public void PlaceOn() =>
		Console.WriteLine("Placed On ArtDecoCoffeeTable");
}

abstract class FurnitureFactory
{
	public abstract IChair CreateChair();
	public abstract ISofa CreateSofa();
	public abstract ICoffeeTable CreateCoffeeTable();
}

class VictorianFurnitureFactory : FurnitureFactory
{
	public override IChair CreateChair() 
		=> new VictorianChair();
	public override ICoffeeTable CreateCoffeeTable() 
		=> new VictorianCoffeeTable();
	public override ISofa CreateSofa() 
		=> new VictorianSofa();
}

class ModernFurnitureFactory : FurnitureFactory
{
	public override IChair CreateChair() 
		=> new ModernChair();
	public override ICoffeeTable CreateCoffeeTable() 
		=> new ModernCoffeeTable();
	public override ISofa CreateSofa() 
		=> new ModernSofa();
}

class ArtDecoFurnitureFactory : FurnitureFactory
{
	public override IChair CreateChair() 
		=> new ArtDecoChair();
	public override ICoffeeTable CreateCoffeeTable() 
		=> new ArtDecoCoffeeTable();
	public override ISofa CreateSofa() 
		=> new ArtDecoSofa();
}

class Program
{
	static void Main()
	{
		FurnitureFactory furnitureFactory = new ArtDecoFurnitureFactory();
		furnitureFactory.CreateSofa().SitOn();
		furnitureFactory = new VictorianFurnitureFactory();
		furnitureFactory.CreateChair().HasLegs();
	}
}