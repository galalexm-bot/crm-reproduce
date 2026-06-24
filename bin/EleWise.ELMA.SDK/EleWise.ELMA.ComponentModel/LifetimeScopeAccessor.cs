using System;
using System.Runtime.CompilerServices;
using Autofac;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ComponentModel;

public class LifetimeScopeAccessor : ILifetimeScopeAccessor
{
	private Func<ILifetimeScope> current;

	private static LifetimeScopeAccessor oB7asEfZ7YrnRUgeBSsZ;

	public ILifetimeScope Current => current();

	public ServiceScope CurrentType
	{
		[CompilerGenerated]
		get
		{
			return _003CCurrentType_003Ek__BackingField;
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
					_003CCurrentType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
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

	public LifetimeScopeAccessor(Func<ILifetimeScope> current)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		if (current == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4EDC49B2));
		}
		this.current = current;
		CurrentType = ServiceScope.Application;
	}

	public void SetAccessor(Func<ILifetimeScope> accessor)
	{
		if (accessor == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561278466));
		}
		current = accessor;
	}

	internal static bool xouseJfZx26Psgy7YHAL()
	{
		return oB7asEfZ7YrnRUgeBSsZ == null;
	}

	internal static LifetimeScopeAccessor aX7LDgfZ0mB9cuY8fMK3()
	{
		return oB7asEfZ7YrnRUgeBSsZ;
	}
}
