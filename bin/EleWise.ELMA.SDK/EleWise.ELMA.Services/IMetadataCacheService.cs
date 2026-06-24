namespace EleWise.ELMA.Services;

public interface IMetadataCacheService
{
	string GetRuntimeHash();

	void SetRuntimeHash(string value);
}
