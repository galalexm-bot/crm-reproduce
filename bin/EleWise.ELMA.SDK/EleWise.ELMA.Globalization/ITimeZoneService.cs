using System;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Globalization;

public interface ITimeZoneService
{
	TimeZoneModel CurrentUserTimeZone { get; }

	long? GetBlockedTimeZoneOffset();

	TimeZoneModel GetUserTimeZone(IUser user);

	DateTime ToClientDateTime(DateTime runtimeDateTime, TZSettings settings = null);

	DateTime ToRuntimeDateTimeFromClient(DateTime clientDateTime, TZSettings settings = null);
}
