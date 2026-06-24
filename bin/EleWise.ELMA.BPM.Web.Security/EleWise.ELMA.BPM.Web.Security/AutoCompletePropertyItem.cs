using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Security.Controllers;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using Newtonsoft.Json;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class AutoCompletePropertyItem : AutoCompleteEntityItem
{
	public bool IsTitle { get; set; }

	public string DisplayName { get; set; }

	public Guid Uid { get; set; }

	public bool IsRequired { get; set; }

	public override string ObjectValuePrefix => GetFullPrefix("Property");

	[JsonIgnore]
	public override string SelectedItemTemplateJs => HttpUtility.HtmlEncode("<div>{item.DisplayName}</div><div>{item.Uid}</div>");

	public static string GetFullPrefix(string prefix)
	{
		return $"{prefix}.";
	}

	public static AutoCompletePropertyItem GetItem(UrlHelper helper, Dictionary<Guid, PropertyMetaLite> properties)
	{
		IEnumerable<PropertyMetaLite> source = properties.Values.Where((PropertyMetaLite i) => i.Uid.Equals(Guid.Empty) && !string.IsNullOrEmpty(i.DisplayName));
		AutoCompletePropertyItem autoCompletePropertyItem = (source.Any() ? source.Select((PropertyMetaLite u) => GetItem(helper, u)).FirstOrDefault() : properties.Values.Select((PropertyMetaLite u) => GetItem(helper, u)).FirstOrDefault());
		if (autoCompletePropertyItem != null)
		{
			return autoCompletePropertyItem;
		}
		return new AutoCompletePropertyItem
		{
			Text = "",
			Value = ""
		};
	}

	public static AutoCompletePropertyItem[] GetItems(UrlHelper helper, Dictionary<Guid, PropertyMetaLite> properties)
	{
		AutoCompletePropertyItem[] first = (from u in properties
			select GetItem(helper, u.Value) into i
			where i.Uid.Equals(Guid.Empty) && !string.IsNullOrEmpty(i.DisplayName)
			select i).ToArray();
		AutoCompletePropertyItem[] second = (from u in properties
			select GetItem(helper, u.Value) into i
			where !i.Uid.Equals(Guid.Empty) && !string.IsNullOrEmpty(i.DisplayName)
			select i).ToArray();
		return first.Concat(second).ToArray();
	}

	public static AutoCompletePropertyItem GetItem(UrlHelper helper, PropertyMetaLite property)
	{
		if (property == null)
		{
			return null;
		}
		string displayName = property.DisplayName;
		string fullImageUrl = helper.Image("#access_vertical.svg");
		bool isRequired = property.IsRequired;
		bool isTitle = property.IsTitle;
		string dropDownText = string.Format("<div {0}>{1}{2}</div>", isRequired ? "class = 'caption-required'" : "", displayName, isTitle ? HtmlExtensions.Image(fullImageUrl, (object)null) : "");
		return new AutoCompletePropertyItem
		{
			DisplayName = displayName,
			IsTitle = isTitle,
			IsRequired = isRequired,
			Value = property.Uid.ToString(),
			Text = displayName,
			Uid = property.Uid,
			DropDownText = dropDownText,
			ViewText = dropDownText
		};
	}
}
