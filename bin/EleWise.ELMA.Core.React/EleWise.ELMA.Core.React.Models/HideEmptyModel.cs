using System;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Core.React.Models;

internal abstract class HideEmptyModel : IHideEmptyModel
{
	private readonly IHideEmptyContainerModel owner;

	private readonly Func<bool> isHidden;

	private bool currentHideEmpty;

	public bool IsEmpty => currentHideEmpty;

	protected HideEmptyModel(IHideEmptyContainerModel owner)
	{
		this.owner = owner;
		ViewModel.DefineProperty(this, new PropertyInfoExpression
		{
			ObjectExpression = "currentHideEmpty",
			ExpressionForSerialize = "currentHideEmpty"
		});
		isHidden = () => currentHideEmpty;
	}

	protected abstract bool GetHiddenValue();

	public virtual void Init()
	{
		currentHideEmpty = GetHiddenValue();
		if (owner != null)
		{
			owner.AddIsHidden(isHidden);
		}
	}

	public virtual void Destroy()
	{
		if (owner != null)
		{
			owner.RemoveIsHidden(isHidden);
		}
	}

	private bool _003C_002Ector_003Eb__3_0()
	{
		return currentHideEmpty;
	}

	private bool _003CInit_003Eb__7_0()
	{
		return GetHiddenValue();
	}
}
