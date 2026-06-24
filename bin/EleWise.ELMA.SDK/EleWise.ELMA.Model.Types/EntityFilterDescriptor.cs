using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

public class EntityFilterDescriptor : CLRTypeDescriptor<IEntityFilter, EntityFilterSettings>
{
	public const string UID_S = "{DCF11C25-895C-49BC-BF57-47C581AB7B54}";

	public static readonly Guid UID;

	internal static EntityFilterDescriptor etYOb8oyjqnr5C1Fg4Be;

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	public override Guid Uid => UID;

	public override string Name => (string)vmx1KxoyUyljMrwomaHS(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146408171));

	public override bool Visible => false;

	public override bool IsEmpty(PropertyMetadata propertyMetadata, object val)
	{
		int num = 1;
		int num2 = num;
		IEntityFilter entityFilter = default(IEntityFilter);
		while (true)
		{
			switch (num2)
			{
			case 1:
				entityFilter = val as IEntityFilter;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return true;
			}
			if (entityFilter == null)
			{
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
				{
					num2 = 1;
				}
				continue;
			}
			return OjnDIOoysoAYhaPOsb5n(entityFilter);
		}
	}

	public override void ApplyFilterValue(ICriteria criteria, EntityMetadata metadata, EntityPropertyMetadata propertyMetadata, object value, string alias)
	{
		//Discarded unreachable code: IL_0115, IL_0124, IL_02f9
		int num = 7;
		IEntityManager entityManager = default(IEntityManager);
		FilterForAttribute filterForAttribute = default(FilterForAttribute);
		DetachedCriteria val = default(DetachedCriteria);
		IEntityFilter entityFilter = default(IEntityFilter);
		string text = default(string);
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = default(_003C_003Ec__DisplayClass11_0);
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 22:
					entityManager = (IEntityManager)FW1T7NoMF3tctuDZbUZ2(filterForAttribute.EntityType);
					num2 = 15;
					continue;
				case 16:
					zqF4E8oME4De09xlQGBl(val, j0XOQJoMviobM7OQp2VX());
					num2 = 13;
					continue;
				case 0:
					return;
				case 21:
					return;
				case 2:
					if (OjnDIOoysoAYhaPOsb5n(entityFilter))
					{
						return;
					}
					num2 = 5;
					continue;
				case 24:
					return;
				case 19:
					val = entityManager.CreateDetachedCriteria((FetchOptions)d7c2TqoMbpr5JwdjPME5(), SPh9XioMosjkPOaMp5mD(filterForAttribute), text, entityFilter);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					continue;
				case 11:
					if (_003C_003Ec__DisplayClass11_.entitySettings == null)
					{
						num2 = 9;
					}
					else if (_003C_003Ec__DisplayClass11_.entitySettings.RelationType != RelationType.OneToMany)
					{
						val = DetachedCriteria.For(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(PbgRJyoMQBCONX8YkAJN(metadata)));
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
						{
							num2 = 11;
						}
					}
					else
					{
						num2 = 20;
					}
					continue;
				case 10:
					return;
				case 17:
					Gv5dDZoMfWLWKUJ2sX2B(criteria, Subqueries.PropertyIn((string)gv4C5ioMBnLYWJOgEous(-583745292 ^ -583777878), val));
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num2 = 10;
					}
					continue;
				case 15:
					if (entityManager == null)
					{
						return;
					}
					num2 = 4;
					continue;
				case 9:
					return;
				case 14:
					entityManager.FilterDetachedCriteria((DetachedCriteria)AgiQKUoMChnoduHSXG8W(val, propertyMetadata.Name, text, (JoinType)0), FetchOptions.All, SPh9XioMosjkPOaMp5mD(filterForAttribute), entityFilter);
					num2 = 16;
					continue;
				case 20:
					propertyMetadata2 = ((ClassMetadata)MetadataLoader.LoadMetadata(SPh9XioMosjkPOaMp5mD(filterForAttribute))).Properties.FirstOrDefault(_003C_003Ec__DisplayClass11_._003CApplyFilterValue_003Eb__0);
					num2 = 8;
					continue;
				case 6:
					return;
				case 23:
					if (filterForAttribute == null)
					{
						return;
					}
					num2 = 22;
					continue;
				case 18:
					if (entityFilter == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				case 12:
					_003C_003Ec__DisplayClass11_.entitySettings = dRZcRZoMW3LFPJydCDvJ(propertyMetadata) as EntitySettings;
					num2 = 11;
					continue;
				case 5:
					filterForAttribute = (FilterForAttribute)((IEnumerable<object>)CcC42aoyzMfBpxHIOu8Q(entityFilter.GetType(), UHUsDXoycscAkrW4cIsU(typeof(FilterForAttribute).TypeHandle), true)).FirstOrDefault();
					num2 = 23;
					continue;
				case 7:
					if (value != null)
					{
						entityFilter = value as IEntityFilter;
						num2 = 18;
					}
					else
					{
						num2 = 6;
					}
					continue;
				case 8:
					if (propertyMetadata2 == null)
					{
						return;
					}
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 19;
					}
					continue;
				case 1:
					zqF4E8oME4De09xlQGBl(val, aQOGBeoMGpWwJdPbk1FK(O3rJgGoMh7wNQOXtWVtD(propertyMetadata2)));
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
					{
						num2 = 17;
					}
					continue;
				case 13:
					criteria.Add((ICriterion)(object)Subqueries.PropertyIn((string)gv4C5ioMBnLYWJOgEous(-583745292 ^ -583777878), val));
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 18;
					}
					continue;
				case 4:
					break;
				case 3:
					text = string.Format((string)gv4C5ioMBnLYWJOgEous(0x2ACE37D ^ 0x2AE7525), propertyMetadata.Name);
					num2 = 12;
					continue;
				}
				break;
			}
			_003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
			num = 3;
		}
	}

	public override TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0084, IL_0093
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 1:
				if (propertyMetadata == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 2:
				break;
			}
			if (dRZcRZoMW3LFPJydCDvJ(propertyMetadata) != null)
			{
				break;
			}
			num2 = 3;
		}
		EntityFilterSettings entityFilterSettings = new EntityFilterSettings();
		yUamiGoMZA2IE0xtx550(entityFilterSettings, HPQsyNoM8cGZbHM2ROFI((SimpleTypeSettings)dRZcRZoMW3LFPJydCDvJ(propertyMetadata)));
		return entityFilterSettings;
	}

	public override ISyntaxNode GetPropertyTypeReference(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter)
	{
		//Discarded unreachable code: IL_00c9, IL_00d8, IL_00e8, IL_00f7, IL_011b, IL_012a
		int num = 10;
		EntityMetadata metadata = default(EntityMetadata);
		EntityMetadata entityMetadata = default(EntityMetadata);
		EntityMetadata metadata2 = default(EntityMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					metadata = GetMetadata(LpNhGvoMSI3YB9CiMnte(metadata));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 7;
					}
					continue;
				case 11:
					if (P6parooMVQf2x1cQVDS0(metadata) == EntityMetadataType.Interface)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto default;
				case 10:
					metadata = GetMetadata(eDPt3XoMuuLcr5GMEqw8(propertyMetadata));
					num = 9;
					break;
				case 13:
					if (!forFilter)
					{
						num = 14;
						break;
					}
					goto case 5;
				default:
					if (P6parooMVQf2x1cQVDS0(metadata) == EntityMetadataType.InterfaceExtension)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 5;
				case 6:
					if (!fbDDuboMIPpMu2BHMP7x(entityMetadata))
					{
						num2 = 11;
						continue;
					}
					goto case 5;
				case 2:
					metadata = GetMetadata(metadata2.ImplementationUid);
					num2 = 8;
					continue;
				case 5:
				case 7:
				case 8:
				case 12:
					return (ISyntaxNode)ijXbqOoMK47YBPnefmrO(m2Tb56oMqrKU74SiCJU2(m3YEufoMRx44cG8IMfZV(metadata), gv4C5ioMBnLYWJOgEous(0x48A7E34A ^ 0x48A7A076)));
				case 1:
					metadata2 = GetMetadata(UegQX2oMikBN8Fd8Ioav(metadata));
					num2 = 4;
					continue;
				case 9:
					entityMetadata = classMetadata as EntityMetadata;
					num2 = 13;
					continue;
				case 4:
					if (metadata2 == null)
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 2;
				case 14:
					if (entityMetadata == null)
					{
						num2 = 5;
						continue;
					}
					goto case 6;
				}
				break;
			}
		}
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return new ColumnType(DbType.Binary);
	}

	protected EntityMetadata GetMetadata(Guid subTypeUid)
	{
		return ((EntityMetadata)MetadataServiceContext.Service.GetMetadata(subTypeUid, loadImplementation: false)) ?? throw new Exception((string)twBsgWoMXqEbg9vqLshH(gv4C5ioMBnLYWJOgEous(-576149596 ^ -576048676), subTypeUid));
	}

	public EntityFilterDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static EntityFilterDescriptor()
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
				UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-210725949 ^ -210631303));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				tlbkVIoMTJc57o6gTnWp();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object vmx1KxoyUyljMrwomaHS(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool yOgtfloyYHBmmgY1iroi()
	{
		return etYOb8oyjqnr5C1Fg4Be == null;
	}

	internal static EntityFilterDescriptor KldewooyLROIOdgC9tUD()
	{
		return etYOb8oyjqnr5C1Fg4Be;
	}

	internal static bool OjnDIOoysoAYhaPOsb5n(object P_0)
	{
		return ((IEntityFilter)P_0).IsEmpty();
	}

	internal static Type UHUsDXoycscAkrW4cIsU(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object CcC42aoyzMfBpxHIOu8Q(object P_0, Type P_1, bool P_2)
	{
		return ((MemberInfo)P_0).GetCustomAttributes(P_1, P_2);
	}

	internal static object FW1T7NoMF3tctuDZbUZ2(Type entityType)
	{
		return ModelHelper.GetEntityManager(entityType);
	}

	internal static object gv4C5ioMBnLYWJOgEous(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object dRZcRZoMW3LFPJydCDvJ(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static Type SPh9XioMosjkPOaMp5mD(object P_0)
	{
		return ((FilterForAttribute)P_0).EntityType;
	}

	internal static object d7c2TqoMbpr5JwdjPME5()
	{
		return FetchOptions.All;
	}

	internal static object O3rJgGoMh7wNQOXtWVtD(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object aQOGBeoMGpWwJdPbk1FK(object P_0)
	{
		return Projections.Property((string)P_0);
	}

	internal static object zqF4E8oME4De09xlQGBl(object P_0, object P_1)
	{
		return ((DetachedCriteria)P_0).SetProjection((IProjection)P_1);
	}

	internal static object Gv5dDZoMfWLWKUJ2sX2B(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static Guid PbgRJyoMQBCONX8YkAJN(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object AgiQKUoMChnoduHSXG8W(object P_0, object P_1, object P_2, JoinType P_3)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return ((DetachedCriteria)P_0).CreateCriteria((string)P_1, (string)P_2, P_3);
	}

	internal static object j0XOQJoMviobM7OQp2VX()
	{
		return Projections.Id();
	}

	internal static object HPQsyNoM8cGZbHM2ROFI(object P_0)
	{
		return ((SimpleTypeSettings)P_0).FieldName;
	}

	internal static void yUamiGoMZA2IE0xtx550(object P_0, object P_1)
	{
		((SimpleTypeSettings)P_0).FieldName = (string)P_1;
	}

	internal static Guid eDPt3XoMuuLcr5GMEqw8(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}

	internal static bool fbDDuboMIPpMu2BHMP7x(object P_0)
	{
		return ((ClassMetadata)P_0).IsInterfaceType;
	}

	internal static EntityMetadataType P6parooMVQf2x1cQVDS0(object P_0)
	{
		return ((EntityMetadata)P_0).Type;
	}

	internal static Guid LpNhGvoMSI3YB9CiMnte(object P_0)
	{
		return ((EntityMetadata)P_0).ImplementationUid;
	}

	internal static Guid UegQX2oMikBN8Fd8Ioav(object P_0)
	{
		return ((ClassMetadata)P_0).BaseClassUid;
	}

	internal static object m3YEufoMRx44cG8IMfZV(object P_0)
	{
		return ((ClassMetadata)P_0).FullTypeName;
	}

	internal static object m2Tb56oMqrKU74SiCJU2(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object ijXbqOoMK47YBPnefmrO(object P_0)
	{
		return ((string)P_0).CreateTypeSyntax();
	}

	internal static object twBsgWoMXqEbg9vqLshH(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void tlbkVIoMTJc57o6gTnWp()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
