using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;

namespace EleWise.ELMA.Security.Models;

[FilterFor(typeof(IUserPublicKeyToken))]
public interface IUserPublicKeyTokenFilter : IEntityFilter
{
	IUser User { get; set; }

	DateTimeRange CreationDate { get; set; }

	string Name { get; set; }
}
