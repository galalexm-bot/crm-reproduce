using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.BPMApps.Models;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.BPMApps.Managers;

public class BPMAppManager : EntityManager<IBPMApp, long>
{
	private static BPMAppManager z5Hr5YfnK2EEmniAUdYa;

	public new static BPMAppManager Instance => Locator.GetServiceNotNull<BPMAppManager>();

	public virtual IBPMApp LoadOrNull(string id)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass2_.id = id;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 1;
				}
				break;
			default:
			{
				ParameterExpression parameterExpression = (ParameterExpression)KigvShfnOtfylkbg5RGi(NbKxsYfnkULYdxQHpSnl(typeof(IBPMApp).TypeHandle), tUVBFgfnn4q2rt0QEOok(0x571EA399 ^ 0x571C6813));
				return ((AbstractNHEntityManager<IBPMApp, long>)this).Find(Expression.Lambda<Func<IBPMApp, bool>>((Expression)Fb9bfCfnPJpOyiAjFYZn(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Field((Expression)yPHrU9fn2kNo9swBsaUj(_003C_003Ec__DisplayClass2_, NbKxsYfnkULYdxQHpSnl(typeof(_003C_003Ec__DisplayClass2_0).TypeHandle)), (FieldInfo)f90HMmfneRWxVoi6H7br((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression })).FirstOrDefault();
			}
			}
		}
	}

	public IBPMApp LoadOrCreate(string id)
	{
		//Discarded unreachable code: IL_006d, IL_007c
		int num = 4;
		int num2 = num;
		IBPMApp iBPMApp = default(IBPMApp);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (iBPMApp != null)
				{
					num2 = 2;
					continue;
				}
				break;
			case 4:
				iBPMApp = LoadOrNull(id);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 3;
				}
				continue;
			case 1:
			case 2:
				return iBPMApp;
			default:
				FRkK0Ifn1Wl8DfPWUDyy(iBPMApp, id);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 1;
				}
				continue;
			case 5:
				break;
			}
			iBPMApp = Create();
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
			{
				num2 = 0;
			}
		}
	}

	public BPMAppManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		MRFCw2fnNmxjtnZhmWQ4();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type NbKxsYfnkULYdxQHpSnl(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object tUVBFgfnn4q2rt0QEOok(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object KigvShfnOtfylkbg5RGi(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object yPHrU9fn2kNo9swBsaUj(object P_0, Type P_1)
	{
		return Expression.Constant(P_0, P_1);
	}

	internal static object f90HMmfneRWxVoi6H7br(RuntimeFieldHandle P_0)
	{
		return FieldInfo.GetFieldFromHandle(P_0);
	}

	internal static object Fb9bfCfnPJpOyiAjFYZn(object P_0, object P_1)
	{
		return Expression.Equal((Expression)P_0, (Expression)P_1);
	}

	internal static bool uTwt3yfnXuhUk9EpSwt9()
	{
		return z5Hr5YfnK2EEmniAUdYa == null;
	}

	internal static BPMAppManager RXFiRVfnTrugRnA5JrLD()
	{
		return z5Hr5YfnK2EEmniAUdYa;
	}

	internal static void FRkK0Ifn1Wl8DfPWUDyy(object P_0, object P_1)
	{
		((IBPMApp)P_0).AppId = (string)P_1;
	}

	internal static void MRFCw2fnNmxjtnZhmWQ4()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
