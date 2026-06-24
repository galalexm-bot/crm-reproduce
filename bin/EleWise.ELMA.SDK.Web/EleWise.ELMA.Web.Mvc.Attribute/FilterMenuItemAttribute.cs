using System;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Web.Mvc.Attributes;

public class FilterMenuItemAttribute : Attribute
{
	private Type type;

	private string typeUidStr;

	private string codeStr;

	public bool Root { get; set; }

	public string Id { get; set; }

	public Guid TypeUid { get; set; }

	public Guid? Code { get; set; }

	public Type Type
	{
		get
		{
			return type;
		}
		set
		{
			type = value;
			TypeUid = InterfaceActivator.UID(value);
		}
	}

	public string TypeUidStr
	{
		get
		{
			return typeUidStr;
		}
		set
		{
			typeUidStr = value;
			TypeUid = new Guid(value);
		}
	}

	public string CodeStr
	{
		get
		{
			return codeStr;
		}
		set
		{
			codeStr = value;
			Code = new Guid(value);
		}
	}

	public string FilterIdParameter { get; set; }

	public string ClickAction { get; set; }

	public string BlankParameter { get; set; }

	public string FilterEditAction { get; set; }

	[Obsolete("Не используется")]
	public string FilterEditTypeUidParameterName { get; set; }

	public bool HideFilterAll { get; set; }

	public bool ShowFilterFavorite { get; set; }
}
