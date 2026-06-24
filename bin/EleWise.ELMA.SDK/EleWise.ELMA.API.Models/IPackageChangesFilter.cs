using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.API.Models;

[FilterFor(typeof(IPackageChanges))]
public interface IPackageChangesFilter : IEntityFilter
{
	long? UserId { get; set; }
}
