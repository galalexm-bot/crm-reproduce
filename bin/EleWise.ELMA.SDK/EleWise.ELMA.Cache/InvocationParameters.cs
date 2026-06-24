using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Castle.DynamicProxy;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Cache;

public class InvocationParameters
{
	internal static InvocationParameters Fe53lafKuNZEmLxNNsqa;

	public object InvocationTarget
	{
		[CompilerGenerated]
		get
		{
			return _003CInvocationTarget_003Ek__BackingField;
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
					_003CInvocationTarget_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Type TargetType
	{
		[CompilerGenerated]
		get
		{
			return _003CTargetType_003Ek__BackingField;
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
					_003CTargetType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public object[] Arguments
	{
		[CompilerGenerated]
		get
		{
			return _003CArguments_003Ek__BackingField;
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
					_003CArguments_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
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

	public Type[] GenericArguments
	{
		[CompilerGenerated]
		get
		{
			return _003CGenericArguments_003Ek__BackingField;
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
					_003CGenericArguments_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public MethodInfo Method
	{
		[CompilerGenerated]
		get
		{
			return _003CMethod_003Ek__BackingField;
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
					_003CMethod_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	internal InvocationParameters(IInvocation invocation)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		lPvFYofKS97bHrKoEyZE();
		base._002Ector();
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				GenericArguments = invocation.get_GenericArguments();
				num = 5;
				break;
			case 5:
				InvocationTarget = invocation.get_InvocationTarget();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num = 3;
				}
				break;
			case 3:
				Method = (MethodInfo)OoxtH1fKixVuKd7cF0KD(invocation);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num = 1;
				}
				break;
			case 0:
				return;
			case 4:
				Arguments = invocation.get_Arguments();
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num = 2;
				}
				break;
			case 1:
				TargetType = w3JX9TfKRM41I4muyf3a(invocation);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void lPvFYofKS97bHrKoEyZE()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object OoxtH1fKixVuKd7cF0KD(object P_0)
	{
		return ((IInvocation)P_0).get_Method();
	}

	internal static Type w3JX9TfKRM41I4muyf3a(object P_0)
	{
		return ((IInvocation)P_0).get_TargetType();
	}

	internal static bool k6W4S3fKIZNPTtZDGG9y()
	{
		return Fe53lafKuNZEmLxNNsqa == null;
	}

	internal static InvocationParameters lUwdeufKVZ5kK3c2ZL3p()
	{
		return Fe53lafKuNZEmLxNNsqa;
	}
}
