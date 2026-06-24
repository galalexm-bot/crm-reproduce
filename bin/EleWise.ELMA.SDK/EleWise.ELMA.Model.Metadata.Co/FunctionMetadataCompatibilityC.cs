using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Dependencies;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata.Components;

[Component]
internal sealed class FunctionMetadataCompatibilityChecker : CompatibilityChecker<FunctionDependency>
{
	private static FunctionMetadataCompatibilityChecker dRdASFhWESA61D2FiMUy;

	public override ICollection<string> CheckCompatibility(FunctionDependency old, FunctionDependency @new)
	{
		Contract.NotNull(old, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A5D5EF ^ 0x3A4D1A3));
		Contract.NotNull(@new, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426094279 ^ -1426088701));
		List<string> list = new List<string>();
		CompatibilityResult compatibilityResult = old.ParameterType.Compatible(@new.ParameterType);
		if (!compatibilityResult.IsValid)
		{
			list.Add(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234094682), @new.DisplayName));
			list.AddRange(compatibilityResult.Errors);
		}
		CompatibilityResult compatibilityResult2 = old.ReturnType.Compatible(@new.ReturnType);
		if (!compatibilityResult2.IsValid)
		{
			list.Add(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675301145), @new.DisplayName));
			list.AddRange(compatibilityResult2.Errors);
		}
		return list;
	}

	public FunctionMetadataCompatibilityChecker()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		z69HJnhWCNYhQiNhDvLU();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void z69HJnhWCNYhQiNhDvLU()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool SWErQshWfVReNkUB3a8P()
	{
		return dRdASFhWESA61D2FiMUy == null;
	}

	internal static FunctionMetadataCompatibilityChecker yWS2xnhWQPBtyftQ3qFh()
	{
		return dRdASFhWESA61D2FiMUy;
	}
}
