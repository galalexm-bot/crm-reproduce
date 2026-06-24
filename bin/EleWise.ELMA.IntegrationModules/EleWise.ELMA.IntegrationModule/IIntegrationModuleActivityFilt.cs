using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.IntegrationModules.Models;

[FilterFor(typeof(IIntegrationModuleActivity))]
public interface IIntegrationModuleActivityFilter : IEntityFilter
{
	[Uid("4b7b816c-17bf-4b22-8c59-d99101cf45ae")]
	string Name { get; set; }
}
