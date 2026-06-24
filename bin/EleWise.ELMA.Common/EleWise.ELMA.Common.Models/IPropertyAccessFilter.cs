using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Common.Models;

[FilterFor(typeof(IPropertyAccess))]
public interface IPropertyAccessFilter : IEntityFilter
{
}
