using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Security.Models.API;

[FilterFor(typeof(IClientSessionDataSets))]
public interface IClientSessionDataSetsFilter : IEntityFilter
{
	string SessionToken { get; set; }
}
