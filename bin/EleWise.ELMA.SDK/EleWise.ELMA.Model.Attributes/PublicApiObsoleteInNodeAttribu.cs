using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = true)]
public class PublicApiObsoleteInNodeAttribute : Attribute
{
	private readonly string parentPath;

	private readonly string message;

	private readonly bool throwError;

	internal static PublicApiObsoleteInNodeAttribute LVUW1yoQhyqlfSN80cfd;

	public string Message => message;

	public bool ThrowError => throwError;

	public string ParentPath => parentPath;

	public PublicApiObsoleteInNodeAttribute(string parentPath)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(parentPath, null);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public PublicApiObsoleteInNodeAttribute(string parentPath, string message)
	{
		//Discarded unreachable code: IL_002d, IL_0032
		YetIXloQfNs6m0In9dAo();
		this._002Ector(parentPath, message, throwError: false);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public PublicApiObsoleteInNodeAttribute(string parentPath, string message, bool throwError)
	{
		//Discarded unreachable code: IL_001e
		YetIXloQfNs6m0In9dAo();
		base._002Ector();
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				this.throwError = throwError;
				num2 = 2;
				break;
			case 3:
				this.parentPath = parentPath;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				this.message = message;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static bool Gm0sRKoQGL48Z0JrrcBu()
	{
		return LVUW1yoQhyqlfSN80cfd == null;
	}

	internal static PublicApiObsoleteInNodeAttribute zFC7yRoQEPpxKryPD7pe()
	{
		return LVUW1yoQhyqlfSN80cfd;
	}

	internal static void YetIXloQfNs6m0In9dAo()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
