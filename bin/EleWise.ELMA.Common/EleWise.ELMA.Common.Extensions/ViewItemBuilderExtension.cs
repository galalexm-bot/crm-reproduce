using System;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Builders;

namespace EleWise.ELMA.Common.Extensions;

public static class ViewItemBuilderExtension
{
	public static TB HistoryPanel<TM, T, TB>(this RootViewItemBuilder<TM, T, TB> b, Action<HistoryPanelViewItemBuilder<TM>> builder = null) where TM : IEntity where T : RootViewItem, new()where TB : RootViewItemBuilder<TM, T, TB>
	{
		HistoryPanelViewItemBuilder<TM> obj = new HistoryPanelViewItemBuilder<TM>(b);
		builder?.Invoke(obj);
		return b as TB;
	}
}
