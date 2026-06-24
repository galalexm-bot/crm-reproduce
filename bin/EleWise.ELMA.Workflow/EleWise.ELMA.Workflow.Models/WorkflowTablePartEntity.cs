using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.CodeGeneration;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models;

[DefaultManager(typeof(WorkflowTablePartManagerMaker))]
public abstract class WorkflowTablePartEntity : WorkflowEntity, IWorkflowTablePartEntity
{
	private IWorkflowMetadataLoaderService workflowMetadataLoaderService;

	internal static WorkflowTablePartEntity F2XsHsOjVPE4oJAgsRm8;

	public IWorkflowMetadataLoaderService WorkflowMetadataLoaderService
	{
		get
		{
			int num = 1;
			int num2 = num;
			IWorkflowMetadataLoaderService obj;
			IWorkflowMetadataLoaderService workflowMetadataLoaderService = default(IWorkflowMetadataLoaderService);
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = this.workflowMetadataLoaderService;
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					workflowMetadataLoaderService = (this.workflowMetadataLoaderService = Locator.GetServiceNotNull<IWorkflowMetadataLoaderService>());
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					obj = workflowMetadataLoaderService;
					break;
				}
				break;
			}
			return obj;
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
					workflowMetadataLoaderService = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
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

	public WorkflowTablePartEntity(long id)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
		{
			num = 0;
		}
		Type mainEntityType = default(Type);
		while (true)
		{
			switch (num)
			{
			case 2:
				Initialize(id, mainEntityType);
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			default:
				mainEntityType = GetMainEntityType();
				num = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public WorkflowTablePartEntity(IEntity firstEntity)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		mZNg0DOj7NqhdxS4LgjP();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				Initialize(firstEntity);
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	protected override ICompositeEntityManager CreateCompositeManager()
	{
		return (ICompositeEntityManager)Locator.GetServiceNotNull(Re6D7aOj2NcDsOUUhgw1(typeof(WorkflowTablePartManager<>).TypeHandle).MakeGenericType(GetType()));
	}

	protected TParent CastToParentItem<TParent>(object parentEntity) where TParent : WorkflowEntity
	{
		IEntity entity = parentEntity as IEntity;
		IEntityManager<TParent> serviceNotNull = Locator.GetServiceNotNull<IEntityManager<TParent>>();
		if (entity == null)
		{
			return null;
		}
		return serviceNotNull.Load((long)entity.GetId());
	}

	protected object CastFromParentItem<TParent>(TParent parent) where TParent : WorkflowEntity
	{
		return parent?.LoadEntity(0);
	}

	private Type GetMainEntityType()
	{
		return ContextVars.GetOrAdd((string)UaMUEyOjFegeKe83BZjR(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1145BED7 ^ 0x1147B4AF), eNphTPOjowh6Mxwx8pcc(this).AssemblyQualifiedName), GetMainEntityTypeNonCached);
	}

	private Type GetMainEntityTypeNonCached()
	{
		//Discarded unreachable code: IL_01ef
		int num = 6;
		int num2 = num;
		ProcessHeaderIdAttribute attribute = default(ProcessHeaderIdAttribute);
		TablePartInfoAttribute attribute2 = default(TablePartInfoAttribute);
		IProcessHeader processHeader = default(IProcessHeader);
		TablePartMetadata tablePartMetadata = default(TablePartMetadata);
		EntityMetadata entityMetadata = default(EntityMetadata);
		Type type2 = default(Type);
		string text = default(string);
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 4:
				throw new ObjectNotFoundException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-63028171 ^ -63044909), attribute.Id);
			case 8:
				throw new MetadataException((string)UaMUEyOjFegeKe83BZjR(aXojwTOjiD11JpNslfoj(0x17F0C5A2 ^ 0x17F2CE8A), eNphTPOjowh6Mxwx8pcc(this).FullName));
			case 6:
				attribute = AttributeHelper<ProcessHeaderIdAttribute>.GetAttribute(eNphTPOjowh6Mxwx8pcc(this), inherited: false);
				num2 = 5;
				break;
			case 1:
				if (attribute2 != null)
				{
					processHeader = Locator.GetService<ProcessHeaderManager>().Load(FOAfwuOjIWntlYXGdyfH(attribute));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e != 0)
					{
						num2 = 8;
					}
				}
				break;
			case 12:
				tablePartMetadata = FindTablePartByPropUid(entityMetadata, ibaNFXOjeyqR76S74f1I(attribute2));
				num2 = 9;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e == 0)
				{
					num2 = 2;
				}
				break;
			case 9:
			{
				if (tablePartMetadata == null)
				{
					num2 = 10;
					break;
				}
				Assembly assembly = type2.Assembly;
				text = (string)hOHEvkOjhv3v4cmGNTLp(B2a27fOjSLFo7jwhROXX(entityMetadata), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1600060848 ^ -1600042326), PkXvRLOj1LelZZPwWUxG(tablePartMetadata));
				type = assembly.GetType(text);
				num2 = 13;
				break;
			}
			case 7:
				entityMetadata = (EntityMetadata)TWQaR5OjrObP8XkueYY0(type2, true, true);
				num2 = 12;
				break;
			case 10:
				throw new MetadataException((string)YsVUYFOjxLgTOgFdH9k7(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x361628FF ^ 0x3614237D), attribute2.TablePartPropertyUid, IiTiwhOjN87cUXQ3AQZC(processHeader)));
			default:
				if (processHeader != null)
				{
					type2 = hvGqyZOjauN6awjX9NAA(WorkflowMetadataLoaderService, processHeader.Id, true);
					num2 = 7;
				}
				else
				{
					num2 = 4;
				}
				break;
			case 2:
				throw new MetadataException((string)UaMUEyOjFegeKe83BZjR(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-682910880 ^ -683044438), eNphTPOjowh6Mxwx8pcc(this).FullName));
			case 5:
				if (attribute != null)
				{
					attribute2 = AttributeHelper<TablePartInfoAttribute>.GetAttribute(eNphTPOjowh6Mxwx8pcc(this), inherited: false);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e != 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 != 0)
					{
						num2 = 1;
					}
				}
				break;
			case 3:
				throw new MetadataException((string)IugwiwOjzr4LHuNmyg8g(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4FD00585 ^ 0x4FD20993), new object[4]
				{
					processHeader.Name,
					XoBUF4OjwghW452vbZ7w(type2.Assembly),
					text,
					Yj9v5kOj4v50tTHq5OvA(tablePartMetadata)
				}));
			case 11:
				return type;
			case 13:
				if (!QtKmOrOjEiuKSvFnvFi4(type, null))
				{
					num2 = 11;
					break;
				}
				goto case 3;
			}
		}
	}

	private TablePartMetadata FindTablePartByPropUid(EntityMetadata metadata, Guid tablePartPropertyUid)
	{
		//Discarded unreachable code: IL_0043, IL_004d, IL_0113, IL_0122, IL_0132, IL_0141, IL_0178, IL_018b, IL_019a
		int num = 5;
		int num2 = num;
		List<TablePartMetadata>.Enumerator enumerator = default(List<TablePartMetadata>.Enumerator);
		TablePartMetadata result = default(TablePartMetadata);
		TablePartMetadata tablePartMetadata2 = default(TablePartMetadata);
		TablePartMetadata current = default(TablePartMetadata);
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = default(_003C_003Ec__DisplayClass11_0);
		TablePartMetadata tablePartMetadata = default(TablePartMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return null;
			case 2:
				try
				{
					while (true)
					{
						IL_00f8:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 4;
							goto IL_0051;
						}
						goto IL_00d5;
						IL_0051:
						while (true)
						{
							switch (num3)
							{
							case 3:
								return result;
							case 1:
								result = tablePartMetadata2;
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 != 0)
								{
									num3 = 3;
								}
								continue;
							case 5:
								if (tablePartMetadata2 == null)
								{
									num3 = 7;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto case 1;
							case 6:
								tablePartMetadata2 = FindTablePartByPropUid(current, _003C_003Ec__DisplayClass11_.tablePartPropertyUid);
								num3 = 5;
								continue;
							case 2:
								break;
							default:
								goto IL_00f8;
							case 4:
								goto end_IL_00f8;
							}
							break;
						}
						goto IL_00d5;
						IL_00d5:
						current = enumerator.Current;
						num3 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 == 0)
						{
							num3 = 6;
						}
						goto IL_0051;
						continue;
						end_IL_00f8:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 1;
			case 4:
				_003C_003Ec__DisplayClass11_.tablePartPropertyUid = tablePartPropertyUid;
				num2 = 3;
				continue;
			case 6:
				return tablePartMetadata;
			case 5:
				_003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
				num2 = 4;
				continue;
			case 3:
				tablePartMetadata = metadata.TableParts.FirstOrDefault(_003C_003Ec__DisplayClass11_._003CFindTablePartByPropUid_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b != 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (tablePartMetadata != null)
			{
				num2 = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 != 0)
				{
					num2 = 5;
				}
				continue;
			}
			enumerator = metadata.TableParts.GetEnumerator();
			num2 = 2;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
			{
				num2 = 1;
			}
		}
	}

	protected void Initialize(IEntity firstEntity)
	{
		int num = 2;
		int num2 = num;
		Type mainEntityType = default(Type);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				mainEntityType = GetMainEntityType();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				Initialize((long)firstEntity.GetId(), mainEntityType, firstEntity);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	void IWorkflowTablePartEntity.Initialize(IEntity firstEntity)
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
				Initialize(firstEntity);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool hlB2HXOjAd5ClXM2e16Y()
	{
		return F2XsHsOjVPE4oJAgsRm8 == null;
	}

	internal static WorkflowTablePartEntity OgLVdMOjGPUobqdcdLk2()
	{
		return F2XsHsOjVPE4oJAgsRm8;
	}

	internal static void mZNg0DOj7NqhdxS4LgjP()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static Type Re6D7aOj2NcDsOUUhgw1(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static Type eNphTPOjowh6Mxwx8pcc(object P_0)
	{
		return P_0.GetType();
	}

	internal static object UaMUEyOjFegeKe83BZjR(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object aXojwTOjiD11JpNslfoj(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static long FOAfwuOjIWntlYXGdyfH(object P_0)
	{
		return ((ProcessHeaderIdAttribute)P_0).Id;
	}

	internal static Type hvGqyZOjauN6awjX9NAA(object P_0, long headerId, bool throwOnMissing)
	{
		return ((IWorkflowMetadataLoaderService)P_0).GetFullInstanceContextType(headerId, throwOnMissing);
	}

	internal static object TWQaR5OjrObP8XkueYY0(Type P_0, bool P_1, bool P_2)
	{
		return MetadataLoader.LoadMetadata(P_0, P_1, P_2);
	}

	internal static Guid ibaNFXOjeyqR76S74f1I(object P_0)
	{
		return ((TablePartInfoAttribute)P_0).TablePartPropertyUid;
	}

	internal static object IiTiwhOjN87cUXQ3AQZC(object P_0)
	{
		return ((IProcessHeader)P_0).Name;
	}

	internal static object YsVUYFOjxLgTOgFdH9k7(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object B2a27fOjSLFo7jwhROXX(object P_0)
	{
		return ((ClassMetadata)P_0).Namespace;
	}

	internal static object PkXvRLOj1LelZZPwWUxG(object P_0)
	{
		return ((ClassMetadata)P_0).TypeName;
	}

	internal static object hOHEvkOjhv3v4cmGNTLp(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static bool QtKmOrOjEiuKSvFnvFi4(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object XoBUF4OjwghW452vbZ7w(object P_0)
	{
		return ComponentManager.GetAssemblyShortName((Assembly)P_0);
	}

	internal static object Yj9v5kOj4v50tTHq5OvA(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static object IugwiwOjzr4LHuNmyg8g(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}
}
