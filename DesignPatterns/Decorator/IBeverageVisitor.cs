namespace DesignPatterns.Decorator
{
	public interface IBeverageVisitor
	{
		void Visit(DarkRoast darkRoast);
		void Visit(Espresso espresso);
		void Visit(HouseBlend houseBlend);
		void Visit(Soy soy);
		void Visit(Mocha mocha);
	}
}