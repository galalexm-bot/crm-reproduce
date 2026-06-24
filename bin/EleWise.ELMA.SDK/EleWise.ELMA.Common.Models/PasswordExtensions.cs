using System;
using System.Linq.Expressions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.Common.Models;

public static class PasswordExtensions
{
	internal static PasswordExtensions gD2hNRfSERJ4lXDnLS6K;

	public static PasswordWrapper ToWrapper(this PasswordInfo info, PasswordSettings settings)
	{
		return new PasswordWrapper(info, settings);
	}

	public static PasswordWrapper ToWrapper(this PasswordInfo info, PropertyMetadata propertyMetadata)
	{
		return (PasswordWrapper)hrXwHafSvOxd61TdL5dw(info, bykqhMfSCHy3CS0WV9wd(propertyMetadata) as PasswordSettings);
	}

	public static PasswordWrapper ToWrapper<T>(this PasswordInfo info, Expression<Func<T, object>> expr)
	{
		PropertyMetadata propertyMetadata = InterfaceActivator.LoadPropertyMetadata(expr);
		return info.ToWrapper(propertyMetadata);
	}

	internal static bool xDLZASfSfoAAQvs2rO0E()
	{
		return gD2hNRfSERJ4lXDnLS6K == null;
	}

	internal static PasswordExtensions lbQR53fSQdEAHktDHnB4()
	{
		return gD2hNRfSERJ4lXDnLS6K;
	}

	internal static object bykqhMfSCHy3CS0WV9wd(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static object hrXwHafSvOxd61TdL5dw(object P_0, object P_1)
	{
		return ((PasswordInfo)P_0).ToWrapper((PasswordSettings)P_1);
	}
}
