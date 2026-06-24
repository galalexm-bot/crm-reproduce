using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Runtime.Cache;

public class TypeInfoCache
{
	internal AssemblyInfoCache _owner;

	private static TypeInfoCache XMLk0TWPElpRSZc85aEu;

	public string TypeName
	{
		[CompilerGenerated]
		get
		{
			return _003CTypeName_003Ek__BackingField;
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
				case 1:
					_003CTypeName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public List<int> EnabledInterceptors { get; set; }

	public List<int> DisabledInterceptors { get; set; }

	public bool? IsComponentType { get; set; }

	public bool? IsServiceType { get; set; }

	public TypeInfoCache()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			default:
				DisabledInterceptors = new List<int>();
				num = 2;
				break;
			case 1:
				EnabledInterceptors = new List<int>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public TypeInfoCache(AssemblyInfoCache owner, Type type)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		this._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				TypeName = type.FullName;
				num = 2;
				break;
			case 1:
				_owner = owner;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	public bool? IsInterceptorEnabled(string name)
	{
		if (_owner == null || _owner._owner == null)
		{
			return null;
		}
		int interceptorIndex = _owner._owner.GetInterceptorIndex(name);
		if (EnabledInterceptors.Contains(interceptorIndex))
		{
			return true;
		}
		if (DisabledInterceptors.Contains(interceptorIndex))
		{
			return false;
		}
		return null;
	}

	public void SetInterceptorEnabled(string name, bool enabled)
	{
		//Discarded unreachable code: IL_00ed, IL_0129, IL_0161
		int num = 4;
		int num2 = num;
		int item = default(int);
		while (true)
		{
			switch (num2)
			{
			case 10:
				if (EnabledInterceptors.Contains(item))
				{
					num2 = 2;
					continue;
				}
				break;
			case 1:
				if (!enabled)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 10;
			case 5:
				if (_owner._owner == null)
				{
					num2 = 8;
					continue;
				}
				item = wQ3ArLWPC8usZKNYpZA8(_owner._owner, name);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num2 = 1;
				}
				continue;
			case 3:
				return;
			case 8:
				return;
			case 6:
				DisabledInterceptors.Add(item);
				num2 = 11;
				continue;
			case 2:
				return;
			case 11:
				return;
			case 9:
				return;
			default:
				if (DisabledInterceptors.Contains(item))
				{
					return;
				}
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 2;
				}
				continue;
			case 4:
				if (_owner == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				goto case 5;
			case 7:
				break;
			}
			EnabledInterceptors.Add(item);
			num2 = 9;
		}
	}

	internal static bool J3u3awWPftuu96ZSAx0Q()
	{
		return XMLk0TWPElpRSZc85aEu == null;
	}

	internal static TypeInfoCache GABwODWPQPd9r6NO2giU()
	{
		return XMLk0TWPElpRSZc85aEu;
	}

	internal static int wQ3ArLWPC8usZKNYpZA8(object P_0, object P_1)
	{
		return ((ApplicationStartCache)P_0).GetInterceptorIndex((string)P_1);
	}
}
