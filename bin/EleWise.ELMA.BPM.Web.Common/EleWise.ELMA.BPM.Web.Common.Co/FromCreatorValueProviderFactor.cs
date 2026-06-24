using System;
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
public class FromCreatorValueProviderFactory : IValueProviderFactory
{
	public IValueProvider GetValueProvider(ControllerContext controllerContext)
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		if (controllerContext == null)
		{
			throw new ArgumentNullException("controllerContext");
		}
		string text = controllerContext.get_HttpContext().Request["CreatorRequest"];
		string prefix;
		if (text == null || !Convert.ToBoolean(text) || string.IsNullOrEmpty(prefix = controllerContext.get_HttpContext().Request["CreatorPrefix"]))
		{
			return null;
		}
		return (IValueProvider)new NameValueCollectionValueProvider(GetNameValueCollection(controllerContext.get_HttpContext().Request.Form, prefix), GetNameValueCollection(Validation.Unvalidated(controllerContext.get_HttpContext().Request).get_Form(), prefix), CultureInfo.CurrentCulture);
	}

	private static NameValueCollection GetNameValueCollection(NameValueCollection collection, string prefix)
	{
		string start = prefix + ".";
		int startLength = start.Length;
		return (from string key in collection.Keys
			where key.StartsWith(start)
			select new
			{
				name = key.Substring(startLength),
				values = collection.GetValues(key)
			}).SelectMany(item => item.values.Select((string value) => new { item.name, value })).ToNameValueCollection(item => item.name, item => item.value, collection.EqualityComparer());
	}
}
