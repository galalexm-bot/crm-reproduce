using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Model.Scripts;

[FilterFor(typeof(IExternalAssembly))]
public interface IExternalAssemblyFilter : IEntityFilter
{
	string Name { get; set; }

	string HashCode { get; set; }
}
