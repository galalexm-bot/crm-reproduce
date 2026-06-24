using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Scope;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Scripts.Entities;

[Service(Type = ComponentType.Server)]
public class EntityScriptingService : IEntityScriptingService
{
	private static Func<string, Type> getTypeFunc;

	private static EntityScriptingService Ycw8PmbPt7FKPdGqIp3d;

	public IExecutionScopeFactory ExecutionScopeFactory
	{
		[CompilerGenerated]
		get
		{
			return _003CExecutionScopeFactory_003Ek__BackingField;
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
					_003CExecutionScopeFactory_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual Type GetScriptModuleType(IEntity entity)
	{
		return GetScriptModuleType(entity, null);
	}

	public virtual Type GetScriptModuleType(IEntity entity, string scriptName)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return pZgPuWbP6a8c6jvXyhgr(entity.CastAsRealType().GetType(), scriptName);
			case 1:
				if (entity == null)
				{
					return null;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static Type GetType(object scriptModuleTypeName)
	{
		//Discarded unreachable code: IL_007b, IL_00d9, IL_0103, IL_011a
		int num = 2;
		int num2 = num;
		int num3 = default(int);
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			default:
				try
				{
					if (jSpXm9bP0B6YAhWrOTYL(VIFsXFbPxqs3JuAWV4bN(new AssemblyName((string)wElONibP7Ds5XoV5t0js(scriptModuleTypeName, num3 + 1))), PfRHWebPH8jwvgxdW5Hy(-1751176224 ^ -1751129754)))
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								type = ComponentManager.FindLoadedAssembly(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858901209), isFullName: false).GetType(((string)scriptModuleTypeName).Remove(num3));
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
								{
									num4 = 1;
								}
								continue;
							case 2:
								break;
							case 1:
								return type;
							}
							break;
						}
					}
				}
				catch
				{
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				goto case 3;
			case 2:
				num3 = fc5mVGbPA2WRVORNJ0dc(scriptModuleTypeName, PfRHWebPH8jwvgxdW5Hy(0x35C0467B ^ 0x35C0148B));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return W4hLohbPmQh5cCHAUaBs(scriptModuleTypeName);
			case 1:
				if (num3 > 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	private static Type GetScriptModuleType(Type entityType, object scriptName)
	{
		//Discarded unreachable code: IL_00d0, IL_00df, IL_0112, IL_0121, IL_01d4, IL_01e3
		int num = 12;
		int num2 = num;
		ClassMetadata classMetadata = default(ClassMetadata);
		Type type = default(Type);
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(entityType);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 14;
				}
				break;
			case 13:
				return null;
			case 7:
				if (!aSNA0MbPJAuLd1gAI1co(type, null))
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 4;
			case 12:
				_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 11;
				}
				break;
			case 8:
				if (!jmWZ9fbP9OSrQeOLsvQV(type.GetMethod(_003C_003Ec__DisplayClass8_.scriptName), null))
				{
					num2 = 3;
					break;
				}
				goto case 1;
			case 14:
				if (!c2EZW6bPM6RTQCJLp2yl(jfYHcsbPyEEqFEATBhAX(classMetadata)))
				{
					num2 = 10;
					break;
				}
				goto default;
			case 1:
				return type;
			default:
				entityType = entityType.BaseType;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 5;
				}
				break;
			case 11:
				_003C_003Ec__DisplayClass8_.scriptName = (string)scriptName;
				num2 = 9;
				break;
			case 4:
				throw new ScriptExecuteException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C51D8AD), jfYHcsbPyEEqFEATBhAX(classMetadata)));
			case 6:
				if (_003C_003Ec__DisplayClass8_.scriptName != null)
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num2 = 7;
					}
					break;
				}
				goto case 1;
			case 5:
			case 9:
				if (!NYjFeSbPdJwT5WgSSMgB(entityType, null))
				{
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 9;
					}
					break;
				}
				goto case 2;
			case 10:
				type = getTypeFunc(classMetadata.ScriptModuleTypeName);
				num2 = 7;
				break;
			case 3:
				if (!type.GetMethods().Any(_003C_003Ec__DisplayClass8_._003CGetScriptModuleType_003Eb__0))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	private static (Type ScriptModuleType, MethodInfo MethodInfo) GetScriptModuleType(Type entityType, object scriptMethodInfo, object errorTitle)
	{
		if (((ScriptMethodInfo)scriptMethodInfo).MetadataUid != Guid.Empty)
		{
			return GetExecutionData((ClassMetadata)MetadataLoader.LoadMetadata(((ScriptMethodInfo)scriptMethodInfo).MetadataUid), ((ScriptMethodInfo)scriptMethodInfo).Name, errorTitle);
		}
		while (entityType != null)
		{
			var (type, methodInfo) = GetExecutionData((ClassMetadata)MetadataLoader.LoadMetadata(entityType), ((ScriptMethodInfo)scriptMethodInfo).Name, errorTitle);
			if (type != null && methodInfo != null)
			{
				return (type, methodInfo);
			}
			entityType = entityType.BaseType;
		}
		return (null, null);
	}

	private static (Type, MethodInfo) GetExecutionData(object metadata, object scriptName, object errorTitle)
	{
		if (string.IsNullOrEmpty(((ClassMetadata)metadata).ScriptModuleTypeName))
		{
			return (null, null);
		}
		Type type = getTypeFunc(((ClassMetadata)metadata).ScriptModuleTypeName);
		if (type == null)
		{
			throw new ScriptExecuteException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269CBF98), ((ClassMetadata)metadata).ScriptModuleTypeName));
		}
		MethodInfo methodInfo = GetMethodInfo((string)errorTitle, type, (string)scriptName, throwOnNotFound: false);
		if (methodInfo == null)
		{
			ScriptExecutionService.MethodNotFound(type, (string)scriptName);
			return (null, null);
		}
		return (type, methodInfo);
	}

	public virtual Type GetScriptModuleItemType(IEntity entity)
	{
		//Discarded unreachable code: IL_0070, IL_00a6, IL_00ec, IL_00fb, IL_0190, IL_019f, IL_01af
		int num = 5;
		int num2 = num;
		Type scriptModuleType = default(Type);
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (!aSNA0MbPJAuLd1gAI1co(scriptModuleType, null))
				{
					num2 = 13;
					break;
				}
				goto case 8;
			case 6:
			case 11:
				if (NYjFeSbPdJwT5WgSSMgB(type, null))
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 10;
					}
					break;
				}
				return null;
			case 8:
				return null;
			case 13:
				type = scriptModuleType;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				scriptModuleType = GetScriptModuleType(entity);
				num2 = 4;
				break;
			case 2:
				if (!aSNA0MbPJAuLd1gAI1co(type.GetGenericTypeDefinition(), sygHKObPlUZ3s1LgnGTR(typeof(EntityScriptModule<>).TypeHandle)))
				{
					num2 = 12;
					break;
				}
				goto case 6;
			case 7:
			case 9:
			case 12:
				type = type.BaseType;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (!NYjFeSbPdJwT5WgSSMgB(type, null))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 1;
			case 1:
				if (!type.IsGenericType)
				{
					num2 = 9;
					break;
				}
				goto case 2;
			case 10:
				return type.GetGenericArguments()[0];
			}
		}
	}

	public virtual object GetScriptInstance(IEntity entity)
	{
		//Discarded unreachable code: IL_0085
		int num = 2;
		int num2 = num;
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 2:
				type = hAbdWbbPrJW6R9pL9ITw(this, entity);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return null;
			default:
				return M8UTCnbPgWcRmFXmLSDj(type);
			case 1:
				if (!aSNA0MbPJAuLd1gAI1co(type, null))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public virtual object GetScriptInstance(IEntity entity, string scriptName)
	{
		int num = 1;
		int num2 = num;
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return null;
			case 1:
				type = A3bi76bP5SfloYKp1Ght(this, entity, scriptName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (!aSNA0MbPJAuLd1gAI1co(type, null))
			{
				return M8UTCnbPgWcRmFXmLSDj(type);
			}
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
			{
				num2 = 2;
			}
		}
	}

	public virtual object ExecuteScript(IEntity entity, string scriptName, Dictionary<string, object> parameters = null, Func<string, Type, object> parameterAccessor = null)
	{
		Contract.ArgumentNotNull(entity, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD55050 ^ 0x5DD5FCF4));
		Contract.ArgumentNotNull(scriptName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A4E9AF9));
		ScriptMethodInfo scriptMethodInfo = ScriptMethodInfoHelper.Deserialize(scriptName);
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(entity.CastAsRealType().GetType());
		string text = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A5D5EF ^ 0x3A73407), scriptMethodInfo.Name, entity.ToString(), classMetadata.DisplayName, entity.GetId());
		Logger.Log.Debug(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606743678), scriptMethodInfo.Name, entity.ToString(), classMetadata.FullTypeName, entity.GetId()));
		try
		{
			object scriptInstance = null;
			MethodInfo methodInfo = null;
			try
			{
				(Type, MethodInfo) scriptModuleType = GetScriptModuleType(entity.CastAsRealType().GetType(), scriptMethodInfo, text);
				var (type, _) = scriptModuleType;
				if (type != null)
				{
					methodInfo = scriptModuleType.Item2;
					using IExecutionScope executionScope = ExecutionScopeFactory.CreateScope().AddRegistration(type).StartScope();
					scriptInstance = executionScope.Resolve(type);
				}
			}
			catch (Exception innerException)
			{
				throw new ScriptExecuteException(text + SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867910548)), innerException);
			}
			if (methodInfo == null)
			{
				Logger.Log.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70179819));
				return null;
			}
			object result = ExecuteScript(text, methodInfo, scriptInstance, entity, parameters, parameterAccessor);
			Logger.Log.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53D4D4F));
			return result;
		}
		catch (ScriptExecuteException exception)
		{
			Logger.Log.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68B95602), exception);
			throw;
		}
		catch (Exception ex)
		{
			Logger.Log.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1C0024), ex);
			throw new ScriptExecuteException(text, ex);
		}
	}

	protected static MethodInfo GetMethodInfo(string errorTitle, Type type, string scriptName, bool throwOnNotFound)
	{
		//Discarded unreachable code: IL_0099, IL_016c, IL_017b, IL_0186, IL_0255, IL_0264, IL_0300, IL_0313, IL_0381, IL_0481, IL_04cc, IL_04db
		int num = 7;
		int num2 = num;
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = default(_003C_003Ec__DisplayClass15_0);
		string text = default(string);
		MethodInfo methodInfo = default(MethodInfo);
		List<MethodInfo>.Enumerator enumerator = default(List<MethodInfo>.Enumerator);
		MethodInfo current = default(MethodInfo);
		List<string> values = default(List<string>);
		string text3 = default(string);
		_003C_003Ec__DisplayClass15_1 _003C_003Ec__DisplayClass15_2 = default(_003C_003Ec__DisplayClass15_1);
		while (true)
		{
			switch (num2)
			{
			case 6:
				_003C_003Ec__DisplayClass15_.scriptName = scriptName;
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				throw new ScriptExecuteException(text);
			case 4:
				cImo1Bb1oP1feJUK4lkK(ePL4yXb1WZmeDy1xc7OP(), text);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num2 = 1;
				}
				break;
			case 8:
				methodInfo = null;
				num2 = 5;
				break;
			default:
				if (jmWZ9fbP9OSrQeOLsvQV(methodInfo, null))
				{
					num2 = 9;
					break;
				}
				text = (string)eILpAGb1BoiDwaKIshGh(errorTitle, SR.T((string)PfRHWebPH8jwvgxdW5Hy(-2107978722 ^ -2108149816), _003C_003Ec__DisplayClass15_.scriptName));
				num2 = 2;
				break;
			case 1:
				return null;
			case 5:
				try
				{
					string text2 = ((IEnumerable<string>)roYEYZbPjWEdCsdqxmya(_003C_003Ec__DisplayClass15_.scriptName, new string[1] { (string)PfRHWebPH8jwvgxdW5Hy(--1418440330 ^ 0x548B6D2C) }, StringSplitOptions.None)).First();
					int num3 = 7;
					while (true)
					{
						int num4;
						MethodInfo methodInfo2;
						switch (num3)
						{
						case 7:
							if (!Hhbn4XbPYeNah0Hp6jW9(text2, PfRHWebPH8jwvgxdW5Hy(0x26FFCB59 ^ 0x26FFD4EF)))
							{
								num4 = 2;
								goto IL_0106;
							}
							goto case 8;
						default:
							try
							{
								while (true)
								{
									IL_026f:
									int num5;
									if (!enumerator.MoveNext())
									{
										num5 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
										{
											num5 = 1;
										}
										goto IL_018a;
									}
									goto IL_01b0;
									IL_01b0:
									current = enumerator.Current;
									num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
									{
										num5 = 1;
									}
									goto IL_018a;
									IL_018a:
									while (true)
									{
										switch (num5)
										{
										case 5:
											break;
										default:
											methodInfo = current;
											num5 = 6;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
											{
												num5 = 4;
											}
											continue;
										case 4:
											if (!nLXeUjb1FjEIZNQYfo3S(TS8BgbbPzBEwy9qFQhHP(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A1640F ^ 0x4A1BE41), meXal6bPcoBru4aB10Eh(current), string.Join((string)PfRHWebPH8jwvgxdW5Hy(-740338220 ^ -740337194), values)), text2))
											{
												num5 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
												{
													num5 = 0;
												}
												continue;
											}
											goto IL_026f;
										case 6:
											goto end_IL_026f;
										case 2:
											goto IL_026f;
										case 1:
											values = ((IEnumerable<ParameterInfo>)GqGRqxbPs9dIwhPmcljN(current)).Select(delegate(ParameterInfo q)
											{
												int num8 = 1;
												int num9 = num8;
												string text4 = default(string);
												while (true)
												{
													switch (num9)
													{
													case 1:
														text4 = (string)_003C_003Ec.AHQtcPCaNCObdNy6QWbW(q.ParameterType);
														num9 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
														{
															num9 = 0;
														}
														break;
													default:
														return (string)_003C_003Ec.IP5XpjCap045swOGCuZc(text4, 1, _003C_003Ec.XlITKXCa37LtPdBtC87d(text4) - 2);
													}
												}
											}).ToList();
											num5 = 4;
											continue;
										case 3:
											goto end_IL_026f;
										}
										break;
									}
									goto IL_01b0;
									continue;
									end_IL_026f:
									break;
								}
							}
							finally
							{
								((IDisposable)enumerator).Dispose();
								int num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
								{
									num6 = 0;
								}
								switch (num6)
								{
								case 0:
									break;
								}
							}
							break;
						case 1:
							text3 = (string)GHWSgkbPUdbsuRrOxYe2(wElONibP7Ds5XoV5t0js(text2, iSatrEbPLAvVE5Sv0OI4(text2, '(') + 1), PfRHWebPH8jwvgxdW5Hy(-889460160 ^ -889457156), "");
							num3 = 6;
							continue;
						case 8:
							_003C_003Ec__DisplayClass15_2 = new _003C_003Ec__DisplayClass15_1();
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
							{
								num3 = 1;
							}
							continue;
						case 3:
							break;
						case 4:
							enumerator = type.GetMethods().ToList().Where(_003C_003Ec__DisplayClass15_2._003CGetMethodInfo_003Eb__1)
								.ToList()
								.GetEnumerator();
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
							{
								num3 = 0;
							}
							continue;
						case 6:
							_003C_003Ec__DisplayClass15_2.parametersList = ((IEnumerable<string>)roYEYZbPjWEdCsdqxmya(text3, new string[1] { (string)PfRHWebPH8jwvgxdW5Hy(--1360331293 ^ 0x51150E1F) }, StringSplitOptions.None)).ToList();
							num3 = 4;
							continue;
						case 2:
							methodInfo2 = type.GetMethod(text2);
							if ((object)methodInfo2 != null)
							{
								goto IL_0450;
							}
							num3 = 9;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
							{
								num3 = 0;
							}
							continue;
						case 9:
							methodInfo2 = type.GetMethods().FirstOrDefault(_003C_003Ec__DisplayClass15_._003CGetMethodInfo_003Eb__0);
							goto IL_0450;
						case 5:
							break;
							IL_0450:
							methodInfo = methodInfo2;
							num4 = 3;
							goto IL_0106;
							IL_0106:
							num3 = num4;
							continue;
						}
						break;
					}
				}
				catch (Exception innerException)
				{
					int num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num7 = 0;
					}
					switch (num7)
					{
					default:
						throw new ScriptExecuteException((string)eILpAGb1BoiDwaKIshGh(errorTitle, SR.T((string)PfRHWebPH8jwvgxdW5Hy(-1123633026 ^ -1123788010), _003C_003Ec__DisplayClass15_.scriptName)), innerException);
					}
				}
				goto default;
			case 2:
				if (!throwOnNotFound)
				{
					num2 = 4;
					break;
				}
				goto case 3;
			case 7:
				_003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
				num2 = 6;
				break;
			case 9:
				return methodInfo;
			}
		}
	}

	private static string GetTypeInfo(Type type)
	{
		//Discarded unreachable code: IL_011f, IL_012e, IL_013e, IL_014d, IL_016a, IL_0207, IL_0216
		int num = 9;
		string result = default(string);
		string text = default(string);
		List<string> list = default(List<string>);
		int num3 = default(int);
		Type[] genericArguments = default(Type[]);
		Type type2 = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 11:
					break;
				case 10:
					result = (string)Oxr78cb1bWyjN7KEtKNk(PfRHWebPH8jwvgxdW5Hy(-867826612 ^ -867770834), type.Namespace, type.Name, text);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 1;
					}
					continue;
				case 12:
					list = new List<string>();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 6;
					}
					continue;
				case 9:
					if (!type.IsGenericType)
					{
						num2 = 8;
						continue;
					}
					goto case 12;
				default:
					result = string.Format((string)PfRHWebPH8jwvgxdW5Hy(0x57A5235E ^ 0x57A7C74A), type.Namespace, type.Name);
					num2 = 2;
					continue;
				case 15:
					num3 = 0;
					num2 = 3;
					continue;
				case 4:
					num3++;
					num2 = 5;
					continue;
				case 3:
				case 5:
					if (num3 < genericArguments.Length)
					{
						num2 = 13;
						continue;
					}
					goto case 14;
				case 14:
					text = string.Join((string)PfRHWebPH8jwvgxdW5Hy(0x42643203 ^ 0x426460F3), list);
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 7;
					}
					continue;
				case 7:
				case 13:
					type2 = genericArguments[num3];
					num2 = 11;
					continue;
				case 6:
					genericArguments = type.GetGenericArguments();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num2 = 15;
					}
					continue;
				case 1:
				case 2:
					return result;
				}
				break;
			}
			list.Add(GetTypeInfo(type2));
			num = 4;
		}
	}

	protected virtual object ExecuteScript(string errorTitle, MethodInfo methodInfo, object scriptInstance, IEntity entity, Dictionary<string, object> parameters, Func<string, Type, object> parameterAccessor = null)
	{
		parameters = parameters ?? new Dictionary<string, object>();
		parameters[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -576189696)] = entity;
		List<object> list = new List<object>();
		ParameterInfo[] parameters2 = methodInfo.GetParameters();
		foreach (ParameterInfo parameterInfo in parameters2)
		{
			if (parameters.TryGetValue(parameterInfo.Name, out var value) && (value == null || parameterInfo.ParameterType.IsAssignableFrom(value.GetType())))
			{
				list.Add(value);
				continue;
			}
			value = null;
			if (parameterAccessor != null)
			{
				value = parameterAccessor(parameterInfo.Name, parameterInfo.ParameterType);
			}
			if (value == null && parameterInfo.ParameterType.IsValueType)
			{
				value = Activator.CreateInstance(parameterInfo.ParameterType);
			}
			list.Add(value);
		}
		try
		{
			object result = InvokeWithDiagnostics(methodInfo, scriptInstance, list.ToArray(), errorTitle);
			DynamicFormHelper.ProcessNewTablePartItems(entity, (EntityMetadata)MetadataLoader.LoadMetadata(entity.CastAsRealType().GetType()));
			return result;
		}
		catch (TargetInvocationException ex)
		{
			throw new ScriptExecuteException(errorTitle + (ex.InnerException ?? ex).Message, ex);
		}
		catch (Exception ex2)
		{
			throw new ScriptExecuteException(errorTitle + ex2.Message, ex2);
		}
	}

	public static object InvokeWithDiagnostics(MethodInfo methodInfo, object scriptInstance, object[] invokedParams, string errorTitle)
	{
		int num = 6;
		_003C_003Ec__DisplayClass18_0 _003C_003Ec__DisplayClass18_ = default(_003C_003Ec__DisplayClass18_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					_003C_003Ec__DisplayClass18_.result = null;
					num2 = 2;
					continue;
				case 3:
					return _003C_003Ec__DisplayClass18_.result;
				case 1:
					_003C_003Ec__DisplayClass18_.methodInfo = methodInfo;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					_003C_003Ec__DisplayClass18_.errorTitle = errorTitle;
					num = 7;
					break;
				case 6:
					_003C_003Ec__DisplayClass18_ = new _003C_003Ec__DisplayClass18_0();
					num2 = 5;
					continue;
				case 5:
					_003C_003Ec__DisplayClass18_.scriptInstance = scriptInstance;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					_003C_003Ec__DisplayClass18_.invokedParams = invokedParams;
					num2 = 4;
					continue;
				case 2:
					DiagnosticsManager.StartCall(_003C_003Ec__DisplayClass18_._003CInvokeWithDiagnostics_003Eb__0, _003C_003Ec__DisplayClass18_._003CInvokeWithDiagnostics_003Eb__1);
					num = 3;
					break;
				}
				break;
			}
		}
	}

	public EntityScriptingService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static EntityScriptingService()
	{
		int num = 2;
		int num2 = num;
		ParameterExpression parameterExpression = default(ParameterExpression);
		while (true)
		{
			switch (num2)
			{
			case 1:
				parameterExpression = (ParameterExpression)UL5UDHb1GUGu1nhgiZAp(sygHKObPlUZ3s1LgnGTR(typeof(string).TypeHandle), PfRHWebPH8jwvgxdW5Hy(-475857671 ^ -475838817));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				return;
			case 2:
				TRl5Y7b1hBaE5qMwZy9d();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 1;
				}
				continue;
			}
			getTypeFunc = MetadataLoader.UseCachingForFunc(Expression.Lambda<Func<string, Type>>(Expression.Call(null, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), parameterExpression), new ParameterExpression[1] { parameterExpression }));
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
			{
				num2 = 3;
			}
		}
	}

	internal static bool RGXWIqbPwhX7UtYqbdXm()
	{
		return Ycw8PmbPt7FKPdGqIp3d == null;
	}

	internal static EntityScriptingService fc1XN9bP4PFhs43UiQTL()
	{
		return Ycw8PmbPt7FKPdGqIp3d;
	}

	internal static Type pZgPuWbP6a8c6jvXyhgr(Type entityType, object P_1)
	{
		return GetScriptModuleType(entityType, P_1);
	}

	internal static object PfRHWebPH8jwvgxdW5Hy(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static int fc5mVGbPA2WRVORNJ0dc(object P_0, object P_1)
	{
		return ((string)P_0).IndexOf((string)P_1);
	}

	internal static object wElONibP7Ds5XoV5t0js(object P_0, int P_1)
	{
		return ((string)P_0).Substring(P_1);
	}

	internal static object VIFsXFbPxqs3JuAWV4bN(object P_0)
	{
		return ((AssemblyName)P_0).Name;
	}

	internal static bool jSpXm9bP0B6YAhWrOTYL(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static Type W4hLohbPmQh5cCHAUaBs(object P_0)
	{
		return ReflectionType.GetType((string)P_0);
	}

	internal static object jfYHcsbPyEEqFEATBhAX(object P_0)
	{
		return ((ClassMetadata)P_0).ScriptModuleTypeName;
	}

	internal static bool c2EZW6bPM6RTQCJLp2yl(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool aSNA0MbPJAuLd1gAI1co(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static bool jmWZ9fbP9OSrQeOLsvQV(object P_0, object P_1)
	{
		return (MethodInfo)P_0 != (MethodInfo)P_1;
	}

	internal static bool NYjFeSbPdJwT5WgSSMgB(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static Type sygHKObPlUZ3s1LgnGTR(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static Type hAbdWbbPrJW6R9pL9ITw(object P_0, object P_1)
	{
		return ((EntityScriptingService)P_0).GetScriptModuleType((IEntity)P_1);
	}

	internal static object M8UTCnbPgWcRmFXmLSDj(Type type)
	{
		return Locator.GetServiceNotNull(type);
	}

	internal static Type A3bi76bP5SfloYKp1Ght(object P_0, object P_1, object P_2)
	{
		return ((EntityScriptingService)P_0).GetScriptModuleType((IEntity)P_1, (string)P_2);
	}

	internal static object roYEYZbPjWEdCsdqxmya(object P_0, object P_1, StringSplitOptions P_2)
	{
		return ((string)P_0).Split((string[])P_1, P_2);
	}

	internal static bool Hhbn4XbPYeNah0Hp6jW9(object P_0, object P_1)
	{
		return ((string)P_0).Contains((string)P_1);
	}

	internal static int iSatrEbPLAvVE5Sv0OI4(object P_0, char P_1)
	{
		return ((string)P_0).IndexOf(P_1);
	}

	internal static object GHWSgkbPUdbsuRrOxYe2(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object GqGRqxbPs9dIwhPmcljN(object P_0)
	{
		return ((MethodBase)P_0).GetParameters();
	}

	internal static object meXal6bPcoBru4aB10Eh(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static object TS8BgbbPzBEwy9qFQhHP(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static bool nLXeUjb1FjEIZNQYfo3S(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object eILpAGb1BoiDwaKIshGh(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object ePL4yXb1WZmeDy1xc7OP()
	{
		return Logger.Log;
	}

	internal static void cImo1Bb1oP1feJUK4lkK(object P_0, object P_1)
	{
		((ILogger)P_0).Warn(P_1);
	}

	internal static object Oxr78cb1bWyjN7KEtKNk(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static void TRl5Y7b1hBaE5qMwZy9d()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object UL5UDHb1GUGu1nhgiZAp(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}
}
