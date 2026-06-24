using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Web.Helpers;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Web.Mvc.Binders;

namespace EleWise.ELMA.BPM.Web.Common.Components;

[Component]
public class CustomPrefixValueProviderFactory : IValueProviderFactory
{
	public IValueProvider GetValueProvider(ControllerContext controllerContext)
	{
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		if (controllerContext == null)
		{
			throw new ArgumentNullException("controllerContext");
		}
		Dictionary<string, string> dictionary = controllerContext.get_HttpContext().Request.Form.AllKeys.Where((string key) => key?.EndsWith(".___CustomPrefix") ?? false).ToDictionary((string key) => key.Substring(0, key.Length - 16), (string key) => controllerContext.get_HttpContext().Request[key]);
		if (!dictionary.Any())
		{
			return null;
		}
		return (IValueProvider)new NameValueCollectionValueProvider(GetNameValueCollection(controllerContext.get_HttpContext().Request.Form, dictionary), GetNameValueCollection(Validation.Unvalidated(controllerContext.get_HttpContext().Request).get_Form(), dictionary), CultureInfo.CurrentCulture);
	}

	private static NameValueCollection GetNameValueCollection(NameValueCollection collection, IDictionary<string, string> prefixMap)
	{
		NameValueCollection nameValueCollection = new NameValueCollection(collection);
		foreach (string key in collection.Keys.Cast<string>())
		{
			nameValueCollection.Add((from pair in prefixMap
				where IsPrefixMatch(pair.Key, key)
				select new
				{
					name = pair.Value + key.Substring(pair.Key.Length),
					values = collection.GetValues(key)
				}).SelectMany(item => item.values.Select((string value) => new { item.name, value })).ToNameValueCollection(item => item.name, item => item.value, collection.EqualityComparer()));
		}
		return nameValueCollection;
	}

	private static bool IsPrefixMatch(string prefix, string testString)
	{
		if (testString == null)
		{
			return false;
		}
		if (prefix.Length == 0)
		{
			return true;
		}
		if (prefix.Length > testString.Length)
		{
			return false;
		}
		if (!testString.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
		{
			return false;
		}
		if (testString.Length == prefix.Length)
		{
			return true;
		}
		char c = testString[prefix.Length];
		if (c == '.' || c == '[')
		{
			return true;
		}
		return false;
	}
}
