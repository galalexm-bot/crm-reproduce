using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Nullifier;

public class ClearObjectParameters
{
	public Func<EntityMetadata, bool> CheckAndDeleteCildMetadate;

	public Func<EntityMetadata, string, bool, int, bool, bool> DeleteEntityMetadata;

	public Func<UnitNullConfig, string, bool, int, bool, bool> DeleteEntityMetadataUnit;

	public Func<Guid, int, bool, bool> DeleteFolder;

	public Func<string, string, bool> SqlQuery;

	public Func<string, string, bool> ExecuteQuery;

	public string tempTableNameProject;

	public List<UnitNullConfig> units;

	public ITransformationProvider Transform;

	public Func<string, bool> AddLog;

	internal static ClearObjectParameters bLidKn23oCpOGdQGQYG;

	public ClearObjectParameters()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool gq5vWX2pAaVSBEVI0Ue()
	{
		return bLidKn23oCpOGdQGQYG == null;
	}

	internal static ClearObjectParameters VdvHlv2aINB4nkSEgVQ()
	{
		return bLidKn23oCpOGdQGQYG;
	}
}
