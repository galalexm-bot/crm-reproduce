using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Web.Mvc.Views.ViewItem;

public abstract class TabCaptionViewItemControl<TModel, TViewItem> : RootViewItemControl<TModel, TViewItem> where TViewItem : TabViewItem
{
	internal const string CallContextDataCaptionCounterName = "TabViewItemCaptionCounter";

	internal static TabCaptionCounterData Data
	{
		get
		{
			return ContextVars.GetOrDefault<TabCaptionCounterData>("TabViewItemCaptionCounter");
		}
		set
		{
			ContextVars.Set("TabViewItemCaptionCounter", value);
		}
	}

	protected long? Counter
	{
		get
		{
			if (Data == null)
			{
				return null;
			}
			return Data.Counter;
		}
		set
		{
			if (Data != null)
			{
				Data.Counter = value;
			}
		}
	}

	protected string CounterText
	{
		get
		{
			if (Data == null)
			{
				return null;
			}
			return Data.CounterText;
		}
		set
		{
			if (Data != null)
			{
				Data.CounterText = value;
			}
		}
	}
}
public abstract class TabCaptionViewItemControl<TModel> : TabCaptionViewItemControl<TModel, TabViewItem>
{
}
