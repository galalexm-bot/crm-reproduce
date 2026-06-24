using System;
using System.Collections.Generic;
using EleWise.ELMA.Calendar.API;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Common.Mobile.API.Calendar;

[Component]
internal sealed class ExternalCalendarPublicServiceMethodsProvider : IPublicServiceMethodsProvider
{
	public IEnumerable<IPublicServiceMethod> GetMethods()
	{
		return new IPublicServiceMethod[1]
		{
			new PublicServiceMethod(CalendarPublicService.UID, "GetExternalCalendarItems", GetExternalCalendarItemsExecutor.MethodDescription, new Version(1, 0, 0), (WebData data) => new GetExternalCalendarItemsExecutor(data))
			{
				ParametersDescriptor = GetExternalCalendarItemsExecutor.ParametersDescriptor,
				ResultDescriptor = GetExternalCalendarItemsExecutor.ResultDescriptor
			}
		};
	}
}
