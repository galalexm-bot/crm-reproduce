using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Views.Toolbox;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_ExtensionZoneViewItem), "DisplayName")]
public class ExtensionZoneViewItem : ViewItem
{
	private class ToolboxItem : AdditionalViewItemToolboxItem<ExtensionZoneViewItem>
	{
		internal static object vd8UKpCQSR1ime07Q9dG;

		public override bool IsAvailable(IMetadata metadata)
		{
			//Discarded unreachable code: IL_0031, IL_0040
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (!base.IsAvailable(metadata))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				default:
					if (MetadataAccessInfo.EnvironmentType != MetadataEnvironmentType.VisualStudio)
					{
						num2 = 3;
						break;
					}
					return true;
				case 3:
					return MetadataAccessInfo.EnvironmentType == MetadataEnvironmentType.DevServer;
				case 1:
					return false;
				}
			}
		}

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			cIePwxCQqpjtyQJjcWVb();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool BR66ebCQicTt7EG0d6Or()
		{
			return vd8UKpCQSR1ime07Q9dG == null;
		}

		internal static ToolboxItem CK4ZGHCQRkrswg04B9dO()
		{
			return (ToolboxItem)vd8UKpCQSR1ime07Q9dG;
		}

		internal static void cIePwxCQqpjtyQJjcWVb()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	internal static ExtensionZoneViewItem jXsX7eo2XpUGnRbVYuGS;

	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public string ZoneId
	{
		[CompilerGenerated]
		get
		{
			return _003CZoneId_003Ek__BackingField;
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
					_003CZoneId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
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

	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	[DefaultValue(true)]
	public virtual bool UseOriginalModel
	{
		[CompilerGenerated]
		get
		{
			return _003CUseOriginalModel_003Ek__BackingField;
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
					_003CUseOriginalModel_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
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

	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	[DefaultValue(false)]
	public bool SupportInColumnRender
	{
		[CompilerGenerated]
		get
		{
			return _003CSupportInColumnRender_003Ek__BackingField;
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
					_003CSupportInColumnRender_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
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

	public ExtensionZoneViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Q74BrJo2nMqjkxhGVH1G();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
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
			UseOriginalModel = true;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
			{
				num = 1;
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
			default:
				return w4JG98o2OewgObeLs3fh(parentViewItem, this);
			case 1:
				if (parentViewItem == null)
				{
					return true;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return false;
	}

	internal static void Q74BrJo2nMqjkxhGVH1G()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool QDmoKpo2Tihc4aCCbKpv()
	{
		return jXsX7eo2XpUGnRbVYuGS == null;
	}

	internal static ExtensionZoneViewItem z3RUEAo2km73HElV45dm()
	{
		return jXsX7eo2XpUGnRbVYuGS;
	}

	internal static bool w4JG98o2OewgObeLs3fh(object P_0, object P_1)
	{
		return ((ViewItem)P_0).IsChildValid((ViewItem)P_1);
	}
}
