using System;
using System.Collections.Generic;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.References;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

public class ReferenceOnTypeDescriptor : CLRTypeDescriptor<ReferenceOnType, ReferenceOnTypeSettings>
{
	public const string UID_S = "{70DC1D0B-F44B-44B9-B9E2-DFE9F8B1DBB3}";

	public static readonly Guid UID;

	private static ReferenceOnTypeDescriptor SOijCMom3SBN9v8QsYra;

	public override Guid Uid => UID;

	public override string Name => (string)CHyh54omD1NU2OphFpy7(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787284935));

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	public override bool Visible => false;

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return null;
	}

	public override IDictionary<string, object> Serialize(object obj, [NotNull] ClassMetadata metadata, [NotNull] PropertyMetadata propertyMetadata, EntitySerializationSettings settings)
	{
		if (obj == null)
		{
			return null;
		}
		Contract.ArgumentNotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 0x6F4DB8CD));
		Contract.ArgumentNotNull(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107996852));
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
			ReferenceOnType referenceOnType = (ReferenceOnType)value;
			serializableDictionary[propertyMetadata.Name] = new SerializableDictionary<string, object>
			{
				{
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29254301 ^ -29237503),
					referenceOnType.TypeUid
				},
				{
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70166921),
					referenceOnType.SubTypeUid
				}
			};
		}
		else
		{
			serializableDictionary[propertyMetadata.Name] = null;
		}
		return serializableDictionary;
	}

	public override void Deserialize(object obj, ClassMetadata metadata, PropertyMetadata propertyMetadata, IDictionary<string, object> values)
	{
		if (obj == null || values == null)
		{
			return;
		}
		Contract.ArgumentNotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17ADCCD8 ^ 0x17AD85E6));
		Contract.ArgumentNotNull(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876048387));
		obj = obj.CastAsRealType();
		PropertyInfo property = obj.GetProperty(metadata, propertyMetadata);
		if (!(property == null) && property.CanWrite && values.Count != 0 && values.TryGetValue(propertyMetadata.Name, out var value))
		{
			if (value is string json)
			{
				value = new EntityJsonSerializer().DeserializeJson(json);
			}
			if (value is IDictionary<string, object> dictionary && Guid.TryParse(dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -576133690)].ToString(), out var result) && Guid.TryParse(dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420911524)].ToString(), out var result2))
			{
				property.SetValue(obj, new ReferenceOnType(result, result2));
			}
		}
	}

	public ReferenceOnTypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		bEypilomt3SKHfdwOKyX();
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

	static ReferenceOnTypeDescriptor()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				bEypilomt3SKHfdwOKyX();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				UID = new Guid((string)qS0ZAiomwfrWx1XcpISN(-195614443 ^ -195708793));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static object CHyh54omD1NU2OphFpy7(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool zc8S4SompUny6UkMf0pG()
	{
		return SOijCMom3SBN9v8QsYra == null;
	}

	internal static ReferenceOnTypeDescriptor i1GLuIomanOSsH2IoOnx()
	{
		return SOijCMom3SBN9v8QsYra;
	}

	internal static void bEypilomt3SKHfdwOKyX()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object qS0ZAiomwfrWx1XcpISN(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
