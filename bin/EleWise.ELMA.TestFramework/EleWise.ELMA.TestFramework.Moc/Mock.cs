namespace EleWise.ELMA.TestFramework.Mocking;

public abstract class Mock : IMock
{
	private int callCounter;

	private readonly string _003CName_003Ek__BackingField;

	public string Name => _003CName_003Ek__BackingField;

	public Mock(string name)
	{
		_003CName_003Ek__BackingField = name;
	}

	public bool WasCalled(int count = 0)
	{
		return count == callCounter;
	}

	protected void IncrementCallCounter()
	{
		callCounter++;
	}
}
