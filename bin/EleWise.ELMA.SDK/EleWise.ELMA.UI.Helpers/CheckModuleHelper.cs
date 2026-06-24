using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.UI.Models;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Helpers;

internal static class CheckModuleHelper
{
	internal static CheckModuleHelper DhFJcHB8UrcpvG5wki5X;

	public static CompatibilityResult CheckSignatures(ModuleDependency dependency, ModuleSignature signature, Guid moduleUid)
	{
		//Discarded unreachable code: IL_0091, IL_00a0
		int num = 1;
		int num2 = num;
		CompatibilityResult compatibilityResult2 = default(CompatibilityResult);
		CompatibilityResult compatibilityResult = default(CompatibilityResult);
		CompatibilityResult compatibilityResult3 = default(CompatibilityResult);
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = default(_003C_003Ec__DisplayClass0_0);
		while (true)
		{
			switch (num2)
			{
			case 6:
				if (!compatibilityResult2.IsValid)
				{
					num2 = 5;
					break;
				}
				return (CompatibilityResult)fuZYgfBZFaDNkKZ8woow();
			case 7:
				return compatibilityResult;
			case 3:
				compatibilityResult3 = CheckDataClasses(dependency.DataClasses.Where(_003C_003Ec__DisplayClass0_._003CCheckSignatures_003Eb__1), signature.DataClasses);
				num2 = 9;
				break;
			case 5:
				return compatibilityResult2;
			default:
				_003C_003Ec__DisplayClass0_.moduleUid = moduleUid;
				num2 = 8;
				break;
			case 4:
				return compatibilityResult3;
			case 9:
				if (M1MCkxB8zMiU9sj5qTDl(compatibilityResult3))
				{
					compatibilityResult2 = CheckFunctions(dependency.Functions.Where(_003C_003Ec__DisplayClass0_._003CCheckSignatures_003Eb__2), signature.Functions);
					num2 = 6;
				}
				else
				{
					num2 = 4;
				}
				break;
			case 8:
				compatibilityResult = CheckComponents(dependency.Components.Where(_003C_003Ec__DisplayClass0_._003CCheckSignatures_003Eb__0), signature.Components);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				if (M1MCkxB8zMiU9sj5qTDl(compatibilityResult))
				{
					num2 = 3;
					break;
				}
				goto case 7;
			case 1:
				_003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static CompatibilityResult CheckComponents(IEnumerable<ComponentDependency> dependencies, IEnumerable<ComponentSignature> signatureList)
	{
		Dictionary<Guid, ComponentSignature> dictionary = signatureList.ToDictionary((ComponentSignature s) => _003C_003Ec.l0f4MqQGac4tGr3Yx0TF(s), (ComponentSignature s) => s);
		foreach (ComponentDependency dependency in dependencies)
		{
			Guid headerUid = dependency.HeaderUid;
			if (!dictionary.ContainsKey(headerUid))
			{
				return CompatibilityResult.Error(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53FAFA52), dependency.DisplayName, dependency.ModuleUid));
			}
			ValidationResult validationResult = CheckComponentHelper.CheckSignature(dependency, dictionary[headerUid]);
			if (!validationResult.IsValid)
			{
				return CompatibilityResult.Error(validationResult.Errors.Select((ValidationError a) => (string)_003C_003Ec.BVt3lqQGDv438k65ELMZ(a)));
			}
		}
		return CompatibilityResult.Ok();
	}

	private static CompatibilityResult CheckDataClasses(IEnumerable<DataClassDependency> dependencies, IEnumerable<DataClassDependency> signatureList)
	{
		Dictionary<Guid, DataClassDependency> dictionary = signatureList.ToDictionary((DataClassDependency s) => _003C_003Ec.l0f4MqQGac4tGr3Yx0TF(s), (DataClassDependency s) => s);
		foreach (DataClassDependency dependency in dependencies)
		{
			Guid headerUid = dependency.HeaderUid;
			if (!dictionary.ContainsKey(headerUid))
			{
				return CompatibilityResult.Error(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7ECEE3F), dependency.DisplayName, dependency.ModuleUid));
			}
			CompatibilityResult compatibilityResult = dependency.Compatible(dictionary[headerUid]);
			if (!compatibilityResult.IsValid)
			{
				return compatibilityResult;
			}
		}
		return CompatibilityResult.Ok();
	}

	private static CompatibilityResult CheckFunctions(IEnumerable<FunctionDependency> dependencies, IEnumerable<FunctionDependency> signatureList)
	{
		Dictionary<Guid, FunctionDependency> dictionary = signatureList.ToDictionary((FunctionDependency s) => _003C_003Ec.l0f4MqQGac4tGr3Yx0TF(s), (FunctionDependency s) => s);
		foreach (FunctionDependency dependency in dependencies)
		{
			Guid headerUid = dependency.HeaderUid;
			if (!dictionary.ContainsKey(headerUid))
			{
				return CompatibilityResult.Error(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606614888), dependency.DisplayName, dependency.ModuleUid));
			}
			CompatibilityResult compatibilityResult = dependency.Compatible(dictionary[headerUid]);
			if (!compatibilityResult.IsValid)
			{
				return compatibilityResult;
			}
		}
		return CompatibilityResult.Ok();
	}

	internal static bool M1MCkxB8zMiU9sj5qTDl(object P_0)
	{
		return ((CompatibilityResult)P_0).IsValid;
	}

	internal static object fuZYgfBZFaDNkKZ8woow()
	{
		return CompatibilityResult.Ok();
	}

	internal static bool hYuIT6B8sQDCfvlH7wgl()
	{
		return DhFJcHB8UrcpvG5wki5X == null;
	}

	internal static CheckModuleHelper l0lDFAB8c1ekYNeAaK7u()
	{
		return DhFJcHB8UrcpvG5wki5X;
	}
}
