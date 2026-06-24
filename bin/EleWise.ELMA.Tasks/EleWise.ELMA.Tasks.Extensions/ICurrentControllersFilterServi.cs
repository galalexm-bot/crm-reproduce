using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Models;
using Iesi.Collections.Generic;
using NHibernate;

namespace EleWise.ELMA.Tasks.Extensions;

public interface ICurrentControllersFilterService
{
	void SetupCurrentControllersFilter(ICriteria criteria, bool? filterUnderControl, TaskControlType? filterControlType, IUser filterControlUser, ISet<IUser> filterCurrentControllers, string taskTable, string currentControllersLinkTable, string currentControllersTaskIdColumn, string currentControllersUserIdColumn);
}
