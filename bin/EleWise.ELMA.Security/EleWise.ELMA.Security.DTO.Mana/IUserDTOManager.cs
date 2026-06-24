using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Security.DTO.Models;

namespace EleWise.ELMA.Security.DTO.Managers;

public interface IUserDTOManager : IConfigurationService
{
	UserDTO LoadOrNull(long id);
}
