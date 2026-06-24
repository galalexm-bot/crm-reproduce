using System;

namespace EleWise.ELMA.Messages.Helpers;

internal static class MessageHashHelper
{
	public static string GenerateHash(long id, DateTime date)
	{
		return date.Ticks.ToString("x16").ToUpperInvariant() + id.ToString().PadLeft(19, Convert.ToChar("0"));
	}
}
