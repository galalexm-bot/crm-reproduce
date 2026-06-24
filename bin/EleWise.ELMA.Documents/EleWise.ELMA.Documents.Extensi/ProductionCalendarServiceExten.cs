using System.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Extensions;

[EditorBrowsable(EditorBrowsableState.Never)]
public static class ProductionCalendarServiceExtension
{
	private static readonly IProductionCalendarService ProductionCalendar = Locator.GetServiceNotNull<IProductionCalendarService>();

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static IProductionSchedule GetProductionSchedule(IUser user, IDocument entity, TZSettings tzSettings)
	{
		return ProductionCalendar.GetProductionSchedule(user, entity, tzSettings);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static IProductionSchedule GetProductionSchedule(IUser user, IDocument entity)
	{
		return ProductionCalendar.GetProductionSchedule(user, entity);
	}
}
