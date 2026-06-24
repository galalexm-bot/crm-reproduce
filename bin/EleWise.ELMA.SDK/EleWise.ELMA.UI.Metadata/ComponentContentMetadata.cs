using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Metadata;

[Serializable]
[DataContract]
public class ComponentContentMetadata : AbstractMetadata
{
	private static ComponentContentMetadata GDcOs9BGh0omdgHPRimR;

	public ComponentContextMetadata Context
	{
		[CompilerGenerated]
		get
		{
			return _003CContext_003Ek__BackingField;
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
					_003CContext_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
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

	public FormViewItem View
	{
		[CompilerGenerated]
		get
		{
			return _003CView_003Ek__BackingField;
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
					_003CView_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
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

	public override void InitNew()
	{
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
				{
					ComponentContextMetadata componentContextMetadata = new ComponentContextMetadata();
					iuCucPBGf8rjEx8ULNrN(componentContextMetadata, ModuleUid);
					aBjNSgBGCKCwCgaCERgV(componentContextMetadata, JHYxAIBGQXQQUSYnd8Dw(0x53CACA3 ^ 0x53C40BD));
					Context = componentContextMetadata;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				case 3:
					break;
				case 4:
					View = new FormViewItem
					{
						RuntimeVersion = RuntimeVersion.Version2
					};
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					Q2LL56BGv46vjqlkM4tv(View, null);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					Context.InitNew();
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 4;
					}
					continue;
				case 1:
					return;
				}
				break;
			}
			base.InitNew();
			num = 2;
		}
	}

	public virtual void GenerateNewUids()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 3:
				DtepjcBGZRvlHXXb6iWx(this, Qa4Ki2BG8WhAbBEVfupv());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
			{
				ComponentContextMetadata context = Context;
				if (context == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 0;
					}
					break;
				}
				FgfW1YBGu6v3XEdJyVZw(context);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 1:
				return;
			}
		}
	}

	public ComponentContentMetadata()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		IuuKvIBGINgDM1IcJThV();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool CpFBRJBGGCkL3mwWbEZm()
	{
		return GDcOs9BGh0omdgHPRimR == null;
	}

	internal static ComponentContentMetadata KfkFr7BGEwVnfI0aC1Ej()
	{
		return GDcOs9BGh0omdgHPRimR;
	}

	internal static void iuCucPBGf8rjEx8ULNrN(object P_0, Guid value)
	{
		((AbstractMetadata)P_0).ModuleUid = value;
	}

	internal static object JHYxAIBGQXQQUSYnd8Dw(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void aBjNSgBGCKCwCgaCERgV(object P_0, object P_1)
	{
		((ClassMetadata)P_0).Namespace = (string)P_1;
	}

	internal static void Q2LL56BGv46vjqlkM4tv(object P_0, object P_1)
	{
		((ViewItem)P_0).InitNew((ViewItem)P_1);
	}

	internal static Guid Qa4Ki2BG8WhAbBEVfupv()
	{
		return Guid.NewGuid();
	}

	internal static void DtepjcBGZRvlHXXb6iWx(object P_0, Guid value)
	{
		((AbstractMetadata)P_0).Uid = value;
	}

	internal static void FgfW1YBGu6v3XEdJyVZw(object P_0)
	{
		((AbstractMetadata)P_0).InitNew();
	}

	internal static void IuuKvIBGINgDM1IcJThV()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
