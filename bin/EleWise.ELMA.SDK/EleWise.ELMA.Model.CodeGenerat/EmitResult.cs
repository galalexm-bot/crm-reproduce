using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.CodeGeneration;

[Serializable]
public class EmitResult
{
	internal static EmitResult u3mPMChe252KDogZk1i5;

	public bool Success
	{
		[CompilerGenerated]
		get
		{
			return _003CSuccess_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CSuccess_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IEnumerable<Diagnostic> Diagnostics { get; private set; }

	private EmitResult()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static EmitResult SuccessResult(IEnumerable<Diagnostic> diagnostics = null)
	{
		return new EmitResult
		{
			Success = true,
			Diagnostics = (diagnostics ?? Enumerable.Empty<Diagnostic>())
		};
	}

	internal static EmitResult ErrorResult(IEnumerable<Diagnostic> diagnostics)
	{
		return new EmitResult
		{
			Success = false,
			Diagnostics = diagnostics
		};
	}

	internal static bool alNPO7heexMwdeRMVbnu()
	{
		return u3mPMChe252KDogZk1i5 == null;
	}

	internal static EmitResult JfuHpjhePWWbYT61iOHe()
	{
		return u3mPMChe252KDogZk1i5;
	}
}
