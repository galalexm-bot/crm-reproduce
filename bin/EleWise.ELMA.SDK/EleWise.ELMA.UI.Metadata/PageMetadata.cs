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

[Image(typeof(PageMetadata), "performance_matrix_user", 32, ImageFormatType.IconPack, false)]
[XmlRoot("Page")]
[Image(typeof(PageMetadata), "performance_matrix_user", 16, ImageFormatType.IconPack, false)]
public class PageMetadata : FormMetadata
{
	[Component]
	public class Info : IMetadataTypeInfo
	{
		private static Info bRuxwgQbilSxZJj8fChV;

		public string Name => SR.T((string)w7OsQAQbKumuQF2Fsgky(-3333094 ^ -3276284));

		public string Description => (string)aAAc4pQbX5o8g14HdFmq(w7OsQAQbKumuQF2Fsgky(-1876063057 ^ -1876367581));

		public Type MetadataType => zedN9xQbTGjGuZXbfXwS(typeof(PageMetadata).TypeHandle);

		public Type GeneratorType => zedN9xQbTGjGuZXbfXwS(typeof(PageMetadataGenerator).TypeHandle);

		public Info()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object w7OsQAQbKumuQF2Fsgky(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static bool lynwFpQbRqoRaa1layFc()
		{
			return bRuxwgQbilSxZJj8fChV == null;
		}

		internal static Info nbcCCdQbqTTe386O2yoQ()
		{
			return bRuxwgQbilSxZJj8fChV;
		}

		internal static object aAAc4pQbX5o8g14HdFmq(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static Type zedN9xQbTGjGuZXbfXwS(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}
	}

	public static readonly Guid TypeUid;

	internal static PageMetadata AVAY8OBErwAZspQrF2am;

	public PageContentMetadata Content
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override IEnumerable<Guid> PartUids
	{
		[IteratorStateMachine(typeof(_003Cget_PartUids_003Ed__11))]
		get
		{
			//yield-return decompiler failed: Missing enumeratorCtor.Body
			return new _003Cget_PartUids_003Ed__11(-2)
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
		//Discarded unreachable code: IL_00f2, IL_0101
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					Tcf4wcBEcXybcnSApXTY(Content.Context, RA5PP5BEshsK029ZuIHk(iWHSqDBEjYhDOxFUYIeE(-1867198571 ^ -1867243005)));
					num2 = 7;
					break;
				default:
					Content = new PageContentMetadata();
					num2 = 9;
					break;
				case 6:
					nMEya6BEUi58obYmFLnp(x908WYBELgrYOkAgX8DH(Content), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6DC147B0 ^ 0x6DC1AA38));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 4;
					}
					break;
				case 9:
					b4mqTrBEYDEkqoyT8Usy(Content);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 2;
					}
					break;
				case 3:
					return;
				case 1:
					if (string.IsNullOrEmpty(base.Namespace))
					{
						goto end_IL_0012;
					}
					goto case 5;
				case 5:
					if (Content != null)
					{
						num2 = 3;
						break;
					}
					goto default;
				case 2:
					base.InitNew();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 1;
					}
					break;
				case 8:
					base.Namespace = (string)iWHSqDBEjYhDOxFUYIeE(0x3CE17B75 ^ 0x3CE1962F);
					num2 = 5;
					break;
				case 7:
					return;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 8;
		}
	}

	public override EntityMetadata GetPartContext(Guid uid)
	{
		//Discarded unreachable code: IL_0091, IL_00a0, IL_00b0, IL_00bf
		int num = 5;
		int num2 = num;
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (x908WYBELgrYOkAgX8DH(Content) == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 6:
				return entityMetadata;
			case 3:
			case 4:
				return null;
			case 5:
				if (Content == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 1;
			case 2:
				entityMetadata = FindFormContextRecursive(Content.Context, uid);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (entityMetadata != null)
				{
					num2 = 6;
					break;
				}
				goto case 3;
			}
		}
	}

	public override FormPartMetadata GetPart(Guid partUid)
	{
		//Discarded unreachable code: IL_0061, IL_0070
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!ECiw5PBfFY1k8hwGMc18(tkOyqkBEzlyDU3EmS2OD(Content), partUid))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 1:
				return Content;
			default:
				return null;
			case 3:
				if (Content != null)
				{
					num2 = 2;
					break;
				}
				goto default;
			}
		}
	}

	public override void GenerateNewUids()
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (Content != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					return;
				case 2:
					break;
				case 3:
					return;
				case 1:
					base.GenerateNewUids();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			FI6ArHBfBDycIokP2u3o(Content);
			num = 3;
		}
	}

	protected override void GetMetadataToRegister(List<IMetadata> metadataList)
	{
		if (Content != null && Content.Context != null)
		{
			metadataList.Add(Content.Context);
		}
	}

	public PageMetadata()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		yRFqrJBfWLgRjCyCFbeY();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static PageMetadata()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 0;
				}
				break;
			default:
				TypeUid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463AE2D0));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static bool yC4JXbBEg2ZTKorUedUl()
	{
		return AVAY8OBErwAZspQrF2am == null;
	}

	internal static PageMetadata WnD3iQBE5eDld8L1jGcB()
	{
		return AVAY8OBErwAZspQrF2am;
	}

	internal static object iWHSqDBEjYhDOxFUYIeE(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void b4mqTrBEYDEkqoyT8Usy(object P_0)
	{
		((AbstractMetadata)P_0).InitNew();
	}

	internal static object x908WYBELgrYOkAgX8DH(object P_0)
	{
		return ((FormPartMetadata)P_0).Context;
	}

	internal static void nMEya6BEUi58obYmFLnp(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Name = (string)P_1;
	}

	internal static object RA5PP5BEshsK029ZuIHk(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void Tcf4wcBEcXybcnSApXTY(object P_0, object P_1)
	{
		((NamedMetadata)P_0).DisplayName = (string)P_1;
	}

	internal static Guid tkOyqkBEzlyDU3EmS2OD(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static bool ECiw5PBfFY1k8hwGMc18(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static void FI6ArHBfBDycIokP2u3o(object P_0)
	{
		((FormPartMetadata)P_0).GenerateNewUids();
	}

	internal static void yRFqrJBfWLgRjCyCFbeY()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
