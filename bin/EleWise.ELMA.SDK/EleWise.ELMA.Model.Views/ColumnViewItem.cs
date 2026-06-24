using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Views.Toolbox;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_ColumnViewItem), "DisplayName")]
public class ColumnViewItem : RootViewItem, ILayoutItemViewItem, IContainerViewItem
{
	[Component(Order = 100)]
	private class ToolboxItem : CommonViewItemToolboxItem<ColumnViewItem>
	{
		private static object I5gSJrCfGk52wB5K4tLO;

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			cvv7ifCfQuHd5MktAnAs();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void cvv7ifCfQuHd5MktAnAs()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool wctgpZCfEyRsExJSQRYd()
		{
			return I5gSJrCfGk52wB5K4tLO == null;
		}

		internal static ToolboxItem tRpVS2CffWhaNLheNkXO()
		{
			return (ToolboxItem)I5gSJrCfGk52wB5K4tLO;
		}
	}

	private static ColumnViewItem X2QGl7oOIUcULRq9HRp5;

	[DefaultValue(ViewItemColumnSize.Auto)]
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public virtual ViewItemColumnSize Size
	{
		[CompilerGenerated]
		get
		{
			return _003CSize_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CSize_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (parentViewItem != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return true;
			default:
				return vOFsT8oOi6W3XxAwKpAd(parentViewItem, this);
			}
		}
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}

	public ColumnViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		qKIsxdoORbZSivcjxkIK();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool vOFsT8oOi6W3XxAwKpAd(object P_0, object P_1)
	{
		return ((ViewItem)P_0).IsChildValid((ViewItem)P_1);
	}

	internal static bool YTjIdCoOV9q3BVEK4ocL()
	{
		return X2QGl7oOIUcULRq9HRp5 == null;
	}

	internal static ColumnViewItem Cvakj7oOSCb8gDTyvEDT()
	{
		return X2QGl7oOIUcULRq9HRp5;
	}

	internal static void qKIsxdoORbZSivcjxkIK()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
