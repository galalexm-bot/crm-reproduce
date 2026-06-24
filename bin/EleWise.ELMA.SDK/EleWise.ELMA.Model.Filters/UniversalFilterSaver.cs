using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Helpers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Filters;

public class UniversalFilterSaver
{
	private static Func<Type, Dictionary<Guid, string>> getUniversalFilter;

	internal static UniversalFilterSaver twwEdSWYYOaT4pc0BSaA;

	private static void SetValue(object obj, object property, object value)
	{
		//Discarded unreachable code: IL_00d0, IL_00df, IL_0117, IL_0126
		int num = 9;
		object value2 = default(object);
		object obj2 = default(object);
		Type type = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return;
				case 1:
				case 2:
					if (t5BWe8WYspFxTi9F4NK3(property).IsEnum)
					{
						num2 = 4;
						continue;
					}
					WrbSdTWLBqY949w1mU3o(property, obj, value, null);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 6;
					}
					continue;
				case 6:
					return;
				case 7:
					((PropertyInfo)property).SetValue(obj, value2, (object[])null);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					return;
				case 9:
					break;
				case 4:
					obj2 = qIlRhXWLFXZ4LJ0O4nGB(((PropertyInfo)property).PropertyType, value);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 11;
					}
					continue;
				default:
					value2 = Enum.ToObject(type, value);
					num2 = 7;
					continue;
				case 11:
					WrbSdTWLBqY949w1mU3o(property, obj, obj2, null);
					num2 = 5;
					continue;
				case 10:
					if (!type.IsEnum)
					{
						num2 = 2;
						continue;
					}
					goto default;
				case 8:
					if (!qBHDTlWYzHcmrqxhGq0j(type, null))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 10;
				}
				break;
			}
			type = oKrjyQWYcD1pcUh65Z4d(t5BWe8WYspFxTi9F4NK3(property));
			num = 8;
		}
	}

	private static void PackProperty(object item, object value, List<FilterProperty> result, string collection = "")
	{
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals0.item = (PropertyMetadata)item;
		CS_0024_003C_003E8__locals0.valueType = value.GetType().GetTypeWithoutProxy();
		object obj = null;
		if (value is QueryParameters queryParameters)
		{
			QueryParametersListInfo queryParametersListInfo = null;
			foreach (KeyValuePair<string, object> item2 in queryParameters)
			{
				List<FilterProperty> list = new List<FilterProperty>
				{
					new FilterProperty
					{
						Uid = CS_0024_003C_003E8__locals0.item.Uid
					}
				};
				if (item2.Value != null)
				{
					Type type = item2.Value.GetType();
					if (typeof(IEnumerable).IsAssignableFrom(type) && type.IsGenericType)
					{
						foreach (object item3 in (IEnumerable)item2.Value)
						{
							if (item3 != null)
							{
								PackProperty(CS_0024_003C_003E8__locals0.item, item3, list, type.AssemblyQualifiedName);
							}
						}
					}
					else
					{
						PackProperty(CS_0024_003C_003E8__locals0.item, item2.Value, list);
					}
				}
				if (queryParametersListInfo == null)
				{
					obj = (queryParametersListInfo = new QueryParametersListInfo());
				}
				queryParametersListInfo.Objects.Add(new QueryParameterInfo
				{
					Name = item2.Key,
					Object = list[0].Value
				});
			}
		}
		else if (value is IEntityFilter)
		{
			ITypeWrapperResolver resolver = null;
			if (CS_0024_003C_003E8__locals0.item.TypeResolver != Guid.Empty)
			{
				resolver = ComponentManager.Current.GetExtensionPoints<ITypeWrapperResolver>().FirstOrDefault((ITypeWrapperResolver r) => _003C_003Ec__DisplayClass1_0.hpFQWuCF391PH50iGHHj(r.Uid, CS_0024_003C_003E8__locals0.item.TypeResolver));
			}
			obj = Pack((IEntityFilter)value, resolver);
		}
		else
		{
			ITypeWrapperDescriptor typeWrapperDescriptor = ComponentManager.Current.GetExtensionPoints<ITypeWrapperDescriptor>().FirstOrDefault(delegate(ITypeWrapperDescriptor e)
			{
				//Discarded unreachable code: IL_009b, IL_00aa
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						if (!_003C_003Ec__DisplayClass1_0.n9TmibCFafEDfk06hj5G(_003C_003Ec__DisplayClass1_0.UkHN4RCFp8wKEtFosryn(e), null))
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
							{
								num2 = 0;
							}
							break;
						}
						goto case 2;
					case 2:
						if (_003C_003Ec__DisplayClass1_0.UkHN4RCFp8wKEtFosryn(e).IsAssignableFrom(CS_0024_003C_003E8__locals0.valueType))
						{
							return true;
						}
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
						{
							num2 = 3;
						}
						break;
					default:
						return _003C_003Ec__DisplayClass1_0.K0lelmCFDOswG01R7rK1(e, CS_0024_003C_003E8__locals0.valueType);
					}
				}
			});
			if (typeWrapperDescriptor != null)
			{
				object obj2 = typeWrapperDescriptor.CreateWrapper(value);
				if (obj2 != null)
				{
					obj = obj2;
				}
			}
			else
			{
				obj = value;
			}
		}
		if (obj == null)
		{
			return;
		}
		FilterProperty filterProperty = result.FirstOrDefault((FilterProperty r) => _003C_003Ec__DisplayClass1_0.NGqAC5CFt3rOY27rpvjC(r) == _003C_003Ec__DisplayClass1_0.dBFHqYCFwtNwZMK9UqnJ(CS_0024_003C_003E8__locals0.item)) ?? new FilterProperty
		{
			Uid = CS_0024_003C_003E8__locals0.item.Uid
		};
		if (string.IsNullOrEmpty(collection))
		{
			filterProperty.Value = obj;
		}
		else
		{
			if (filterProperty.Value == null)
			{
				filterProperty.Value = new ListInfo();
			}
			ListInfo obj3 = (ListInfo)filterProperty.Value;
			obj3.ListClass = collection;
			obj3.Objects.Add(obj);
		}
		if (result.All((FilterProperty r) => r.Uid != _003C_003Ec__DisplayClass1_0.dBFHqYCFwtNwZMK9UqnJ(CS_0024_003C_003E8__locals0.item)))
		{
			result.Add(filterProperty);
		}
	}

	private static QueryParameters UnPackQueryParameters(object info, object queryParameters)
	{
		//Discarded unreachable code: IL_0030, IL_007d, IL_008c, IL_0175, IL_0184, IL_018f, IL_0261, IL_0274, IL_031c, IL_032f, IL_033e
		int num = 1;
		int num2 = num;
		List<QueryParameterInfo>.Enumerator enumerator = default(List<QueryParameterInfo>.Enumerator);
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		ListInfo listInfo = default(ListInfo);
		QueryParameterInfo current = default(QueryParameterInfo);
		object obj = default(object);
		object obj2 = default(object);
		MethodInfo methodInfo = default(MethodInfo);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return (QueryParameters)queryParameters;
			case 1:
				enumerator = ((QueryParametersListInfo)info).Objects.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				while (true)
				{
					IL_00d5:
					int num3;
					if (!enumerator.MoveNext())
					{
						num3 = 5;
						goto IL_003e;
					}
					goto IL_00b2;
					IL_003e:
					while (true)
					{
						switch (num3)
						{
						case 5:
							return (QueryParameters)queryParameters;
						case 8:
						{
							enumerator2 = listInfo.Objects.GetEnumerator();
							int num4 = 2;
							num3 = num4;
							continue;
						}
						case 3:
							break;
						case 4:
						case 9:
							goto IL_00d5;
						default:
							if ((listInfo = Its9pXWLWuCE61X6bqMA(current) as ListInfo) == null)
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
								{
									num3 = 0;
								}
								continue;
							}
							goto case 6;
						case 10:
							B8l7WeWLGpKRtYw21wO2(queryParameters, current.Name, obj);
							num3 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
							{
								num3 = 1;
							}
							continue;
						case 6:
							obj = Activator.CreateInstance(ReflectionType.GetType((string)hiVPGMWLowblxYKJrZoY(listInfo)));
							num3 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
							{
								num3 = 7;
							}
							continue;
						case 2:
							try
							{
								while (true)
								{
									IL_0200:
									int num5;
									if (!enumerator2.MoveNext())
									{
										num5 = 2;
										goto IL_0193;
									}
									goto IL_01b1;
									IL_0193:
									while (true)
									{
										switch (num5)
										{
										case 1:
											break;
										case 4:
											if (obj2 != null)
											{
												num5 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
												{
													num5 = 0;
												}
												continue;
											}
											goto IL_0200;
										case 3:
											goto IL_0200;
										default:
											I2iaW6WLhIZZVnj3beUI(methodInfo, obj, new object[1] { obj2 });
											num5 = 3;
											continue;
										case 2:
											goto end_IL_0200;
										}
										break;
									}
									goto IL_01b1;
									IL_01b1:
									obj2 = aIatDlWLb8BxDTrPA5y0(UnPackProperty(enumerator2.Current), obj.GetType().GetGenericArguments().First());
									num5 = 4;
									goto IL_0193;
									continue;
									end_IL_0200:
									break;
								}
							}
							finally
							{
								((IDisposable)enumerator2).Dispose();
								int num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
								{
									num6 = 0;
								}
								switch (num6)
								{
								case 0:
									break;
								}
							}
							goto case 10;
						case 1:
						case 11:
							B8l7WeWLGpKRtYw21wO2(queryParameters, ogiFwZWLEZ24JGKYCFnN(current), F4NSn5WLf9UcHCWQb04v(Its9pXWLWuCE61X6bqMA(current)));
							num3 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
							{
								num3 = 9;
							}
							continue;
						case 7:
							methodInfo = obj.GetType().GetMethods().FirstOrDefault((MethodInfo m) => (string)_003C_003Ec.NcgtM7CF7SjHPQDLOr7E(m) == (string)_003C_003Ec.pYovRgCFxfnb89JHSJ1p(-583745292 ^ -583768888));
							num3 = 8;
							continue;
						}
						break;
					}
					goto IL_00b2;
					IL_00b2:
					current = enumerator.Current;
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num3 = 0;
					}
					goto IL_003e;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
				int num7 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num7 = 0;
				}
				switch (num7)
				{
				case 0:
					break;
				}
			}
		}
	}

	private static object UnPackProperty(object propertyValue)
	{
		//Discarded unreachable code: IL_005d, IL_006c, IL_0127, IL_0136, IL_0146, IL_0155, IL_0176, IL_01ce
		int num = 4;
		ITypeWrapperDescriptor typeWrapperDescriptor = default(ITypeWrapperDescriptor);
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		object result = default(object);
		QueryParametersListInfo info = default(QueryParametersListInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 12:
					goto end_IL_0012;
				case 6:
					typeWrapperDescriptor = ((ComponentManager)fGxwSwWLQtPTK3JvhwRk()).GetExtensionPoints<ITypeWrapperDescriptor>().FirstOrDefault(_003C_003Ec__DisplayClass3_._003CUnPackProperty_003Eb__0);
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num2 = 11;
					}
					continue;
				case 5:
				case 10:
					_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num2 = 12;
					}
					continue;
				default:
					return result;
				case 1:
					result = UnPack(propertyValue);
					num2 = 13;
					continue;
				case 8:
					return null;
				case 3:
					if ((info = propertyValue as QueryParametersListInfo) != null)
					{
						num2 = 2;
						continue;
					}
					goto case 9;
				case 4:
					if (propertyValue != null)
					{
						num2 = 3;
						continue;
					}
					goto case 8;
				case 7:
					obj = propertyValue;
					break;
				case 11:
					if (typeWrapperDescriptor == null)
					{
						num2 = 7;
						continue;
					}
					obj = typeWrapperDescriptor.GetObject(propertyValue);
					break;
				case 2:
					result = UnPackQueryParameters(info, new QueryParameters());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					if (!(propertyValue is SerializableFilter))
					{
						num2 = 5;
						continue;
					}
					goto case 1;
				}
				result = obj;
				num2 = 14;
				continue;
				end_IL_0012:
				break;
			}
			_003C_003Ec__DisplayClass3_.valueType = propertyValue.GetType().GetTypeWithoutProxy();
			num = 6;
		}
	}

	public static object Pack(IEntityFilter filter, ITypeWrapperResolver resolver = null)
	{
		//Discarded unreachable code: IL_006a, IL_00ee, IL_00fd, IL_0143, IL_0152, IL_019a, IL_01a9, IL_01b4, IL_02ba, IL_02c9, IL_02ea, IL_02f9, IL_0408, IL_041b, IL_042a
		int num = 2;
		int num2 = num;
		Type type = default(Type);
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		PropertyMetadata current = default(PropertyMetadata);
		IEnumerator enumerator2 = default(IEnumerator);
		IEnumerable enumerable = default(IEnumerable);
		Type type2 = default(Type);
		object obj2 = default(object);
		object current2 = default(object);
		SerializableFilter serializableFilter2 = default(SerializableFilter);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return null;
			case 2:
				if (filter != null)
				{
					type = filter.GetType();
					num2 = 4;
					break;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
							{
								num3 = 15;
							}
							goto IL_0078;
						}
						goto IL_034b;
						IL_034b:
						current = enumerator.Current;
						int num4 = 7;
						num3 = num4;
						goto IL_0078;
						IL_0078:
						while (true)
						{
							switch (num3)
							{
							default:
								enumerator2 = (IEnumerator)e2looTWLqVQ22bNf1kQj(enumerable);
								num3 = 16;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
								{
									num3 = 16;
								}
								continue;
							case 10:
								type2 = obj2.GetType();
								num3 = 14;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
								{
									num3 = 14;
								}
								continue;
							case 1:
								enumerable = obj2 as IEnumerable;
								num3 = 3;
								continue;
							case 14:
								if (R1UOx1WLi0bluoOFybaV(filter.GetType().GetReflectionProperty((string)VWfPw9WLIU0bLKLQj0CP(current)), null))
								{
									num3 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto case 6;
							case 16:
								try
								{
									while (true)
									{
										IL_022b:
										int num5;
										if (!enumerator2.MoveNext())
										{
											num5 = 3;
											goto IL_01b8;
										}
										goto IL_01f7;
										IL_01b8:
										while (true)
										{
											switch (num5)
											{
											default:
												PackProperty(current, current2, serializableFilter2.Properties, type2.AssemblyQualifiedName);
												num5 = 4;
												continue;
											case 1:
												break;
											case 2:
												if (current2 != null)
												{
													num5 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
													{
														num5 = 0;
													}
													continue;
												}
												goto IL_022b;
											case 4:
												goto IL_022b;
											case 3:
												goto end_IL_022b;
											}
											break;
										}
										goto IL_01f7;
										IL_01f7:
										current2 = enumerator2.Current;
										num5 = 2;
										goto IL_01b8;
										continue;
										end_IL_022b:
										break;
									}
								}
								finally
								{
									IDisposable disposable = enumerator2 as IDisposable;
									int num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
									{
										num6 = 0;
									}
									while (true)
									{
										switch (num6)
										{
										default:
											if (disposable != null)
											{
												int num7 = 2;
												num6 = num7;
												continue;
											}
											break;
										case 2:
											disposable.Dispose();
											num6 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
											{
												num6 = 1;
											}
											continue;
										case 1:
											break;
										}
										break;
									}
								}
								break;
							case 3:
								if (enumerable == null)
								{
									num3 = 13;
									continue;
								}
								goto default;
							case 9:
								if (obj2 != null)
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
									{
										num3 = 10;
									}
									continue;
								}
								break;
							case 5:
							case 11:
							case 13:
								break;
							case 8:
								goto IL_034b;
							case 6:
								if (yO4AAKWLRYR2LnBbmw6t(typeof(IEnumerable).TypeHandle).IsAssignableFrom(type2))
								{
									num3 = 12;
									continue;
								}
								goto case 2;
							case 12:
								if (!type2.IsGenericType)
								{
									num3 = 4;
									continue;
								}
								goto case 1;
							case 2:
							case 4:
								PackProperty(current, obj2, serializableFilter2.Properties);
								num3 = 11;
								continue;
							case 7:
								obj2 = IUnGtIWLSmJKILIPCw1r(Ql5CPiWLVSv9wy9bulXW(filter.GetType(), VWfPw9WLIU0bLKLQj0CP(current)), filter, null);
								num3 = 9;
								continue;
							case 15:
								return serializableFilter2;
							}
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num8 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num8 = 0;
					}
					switch (num8)
					{
					case 0:
						break;
					}
				}
			default:
				return serializableFilter2;
			case 4:
			{
				ClassMetadata obj = (ClassMetadata)MetadataLoader.LoadMetadata(type);
				SerializableFilter serializableFilter = new SerializableFilter();
				qE0FAuWLCNhGqRQ6XFsn(serializableFilter, type.AssemblyQualifiedName);
				serializableFilter2 = serializableFilter;
				if (resolver != null)
				{
					string text = (string)adw4h0WLv4o644SvSoI8(resolver, filter);
					if (!hV38WSWL8ZRTg4EypeVG(text))
					{
						PjxwK1WLu8S2NtnAXmow(serializableFilter2, xpGFxJWLZxf4ARi1Viwp(resolver).ToString());
						qE0FAuWLCNhGqRQ6XFsn(serializableFilter2, text);
					}
				}
				enumerator = obj.Properties.GetEnumerator();
				num2 = 3;
				break;
			}
			}
		}
	}

	public static Dictionary<Guid, string> UniversalFilterUnPackFromDictionary(Type type)
	{
		return getUniversalFilter(type);
	}

	private static Dictionary<Guid, string> GetUniversalFilter(Type type)
	{
		_003C_003Ec__DisplayClass7_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0();
		PropertyInfo[] reflectionProperties = type.GetReflectionProperties();
		CS_0024_003C_003E8__locals0.universalFilter = reflectionProperties.SelectMany(delegate(PropertyInfo p)
		{
			CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_1();
			CS_0024_003C_003E8__locals0.p = p;
			return from a in CS_0024_003C_003E8__locals0.p.GetCustomAttributes(typeof(UniversalFilterUnPackFromAttribute), inherit: true).OfType<UniversalFilterUnPackFromAttribute>()
				select new
				{
					Key = a.PropertyUid,
					Value = CS_0024_003C_003E8__locals0.p.Name
				};
		}).ToDictionary(p => p.Key, p => p.Value);
		reflectionProperties.Each(delegate(PropertyInfo p)
		{
			//Discarded unreachable code: IL_005c, IL_006b
			int num = 1;
			Guid deterministicGuid = default(Guid);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						deterministicGuid = p.Name.GetDeterministicGuid();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
						{
							num2 = 0;
						}
						continue;
					case 3:
						return;
					case 4:
						return;
					default:
						if (CS_0024_003C_003E8__locals0.universalFilter.ContainsKey(deterministicGuid))
						{
							num2 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
							{
								num2 = 2;
							}
							continue;
						}
						break;
					case 2:
						break;
					}
					break;
				}
				CS_0024_003C_003E8__locals0.universalFilter.Add(deterministicGuid, (string)_003C_003Ec__DisplayClass7_0.a5kDvHCF5lgDO4jSTdfg(p));
				num = 4;
			}
		});
		return CS_0024_003C_003E8__locals0.universalFilter;
	}

	public static IEntityFilter UnPack(object datafilter, ReferenceOnEntityType filterType = null, IEntityFilter filter = null, ITypeWrapperResolver resolver = null)
	{
		//Discarded unreachable code: IL_00d8, IL_013e, IL_014d, IL_018c, IL_0241, IL_0287, IL_03ec, IL_0424, IL_04c0, IL_04cf, IL_0532, IL_0541, IL_0590, IL_063e, IL_064d, IL_06c7, IL_06d6, IL_0755, IL_0768, IL_089a, IL_08ad, IL_08bc, IL_090d, IL_09c4
		int num = 12;
		List<FilterProperty>.Enumerator enumerator = default(List<FilterProperty>.Enumerator);
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		Dictionary<Guid, string> dictionary = default(Dictionary<Guid, string>);
		IEntityFilter entityFilter = default(IEntityFilter);
		ClassMetadata classMetadata = default(ClassMetadata);
		FilterProperty current = default(FilterProperty);
		MethodInfo methodInfo = default(MethodInfo);
		PropertyInfo reflectionProperty = default(PropertyInfo);
		object obj5 = default(object);
		QueryParameters queryParameters = default(QueryParameters);
		QueryParametersListInfo info = default(QueryParametersListInfo);
		object obj4 = default(object);
		object obj2 = default(object);
		_003C_003Ec__DisplayClass8_1 _003C_003Ec__DisplayClass8_2 = default(_003C_003Ec__DisplayClass8_1);
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		object obj3 = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				Type type;
				object obj;
				switch (num2)
				{
				case 16:
					enumerator = _003C_003Ec__DisplayClass8_.serializableFilter.Properties.GetEnumerator();
					num2 = 2;
					continue;
				case 10:
					if (filterType == null)
					{
						num = 5;
						break;
					}
					type = OpN6fdWLk6Jc8QUYWf2w(mtMI34WLT6AbFspTdC4l(filterType));
					if ((object)type != null)
					{
						goto IL_09b5;
					}
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
					{
						num2 = 0;
					}
					continue;
				case 12:
					_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 11;
					}
					continue;
				case 7:
					if (datafilter is SerializableFilter)
					{
						num2 = 18;
						continue;
					}
					goto case 3;
				case 1:
					dictionary = UniversalFilterUnPackFromDictionary(entityFilter.GetType());
					num2 = 16;
					continue;
				case 9:
					return entityFilter;
				case 19:
					resolver = ComponentManager.Current.GetExtensionPoints<ITypeWrapperResolver>().FirstOrDefault(_003C_003Ec__DisplayClass8_._003CUnPack_003Eb__0);
					num2 = 15;
					continue;
				case 4:
					if (resolver == null)
					{
						num = 13;
						break;
					}
					goto case 15;
				default:
					classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(entityFilter.GetType());
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
								{
									num3 = 0;
								}
								goto IL_019a;
							}
							goto IL_0483;
							IL_0483:
							current = enumerator.Current;
							num3 = 12;
							goto IL_019a;
							IL_019a:
							while (true)
							{
								object obj6;
								int num7;
								PropertyMetadata propertyMetadata;
								switch (num3)
								{
								default:
									return entityFilter;
								case 0:
									return entityFilter;
								case 1:
									if (!tA40aqWL1KVvKsnsH1mo(methodInfo, null))
									{
										num3 = 36;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
										{
											num3 = 32;
										}
										continue;
									}
									break;
								case 7:
									obj6 = Activator.CreateInstance(reflectionProperty.PropertyType);
									goto IL_080e;
								case 34:
									RSrS89WL3YAeVrekekQb(entityFilter, reflectionProperty, obj5);
									num3 = 15;
									continue;
								case 29:
									if (QyMASiWL2BcXqu8xorl3(current) == null)
									{
										num3 = 13;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
										{
											num3 = 13;
										}
										continue;
									}
									goto case 21;
								case 17:
									if (!reflectionProperty.PropertyType.IsGenericType)
									{
										num3 = 23;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
										{
											num3 = 6;
										}
										continue;
									}
									goto case 20;
								case 6:
								case 13:
								case 15:
								case 32:
									break;
								case 24:
									if ((queryParameters = IUnGtIWLSmJKILIPCw1r(reflectionProperty, entityFilter, null) as QueryParameters) == null)
									{
										num7 = 4;
										goto IL_0196;
									}
									if ((info = current.Value as QueryParametersListInfo) != null)
									{
										num3 = 28;
										continue;
									}
									break;
								case 27:
									obj5 = Convert(F4NSn5WLf9UcHCWQb04v(QyMASiWL2BcXqu8xorl3(current)), t5BWe8WYspFxTi9F4NK3(reflectionProperty));
									num3 = 34;
									continue;
								case 3:
									I2iaW6WLhIZZVnj3beUI(methodInfo, obj4, new object[1] { obj2 });
									num3 = 6;
									continue;
								case 4:
									throw new Exception(SR.T((string)ohupIUWLNNf7hyZ7JppR(-105199646 ^ -105347968)));
								case 33:
									obj2 = Convert(F4NSn5WLf9UcHCWQb04v(current.Value), obj4.GetType().GetGenericArguments().First());
									num3 = 8;
									continue;
								case 8:
									if (obj2 != null)
									{
										num3 = 3;
										continue;
									}
									break;
								case 21:
									_003C_003Ec__DisplayClass8_2.propertyUid = NJ8ZH6WLeqbTW4lX2nOu(current);
									num3 = 37;
									continue;
								case 36:
									if (QyMASiWL2BcXqu8xorl3(current) is ListInfo)
									{
										num3 = 22;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
										{
											num3 = 17;
										}
										continue;
									}
									goto case 33;
								case 25:
									SetValue(entityFilter, reflectionProperty, obj4);
									num3 = 10;
									continue;
								case 18:
									if (propertyMetadata2 != null)
									{
										num3 = 2;
										continue;
									}
									break;
								case 9:
									goto IL_0483;
								case 2:
									reflectionProperty = entityFilter.GetType().GetReflectionProperty((string)VWfPw9WLIU0bLKLQj0CP(propertyMetadata2), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
									num7 = 30;
									goto IL_0196;
								case 35:
									if (_003C_003Ec__DisplayClass8_2.propertyName != null)
									{
										num3 = 31;
										continue;
									}
									goto case 11;
								case 22:
									enumerator2 = ((ListInfo)QyMASiWL2BcXqu8xorl3(current)).Objects.GetEnumerator();
									num3 = 5;
									continue;
								case 26:
									if (!(current.Value is ListInfo))
									{
										num3 = 7;
										continue;
									}
									obj6 = bfA0f0WLPfO0wcQlYhw3(ReflectionType.GetType((string)hiVPGMWLowblxYKJrZoY((ListInfo)QyMASiWL2BcXqu8xorl3(current))));
									goto IL_080e;
								case 20:
									obj4 = IUnGtIWLSmJKILIPCw1r(reflectionProperty, entityFilter, null);
									num3 = 14;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
									{
										num3 = 5;
									}
									continue;
								case 11:
									propertyMetadata = classMetadata.Properties.Find(_003C_003Ec__DisplayClass8_2._003CUnPack_003Eb__2);
									goto IL_07d7;
								case 16:
								case 23:
									if (typeof(QueryParameters).IsAssignableFrom(reflectionProperty.PropertyType))
									{
										num3 = 24;
										continue;
									}
									goto case 27;
								case 14:
									if (obj4 == null)
									{
										num3 = 6;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
										{
											num3 = 26;
										}
										continue;
									}
									goto case 10;
								case 30:
									if (!R1UOx1WLi0bluoOFybaV(reflectionProperty, null))
									{
										num3 = 19;
										continue;
									}
									break;
								case 19:
									if (yO4AAKWLRYR2LnBbmw6t(typeof(IEnumerable).TypeHandle).IsAssignableFrom(reflectionProperty.PropertyType))
									{
										num3 = 17;
										continue;
									}
									goto case 16;
								case 12:
									_003C_003Ec__DisplayClass8_2 = new _003C_003Ec__DisplayClass8_1();
									num3 = 29;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
									{
										num3 = 22;
									}
									continue;
								case 5:
									try
									{
										while (true)
										{
											IL_0713:
											int num4;
											if (!enumerator2.MoveNext())
											{
												num4 = 3;
												goto IL_065c;
											}
											goto IL_06e1;
											IL_065c:
											while (true)
											{
												switch (num4)
												{
												case 4:
													break;
												case 5:
													if (obj3 == null)
													{
														num4 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
														{
															num4 = 0;
														}
														continue;
													}
													break;
												case 1:
													goto IL_06e1;
												default:
													goto IL_0713;
												case 3:
													goto end_IL_0713;
												}
												break;
											}
											I2iaW6WLhIZZVnj3beUI(methodInfo, obj4, new object[1] { obj3 });
											int num5 = 2;
											goto IL_0658;
											IL_06e1:
											obj3 = aIatDlWLb8BxDTrPA5y0(F4NSn5WLf9UcHCWQb04v(enumerator2.Current), obj4.GetType().GetGenericArguments().First());
											num5 = 5;
											goto IL_0658;
											IL_0658:
											num4 = num5;
											goto IL_065c;
											continue;
											end_IL_0713:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator2).Dispose();
										int num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
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
								case 28:
									UnPackQueryParameters(info, queryParameters);
									num3 = 32;
									continue;
								case 37:
									_003C_003Ec__DisplayClass8_2.propertyName = (dictionary.ContainsKey(_003C_003Ec__DisplayClass8_2.propertyUid) ? dictionary[_003C_003Ec__DisplayClass8_2.propertyUid] : null);
									num3 = 35;
									continue;
								case 31:
									propertyMetadata = classMetadata.Properties.Find(_003C_003Ec__DisplayClass8_2._003CUnPack_003Eb__1);
									goto IL_07d7;
								case 10:
									{
										methodInfo = obj4.GetType().GetMethods().FirstOrDefault((MethodInfo m) => _003C_003Ec.cCxJbjCF0fxeijuWuucd(_003C_003Ec.NcgtM7CF7SjHPQDLOr7E(m), _003C_003Ec.pYovRgCFxfnb89JHSJ1p(0x103FE975 ^ 0x103F4D49)));
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
										{
											num3 = 1;
										}
										continue;
									}
									IL_0196:
									num3 = num7;
									continue;
									IL_07d7:
									propertyMetadata2 = propertyMetadata;
									num3 = 18;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
									{
										num3 = 2;
									}
									continue;
									IL_080e:
									obj4 = obj6;
									num3 = 25;
									continue;
								}
								break;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num8 = 0;
						}
						switch (num8)
						{
						case 0:
							break;
						}
					}
				case 13:
					if (hV38WSWL8ZRTg4EypeVG(nPlChVWLKaQb3XWrKtJM(_003C_003Ec__DisplayClass8_.serializableFilter)))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto case 19;
				case 5:
					type = ReflectionType.GetType((string)KZ5W4MWLXlbIfKA9hGDN(_003C_003Ec__DisplayClass8_.serializableFilter));
					goto IL_09b5;
				case 3:
				case 6:
					return null;
				case 18:
					_003C_003Ec__DisplayClass8_.serializableFilter = (SerializableFilter)datafilter;
					num = 4;
					break;
				case 11:
					if (datafilter == null)
					{
						num = 6;
						break;
					}
					goto case 7;
				case 14:
					if (resolver == null)
					{
						num2 = 10;
						continue;
					}
					obj = (IEntityFilter)cFudYVWLOH1EpNoveI4y(resolver, _003C_003Ec__DisplayClass8_.serializableFilter.FilterType);
					goto IL_09e0;
				case 15:
				case 17:
					obj = filter;
					if (obj != null)
					{
						goto IL_09e0;
					}
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 14;
					}
					continue;
				case 8:
					{
						type = yO4AAKWLRYR2LnBbmw6t(typeof(Filter).TypeHandle);
						goto IL_09b5;
					}
					IL_09b5:
					obj = (IEntityFilter)tfCgqbWLnZLv9TKTqCmw(type);
					goto IL_09e0;
					IL_09e0:
					entityFilter = (IEntityFilter)obj;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	public static object Convert(object obj, Type type)
	{
		//Discarded unreachable code: IL_0049, IL_0058
		int num = 1;
		IConvertTypeWrapper convertTypeWrapper = default(IConvertTypeWrapper);
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (convertTypeWrapper == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
						{
							num2 = 3;
						}
						break;
					}
					goto case 4;
				case 8:
					if (_003C_003Ec__DisplayClass9_.obj != null)
					{
						goto end_IL_0012;
					}
					goto case 3;
				case 7:
					convertTypeWrapper = ComponentManager.Current.GetExtensionPoints<IConvertTypeWrapper>().FirstOrDefault(_003C_003Ec__DisplayClass9_._003CConvert_003Eb__0);
					num2 = 5;
					break;
				case 2:
					_003C_003Ec__DisplayClass9_.type = type;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num2 = 8;
					}
					break;
				case 1:
					_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					return HU58jcWLpkfk8EgadIu2(convertTypeWrapper, _003C_003Ec__DisplayClass9_.obj);
				case 3:
				case 6:
					return _003C_003Ec__DisplayClass9_.obj;
				case 9:
					if (!qBHDTlWYzHcmrqxhGq0j(_003C_003Ec__DisplayClass9_.type, _003C_003Ec__DisplayClass9_.obj.GetType()))
					{
						num2 = 6;
						break;
					}
					goto case 7;
				default:
					_003C_003Ec__DisplayClass9_.obj = obj;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 2;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 9;
		}
	}

	public static IEntityFilter Create(IEntityFilter source, ReferenceOnEntityType filterType)
	{
		return UnPack(Pack(source), filterType);
	}

	public UniversalFilterSaver()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		WlSqFhWLaAr8hYOdWIJF();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static UniversalFilterSaver()
	{
		int num = 1;
		int num2 = num;
		ParameterExpression parameterExpression = default(ParameterExpression);
		while (true)
		{
			switch (num2)
			{
			default:
				parameterExpression = (ParameterExpression)SBH0hvWLDQKEMQAMxvN6(yO4AAKWLRYR2LnBbmw6t(typeof(Type).TypeHandle), ohupIUWLNNf7hyZ7JppR(0x4EA5403C ^ 0x4EA54C1E));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				WlSqFhWLaAr8hYOdWIJF();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				getUniversalFilter = MetadataLoader.UseCachingForFunc(Expression.Lambda<Func<Type, Dictionary<Guid, string>>>(Expression.Call(null, (MethodInfo)lH8rcbWLtO6HbNTYOka5((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), parameterExpression), new ParameterExpression[1] { parameterExpression }));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static Type t5BWe8WYspFxTi9F4NK3(object P_0)
	{
		return ((PropertyInfo)P_0).PropertyType;
	}

	internal static Type oKrjyQWYcD1pcUh65Z4d(Type P_0)
	{
		return Nullable.GetUnderlyingType(P_0);
	}

	internal static bool qBHDTlWYzHcmrqxhGq0j(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object qIlRhXWLFXZ4LJ0O4nGB(Type P_0, object P_1)
	{
		return Enum.ToObject(P_0, P_1);
	}

	internal static void WrbSdTWLBqY949w1mU3o(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static bool zneReLWYLRGB6WMsxfeT()
	{
		return twwEdSWYYOaT4pc0BSaA == null;
	}

	internal static UniversalFilterSaver Y0PNU8WYU9SPKlXU02bg()
	{
		return twwEdSWYYOaT4pc0BSaA;
	}

	internal static object Its9pXWLWuCE61X6bqMA(object P_0)
	{
		return ((QueryParameterInfo)P_0).Object;
	}

	internal static object hiVPGMWLowblxYKJrZoY(object P_0)
	{
		return ((ListInfo)P_0).ListClass;
	}

	internal static object aIatDlWLb8BxDTrPA5y0(object P_0, Type type)
	{
		return Convert(P_0, type);
	}

	internal static object I2iaW6WLhIZZVnj3beUI(object P_0, object P_1, object P_2)
	{
		return ((MethodBase)P_0).Invoke(P_1, (object[])P_2);
	}

	internal static void B8l7WeWLGpKRtYw21wO2(object P_0, object P_1, object P_2)
	{
		((QueryParameters)P_0)[(string)P_1] = P_2;
	}

	internal static object ogiFwZWLEZ24JGKYCFnN(object P_0)
	{
		return ((QueryParameterInfo)P_0).Name;
	}

	internal static object F4NSn5WLf9UcHCWQb04v(object P_0)
	{
		return UnPackProperty(P_0);
	}

	internal static object fGxwSwWLQtPTK3JvhwRk()
	{
		return ComponentManager.Current;
	}

	internal static void qE0FAuWLCNhGqRQ6XFsn(object P_0, object P_1)
	{
		((SerializableFilter)P_0).FilterType = (string)P_1;
	}

	internal static object adw4h0WLv4o644SvSoI8(object P_0, object P_1)
	{
		return ((ITypeWrapperResolver)P_0).GetObjectInstanceDescriptor(P_1);
	}

	internal static bool hV38WSWL8ZRTg4EypeVG(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static Guid xpGFxJWLZxf4ARi1Viwp(object P_0)
	{
		return ((ITypeWrapperResolver)P_0).Uid;
	}

	internal static void PjxwK1WLu8S2NtnAXmow(object P_0, object P_1)
	{
		((SerializableFilter)P_0).ResolverType = (string)P_1;
	}

	internal static object VWfPw9WLIU0bLKLQj0CP(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object Ql5CPiWLVSv9wy9bulXW(Type type, object P_1)
	{
		return type.GetReflectionProperty((string)P_1);
	}

	internal static object IUnGtIWLSmJKILIPCw1r(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static bool R1UOx1WLi0bluoOFybaV(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static Type yO4AAKWLRYR2LnBbmw6t(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object e2looTWLqVQ22bNf1kQj(object P_0)
	{
		return ((IEnumerable)P_0).GetEnumerator();
	}

	internal static object nPlChVWLKaQb3XWrKtJM(object P_0)
	{
		return ((SerializableFilter)P_0).ResolverType;
	}

	internal static object KZ5W4MWLXlbIfKA9hGDN(object P_0)
	{
		return ((SerializableFilter)P_0).FilterType;
	}

	internal static Guid mtMI34WLT6AbFspTdC4l(object P_0)
	{
		return ((ReferenceOnEntityType)P_0).TypeUid;
	}

	internal static Type OpN6fdWLk6Jc8QUYWf2w(Guid uid)
	{
		return MetadataLoader.GetFilterType(uid);
	}

	internal static object tfCgqbWLnZLv9TKTqCmw(Type t)
	{
		return InterfaceActivator.Create(t);
	}

	internal static object cFudYVWLOH1EpNoveI4y(object P_0, object P_1)
	{
		return ((ITypeWrapperResolver)P_0).GetObjectInstance((string)P_1);
	}

	internal static object QyMASiWL2BcXqu8xorl3(object P_0)
	{
		return ((FilterProperty)P_0).Value;
	}

	internal static Guid NJ8ZH6WLeqbTW4lX2nOu(object P_0)
	{
		return ((FilterProperty)P_0).Uid;
	}

	internal static object bfA0f0WLPfO0wcQlYhw3(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static bool tA40aqWL1KVvKsnsH1mo(object P_0, object P_1)
	{
		return (MethodInfo)P_0 == (MethodInfo)P_1;
	}

	internal static object ohupIUWLNNf7hyZ7JppR(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void RSrS89WL3YAeVrekekQb(object P_0, object P_1, object P_2)
	{
		SetValue(P_0, P_1, P_2);
	}

	internal static object HU58jcWLpkfk8EgadIu2(object P_0, object P_1)
	{
		return ((IConvertTypeWrapper)P_0).ConvertWrapper(P_1);
	}

	internal static void WlSqFhWLaAr8hYOdWIJF()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object SBH0hvWLDQKEMQAMxvN6(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object lH8rcbWLtO6HbNTYOka5(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}
}
