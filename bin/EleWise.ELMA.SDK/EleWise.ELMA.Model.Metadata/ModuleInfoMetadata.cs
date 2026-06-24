using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Attributes;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Modules.Attributes;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata;

[Serializable]
[XmlExport]
[DataContract]
[XmlRoot("ModuleInfo")]
public class ModuleInfoMetadata : NamedMetadata, IRootMetadata, IMetadata, IXsiType
{
	[Component]
	private class Info : IMetadataTypeInfo
	{
		private static object dTAlXICtY43OiX1VIv30;

		public string Name => SR.T((string)BpgNEFCtsJhM4jTG8AMQ(0x103FE975 ^ 0x103A44D3));

		public string Description => string.Empty;

		public Type MetadataType => oEqMlaCtcm0gfLKMQE1D(typeof(ModuleInfoMetadata).TypeHandle);

		public Type GeneratorType => typeof(ModuleInfoGenerator);

		public Info()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			NELpr4CtziirfVjoxr71();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object BpgNEFCtsJhM4jTG8AMQ(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static bool HqDJxwCtLlJTYFVXuhIW()
		{
			return dTAlXICtY43OiX1VIv30 == null;
		}

		internal static Info eUCXvtCtUpqYmbwcXXBL()
		{
			return (Info)dTAlXICtY43OiX1VIv30;
		}

		internal static Type oEqMlaCtcm0gfLKMQE1D(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static void NELpr4CtziirfVjoxr71()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private static ModuleInfoMetadata Gqolpeb4vV9M7jKS7f0s;

	[DefaultValue(ModuleType.Default)]
	public ModuleType ModuleType
	{
		[CompilerGenerated]
		get
		{
			return _003CModuleType_003Ek__BackingField;
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
					_003CModuleType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
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

	public string WebSite
	{
		[CompilerGenerated]
		get
		{
			return _003CWebSite_003Ek__BackingField;
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
					_003CWebSite_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string HtmlDescription
	{
		[CompilerGenerated]
		get
		{
			return _003CHtmlDescription_003Ek__BackingField;
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
					_003CHtmlDescription_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(false)]
	public bool ServerModuleRequired
	{
		[CompilerGenerated]
		get
		{
			return _003CServerModuleRequired_003Ek__BackingField;
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
					_003CServerModuleRequired_003Ek__BackingField = value;
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

	[DefaultValue(ModuleStatus.Unknown)]
	public ModuleStatus DefaultStatus
	{
		[CompilerGenerated]
		get
		{
			return _003CDefaultStatus_003Ek__BackingField;
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
					_003CDefaultStatus_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(null)]
	public ModuleDependency Dependency
	{
		[CompilerGenerated]
		get
		{
			return _003CDependency_003Ek__BackingField;
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
					_003CDependency_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
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

	[XmlArray("DependencyModules")]
	[XmlArrayItem("Module")]
	public List<LinkToModule> DependencyModules { get; set; }

	public List<ComponentMetadata> Components { get; set; }

	public List<DataClassMetadata> DataClasses { get; set; }

	public List<FunctionMetadata> Functions { get; set; }

	[Obsolete("Данный API может быть изменен или удален в любой момент", false)]
	[XmlForceElement]
	public List<ProjectItem> ProjectItems { get; set; }

	public ModuleInfoMetadata()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		bBxN39b4uBaRv5ZR04Wo();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				ModuleType = ModuleType.Default;
				num = 7;
				break;
			case 6:
				DataClasses = new List<DataClassMetadata>();
				num = 5;
				break;
			case 2:
				DependencyModules = new List<LinkToModule>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num = 1;
				}
				break;
			case 5:
				Functions = new List<FunctionMetadata>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num = 0;
				}
				break;
			default:
				ProjectItems = new List<ProjectItem>();
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
				{
					num = 4;
				}
				break;
			case 1:
				Components = new List<ComponentMetadata>();
				num = 6;
				break;
			case 7:
				DefaultStatus = ModuleStatus.Unknown;
				num = 2;
				break;
			case 4:
				return;
			}
		}
	}

	public override void InitNew()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				base.InitNew();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				dvddvNb4VO3hbCmUJ0mn(this, DWdTX2b4Inh9vFkKE2Rw(this));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal IEnumerable<IMetadata> GetMetadataToRegister()
	{
		List<IMetadata> list = new List<IMetadata>();
		list.AddRange(DataClasses);
		list.AddRange(Functions);
		foreach (ComponentMetadata component in Components)
		{
			list.Add(component);
			list.AddRange(component.GetMetadataToRegister());
		}
		return list;
	}

	public void LoadFromType(Type type, bool inherit = true)
	{
		//Discarded unreachable code: IL_0094, IL_00a3
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (!R3yQJxb4S4JquH3hLUEB(type, null))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 1:
				return;
			default:
				throw new ArgumentNullException((string)HGSDA3b4ie9Q8AoHgHwF(0x269E5FCA ^ 0x269E53E8));
			case 2:
				LoadFromAssembly(type.Assembly);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public void LoadFromAssembly(Assembly asm)
	{
		int num = 13;
		ModuleAttribute attribute6 = default(ModuleAttribute);
		ModuleTitleAttribute attribute2 = default(ModuleTitleAttribute);
		ServerModuleRequiredAttribute attribute5 = default(ServerModuleRequiredAttribute);
		ModuleWebSiteAttribute attribute4 = default(ModuleWebSiteAttribute);
		ModuleTypeAttribute attribute3 = default(ModuleTypeAttribute);
		ModuleDefaultStatusAttribute attribute7 = default(ModuleDefaultStatusAttribute);
		ModuleHtmlDescriptionAttribute attribute = default(ModuleHtmlDescriptionAttribute);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 13:
					attribute6 = AttributeHelper<ModuleAttribute>.GetAttribute(asm);
					num2 = 12;
					break;
				case 5:
					attribute2 = AttributeHelper<ModuleTitleAttribute>.GetAttribute(asm);
					num2 = 16;
					break;
				case 6:
					dvddvNb4VO3hbCmUJ0mn(this, DWdTX2b4Inh9vFkKE2Rw(this));
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 5;
					}
					break;
				case 1:
					Name = (string)ensUvib4TE5kApdB8HqU(attribute6);
					num2 = 6;
					break;
				case 17:
					attribute5 = AttributeHelper<ServerModuleRequiredAttribute>.GetAttribute(asm);
					num2 = 11;
					break;
				default:
					attribute4 = AttributeHelper<ModuleWebSiteAttribute>.GetAttribute(asm);
					num2 = 7;
					break;
				case 12:
					if (attribute6 != null)
					{
						WfQHE9b4XUfxcRNQCikh(this, XgQmngb4KvoVx9QKq7C7(attribute6));
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto end_IL_0012;
				case 8:
					attribute3 = AttributeHelper<ModuleTypeAttribute>.GetAttribute(asm);
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
					{
						num2 = 12;
					}
					break;
				case 11:
					ServerModuleRequired = attribute5 != null;
					num2 = 4;
					break;
				case 2:
					attribute7 = AttributeHelper<ModuleDefaultStatusAttribute>.GetAttribute(asm);
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 10;
					}
					break;
				case 4:
					return;
				case 3:
					attribute = AttributeHelper<ModuleHtmlDescriptionAttribute>.GetAttribute(asm);
					num2 = 14;
					break;
				case 9:
					throw new InvalidOperationException((string)NVPERSb4qnIt0M6WjgVA(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -138086989), HQBSdrb4RX3w3KOfdL0L(asm), HGSDA3b4ie9Q8AoHgHwF(0x68BBB53E ^ 0x68B9415C)));
				case 16:
					a7q8DGb4nwrRihH5eZOJ(this, (attribute2 != null) ? vjHOOgb4ktu0X72dRh8M(attribute2) : string.Empty);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 1;
					}
					break;
				case 10:
					DefaultStatus = attribute7?.Status ?? ModuleStatus.Enabled;
					num2 = 8;
					break;
				case 15:
					ModuleType = ((attribute3 != null) ? rq5bo4b4O1rWmQ1Xsek9(attribute3) : ModuleType.Default);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 0;
					}
					break;
				case 7:
					WebSite = (string)((attribute4 != null) ? CuHoP6b42uVPGaGC7h3Z(attribute4) : "");
					num2 = 3;
					break;
				case 14:
					HtmlDescription = (string)((attribute != null) ? kda7wHb4eR8NPqkxydT0(attribute) : "");
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 9;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 9;
		}
	}

	public virtual bool IsRestartNeeded(IRootMetadata metadata)
	{
		return true;
	}

	public virtual void ApplyRestartUnrequiredChanges(bool inherit)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeDependencyModules()
	{
		return EZxJUBb4PqL8nnMMhLna(DependencyModules) > 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeComponents()
	{
		return c6cXiLb41Vk5HZIywHxO(Components) != 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeDataClasses()
	{
		return msstVWb4NjCg6p0UkWsd(DataClasses) != 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeFunctions()
	{
		return YPYXSxb43ckulE8UmkJn(Functions) != 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeProjectItems()
	{
		return dfDVs6b4pa50e82vAtUY(ProjectItems) != 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeDescription()
	{
		return !dF0eX1b4Dlx2HhkTAHe1(EXILVRb4a1LZiASkSAfy(this));
	}

	internal ModuleInfoMetadata ShallowCopy()
	{
		return (ModuleInfoMetadata)yw51b3b4tZ0ihgXnPMyZ(this);
	}

	internal static void bBxN39b4uBaRv5ZR04Wo()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool zyyWN1b48me3eZ0UH9eo()
	{
		return Gqolpeb4vV9M7jKS7f0s == null;
	}

	internal static ModuleInfoMetadata b0dh0Tb4ZYhtXbaK0VRI()
	{
		return Gqolpeb4vV9M7jKS7f0s;
	}

	internal static Guid DWdTX2b4Inh9vFkKE2Rw(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static void dvddvNb4VO3hbCmUJ0mn(object P_0, Guid value)
	{
		((AbstractMetadata)P_0).ModuleUid = value;
	}

	internal static bool R3yQJxb4S4JquH3hLUEB(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object HGSDA3b4ie9Q8AoHgHwF(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object HQBSdrb4RX3w3KOfdL0L(object P_0)
	{
		return ComponentManager.GetAssemblyShortName((Assembly)P_0);
	}

	internal static object NVPERSb4qnIt0M6WjgVA(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static Guid XgQmngb4KvoVx9QKq7C7(object P_0)
	{
		return ((ModuleAttribute)P_0).Uid;
	}

	internal static void WfQHE9b4XUfxcRNQCikh(object P_0, Guid value)
	{
		((AbstractMetadata)P_0).Uid = value;
	}

	internal static object ensUvib4TE5kApdB8HqU(object P_0)
	{
		return ((ModuleAttribute)P_0).Id;
	}

	internal static object vjHOOgb4ktu0X72dRh8M(object P_0)
	{
		return ((ModuleTitleAttribute)P_0).Title;
	}

	internal static void a7q8DGb4nwrRihH5eZOJ(object P_0, object P_1)
	{
		((NamedMetadata)P_0).DisplayName = (string)P_1;
	}

	internal static ModuleType rq5bo4b4O1rWmQ1Xsek9(object P_0)
	{
		return ((ModuleTypeAttribute)P_0).ModuleType;
	}

	internal static object CuHoP6b42uVPGaGC7h3Z(object P_0)
	{
		return ((ModuleWebSiteAttribute)P_0).WebSite;
	}

	internal static object kda7wHb4eR8NPqkxydT0(object P_0)
	{
		return ((ModuleHtmlDescriptionAttribute)P_0).Description;
	}

	internal static int EZxJUBb4PqL8nnMMhLna(object P_0)
	{
		return ((List<LinkToModule>)P_0).Count;
	}

	internal static int c6cXiLb41Vk5HZIywHxO(object P_0)
	{
		return ((List<ComponentMetadata>)P_0).Count;
	}

	internal static int msstVWb4NjCg6p0UkWsd(object P_0)
	{
		return ((List<DataClassMetadata>)P_0).Count;
	}

	internal static int YPYXSxb43ckulE8UmkJn(object P_0)
	{
		return ((List<FunctionMetadata>)P_0).Count;
	}

	internal static int dfDVs6b4pa50e82vAtUY(object P_0)
	{
		return ((List<ProjectItem>)P_0).Count;
	}

	internal static object EXILVRb4a1LZiASkSAfy(object P_0)
	{
		return ((NamedMetadata)P_0).Description;
	}

	internal static bool dF0eX1b4Dlx2HhkTAHe1(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object yw51b3b4tZ0ihgXnPMyZ(object P_0)
	{
		return P_0.MemberwiseClone();
	}
}
