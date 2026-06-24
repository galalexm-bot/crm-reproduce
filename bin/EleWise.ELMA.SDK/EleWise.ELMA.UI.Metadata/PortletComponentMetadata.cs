using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.CodeGeneration;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Metadata;

[Serializable]
[XmlRoot("PortletComponent")]
[DataContract]
[Uid("{76584C56-99AD-4D3E-B0AB-7758333251BD}")]
public sealed class PortletComponentMetadata : ComponentMetadata
{
	[Component]
	private sealed class Info : IMetadataTypeInfo
	{
		internal static object Nnr6QYQoQ5RYCUntOnyI;

		public string Name => (string)pUIHrZQo8aLiTXX191Si(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2139015692));

		public string Description => (string)pUIHrZQo8aLiTXX191Si(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x26FFCB59 ^ 0x26FAA18D));

		public Type MetadataType => vC0oqoQoZF8MLfwbtgaC(typeof(PortletComponentMetadata).TypeHandle);

		public Type GeneratorType => vC0oqoQoZF8MLfwbtgaC(typeof(PortletComponentMetadataGenerator).TypeHandle);

		public Info()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			klTKscQouAMwEfBj6PEU();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object pUIHrZQo8aLiTXX191Si(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool YIekHjQoCc3NI9nd38w2()
		{
			return Nnr6QYQoQ5RYCUntOnyI == null;
		}

		internal static Info YUg9ZEQov0JiKltaM4UC()
		{
			return (Info)Nnr6QYQoQ5RYCUntOnyI;
		}

		internal static Type vC0oqoQoZF8MLfwbtgaC(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static void klTKscQouAMwEfBj6PEU()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	public new static readonly Guid TypeUid;

	internal static PortletComponentMetadata qM7284Bha4Fw19vcAVLT;

	public PortletPersonalizationMetadata PersonalizationContext
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public PortletComponentMetadata()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		O6B68aBhwBSvaUW8oDhr();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public PortletComponentMetadata(Guid moduleUid)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		O6B68aBhwBSvaUW8oDhr();
		base._002Ector(moduleUid);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override Guid GetMetadataTypeUid()
	{
		return TypeUid;
	}

	public override void InitNew()
	{
		//Discarded unreachable code: IL_00a6
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (PersonalizationContext == null)
				{
					num2 = 6;
					break;
				}
				return;
			case 1:
				WwKPGpBh4Ir8H176QqnA(PersonalizationContext);
				num2 = 3;
				break;
			case 3:
				khm5XlBh669wqP844ckm(PersonalizationContext, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561101234));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				base.InitNew();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 4;
				}
				break;
			case 2:
				return;
			case 7:
				return;
			case 6:
				PersonalizationContext = new PortletPersonalizationMetadata();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num2 = 1;
				}
				break;
			default:
				aArZhyBhAi5wCSh5O6of(PersonalizationContext, SR.T((string)tkr5jgBhH4w4gmuHaxqk(0x7C1EE318 ^ 0x7C1E0854)));
				num2 = 2;
				break;
			}
		}
	}

	static PortletComponentMetadata()
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
			case 1:
				TypeUid = new Guid((string)tkr5jgBhH4w4gmuHaxqk(0x26FFCB59 ^ 0x26FF2027));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static void O6B68aBhwBSvaUW8oDhr()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Lwty84BhDUbn8c8xbnCK()
	{
		return qM7284Bha4Fw19vcAVLT == null;
	}

	internal static PortletComponentMetadata y7mNqMBhtUToNEDnr1IX()
	{
		return qM7284Bha4Fw19vcAVLT;
	}

	internal static void WwKPGpBh4Ir8H176QqnA(object P_0)
	{
		((AbstractMetadata)P_0).InitNew();
	}

	internal static void khm5XlBh669wqP844ckm(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Name = (string)P_1;
	}

	internal static object tkr5jgBhH4w4gmuHaxqk(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void aArZhyBhAi5wCSh5O6of(object P_0, object P_1)
	{
		((NamedMetadata)P_0).DisplayName = (string)P_1;
	}
}
