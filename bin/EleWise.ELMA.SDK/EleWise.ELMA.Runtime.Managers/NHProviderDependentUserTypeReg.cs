using System;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using NHibernate.UserTypes;

namespace EleWise.ELMA.Runtime.Managers;

[Component(Type = ComponentType.Server, InjectProerties = false, EnableInterceptors = false)]
public abstract class NHProviderDependentUserTypeRegistrar<TUserTypeImpl, TUserTypeBase> : INHProviderDependentUserTypeRegistrar where TUserTypeImpl : TUserTypeBase where TUserTypeBase : IUserType
{
	internal static object lnSev0WMhevsY5Ktrhg0;

	public abstract Guid ProviderUid { get; }

	void INHProviderDependentUserTypeRegistrar.Register()
	{
		NHProviderDependentUserTypes.Register<TUserTypeBase, TUserTypeImpl>();
	}

	protected NHProviderDependentUserTypeRegistrar()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool fkcsCcWMGgi8QCgQC1Oq()
	{
		return lnSev0WMhevsY5Ktrhg0 == null;
	}

	internal static object nDlYTsWMEKlLdKYBdxfp()
	{
		return lnSev0WMhevsY5Ktrhg0;
	}
}
