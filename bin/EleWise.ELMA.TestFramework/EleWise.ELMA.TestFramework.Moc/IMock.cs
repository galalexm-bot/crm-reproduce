namespace EleWise.ELMA.TestFramework.Mocking;

internal interface IMock
{
	string Name { get; }

	bool WasCalled(int count = 0);
}
