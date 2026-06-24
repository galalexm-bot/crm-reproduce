using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Deploy.Import;

[Component]
public class ClearBeforeDelCustomActivityParameters : IClearBeforeDelEntityMetadata
{
	internal static ClearBeforeDelCustomActivityParameters A8aMRmTUY5UVW2twM5c;

	public void Clear(object oldobjectMd)
	{
		//Discarded unreachable code: IL_0081, IL_0090, IL_0150
		int num = 8;
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = default(_003C_003Ec__DisplayClass0_0);
		List<ICustomActivity> list = default(List<ICustomActivity>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					goto end_IL_0012;
				case 4:
					if (_003C_003Ec__DisplayClass0_.parameters != null)
					{
						num2 = 5;
						continue;
					}
					return;
				default:
					if (list == null)
					{
						num2 = 3;
						continue;
					}
					break;
				case 3:
					return;
				case 6:
					return;
				case 7:
					_003C_003Ec__DisplayClass0_.parameters = oldobjectMd as CustomActivityParameters;
					num2 = 4;
					continue;
				case 2:
					return;
				case 5:
				{
					object obj = BoGuqPTpCkwUWX5I5Ow();
					ParameterExpression parameterExpression = (ParameterExpression)sRU3MdTnylPJq4oYNDS(PW6GTvTG1HKr9PwUJDb(typeof(ICustomActivity).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-802458460 ^ -802470722));
					list = ((AbstractNHEntityManager<ICustomActivity, long>)obj).Find(Expression.Lambda<Func<ICustomActivity, bool>>(Expression.Equal(Expression.Property(parameterExpression, (MethodInfo)AKDUInTyNmjE7R29US5((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)qrHg7gT6FjedGZ8vEFh(UMSfEiTOHfWFDtyWL22(_003C_003Ec__DisplayClass0_, typeof(_003C_003Ec__DisplayClass0_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression })).ToList();
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9747bbf97f854087a2d2f13ea94f4085 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				case 1:
					break;
				}
				list.ForEach(delegate(ICustomActivity p)
				{
					int num3 = 1;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 1:
							p.Parameters = null;
							num4 = 0;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_368897dda30d41e8b26c6b065203d16b == 0)
							{
								num4 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				});
				num2 = 6;
				continue;
				end_IL_0012:
				break;
			}
			_003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
			num = 7;
		}
	}

	public ClearBeforeDelCustomActivityParameters()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		yTExuxTR0KKb6EsEGDP();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2d82a778b0ee4fc0915a368d2259a8f3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object BoGuqPTpCkwUWX5I5Ow()
	{
		return CustomActivityManager.Instance;
	}

	internal static Type PW6GTvTG1HKr9PwUJDb(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object sRU3MdTnylPJq4oYNDS(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object AKDUInTyNmjE7R29US5(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object UMSfEiTOHfWFDtyWL22(object P_0, Type P_1)
	{
		return Expression.Constant(P_0, P_1);
	}

	internal static object qrHg7gT6FjedGZ8vEFh(object P_0, object P_1)
	{
		return Expression.Field((Expression)P_0, (FieldInfo)P_1);
	}

	internal static bool luVQKjTmNN2PAT7OrMU()
	{
		return A8aMRmTUY5UVW2twM5c == null;
	}

	internal static ClearBeforeDelCustomActivityParameters M5Et4YTAMAgh3DBDpJE()
	{
		return A8aMRmTUY5UVW2twM5c;
	}

	internal static void yTExuxTR0KKb6EsEGDP()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
