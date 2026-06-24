using System;
using System.Collections.Generic;
using System.ComponentModel;
using EleWise.ELMA.Exceptions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Services.Impl;

public abstract class SimpleBoundVariableServiceBase : IClearableContextBoundVariableService, IContextBoundVariableService, IAbstractBoundVariableService
{
	private static SimpleBoundVariableServiceBase f3xSyLBJo1uhCkVrS29M;

	protected abstract IDictionary<string, object> Dictionary { get; }

	public virtual bool Contains(string name)
	{
		return Dictionary.ContainsKey(name);
	}

	public virtual T Get<T>(string name)
	{
		if (!TryGetValue<T>(name, out var value))
		{
			throw new VariableNotFoundException(name);
		}
		return value;
	}

	public virtual bool TryGetValue<T>(string name, out T value)
	{
		if (Dictionary.TryGetValue(name, out var value2))
		{
			value = (T)value2;
			return true;
		}
		value = default(T);
		return false;
	}

	public virtual void Set(string name, object value)
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
				Dictionary[name] = value;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[Obsolete("This method is obsolete and throws exception. Use extension method IContextBoundVariableService.ClearFor or IContextBoundVariableService.ClearRegion instead.", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void Clear()
	{
		throw new Exception((string)MMesXUBJGJSL1KcG6BTg(-2099751081 ^ -2099692149));
	}

	void IClearableContextBoundVariableService.ClearContext()
	{
		Moa3vQBJEHbGbqrWqVId(this);
	}

	protected virtual void ClearContext()
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
				i76H2PBJfbfvmZAs5FsW(Dictionary);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public virtual void Remove(string key)
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
				Dictionary.Remove(key);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected SimpleBoundVariableServiceBase()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool zoKesWBJbhxptIE2n5wS()
	{
		return f3xSyLBJo1uhCkVrS29M == null;
	}

	internal static SimpleBoundVariableServiceBase oHKgovBJhYrP2gCR4CNm()
	{
		return f3xSyLBJo1uhCkVrS29M;
	}

	internal static object MMesXUBJGJSL1KcG6BTg(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void Moa3vQBJEHbGbqrWqVId(object P_0)
	{
		((SimpleBoundVariableServiceBase)P_0).ClearContext();
	}

	internal static void i76H2PBJfbfvmZAs5FsW(object P_0)
	{
		((ICollection<KeyValuePair<string, object>>)P_0).Clear();
	}
}
