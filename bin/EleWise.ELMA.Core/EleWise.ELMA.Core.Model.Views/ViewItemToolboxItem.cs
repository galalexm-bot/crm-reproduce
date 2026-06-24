using System;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Core.Model.Views.Toolbox;

[Component]
public abstract class ViewItemToolboxItem : IViewItemToolboxItem
{
	private readonly string _003CIcon_003Ek__BackingField;

	public abstract Guid Uid { get; }

	public abstract string Name { get; }

	public abstract Guid GroupUid { get; }

	public abstract System.Type Type { get; }

	public virtual bool Visible => true;

	public virtual string Icon => _003CIcon_003Ek__BackingField;

	public abstract ViewItem CreateViewItem();

	public abstract string GetSlotName(Guid uid);
}
public abstract class ViewItemToolboxItem<TViewItem> : ViewItemToolboxItem where TViewItem : ViewItem
{
	private readonly IViewItemInfoService viewItemInfoService;

	public override string Name
	{
		get
		{
			ViewItemTypeInfo viewItemTypeInfo = viewItemInfoService?.GetInfo(typeof(TViewItem));
			if (viewItemTypeInfo == null)
			{
				return "";
			}
			return viewItemTypeInfo.Name;
		}
	}

	public override System.Type Type => typeof(TViewItem);

	public override string Icon => "row";

	public ViewItemToolboxItem(IViewItemInfoService viewItemInfoService)
	{
		this.viewItemInfoService = viewItemInfoService;
	}

	public override ViewItem CreateViewItem()
	{
		TViewItem val = Activator.CreateInstance<TViewItem>();
		val.InitNew(null);
		return val;
	}

	public override string GetSlotName(Guid uid)
	{
		return Name;
	}
}
