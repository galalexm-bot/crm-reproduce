using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using Autofac.Builder;
using Autofac.Core;
using EleWise.ELMA.Services.Scope;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Services.Autofac;

internal sealed class ExecutionScopeBuilder : IExecutionScopeBuilder
{
	private readonly ILifetimeScope globalScope;

	private readonly List<IComponentRegistration> registrations;

	internal static ExecutionScopeBuilder UuE38jBmd6Ksstdy2RC6;

	internal ExecutionScopeBuilder(ILifetimeScope globalScope)
	{
		//Discarded unreachable code: IL_003a, IL_003f
		q2oEilBmg1LKUbTMTSWI();
		registrations = new List<IComponentRegistration>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
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
			this.globalScope = globalScope;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
			{
				num = 1;
			}
		}
	}

	public IExecutionScopeBuilder AddRegistration(Type type, params Type[] registerTypes)
	{
		//Discarded unreachable code: IL_0093, IL_00b7
		int num = 6;
		int num2 = num;
		IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle> val = default(IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>);
		while (true)
		{
			switch (num2)
			{
			case 2:
			case 4:
				RegistrationExtensions.AsSelf<object, ConcreteReflectionActivatorData>(val);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				val = RegistrationExtensions.PropertiesAutowired<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(RegistrationBuilder.ForType(type), (PropertyWiringOptions)1);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (registerTypes.Length != 0)
				{
					num2 = 8;
					break;
				}
				goto case 2;
			case 6:
				bSQJ53Bm51U90jA29v2T(type, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7EC191D));
				num2 = 5;
				break;
			case 9:
				return this;
			case 8:
				val.As(registerTypes);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
				{
					num2 = 7;
				}
				break;
			case 1:
			case 7:
				registrations.Add(RegistrationBuilder.CreateRegistration<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(val));
				num2 = 9;
				break;
			default:
				if (registerTypes == null)
				{
					num2 = 2;
					break;
				}
				goto case 3;
			}
		}
	}

	public IExecutionScopeBuilder AddRegistration(Type type, IEnumerable<Type> registerTypes)
	{
		return AddRegistration(type, registerTypes?.ToArray() ?? Array.Empty<Type>());
	}

	public IExecutionScopeBuilder AddRegistration(object instance, params Type[] registerTypes)
	{
		//Discarded unreachable code: IL_00b2, IL_0155
		int num = 8;
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
		IRegistrationBuilder<object, SimpleActivatorData, SingleRegistrationStyle> val = default(IRegistrationBuilder<object, SimpleActivatorData, SingleRegistrationStyle>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
					num2 = 7;
					continue;
				case 1:
				case 2:
					registrations.Add(RegistrationBuilder.CreateRegistration<object, SimpleActivatorData, SingleRegistrationStyle>(val));
					num2 = 11;
					continue;
				case 6:
					if (registerTypes != null)
					{
						num2 = 9;
						continue;
					}
					goto case 3;
				case 3:
				case 5:
					RegistrationExtensions.AsSelf<object, SimpleActivatorData>(val);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 1;
					}
					continue;
				case 11:
					return this;
				case 4:
					val.As(registerTypes);
					num2 = 2;
					continue;
				case 9:
					if (registerTypes.Length == 0)
					{
						num2 = 5;
						continue;
					}
					goto case 4;
				case 10:
					val = RegistrationExtensions.PropertiesAutowired<object, SimpleActivatorData, SingleRegistrationStyle>(RegistrationBuilder.ForDelegate(_003C_003Ec__DisplayClass5_.instance.GetType(), (Func<IComponentContext, IEnumerable<Parameter>, object>)_003C_003Ec__DisplayClass5_._003CAddRegistration_003Eb__0), (PropertyWiringOptions)1);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 6;
					}
					continue;
				case 7:
					_003C_003Ec__DisplayClass5_.instance = instance;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			Contract.ArgumentNotNull(_003C_003Ec__DisplayClass5_.instance, (string)U03VfbBmjR7mTLj91uXg(-1870892489 ^ -1870851817));
			num = 10;
		}
	}

	public IExecutionScopeBuilder AddRegistration(object instance, IEnumerable<Type> registerTypes)
	{
		return AddRegistration(instance, registerTypes?.ToArray() ?? Array.Empty<Type>());
	}

	public IExecutionScope StartScope()
	{
		return new ExecutionScope(globalScope, registrations);
	}

	internal static void q2oEilBmg1LKUbTMTSWI()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool IUhf8fBmlEptrKvrralf()
	{
		return UuE38jBmd6Ksstdy2RC6 == null;
	}

	internal static ExecutionScopeBuilder kpvbsoBmrBhXp8eGdI5x()
	{
		return UuE38jBmd6Ksstdy2RC6;
	}

	internal static void bSQJ53Bm51U90jA29v2T(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object U03VfbBmjR7mTLj91uXg(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
