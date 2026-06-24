using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Scope;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Scripts;

[Component]
public abstract class AbstractActionExecutionHandler : IActionExecutionHandler
{
	private readonly IExecutionScopeFactory executionScopeFactory;

	private static AbstractActionExecutionHandler HRojDdbuOs7fbfQvEM8k;

	private static IMetadataService MetadataService => (IMetadataService)UFgFhjbIFo8DW0WqJjxd();

	protected AbstractActionExecutionHandler(IExecutionScopeFactory executionScopeFactory)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				this.executionScopeFactory = executionScopeFactory;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public abstract bool Check(ActionExecutionParams parameters);

	public abstract ActionExecutionResult Execute(ActionExecutionParams parameters);

	protected ActionExecutionResult Execute(Type executorType, ActionExecutionParams parameters)
	{
		//Discarded unreachable code: IL_0101, IL_0134, IL_019b, IL_01aa, IL_022d, IL_0295, IL_02c5, IL_02fd, IL_030c
		int num = 1;
		int num2 = num;
		IExecutionScope executionScope = default(IExecutionScope);
		ActionExecutionResult result = default(ActionExecutionResult);
		object result2 = default(object);
		MethodInfo methodInfo = default(MethodInfo);
		ScriptMethodInfo scriptMethodInfo = default(ScriptMethodInfo);
		while (true)
		{
			switch (num2)
			{
			case 1:
				executionScope = ((IExecutionScopeBuilder)CjQZyXbuPZ5enFxDLL49(executionScopeFactory)).AddRegistration(executorType, Array.Empty<Type>()).StartScope();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return result;
			}
			try
			{
				object obj = pd9PV6bu1nZxiEe9ewYS(executionScope, executorType);
				int num3 = 2;
				int num4 = num3;
				while (true)
				{
					switch (num4)
					{
					case 2:
						if (obj != null)
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
							{
								num4 = 1;
							}
							break;
						}
						goto case 7;
					case 6:
					{
						ActionExecutionResult actionExecutionResult = new ActionExecutionResult();
						Wqj7tkbuHKGCoMTL40lK(actionExecutionResult, SerializeResult(result2, v0S27Xbu4brCvxnWYBvp(methodInfo), parameters.ReturnType, (EntityTypeSerializationSettings[])peA4Dfbu6CdnCEeiRjQR(parameters)));
						result = actionExecutionResult;
						num4 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
						{
							num4 = 9;
						}
						break;
					}
					default:
						try
						{
							result2 = ExecuteMethod(methodInfo, obj, parameters);
							int num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
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
							int num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
							{
								num6 = 0;
							}
							while (true)
							{
								switch (num6)
								{
								case 1:
									throw;
								}
								Vceu2Ibuwo7cJrfVOX9T(tNLR0ybuthjXJfoQDEiq(), SR.T((string)L5X4b1buNZc8t0rMOIZj(-643786247 ^ -643804931), whjuDWbua8FVZDYEePPl(scriptMethodInfo), executorType), ex);
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
								{
									num6 = 1;
								}
							}
						}
						goto case 6;
					case 4:
						methodInfo = ScriptHelper.GetMethodInfo(executorType, (string)whjuDWbua8FVZDYEePPl(scriptMethodInfo));
						num4 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
						{
							num4 = 8;
						}
						break;
					case 3:
						throw new Exception(SR.T((string)L5X4b1buNZc8t0rMOIZj(-1217523399 ^ -1217615545), executorType, whjuDWbua8FVZDYEePPl(scriptMethodInfo)));
					case 5:
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
						{
							num4 = 0;
						}
						break;
					case 7:
						throw new Exception((string)qlVV6Nbu3JhxoySFtaSa(L5X4b1buNZc8t0rMOIZj(-1824388195 ^ -1824476227)));
					case 1:
						scriptMethodInfo = ScriptMethodInfoHelper.Deserialize((string)f6yrLkbupF8foabWeqOu(parameters));
						num4 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
						{
							num4 = 4;
						}
						break;
					case 8:
						if (!MDio4BbuD9mEFhZEP8u0(methodInfo, null))
						{
							num4 = 5;
							break;
						}
						goto case 3;
					case 9:
						return result;
					}
				}
			}
			finally
			{
				if (executionScope != null)
				{
					int num7 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num7 = 0;
					}
					while (true)
					{
						switch (num7)
						{
						case 1:
							KRcgZgbuAQSNZYwrB3PD(executionScope);
							num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
							{
								num7 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
			}
		}
	}

	protected virtual object Invoke(MethodInfo method, object executorInstance, object[] parameters)
	{
		return GuCU6pbu7rt1n8T3oBaY(method, executorInstance, parameters, string.Empty);
	}

	protected static object DeserializeParameter(string model, Type runtimeType, TypeSignature typeSignature)
	{
		//Discarded unreachable code: IL_011d, IL_013d, IL_014c, IL_01dd, IL_0341, IL_0361, IL_0370, IL_03fb, IL_040a, IL_04d0
		int num = 28;
		Action action = default(Action);
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
		Guid guid = default(Guid);
		Guid guid2 = default(Guid);
		TypeSettings typeSettings = default(TypeSettings);
		ISecurityService service = default(ISecurityService);
		object value = default(object);
		Type type2 = default(Type);
		ITypeDescriptor typeDescriptor = default(ITypeDescriptor);
		Type targetType = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				Type type;
				switch (num2)
				{
				case 1:
				case 5:
				case 8:
					action = _003C_003Ec__DisplayClass6_._003CDeserializeParameter_003Eb__0;
					num2 = 12;
					continue;
				case 9:
				{
					_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_2 = _003C_003Ec__DisplayClass6_;
					PropertyMetadata obj = new PropertyMetadata
					{
						Name = (string)L5X4b1buNZc8t0rMOIZj(0x7459E02 ^ 0x7472770),
						TypeUid = guid
					};
					yugSFpbu9PlWsZbEyH48(obj, guid2);
					XR7PBxbud5RFHQaxb23y(obj, typeSettings);
					sa9T4KburHIX7nNUC3oP(obj, m3E5qsbulIqRM5q4IN90(typeSignature));
					_003C_003Ec__DisplayClass6_2.paramPropertyMetadata = obj;
					num2 = 2;
					continue;
				}
				case 31:
					if (etr8Gibu5CXDhtq52T4R(typeSignature) == RelationType.ManyToMany)
					{
						type = KeSxBfbuMgg47bMvRhd4(typeof(SerializableList<ExpandoObject>).TypeHandle);
						break;
					}
					num2 = 15;
					continue;
				case 6:
					q32KMJbujU5thwyITKdm(action);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 22;
					}
					continue;
				case 30:
					if (model == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto default;
				case 20:
					if (service != null)
					{
						goto end_IL_0012;
					}
					goto case 6;
				case 14:
					if (!(guid == BinaryFileDescriptor.UID))
					{
						num2 = 19;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num2 = 29;
						}
						continue;
					}
					goto case 32;
				case 27:
					guid = JJ3Tg3bux14o0nrxWxdZ(typeSignature);
					num2 = 13;
					continue;
				case 13:
					guid2 = xQqZMkbu0adnDFJXllqd(typeSignature);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num2 = 25;
					}
					continue;
				case 4:
				case 21:
					throw new Exception(SR.T((string)L5X4b1buNZc8t0rMOIZj(-234299632 ^ -234199082), guid, guid2));
				case 2:
					_003C_003Ec__DisplayClass6_.dict = null;
					num2 = 30;
					continue;
				default:
					if (!(guid2 != Guid.Empty))
					{
						num2 = 14;
						continue;
					}
					goto case 32;
				case 12:
					service = Locator.GetService<ISecurityService>();
					num2 = 20;
					continue;
				case 19:
					_003C_003Ec__DisplayClass6_.dict = new Dictionary<string, object> { 
					{
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12A5FAC7 ^ 0x12A743B5),
						value
					} };
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 5;
					}
					continue;
				case 17:
					type2 = KeSxBfbuMgg47bMvRhd4(typeof(ActionExecutionParamModel<>).TypeHandle).MakeGenericType(runtimeType);
					num2 = 33;
					continue;
				case 18:
					_003C_003Ec__DisplayClass6_.requestMetadata = new ClassMetadata();
					num2 = 9;
					continue;
				case 23:
					if (typeDescriptor == null)
					{
						num2 = 4;
						continue;
					}
					goto case 24;
				case 3:
				case 11:
					a1HOebbuYXHJtyx2n3Qw(service, action);
					num2 = 16;
					continue;
				case 26:
				case 29:
					_003C_003Ec__DisplayClass6_.dict = new Dictionary<string, object> { 
					{
						(string)L5X4b1buNZc8t0rMOIZj(--1418440330 ^ 0x548917F8),
						model
					} };
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 8;
					}
					continue;
				case 16:
				case 22:
					return Gjv62FbuLomtwyQ7SCgO(_003C_003Ec__DisplayClass6_.functionRequest);
				case 33:
					_003C_003Ec__DisplayClass6_.functionRequest = (IActionExecutionParamModel)F1gJxcbuJAyKeYrxExNN(type2);
					num2 = 18;
					continue;
				case 28:
					_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
					num2 = 27;
					continue;
				case 10:
					_003C_003Ec__DisplayClass6_.serializableTypeDescriptor = typeDescriptor as ISerializableTypeDescriptor;
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 23;
					}
					continue;
				case 24:
					if (_003C_003Ec__DisplayClass6_.serializableTypeDescriptor != null)
					{
						typeSettings = (TypeSettings)UJZbXGbuypOp3I8CJANh(edG68Zbum9WHSE4t222H(typeDescriptor), typeSignature);
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
						{
							num2 = 17;
						}
					}
					else
					{
						num2 = 21;
					}
					continue;
				case 32:
					if (!QBq9g0bugZxk4FeEOEbh(guid, ListOfSimpleTypeDescriptor.UID))
					{
						num2 = 31;
						continue;
					}
					type = typeof(SerializableList<object>);
					break;
				case 25:
					typeDescriptor = MetadataService.GetTypeDescriptor(guid, guid2);
					num2 = 10;
					continue;
				case 7:
					value = new JsonSerializer().Deserialize(model, targetType);
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 18;
					}
					continue;
				case 15:
					type = KeSxBfbuMgg47bMvRhd4(typeof(ExpandoObject).TypeHandle);
					break;
				}
				targetType = type;
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 7;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	protected static IDictionary<string, object> SerializeResult(object result, Type runtimeType, TypeSignature typeSignature, EntityTypeSerializationSettings[] entityDependencies)
	{
		if (result == null || runtimeType == typeof(void))
		{
			return null;
		}
		Guid typeUid = typeSignature.TypeUid;
		Guid subTypeUid = typeSignature.SubTypeUid;
		ITypeDescriptor typeDescriptor = MetadataService.GetTypeDescriptor(typeUid, subTypeUid);
		ISerializableTypeDescriptor serializableTypeDescriptor = typeDescriptor as ISerializableTypeDescriptor;
		if (typeDescriptor == null || serializableTypeDescriptor == null)
		{
			throw new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571C1B5F), typeUid, subTypeUid));
		}
		TypeSettings settings = CreateTypeSettings(typeDescriptor.SettingsType, typeSignature);
		IExecuteFunctionResponse executeFunctionResponse = (IExecuteFunctionResponse)Activator.CreateInstance(typeof(ExecuteFunctionResponse<>).MakeGenericType(runtimeType));
		executeFunctionResponse.Result = result;
		ClassMetadata metadata = new ClassMetadata();
		PropertyMetadata propertyMetadata = new PropertyMetadata
		{
			Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979335239),
			TypeUid = typeUid,
			SubTypeUid = subTypeUid,
			Settings = settings,
			Nullable = typeSignature.Nullable
		};
		EntitySerializationSettings entitySerializationSettings = new EntitySerializationSettings
		{
			WriteReferences = true
		};
		if (entityDependencies != null && entityDependencies.Length != 0)
		{
			entitySerializationSettings.Mode = EntitySerializationMode.Default;
			entitySerializationSettings.TypePropertySelector = entityDependencies.ToDictionary((EntityTypeSerializationSettings dependency) => _003C_003Ec.npS4RwCPE9uDCmii8eHJ(dependency), delegate(EntityTypeSerializationSettings dependency)
			{
				//Discarded unreachable code: IL_0235, IL_0244, IL_0254, IL_0263
				int num = 8;
				_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
				string[] array = default(string[]);
				int num3 = default(int);
				List<string> properties = default(List<string>);
				EntityMetadata entityMetadata = default(EntityMetadata);
				IPropertyMetadata[] source = default(IPropertyMetadata[]);
				while (true)
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 5:
							_003C_003Ec__DisplayClass7_.name = array[num3];
							num2 = 14;
							continue;
						default:
							if (num3 >= array.Length)
							{
								num2 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
								{
									num2 = 0;
								}
								continue;
							}
							goto case 13;
						case 4:
							break;
						case 12:
							if (!properties.Contains((string)_003C_003Ec.gq8DliCPQ9kpPFj8antE(0x4D1C1EE4 ^ 0x4D1C7176)))
							{
								num2 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
								{
									num2 = 0;
								}
								continue;
							}
							break;
						case 8:
							entityMetadata = ((IMetadataService)_003C_003Ec.yUmyThCPf0dHW1U5JPsB()).GetMetadata(_003C_003Ec.npS4RwCPE9uDCmii8eHJ(dependency), loadImplementation: true) as EntityMetadata;
							num2 = 7;
							continue;
						case 1:
							return (EntitySerializationSelector)_003C_003Ec.Hj7Dk8CPvuIaBLEGetEU(string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x313233F6), properties), entityMetadata);
						case 14:
							if (source.FirstOrDefault(_003C_003Ec__DisplayClass7_._003CSerializeResult_003Eb__2) != null)
							{
								num2 = 6;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
								{
									num2 = 15;
								}
								continue;
							}
							goto case 10;
						case 11:
							array = (string[])_003C_003Ec.Sr3ZlaCPCh4C3AlCnsWt(properties);
							num2 = 7;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
							{
								num2 = 9;
							}
							continue;
						case 13:
							_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
							{
								num2 = 5;
							}
							continue;
						case 2:
							properties.Add((string)_003C_003Ec.gq8DliCPQ9kpPFj8antE(-1837662597 ^ -1837690391));
							num2 = 4;
							continue;
						case 9:
							num3 = 0;
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
							{
								num2 = 0;
							}
							continue;
						case 10:
							properties.Remove(_003C_003Ec__DisplayClass7_.name);
							num2 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
							{
								num2 = 4;
							}
							continue;
						case 7:
							properties = dependency.Properties;
							num2 = 9;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
							{
								num2 = 12;
							}
							continue;
						case 6:
						case 15:
							num3++;
							num2 = 3;
							continue;
						}
						break;
					}
					source = entityMetadata.GetPropertiesAndTableParts().ToArray();
					num = 11;
				}
			});
		}
		IDictionary<string, object> dictionary = serializableTypeDescriptor.Serialize(executeFunctionResponse, metadata, propertyMetadata, entitySerializationSettings);
		if (dictionary == null)
		{
			return null;
		}
		return dictionary;
	}

	private object ExecuteMethod(MethodInfo method, object executorInstance, ActionExecutionParams parameters)
	{
		//Discarded unreachable code: IL_0060, IL_006f, IL_00e4, IL_00f3
		int num = 1;
		int num2 = num;
		object result = default(object);
		object obj = default(object);
		ParameterInfo[] array = default(ParameterInfo[]);
		while (true)
		{
			switch (num2)
			{
			case 6:
				result = h1QwLLbusYqhLnJmkdJN(this, method, executorInstance, new object[1] { obj });
				num2 = 4;
				break;
			case 4:
			case 7:
				return result;
			case 5:
				result = h1QwLLbusYqhLnJmkdJN(this, method, executorInstance, new object[0]);
				num2 = 7;
				break;
			case 2:
			case 3:
				obj = DeserializeParameter((string)p9XF3ybucM4Z9C7i4lNp(parameters), array[0].ParameterType, (TypeSignature)tkWAoEbuzG3d91iJEA64(parameters));
				num2 = 6;
				break;
			case 1:
				array = (ParameterInfo[])knvmIkbuU9ofMSQH4fI0(method);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (array.Length != 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 5;
			}
		}
	}

	private static TypeSettings CreateTypeSettings(Type settingsType, object type)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				if (BmNkoXbIB8IrMkOqXVWY(settingsType, null))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 0;
					}
					break;
				}
				TypeSettings typeSettings;
				TypeSettings result = (typeSettings = (TypeSettings)F1gJxcbuJAyKeYrxExNN(settingsType));
				if (typeSettings != null)
				{
					if (typeSettings is DataClassSettings dataClassSettings)
					{
						KO3VRWbIWYcpCgr71XZ0(dataClassSettings, etr8Gibu5CXDhtq52T4R(type));
						return result;
					}
					if (typeSettings is EntitySettings entitySettings)
					{
						RlYSk5bIoM8cjMoUXtwc(entitySettings, ((TypeSignature)type).RelationType);
						return result;
					}
					if (typeSettings is ListOfSimpleTypeSettings listOfSimpleTypeSettings)
					{
						listOfSimpleTypeSettings.SimpleTypeUid = ((TypeSignature)type).SubTypeUid;
					}
				}
				return result;
			}
			default:
				return null;
			}
		}
	}

	internal static bool ShAhQIbu2OgeIAW2KDh1()
	{
		return HRojDdbuOs7fbfQvEM8k == null;
	}

	internal static AbstractActionExecutionHandler KxqfrmbuehxxIN1Qdp6f()
	{
		return HRojDdbuOs7fbfQvEM8k;
	}

	internal static object CjQZyXbuPZ5enFxDLL49(object P_0)
	{
		return ((IExecutionScopeFactory)P_0).CreateScope();
	}

	internal static object pd9PV6bu1nZxiEe9ewYS(object P_0, Type objectType)
	{
		return ((IExecutionScope)P_0).Resolve(objectType);
	}

	internal static object L5X4b1buNZc8t0rMOIZj(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object qlVV6Nbu3JhxoySFtaSa(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object f6yrLkbupF8foabWeqOu(object P_0)
	{
		return ((ActionExecutionParams)P_0).ScriptName;
	}

	internal static object whjuDWbua8FVZDYEePPl(object P_0)
	{
		return ((ScriptMethodInfo)P_0).Name;
	}

	internal static bool MDio4BbuD9mEFhZEP8u0(object P_0, object P_1)
	{
		return (MethodInfo)P_0 == (MethodInfo)P_1;
	}

	internal static object tNLR0ybuthjXJfoQDEiq()
	{
		return Logger.Log;
	}

	internal static void Vceu2Ibuwo7cJrfVOX9T(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static Type v0S27Xbu4brCvxnWYBvp(object P_0)
	{
		return ((MethodInfo)P_0).ReturnType;
	}

	internal static object peA4Dfbu6CdnCEeiRjQR(object P_0)
	{
		return ((ActionExecutionParams)P_0).EntityTypeSerializationSettings;
	}

	internal static void Wqj7tkbuHKGCoMTL40lK(object P_0, object P_1)
	{
		((ActionExecutionResult)P_0).Result = P_1;
	}

	internal static void KRcgZgbuAQSNZYwrB3PD(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object GuCU6pbu7rt1n8T3oBaY(object P_0, object P_1, object P_2, object P_3)
	{
		return EntityScriptingService.InvokeWithDiagnostics((MethodInfo)P_0, P_1, (object[])P_2, (string)P_3);
	}

	internal static Guid JJ3Tg3bux14o0nrxWxdZ(object P_0)
	{
		return ((TypeSignature)P_0).TypeUid;
	}

	internal static Guid xQqZMkbu0adnDFJXllqd(object P_0)
	{
		return ((TypeSignature)P_0).SubTypeUid;
	}

	internal static Type edG68Zbum9WHSE4t222H(object P_0)
	{
		return ((ITypeDescriptor)P_0).SettingsType;
	}

	internal static object UJZbXGbuypOp3I8CJANh(Type settingsType, object P_1)
	{
		return CreateTypeSettings(settingsType, P_1);
	}

	internal static Type KeSxBfbuMgg47bMvRhd4(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object F1gJxcbuJAyKeYrxExNN(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static void yugSFpbu9PlWsZbEyH48(object P_0, Guid value)
	{
		((PropertyMetadata)P_0).SubTypeUid = value;
	}

	internal static void XR7PBxbud5RFHQaxb23y(object P_0, object P_1)
	{
		((PropertyMetadata)P_0).Settings = (TypeSettings)P_1;
	}

	internal static bool m3E5qsbulIqRM5q4IN90(object P_0)
	{
		return ((TypeSignature)P_0).Nullable;
	}

	internal static void sa9T4KburHIX7nNUC3oP(object P_0, bool value)
	{
		((PropertyMetadata)P_0).Nullable = value;
	}

	internal static bool QBq9g0bugZxk4FeEOEbh(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static RelationType etr8Gibu5CXDhtq52T4R(object P_0)
	{
		return ((TypeSignature)P_0).RelationType;
	}

	internal static void q32KMJbujU5thwyITKdm(object P_0)
	{
		P_0();
	}

	internal static void a1HOebbuYXHJtyx2n3Qw(object P_0, object P_1)
	{
		((ISecurityService)P_0).RunWithElevatedPrivilegiesAndWithDeleted((Action)P_1);
	}

	internal static object Gjv62FbuLomtwyQ7SCgO(object P_0)
	{
		return ((IActionExecutionParamModel)P_0).Parameter;
	}

	internal static object knvmIkbuU9ofMSQH4fI0(object P_0)
	{
		return ((MethodBase)P_0).GetParameters();
	}

	internal static object h1QwLLbusYqhLnJmkdJN(object P_0, object P_1, object P_2, object P_3)
	{
		return ((AbstractActionExecutionHandler)P_0).Invoke((MethodInfo)P_1, P_2, (object[])P_3);
	}

	internal static object p9XF3ybucM4Z9C7i4lNp(object P_0)
	{
		return ((ActionExecutionParams)P_0).Parameter;
	}

	internal static object tkWAoEbuzG3d91iJEA64(object P_0)
	{
		return ((ActionExecutionParams)P_0).ParameterType;
	}

	internal static object UFgFhjbIFo8DW0WqJjxd()
	{
		return MetadataServiceContext.Service;
	}

	internal static bool BmNkoXbIB8IrMkOqXVWY(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static void KO3VRWbIWYcpCgr71XZ0(object P_0, RelationType value)
	{
		((DataClassSettings)P_0).RelationType = value;
	}

	internal static void RlYSk5bIoM8cjMoUXtwc(object P_0, RelationType value)
	{
		((EntitySettings)P_0).RelationType = value;
	}
}
