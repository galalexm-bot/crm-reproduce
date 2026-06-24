using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Modules.Attributes;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.CodeGeneration;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Metadata;

[Serializable]
[DataContract]
[XmlRoot("Component")]
[Uid("{66457AD6-CE6E-4CD5-AE3A-D46DC83A0E85}")]
public class ComponentMetadata : NamedMetadata, ICodeItemMetadata, IMetadata, IXsiType, IRootMetadata
{
	[Component]
	private sealed class Info : IMetadataTypeInfo
	{
		private static object VDTXkcQoeesawHbLj5rq;

		public string Name => SR.T((string)DPrT0AQoN4xqYRX5bN9u(0x1637C429 ^ 0x1632AF17));

		public string Description => SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217693075));

		public Type MetadataType => typeof(ComponentMetadata);

		public Type GeneratorType => tIuYDVQo3xe1Hlxnbb9m(typeof(ComponentMetadataGenerator).TypeHandle);

		public Info()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			ExfoeyQopsApneqVZqnb();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object DPrT0AQoN4xqYRX5bN9u(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static bool zUJ2RkQoPDJi7HwnNwCI()
		{
			return VDTXkcQoeesawHbLj5rq == null;
		}

		internal static Info AaNkF2Qo1eDYFqMXVals()
		{
			return (Info)VDTXkcQoeesawHbLj5rq;
		}

		internal static Type tIuYDVQo3xe1Hlxnbb9m(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static void ExfoeyQopsApneqVZqnb()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	public static readonly Guid TypeUid;

	internal const string DefaultNamespace = "EleWise.ELMA.UI.Components";

	internal static ComponentMetadata X6D1IdBGO0dXEdL4ndlD;

	[DefaultValue("")]
	public string Namespace
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
				case 0:
					return;
				case 1:
					_003CNamespace_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue("")]
	public string NamespaceForDisplay
	{
		[CompilerGenerated]
		get
		{
			return _003CNamespaceForDisplay_003Ek__BackingField;
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
					_003CNamespaceForDisplay_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
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

	public string FullTypeName => (string)jbnbiLBG3yPD4mipsTxK(Namespace, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088302820), xyubDJBGN0PjHVvjrg1q(this));

	public ComponentContentMetadata Content
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
				case 1:
					_003CContent_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
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

	public List<DataClassMetadata> DataClasses { get; set; }

	public List<Implementation> Implementations { get; set; }

	public List<ImplementationForm> ImplementationForms { get; set; }

	public List<UserDefinedListInfo> UserDefinedListInfos { get; set; }

	public CustomTypeImplementationModel CustomTypeImplementation
	{
		[CompilerGenerated]
		get
		{
			return _003CCustomTypeImplementation_003Ek__BackingField;
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
					_003CCustomTypeImplementation_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
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

	public Guid? ScriptUid { get; set; }

	public Guid? ClientScriptUid { get; set; }

	public Guid? ViewScriptUid { get; set; }

	public Guid? TestScriptUid { get; set; }

	public List<FunctionDependency> FunctionDependencies { get; set; }

	public List<DataClassDependency> DataClassDependencies { get; set; }

	public List<ComponentDependency> ComponentDependencies { get; set; }

	public List<EntityDependency> EntityDependencies { get; set; }

	public List<EnumDependency> EnumDependencies { get; set; }

	public ComponentMetadata(Guid moduleUid)
	{
		//Discarded unreachable code: IL_002a
		SingletonReader.JJCZtPuTvSt();
		this._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				EdYQnoBG1BYqgUwj7YMi(this, f0OgCJBGPSNdgTDNA63D(moduleUid, Guid.Empty));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 1:
			{
				ModuleUid = moduleUid;
				int num2 = 2;
				num = num2;
				break;
			}
			}
		}
	}

	public ComponentMetadata()
	{
		//Discarded unreachable code: IL_001a, IL_001f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 2:
				FunctionDependencies = new List<FunctionDependency>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num = 8;
				}
				break;
			case 1:
				EntityDependencies = new List<EntityDependency>();
				num = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num = 0;
				}
				break;
			case 3:
				ImplementationForms = new List<ImplementationForm>();
				num = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
				{
					num = 0;
				}
				break;
			default:
				ComponentDependencies = new List<ComponentDependency>();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num = 1;
				}
				break;
			case 4:
				DataClasses = new List<DataClassMetadata>();
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num = 2;
				}
				break;
			case 7:
				return;
			case 8:
				DataClassDependencies = new List<DataClassDependency>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num = 0;
				}
				break;
			case 6:
				UserDefinedListInfos = new List<UserDefinedListInfo>();
				num = 7;
				break;
			case 5:
				Implementations = new List<Implementation>();
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
				{
					num = 2;
				}
				break;
			case 9:
				EnumDependencies = new List<EnumDependency>();
				num = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num = 2;
				}
				break;
			}
		}
	}

	public virtual Guid GetMetadataTypeUid()
	{
		return TypeUid;
	}

	public override void InitNew()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				if (Content != null)
				{
					num2 = 7;
					break;
				}
				Content = new ComponentContentMetadata
				{
					ModuleUid = NwljwrBGaZJZ7ZsnLed7(this)
				};
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				base.InitNew();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				Namespace = (string)atgksABGpw8NMYIwO1Cj(-629844702 ^ -629819076);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				LhZg7YBGD7fhV7JiDZkP(Content);
				num2 = 6;
				break;
			case 7:
				return;
			case 6:
				trXEiCBGwkC6y61jdpp2(C6dSJRBGtwa5VHKBfLlC(Content), atgksABGpw8NMYIwO1Cj(0x3A6135BE ^ 0x3A6171BA));
				num2 = 5;
				break;
			case 5:
				IBWOlaBG6wU5bg8L2AmS(C6dSJRBGtwa5VHKBfLlC(Content), lcyqRcBG45Ut74e0BFv0(atgksABGpw8NMYIwO1Cj(-1998538950 ^ -1998562452)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void GenerateNewUids()
	{
		int num = 1;
		int num2 = num;
		Guid oldMetadataUid = default(Guid);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 2:
				lB20vuBGAi2nB30lWQpo(Content);
				num2 = 4;
				break;
			default:
				LhZg7YBGD7fhV7JiDZkP(this);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				oldMetadataUid = oE3qSrBGHdyArjSSoPGf(this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				oBEmE6BG7uZJfS566oK6(this, oldMetadataUid);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	public void LoadFromType(Type type, bool inherit = true)
	{
		//Discarded unreachable code: IL_0079, IL_0088, IL_0112, IL_0121, IL_015e, IL_016d, IL_028d, IL_029c
		int num = 16;
		Guid versionUid = default(Guid);
		_003C_003Ec__DisplayClass79_0 _003C_003Ec__DisplayClass79_ = default(_003C_003Ec__DisplayClass79_0);
		int num3 = default(int);
		PropertyInfo propertyInfo = default(PropertyInfo);
		ComponentMetadata componentMetadata = default(ComponentMetadata);
		PropertyInfo[] properties = default(PropertyInfo[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					versionUid = dUU07kBGx8l2YfcZD3gj(AttributeHelper<MetadataItemUidAttribute>.GetAttribute(_003C_003Ec__DisplayClass79_.type.Assembly));
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 6;
					}
					continue;
				case 9:
				case 19:
					num3++;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 1;
					}
					continue;
				case 16:
					_003C_003Ec__DisplayClass79_ = new _003C_003Ec__DisplayClass79_0();
					num2 = 15;
					continue;
				case 18:
					if (((Array)HfmqBGBGdUy4XXwspKXF(propertyInfo)).Length == 0)
					{
						num2 = 5;
						continue;
					}
					goto case 9;
				case 5:
					uqQ3kMBGr33Yo6I3X4Ge(propertyInfo, this, cu4o8DBGlTrfyEdubAs1(propertyInfo, componentMetadata, null), null);
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 4;
					}
					continue;
				default:
					num3 = 0;
					num2 = 7;
					continue;
				case 17:
					propertyInfo = properties[num3];
					num2 = 2;
					continue;
				case 2:
					if (!propertyInfo.CanRead)
					{
						num2 = 9;
						continue;
					}
					goto case 13;
				case 8:
					if (!PpnG6FBGmnKecAcdT2KY(mgwGORBG0vRW0TgD4jSp(_003C_003Ec__DisplayClass79_.type.Assembly), atgksABGpw8NMYIwO1Cj(-1334993905 ^ -1335004993)))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
						{
							num2 = 14;
						}
						continue;
					}
					break;
				case 4:
				case 14:
					componentMetadata = (ComponentMetadata)opW5RnBGJ0CoymDwghmn(((AbstractNHEntityManager<ComponentMetadataItem, long>)uUbc5LBGMviRiQBHt0T8()).Load(versionUid));
					num2 = 3;
					continue;
				case 12:
					return;
				case 20:
					properties = gbOrfrBG9fsr9wgUYe7X(this).GetProperties();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
				case 21:
					if (componentMetadata == null)
					{
						return;
					}
					goto end_IL_0012;
				case 11:
					return;
				case 15:
					_003C_003Ec__DisplayClass79_.type = type;
					num2 = 6;
					continue;
				case 13:
					if (propertyInfo.CanWrite)
					{
						num2 = 18;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 9;
				case 1:
				case 7:
					if (num3 >= properties.Length)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto case 17;
				case 10:
					break;
				}
				IModuleMetadataLoader serviceNotNull = Locator.GetServiceNotNull<IModuleMetadataLoader>();
				Guid moduleUid = AttributeHelper<AssemblyModuleAttribute>.GetAttribute(_003C_003Ec__DisplayClass79_.type.Assembly).Uid;
				componentMetadata = ((ModuleInfoMetadata)y3EWWuBGyR4AMQFW9owH(serviceNotNull.GetSpecificModuleVersion(moduleUid, versionUid))).Components.Find(_003C_003Ec__DisplayClass79_._003CLoadFromType_003Eb__0);
				num2 = 21;
				continue;
				end_IL_0012:
				break;
			}
			num = 20;
		}
	}

	public bool IsRestartNeeded(IRootMetadata metadata)
	{
		return false;
	}

	public void ApplyRestartUnrequiredChanges(bool inherit)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeDataClasses()
	{
		return DULU2lBGgjhKoiZHnNJD(DataClasses) != 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeImplementations()
	{
		return CTrFOhBG5Yp5E3qen25I(Implementations) != 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeImplementationForms()
	{
		return ImplementationForms.Count != 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeDataClassDependencies()
	{
		return iHYegvBGj34hDeBj6qBC(DataClassDependencies) != 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeFunctionDependencies()
	{
		return FunctionDependencies.Count != 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeComponentDependencies()
	{
		return hlXJmLBGYcqPquqFqENE(ComponentDependencies) != 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeEntityDependencies()
	{
		return nb0cO9BGLoWxWR9e0lEl(EntityDependencies) != 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeEnumDependencies()
	{
		return yfPKIxBGUtfIZB8XR8rV(EnumDependencies) != 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeUserDefinedListInfos()
	{
		return SBOnSMBGsXEfjAcNmlnV(UserDefinedListInfos) != 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeScriptUid()
	{
		int num = 1;
		int num2 = num;
		Guid? scriptUid = default(Guid?);
		while (true)
		{
			switch (num2)
			{
			case 1:
				scriptUid = ScriptUid;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return scriptUid.HasValue;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeClientScriptUid()
	{
		int num = 1;
		int num2 = num;
		Guid? clientScriptUid = default(Guid?);
		while (true)
		{
			switch (num2)
			{
			default:
				return clientScriptUid.HasValue;
			case 1:
				clientScriptUid = ClientScriptUid;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeViewScriptUid()
	{
		int num = 1;
		int num2 = num;
		Guid? viewScriptUid = default(Guid?);
		while (true)
		{
			switch (num2)
			{
			default:
				return viewScriptUid.HasValue;
			case 1:
				viewScriptUid = ViewScriptUid;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTestScriptUid()
	{
		int num = 1;
		int num2 = num;
		Guid? testScriptUid = default(Guid?);
		while (true)
		{
			switch (num2)
			{
			case 1:
				testScriptUid = TestScriptUid;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return testScriptUid.HasValue;
			}
		}
	}

	internal IEnumerable<IMetadata> GetMetadataToRegister()
	{
		List<IMetadata> list = new List<IMetadata>(DataClasses.Count + 1);
		if (Content?.Context != null)
		{
			list.Add(Content.Context);
		}
		if (DataClasses != null)
		{
			list.AddRange(DataClasses);
		}
		return list;
	}

	static ComponentMetadata()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				TypeUid = new Guid((string)atgksABGpw8NMYIwO1Cj(-1978478350 ^ -1978516438));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				M4o95aBGcPlsgDIqiSan();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool f0OgCJBGPSNdgTDNA63D(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static void EdYQnoBG1BYqgUwj7YMi(object P_0, bool value)
	{
		((AbstractMetadata)P_0).Internal = value;
	}

	internal static bool i801gYBG2blSf5u12lGC()
	{
		return X6D1IdBGO0dXEdL4ndlD == null;
	}

	internal static ComponentMetadata nbyvbMBGecBFxdb8tM5I()
	{
		return X6D1IdBGO0dXEdL4ndlD;
	}

	internal static object xyubDJBGN0PjHVvjrg1q(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object jbnbiLBG3yPD4mipsTxK(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object atgksABGpw8NMYIwO1Cj(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Guid NwljwrBGaZJZ7ZsnLed7(object P_0)
	{
		return ((AbstractMetadata)P_0).ModuleUid;
	}

	internal static void LhZg7YBGD7fhV7JiDZkP(object P_0)
	{
		((AbstractMetadata)P_0).InitNew();
	}

	internal static object C6dSJRBGtwa5VHKBfLlC(object P_0)
	{
		return ((ComponentContentMetadata)P_0).Context;
	}

	internal static void trXEiCBGwkC6y61jdpp2(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Name = (string)P_1;
	}

	internal static object lcyqRcBG45Ut74e0BFv0(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void IBWOlaBG6wU5bg8L2AmS(object P_0, object P_1)
	{
		((NamedMetadata)P_0).DisplayName = (string)P_1;
	}

	internal static Guid oE3qSrBGHdyArjSSoPGf(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static void lB20vuBGAi2nB30lWQpo(object P_0)
	{
		((ComponentContentMetadata)P_0).GenerateNewUids();
	}

	internal static void oBEmE6BG7uZJfS566oK6(object P_0, Guid oldMetadataUid)
	{
		ComponentMetadataHelperInternal.ReplaceOldUids((ComponentMetadata)P_0, oldMetadataUid);
	}

	internal static Guid dUU07kBGx8l2YfcZD3gj(object P_0)
	{
		return ((MetadataItemUidAttribute)P_0).ItemUid;
	}

	internal static object mgwGORBG0vRW0TgD4jSp(object P_0)
	{
		return ((Assembly)P_0).FullName;
	}

	internal static bool PpnG6FBGmnKecAcdT2KY(object P_0, object P_1)
	{
		return ((string)P_0).StartsWith((string)P_1);
	}

	internal static object y3EWWuBGyR4AMQFW9owH(object P_0)
	{
		return ((ModuleVersion)P_0).Metadata;
	}

	internal static object uUbc5LBGMviRiQBHt0T8()
	{
		return ComponentMetadataItemManager.Instance;
	}

	internal static object opW5RnBGJ0CoymDwghmn(object P_0)
	{
		return ((ComponentMetadataItem)P_0).Metadata;
	}

	internal static Type gbOrfrBG9fsr9wgUYe7X(object P_0)
	{
		return P_0.GetType();
	}

	internal static object HfmqBGBGdUy4XXwspKXF(object P_0)
	{
		return ((PropertyInfo)P_0).GetIndexParameters();
	}

	internal static object cu4o8DBGlTrfyEdubAs1(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static void uqQ3kMBGr33Yo6I3X4Ge(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static int DULU2lBGgjhKoiZHnNJD(object P_0)
	{
		return ((List<DataClassMetadata>)P_0).Count;
	}

	internal static int CTrFOhBG5Yp5E3qen25I(object P_0)
	{
		return ((List<Implementation>)P_0).Count;
	}

	internal static int iHYegvBGj34hDeBj6qBC(object P_0)
	{
		return ((List<DataClassDependency>)P_0).Count;
	}

	internal static int hlXJmLBGYcqPquqFqENE(object P_0)
	{
		return ((List<ComponentDependency>)P_0).Count;
	}

	internal static int nb0cO9BGLoWxWR9e0lEl(object P_0)
	{
		return ((List<EntityDependency>)P_0).Count;
	}

	internal static int yfPKIxBGUtfIZB8XR8rV(object P_0)
	{
		return ((List<EnumDependency>)P_0).Count;
	}

	internal static int SBOnSMBGsXEfjAcNmlnV(object P_0)
	{
		return ((List<UserDefinedListInfo>)P_0).Count;
	}

	internal static void M4o95aBGcPlsgDIqiSan()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
