using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Models;

public sealed class ValidationResult
{
	internal static ValidationResult HgdH8qBb25JXOFpcaNdi;

	public bool IsValid { get; }

	public ValidationError[] Errors { get; }

	public ValidationResult(bool success, params ValidationError[] errors)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		S8i6doBb1HBiWiTBB5xy();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
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
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public ValidationResult(bool success, IEnumerable<ValidationError> errors)
	{
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(success, errors.ToArray());
	}

	internal static void S8i6doBb1HBiWiTBB5xy()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool jYKgKkBbe5tXajUeDTyL()
	{
		return HgdH8qBb25JXOFpcaNdi == null;
	}

	internal static ValidationResult kbHYoYBbPpFhZnvol5ek()
	{
		return HgdH8qBb25JXOFpcaNdi;
	}
}
