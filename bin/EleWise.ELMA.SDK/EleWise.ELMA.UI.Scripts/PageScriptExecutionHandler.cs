using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Services.Scope;
using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Scripts;

[Component]
internal sealed class PageScriptExecutionHandler : IScriptExecutionHandler
{
	private readonly FormDescriptorProvider formDescriptorProvider;

	private readonly IEnumerable<IObjectFormProvider> objectFormProviders;

	private readonly IExecutionScopeFactory executionScopeFactory;

	private static PageScriptExecutionHandler awU9ApYZdeDTkbKoxJw;

	public PageScriptExecutionHandler(FormDescriptorProvider formDescriptorProvider, IEnumerable<IObjectFormProvider> objectFormProviders, IExecutionScopeFactory executionScopeFactory)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.formDescriptorProvider = formDescriptorProvider;
		this.objectFormProviders = objectFormProviders;
		this.executionScopeFactory = executionScopeFactory;
	}

	public bool Check(ScriptExecutionParams parameters)
	{
		return Dew06DYSVgqLgoI3hGr(IqUeWiYVERjHsC1bmpF(parameters)) == PageMetadata.TypeUid;
	}

	public ScriptExecutionResult ExecuteScript(ScriptExecutionParams parameters)
	{
		//Discarded unreachable code: IL_00ab, IL_00e3, IL_011b, IL_0154, IL_0187, IL_01f5, IL_042c, IL_0482, IL_0491, IL_049c, IL_04ef, IL_058c, IL_05ab, IL_05ba, IL_05e7, IL_05f6
		int num = 9;
		int num2 = num;
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
		IExecutionScope executionScope = default(IExecutionScope);
		Type controllerType = default(Type);
		string errorTitle = default(string);
		ScriptMethodInfo scriptMethodInfo = default(ScriptMethodInfo);
		PageDescriptor pageDescriptor = default(PageDescriptor);
		IEnumerator<PropertyViewInfo> enumerator = default(IEnumerator<PropertyViewInfo>);
		PropertyViewInfoContainer propertyViewInfoContainer = default(PropertyViewInfoContainer);
		Type type = default(Type);
		object item = default(object);
		FormViewItem formViewItem = default(FormViewItem);
		IObjectFormProvider objectFormProvider = default(IObjectFormProvider);
		PropertyViewInfo current = default(PropertyViewInfo);
		TypeSettings typeSettings = default(TypeSettings);
		while (true)
		{
			switch (num2)
			{
			default:
				try
				{
					_003C_003Ec__DisplayClass5_.controllerInstance = executionScope.Resolve(controllerType);
					int num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num7 = 0;
					}
					switch (num7)
					{
					case 0:
						break;
					}
				}
				finally
				{
					if (executionScope != null)
					{
						int num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num8 = 0;
						}
						while (true)
						{
							switch (num8)
							{
							default:
								h7L8tyYeMctaZCbohJB(executionScope);
								num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
								{
									num8 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
				goto case 12;
			case 19:
				try
				{
					ScriptExecutionService.ScriptExecution(_003C_003Ec__DisplayClass5_._003CExecuteScript_003Eb__1, errorTitle);
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				catch (Exception ex)
				{
					int num6 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num6 = 1;
					}
					while (true)
					{
						switch (num6)
						{
						case 1:
							NPFwSTYap4dTWjgCUkR(OufXlAYpnCpwIxPF2L4(), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -672072641), scriptMethodInfo.Name, controllerType), ex);
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
							{
								num6 = 0;
							}
							break;
						default:
							throw;
						}
					}
				}
				goto case 5;
			case 13:
				controllerType = pageDescriptor.ControllerType;
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num2 = 3;
				}
				break;
			case 5:
				if (_003C_003Ec__DisplayClass5_.viewModel.Context == null)
				{
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 4;
			case 7:
				enumerator = propertyViewInfoContainer.GetAll().GetEnumerator();
				num2 = 16;
				break;
			case 2:
				_003C_003Ec__DisplayClass5_.viewModel = (IPageLoadViewModel)Activator.CreateInstance(type, yyjfoYYk0wPts16F5yt(pageDescriptor), item, formViewItem, propertyViewInfoContainer);
				num2 = 14;
				break;
			case 24:
				throw new Exception((string)IZu6N6YKG1tsMEaIbXd(QHtdLoYqLoMQ3jv4JZp(-29254301 ^ -29272371)));
			case 3:
				throw new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A4CB069), OQP83sYRPwEUOLcJKA1(_003C_003Ec__DisplayClass5_.modelInfo)));
			case 10:
			case 18:
			{
				ScriptExecutionResult scriptExecutionResult = new ScriptExecutionResult();
				beW7IUY6kpa70wnvC8K(scriptExecutionResult, vT8irDYDh0X2dgPqeVn(_003C_003Ec__DisplayClass5_.viewModel));
				l9Uu0DYHYgdhYk6RyQO(scriptExecutionResult, propertyViewInfoContainer);
				return scriptExecutionResult;
			}
			case 8:
				_003C_003Ec__DisplayClass5_.modelInfo = parameters.ModelInfo;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num2 = 1;
				}
				break;
			case 15:
				if (pageDescriptor != null)
				{
					objectFormProvider = objectFormProviders.FirstOrDefault(_003C_003Ec__DisplayClass5_._003CExecuteScript_003Eb__0);
					num2 = 20;
				}
				else
				{
					num2 = 3;
				}
				break;
			case 12:
				if (_003C_003Ec__DisplayClass5_.controllerInstance == null)
				{
					num2 = 23;
					break;
				}
				scriptMethodInfo = ScriptMethodInfoHelper.Deserialize(parameters.ScriptName);
				num2 = 17;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
				{
					num2 = 13;
				}
				break;
			case 22:
				errorTitle = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740319698), owwRXcY3VFkKj7rkYJT(MIaWT4YNo1Krq1pWKSK(pageDescriptor)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 19;
				}
				break;
			case 6:
				executionScope = ((IExecutionScopeBuilder)mtcKTUY2sw2YlcKOGuH(executionScopeFactory)).AddRegistration(controllerType, Array.Empty<Type>()).StartScope();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 0;
				}
				break;
			case 9:
				_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
				num2 = 8;
				break;
			case 1:
				pageDescriptor = CMUmTPYi2KJclVtUpFN(formDescriptorProvider, Dew06DYSVgqLgoI3hGr(_003C_003Ec__DisplayClass5_.modelInfo), _003C_003Ec__DisplayClass5_.modelInfo.SubTypeUid, false) as PageDescriptor;
				num2 = 15;
				break;
			case 16:
				try
				{
					while (true)
					{
						IL_052d:
						int num3;
						if (!jlQ5qVY45LLWyyRiOV8(enumerator))
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
							{
								num3 = 0;
							}
							goto IL_04a0;
						}
						goto IL_0553;
						IL_0553:
						current = enumerator.Current;
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
						{
							num3 = 0;
						}
						goto IL_04a0;
						IL_04a0:
						while (true)
						{
							switch (num3)
							{
							case 1:
								typeSettings = (TypeSettings)zmWOkCYtStLDu2YcLc7(vT8irDYDh0X2dgPqeVn(_003C_003Ec__DisplayClass5_.viewModel), current.Uid);
								num3 = 6;
								continue;
							case 6:
								if (typeSettings == null)
								{
									num3 = 5;
									continue;
								}
								goto case 4;
							case 4:
								iudd6sYwnZbeq75pOZw(current, typeSettings);
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
								{
									num3 = 0;
								}
								continue;
							case 3:
							case 5:
								goto IL_052d;
							case 2:
								goto IL_0553;
							case 0:
								break;
							}
							break;
						}
						break;
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 2;
						goto IL_0590;
					}
					goto IL_05c5;
					IL_0590:
					switch (num4)
					{
					default:
						goto end_IL_057b;
					case 2:
						goto end_IL_057b;
					case 1:
						break;
					case 0:
						goto end_IL_057b;
					}
					goto IL_05c5;
					IL_05c5:
					h7L8tyYeMctaZCbohJB(enumerator);
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num4 = 0;
					}
					goto IL_0590;
					end_IL_057b:;
				}
				goto case 10;
			case 21:
			{
				(object, ClassMetadata) objectInfo = objectFormProvider.GetObjectInfo(Dew06DYSVgqLgoI3hGr(_003C_003Ec__DisplayClass5_.modelInfo), _003C_003Ec__DisplayClass5_.modelInfo.SubTypeUid, (string)WcXJGTYOssIE3jfu1ps(parameters));
				item = objectInfo.Item1;
				propertyViewInfoContainer = new PropertyViewInfoContainer(objectInfo.Item2);
				num2 = 2;
				break;
			}
			case 20:
				if (objectFormProvider != null)
				{
					formViewItem = (FormViewItem)tZNTbrYXyfNuXZlJVsM(objectFormProvider, null, OQP83sYRPwEUOLcJKA1(_003C_003Ec__DisplayClass5_.modelInfo));
					num2 = 11;
				}
				else
				{
					num2 = 24;
				}
				break;
			case 4:
				if (propertyViewInfoContainer != null)
				{
					num2 = 7;
					break;
				}
				goto case 10;
			case 11:
				type = TCUFtQYTmF3ds9mTsfD(typeof(PageLoadViewModel<>).TypeHandle).MakeGenericType(tIfwwiYngHyaI7vuoAx(yyjfoYYk0wPts16F5yt(pageDescriptor)));
				num2 = 21;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num2 = 16;
				}
				break;
			case 17:
				_003C_003Ec__DisplayClass5_.method = (MethodInfo)Dwq176Y1dDtBFYW49bw(controllerType, Myhq4bYP4Pp3o00883d(scriptMethodInfo));
				num2 = 22;
				break;
			case 14:
				_003C_003Ec__DisplayClass5_.controllerInstance = null;
				num2 = 13;
				break;
			case 23:
				return null;
			}
		}
	}

	internal static object IqUeWiYVERjHsC1bmpF(object P_0)
	{
		return ((ScriptExecutionParams)P_0).ModelInfo;
	}

	internal static Guid Dew06DYSVgqLgoI3hGr(object P_0)
	{
		return ((ModelInfo)P_0).TypeUid;
	}

	internal static bool TdG1iHYusdCitRdIvjN()
	{
		return awU9ApYZdeDTkbKoxJw == null;
	}

	internal static PageScriptExecutionHandler SMSr44YIJqmKDGREyRL()
	{
		return awU9ApYZdeDTkbKoxJw;
	}

	internal static object CMUmTPYi2KJclVtUpFN(object P_0, Guid metadataType, Guid headerUid, bool forEmulation)
	{
		return ((FormDescriptorProvider)P_0).GetDescriptorByHeaderUid(metadataType, headerUid, forEmulation);
	}

	internal static Guid OQP83sYRPwEUOLcJKA1(object P_0)
	{
		return ((ModelInfo)P_0).SubTypeUid;
	}

	internal static object QHtdLoYqLoMQ3jv4JZp(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object IZu6N6YKG1tsMEaIbXd(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object tZNTbrYXyfNuXZlJVsM(object P_0, object P_1, Guid formUid)
	{
		return ((IObjectFormProvider)P_0).GetFormByUid(P_1, formUid);
	}

	internal static Type TCUFtQYTmF3ds9mTsfD(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object yyjfoYYk0wPts16F5yt(object P_0)
	{
		return ((PageDescriptor)P_0).Content;
	}

	internal static Type tIfwwiYngHyaI7vuoAx(object P_0)
	{
		return ((FormPartDescriptor<PageDescriptor, PageContentMetadata>)P_0).ContextType;
	}

	internal static object WcXJGTYOssIE3jfu1ps(object P_0)
	{
		return ((ScriptExecutionParams)P_0).Model;
	}

	internal static object mtcKTUY2sw2YlcKOGuH(object P_0)
	{
		return ((IExecutionScopeFactory)P_0).CreateScope();
	}

	internal static void h7L8tyYeMctaZCbohJB(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object Myhq4bYP4Pp3o00883d(object P_0)
	{
		return ((ScriptMethodInfo)P_0).Name;
	}

	internal static object Dwq176Y1dDtBFYW49bw(Type type, object P_1)
	{
		return ScriptHelper.GetMethodInfo(type, (string)P_1);
	}

	internal static object MIaWT4YNo1Krq1pWKSK(object P_0)
	{
		return ((FormDescriptor)P_0).Metadata;
	}

	internal static object owwRXcY3VFkKj7rkYJT(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object OufXlAYpnCpwIxPF2L4()
	{
		return Logger.Log;
	}

	internal static void NPFwSTYap4dTWjgCUkR(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static object vT8irDYDh0X2dgPqeVn(object P_0)
	{
		return ((IFormViewModel)P_0).Context;
	}

	internal static object zmWOkCYtStLDu2YcLc7(object P_0, Guid propertyUid)
	{
		return ((IEntity)P_0).LoadPropertyInstanceSettings(propertyUid);
	}

	internal static void iudd6sYwnZbeq75pOZw(object P_0, object P_1)
	{
		((PropertyViewInfo)P_0).Settings = (TypeSettings)P_1;
	}

	internal static bool jlQ5qVY45LLWyyRiOV8(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void beW7IUY6kpa70wnvC8K(object P_0, object P_1)
	{
		((ScriptExecutionResult)P_0).Model = P_1;
	}

	internal static void l9Uu0DYHYgdhYk6RyQO(object P_0, object P_1)
	{
		((ScriptExecutionResult)P_0).PropertyContainer = (PropertyViewInfoContainer)P_1;
	}
}
