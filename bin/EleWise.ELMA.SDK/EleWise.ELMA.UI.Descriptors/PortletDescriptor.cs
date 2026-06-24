using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Descriptors;

public class PortletDescriptor : FormDescriptor
{
	[Component]
	public class Info : IFormDescriptorInfo
	{
		internal static Info r3T81yfgjYiZK1sSZ14J;

		public Type MetadataType => s2325xfgUkncW28m0gcM(typeof(PortletMetadata).TypeHandle);

		public Type DescriptorType => typeof(PortletDescriptor);

		public Info()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			XdL8aYfgsbXfwutxOLwf();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static Type s2325xfgUkncW28m0gcM(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static void XdL8aYfgsbXfwutxOLwf()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool oWiEmIfgYjkULPXxqisn()
		{
			return r3T81yfgjYiZK1sSZ14J == null;
		}

		internal static Info S8xnMvfgLsBYkKUsPWdp()
		{
			return r3T81yfgjYiZK1sSZ14J;
		}
	}

	internal static PortletDescriptor mVRYQ5MMOyrXRIqRv4Q;

	public PortletContentDescriptor Content
	{
		[CompilerGenerated]
		get
		{
			return _003CContent_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CContent_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public PortletSettingsDescriptor Settings
	{
		[CompilerGenerated]
		get
		{
			return _003CSettings_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CSettings_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Type PersonalizationType
	{
		[CompilerGenerated]
		get
		{
			return _003CPersonalizationType_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CPersonalizationType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public PortletDescriptor(IFormMetadataItem item)
	{
		//Discarded unreachable code: IL_001b, IL_0150
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(item);
		int num = 2;
		string text = default(string);
		PortletMetadata portletMetadata = default(PortletMetadata);
		while (true)
		{
			switch (num)
			{
			case 4:
				if (!(PersonalizationType == null))
				{
					num = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num = 2;
					}
					break;
				}
				goto case 5;
			default:
				PersonalizationType = base.Assembly.GetType(text);
				num = 4;
				break;
			case 5:
				throw new TypeNotFoundException(text);
			case 6:
				return;
			case 2:
				KmrHUJMrSpx6kh3eKau(gh3YqpMdiFPC9HGZBQJ(item) is PortletMetadata, BXhooVMlkC09nJu5K5m(0x3A5D5EF ^ 0x3A57E09));
				num = 3;
				break;
			case 7:
				Content = new PortletContentDescriptor(this, (PortletContentMetadata)iMQEbhMgLqecycdLL0R(portletMetadata));
				num = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num = 0;
				}
				break;
			case 3:
			{
				portletMetadata = (PortletMetadata)gh3YqpMdiFPC9HGZBQJ(item);
				int num2 = 7;
				num = num2;
				break;
			}
			case 8:
				Settings = new PortletSettingsDescriptor(this, portletMetadata.Settings);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				text = (string)pg1LJmMLJnf1AXncLFq(plgjt1M51AdOBA0F92A(portletMetadata), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A5D5EF ^ 0x3A59A31), lT18qCMY8LSh1pGDQtF(xtZfygMjZ5AuJ3S4Xbd(portletMetadata)));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static object gh3YqpMdiFPC9HGZBQJ(object P_0)
	{
		return ((IFormMetadataItem)P_0).Metadata;
	}

	internal static object BXhooVMlkC09nJu5K5m(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void KmrHUJMrSpx6kh3eKau(bool condition, object P_1)
	{
		Contract.CheckArgument(condition, (string)P_1);
	}

	internal static object iMQEbhMgLqecycdLL0R(object P_0)
	{
		return ((PortletMetadata)P_0).Content;
	}

	internal static object plgjt1M51AdOBA0F92A(object P_0)
	{
		return ((FormMetadata)P_0).FullTypeName;
	}

	internal static object xtZfygMjZ5AuJ3S4Xbd(object P_0)
	{
		return ((PortletMetadata)P_0).PersonalizationContext;
	}

	internal static object lT18qCMY8LSh1pGDQtF(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object pg1LJmMLJnf1AXncLFq(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static bool VxB9SQMJ5O1TTHwpxZy()
	{
		return mVRYQ5MMOyrXRIqRv4Q == null;
	}

	internal static PortletDescriptor eZMrW7M9WZCv9UY4kdh()
	{
		return mVRYQ5MMOyrXRIqRv4Q;
	}
}
