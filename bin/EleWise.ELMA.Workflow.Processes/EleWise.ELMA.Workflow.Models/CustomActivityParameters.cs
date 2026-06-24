using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Workflow.Mappings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models;

[Serializable]
[Entity("CustomActivityParameters")]
[DisplayName(typeof(__Resources_CustomActivityParameters), "DisplayName")]
[Uid("{C68A3664-8211-4960-B082-7BDC7E24FC9B}")]
[MetadataType(typeof(EntityMetadata))]
[ClassMap(typeof(CustomActivityParametersMap))]
[BaseClass("{C40FD1D3-F5D9-4323-9E51-42EBFA77E6DC}")]
public class CustomActivityParameters : EntityMetadata
{
	[Component]
	public class Info : IMetadataTypeInfo
	{
		private static Info Ma3TfKG17NlICojjWyI;

		public string Name => (string)hWq5CPnETKfxOJvPjTW(bEg9yIGz8bOMVxxAaoD(-2144947971 ^ -2144950241));

		public string Description => string.Empty;

		public Type MetadataType => cIxA6NnCCgOAZ1l76Lg(typeof(CustomActivityParameters).TypeHandle);

		public Type GeneratorType => cIxA6NnCCgOAZ1l76Lg(typeof(EntityGenerator).TypeHandle);

		public Info()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			nlbO6xnXZpmiMQOJo93();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_eb17dd137d8d48b5ba1e0580355a54c3 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object bEg9yIGz8bOMVxxAaoD(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object hWq5CPnETKfxOJvPjTW(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool pv449uGIWd7JgWvDV9f()
		{
			return Ma3TfKG17NlICojjWyI == null;
		}

		internal static Info aVUZDfGZ3Vy9ekBSTE4()
		{
			return Ma3TfKG17NlICojjWyI;
		}

		internal static Type cIxA6NnCCgOAZ1l76Lg(RuntimeTypeHandle P_0)
		{
			return System.Type.GetTypeFromHandle(P_0);
		}

		internal static void nlbO6xnXZpmiMQOJo93()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		}
	}

	public new const string UID_S = "{C68A3664-8211-4960-B082-7BDC7E24FC9B}";

	private static Guid _UID;

	internal static CustomActivityParameters WSnycf2VXweqiOkYWEG;

	public override Guid TypeUid
	{
		get
		{
			return _UID;
		}
		set
		{
		}
	}

	[StringSettings(FieldName = "AssemblyName")]
	[EntityProperty]
	[Uid("{C6C7C234-4BFA-4EDE-92E5-782A075855B2}")]
	[XmlElement("AssemblyName")]
	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	public virtual string AssemblyName
	{
		[CompilerGenerated]
		get
		{
			return _003CAssemblyName_003Ek__BackingField;
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
					_003CAssemblyName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7ae8403b9a8240c5b9d009904e9a6779 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Property("{1911B22D-0CE2-4743-832F-6A44CB0357FE}")]
	[Uid("{17C9180A-99AF-46D3-A73A-38AAFA71B0A4}")]
	[BlobSettings(FieldName = "AssemblyRaw")]
	[XmlElement("AssemblyRaw", IsNullable = true)]
	[EntityProperty]
	public virtual byte[] AssemblyRaw
	{
		[CompilerGenerated]
		get
		{
			return _003CAssemblyRaw_003Ek__BackingField;
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
					_003CAssemblyRaw_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9451b1fac1ed452e82e1cbd5a96b41fd == 0)
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

	[Uid("{F34C6B51-FE97-440A-A16B-F270152D22D7}")]
	[EntityProperty]
	[BlobSettings(FieldName = "DebugRaw")]
	[XmlElement("DebugRaw", IsNullable = true)]
	[Property("{1911B22D-0CE2-4743-832F-6A44CB0357FE}")]
	public virtual byte[] DebugRaw
	{
		[CompilerGenerated]
		get
		{
			return _003CDebugRaw_003Ek__BackingField;
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
					_003CDebugRaw_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13af7ecdfdd3466b80333112ab4ca5a5 != 0)
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

	public override PropertyMetadata CreateProperty(bool initNew = false)
	{
		//Discarded unreachable code: IL_0048, IL_0057
		int num = 2;
		int num2 = num;
		EntityPropertyMetadata entityPropertyMetadata = default(EntityPropertyMetadata);
		while (true)
		{
			switch (num2)
			{
			case 3:
			case 4:
				return entityPropertyMetadata;
			case 1:
				if (!initNew)
				{
					num2 = 4;
					continue;
				}
				break;
			case 2:
				entityPropertyMetadata = new EntityPropertyMetadata();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_931b467c9a154e15b6f12c7011275615 == 0)
				{
					num2 = 1;
				}
				continue;
			}
			entityPropertyMetadata.InitNew();
			num2 = 3;
		}
	}

	public CustomActivityParameters()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Y3EoNe2Mhe3iptvqlM0();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e6a95a03603e49dfb9bfc60af0009767 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static CustomActivityParameters()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2d82a778b0ee4fc0915a368d2259a8f3 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				_UID = new Guid((string)mb9SPu2aL0c8qtFv7Xj(0x148F9F60 ^ 0x148F87F2));
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_6ee07aa726964a2281f0ce81cd001aec != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static bool DKFMuM2Dsc41K5NUBOj()
	{
		return WSnycf2VXweqiOkYWEG == null;
	}

	internal static CustomActivityParameters AFdsls2Ks6vc4qtF8qN()
	{
		return WSnycf2VXweqiOkYWEG;
	}

	internal static void Y3EoNe2Mhe3iptvqlM0()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static object mb9SPu2aL0c8qtFv7Xj(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
