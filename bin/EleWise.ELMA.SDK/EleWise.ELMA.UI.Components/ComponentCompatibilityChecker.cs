using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata.Components;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Components;

[Component]
internal sealed class ComponentCompatibilityChecker : CompatibilityChecker<ComponentSignature>
{
	internal static ComponentCompatibilityChecker WKliLBBZMMdb4qnMqhNR;

	public override ICollection<string> CheckCompatibility(ComponentSignature old, ComponentSignature @new)
	{
		Contract.NotNull(old, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463B0B70));
		Contract.NotNull(@new, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A1640F ^ 0x4A17E35));
		List<InputComputedValue> inputs = @new.Inputs;
		Dictionary<string, InputComputedValue> dictionary = old.Inputs.ToDictionary((InputComputedValue i) => (string)_003C_003Ec.EbS0l9QEZgvZvoljnjZD(i), (InputComputedValue i) => i);
		if (inputs.Count == 0)
		{
			return Array.Empty<string>();
		}
		List<string> list = new List<string>();
		foreach (InputComputedValue item in inputs)
		{
			if (!dictionary.TryGetValue(item.Name, out var value))
			{
				if (item.Required)
				{
					list.Add(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68BAB168), @new.Name, @new.DisplayName, item.Name));
				}
				continue;
			}
			if (item.Nullable != value.Nullable && !item.Nullable && value.Nullable)
			{
				list.Add(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A7692B1), @new.Name, item.Name));
			}
			if (item.RelationType != value.RelationType)
			{
				list.Add(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858952133), @new.Name, item.Name));
			}
			if (item.TypeUid != value.TypeUid || item.SubTypeUid != value.SubTypeUid)
			{
				list.Add(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643719235), @new.Name, item.Name));
			}
			if (value is ActionInputComputedValue actionInputComputedValue && item is ActionInputComputedValue actionInputComputedValue2)
			{
				TypeSignature parameterType = actionInputComputedValue.ParameterType;
				TypeSignature parameterType2 = actionInputComputedValue2.ParameterType;
				if (parameterType.TypeUid != parameterType2.TypeUid || parameterType.SubTypeUid != parameterType2.SubTypeUid)
				{
					list.Add(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1411129521), @new.Name, item.Name));
				}
				if (parameterType.Nullable != parameterType2.Nullable && parameterType.Nullable && !parameterType2.Nullable)
				{
					list.Add(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA592A41 ^ 0xA582DE7), @new.Name, item.Name));
				}
				if (parameterType.RelationType != parameterType2.RelationType)
				{
					list.Add(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852900764), @new.Name, item.Name));
				}
				TypeSignature returnType = actionInputComputedValue.ReturnType;
				TypeSignature returnType2 = actionInputComputedValue2.ReturnType;
				if (returnType.TypeUid != returnType2.TypeUid || returnType.SubTypeUid != returnType2.SubTypeUid)
				{
					list.Add(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7E3B22), @new.Name, item.Name));
				}
				if (returnType.Nullable != returnType2.Nullable && returnType.Nullable && !returnType2.Nullable)
				{
					list.Add(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EA5403C ^ 0x4EA44A32), @new.Name, item.Name));
				}
				if (returnType.RelationType != returnType2.RelationType)
				{
					list.Add(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538455308), @new.Name, item.Name));
				}
			}
		}
		return list;
	}

	public ComponentCompatibilityChecker()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		k6Y3b5BZdHxI3LgkgbvD();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void k6Y3b5BZdHxI3LgkgbvD()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool mlod3ZBZJeyIjc4eASSV()
	{
		return WKliLBBZMMdb4qnMqhNR == null;
	}

	internal static ComponentCompatibilityChecker uZ0qGmBZ9dkvNRNgmvkJ()
	{
		return WKliLBBZMMdb4qnMqhNR;
	}
}
