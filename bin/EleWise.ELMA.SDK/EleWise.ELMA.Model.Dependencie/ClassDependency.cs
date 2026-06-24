using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using EleWise.ELMA.Model.Signatures;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Dependencies;

[Serializable]
[DataContract]
public abstract class ClassDependency : Dependency
{
	private static ClassDependency Kx2t0khit2JbyTWZ0P9e;

	[DataMember]
	public List<PropertySignature> Properties { get; set; }

	protected ClassDependency()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
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
			Properties = new List<PropertySignature>();
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
			{
				num = 1;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeProperties()
	{
		return Fui2FShi6Kk7ciBNruVM(Properties) != 0;
	}

	internal static bool P0XEl2hiwSLwoOF7E48W()
	{
		return Kx2t0khit2JbyTWZ0P9e == null;
	}

	internal static ClassDependency fxfZimhi4N2pGII7CnSo()
	{
		return Kx2t0khit2JbyTWZ0P9e;
	}

	internal static int Fui2FShi6Kk7ciBNruVM(object P_0)
	{
		return ((List<PropertySignature>)P_0).Count;
	}
}
