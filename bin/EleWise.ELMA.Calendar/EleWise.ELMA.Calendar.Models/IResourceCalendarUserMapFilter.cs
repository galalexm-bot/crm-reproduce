using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Projects.Models.Resources;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Calendar.Models;

[FilterFor(typeof(IResourceCalendarUserMap))]
public interface IResourceCalendarUserMapFilter : IEntityFilter
{
	IUser User { get; set; }

	IResourceCalendar Calendar { get; set; }
}
