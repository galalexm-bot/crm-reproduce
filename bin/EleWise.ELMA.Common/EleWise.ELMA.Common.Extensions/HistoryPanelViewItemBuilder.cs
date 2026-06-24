using EleWise.ELMA.Common.ViewItems;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Views.Builders;

namespace EleWise.ELMA.Common.Extensions;

public class HistoryPanelViewItemBuilder<TM> : ViewItemBuilder<TM, HistoryPanelViewItem, HistoryPanelViewItemBuilder<TM>> where TM : IEntity
{
	internal HistoryPanelViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
		: base(parentViewItemBuilder)
	{
	}
}
