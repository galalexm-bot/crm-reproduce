using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata.Components;

[Component]
internal sealed class DataClassMetadataCompatibilityChecker : CompatibilityChecker<DataClassDependency>
{
	private readonly IDependencyService dependencyService;

	private static DataClassMetadataCompatibilityChecker SkL4rShWo1hKkJ1DfiHk;

	public DataClassMetadataCompatibilityChecker(IDependencyService dependencyService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		xOMfMphWGiEEHWXvqIuK();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.dependencyService = dependencyService;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
			{
				num = 1;
			}
		}
	}

	public override ICollection<string> CheckCompatibility(DataClassDependency old, DataClassDependency @new)
	{
		Contract.NotNull(old, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x20271E03));
		Contract.NotNull(@new, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123638716));
		return dependencyService.CheckDataClassCompatibility(old, @new).Errors;
	}

	internal static void xOMfMphWGiEEHWXvqIuK()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool GZA5BRhWbFDm55vfUjQS()
	{
		return SkL4rShWo1hKkJ1DfiHk == null;
	}

	internal static DataClassMetadataCompatibilityChecker Yg9s3rhWhkugYXplTLqA()
	{
		return SkL4rShWo1hKkJ1DfiHk;
	}
}
