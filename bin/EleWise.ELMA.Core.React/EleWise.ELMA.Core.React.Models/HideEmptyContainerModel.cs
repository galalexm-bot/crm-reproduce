using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Collections;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Core.React.Models;

internal sealed class HideEmptyContainerModel : HideEmptyModel, IHideEmptyContainerModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<Func<bool>, bool> _003C_003E9__8_0;

		internal bool _003CGetHiddenValue_003Eb__8_0(Func<bool> i)
		{
			return i.Invoke();
		}
	}

	private readonly IHideEmptyViewItemContainerModel storage;

	private readonly IViewItem viewItem;

	private System.Collections.Generic.ICollection<Func<bool>> subscriberList;

	public HideEmptyContainerModel(IHideEmptyViewItemContainerModel containerModel, IViewItem viewItem, IHideEmptyContainerModel owner)
		: base(owner)
	{
		subscriberList = new ReactiveCollection<Func<bool>>();
		storage = containerModel;
		this.viewItem = viewItem;
	}

	public override void Init()
	{
		base.Init();
		storage.AddHideEmpty(viewItem, this);
	}

	public override void Destroy()
	{
		base.Destroy();
		storage.RemoveHideEmpty(viewItem);
		subscriberList = null;
	}

	public void AddIsHidden(Func<bool> isHidden)
	{
		if (subscriberList != null)
		{
			subscriberList.Add(isHidden);
		}
	}

	public void RemoveIsHidden(Func<bool> isHidden)
	{
		if (subscriberList != null)
		{
			subscriberList.Remove(isHidden);
		}
	}

	protected override bool GetHiddenValue()
	{
		return Enumerable.All<Func<bool>>((System.Collections.Generic.IEnumerable<Func<bool>>)subscriberList, (Func<Func<bool>, bool>)((Func<bool> i) => i.Invoke()));
	}
}
