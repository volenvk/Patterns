namespace DesignPatterns.Observable
{
	public interface IObserv
	{
		void Update(float temp, float humidity, float pressure);
	}
}