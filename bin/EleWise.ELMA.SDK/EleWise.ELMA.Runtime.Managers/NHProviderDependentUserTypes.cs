using System;
using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using NHibernate.UserTypes;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Managers;

internal static class NHProviderDependentUserTypes
{
	private static readonly Dictionary<Type, Type> cache;

	internal static NHProviderDependentUserTypes d5V2E8WMf3Gs9t6nDifv;

	public static void Register<TBaseType, TImplType>()
	{
		cache[typeof(TBaseType)] = typeof(TImplType);
	}

	public static Type Get<TBaseType>()
	{
		return cache[typeof(TBaseType)];
	}

	public static IUserType GetInstance<TBaseType>() where TBaseType : IUserType
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		Type type = Get<TBaseType>();
		if (type == null)
		{
			throw new ArgumentException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34185E55 ^ 0x341A71C3), typeof(TBaseType).FullName));
		}
		return (IUserType)Activator.CreateInstance(type);
	}

	static NHProviderDependentUserTypes()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				DmJ9xZWMvUGDv4WHCIen();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				cache = new Dictionary<Type, Type>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void DmJ9xZWMvUGDv4WHCIen()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool DtyAXTWMQWfyMWFuuMgc()
	{
		return d5V2E8WMf3Gs9t6nDifv == null;
	}

	internal static NHProviderDependentUserTypes KEQuahWMCRLBOGKV3U4m()
	{
		return d5V2E8WMf3Gs9t6nDifv;
	}
}
