using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Convertors;

[Component]
public abstract class TypeConvertor : ITypeConvertor
{
	private static TypeConvertor AlasnSojaja2YravE9vF;

	public abstract List<Guid> SourceTypeUids { get; }

	public abstract List<Guid> TargetTypeUids { get; }

	public abstract object DoConvert(object obj);

	protected TypeConvertor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool HBthm9ojDARH8Gsw3t9l()
	{
		return AlasnSojaja2YravE9vF == null;
	}

	internal static TypeConvertor mR1mBcojtUUcFrFL1Mal()
	{
		return AlasnSojaja2YravE9vF;
	}
}
