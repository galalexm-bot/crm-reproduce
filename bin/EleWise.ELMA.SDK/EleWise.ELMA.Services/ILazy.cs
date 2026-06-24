namespace EleWise.ELMA.Services;

public interface ILazy<T> where T : class
{
	bool IsRegistered { get; }

	T Value { get; }
}
