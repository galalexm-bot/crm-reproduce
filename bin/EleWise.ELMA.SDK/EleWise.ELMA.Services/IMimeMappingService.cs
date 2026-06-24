using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Services;

[DeveloperApi(DeveloperApiType.Service)]
public interface IMimeMappingService
{
	string GetTypeByExtension(string extension);

	void RegisterMimeType(string ext, string mimeType);
}
