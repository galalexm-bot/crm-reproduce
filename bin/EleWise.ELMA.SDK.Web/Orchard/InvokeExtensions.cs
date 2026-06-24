using System;
using System.Collections.Generic;
using EleWise.ELMA.Logging;
using Orchard.Exceptions;
using Orchard.Security;

namespace Orchard;

public static class InvokeExtensions
{
	public static void Invoke<TEvents>(this IEnumerable<TEvents> events, Action<TEvents> dispatch, ILogger logger)
	{
		foreach (TEvents @event in events)
		{
			try
			{
				dispatch(@event);
			}
			catch (Exception ex)
			{
				if (IsLogged(ex))
				{
					logger.Error(ex, "{2} thrown from {0} by {1}", typeof(TEvents).Name, @event.GetType().FullName, ex.GetType().Name);
				}
				if (ex.IsFatal())
				{
					throw;
				}
			}
		}
	}

	public static IEnumerable<TResult> Invoke<TEvents, TResult>(this IEnumerable<TEvents> events, Func<TEvents, TResult> dispatch, ILogger logger)
	{
		foreach (TEvents @event in events)
		{
			TResult val = default(TResult);
			try
			{
				val = dispatch(@event);
			}
			catch (Exception ex)
			{
				if (IsLogged(ex))
				{
					logger.Error(ex, "{2} thrown from {0} by {1}", typeof(TEvents).Name, @event.GetType().FullName, ex.GetType().Name);
				}
				if (ex.IsFatal())
				{
					throw;
				}
			}
			yield return val;
		}
	}

	private static bool IsLogged(Exception ex)
	{
		if (!(ex is OrchardSecurityException))
		{
			return !ex.IsFatal();
		}
		return true;
	}
}
