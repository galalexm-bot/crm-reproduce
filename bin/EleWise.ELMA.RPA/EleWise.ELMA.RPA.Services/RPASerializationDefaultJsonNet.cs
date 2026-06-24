using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace EleWise.ELMA.RPA.Services;

internal class RPASerializationDefaultJsonNetSettings
{
	public const string DateTimeFormat = "yyyy-MM-dd'T'HH:mm:ssK";

	public static IEnumerable<JsonConverter> Converters;

	public static JsonSerializerSettings SerializerSettings;

	static RPASerializationDefaultJsonNetSettings()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		List<JsonConverter> list = new List<JsonConverter>();
		IsoDateTimeConverter val = new IsoDateTimeConverter();
		val.set_DateTimeFormat("yyyy-MM-dd'T'HH:mm:ssK");
		val.set_Culture(CultureInfo.InvariantCulture);
		list.Add((JsonConverter)val);
		Converters = list;
		JsonSerializerSettings val2 = new JsonSerializerSettings();
		val2.set_DateTimeZoneHandling((DateTimeZoneHandling)0);
		val2.set_Converters((IList<JsonConverter>)Converters.ToList());
		val2.set_Error((EventHandler<ErrorEventArgs>)delegate(object sender, ErrorEventArgs args)
		{
			args.get_ErrorContext().set_Handled(true);
		});
		SerializerSettings = val2;
	}
}
