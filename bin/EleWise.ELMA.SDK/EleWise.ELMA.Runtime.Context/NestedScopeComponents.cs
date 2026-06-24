using System.Collections.Generic;
using System.Linq;
using Autofac;
using Autofac.Features.Metadata;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Context;

public class NestedScopeComponents<T>
{
	private readonly string scope;

	private readonly ServiceScope? scopeType;

	private ILifetimeScopeAccessor lifetimeScopeAccessor;

	private IContextBoundVariableService contextBoundVariableService;

	private readonly string key;

	private static object JDn2XPW2lMMZOVVSuuqW;

	public bool Available
	{
		get
		{
			//Discarded unreachable code: IL_00ac, IL_00bb
			int num = 1;
			ServiceScope? serviceScope = default(ServiceScope?);
			ILifetimeScopeAccessor lifetimeScopeAccessor = default(ILifetimeScopeAccessor);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 4:
						if (serviceScope.Value != lifetimeScopeAccessor.CurrentType)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
							{
								num2 = 2;
							}
							continue;
						}
						return true;
					case 3:
						return object.Equals(lifetimeScopeAccessor.Current.get_Tag(), scope);
					case 5:
						return false;
					case 1:
						lifetimeScopeAccessor = Accessor();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
						{
							num2 = 0;
						}
						continue;
					case 7:
						if (serviceScope.HasValue)
						{
							num2 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 2;
					case 6:
						serviceScope = scopeType;
						num2 = 4;
						continue;
					case 2:
						if (scope == null)
						{
							num2 = 5;
							continue;
						}
						goto case 3;
					}
					break;
				}
				serviceScope = scopeType;
				num = 7;
			}
		}
	}

	public IEnumerable<T> Value
	{
		get
		{
			if (!Available)
			{
				return EleWise.ELMA.Helpers.EmptyArray<T>.Instance;
			}
			return ContextObjects().GetOrAdd(key, () => (from v in ResolutionExtensions.Resolve<IEnumerable<Meta<T>>>((IComponentContext)(object)Accessor().Current).Select(delegate(Meta<T> m)
				{
					m.get_Metadata().TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4ED98F38), out var value);
					return new
					{
						value = m.get_Value(),
						order = ((value != null) ? ((int)value) : 0)
					};
				})
				orderby v.order
				select v.value).ToList());
		}
	}

	public NestedScopeComponents(ServiceScope scopeType)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				this.scopeType = scopeType;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			default:
				key = GetType().FullName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218625558);
				num = 2;
				break;
			}
		}
	}

	private ILifetimeScopeAccessor Accessor()
	{
		int num = 1;
		int num2 = num;
		ILifetimeScopeAccessor lifetimeScopeAccessor = default(ILifetimeScopeAccessor);
		ILifetimeScopeAccessor obj;
		while (true)
		{
			switch (num2)
			{
			default:
				lifetimeScopeAccessor = (this.lifetimeScopeAccessor = Locator.GetService<ILifetimeScopeAccessor>());
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				obj = this.lifetimeScopeAccessor;
				if (obj != null)
				{
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				obj = lifetimeScopeAccessor;
				break;
			}
			break;
		}
		return obj;
	}

	private IContextBoundVariableService ContextObjects()
	{
		int num = 1;
		int num2 = num;
		IContextBoundVariableService obj;
		IContextBoundVariableService contextBoundVariableService = default(IContextBoundVariableService);
		while (true)
		{
			switch (num2)
			{
			case 1:
				obj = this.contextBoundVariableService;
				if (obj == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				contextBoundVariableService = (this.contextBoundVariableService = Locator.GetServiceNotNull<IContextBoundVariableService>());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 2;
				}
				continue;
			case 2:
				obj = contextBoundVariableService;
				break;
			}
			break;
		}
		return obj;
	}

	internal static bool b4OCM7W2rnvqeVljq6pF()
	{
		return JDn2XPW2lMMZOVVSuuqW == null;
	}

	internal static object KZ3En5W2gkGyRe3L5jd7()
	{
		return JDn2XPW2lMMZOVVSuuqW;
	}
}
