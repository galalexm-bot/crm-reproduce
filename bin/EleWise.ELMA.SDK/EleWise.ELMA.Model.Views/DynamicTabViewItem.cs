using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_DynamicTabViewItem), "DisplayName")]
public class DynamicTabViewItem : TabViewItem, IDynamicViewItem, IViewItemWithPropertyParents
{
	private static DynamicTabViewItem SrLgpqoXp1x4HsT7j8lu;

	public Guid PropertyUid
	{
		[CompilerGenerated]
		get
		{
			return _003CPropertyUid_003Ek__BackingField;
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
				case 1:
					_003CPropertyUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public List<Guid> PropertyParents { get; set; }

	public DynamicTabViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		KA69VwoXtBVKx7ipO5Dw();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			PropertyParents = new List<Guid>();
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
			{
				num = 1;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializePropertyParents()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (PropertyParents != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return false;
			default:
				return OesVoLoXwlWKn7S7IS6w(PropertyParents) > 0;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializePropertyUid()
	{
		return X6e4cmoX4sman3WwB43D(PropertyUid, Guid.Empty);
	}

	internal static void KA69VwoXtBVKx7ipO5Dw()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool aRXj1noXaDEfwen0ZxBA()
	{
		return SrLgpqoXp1x4HsT7j8lu == null;
	}

	internal static DynamicTabViewItem u7pTZsoXDU0Er9rU5qUQ()
	{
		return SrLgpqoXp1x4HsT7j8lu;
	}

	internal static int OesVoLoXwlWKn7S7IS6w(object P_0)
	{
		return ((List<Guid>)P_0).Count;
	}

	internal static bool X6e4cmoX4sman3WwB43D(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}
}
