using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Actions;

[Serializable]
public class ActionMethodMetadata : IAuditEventHolder
{
	private readonly IAuditObject _auditObject;

	private readonly IAuditAction _auditAction;

	private readonly IList<ActionMethodArgument> _arguments;

	private readonly ActionMethodArgument _resultArgument;

	internal static ActionMethodMetadata eCLhggfwvUHJ16C4L728;

	public IAuditObject Object => _auditObject;

	public IAuditAction Action => _auditAction;

	public ActionMethodArgument ResultArgument => _resultArgument;

	public ReadOnlyCollection<ActionMethodArgument> Arguments => new ReadOnlyCollection<ActionMethodArgument>(_arguments);

	public ActionMethodMetadata(IAuditObject auditObject, IAuditAction auditAction, IList<ActionMethodArgument> arguments, ActionMethodArgument resultArgument)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		_auditObject = auditObject;
		_auditAction = auditAction;
		_arguments = arguments;
		_resultArgument = resultArgument;
	}

	public static ActionMethodMetadata Create([NotNull] IAuditObject auditObject, [NotNull] IAuditAction auditAction, [NotNull] MethodInfo methodInfo)
	{
		//Discarded unreachable code: IL_011f, IL_0129, IL_0138, IL_0148, IL_0157
		int num = 8;
		int num2 = num;
		List<ActionMethodArgument> arguments = default(List<ActionMethodArgument>);
		ActionMethodArgument resultArgument = default(ActionMethodArgument);
		while (true)
		{
			ActionMethodArgument actionMethodArgument;
			switch (num2)
			{
			case 6:
				return new ActionMethodMetadata(auditObject, auditAction, arguments, resultArgument);
			case 8:
				if (auditObject == null)
				{
					num2 = 7;
					break;
				}
				if (auditAction == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 1;
					}
					break;
				}
				if (!(methodInfo == null))
				{
					num2 = 4;
					break;
				}
				goto case 1;
			case 7:
				throw new ArgumentNullException((string)MLr4KqfwuMH5SdsXmCQv(-1411196499 ^ -1410889749));
			case 1:
				throw new ArgumentNullException((string)MLr4KqfwuMH5SdsXmCQv(-1858887263 ^ -1858668259));
			case 4:
				if (YMhm7ZfwSVBRunfjuUXl(X0FwQ0fwIDrcXlKiIdlL(methodInfo), O479PDfwV6btL6dWqSiq(typeof(void).TypeHandle)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 3:
				throw new ArgumentNullException((string)MLr4KqfwuMH5SdsXmCQv(0x35C0467B ^ 0x35C5181B));
			case 2:
				actionMethodArgument = new ActionMethodArgument(null, X0FwQ0fwIDrcXlKiIdlL(methodInfo));
				goto IL_017d;
			default:
				actionMethodArgument = new ActionMethodArgument((string)tSrCvbfwR8LxD7tqmgJA(X8hagEfwi45Nei7v8Oi5(methodInfo)), alsa3XfwqhtivwxF70ZZ(X8hagEfwi45Nei7v8Oi5(methodInfo)));
				goto IL_017d;
			case 5:
				{
					arguments = (from parameter in methodInfo.GetParameters()
						select new ActionMethodArgument(parameter.Name, parameter.ParameterType)).ToList();
					num2 = 6;
					break;
				}
				IL_017d:
				resultArgument = actionMethodArgument;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 5;
				}
				break;
			}
		}
	}

	internal static object MLr4KqfwuMH5SdsXmCQv(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type X0FwQ0fwIDrcXlKiIdlL(object P_0)
	{
		return ((MethodInfo)P_0).ReturnType;
	}

	internal static Type O479PDfwV6btL6dWqSiq(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool YMhm7ZfwSVBRunfjuUXl(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object X8hagEfwi45Nei7v8Oi5(object P_0)
	{
		return ((MethodInfo)P_0).ReturnParameter;
	}

	internal static object tSrCvbfwR8LxD7tqmgJA(object P_0)
	{
		return ((ParameterInfo)P_0).Name;
	}

	internal static Type alsa3XfwqhtivwxF70ZZ(object P_0)
	{
		return ((ParameterInfo)P_0).ParameterType;
	}

	internal static bool Nnv2s4fw839Uex78rBMr()
	{
		return eCLhggfwvUHJ16C4L728 == null;
	}

	internal static ActionMethodMetadata OLoWZjfwZIRttir9LSdd()
	{
		return eCLhggfwvUHJ16C4L728;
	}
}
