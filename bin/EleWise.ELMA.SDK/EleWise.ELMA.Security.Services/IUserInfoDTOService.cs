using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Security.Services;

public interface IUserInfoDTOService : IConfigurationService
{
	string GetFullName(long id);
}
