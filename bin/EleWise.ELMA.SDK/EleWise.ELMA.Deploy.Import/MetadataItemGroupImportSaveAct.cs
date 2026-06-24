using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import;

public class MetadataItemGroupImportSaveActions : EntityImportSaveActions
{
	public static readonly Guid UID;

	private static MetadataItemGroupImportSaveActions Sbxhm4EyGrk9fqcGePcD;

	public override bool IsSupported(Guid typeGuid)
	{
		return bP8mZMEyQlNVcNL85HAJ(typeGuid, UID);
	}

	public override bool CanBeSaved(Dictionary<string, object> propValues, ImportEntityCanBeSavedData data)
	{
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
		_003C_003Ec__DisplayClass2_.data = data;
		Guid result = Guid.Empty;
		if (propValues.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C9495B4 ^ 0x1C940582)) && propValues[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852874190)] != null)
		{
			Guid.TryParse(((SerializableDictionary<string, object>)propValues[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7EC8509)])[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978482848)].ToString(), out result);
		}
		if (result != Guid.Empty)
		{
			_003C_003Ec__DisplayClass2_1 _003C_003Ec__DisplayClass2_2 = new _003C_003Ec__DisplayClass2_1();
			_003C_003Ec__DisplayClass2_2.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass2_;
			_003C_003Ec__DisplayClass2_2.keyString = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E6D69A) + result;
			if (_003C_003Ec__DisplayClass2_2.CS_0024_003C_003E8__locals1.data.ServiceData.ContainsKey(_003C_003Ec__DisplayClass2_2.keyString) && !Guid.TryParse(_003C_003Ec__DisplayClass2_2.CS_0024_003C_003E8__locals1.data.ServiceData[_003C_003Ec__DisplayClass2_2.keyString], out var _))
			{
				IEntityManager<IMetadataItemGroup> instance = EntityManager<IMetadataItemGroup>.Instance;
				ParameterExpression parameterExpression = Expression.Parameter(typeof(IMetadataItemGroup), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106466236));
				List<IMetadataItemGroup> list = instance.Find(Expression.Lambda<Func<IMetadataItemGroup, bool>>(Expression.Equal(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Call(Expression.Property(Expression.Field(Expression.Field(Expression.Constant(_003C_003Ec__DisplayClass2_2, typeof(_003C_003Ec__DisplayClass2_1)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(Dictionary<string, string>).TypeHandle), Expression.Field(Expression.Constant(_003C_003Ec__DisplayClass2_2, typeof(_003C_003Ec__DisplayClass2_1)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)))), new ParameterExpression[1] { parameterExpression })).ToList();
				if (list.Count > 0 && list[0] != null)
				{
					((SerializableDictionary<string, object>)propValues[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x36306357)])[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x36309CF3)] = list[0].Uid.ToString();
				}
			}
		}
		return true;
	}

	public MetadataItemGroupImportSaveActions()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		hdm9tqEyCaM1jlCHf0jL();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static MetadataItemGroupImportSaveActions()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				UID = new Guid((string)ywuGPJEyvKobvidd3Yi9(0x103FE975 ^ 0x103B444D));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return;
			case 1:
				hdm9tqEyCaM1jlCHf0jL();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool bP8mZMEyQlNVcNL85HAJ(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool J3dNUSEyEPJCnwk2LSYq()
	{
		return Sbxhm4EyGrk9fqcGePcD == null;
	}

	internal static MetadataItemGroupImportSaveActions YywwvmEyfo91TG7OFlrm()
	{
		return Sbxhm4EyGrk9fqcGePcD;
	}

	internal static void hdm9tqEyCaM1jlCHf0jL()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object ywuGPJEyvKobvidd3Yi9(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
