using System;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Services.Scope;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Scripts.Entities;

internal sealed class EntityActionExecutionHandler : AbstractActionExecutionHandler
{
	private static readonly Func<string, Type> getTypeFunc;

	private readonly IMetadataRuntimeService metadataRuntimeService;

	internal static EntityActionExecutionHandler JjgnDlb2NW2FUlXDk3mV;

	public EntityActionExecutionHandler(IExecutionScopeFactory executionScopeFactory, IMetadataRuntimeService metadataRuntimeService)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		QoNhwNb2ahlTWflbYtWK();
		base._002Ector(executionScopeFactory);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
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
			this.metadataRuntimeService = metadataRuntimeService;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
			{
				num = 1;
			}
		}
	}

	public override bool Check(ActionExecutionParams parameters)
	{
		return u4hP9Zb2tYXvYNwxCJZt(vEqYr1b2D7lRqCPJLtrX(parameters), EntityMetadata.UID);
	}

	public override ActionExecutionResult Execute(ActionExecutionParams parameters)
	{
		//Discarded unreachable code: IL_004d, IL_0171, IL_01a4, IL_01e4, IL_01f3
		int num = 5;
		int num2 = num;
		ScriptMethodInfo scriptMethodInfo = default(ScriptMethodInfo);
		string text2 = default(string);
		string text = default(string);
		ClassMetadata classMetadata = default(ClassMetadata);
		Guid instanceUid = default(Guid);
		Guid guid = default(Guid);
		ActionExecutionResult actionExecutionResult = default(ActionExecutionResult);
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 9:
				throw new Exception(SR.T((string)fu6UsKb2wijR0GmhmuwS(-542721635 ^ -542874109)));
			case 1:
				scriptMethodInfo = (ScriptMethodInfo)H9Nq7Db247CI7qUO2uk8(parameters.ScriptName);
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 2;
				}
				break;
			default:
				text2 = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 0x6F4D3711), text, vwy3Rdb2xSge3OF256dN(classMetadata));
				num2 = 8;
				break;
			case 5:
				instanceUid = parameters.InstanceUid;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				throw new Exception((string)jHQQYdb2yAIlVjcmLwNQ(text2, k1VDBMb2mkbyiyk623Jf(fu6UsKb2wijR0GmhmuwS(-1751176224 ^ -1751266336))));
			case 7:
				guid = lkhEH5b26YgpQ3sa0nmO(scriptMethodInfo);
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
				{
					num2 = 7;
				}
				break;
			case 6:
				return actionExecutionResult;
			case 3:
				try
				{
					actionExecutionResult = Execute(type, parameters);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num3 = 0;
					}
					return num3 switch
					{
						0 => actionExecutionResult, 
						_ => actionExecutionResult, 
					};
				}
				catch (Exception ex)
				{
					int num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							WLhSnGb2MafdWpeLUybA(Logger.Log, text2, ex);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
							{
								num4 = 0;
							}
							break;
						default:
							throw;
						}
					}
				}
			case 4:
				if (!u4hP9Zb2tYXvYNwxCJZt(instanceUid, Guid.Empty))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 9;
			case 8:
				if (!MUxpx0b20slhZaFFd0V8(type, null))
				{
					num2 = 3;
					break;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
				{
					num2 = 2;
				}
				break;
			case 10:
			{
				Type typeByUid = metadataRuntimeService.GetTypeByUid(kkbP9qb2HHOP5MIm1lKk(guid, Guid.Empty) ? guid : instanceUid);
				classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(typeByUid);
				text = (string)SEdXehb2AkMsRqFev4o5(scriptMethodInfo);
				type = IJguT2b27FZnel27ePkf(typeByUid, text);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	private static Type GetExecutorType(Type entityType, object scriptName)
	{
		//Discarded unreachable code: IL_0132, IL_016e, IL_017d
		int num = 6;
		ClassMetadata classMetadata = default(ClassMetadata);
		Type type = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					throw new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606744242), yHthNMb2JcLoImS548kE(classMetadata)));
				case 10:
					if (!kodXj7b2dmTZQEoSr5jH(bEDuKKb29cntIqWO7I2i(type, scriptName), null))
					{
						tXxiD8b2lTisqXB3HjKM(type, scriptName);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto end_IL_0012;
				case 4:
					if (string.IsNullOrEmpty((string)yHthNMb2JcLoImS548kE(classMetadata)))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
						{
							num2 = 3;
						}
						break;
					}
					goto case 2;
				case 11:
					return null;
				case 5:
					classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(entityType);
					num2 = 4;
					break;
				case 6:
				case 8:
					if (!PVhrd3b2rMIpoTeAstja(entityType, null))
					{
						num2 = 11;
						break;
					}
					goto case 5;
				default:
					if (!MUxpx0b20slhZaFFd0V8(type, null))
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
						{
							num2 = 9;
						}
						break;
					}
					goto case 9;
				case 1:
				case 3:
					entityType = entityType.BaseType;
					num2 = 8;
					break;
				case 2:
					type = getTypeFunc((string)yHthNMb2JcLoImS548kE(classMetadata));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 0;
					}
					break;
				case 7:
					return type;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 7;
		}
	}

	private static Type GetType(object scriptModuleTypeName)
	{
		//Discarded unreachable code: IL_00b2, IL_00d5, IL_00e4, IL_00f4, IL_0153, IL_016a, IL_0179
		int num = 3;
		int num2 = num;
		int num3 = default(int);
		Type result = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 3:
				num3 = LeWh8Zb2gN7BBUBeCnJO(scriptModuleTypeName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867211419), StringComparison.CurrentCulture);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return ReflectionType.GetType((string)scriptModuleTypeName);
			case 1:
				try
				{
					int num4;
					if (!((string)XfHdVFb2jb4m96sZSLYT(new AssemblyName((string)xaGrCHb25jkW8fOZbL6F(scriptModuleTypeName, num3 + 1))) == (string)fu6UsKb2wijR0GmhmuwS(-675505729 ^ -675523783)))
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num4 = 0;
						}
						goto IL_00b6;
					}
					goto IL_00fe;
					IL_00fe:
					result = wmHV9Wb2UrcvTrVgaagr(olJyDib2Yafq4JCbwgpP(fu6UsKb2wijR0GmhmuwS(-1870892489 ^ -1870874447), false), RNaPEFb2LiFeaw8ntthi(scriptModuleTypeName, num3));
					num4 = 3;
					goto IL_00b6;
					IL_00b6:
					switch (num4)
					{
					case 3:
						return result;
					default:
						goto end_IL_006a;
					case 0:
						goto end_IL_006a;
					case 1:
						break;
					case 2:
						goto end_IL_006a;
					}
					goto IL_00fe;
					end_IL_006a:;
				}
				catch
				{
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				goto default;
			case 2:
				if (num3 > 0)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			}
		}
	}

	static EntityActionExecutionHandler()
	{
		int num = 3;
		ParameterExpression parameterExpression = default(ParameterExpression);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					parameterExpression = (ParameterExpression)AuVff4b2c4j5Dq1T4OyO(j8wGg0b2sklwQdiijqSG(typeof(string).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867713494));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					getTypeFunc = MetadataLoader.UseCachingForFunc(Expression.Lambda<Func<string, Type>>((Expression)psLQcpbeFM8s31qvd0iP(null, (MethodInfo)dhk9oZb2zFABW9CpTFBE((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), new Expression[1] { parameterExpression }), new ParameterExpression[1] { parameterExpression }));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 0;
					}
					continue;
				case 0:
					return;
				case 3:
					break;
				}
				break;
			}
			SingletonReader.JJCZtPuTvSt();
			num = 2;
		}
	}

	internal static void QoNhwNb2ahlTWflbYtWK()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool TryB6Eb23WtXjYXV26lT()
	{
		return JjgnDlb2NW2FUlXDk3mV == null;
	}

	internal static EntityActionExecutionHandler Jrk34Xb2pgn0shBIuE5E()
	{
		return JjgnDlb2NW2FUlXDk3mV;
	}

	internal static Guid vEqYr1b2D7lRqCPJLtrX(object P_0)
	{
		return ((ActionExecutionParams)P_0).TypeUid;
	}

	internal static bool u4hP9Zb2tYXvYNwxCJZt(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object fu6UsKb2wijR0GmhmuwS(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object H9Nq7Db247CI7qUO2uk8(object P_0)
	{
		return ScriptMethodInfoHelper.Deserialize((string)P_0);
	}

	internal static Guid lkhEH5b26YgpQ3sa0nmO(object P_0)
	{
		return ((ScriptMethodInfo)P_0).MetadataUid;
	}

	internal static bool kkbP9qb2HHOP5MIm1lKk(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object SEdXehb2AkMsRqFev4o5(object P_0)
	{
		return ((ScriptMethodInfo)P_0).Name;
	}

	internal static Type IJguT2b27FZnel27ePkf(Type entityType, object P_1)
	{
		return GetExecutorType(entityType, P_1);
	}

	internal static object vwy3Rdb2xSge3OF256dN(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static bool MUxpx0b20slhZaFFd0V8(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object k1VDBMb2mkbyiyk623Jf(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object jHQQYdb2yAIlVjcmLwNQ(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void WLhSnGb2MafdWpeLUybA(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static object yHthNMb2JcLoImS548kE(object P_0)
	{
		return ((ClassMetadata)P_0).ScriptModuleTypeName;
	}

	internal static object bEDuKKb29cntIqWO7I2i(Type type, object P_1)
	{
		return ScriptHelper.GetMethodInfo(type, (string)P_1);
	}

	internal static bool kodXj7b2dmTZQEoSr5jH(object P_0, object P_1)
	{
		return (MethodInfo)P_0 != (MethodInfo)P_1;
	}

	internal static void tXxiD8b2lTisqXB3HjKM(Type type, object P_1)
	{
		ScriptExecutionService.MethodNotFound(type, (string)P_1);
	}

	internal static bool PVhrd3b2rMIpoTeAstja(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static int LeWh8Zb2gN7BBUBeCnJO(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).IndexOf((string)P_1, P_2);
	}

	internal static object xaGrCHb25jkW8fOZbL6F(object P_0, int P_1)
	{
		return ((string)P_0).Substring(P_1);
	}

	internal static object XfHdVFb2jb4m96sZSLYT(object P_0)
	{
		return ((AssemblyName)P_0).Name;
	}

	internal static object olJyDib2Yafq4JCbwgpP(object P_0, bool isFullName)
	{
		return ComponentManager.FindLoadedAssembly((string)P_0, isFullName);
	}

	internal static object RNaPEFb2LiFeaw8ntthi(object P_0, int P_1)
	{
		return ((string)P_0).Remove(P_1);
	}

	internal static Type wmHV9Wb2UrcvTrVgaagr(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetType((string)P_1);
	}

	internal static Type j8wGg0b2sklwQdiijqSG(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object AuVff4b2c4j5Dq1T4OyO(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object dhk9oZb2zFABW9CpTFBE(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object psLQcpbeFM8s31qvd0iP(object P_0, object P_1, object P_2)
	{
		return Expression.Call((Expression)P_0, (MethodInfo)P_1, (Expression[])P_2);
	}
}
