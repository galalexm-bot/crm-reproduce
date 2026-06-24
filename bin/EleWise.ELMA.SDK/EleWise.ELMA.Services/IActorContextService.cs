namespace EleWise.ELMA.Services;

public interface IActorContextService
{
	bool TryGet(string key, out object value);

	void Set(string key, object value);
}
