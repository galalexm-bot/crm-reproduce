namespace EleWise.ELMA.RPA.Services;

public interface IRPASerializationService
{
	T Deserialize<T>(string json);

	string Serialize(object obj);
}
