using System.Collections.Generic;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Web.Mvc.Html.MessageCustomPager;

namespace EleWise.ELMA.Messages.Web.Models;

public class ListChannelMessageParentModel : List<InfoChannelMessageParent>
{
	public bool CompactView { get; set; }

	public MessagePagerSettings PagerSettings { get; set; }

	public long ItemsCount { get; set; }

	public long? CommentsCount { get; set; }

	public string GridId { get; set; }

	public IBaseMessageFilter Filter { get; set; }

	public ListChannelMessageParentModel()
	{
	}

	public ListChannelMessageParentModel(IEnumerable<InfoChannelMessageParent> collection)
		: base(collection)
	{
	}

	public string GetSerializedFilter()
	{
		return ClassSerializationHelper.SerializeObjectByXml(UniversalFilterSaver.Pack(Filter));
	}
}
