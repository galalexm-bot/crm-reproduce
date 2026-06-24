using System;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Web.Mvc.Views.ViewItem;

public abstract class FormViewItemControl : ViewItemControl<FormViewItem, object>
{
	public const string CallContextItemTypeDataName = "FormViewItemItemType";

	public const string CallContextEntityDataName = "FormViewItemEntity";

	public const string CallContextViewProviderUidDataName = "FormViewItemViewProviderUid";

	public const string CallContextViewItemIdDataName = "FormViewItemViewItemId";

	public const string CallContextDynamicFormsProviderUidDataName = "FormViewItemDynamicFormsProviderUid";

	public const string CallContextDynamicFormsProviderDataDataName = "FormViewItemDynamicFormsProviderData";

	public const string CallContextFormIdDataName = "FormViewItemFormId";

	public const string CallContextShowDescriptionDataName = "FormViewItemShowDescription";

	public const string CallContextOriginalViewItemDataName = "FormViewItemOriginalViewItem";

	private const string CallContextDisabledRenderNotifyName = "DisabledRenderNotify";

	protected internal static ItemType ItemType => ContextVars.GetOrAdd("FormViewItemItemType", () => ItemType.Default);

	protected internal static object Entity => ContextVars.GetOrDefault<object>("FormViewItemEntity");

	public static bool IsFormViewItem => ContextVars.Contains("ViewItemObject");

	protected internal Guid ViewProviderUid => ContextVars.GetOrAdd("FormViewItemViewProviderUid", () => Guid.Empty);

	protected internal string ViewItemId => ContextVars.GetOrDefault<string>("FormViewItemViewItemId");

	protected internal Guid DynamicFormsProviderUid => ContextVars.GetOrAdd("FormViewItemDynamicFormsProviderUid", () => Guid.Empty);

	protected internal string DynamicFormsProviderData => ContextVars.GetOrDefault<string>("FormViewItemDynamicFormsProviderData");

	protected internal string FormId => ContextVars.GetOrDefault<string>("FormViewItemFormId");

	protected internal bool ShowDescription => ContextVars.GetOrDefault<bool>("FormViewItemShowDescription");

	protected internal FormViewItem OriginalViewItem => ContextVars.GetOrDefault<FormViewItem>("FormViewItemOriginalViewItem");

	protected internal static bool DisabledRenderNotify
	{
		get
		{
			return ContextVars.GetOrDefault<bool>("DisabledRenderNotify");
		}
		private set
		{
			ContextVars.Set("DisabledRenderNotify", value);
		}
	}

	public static T WithDisableNotify<T>(Func<T> action)
	{
		bool disabledRenderNotify = DisabledRenderNotify;
		DisabledRenderNotify = true;
		try
		{
			return action();
		}
		finally
		{
			DisabledRenderNotify = disabledRenderNotify;
		}
	}
}
