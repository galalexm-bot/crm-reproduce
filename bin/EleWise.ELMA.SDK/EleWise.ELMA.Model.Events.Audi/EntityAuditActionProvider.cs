using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Events.Audit;

[Component]
public class EntityAuditActionProvider : IAuditActionProvider
{
	private IMetadataRuntimeService metadataRuntimeService;

	private readonly Func<Guid, IEnumerable<IAuditAction>> getObjectActionsCached;

	private static EnumMetadata defaultActions;

	internal static EntityAuditActionProvider oif5ZGoBsfNiUCn21EgR;

	public Guid? ObjectUid => null;

	internal static EnumMetadata DefaultActions
	{
		get
		{
			//Discarded unreachable code: IL_0059, IL_0068
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (defaultActions != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 3:
					defaultActions.LoadFromType(pBJdjvoWo7AW14D68wEC(typeof(DefaultEntityActions).TypeHandle));
					num2 = 4;
					continue;
				default:
					return defaultActions;
				case 2:
					break;
				}
				defaultActions = new EntityActionsMetadata();
				num2 = 3;
			}
		}
	}

	public EntityAuditActionProvider(IMetadataRuntimeService metadataService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		PSGweUoWFV6l4dtjtKwm();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				metadataRuntimeService = metadataService;
				num = 2;
				break;
			case 2:
			{
				ParameterExpression parameterExpression = (ParameterExpression)L0phiNoWWR29VWN6sItQ(typeof(Guid), KnnEGsoWBeKDWfdexuYc(--1333735954 ^ 0x4F7EF1C4));
				getObjectActionsCached = MetadataLoader.UseCachingForFunc(Expression.Lambda<Func<Guid, IEnumerable<IAuditAction>>>((Expression)LCNoSioWhuvcZqH9AJT2(FWHdhaoWblo7CkUHI06s(this, pBJdjvoWo7AW14D68wEC(typeof(EntityAuditActionProvider).TypeHandle)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), new Expression[1] { parameterExpression }), new ParameterExpression[1] { parameterExpression }));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
				{
					num = 0;
				}
				break;
			}
			case 0:
				return;
			}
		}
	}

	public IEnumerable<IAuditAction> GetActions(IAuditObject obj)
	{
		if (obj == null || obj.Type == null || obj.Type.Uid != EntityAuditObjectType.UID)
		{
			return null;
		}
		return getObjectActionsCached(obj.Uid);
	}

	public IAuditAction GetAction(IAuditObject obj, Guid uid)
	{
		//Discarded unreachable code: IL_005e, IL_0110, IL_011f, IL_012e
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
		IEnumerable<IAuditAction> actions = default(IEnumerable<IAuditAction>);
		while (true)
		{
			switch (num2)
			{
			case 4:
				_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
				num2 = 3;
				break;
			case 2:
				if (obj != null)
				{
					num2 = 5;
					break;
				}
				goto default;
			case 10:
				if (!NgNEJPoWfumrRXimtjbN(b9iNnJoWEZHRV3RMSdFp(XdZCNnoWGIXueKNNaTrp(obj)), EntityAuditObjectType.UID))
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 1:
				if (actions != null)
				{
					num2 = 6;
					break;
				}
				goto case 9;
			case 3:
				_003C_003Ec__DisplayClass7_.uid = uid;
				num2 = 2;
				break;
			case 9:
				return null;
			case 6:
				return actions.FirstOrDefault(_003C_003Ec__DisplayClass7_._003CGetAction_003Eb__0);
			case 5:
				if (obj.Type == null)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 7;
					}
					break;
				}
				goto case 10;
			default:
				return null;
			case 8:
				actions = GetActions(obj);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void InitActionsForObject()
	{
	}

	private IEnumerable<IAuditAction> GetObjectActions(Guid objUid)
	{
		List<IAuditAction> list = new List<IAuditAction>();
		if (metadataRuntimeService.GetMetadata(objUid, loadImplementation: false) is EntityMetadata entityMetadata)
		{
			if (entityMetadata.Type == EntityMetadataType.InterfaceImplementation)
			{
				if (metadataRuntimeService.GetMetadata(entityMetadata.ImplementationUid, loadImplementation: false) is EntityMetadata metadata)
				{
					GetEntityMetadataActions(metadata, list);
				}
			}
			else if (entityMetadata.Type == EntityMetadataType.Entity)
			{
				GetEntityMetadataActions(entityMetadata, list);
			}
		}
		return list;
	}

	private static EnumValueMetadata GetDefaultLocalizedMetadata(Guid valueUid)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = default(_003C_003Ec__DisplayClass12_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return ((EnumMetadata)tXLBfPoWQ1Um6xdZRSiC()).Values.FirstOrDefault(_003C_003Ec__DisplayClass12_._003CGetDefaultLocalizedMetadata_003Eb__0);
			case 1:
				_003C_003Ec__DisplayClass12_.valueUid = valueUid;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private static EnumValueMetadata GetLocalizedMetadata(Type metadataType, Guid valueUid)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = default(_003C_003Ec__DisplayClass13_0);
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(metadataType, inherit: true, loadImplementation: false);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 3;
				}
				break;
			default:
				if (entityMetadata.Actions == null)
				{
					num2 = 5;
					break;
				}
				return ((EnumMetadata)wGBFwtoWCihQ4Du88upn(entityMetadata)).Values.FirstOrDefault(_003C_003Ec__DisplayClass13_._003CGetLocalizedMetadata_003Eb__0);
			case 5:
				return null;
			case 3:
				if (entityMetadata != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			case 1:
				_003C_003Ec__DisplayClass13_.valueUid = valueUid;
				num2 = 4;
				break;
			}
		}
	}

	private static void GetEntityMetadataActions(object metadata, List<IAuditAction> actions)
	{
		_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass14_0();
		Contract.ArgumentNotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7EC5C01));
		IMetadataRuntimeService serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
		EntityMetadataType type = ((EntityMetadata)metadata).Type;
		if ((uint)type <= 1u || type == EntityMetadataType.InterfaceImplementation)
		{
			if (((ClassMetadata)metadata).BaseClassUid != Guid.Empty)
			{
				if (serviceNotNull.GetMetadata(((ClassMetadata)metadata).BaseClassUid, loadImplementation: false) is EntityMetadata entityMetadata && entityMetadata.Actions != null)
				{
					GetEntityMetadataActions(entityMetadata, actions);
				}
			}
			else
			{
				foreach (EnumValueMetadata value in DefaultActions.Values)
				{
					EntityAuditAction item = new EntityAuditAction(value.Uid, value.Name, (EntityAuditAction a) => GetDefaultLocalizedMetadata(_003C_003Ec.ShRLgECone60roKR8bE9(a)), value.DefaultImage);
					actions.Add(item);
				}
			}
		}
		CS_0024_003C_003E8__locals0.metadataType = serviceNotNull.GetTypeByUid(((AbstractMetadata)metadata).Uid, loadImplementation: false);
		if (CS_0024_003C_003E8__locals0.metadataType == null)
		{
			return;
		}
		foreach (EnumValueMetadata value2 in ((EntityMetadata)metadata).Actions.Values)
		{
			EntityAuditAction item2 = new EntityAuditAction(value2.Uid, value2.Name, (EntityAuditAction a) => (EnumValueMetadata)_003C_003Ec__DisplayClass14_0.uQWHnmCoqd2CeoYmIXc8(CS_0024_003C_003E8__locals0.metadataType, _003C_003Ec__DisplayClass14_0.efk9pjCoREct27rsnd6B(a)), value2.DefaultImage);
			actions.Add(item2);
		}
		if (((EntityMetadata)metadata).Type != EntityMetadataType.Interface || !(serviceNotNull.GetMetadata(((EntityMetadata)metadata).ImplementationUid, loadImplementation: false) is EntityMetadata entityMetadata2) || entityMetadata2.ImplementedExtensionUids == null)
		{
			return;
		}
		foreach (Guid implementedExtensionUid in entityMetadata2.ImplementedExtensionUids)
		{
			EntityMetadata entityMetadata3 = (EntityMetadata)serviceNotNull.GetMetadata(implementedExtensionUid, loadImplementation: false);
			if (entityMetadata3 != null)
			{
				GetEntityMetadataActions(entityMetadata3, actions);
			}
		}
	}

	internal static void PSGweUoWFV6l4dtjtKwm()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object KnnEGsoWBeKDWfdexuYc(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object L0phiNoWWR29VWN6sItQ(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static Type pBJdjvoWo7AW14D68wEC(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object FWHdhaoWblo7CkUHI06s(object P_0, Type P_1)
	{
		return Expression.Constant(P_0, P_1);
	}

	internal static object LCNoSioWhuvcZqH9AJT2(object P_0, object P_1, object P_2)
	{
		return Expression.Call((Expression)P_0, (MethodInfo)P_1, (Expression[])P_2);
	}

	internal static bool fLjQaUoBcwcmahIqDCBm()
	{
		return oif5ZGoBsfNiUCn21EgR == null;
	}

	internal static EntityAuditActionProvider uHedcooBzOBvarIfiGQC()
	{
		return oif5ZGoBsfNiUCn21EgR;
	}

	internal static object XdZCNnoWGIXueKNNaTrp(object P_0)
	{
		return ((IAuditObject)P_0).Type;
	}

	internal static Guid b9iNnJoWEZHRV3RMSdFp(object P_0)
	{
		return ((IAuditObjectType)P_0).Uid;
	}

	internal static bool NgNEJPoWfumrRXimtjbN(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object tXLBfPoWQ1Um6xdZRSiC()
	{
		return DefaultActions;
	}

	internal static object wGBFwtoWCihQ4Du88upn(object P_0)
	{
		return ((EntityMetadata)P_0).Actions;
	}
}
