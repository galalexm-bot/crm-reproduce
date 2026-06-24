using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Deploy.Import;

public class FormHeaderImportSaveActions : EntityImportSaveActions
{
	public static readonly Guid UID;

	private static FormHeaderImportSaveActions pYZlNa3TZg66l6a1cLS;

	public override bool IsSupported(Guid typeGuid)
	{
		return iLP3pZ3r927Nd2hQSpe(typeGuid, UID);
	}

	public override bool CanBeSaved(Dictionary<string, object> propValues, ImportEntityCanBeSavedData data)
	{
		ParameterExpression parameterExpression = Expression.Parameter(typeof(IFormMetadataItemHeader), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-426925384 ^ -426944266));
		string key = LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemHeader, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression }));
		if (propValues.ContainsKey(key) && propValues[key] != null)
		{
			EleWise.ELMA.Security.Models.IUser user = UserManager.Instance.LoadOrNull(SecurityConstants.AdminUserUid);
			if (user != null)
			{
				propValues[key] = user.Id;
			}
		}
		return true;
	}

	public FormHeaderImportSaveActions()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		MGJgNV339hXm6DJn8r9();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c9893e65c104705bb8b228f8a38d9cd == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static FormHeaderImportSaveActions()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				UID = new Guid((string)NRCHJw3yuvFxY2XKhfT(0x4BBFF2C6 ^ 0x4BBF0892));
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0b98d9f52b424149868b80d852714a70 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				MGJgNV339hXm6DJn8r9();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_73b92e1f752f422d899693d4318e4486 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool iLP3pZ3r927Nd2hQSpe(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool W2XRo83gnrB87acp3I3()
	{
		return pYZlNa3TZg66l6a1cLS == null;
	}

	internal static FormHeaderImportSaveActions DIOX3m38u2y7Ue9SodJ()
	{
		return pYZlNa3TZg66l6a1cLS;
	}

	internal static void MGJgNV339hXm6DJn8r9()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static object NRCHJw3yuvFxY2XKhfT(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
