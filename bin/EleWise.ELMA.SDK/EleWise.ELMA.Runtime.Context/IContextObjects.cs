namespace EleWise.ELMA.Runtime.Context;

public interface IContextObjects
{
	T Get<T>() where T : class;

	void Set<T>(T obj) where T : class;
}
