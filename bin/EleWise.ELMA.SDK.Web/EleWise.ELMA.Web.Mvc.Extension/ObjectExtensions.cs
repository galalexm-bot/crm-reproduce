using System;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EleWise.ELMA.Web.Mvc.Extensions;

public static class ObjectExtensions
{
	public static string GetID(this object obj)
	{
		return obj?.ToString().ToLower();
	}

	public static string StringUid(this IMetadata metadata)
	{
		if (metadata != null)
		{
			return metadata.Uid.ToStringId();
		}
		return "";
	}

	public static string ToStringId(this Guid uid)
	{
		return "g" + uid.ToString().Replace("-", "_");
	}

	public static JValue AsJValue(this string str)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return (JValue)new JRaw((object)str);
	}

	public static MvcHtmlString ToJson(this object obj, params JsonConverter[] converters)
	{
		if (obj != null)
		{
			return MvcHtmlString.Create(JsonConvert.SerializeObject(obj, converters));
		}
		return MvcHtmlString.Empty;
	}

	public static MvcHtmlString ToEncodedJson(this object obj, params JsonConverter[] converters)
	{
		if (obj != null)
		{
			return MvcHtmlString.Create(HttpUtility.HtmlAttributeEncode(JsonConvert.SerializeObject(obj, converters)));
		}
		return MvcHtmlString.Empty;
	}

	public static MvcHtmlString ToJsonSlice(this object obj)
	{
		if (obj == null)
		{
			return MvcHtmlString.Empty;
		}
		string text = JsonConvert.SerializeObject(obj).Remove(0, 1);
		return MvcHtmlString.Create(text.Remove(text.Length - 1));
	}

	public static T FromJson<T>(this string json)
	{
		if (!json.IsNullOrEmpty())
		{
			return JsonConvert.DeserializeObject<T>(json);
		}
		return default(T);
	}

	public static string SafeToString(this object obj)
	{
		return obj?.ToString();
	}
}
