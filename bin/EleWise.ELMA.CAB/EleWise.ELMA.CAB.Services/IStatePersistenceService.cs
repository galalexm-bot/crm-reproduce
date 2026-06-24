namespace EleWise.ELMA.CAB.Services;

public interface IStatePersistenceService
{
	void Save(State state);

	State Load(string id);

	void Remove(string id);

	bool Contains(string id);
}
