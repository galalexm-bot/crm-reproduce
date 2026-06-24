namespace Nemerle.Concurrency;

public class DummyQueue
{
	private int count = 0;

	public bool IsEmpty => count == 0;

	public void Add()
	{
		checked
		{
			count++;
		}
	}

	public void Take()
	{
		checked
		{
			count--;
		}
	}
}
