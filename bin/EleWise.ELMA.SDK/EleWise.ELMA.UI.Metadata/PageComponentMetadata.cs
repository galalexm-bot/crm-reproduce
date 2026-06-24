using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.UI.CodeGeneration;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Metadata;

[Serializable]
[XmlRoot("PageComponent")]
[Uid("{CBEA0822-E430-4BCF-8D6E-DD5AC76AE84E}")]
[DataContract]
public sealed class PageComponentMetadata : ComponentMetadata
{
	[Component]
	private sealed class Info : IMetadataTypeInfo
	{
		private static object oGR0ffQoIAAMsHKUKqdb;

		public string Name => SR.T((string)wLW5S3QoirMcqMs0T5Ia(-1638402543 ^ -1638608881));

		public string Description => (string)Lb7urJQoRtf8YYhqCfov(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606971372));

		public Type MetadataType => vJ41BgQoqq8TDVMFLlov(typeof(PageComponentMetadata).TypeHandle);

		public Type GeneratorType => vJ41BgQoqq8TDVMFLlov(typeof(PageComponentMetadataGenerator).TypeHandle);

		public Info()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			HxvypmQoKtuYHMd6WFhu();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object wLW5S3QoirMcqMs0T5Ia(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static bool SQW5xrQoV1TQdqECbwLk()
		{
			return oGR0ffQoIAAMsHKUKqdb == null;
		}

		internal static Info PbTkrhQoSrYjLNss4TcI()
		{
			return (Info)oGR0ffQoIAAMsHKUKqdb;
		}

		internal static object Lb7urJQoRtf8YYhqCfov(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static Type vJ41BgQoqq8TDVMFLlov(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static void HxvypmQoKtuYHMd6WFhu()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	public new static readonly Guid TypeUid;

	private static PageComponentMetadata pE8TpRBhUh92Q8M2h5QC;

	public PageComponentMetadata()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		OSAKt3BhzEvAyYY476mu();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public PageComponentMetadata(Guid moduleUid)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(moduleUid);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
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

	static PageComponentMetadata()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				TypeUid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87310407));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return;
			case 1:
				OSAKt3BhzEvAyYY476mu();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void OSAKt3BhzEvAyYY476mu()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool ykEuSFBhsidp752luTfr()
	{
		return pE8TpRBhUh92Q8M2h5QC == null;
	}

	internal static PageComponentMetadata n7Y2D0Bhc73XpDEcor4R()
	{
		return pE8TpRBhUh92Q8M2h5QC;
	}
}
