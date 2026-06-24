using System;
using System.Web.Mvc;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.Web.Code;

public abstract class AddressComboBoxItemControl : WebViewPage<string>
{
	private const string callContextParentName = "AddressItemControlParent";

	private const string callContextTypesName = "AddressItemControlTypes";

	private const string callContextCountryName = "AddressItemControlCountry";

	private const string callContextShowDropDownName = "AddressItemControlShowDropDown";

	internal static object[] Types
	{
		get
		{
			return ContextVars.GetOrDefault<object[]>("AddressItemControlTypes");
		}
		set
		{
			ContextVars.Set("AddressItemControlTypes", value);
		}
	}

	internal static ICountry Country
	{
		get
		{
			return ContextVars.GetOrDefault<ICountry>("AddressItemControlCountry");
		}
		set
		{
			ContextVars.Set("AddressItemControlCountry", value);
		}
	}

	internal static bool? ShowDropDownValue
	{
		get
		{
			return ContextVars.GetOrDefault<bool?>("AddressItemControlShowDropDown");
		}
		set
		{
			ContextVars.Set("AddressItemControlShowDropDown", value);
		}
	}

	protected internal static Guid? Parent
	{
		get
		{
			return ContextVars.GetOrDefault<Guid?>("AddressItemControlParent");
		}
		set
		{
			ContextVars.Set("AddressItemControlParent", value);
		}
	}

	protected long? CountryCode
	{
		get
		{
			if (Country == null)
			{
				return null;
			}
			return Country.CountryCode;
		}
	}

	protected bool ShowDropDown => ShowDropDownValue ?? false;

	protected object CurrentType => Array.Find(Types, (object t) => t != null && t.ToString() == ((ViewDataDictionary)base.get_ViewData()).get_ModelMetadata().get_PropertyName());

	protected object ParentType
	{
		get
		{
			int num = Array.IndexOf(Types, CurrentType) - 1;
			if (num < 0)
			{
				return null;
			}
			return Types[num];
		}
	}

	protected object ChildType
	{
		get
		{
			int num = Array.IndexOf(Types, CurrentType) + 1;
			if (num >= Types.Length)
			{
				return null;
			}
			return Types[num];
		}
	}
}
