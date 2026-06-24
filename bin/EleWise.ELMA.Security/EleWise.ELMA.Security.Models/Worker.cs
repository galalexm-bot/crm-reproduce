using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Security.DTO.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Models;

[Serializable]
public class Worker
{
	public static class Types
	{
		public static readonly Guid Property;

		private static Types AFn4uupjqWaAxWVpCekS;

		static Types()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					jk5GQNpjFN26ITLCoUVC();
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7eacf98b652644699fca43e43408d382 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					Property = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--561310391 ^ 0x2175C7A9));
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					return;
				}
			}
		}

		internal static void jk5GQNpjFN26ITLCoUVC()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		}

		internal static bool SAh0fWpjcSei9mZlg7OX()
		{
			return AFn4uupjqWaAxWVpCekS == null;
		}

		internal static Types JOqaASpjGGgutCuAVEvH()
		{
			return AFn4uupjqWaAxWVpCekS;
		}
	}

	internal static Worker TQrNp4GkrjqmymwBxbA;

	public Guid WorkerType
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkerType_003Ek__BackingField;
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
					_003CWorkerType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a16ce287ba7944e2afcf4e52864ec01d != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(0L)]
	public long WorkerId
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkerId_003Ek__BackingField;
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
					_003CWorkerId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1a646659a464f3fa5c9aedc64725d72 == 0)
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

	public Guid WorkerUid
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkerUid_003Ek__BackingField;
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
					_003CWorkerUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dee60bd1c491407eb16511279f664d42 != 0)
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

	[DefaultValue(WorkerDisplayType.UserName)]
	public WorkerDisplayType WorkerDisplayType
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkerDisplayType_003Ek__BackingField;
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
					_003CWorkerDisplayType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0ab7ce9a6369414380df24a533da8346 == 0)
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

	public Worker()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		YmMfKhGAHgEB14JNj0e();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d689f5970f6345a7af332e1f7092123f == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			WorkerDisplayType = WorkerDisplayType.UserName;
			num = 1;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fb7ef78ec97a4842bca66699308784ed != 0)
			{
				num = 1;
			}
		}
	}

	public override bool Equals(object obj)
	{
		//Discarded unreachable code: IL_003d, IL_004c
		int num = 4;
		int num2 = num;
		Worker worker = default(Worker);
		while (true)
		{
			switch (num2)
			{
			case 4:
				worker = obj as Worker;
				num2 = 3;
				continue;
			case 1:
				if (!VH36ttGXZRDob3Wep8P(WorkerType, BY4vJ5GWodc6t9kQTfP(worker)))
				{
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e0cdbab05b2b455cab94ec0ba1efc443 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				goto default;
			default:
				if (WorkerUid == j6EXPJGnCSIbqaxYN9M(worker))
				{
					num2 = 5;
					continue;
				}
				break;
			case 5:
				if (WorkerId == PylSDVGiTyWvk2obmP8(worker))
				{
					num2 = 6;
					continue;
				}
				break;
			case 3:
				if (worker != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 6:
				return WorkerDisplayType == vqdhC6G7JYjcleuhC0c(worker);
			case 2:
				break;
			}
			break;
		}
		return false;
	}

	public override int GetHashCode()
	{
		int num = 1;
		int num2 = num;
		(Guid, long, Guid, WorkerDisplayType) tuple = default((Guid, long, Guid, WorkerDisplayType));
		while (true)
		{
			switch (num2)
			{
			default:
				return tuple.GetHashCode();
			case 1:
				tuple = (WorkerType, WorkerId, WorkerUid, WorkerDisplayType);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_364662b38d3b4bdb9f3f1f11b8889cdc != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static Worker GetFrom(OrganizationItemDTO item)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
			{
				Worker worker = new Worker();
				IU4jC6GNKCE3rQx8myr(worker, OrganizationItemDTO.MetadataUid);
				worker.WorkerId = item.Id;
				return worker;
			}
			case 1:
				GW70LbGlOSHxK7pZEdj(item, Nw1EKpG6jOGnuKNluMJ(0x1C48C9C4 ^ 0x1C48562E));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6370a8f224e7416eb3575ae34b77f5e3 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static Worker GetFrom(UserGroupDTO item)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
			{
				Worker worker = new Worker();
				IU4jC6GNKCE3rQx8myr(worker, OUMXf8GZVuGpHpw9alq());
				worker.WorkerId = item.Id;
				return worker;
			}
			case 1:
				Contract.ArgumentNotNull(item, (string)Nw1EKpG6jOGnuKNluMJ(0xCDF201B ^ 0xCDFBFF1));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0a82cc1379bc48bbb836c94da8cb8564 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static Worker GetFrom(IPropertyMetadata prop)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				Contract.ArgumentNotNull(prop, (string)Nw1EKpG6jOGnuKNluMJ(-2068904634 ^ -2068866384));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d2fa92555e394879ba912e266541f735 == 0)
				{
					num2 = 0;
				}
				break;
			default:
			{
				Worker worker = new Worker();
				IU4jC6GNKCE3rQx8myr(worker, Types.Property);
				worker.WorkerUid = RLfxdnGx7mi0o4M8XO5(prop);
				return worker;
			}
			}
		}
	}

	public static List<Worker> PrepareForFilter(List<Worker> workers, IEntity entity)
	{
		List<Worker> list = new List<Worker>();
		if (workers != null)
		{
			using (List<Worker>.Enumerator enumerator = workers.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					_003C_003Ec__DisplayClass23_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass23_0();
					CS_0024_003C_003E8__locals0.w = enumerator.Current;
					if (CS_0024_003C_003E8__locals0.w.WorkerType == Types.Property)
					{
						bool flag = false;
						if (entity != null)
						{
							PropertyMetadata propertyMetadata = ((ClassMetadata)MetadataLoader.LoadMetadata(entity.CastAsRealType().GetType())).Properties.FirstOrDefault((PropertyMetadata p) => _003C_003Ec__DisplayClass23_0.NPisBSpjsfBtIU6dNQbD(p) == CS_0024_003C_003E8__locals0.w.WorkerUid);
							EntitySettings entitySettings = ((propertyMetadata != null) ? (propertyMetadata.Settings as EntitySettings) : null);
							object obj = ((propertyMetadata != null) ? entity.GetPropertyValue(propertyMetadata.Uid) : null);
							if (propertyMetadata != null && entitySettings != null && obj != null)
							{
								if (propertyMetadata.SubTypeUid == UserDTO.UID || propertyMetadata.SubTypeUid == UserDTO.ImplUID)
								{
									flag = AddItems<IUser>(list, obj, entitySettings, UserDTO.UID);
								}
								else if (propertyMetadata.SubTypeUid == UserGroupDTO.MetadataUid || propertyMetadata.SubTypeUid == UserGroupDTO.ImplMetadataUid)
								{
									flag = AddItems<IUserGroup>(list, obj, entitySettings, UserGroupDTO.MetadataUid);
								}
								else if (propertyMetadata.SubTypeUid == OrganizationItemDTO.MetadataUid || propertyMetadata.SubTypeUid == OrganizationItemDTO.ImplMetadataUid)
								{
									flag = AddItems<IOrganizationItem>(list, obj, entitySettings, OrganizationItemDTO.MetadataUid);
								}
							}
						}
						if (!flag)
						{
							list.Add(CS_0024_003C_003E8__locals0.w);
						}
					}
					else
					{
						list.Add(CS_0024_003C_003E8__locals0.w);
					}
				}
				return list;
			}
		}
		return list;
	}

	private static bool AddItems<T>(List<Worker> result, object propertyValue, object settings, Guid workerType) where T : class, IEntity<long>
	{
		bool result2 = false;
		if (((EntitySettings)settings).RelationType == RelationType.OneToOne)
		{
			if (propertyValue is T val)
			{
				result.Add(new Worker
				{
					WorkerType = workerType,
					WorkerId = val.Id
				});
				result2 = true;
			}
		}
		else if (propertyValue is IEnumerable source)
		{
			{
				foreach (T item in source.OfType<T>().ToList())
				{
					result.Add(new Worker
					{
						WorkerType = workerType,
						WorkerId = item.Id
					});
					result2 = true;
				}
				return result2;
			}
		}
		return result2;
	}

	internal static void YmMfKhGAHgEB14JNj0e()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool QBUeewGp44BhcAFHjmi()
	{
		return TQrNp4GkrjqmymwBxbA == null;
	}

	internal static Worker AepkshG5s27ZeEt8MyW()
	{
		return TQrNp4GkrjqmymwBxbA;
	}

	internal static Guid BY4vJ5GWodc6t9kQTfP(object P_0)
	{
		return ((Worker)P_0).WorkerType;
	}

	internal static bool VH36ttGXZRDob3Wep8P(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static Guid j6EXPJGnCSIbqaxYN9M(object P_0)
	{
		return ((Worker)P_0).WorkerUid;
	}

	internal static long PylSDVGiTyWvk2obmP8(object P_0)
	{
		return ((Worker)P_0).WorkerId;
	}

	internal static WorkerDisplayType vqdhC6G7JYjcleuhC0c(object P_0)
	{
		return ((Worker)P_0).WorkerDisplayType;
	}

	internal static object Nw1EKpG6jOGnuKNluMJ(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void GW70LbGlOSHxK7pZEdj(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void IU4jC6GNKCE3rQx8myr(object P_0, Guid value)
	{
		((Worker)P_0).WorkerType = value;
	}

	internal static Guid OUMXf8GZVuGpHpw9alq()
	{
		return UserGroupDTO.MetadataUid;
	}

	internal static Guid RLfxdnGx7mi0o4M8XO5(object P_0)
	{
		return ((IPropertyMetadata)P_0).PropertyUid;
	}
}
