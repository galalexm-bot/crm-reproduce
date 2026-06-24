using System.Collections.Generic;
using System.Linq;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Dependencies;

public sealed class CompatibilityResult
{
	private static CompatibilityResult ztYKgDhiHsKjo8SJNw1M;

	public bool IsValid { get; }

	public string[] Errors { get; }

	public CompatibilityResult(bool success, params string[] errors)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Yu7kOThixDwmVn8LYBme();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				IsValid = success;
				num = 2;
				break;
			case 2:
				Errors = errors;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public CompatibilityResult(bool success, IEnumerable<string> errors)
	{
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(success, errors.ToArray());
	}

	public static CompatibilityResult Ok()
	{
		return new CompatibilityResult(true);
	}

	public static CompatibilityResult Error(IEnumerable<string> errors)
	{
		return new CompatibilityResult(success: false, errors);
	}

	public static CompatibilityResult Error(params string[] errors)
	{
		return new CompatibilityResult(success: false, errors);
	}

	internal static void Yu7kOThixDwmVn8LYBme()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool tr5onchiAjiURZ1kPxOX()
	{
		return ztYKgDhiHsKjo8SJNw1M == null;
	}

	internal static CompatibilityResult sZwSCehi7aMLssbr7iPA()
	{
		return ztYKgDhiHsKjo8SJNw1M;
	}
}
