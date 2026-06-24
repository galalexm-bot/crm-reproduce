using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(ILegalForm))]
public interface ILegalFormFilter : IEntityFilter
{
	string LongName { get; set; }

	string ShortName { get; set; }
}
