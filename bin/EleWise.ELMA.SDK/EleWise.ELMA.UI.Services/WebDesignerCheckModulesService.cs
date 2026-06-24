using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Services;

[Service]
internal sealed class WebDesignerCheckModulesService : IWebDesignerCheckModulesService
{
	private readonly ModuleMetadataItemHeaderManager moduleMetadataItemHeaderManager;

	private readonly ICacheService cacheService;

	private readonly IModuleMetadataLoader moduleMetadataLoader;

	private static WebDesignerCheckModulesService YBSNsoUmYPARXpENO8L;

	public WebDesignerCheckModulesService(ModuleMetadataItemHeaderManager moduleMetadataItemHeaderManager, ICacheService cacheService, IModuleMetadataLoader moduleMetadataLoader)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		WGNVpIUJMrswvVEqCMO();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				this.moduleMetadataItemHeaderManager = moduleMetadataItemHeaderManager;
				num = 2;
				break;
			case 2:
				this.cacheService = cacheService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num = 1;
				}
				break;
			case 3:
				return;
			case 1:
				this.moduleMetadataLoader = moduleMetadataLoader;
				num = 3;
				break;
			}
		}
	}

	public CheckDesignerModuleResult[] CheckWebDesigner()
	{
		//Discarded unreachable code: IL_006d, IL_007c, IL_0148, IL_0232, IL_0241, IL_02f8, IL_0302, IL_0335, IL_0344, IL_0386, IL_0497, IL_04aa, IL_04b9
		int num = 7;
		List<CheckDesignerModuleResult> value = default(List<CheckDesignerModuleResult>);
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
		List<ModuleMetadataItemHeader> list = default(List<ModuleMetadataItemHeader>);
		string text = default(string);
		Version version = default(Version);
		List<ModuleMetadataItemHeader>.Enumerator enumerator = default(List<ModuleMetadataItemHeader>.Enumerator);
		ModuleMetadataItemHeader current = default(ModuleMetadataItemHeader);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					value = new List<CheckDesignerModuleResult>();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 1;
					}
					break;
				case 7:
					_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
					{
						num2 = 6;
					}
					break;
				case 12:
					if (xDFo4NUsUkFowk64b5F(list) != 0)
					{
						goto end_IL_0012;
					}
					goto case 2;
				case 11:
				{
					object obj2 = UgSpk8sBD8Itgxt573H(pSmYYFsFiJ7lQsMqPTI(moduleMetadataLoader.GetDefaultModuleVersion(ModuleMetadataItemHeaderManager.BuilderUiModuleUid)));
					text = obj2.ToString();
					int num5 = 3;
					if (!(((Version)obj2).ToString(num5) != version.ToString(num5)))
					{
						num2 = 9;
						break;
					}
					goto case 14;
				}
				case 5:
					_003C_003Ec__DisplayClass5_.designerModuleUids = ModuleMetadataItemHeaderManager.DesignerModules;
					num2 = 16;
					break;
				default:
					return (CheckDesignerModuleResult[])oHxruoUdiX1iQKLyJaA(value);
				case 4:
				case 8:
					cacheService.Insert((string)VUEbQRU9SMIAVFh5XCK(0x4785BC0D ^ 0x478568B3), value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					if (!cacheService.TryGetValue<List<CheckDesignerModuleResult>>((string)VUEbQRU9SMIAVFh5XCK(0x1DE3DD89 ^ 0x1DE30937), out value))
					{
						num2 = 17;
						break;
					}
					goto case 15;
				case 2:
				{
					List<CheckDesignerModuleResult> list4 = value;
					CheckDesignerModuleResult checkDesignerModuleResult2 = new CheckDesignerModuleResult();
					LjGenkUc2tWVX9T54vd(checkDesignerModuleResult2, VUEbQRU9SMIAVFh5XCK(-1426094279 ^ -1426107447));
					checkDesignerModuleResult2.CheckResult = (string)rPGJfpUzkei0bfqwIQ9(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD3DEF7E ^ 0xD3D3A5C));
					list4.Add(checkDesignerModuleResult2);
					num2 = 4;
					break;
				}
				case 15:
					return (CheckDesignerModuleResult[])oHxruoUdiX1iQKLyJaA(value);
				case 17:
					value = new List<CheckDesignerModuleResult>();
					num2 = 5;
					break;
				case 14:
				{
					List<CheckDesignerModuleResult> list2 = value;
					CheckDesignerModuleResult checkDesignerModuleResult = new CheckDesignerModuleResult
					{
						ModuleName = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x831A0C2)
					};
					s2EgSqsW4TVqYLiw2Yq(checkDesignerModuleResult, text);
					cNCItgso5dwGBSIyUcw(checkDesignerModuleResult, SR.T((string)VUEbQRU9SMIAVFh5XCK(-541731959 ^ -541784361), text, version.ToString()));
					list2.Add(checkDesignerModuleResult);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 0;
					}
					break;
				}
				case 13:
				case 18:
					version = VersionInfo.GetVersion<SR>();
					num2 = 11;
					break;
				case 3:
				case 9:
					enumerator = list.GetEnumerator();
					num2 = 10;
					break;
				case 10:
					try
					{
						while (true)
						{
							IL_03b3:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 2;
								goto IL_0306;
							}
							goto IL_0390;
							IL_0306:
							while (true)
							{
								switch (num3)
								{
								case 6:
									if (!PFqEyKsGXhvSaRADjOe(pUhkd9sh55oLEGB6aKf(YCFSYssbQlEveWkE5PH(current)), text))
									{
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
										{
											num3 = 0;
										}
										continue;
									}
									goto case 5;
								case 7:
									break;
								default:
									goto IL_03b3;
								case 5:
								{
									List<CheckDesignerModuleResult> list3 = value;
									CheckDesignerModuleResult checkDesignerModuleResult = new CheckDesignerModuleResult();
									LjGenkUc2tWVX9T54vd(checkDesignerModuleResult, current.Name);
									s2EgSqsW4TVqYLiw2Yq(checkDesignerModuleResult, pUhkd9sh55oLEGB6aKf(YCFSYssbQlEveWkE5PH(current)));
									cNCItgso5dwGBSIyUcw(checkDesignerModuleResult, SR.T((string)VUEbQRU9SMIAVFh5XCK(0x2ACE37D ^ 0x2AC357D), n0ChpFsEoUUxxpqyPbS(current), text));
									list3.Add(checkDesignerModuleResult);
									num3 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
									{
										num3 = 4;
									}
									continue;
								}
								case 3:
									if (current.Published == null)
									{
										num3 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
										{
											num3 = 0;
										}
										continue;
									}
									goto case 6;
								case 2:
									goto end_IL_03b3;
								}
								break;
							}
							goto IL_0390;
							IL_0390:
							current = enumerator.Current;
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
							{
								num3 = 3;
							}
							goto IL_0306;
							continue;
							end_IL_03b3:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 4;
				case 16:
				{
					ModuleMetadataItemHeaderManager obj = moduleMetadataItemHeaderManager;
					ParameterExpression parameterExpression = (ParameterExpression)jM8qiyUrLkLgBThoQDf(sKH25hUl4Bo4hEGVeQO(typeof(ModuleMetadataItemHeader).TypeHandle), VUEbQRU9SMIAVFh5XCK(-1824388195 ^ -1824349213));
					list = (from item in obj.Find(Expression.Lambda<Func<ModuleMetadataItemHeader, bool>>(Expression.Call((Expression)LmhCvtUjYaqssNig55G(O3ym0aUgc4JWPDVMHEK(_003C_003Ec__DisplayClass5_, sKH25hUl4Bo4hEGVeQO(typeof(_003C_003Ec__DisplayClass5_0).TypeHandle)), fpBmhqU5N67Bfbh3NDX((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)Kbb83FUYW3B9MsXFO6e((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(ICollection<Guid>).TypeHandle), (Expression)kRo6jUUURQABwDIZscY(parameterExpression, (MethodInfo)EEPQRNULCs4kmeDSFcw((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression }))
						orderby (string)_003C_003Ec.LxlHtHfU5utEWVmnc1GE(item)
						select item).ToList();
					num2 = 12;
					break;
				}
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 13;
		}
	}

	public void ClearCache()
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
				QlKUS1sfUo4MmGsPSM2(cacheService, VUEbQRU9SMIAVFh5XCK(-195614443 ^ -195560021));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void WGNVpIUJMrswvVEqCMO()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool ioqq8gUy83J9GDqF0OT()
	{
		return YBSNsoUmYPARXpENO8L == null;
	}

	internal static WebDesignerCheckModulesService c01guxUMVKI4uXkruGZ()
	{
		return YBSNsoUmYPARXpENO8L;
	}

	internal static object VUEbQRU9SMIAVFh5XCK(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object oHxruoUdiX1iQKLyJaA(object P_0)
	{
		return ((List<CheckDesignerModuleResult>)P_0).ToArray();
	}

	internal static Type sKH25hUl4Bo4hEGVeQO(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object jM8qiyUrLkLgBThoQDf(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object O3ym0aUgc4JWPDVMHEK(object P_0, Type P_1)
	{
		return Expression.Constant(P_0, P_1);
	}

	internal static object fpBmhqU5N67Bfbh3NDX(RuntimeFieldHandle P_0)
	{
		return FieldInfo.GetFieldFromHandle(P_0);
	}

	internal static object LmhCvtUjYaqssNig55G(object P_0, object P_1)
	{
		return Expression.Field((Expression)P_0, (FieldInfo)P_1);
	}

	internal static object Kbb83FUYW3B9MsXFO6e(RuntimeMethodHandle P_0, RuntimeTypeHandle P_1)
	{
		return MethodBase.GetMethodFromHandle(P_0, P_1);
	}

	internal static object EEPQRNULCs4kmeDSFcw(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object kRo6jUUURQABwDIZscY(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static int xDFo4NUsUkFowk64b5F(object P_0)
	{
		return ((List<ModuleMetadataItemHeader>)P_0).Count;
	}

	internal static void LjGenkUc2tWVX9T54vd(object P_0, object P_1)
	{
		((CheckDesignerModuleResult)P_0).ModuleName = (string)P_1;
	}

	internal static object rPGJfpUzkei0bfqwIQ9(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object pSmYYFsFiJ7lQsMqPTI(object P_0)
	{
		return ((ModuleVersion)P_0).Header;
	}

	internal static object UgSpk8sBD8Itgxt573H(object P_0)
	{
		return ((ModuleVersionHeader)P_0).Version;
	}

	internal static void s2EgSqsW4TVqYLiw2Yq(object P_0, object P_1)
	{
		((CheckDesignerModuleResult)P_0).Version = (string)P_1;
	}

	internal static void cNCItgso5dwGBSIyUcw(object P_0, object P_1)
	{
		((CheckDesignerModuleResult)P_0).CheckResult = (string)P_1;
	}

	internal static object YCFSYssbQlEveWkE5PH(object P_0)
	{
		return ((ModuleMetadataItemHeader)P_0).Published;
	}

	internal static object pUhkd9sh55oLEGB6aKf(object P_0)
	{
		return ((ModuleMetadataItem)P_0).Version;
	}

	internal static bool PFqEyKsGXhvSaRADjOe(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object n0ChpFsEoUUxxpqyPbS(object P_0)
	{
		return ((ModuleMetadataItemHeader)P_0).DisplayName;
	}

	internal static void QlKUS1sfUo4MmGsPSM2(object P_0, object P_1)
	{
		((ICacheService)P_0).Remove((string)P_1);
	}
}
