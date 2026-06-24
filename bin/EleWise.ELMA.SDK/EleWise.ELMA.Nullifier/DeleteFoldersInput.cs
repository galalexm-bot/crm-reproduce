using System;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Nullifier;

public class DeleteFoldersInput
{
	public Guid uid;

	public int level;

	public ITransformationProvider transform;

	public Func<string, string, bool> sqlQuery;

	public Func<string, string, bool> ExecuteQuery;

	public bool ClearFolderOnly;

	internal static DeleteFoldersInput pOZ3Ow2Dfe7kVrobb5w;

	public DeleteFoldersInput()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool xmcWaJ2tx84BCpC1uuD()
	{
		return pOZ3Ow2Dfe7kVrobb5w == null;
	}

	internal static DeleteFoldersInput OnAhpD2wCyCYU7pcVtH()
	{
		return pOZ3Ow2Dfe7kVrobb5w;
	}
}
