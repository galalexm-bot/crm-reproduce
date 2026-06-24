using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Security.Diagrams;
using EleWise.ELMA.Security.Types.Settings;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Types;

public class OrganizationDiagramTypeDescriptor : CLRTypeDescriptor<OrganizationDiagram, OrganizationDiagramTypeSettings>
{
	public const string UID_S = "{C977BD31-07D1-4BA2-AB9C-5049D363A923}";

	public static readonly Guid UID;

	internal static OrganizationDiagramTypeDescriptor N6pVdmZqga2NFeA0I2j;

	public override Guid Uid => UID;

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	public override string Name => (string)NwRHfUZ0x3o5qDeKb9K(JX0NUmZFCQoEsqvv5I0(0x201ABE6B ^ 0x201A80BF));

	public override bool Visible
	{
		get
		{
			//Discarded unreachable code: IL_0056, IL_0065
			int num = 2;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						if (!tJeb2tZEasxqlM7lyLe(this))
						{
							num2 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_364662b38d3b4bdb9f3f1f11b8889cdc == 0)
							{
								num2 = 1;
							}
							break;
						}
						goto default;
					default:
						if (MetadataAccessInfo.EnvironmentType == MetadataEnvironmentType.VisualStudio)
						{
							return true;
						}
						goto end_IL_0012;
					case 3:
						return MetadataAccessInfo.EnvironmentType == MetadataEnvironmentType.DevServer;
					case 1:
						return false;
					}
					continue;
					end_IL_0012:
					break;
				}
				num = 3;
			}
		}
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return new ColumnType(DbType.Binary);
	}

	public override IDictionary<string, object> Serialize(object obj, ClassMetadata metadata, PropertyMetadata propertyMetadata, EntitySerializationSettings serializationSettings)
	{
		if (obj == null)
		{
			return null;
		}
		if (metadata == null)
		{
			throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x50A2A0A3 ^ 0x50A29FA7));
		}
		if (propertyMetadata == null)
		{
			throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4BBFF2C6 ^ 0x4BBFCDDE));
		}
		obj = obj.CastAsRealType();
		PropertyInfo property = obj.GetProperty(metadata, propertyMetadata);
		if (property == null || !property.CanRead)
		{
			return null;
		}
		object value = property.GetValue(obj, null);
		SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>();
		if (value != null)
		{
			serializableDictionary[propertyMetadata.Name] = value;
		}
		return serializableDictionary;
	}

	public OrganizationDiagramTypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		GSO2R0ZDdQ58d7Qghk3();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0d00d0d8fcd5481b8bdc09ec82b1ea36 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static OrganizationDiagramTypeDescriptor()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				UID = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x9D1442B ^ 0x9D17B17));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae9e5ed1f04543cd9a3ea633dd768889 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object JX0NUmZFCQoEsqvv5I0(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object NwRHfUZ0x3o5qDeKb9K(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool t9St3CZcVxbYyZn3Q06()
	{
		return N6pVdmZqga2NFeA0I2j == null;
	}

	internal static OrganizationDiagramTypeDescriptor EZYfuCZGS2RXAVuOGq0()
	{
		return N6pVdmZqga2NFeA0I2j;
	}

	internal static bool tJeb2tZEasxqlM7lyLe(object P_0)
	{
		return ((TypeDescriptor)P_0).Visible;
	}

	internal static void GSO2R0ZDdQ58d7Qghk3()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
