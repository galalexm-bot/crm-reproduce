using System;

namespace EleWise.ELMA.Core.React.Models;

internal sealed class ShowEmptyModel : IHideEmptyModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<bool> _003C_003E9__2_0;

		internal bool _003C_002Ector_003Eb__2_0()
		{
			return false;
		}
	}

	private readonly IHideEmptyContainerModel owner;

	private readonly Func<bool> isHidden;

	public bool IsEmpty => false;

	public ShowEmptyModel(IHideEmptyContainerModel owner)
	{
		isHidden = () => false;
		this.owner = owner;
	}

	public void Init()
	{
		if (owner != null)
		{
			owner.AddIsHidden(isHidden);
		}
	}

	public void Destroy()
	{
		if (owner != null)
		{
			owner.RemoveIsHidden(isHidden);
		}
	}
}
