using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model;

namespace EleWise.ELMA.Services;

public interface IIconPackService : IConfigurationService
{
	IconModel GetIcon(string name);
}
