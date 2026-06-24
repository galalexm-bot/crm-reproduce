using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Scope;
using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Services;

[Component]
public abstract class UIDynamicFormProvider : IDynamicFormsProvider
{
	public const string ResultDataItemName = "UIFormResult";

	internal static UIDynamicFormProvider vRUklecPRvACKAwUYiK;

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
				case 1:
					_003CExecutionScopeFactory_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
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

	public abstract Guid Uid { get; }

	public Type GetEntityType(DynamicFormSettings settings)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (settings != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 1;
			default:
				return null;
			case 1:
				return null;
			case 2:
				ParseViewItemParams((string)e0bMq2c3QWcf6IoD8Ek(settings));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void ExecuteScript(IEntity entity, RootViewItem view, DynamicFormSettings settings, string scriptName, DynamicFormResultData resultData)
	{
		//Discarded unreachable code: IL_0109, IL_0158, IL_0162, IL_0171, IL_0180, IL_0244, IL_027c, IL_02b4, IL_0305, IL_033f, IL_034e, IL_035e, IL_03af, IL_045c, IL_048e, IL_049d, IL_06f3, IL_0702, IL_07a2
		int num = 34;
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		IEntity entity2 = default(IEntity);
		FormDescriptor formDescriptor = default(FormDescriptor);
		object obj = default(object);
		ITablePartItem tablePartItem2 = default(ITablePartItem);
		UIViewItemParams uIViewItemParams = default(UIViewItemParams);
		IExecutionScope executionScope = default(IExecutionScope);
		object obj2 = default(object);
		Type type = default(Type);
		ParameterInfo parameterInfo = default(ParameterInfo);
		ParameterInfo[] parameters = default(ParameterInfo[]);
		int num3 = default(int);
		ITablePartItem tablePartItem = default(ITablePartItem);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				string text2;
				switch (num2)
				{
				case 56:
					if (_003C_003Ec__DisplayClass8_.controllerInstance == null)
					{
						num2 = 25;
						continue;
					}
					entity2 = entity;
					num2 = 4;
					continue;
				case 45:
					text2 = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307E4605), formDescriptor.Metadata.Name);
					goto IL_07f4;
				case 33:
					if (settings == null)
					{
						num2 = 24;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
						{
							num2 = 28;
						}
						continue;
					}
					goto case 10;
				case 26:
					obj = cxNELycywqaOVYyTNcm(this, iOCtdIcmagOKiCuDCaX(((object[])YyuxoMc0tCd2sc6fQdZ(_003C_003Ec__DisplayClass8_.method))[0]), formDescriptor, tablePartItem2, view, uIViewItemParams);
					num2 = 22;
					continue;
				case 53:
					executionScope = ((IExecutionScopeBuilder)HhVmwLctABQDbhhNBOa(ExecutionScopeFactory)).AddRegistration(mOyyyXcw2gBsSN5tgrH(formDescriptor), Array.Empty<Type>()).StartScope();
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 36;
					}
					continue;
				case 36:
					try
					{
						_003C_003Ec__DisplayClass8_.controllerInstance = Bqi2onc4BYhb3sgDHjx(executionScope, mOyyyXcw2gBsSN5tgrH(formDescriptor));
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					finally
					{
						if (executionScope != null)
						{
							int num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
							{
								num5 = 1;
							}
							while (true)
							{
								switch (num5)
								{
								case 1:
									Bg8yXyc6CSrEunVaI7K(executionScope);
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
									{
										num5 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
					goto case 56;
				case 15:
					return;
				case 23:
					if (obj2 != null)
					{
						num2 = 18;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
						{
							num2 = 14;
						}
						continue;
					}
					return;
				case 55:
					return;
				case 27:
					return;
				case 38:
					_003C_003Ec__DisplayClass8_.method = GetMethodInfo(type, scriptName);
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 43;
					}
					continue;
				case 28:
					return;
				case 17:
					CpHmAIcx5R2YJ4cbDMX(type, scriptName);
					num = 15;
					break;
				case 5:
					_003C_003Ec__DisplayClass8_.controllerInstance = null;
					num2 = 30;
					continue;
				case 20:
					return;
				case 21:
					uIViewItemParams = (UIViewItemParams)OkCbNUcp6cPZj5ICehw(this, e0bMq2c3QWcf6IoD8Ek(settings));
					num2 = 57;
					continue;
				case 29:
					obj = CreateViewModelType(iOCtdIcmagOKiCuDCaX(_003C_003Ec__DisplayClass8_.method.GetParameters()[0]), formDescriptor, entity2, view, uIViewItemParams);
					num2 = 47;
					continue;
				case 48:
					parameterInfo = parameters[num3];
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num2 = 16;
					}
					continue;
				case 37:
					_003C_003Ec__DisplayClass8_.parameterValues.Add(null);
					num = 35;
					break;
				case 24:
				case 50:
					if (entity2 == null)
					{
						num2 = 40;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
						{
							num2 = 33;
						}
						continue;
					}
					goto case 46;
				case 52:
					if (tablePartItem2 == null)
					{
						num = 7;
						break;
					}
					goto case 51;
				case 57:
					formDescriptor = (FormDescriptor)LHIKPecaAn5GHgJmjNP(uIViewItemParams);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 5;
					}
					continue;
				case 40:
					return;
				case 43:
					if (!wwOwqWc7bMbrPycMFAB(_003C_003Ec__DisplayClass8_.method, null))
					{
						if (tablePartItem2 == null)
						{
							num2 = 24;
							continue;
						}
						goto case 19;
					}
					num2 = 17;
					continue;
				case 10:
					if (scriptName == null)
					{
						return;
					}
					num2 = 21;
					continue;
				case 4:
					tablePartItem2 = entity as ITablePartItem;
					num2 = 52;
					continue;
				case 44:
					if (!(NCHXWOcJUmRysbIdAJb(formDescriptor) is PageMetadata))
					{
						num2 = 43;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num2 = 45;
						}
						continue;
					}
					text2 = SR.T((string)hCojN5c9CSLyyFcdstx(-1633514411 ^ -1633531985), pbp0UpcdbwZUqmGRd70(NCHXWOcJUmRysbIdAJb(formDescriptor)));
					goto IL_07f4;
				case 46:
					entity2 = entity2.CastAsRealType();
					num2 = 29;
					continue;
				case 22:
					_003C_003Ec__DisplayClass8_.parameterValues.Add(obj);
					num = 9;
					break;
				default:
					_003C_003Ec__DisplayClass8_.parameterValues = new List<object>();
					num2 = 39;
					continue;
				case 34:
					_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
					num2 = 33;
					continue;
				case 8:
					return;
				case 9:
				case 41:
					parameters = _003C_003Ec__DisplayClass8_.method.GetParameters();
					num2 = 42;
					continue;
				case 11:
					if (!iOCtdIcmagOKiCuDCaX(parameterInfo).IsAssignableFrom(entity.GetType()))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 37;
				case 2:
				case 13:
					if (tablePartItem == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 54;
				case 16:
					if (entity is ITablePartItem)
					{
						num2 = 11;
						continue;
					}
					goto case 1;
				case 32:
					sB2UEXclbX4Tx2qtkeT(new Action(_003C_003Ec__DisplayClass8_._003CExecuteScript_003Eb__0), text);
					num2 = 6;
					continue;
				case 31:
				case 35:
					num3++;
					num2 = 14;
					continue;
				case 39:
					type = _003C_003Ec__DisplayClass8_.controllerInstance.GetType();
					num = 38;
					break;
				case 19:
					tablePartItem2 = tablePartItem2.CastAsRealType();
					num2 = 26;
					continue;
				case 51:
					tablePartItem = tablePartItem2;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 1;
					}
					continue;
				case 12:
				case 14:
					if (num3 >= parameters.Length)
					{
						num2 = 44;
						continue;
					}
					goto case 48;
				case 30:
					if (npdZZxcDfKfhjZpj1c1(formDescriptor.ControllerType, null))
					{
						num = 53;
						break;
					}
					goto case 56;
				case 18:
					resultData.Data[(string)hCojN5c9CSLyyFcdstx(0x49E27B8A ^ 0x49E2A1B8)] = obj2;
					num2 = 55;
					continue;
				case 42:
					num3 = e8UXlGcM36MoUw0J72c(_003C_003Ec__DisplayClass8_.parameterValues);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 12;
					}
					continue;
				case 54:
					entity2 = tablePartItem.Parent;
					num2 = 49;
					continue;
				case 25:
					hkWnbncAG6hTMgOe4Fr(EVlHcDcHXfEPCXyNDWe(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1765851862 ^ -1765809076));
					num2 = 27;
					continue;
				case 47:
					_003C_003Ec__DisplayClass8_.parameterValues.Add(obj);
					num2 = 41;
					continue;
				case 1:
				case 3:
					_003C_003Ec__DisplayClass8_.parameterValues.Add(null);
					num2 = 31;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 11;
					}
					continue;
				case 6:
					obj2 = FjNjeBcrsQSBvfkUH84(this, obj);
					num2 = 23;
					continue;
				case 49:
					{
						tablePartItem = tablePartItem.Parent as ITablePartItem;
						num2 = 13;
						continue;
					}
					IL_07f4:
					text = text2;
					num2 = 32;
					continue;
				}
				break;
			}
		}
	}

	public string GetPropertyValueChangeScriptName(IEntity entity, RootViewItem view, DynamicFormSettings settings, string propertyName)
	{
		//Discarded unreachable code: IL_008c, IL_0096, IL_00a5, IL_010c, IL_011b, IL_0173, IL_0182, IL_01a2, IL_01b1
		int num = 10;
		FormDescriptor formDescriptor = default(FormDescriptor);
		Type typeByUid = default(Type);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		FormPartMetadata partMetadata = default(FormPartMetadata);
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 14:
					if (entity != null)
					{
						num2 = 7;
						continue;
					}
					goto case 6;
				case 4:
					if (formDescriptor == null)
					{
						num2 = 11;
						continue;
					}
					goto case 1;
				case 6:
					obj = (EntityMetadata)MetadataLoader.LoadMetadata(typeByUid);
					break;
				case 8:
					if (propertyMetadata == null)
					{
						num2 = 3;
						continue;
					}
					return (string)zLMc5ecjmVc4rkyi31k(propertyMetadata);
				case 1:
					if (partMetadata != null)
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 11;
				case 11:
				case 12:
					return null;
				case 5:
					typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(YnSAsYc5dviIf3WtT3A(MQ2OcGcgxUoCfs4atGP(partMetadata)));
					num2 = 14;
					continue;
				case 9:
					_003C_003Ec__DisplayClass9_.propertyName = propertyName;
					num2 = 13;
					continue;
				case 3:
					return null;
				default:
					return null;
				case 2:
					goto end_IL_0012;
				case 13:
					if (settings != null)
					{
						num2 = 2;
						continue;
					}
					goto default;
				case 10:
					_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					obj = (EntityMetadata)MetadataLoader.LoadMetadata(entity.GetType());
					break;
				}
				propertyMetadata = ((ClassMetadata)obj).Properties.FirstOrDefault(_003C_003Ec__DisplayClass9_._003CGetPropertyValueChangeScriptName_003Eb__0);
				num2 = 8;
				continue;
				end_IL_0012:
				break;
			}
			UIViewItemParams uIViewItemParams = ParseViewItemParams((string)e0bMq2c3QWcf6IoD8Ek(settings));
			formDescriptor = (FormDescriptor)LHIKPecaAn5GHgJmjNP(uIViewItemParams);
			partMetadata = uIViewItemParams.PartMetadata;
			num = 4;
		}
	}

	protected virtual UIViewItemParams ParseViewItemParams(string dynamicFormsProviderData)
	{
		return new UIViewItemParams(dynamicFormsProviderData);
	}

	protected abstract Type GetItemViewModelType(Type itemType, FormDescriptor descriptor);

	protected abstract Type GetViewModelType(Type entityType, FormDescriptor descriptor);

	protected abstract object CreateItemViewModelType(Type itemViewModelType, FormDescriptor descriptor, IEntity entity, RootViewItem view, UIViewItemParams viewItemParams);

	protected abstract object CreateViewModelType(Type viewModelType, FormDescriptor descriptor, IEntity entity, RootViewItem view, UIViewItemParams viewItemParams);

	protected abstract object GetResult(object viewModel);

	private MethodInfo GetMethodInfo(Type type, string scriptName)
	{
		//Discarded unreachable code: IL_0154, IL_0163, IL_01c3, IL_01cd, IL_023d, IL_0349, IL_035c
		int num = 8;
		int num2 = num;
		string text = default(string);
		_003C_003Ec__DisplayClass16_1 _003C_003Ec__DisplayClass16_2 = default(_003C_003Ec__DisplayClass16_1);
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = default(_003C_003Ec__DisplayClass16_0);
		MethodInfo result = default(MethodInfo);
		List<MethodInfo>.Enumerator enumerator = default(List<MethodInfo>.Enumerator);
		MethodInfo current = default(MethodInfo);
		List<string> values = default(List<string>);
		while (true)
		{
			MethodInfo methodInfo;
			switch (num2)
			{
			case 9:
				if (!text.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1870893695)))
				{
					num2 = 12;
					continue;
				}
				goto default;
			case 5:
				_003C_003Ec__DisplayClass16_2.scriptShortName = (string)TN1snJcUTEuyokAs9P1(text, 0, YuIscgcLWoJICvwJQjc(text, '('));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 0;
				}
				continue;
			case 10:
				text = ((IEnumerable<string>)lqtKqOcYJhw6n174wGS(_003C_003Ec__DisplayClass16_.scriptName, new string[1] { (string)hCojN5c9CSLyyFcdstx(-1876063057 ^ -1876078839) }, StringSplitOptions.None)).First();
				num2 = 9;
				continue;
			case 12:
				methodInfo = type.GetMethod(text);
				if ((object)methodInfo == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 11;
					}
					continue;
				}
				break;
			case 6:
				result = null;
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num2 = 10;
				}
				continue;
			case 2:
			case 4:
				return result;
			default:
				_003C_003Ec__DisplayClass16_2 = new _003C_003Ec__DisplayClass16_1();
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 2;
				}
				continue;
			case 1:
				enumerator = type.GetMethods().Where(_003C_003Ec__DisplayClass16_2._003CGetMethodInfo_003Eb__1).ToList()
					.GetEnumerator();
				num2 = 3;
				continue;
			case 8:
				_003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 2;
				}
				continue;
			case 3:
				try
				{
					while (true)
					{
						IL_0247:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 3;
							goto IL_01d1;
						}
						goto IL_01f7;
						IL_01d1:
						while (true)
						{
							switch (num3)
							{
							case 1:
								return result;
							case 3:
								return result;
							case 5:
								break;
							case 6:
								result = current;
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
								{
									num3 = 1;
								}
								continue;
							case 4:
								goto IL_0247;
							case 2:
							{
								object obj = bctLcMccoMKkrF6deT6(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1637C429 ^ 0x16371E67), CR26EscsgS46FpZwqfw(current), string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105212654), values));
								text = (string)Nhc4obzFLYuCEktiny3(FFeAjJczaXETYYpDnGF(text, '+', '.'), hCojN5c9CSLyyFcdstx(--1333735954 ^ 0x4F7F7B30), "");
								if (!VpOBWuzBiExIPPlRAU9(obj, text))
								{
									num3 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
									{
										num3 = 6;
									}
									continue;
								}
								goto IL_0247;
							}
							default:
								values = current.GetParameters().Select(delegate(ParameterInfo q)
								{
									int num5 = 1;
									int num6 = num5;
									string text2 = default(string);
									while (true)
									{
										switch (num6)
										{
										case 1:
											text2 = (string)_003C_003Ec.BqXvEOfsnbllWyUfSfvb(_003C_003Ec.dTveDxfsk4DiBwdcFq9n(q));
											num6 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
											{
												num6 = 0;
											}
											break;
										default:
											return (string)_003C_003Ec.NEl6bxfs2vcfZDZCmZZP(text2, 1, _003C_003Ec.YVTcXkfsOvHlM0eHosfR(text2) - 2);
										}
									}
								}).ToList();
								num3 = 2;
								continue;
							}
							break;
						}
						goto IL_01f7;
						IL_01f7:
						current = enumerator.Current;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
						{
							num3 = 0;
						}
						goto IL_01d1;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			case 7:
				_003C_003Ec__DisplayClass16_.scriptName = scriptName;
				num2 = 6;
				continue;
			case 11:
				methodInfo = type.GetMethods().FirstOrDefault(_003C_003Ec__DisplayClass16_._003CGetMethodInfo_003Eb__0);
				break;
			}
			result = methodInfo;
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
			{
				num2 = 2;
			}
		}
	}

	private static string GetTypeInfo(Type type)
	{
		//Discarded unreachable code: IL_005d, IL_0139, IL_0148, IL_01aa
		int num = 3;
		int num2 = num;
		Type[] genericArguments = default(Type[]);
		Type type2 = default(Type);
		int num3 = default(int);
		List<string> list = default(List<string>);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			switch (num2)
			{
			case 7:
				genericArguments = type.GetGenericArguments();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num2 = 0;
				}
				continue;
			case 10:
			case 11:
				type2 = genericArguments[num3];
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num2 = 6;
				}
				continue;
			case 6:
				list.Add((string)ioJXPJzWkF8SFIY7lSf(type2));
				num2 = 12;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				text = string.Join((string)hCojN5c9CSLyyFcdstx(0x3C5338FF ^ 0x3C536A0F), list);
				num2 = 13;
				continue;
			case 13:
				result = (string)vwmCmjzoWaNOgjGq1W6(hCojN5c9CSLyyFcdstx(0x3B36AB09 ^ 0x3B36716B), type.Namespace, type.Name, text);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 8;
				}
				continue;
			default:
				num3 = 0;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num2 = 14;
				}
				continue;
			case 3:
				if (type.IsGenericType)
				{
					num2 = 2;
					continue;
				}
				break;
			case 12:
				num3++;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
				{
					num2 = 2;
				}
				continue;
			case 4:
			case 8:
				return result;
			case 5:
			case 14:
				if (num3 < genericArguments.Length)
				{
					num2 = 11;
					continue;
				}
				goto case 1;
			case 2:
				list = new List<string>();
				num2 = 7;
				continue;
			case 9:
				break;
			}
			result = (string)clEutvzb3NghdUSdpnF(hCojN5c9CSLyyFcdstx(0x66F566B6 ^ 0x66F5BC34), FFeAjJczaXETYYpDnGF(type.FullName, '+', '.'));
			num2 = 4;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
			{
				num2 = 4;
			}
		}
	}

	protected UIDynamicFormProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		cW9lmYzhTi3h9p8L98T();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool Od8uYgc1TO5uB6UXTf2()
	{
		return vRUklecPRvACKAwUYiK == null;
	}

	internal static UIDynamicFormProvider sYsMQccNEYxIZVvBAOy()
	{
		return vRUklecPRvACKAwUYiK;
	}

	internal static object e0bMq2c3QWcf6IoD8Ek(object P_0)
	{
		return ((DynamicFormSettings)P_0).DynamicFormsProviderData;
	}

	internal static object OkCbNUcp6cPZj5ICehw(object P_0, object P_1)
	{
		return ((UIDynamicFormProvider)P_0).ParseViewItemParams((string)P_1);
	}

	internal static object LHIKPecaAn5GHgJmjNP(object P_0)
	{
		return ((UIViewItemParams)P_0).FormDescriptor;
	}

	internal static bool npdZZxcDfKfhjZpj1c1(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object HhVmwLctABQDbhhNBOa(object P_0)
	{
		return ((IExecutionScopeFactory)P_0).CreateScope();
	}

	internal static Type mOyyyXcw2gBsSN5tgrH(object P_0)
	{
		return ((FormDescriptor)P_0).ControllerType;
	}

	internal static object Bqi2onc4BYhb3sgDHjx(object P_0, Type objectType)
	{
		return ((IExecutionScope)P_0).Resolve(objectType);
	}

	internal static void Bg8yXyc6CSrEunVaI7K(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object EVlHcDcHXfEPCXyNDWe()
	{
		return Logger.Log;
	}

	internal static void hkWnbncAG6hTMgOe4Fr(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static bool wwOwqWc7bMbrPycMFAB(object P_0, object P_1)
	{
		return (MethodInfo)P_0 == (MethodInfo)P_1;
	}

	internal static void CpHmAIcx5R2YJ4cbDMX(Type type, object P_1)
	{
		ScriptExecutionService.MethodNotFound(type, (string)P_1);
	}

	internal static object YyuxoMc0tCd2sc6fQdZ(object P_0)
	{
		return ((MethodBase)P_0).GetParameters();
	}

	internal static Type iOCtdIcmagOKiCuDCaX(object P_0)
	{
		return ((ParameterInfo)P_0).ParameterType;
	}

	internal static object cxNELycywqaOVYyTNcm(object P_0, Type itemViewModelType, object P_2, object P_3, object P_4, object P_5)
	{
		return ((UIDynamicFormProvider)P_0).CreateItemViewModelType(itemViewModelType, (FormDescriptor)P_2, (IEntity)P_3, (RootViewItem)P_4, (UIViewItemParams)P_5);
	}

	internal static int e8UXlGcM36MoUw0J72c(object P_0)
	{
		return ((List<object>)P_0).Count;
	}

	internal static object NCHXWOcJUmRysbIdAJb(object P_0)
	{
		return ((FormDescriptor)P_0).Metadata;
	}

	internal static object hCojN5c9CSLyyFcdstx(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object pbp0UpcdbwZUqmGRd70(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static void sB2UEXclbX4Tx2qtkeT(object P_0, object P_1)
	{
		ScriptExecutionService.ScriptExecution((Action)P_0, (string)P_1);
	}

	internal static object FjNjeBcrsQSBvfkUH84(object P_0, object P_1)
	{
		return ((UIDynamicFormProvider)P_0).GetResult(P_1);
	}

	internal static object MQ2OcGcgxUoCfs4atGP(object P_0)
	{
		return ((FormPartMetadata)P_0).Context;
	}

	internal static Guid YnSAsYc5dviIf3WtT3A(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object zLMc5ecjmVc4rkyi31k(object P_0)
	{
		return ((PropertyMetadata)P_0).OnChangeScriptName;
	}

	internal static object lqtKqOcYJhw6n174wGS(object P_0, object P_1, StringSplitOptions P_2)
	{
		return ((string)P_0).Split((string[])P_1, P_2);
	}

	internal static int YuIscgcLWoJICvwJQjc(object P_0, char P_1)
	{
		return ((string)P_0).IndexOf(P_1);
	}

	internal static object TN1snJcUTEuyokAs9P1(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static object CR26EscsgS46FpZwqfw(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static object bctLcMccoMKkrF6deT6(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object FFeAjJczaXETYYpDnGF(object P_0, char P_1, char P_2)
	{
		return ((string)P_0).Replace(P_1, P_2);
	}

	internal static object Nhc4obzFLYuCEktiny3(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static bool VpOBWuzBiExIPPlRAU9(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object ioJXPJzWkF8SFIY7lSf(Type type)
	{
		return GetTypeInfo(type);
	}

	internal static object vwmCmjzoWaNOgjGq1W6(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static object clEutvzb3NghdUSdpnF(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void cW9lmYzhTi3h9p8L98T()
	{
		SingletonReader.PushGlobal();
	}
}
