using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.CodeGeneration;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Metadata;

[Image(typeof(PortletMetadata), "portlet", 16, ImageFormatType.IconPack, false)]
[XmlRoot("Portlet")]
[Image(typeof(PortletMetadata), "portlet", 32, ImageFormatType.IconPack, false)]
public class PortletMetadata : FormMetadata
{
	[Component]
	public class Info : IMetadataTypeInfo
	{
		internal static Info HV3ayOQbe0x3VcTZPgOE;

		public string Name => (string)uOQgCHQb3apNpHaVBAjN(BdidOXQbNZGWO8vjrQly(-2099751081 ^ -2099547813));

		public string Description => (string)uOQgCHQb3apNpHaVBAjN(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345233796));

		public Type MetadataType => yPiEU0Qbpc14Y58SW0iS(typeof(PortletMetadata).TypeHandle);

		public Type GeneratorType => typeof(PortletMetadataGenerator);

		public Info()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			xDIZCEQbapWhb8N5BZPi();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object BdidOXQbNZGWO8vjrQly(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object uOQgCHQb3apNpHaVBAjN(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool zSTHKyQbPNHXkXoQrXYB()
		{
			return HV3ayOQbe0x3VcTZPgOE == null;
		}

		internal static Info lLcl0yQb1geWaGBtaiVH()
		{
			return HV3ayOQbe0x3VcTZPgOE;
		}

		internal static Type yPiEU0Qbpc14Y58SW0iS(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static void xDIZCEQbapWhb8N5BZPi()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	public const string IconImageKey = "CD097E40E88B466B833FC69F312600AF";

	public static readonly Guid TypeUid;

	internal static PortletMetadata dbYlblBfC1PG0bnmP7ZY;

	public PortletContentMetadata Content
	{
		[CompilerGenerated]
		get
		{
			return _003CContent_003Ek__BackingField;
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
					_003CContent_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public FormContextMetadata PersonalizationContext
	{
		[CompilerGenerated]
		get
		{
			return _003CPersonalizationContext_003Ek__BackingField;
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
					_003CPersonalizationContext_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public PortletSettingsMetadata Settings
	{
		[CompilerGenerated]
		get
		{
			return _003CSettings_003Ek__BackingField;
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
					_003CSettings_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public MetadataImage Icon
	{
		get
		{
			return (MetadataImage)dRAcl8BfZS3fHRyNVSWu(this, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398717088));
		}
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
					WBh0veBfIpZUCdAcBK42(this, DsmtCeBfuTMghvQIlx6l(0x463A0F3C ^ 0x463AE100), value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
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

	public string IconUrl
	{
		[CompilerGenerated]
		get
		{
			return _003CIconUrl_003Ek__BackingField;
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
					_003CIconUrl_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
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

	public override IEnumerable<Guid> PartUids
	{
		[IteratorStateMachine(typeof(_003Cget_PartUids_003Ed__28))]
		get
		{
			//yield-return decompiler failed: Missing enumeratorCtor.Body
			return new _003Cget_PartUids_003Ed__28(-2)
			{
				_003C_003E4__this = this
			};
		}
	}

	public override Guid GetTypeUid()
	{
		return TypeUid;
	}

	public override void InitNew()
	{
		//Discarded unreachable code: IL_0245, IL_0254
		int num = 9;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					Settings.InitNew();
					num = 18;
					break;
				case 17:
					base.Namespace = (string)DsmtCeBfuTMghvQIlx6l(0x57A5235E ^ 0x57A5CDDE);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
					{
						num2 = 0;
					}
					continue;
				case 19:
					IBRHkOBfK4AEXjDGiH2A(Content.Context, QVq04SBfqpYXMuE5d0Vi(DsmtCeBfuTMghvQIlx6l(0x49E27B8A ^ 0x49E2954C)));
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 14;
					}
					continue;
				case 8:
					if (Yv554aBfVDHZ1pAsoUxX(base.Namespace))
					{
						num2 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto default;
				case 9:
					base.InitNew();
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 8;
					}
					continue;
				case 3:
					Content = new PortletContentMetadata();
					num = 16;
					break;
				case 16:
					KoRqOQBfSQRegU6KYGBo(Content);
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
					{
						num2 = 6;
					}
					continue;
				case 18:
					lH6HF1BfR0OK9mqCP1En(ySwycBBfiykmSeiXngxr(Settings), DsmtCeBfuTMghvQIlx6l(0x10E41EDB ^ 0x10E43E4D));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					KoRqOQBfSQRegU6KYGBo(PersonalizationContext);
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num2 = 2;
					}
					continue;
				case 11:
					IBRHkOBfK4AEXjDGiH2A(PersonalizationContext, QVq04SBfqpYXMuE5d0Vi(DsmtCeBfuTMghvQIlx6l(0x4EDCBA32 ^ 0x4EDC552E)));
					num = 5;
					break;
				case 13:
					lH6HF1BfR0OK9mqCP1En(PersonalizationContext, DsmtCeBfuTMghvQIlx6l(-1822890472 ^ -1822945998));
					num2 = 11;
					continue;
				case 5:
					if (Settings == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					return;
				case 1:
					IBRHkOBfK4AEXjDGiH2A(ySwycBBfiykmSeiXngxr(Settings), SR.T((string)DsmtCeBfuTMghvQIlx6l(0x53FA00CE ^ 0x53FAEF82)));
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num2 = 5;
					}
					continue;
				case 10:
				case 15:
					if (PersonalizationContext == null)
					{
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 5;
				case 6:
					return;
				case 2:
					Settings = new PortletSettingsMetadata();
					num2 = 7;
					continue;
				default:
					if (Content != null)
					{
						num2 = 10;
						continue;
					}
					goto case 3;
				case 14:
					PersonalizationContext = new FormContextMetadata();
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
					{
						num2 = 1;
					}
					continue;
				case 12:
					lH6HF1BfR0OK9mqCP1En(ySwycBBfiykmSeiXngxr(Content), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867767560));
					num = 19;
					break;
				}
				break;
			}
		}
	}

	public override void GenerateNewUids()
	{
		int num = 6;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					IWjd2wBfX1qecO5QTJAy(Settings);
					num2 = 2;
					break;
				default:
					Nmu5RtBfTWKe3NeJYaRa(PersonalizationContext);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
					{
						num2 = 7;
					}
					break;
				case 2:
					return;
				case 7:
					if (Settings == null)
					{
						return;
					}
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 3;
					}
					break;
				case 5:
					if (Content != null)
					{
						goto end_IL_0012;
					}
					goto case 1;
				case 6:
					base.GenerateNewUids();
					num2 = 5;
					break;
				case 1:
					if (PersonalizationContext != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 7;
				case 4:
					IWjd2wBfX1qecO5QTJAy(Content);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 0;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	public override EntityMetadata GetPartContext(Guid uid)
	{
		//Discarded unreachable code: IL_014c, IL_015b, IL_01ca, IL_01d9, IL_0213, IL_0222
		int num = 13;
		int num2 = num;
		EntityMetadata entityMetadata = default(EntityMetadata);
		EntityMetadata entityMetadata2 = default(EntityMetadata);
		EntityMetadata entityMetadata3 = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			case 11:
				return entityMetadata;
			case 1:
			case 12:
				if (PersonalizationContext != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 4;
			case 6:
				entityMetadata2 = FindFormContextRecursive(PersonalizationContext, uid);
				num2 = 15;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num2 = 13;
				}
				break;
			case 3:
				return entityMetadata3;
			case 7:
				return null;
			case 13:
				if (Content == null)
				{
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 8;
			default:
				return entityMetadata2;
			case 4:
				if (Settings != null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 10;
					}
					break;
				}
				goto case 7;
			case 2:
				entityMetadata3 = FindFormContextRecursive((EntityMetadata)ySwycBBfiykmSeiXngxr(Settings), uid);
				num2 = 5;
				break;
			case 8:
				if (ySwycBBfiykmSeiXngxr(Content) == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 9;
			case 5:
				if (entityMetadata3 != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 7;
			case 15:
				if (entityMetadata2 == null)
				{
					num2 = 4;
					break;
				}
				goto default;
			case 9:
				entityMetadata = FindFormContextRecursive((EntityMetadata)ySwycBBfiykmSeiXngxr(Content), uid);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num2 = 14;
				}
				break;
			case 10:
				if (Settings.Context == null)
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 14:
				if (entityMetadata != null)
				{
					num2 = 11;
					break;
				}
				goto case 1;
			}
		}
	}

	public override FormPartMetadata GetPart(Guid partUid)
	{
		//Discarded unreachable code: IL_006b, IL_007a, IL_008a, IL_0099
		int num = 6;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 6:
				if (Content != null)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			case 1:
				return Settings;
			case 4:
				return null;
			case 3:
				return Content;
			default:
				if (Settings != null)
				{
					num2 = 2;
					break;
				}
				goto case 4;
			case 2:
				if (!(SHdO3SBfkIAvG87atnJ5(Settings) == partUid))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 1;
			case 5:
				if (!(Content.Uid == partUid))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	protected override void GetMetadataToRegister(List<IMetadata> metadataList)
	{
		if (Content != null && Content.Context != null)
		{
			metadataList.Add(Content.Context);
		}
		if (PersonalizationContext != null)
		{
			metadataList.Add(PersonalizationContext);
		}
		if (Settings != null && Settings.Context != null)
		{
			metadataList.Add(Settings.Context);
		}
	}

	public PortletMetadata()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		yu7JjVBfnL9mWGDQwxYy();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static PortletMetadata()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				yu7JjVBfnL9mWGDQwxYy();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				TypeUid = new Guid((string)DsmtCeBfuTMghvQIlx6l(-138018305 ^ -137957801));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool zbj8naBfv0cML7TMgZIq()
	{
		return dbYlblBfC1PG0bnmP7ZY == null;
	}

	internal static PortletMetadata ytDiCGBf8q0v0sfKK9tu()
	{
		return dbYlblBfC1PG0bnmP7ZY;
	}

	internal static object dRAcl8BfZS3fHRyNVSWu(object P_0, object P_1)
	{
		return ((NamedMetadata)P_0).GetNamedImage((string)P_1);
	}

	internal static object DsmtCeBfuTMghvQIlx6l(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void WBh0veBfIpZUCdAcBK42(object P_0, object P_1, object P_2)
	{
		((NamedMetadata)P_0).AddNamedImage((string)P_1, (MetadataImage)P_2);
	}

	internal static bool Yv554aBfVDHZ1pAsoUxX(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void KoRqOQBfSQRegU6KYGBo(object P_0)
	{
		((AbstractMetadata)P_0).InitNew();
	}

	internal static object ySwycBBfiykmSeiXngxr(object P_0)
	{
		return ((FormPartMetadata)P_0).Context;
	}

	internal static void lH6HF1BfR0OK9mqCP1En(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Name = (string)P_1;
	}

	internal static object QVq04SBfqpYXMuE5d0Vi(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void IBRHkOBfK4AEXjDGiH2A(object P_0, object P_1)
	{
		((NamedMetadata)P_0).DisplayName = (string)P_1;
	}

	internal static void IWjd2wBfX1qecO5QTJAy(object P_0)
	{
		((FormPartMetadata)P_0).GenerateNewUids();
	}

	internal static void Nmu5RtBfTWKe3NeJYaRa(object P_0)
	{
		((FormContextMetadata)P_0).GenerateNewUids();
	}

	internal static Guid SHdO3SBfkIAvG87atnJ5(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static void yu7JjVBfnL9mWGDQwxYy()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
