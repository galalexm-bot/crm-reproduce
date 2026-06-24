using System;
using System.IO;
using Newtonsoft.Json;

namespace EleWise.ELMA.Helpers;

public static class JsonHelper
{
	public static T DeserializeResponse<T>(Stream stream)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		using StreamReader streamReader = new StreamReader(stream);
		JsonTextReader val = new JsonTextReader((TextReader)streamReader);
		try
		{
			return new JsonSerializer().Deserialize<T>((JsonReader)(object)val);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}
}
