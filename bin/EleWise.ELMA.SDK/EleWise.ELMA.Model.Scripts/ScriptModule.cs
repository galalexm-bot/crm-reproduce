using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts.Types.Settings;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.ScriptDesigner.TranslateData;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Scripts;

[Entity("ScriptModule")]
[DisplayName(typeof(ScriptModule_Resources), "DisplayName")]
[ShowInDesigner(false)]
[ShowInTypeTree(true)]
[Uid("{53EBA73B-29A5-4609-9D37-A93E409DC09F}")]
[MetadataType(typeof(EntityMetadata))]
[ClassMap(typeof(ScriptModule_Map))]
public class ScriptModule : Entity<long>, IScriptModule
{
	public const string UID_S = "{53EBA73B-29A5-4609-9D37-A93E409DC09F}";

	private static ScriptModule rtwfW8bqVIMbpsPcyGL2;

	[GuidSettings(FieldName = "Uid")]
	[EntityProperty]
	[Uid("{6D42ADC9-AC19-4D8B-A9C1-69D8DDD7422F}")]
	[Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
	[SystemProperty]
	public virtual Guid Uid
	{
		[CompilerGenerated]
		get
		{
			return _003CUid_003Ek__BackingField;
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
					_003CUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EntityProperty]
	[GuidSettings(FieldName = "ModuleTypeUid")]
	[Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
	[Uid("{AAC72ECC-D993-4845-88DF-6E02D2DCC8D9}")]
	public virtual Guid ModuleTypeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CModuleTypeUid_003Ek__BackingField;
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
					_003CModuleTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
	[Uid("{0AF338B8-8286-4B22-AF43-E4CF7E38B7E7}")]
	[EntityProperty]
	[GuidSettings(FieldName = "ObjectUid")]
	public virtual Guid ObjectUid
	{
		[CompilerGenerated]
		get
		{
			return _003CObjectUid_003Ek__BackingField;
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
					_003CObjectUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EntityProperty]
	[StringSettings(FieldName = "ModuleName", MaxValueString = "255")]
	[Uid("{61AEFECA-816E-45AF-8D11-095C6C520401}")]
	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	public virtual string ModuleName
	{
		[CompilerGenerated]
		get
		{
			return _003CModuleName_003Ek__BackingField;
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
					_003CModuleName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[StringSettings(FieldName = "SourceCode", MaxValueString = "2147483647", MultiLine = true)]
	[EntityProperty]
	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	[Uid("{23F03DE5-F469-482F-9F97-BCB6B22350F7}")]
	public virtual string SourceCode
	{
		[CompilerGenerated]
		get
		{
			return _003CSourceCode_003Ek__BackingField;
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
					_003CSourceCode_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
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

	[EntityProperty]
	[RootCodeItemTypeSettings(FieldName = "CodeItems")]
	[Uid("D2725740-4F4E-46A8-9A23-518654C6DC9F")]
	[Property("B996B108-7A4D-4240-B96B-C6C1D99636D7")]
	public virtual RootCodeItemCollection CodeItems
	{
		[CompilerGenerated]
		get
		{
			return _003CCodeItems_003Ek__BackingField;
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
					_003CCodeItems_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
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

	[Uid("{D56978B8-F71B-4668-A50A-3CD109BFB6DC}")]
	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	[EntityProperty]
	[StringSettings(FieldName = "ScriptMetodsList", MaxValueString = "2147483647", MultiLine = true)]
	public virtual string ScriptMetodsList
	{
		[CompilerGenerated]
		get
		{
			return _003CScriptMetodsList_003Ek__BackingField;
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
					_003CScriptMetodsList_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
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

	[EntityProperty]
	[Uid("{CDEFC7DA-CA36-4E0A-B4F9-77401141ADEA}")]
	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	[StringSettings(FieldName = "CompiledFileName", MaxValueString = "2147483647")]
	public virtual string CompiledFileName
	{
		[CompilerGenerated]
		get
		{
			return _003CCompiledFileName_003Ek__BackingField;
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
					_003CCompiledFileName_003Ek__BackingField = value;
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

	[StringSettings(FieldName = "References", MaxValueString = "2147483647", MultiLine = true)]
	[EntityProperty]
	[Uid("{DAACFC5C-6F74-4630-A59F-FD10B550D9B0}")]
	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	public virtual string References
	{
		[CompilerGenerated]
		get
		{
			return _003CReferences_003Ek__BackingField;
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
					_003CReferences_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
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

	[StringSettings(FieldName = "ElmaReferences", MaxValueString = "2147483647", MultiLine = true)]
	[EntityProperty]
	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	[Uid("{B1A03C14-F8CF-4A9C-A5EF-ED6A5C7BE8FD}")]
	public virtual string ElmaReferences
	{
		[CompilerGenerated]
		get
		{
			return _003CElmaReferences_003Ek__BackingField;
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
					_003CElmaReferences_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
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

	[Uid("{CF5EAC0A-0948-4C3B-ADD9-564EFAA6442B}")]
	[Property("{F14334F8-4964-4A0E-9846-D7687933F0A4}")]
	[EntityProperty]
	[ScriptWebReferencesTypeSettings(FieldName = "WebReferences")]
	public virtual List<ScriptWebReference> WebReferences { get; set; }

	[EntityProperty]
	[AssemblyReferenceTypeSettings(FieldName = "LocalReferences")]
	[Property("{6D4B839B-DADA-4BA9-B163-33A771E84039}")]
	[Uid("{45B49B1D-DB7A-404A-A644-3C5ED2369C8A}")]
	public virtual List<AssemblyReference> LocalReferences { get; set; }

	[AssemblyReferenceTypeSettings(FieldName = "GlobalScriptModules")]
	[EntityProperty]
	[Uid("{56FF3F44-4C36-4337-9B04-DDA9E8E39427}")]
	[Property("{6D4B839B-DADA-4BA9-B163-33A771E84039}")]
	public virtual List<AssemblyReference> GlobalScriptModules { get; set; }

	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	[EntityProperty]
	[Uid("{EA44042E-6283-4FBF-B3A0-6F9E83B99188}")]
	[StringSettings(FieldName = "AssemblyName")]
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
				case 1:
					_003CAssemblyName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
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

	[EntityProperty]
	[Uid("{960864C3-2E38-489F-9D07-3F05D129B6E5}")]
	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	[StringSettings(FieldName = "Namespace")]
	public virtual string Namespace
	{
		[CompilerGenerated]
		get
		{
			return _003CNamespace_003Ek__BackingField;
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
					_003CNamespace_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
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

	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	[EntityProperty]
	[Uid("{B61E66C6-FBDE-4245-9A8E-034A817B37FB}")]
	[StringSettings(FieldName = "ClassName")]
	public virtual string ClassName
	{
		[CompilerGenerated]
		get
		{
			return _003CClassName_003Ek__BackingField;
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
					_003CClassName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
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

	[Property("{D6E0683F-B70F-4D65-B3FF-E1987CBD40A5}")]
	[StringSettings(FieldName = "ScriptMethods")]
	[Uid("{B54AEEEA-A2C5-435B-B09F-4253FE9E8085}")]
	[EntityProperty]
	public virtual List<ScriptMethodDeclaration> ScriptMethods { get; set; }

	[EntityProperty]
	[BlobSettings(FieldName = "AssemblyRaw")]
	[Uid("{02015E6F-DB15-441B-9275-BB94055AA78B}")]
	[Property("{1911B22D-0CE2-4743-832F-6A44CB0357FE}")]
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
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

	[BlobSettings(FieldName = "DebugRaw")]
	[Property("{1911B22D-0CE2-4743-832F-6A44CB0357FE}")]
	[EntityProperty]
	[Uid("{667A5D08-319F-4F03-8ABD-0419150D6224}")]
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
				case 0:
					return;
				case 1:
					_003CDebugRaw_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EntityProperty]
	[EntitySettings(FieldName = "Draft")]
	[Property("{72ED98CA-F260-4671-9BCD-FF1D80235F47}", "{53EBA73B-29A5-4609-9D37-A93E409DC09F}")]
	[Uid("{947D25F6-1D98-43DD-A304-244107426396}")]
	public virtual ScriptModule Draft
	{
		[CompilerGenerated]
		get
		{
			return _003CDraft_003Ek__BackingField;
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
					_003CDraft_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
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

	[EntityProperty]
	[Uid("{39DCFC2A-6BD5-4BF9-A366-9228112451B6}")]
	[XmlSerializableObjectSettings(FieldName = "Dependencies")]
	[Property("{66C7898B-E56B-49E0-BFB8-9F9C4A7A0C52}")]
	public virtual object Dependencies
	{
		[CompilerGenerated]
		get
		{
			return _003CDependencies_003Ek__BackingField;
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
					_003CDependencies_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
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

	public virtual string FullClassName => (string)OPsT8GbqXJksPvDCGQEf(UewFrqbqqVsRukbv9Bux(this), FMVRKEbqKCyOj2HlPbPF(-2107978722 ^ -2107975974), ClassName);

	public ScriptModule()
	{
		//Discarded unreachable code: IL_002a
		MjyqFLbqRdQRoNgGKNH7();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				WebReferences = new List<ScriptWebReference>();
				num = 3;
				break;
			case 2:
				return;
			case 5:
				GlobalScriptModules = new List<AssemblyReference>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num = 0;
				}
				break;
			default:
			{
				ScriptMethods = new List<ScriptMethodDeclaration>();
				int num2 = 2;
				num = num2;
				break;
			}
			case 4:
				LocalReferences = new List<AssemblyReference>();
				num = 5;
				break;
			case 3:
				CodeItems = new RootCodeItemCollection();
				num = 4;
				break;
			}
		}
	}

	internal static void MjyqFLbqRdQRoNgGKNH7()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool rjSpgXbqSFDNuus3EluD()
	{
		return rtwfW8bqVIMbpsPcyGL2 == null;
	}

	internal static ScriptModule O2e5JdbqiaGv9O64UNS9()
	{
		return rtwfW8bqVIMbpsPcyGL2;
	}

	internal static object UewFrqbqqVsRukbv9Bux(object P_0)
	{
		return ((ScriptModule)P_0).Namespace;
	}

	internal static object FMVRKEbqKCyOj2HlPbPF(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object OPsT8GbqXJksPvDCGQEf(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}
}
