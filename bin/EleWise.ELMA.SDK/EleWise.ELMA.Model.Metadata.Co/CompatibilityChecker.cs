using System.Collections.Generic;
using EleWise.ELMA.Model.Metadata.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata.Components;

internal abstract class CompatibilityChecker<T> : ICompatibilityChecker<T>, ICompatibilityChecker
{
	internal static object mcfclNhWFGeGB9ue8nJw;

	public bool Check(object obj)
	{
		return obj is T;
	}

	public ICollection<string> CheckCompatibility(object old, object @new)
	{
		return CheckCompatibility((T)old, (T)@new);
	}

	public abstract ICollection<string> CheckCompatibility(T old, T @new);

	protected CompatibilityChecker()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool TivvXvhWBJGC03jDxf2X()
	{
		return mcfclNhWFGeGB9ue8nJw == null;
	}

	internal static object i9AOdrhWW2Sv1hDRRuCH()
	{
		return mcfclNhWFGeGB9ue8nJw;
	}
}
