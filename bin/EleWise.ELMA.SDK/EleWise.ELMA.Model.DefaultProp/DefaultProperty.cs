using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.DefaultProperties;

[Component]
public abstract class DefaultProperty : IDefaultProperty
{
	private static DefaultProperty gbOM9lWjgQM7tDu6TY93;

	public abstract string Name { get; }

	public virtual Guid Uid => pZhFlJWjL4Vcnyf0jKhd(tKhyjjWjYNxjgd5Pyete(this));

	public virtual bool DefaultChecked => false;

	protected abstract string PropertyName { get; }

	protected virtual string PropertyDisplayName => Name;

	protected virtual string PropertyDescription => string.Empty;

	protected abstract Guid TypeUid { get; }

	protected virtual Guid SubTypeUid => Guid.Empty;

	protected virtual bool Required => false;

	protected virtual bool Filterable => false;

	protected virtual Guid HandlerUid => Guid.Empty;

	public virtual bool IsAvailableFor(ClassMetadata classMetadata, List<IMetadata> allProperties = null)
	{
		Contract.ArgumentNotNull(classMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112832910));
		List<PropertyMetadata> list = new List<PropertyMetadata>();
		List<TablePartMetadata> list2 = new List<TablePartMetadata>();
		if (allProperties != null)
		{
			foreach (IMetadata allProperty in allProperties)
			{
				PropertyMetadata propertyMetadata = allProperty as PropertyMetadata;
				TablePartMetadata tablePartMetadata = allProperty as TablePartMetadata;
				if (propertyMetadata != null)
				{
					list.Add(propertyMetadata);
				}
				if (tablePartMetadata != null)
				{
					list2.Add(tablePartMetadata);
				}
			}
		}
		if (list.FirstOrDefault((PropertyMetadata p) => MPDk5NWYZB41Q5ZlCFUF(yAVqvWWY8d5VQI3vOZTe(p), bx2BuqWjceHsJV7hmRWJ(this))) == null)
		{
			return list2.FirstOrDefault((TablePartMetadata p) => MPDk5NWYZB41Q5ZlCFUF(p.Name, bx2BuqWjceHsJV7hmRWJ(this))) == null;
		}
		return false;
	}

	public virtual void InitProperty(ClassMetadata classMetadata, PropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_00f3, IL_0102
		int num = 6;
		int num2 = num;
		EntityPropertyMetadata entityPropertyMetadata = default(EntityPropertyMetadata);
		while (true)
		{
			switch (num2)
			{
			case 3:
				waAXabWYQ2lkfLa8YQ7q(entityPropertyMetadata, sQAI3AWYfCeoJUF4bm0n(this));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 1;
				}
				break;
			case 14:
				if (entityPropertyMetadata == null)
				{
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 3;
			case 4:
				NbAWBRWYF6dfVqAkX0xW(propertyMetadata, FMcBkeWjzZ73L5nRig9T(this));
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
				{
					num2 = 12;
				}
				break;
			case 8:
				entityPropertyMetadata = propertyMetadata as EntityPropertyMetadata;
				num2 = 14;
				break;
			case 9:
				pYEIYlWYh4KCjx8VSStF(propertyMetadata, l5cocyWYbHQVGRbQsBNq(this));
				num2 = 13;
				break;
			case 2:
				return;
			case 1:
			case 11:
				if (!BxmOU6WYv1KidXlvVmyW(gI40mIWYCGf2ibmSBMtZ(this), Guid.Empty))
				{
					return;
				}
				num2 = 10;
				break;
			case 12:
				pVKZ1LWYBLFyheyTKiQ9(propertyMetadata, PropertyDescription);
				num2 = 7;
				break;
			case 7:
				j4NxJkWYoOfSZyQjoWBR(propertyMetadata, yCkCsKWYWUIkH9sg3eo0(this));
				num2 = 9;
				break;
			case 5:
				PpwHYFWjswwJ8gptyprY(propertyMetadata, GekawmWjUBuvNhBBVUwk(-289714582 ^ -289732808));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
				{
					num2 = 0;
				}
				break;
			default:
				propertyMetadata.Name = (string)bx2BuqWjceHsJV7hmRWJ(this);
				num2 = 4;
				break;
			case 6:
				Contract.ArgumentNotNull(classMetadata, (string)GekawmWjUBuvNhBBVUwk(-1317790512 ^ -1317662156));
				num2 = 5;
				break;
			case 13:
				DUDkgcWYE2HG2u1YZ19M(propertyMetadata, fv7LuUWYGWCTedineGiD(this, classMetadata, propertyMetadata));
				num2 = 8;
				break;
			case 10:
				propertyMetadata.Handlers.Add(new PropertyHandlerInfo
				{
					HandlerUid = gI40mIWYCGf2ibmSBMtZ(this)
				});
				num2 = 2;
				break;
			}
		}
	}

	protected abstract TypeSettings GetTypeSettings(ClassMetadata classMetadata, PropertyMetadata propertyMetadata);

	protected DefaultProperty()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object tKhyjjWjYNxjgd5Pyete(object P_0)
	{
		return ((DefaultProperty)P_0).Name;
	}

	internal static Guid pZhFlJWjL4Vcnyf0jKhd(object P_0)
	{
		return ((string)P_0).GetDeterministicGuid();
	}

	internal static bool mjfjrbWj5CvuIDkQ7RrS()
	{
		return gbOM9lWjgQM7tDu6TY93 == null;
	}

	internal static DefaultProperty L4ofJTWjjVXMKsojBm2j()
	{
		return gbOM9lWjgQM7tDu6TY93;
	}

	internal static object GekawmWjUBuvNhBBVUwk(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void PpwHYFWjswwJ8gptyprY(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object bx2BuqWjceHsJV7hmRWJ(object P_0)
	{
		return ((DefaultProperty)P_0).PropertyName;
	}

	internal static object FMcBkeWjzZ73L5nRig9T(object P_0)
	{
		return ((DefaultProperty)P_0).PropertyDisplayName;
	}

	internal static void NbAWBRWYF6dfVqAkX0xW(object P_0, object P_1)
	{
		((NamedMetadata)P_0).DisplayName = (string)P_1;
	}

	internal static void pVKZ1LWYBLFyheyTKiQ9(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Description = (string)P_1;
	}

	internal static Guid yCkCsKWYWUIkH9sg3eo0(object P_0)
	{
		return ((DefaultProperty)P_0).TypeUid;
	}

	internal static void j4NxJkWYoOfSZyQjoWBR(object P_0, Guid value)
	{
		((PropertyMetadata)P_0).TypeUid = value;
	}

	internal static Guid l5cocyWYbHQVGRbQsBNq(object P_0)
	{
		return ((DefaultProperty)P_0).SubTypeUid;
	}

	internal static void pYEIYlWYh4KCjx8VSStF(object P_0, Guid value)
	{
		((PropertyMetadata)P_0).SubTypeUid = value;
	}

	internal static object fv7LuUWYGWCTedineGiD(object P_0, object P_1, object P_2)
	{
		return ((DefaultProperty)P_0).GetTypeSettings((ClassMetadata)P_1, (PropertyMetadata)P_2);
	}

	internal static void DUDkgcWYE2HG2u1YZ19M(object P_0, object P_1)
	{
		((PropertyMetadata)P_0).Settings = (TypeSettings)P_1;
	}

	internal static bool sQAI3AWYfCeoJUF4bm0n(object P_0)
	{
		return ((DefaultProperty)P_0).Filterable;
	}

	internal static void waAXabWYQ2lkfLa8YQ7q(object P_0, bool value)
	{
		((EntityPropertyMetadata)P_0).Filterable = value;
	}

	internal static Guid gI40mIWYCGf2ibmSBMtZ(object P_0)
	{
		return ((DefaultProperty)P_0).HandlerUid;
	}

	internal static bool BxmOU6WYv1KidXlvVmyW(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object yAVqvWWY8d5VQI3vOZTe(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static bool MPDk5NWYZB41Q5ZlCFUF(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}
}
