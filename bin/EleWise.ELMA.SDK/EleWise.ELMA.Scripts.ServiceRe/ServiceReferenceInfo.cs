using System.Collections.Generic;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Scripts.ServiceReference.Models;

public sealed class ServiceReferenceInfo
{
	private static ServiceReferenceInfo NyEHmQWBZHusRcpLSGyV;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return _003CName_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<string> MethodNames { get; set; }

	public ServiceReferenceInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ap3WJMWBVFeyZk3nMSBB();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
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
			MethodNames = new List<string>();
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
			{
				num = 0;
			}
		}
	}

	internal static void ap3WJMWBVFeyZk3nMSBB()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool EkCcCxWBu6N2PGXobBQu()
	{
		return NyEHmQWBZHusRcpLSGyV == null;
	}

	internal static ServiceReferenceInfo c67Fg5WBIiChTcOMf7d3()
	{
		return NyEHmQWBZHusRcpLSGyV;
	}
}
