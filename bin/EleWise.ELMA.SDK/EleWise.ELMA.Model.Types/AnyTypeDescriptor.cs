using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.Models.API;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Db;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

public class AnyTypeDescriptor : TypeDescriptor
{
	public const string UID_S = "{C77CD813-1DFB-4777-AB7E-87B54BD09E38}";

	public static readonly Guid UID;

	internal static AnyTypeDescriptor GNsS9RoJKdPt3X2kqUgR;

	[EditorBrowsable(EditorBrowsableState.Never)]
	[XmlIgnore]
	public DataClassDescriptor DataClassDescriptor
	{
		[CompilerGenerated]
		get
		{
			return _003CDataClassDescriptor_003Ek__BackingField;
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
					_003CDataClassDescriptor_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
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

	public override Guid Uid => UID;

	public override string Name => (string)RZtpYZoJna8OX13dADSS(DV7wkioJkQxNx44j3T71(-1867198571 ^ -1867098511));

	public override bool CanBeNullable => false;

	public override bool? DefaultNullableValue => null;

	public override Type SettingsType => j9mdDFoJOdS1Rb39BphS(typeof(AnyTypeSettings).TypeHandle);

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	public override bool UseForEntity => false;

	public override IEnumerable<ITypeDescriptor> GetSubTypes(ClassMetadata classMetadata)
	{
		return null;
	}

	public override ISyntaxNode GetPropertyTypeReference(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				y5VU4eoJ2fLRpJjFLbK3(BmqX72oJeyuJMi2FWbFg(propertyMetadata), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420898064));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				y5VU4eoJ2fLRpJjFLbK3(propertyMetadata, DV7wkioJkQxNx44j3T71(0x26FFCB59 ^ 0x26FF820B));
				num2 = 2;
				break;
			default:
				return (ISyntaxNode)kpM2AgoJ1VieBxf0Q3JW(((AnyTypeSettings)BmqX72oJeyuJMi2FWbFg(propertyMetadata)).FullTypeName);
			case 1:
				sgKyBMoJP3c2IABoghAr(BmqX72oJeyuJMi2FWbFg(propertyMetadata) is AnyTypeSettings, DV7wkioJkQxNx44j3T71(0x3630F361 ^ 0x36326969));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override string GetPropertyTypeDisplayName(PropertyMetadata propertyMetadata)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				Contract.CheckArgument(BmqX72oJeyuJMi2FWbFg(propertyMetadata) is AnyTypeSettings, (string)DV7wkioJkQxNx44j3T71(-1638402543 ^ -1638568935));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				Contract.ArgumentNotNull(propertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A635868));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return (string)RZtpYZoJna8OX13dADSS(NOD6b0oJNcu3GtijpuMB((AnyTypeSettings)BmqX72oJeyuJMi2FWbFg(propertyMetadata)));
			case 3:
				y5VU4eoJ2fLRpJjFLbK3(propertyMetadata, DV7wkioJkQxNx44j3T71(-3333094 ^ -3314360));
				num2 = 2;
				break;
			}
		}
	}

	public override ISyntaxNode GetPropertyInitExpression(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		return null;
	}

	public override IPropertyDefaultValueContainer GetDefaultContainer(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		return new PropertyAnyTypeValueContainer(propertyMetadata);
	}

	public override TypeDbStructures GetDbStructures(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		throw new NotImplementedException();
	}

	public override bool ApplyDbChanges(IDbModelUpdater updater, EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata, EntityPropertyMetadata oldPropertyMetadata)
	{
		throw new NotImplementedException();
	}

	public override object SerializeSimple(object value, Type valueType, EntitySerializationSettings settings)
	{
		//Discarded unreachable code: IL_004d, IL_005c, IL_0087, IL_0102, IL_0111
		int num = 6;
		SerializableDictionary<string, object> result2 = default(SerializableDictionary<string, object>);
		SerializableList<object> result = default(SerializableList<object>);
		Type type = default(Type);
		DataClass dataClass = default(DataClass);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					return result2;
				case 2:
					if ((result = value as SerializableList<object>) != null)
					{
						num2 = 7;
						break;
					}
					return base.SerializeSimple(value, valueType, settings);
				case 10:
					if (!cxsJbEoJ3lIul7TqYWnn(type, TypeOf<EleWise.ELMA.Common.Models.WebData>.Raw))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto default;
				case 3:
					return ((EleWise.ELMA.Common.Models.API.WebData)value).ToDictionary();
				case 7:
					return result;
				case 5:
					return null;
				default:
					return EleWise.ELMA.Common.Models.API.WebData.Create((EleWise.ELMA.Common.Models.WebData)value).ToDictionary();
				case 1:
					if (!cxsJbEoJ3lIul7TqYWnn(type, TypeOf<EleWise.ELMA.Common.Models.API.WebData>.Raw))
					{
						if ((object)(dataClass = value as DataClass) == null)
						{
							num2 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
							{
								num2 = 4;
							}
							break;
						}
						goto case 9;
					}
					num2 = 3;
					break;
				case 9:
					return SADCdBoJpVlIuPmLHgNu(DataClassDescriptor, dataClass, valueType, settings);
				case 4:
					if ((result2 = value as SerializableDictionary<string, object>) == null)
					{
						num2 = 2;
						break;
					}
					goto case 8;
				case 6:
					if (value != null)
					{
						type = value.GetType();
						num = 10;
						goto end_IL_0012;
					}
					num2 = 5;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
		}
	}

	public AnyTypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Wr4y1moJapAoFipOGf1Y();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static AnyTypeDescriptor()
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
				Wr4y1moJapAoFipOGf1Y();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				UID = new Guid((string)DV7wkioJkQxNx44j3T71(-643786247 ^ -643693667));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool SKHgMioJX15KdJbF7elc()
	{
		return GNsS9RoJKdPt3X2kqUgR == null;
	}

	internal static AnyTypeDescriptor Myv6rVoJTiMD6Kf38Jfn()
	{
		return GNsS9RoJKdPt3X2kqUgR;
	}

	internal static object DV7wkioJkQxNx44j3T71(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object RZtpYZoJna8OX13dADSS(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static Type j9mdDFoJOdS1Rb39BphS(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void y5VU4eoJ2fLRpJjFLbK3(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object BmqX72oJeyuJMi2FWbFg(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static void sgKyBMoJP3c2IABoghAr(bool condition, object P_1)
	{
		Contract.CheckArgument(condition, (string)P_1);
	}

	internal static object kpM2AgoJ1VieBxf0Q3JW(object P_0)
	{
		return ((string)P_0).CreateTypeSyntax();
	}

	internal static object NOD6b0oJNcu3GtijpuMB(object P_0)
	{
		return ((AnyTypeSettings)P_0).FullTypeName;
	}

	internal static bool cxsJbEoJ3lIul7TqYWnn(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object SADCdBoJpVlIuPmLHgNu(object P_0, object P_1, Type valueType, object P_3)
	{
		return ((TypeDescriptor)P_0).SerializeSimple(P_1, valueType, (EntitySerializationSettings)P_3);
	}

	internal static void Wr4y1moJapAoFipOGf1Y()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
