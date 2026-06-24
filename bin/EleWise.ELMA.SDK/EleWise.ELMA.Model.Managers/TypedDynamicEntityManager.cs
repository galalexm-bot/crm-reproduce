using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Remoting;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CSharp.RuntimeBinder;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Managers;

public class TypedDynamicEntityManager : EternalRefObject
{
	private Type type;

	private EntityMetadata metadata;

	private IEntityManager manager;

	internal static TypedDynamicEntityManager MH3oFohQcxYbMmHsg8he;

	public TypedDynamicEntityManager(Guid typeUid)
	{
		//Discarded unreachable code: IL_001a
		rPAydZhCBXyvUuDM7nd8();
		base._002Ector();
		int num = 2;
		IMetadataRuntimeService serviceNotNull = default(IMetadataRuntimeService);
		while (true)
		{
			switch (num)
			{
			case 3:
			{
				type = serviceNotNull.GetTypeByUid(typeUid);
				int num2 = 4;
				num = num2;
				break;
			}
			case 6:
				return;
			case 2:
				serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
				{
					num = 3;
				}
				break;
			case 5:
				if (metadata == null)
				{
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num = 0;
					}
					break;
				}
				manager = ModelHelper.GetEntityManager(type);
				num = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
				{
					num = 6;
				}
				break;
			case 4:
				if (X12VVbhCWGstyPnRb3jr(type, null))
				{
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num = 1;
					}
				}
				else
				{
					metadata = MetadataLoader.LoadMetadata(type) as EntityMetadata;
					num = 5;
				}
				break;
			default:
				throw new Exception((string)S3vhx1hCoL0GWUaoxl5Y(QPT2O4hCbKWiBw3sUNP6(-951514650 ^ -951435640), typeUid));
			case 1:
				throw new Exception((string)S3vhx1hCoL0GWUaoxl5Y(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2AFD44D), typeUid));
			}
		}
	}

	public virtual DynamicEntity New()
	{
		int num = 1;
		int num2 = num;
		object entity = default(object);
		while (true)
		{
			switch (num2)
			{
			case 1:
				entity = Activator.CreateInstance(type);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return new DynamicEntity(metadata, entity);
			}
		}
	}

	public virtual DynamicEntity Load(object id, Guid[] propertyUids = null)
	{
		int num = 1;
		int num2 = num;
		object entity = default(object);
		while (true)
		{
			switch (num2)
			{
			default:
				return new DynamicEntity(metadata, entity);
			case 1:
				entity = KS7rllhChbiuGsnRlDJ0(manager, id);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual object Save(DynamicEntity entity)
	{
		//Discarded unreachable code: IL_00b4, IL_00c3, IL_011f, IL_012e
		int num = 8;
		object obj2 = default(object);
		object obj = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (obj2 != null)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 9;
				case 5:
					if (_003C_003Eo__6._003C_003Ep__0 != null)
					{
						num = 2;
						break;
					}
					goto case 1;
				default:
					return _003C_003Eo__6._003C_003Ep__0.Target(_003C_003Eo__6._003C_003Ep__0, obj2);
				case 9:
					obj2 = hU7lIGhCf1tIBSslHjmJ(type);
					num2 = 10;
					continue;
				case 3:
					r78nVChCClB6A2cYsPE5(manager, obj2);
					num = 5;
					break;
				case 7:
					obj2 = J59fAahCEMR7VYIto7K4(manager, obj);
					num2 = 4;
					continue;
				case 6:
				case 10:
					FrjscahCQHkkYlFbcrSI(entity, metadata, obj2);
					num2 = 3;
					continue;
				case 1:
					_003C_003Eo__6._003C_003Ep__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307E1E8F), typeof(TypedDynamicEntityManager), new CSharpArgumentInfo[1] { (CSharpArgumentInfo)OwQoHshCvOOrCkb4BY8m(CSharpArgumentInfoFlags.None, null) }));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					obj = Ko6yvEhCGMJjAfYlyvWW(entity);
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	public virtual void Delete(DynamicEntity entity)
	{
		//Discarded unreachable code: IL_00ad, IL_00bc
		int num = 2;
		int num2 = num;
		object obj2 = default(object);
		object obj = default(object);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				obj2 = J59fAahCEMR7VYIto7K4(manager, obj);
				num2 = 3;
				continue;
			case 3:
				if (obj2 == null)
				{
					num2 = 5;
					continue;
				}
				break;
			case 0:
				return;
			case 5:
				return;
			case 2:
				obj = Ko6yvEhCGMJjAfYlyvWW(entity);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num2 = 1;
				}
				continue;
			case 4:
				break;
			}
			xjucKihC8iB6iKCLIyFA(manager, obj2);
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
			{
				num2 = 0;
			}
		}
	}

	public virtual ICollection<DynamicEntity> FindAll()
	{
		IEnumerable enumerable = manager.FindAll();
		List<DynamicEntity> list = new List<DynamicEntity>();
		foreach (object item in enumerable)
		{
			list.Add(new DynamicEntity(metadata, item));
		}
		return list;
	}

	internal static void rPAydZhCBXyvUuDM7nd8()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool X12VVbhCWGstyPnRb3jr(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object S3vhx1hCoL0GWUaoxl5Y(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object QPT2O4hCbKWiBw3sUNP6(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool QeurvQhQzvC8DSZb6dqf()
	{
		return MH3oFohQcxYbMmHsg8he == null;
	}

	internal static TypedDynamicEntityManager ISFitNhCFJlWoDUSmQWa()
	{
		return MH3oFohQcxYbMmHsg8he;
	}

	internal static object KS7rllhChbiuGsnRlDJ0(object P_0, object P_1)
	{
		return ((IEntityManager)P_0).Load(P_1);
	}

	internal static object Ko6yvEhCGMJjAfYlyvWW(object P_0)
	{
		return ((DynamicEntity)P_0).Id;
	}

	internal static object J59fAahCEMR7VYIto7K4(object P_0, object P_1)
	{
		return ((IEntityManager)P_0).LoadOrNull(P_1);
	}

	internal static object hU7lIGhCf1tIBSslHjmJ(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static void FrjscahCQHkkYlFbcrSI(object P_0, object P_1, object P_2)
	{
		((DynamicEntity)P_0).SaveToEntity((EntityMetadata)P_1, P_2);
	}

	internal static void r78nVChCClB6A2cYsPE5(object P_0, object P_1)
	{
		((IEntityManager)P_0).Save(P_1);
	}

	internal static object OwQoHshCvOOrCkb4BY8m(CSharpArgumentInfoFlags P_0, object P_1)
	{
		return CSharpArgumentInfo.Create(P_0, (string)P_1);
	}

	internal static void xjucKihC8iB6iKCLIyFA(object P_0, object P_1)
	{
		((IEntityManager)P_0).Delete(P_1);
	}
}
