using System;
using System.Collections.Generic;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Transformations.Struct;

namespace EleWise.ELMA.Content.Transformation;

[Serializable]
public abstract class MenuItemTransformationBase<TTransformation, TAdd, TMove, THide, TChange> : Transformation<IMenuItem, TTransformation, Guid, TAdd, TMove, THide, TChange> where TTransformation : Transformation<IMenuItem, TTransformation, Guid>, new()where TAdd : TransformationAdd<IMenuItem, TTransformation, Guid>, new()where TMove : TransformationMove<IMenuItem, TTransformation, Guid>, new()where THide : TransformationHide<IMenuItem, TTransformation, Guid>, new()where TChange : TransformationChange<IMenuItem, TTransformation, Guid>, new()
{
	public class MenuItemWeightChanged : EventArgs
	{
		public IMenuItem MenuItem { get; set; }
	}

	public EventHandler<MenuItemWeightChanged> WeightChanged { get; set; }

	protected override IList<IMenuItem> GetSubItems(IMenuItem item)
	{
		return item.Items;
	}

	protected override Guid GetUid(IMenuItem item)
	{
		return item.MenuUid;
	}

	protected override bool IsHide(IMenuItem item)
	{
		return false;
	}

	protected override void SetHide(IMenuItem parentItem, IMenuItem item, bool hide = true)
	{
		DeleteItem(item.ParentItem, item);
	}

	protected override IMenuItem CreateCopy(IMenuItem item)
	{
		return CloneHelperBuilder.Create(item).Restrictions(delegate(RestrictionsBuilder<IMenuItem> r)
		{
			r.Rule().ForPropertyName((IMenuItem i) => i.Items).Ignore();
		}).Clone();
	}

	protected override IMenuItem Clone(IMenuItem item)
	{
		return CloneHelperBuilder.Create(item).Clone();
	}

	protected override void AddItem(IMenuItem item, IMenuItem subItem)
	{
		subItem.ParentItem?.Items?.Remove(subItem);
		if (item.Items == null)
		{
			item.Items = new List<IMenuItem>();
		}
		item.Items.Add(subItem);
		int num = ((item.Items.Count > 0) ? item.Items[item.Items.Count - 1].Weight : int.MinValue);
		subItem.ParentItem = item;
		if (subItem.Weight <= num)
		{
			subItem.Weight = num + 1;
			if (WeightChanged != null)
			{
				WeightChanged(this, new MenuItemWeightChanged
				{
					MenuItem = subItem
				});
			}
		}
	}

	protected override void InsertItem(IMenuItem item, int index, IMenuItem subItem)
	{
		if (item.Items == null)
		{
			item.Items = new List<IMenuItem>();
		}
		item.Items.Insert(index, subItem);
		subItem.ParentItem = item;
		int num = ((index > 0) ? item.Items[index - 1].Weight : int.MinValue);
		int num2 = ((index + 1 < item.Items.Count) ? item.Items[index + 1].Weight : int.MaxValue);
		if (subItem.Weight > num && subItem.Weight < num2)
		{
			return;
		}
		num = (subItem.Weight = num + 1);
		if (WeightChanged != null)
		{
			WeightChanged(this, new MenuItemWeightChanged
			{
				MenuItem = subItem
			});
		}
		for (int i = index + 1; i < item.Items.Count && item.Items[i].Weight <= num; i++)
		{
			num = (item.Items[i].Weight = num + 1);
			if (WeightChanged != null)
			{
				WeightChanged(this, new MenuItemWeightChanged
				{
					MenuItem = item.Items[i]
				});
			}
		}
	}
}
