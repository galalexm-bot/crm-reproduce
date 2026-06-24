using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.API.Models;

[Serializable]
[DataContract]
[KnownType("GetPackageKnownTypes")]
public abstract class PackageBase
{
	private static readonly object packageKnownTypesLocker;

	private static Type[] packageKnownTypes;

	internal static PackageBase DvpCc0fNK3CZAwYxNKPT;

	[DataMember]
	public Guid ServiceUid
	{
		[CompilerGenerated]
		get
		{
			return _003CServiceUid_003Ek__BackingField;
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
					_003CServiceUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember]
	public Guid TypeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CTypeUid_003Ek__BackingField;
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
					_003CTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Obsolete("Этот конструктор предназначен только для десериализации.", true)]
	public PackageBase()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		jPoHr8fNkXmQJmlpOVhi();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public PackageBase(Guid serviceUid, Guid typeUid)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				TypeUid = typeUid;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num = 0;
				}
				break;
			default:
				ServiceUid = serviceUid;
				num = 2;
				break;
			case 1:
				return;
			}
		}
	}

	private static IEnumerable<Type> GetPackageKnownTypes()
	{
		if (packageKnownTypes != null)
		{
			return packageKnownTypes;
		}
		lock (packageKnownTypesLocker)
		{
			if (packageKnownTypes != null)
			{
				return packageKnownTypes;
			}
			packageKnownTypes = new Type[2]
			{
				typeof(DeletedIdsPackage),
				typeof(UpdateIdPackage)
			}.Union(ComponentManager.Current.GetExtensionPoints<IUpdatePackageService>().SelectMany((IUpdatePackageService s) => s.KnownTypes(null))).ToArray();
			return packageKnownTypes;
		}
	}

	static PackageBase()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				jPoHr8fNkXmQJmlpOVhi();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				packageKnownTypesLocker = new object();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static void jPoHr8fNkXmQJmlpOVhi()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Npu6FRfNXa2DPk1HhxlS()
	{
		return DvpCc0fNK3CZAwYxNKPT == null;
	}

	internal static PackageBase QC4ympfNTwt8EWQCs9gk()
	{
		return DvpCc0fNK3CZAwYxNKPT;
	}
}
