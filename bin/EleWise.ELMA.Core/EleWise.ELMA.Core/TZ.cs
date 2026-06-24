using System;
using Bridge;

namespace EleWise.ELMA.Core;

public static class TZ
{
	private static readonly int? _003CClientTimeZoneOffset_003Ek__BackingField;

	private static readonly int _003CBrowserTimeZoneOffset_003Ek__BackingField;

	private static readonly int? _003CServerTimeZoneOffset_003Ek__BackingField;

	public static int? ClientTimeZoneOffset
	{
		[Template("newRuntimeTZContainer.userOffset()")]
		get
		{
			return _003CClientTimeZoneOffset_003Ek__BackingField;
		}
	}

	public static int BrowserTimeZoneOffset
	{
		[Template("newRuntimeTZContainer.browserOffset()")]
		get
		{
			return _003CBrowserTimeZoneOffset_003Ek__BackingField;
		}
	}

	public static int? ServerTimeZoneOffset
	{
		[Template("newRuntimeTZContainer.serverOffset()")]
		get
		{
			return _003CServerTimeZoneOffset_003Ek__BackingField;
		}
	}

	public static System.DateTime GetServerTime()
	{
		if (!ServerTimeZoneOffset.get_HasValue())
		{
			return System.DateTime.get_Now();
		}
		return System.DateTime.get_UtcNow().AddMinutes((double)ServerTimeZoneOffset.get_Value());
	}
}
