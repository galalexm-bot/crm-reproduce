using System;
using System.ComponentModel;
using System.Web.Mvc;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Messages.Web.Portlets;

[Serializable]
public class MessagesPortletPersonalization : PortletPersonalization
{
	private bool _showOnlyNew;

	private long _channelId = -1L;

	private int? commentsCount;

	private int? messagesCount;

	[Personalization(PersonalizationScope.User)]
	[DefaultValue(false)]
	[HiddenInput(DisplayValue = false)]
	public virtual bool ShowOnlyNew
	{
		get
		{
			return _showOnlyNew;
		}
		set
		{
			_showOnlyNew = value;
		}
	}

	[Personalization(PersonalizationScope.User)]
	[DefaultValue(-1)]
	[HiddenInput(DisplayValue = false)]
	public virtual long ChannelId
	{
		get
		{
			return _channelId;
		}
		set
		{
			_channelId = value;
		}
	}

	[Int32Settings(MinValue = 0, MaxValue = 20, DefaultValueStr = "3", FieldName = "CommentsCount")]
	[Required(true)]
	[RequiredField]
	[Personalization(PersonalizationScope.User)]
	[DefaultValue(3)]
	[HiddenInput(DisplayValue = false)]
	public int CommentsCount
	{
		get
		{
			if (!commentsCount.HasValue)
			{
				return 3;
			}
			return commentsCount.Value;
		}
		set
		{
			if (value < 0)
			{
				value = 0;
			}
			if (value > 20)
			{
				value = 20;
			}
			commentsCount = value;
		}
	}

	[Int32Settings(MinValue = 1, MaxValue = 20, DefaultValueStr = "5", FieldName = "MessagesCount")]
	[Required(true)]
	[RequiredField]
	[Personalization(PersonalizationScope.User)]
	[DefaultValue(5)]
	[HiddenInput(DisplayValue = false)]
	public int MessagesCount
	{
		get
		{
			if (!messagesCount.HasValue)
			{
				return 5;
			}
			return messagesCount.Value;
		}
		set
		{
			if (value < 1)
			{
				value = 1;
			}
			if (value > 20)
			{
				value = 20;
			}
			messagesCount = value;
		}
	}

	public bool CanChangePropertyShowOnlyNew()
	{
		return ChannelId == -1;
	}
}
