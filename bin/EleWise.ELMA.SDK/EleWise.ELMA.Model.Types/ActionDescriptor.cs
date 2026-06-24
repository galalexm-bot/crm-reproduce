using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

[Component(Order = 900)]
public sealed class ActionDescriptor : CLRTypeDescriptor<object, ActionSettings>
{
	public const string UID_S = "{BF9C9728-A0F8-46F4-AB87-7C1F8DDE427C}";

	public static readonly Guid UID;

	internal static ActionDescriptor fu1hLeo49K15nkK7HniF;

	public override Guid Uid => UID;

	public override string Name => (string)vyPNLyo4gKqdqksSOh6k(akgoQNo4rRk5vhUwjII1(0x4EA5403C ^ 0x4EA5100E));

	public override bool Visible => false;

	public override bool IsRuntimeType => false;

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return null;
	}

	public override IDictionary<string, object> Serialize(object obj, ClassMetadata metadata, PropertyMetadata propertyMetadata, EntitySerializationSettings settings)
	{
		return null;
	}

	public override object SerializeSimple(object value)
	{
		return null;
	}

	public override void Deserialize(object obj, ClassMetadata metadata, PropertyMetadata propertyMetadata, IDictionary<string, object> values)
	{
	}

	public override object DeserializeSimple(object value, Type deserializeToType)
	{
		return null;
	}

	public ActionDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		lUeNrFo45uVuVvj1MuEs();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ActionDescriptor()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				lUeNrFo45uVuVvj1MuEs();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				UID = new Guid((string)akgoQNo4rRk5vhUwjII1(0x42643203 ^ 0x42664939));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object akgoQNo4rRk5vhUwjII1(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object vyPNLyo4gKqdqksSOh6k(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool TtX53Jo4dC9Fakq49h8c()
	{
		return fu1hLeo49K15nkK7HniF == null;
	}

	internal static ActionDescriptor MfJBWVo4lHtZeTJOAxLP()
	{
		return fu1hLeo49K15nkK7HniF;
	}

	internal static void lUeNrFo45uVuVvj1MuEs()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
