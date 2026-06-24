using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Helpers;

public static class EntityQueryHelper
{
	private static EntityQueryHelper HOGulQhUQFPUc347gbgh;

	public static Type GetUsableType(Type type)
	{
		//Discarded unreachable code: IL_00b8
		int num = 2;
		int num2 = num;
		EntityMetadata entityMetadata = default(EntityMetadata);
		Type result = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 1:
				entityMetadata = MetadataLoader.LoadMetadata(type) as EntityMetadata;
				num2 = 4;
				break;
			case 3:
				result = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(hSI23ehUZRIBAWo1n5EU(entityMetadata), loadImplementation: false);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				if (L00sMYhU8dBXUi2MryKd(entityMetadata) == EntityMetadataType.InterfaceImplementation)
				{
					num2 = 3;
					break;
				}
				goto default;
			case 2:
				result = type;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return result;
			case 4:
				if (entityMetadata == null)
				{
					num2 = 6;
					break;
				}
				goto case 5;
			}
		}
	}

	private static IEntityFilter CreateFilter(Type entityType, object eqlQuery, Guid? filterProviderUid, object filterProviderData, object filterFields)
	{
		_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
		CS_0024_003C_003E8__locals0.filterProviderUid = filterProviderUid;
		Type entityFilterType = ModelHelper.GetEntityFilterType(entityType);
		object obj;
		if (!(entityFilterType != null))
		{
			IEntityFilter entityFilter = new Filter();
			obj = entityFilter;
		}
		else
		{
			obj = (IEntityFilter)InterfaceActivator.Create(entityFilterType);
		}
		IEntityFilter entityFilter2 = (IEntityFilter)obj;
		if (CS_0024_003C_003E8__locals0.filterProviderUid.HasValue)
		{
			IEntityFilterProvider entityFilterProvider = ComponentManager.Current.GetExtensionPoints<IEntityFilterProvider>().FirstOrDefault((IEntityFilterProvider p) => _003C_003Ec__DisplayClass6_0.qHFx8bvymFrJmkJQFRF9(p.ProviderUid, CS_0024_003C_003E8__locals0.filterProviderUid.Value));
			if (entityFilterProvider != null)
			{
				IEntityFilter filter = entityFilterProvider.GetFilter(CS_0024_003C_003E8__locals0.filterProviderUid.Value, entityFilter2);
				if (filter != null)
				{
					entityFilter2 = filter;
				}
				entityFilterProvider.ApplyFilter(entityFilter2, (string)filterProviderData);
			}
		}
		BindFilterFields(entityFilter2, (string)filterFields);
		if (!string.IsNullOrEmpty((string)eqlQuery))
		{
			entityFilter2.Query = (string)eqlQuery;
		}
		return entityFilter2;
	}

	public static void BindFilterFields(IEntityFilter filter, string filterFields)
	{
		//Discarded unreachable code: IL_0041, IL_0075, IL_0084, IL_0096, IL_00a5, IL_00b0, IL_0213, IL_0222, IL_0232, IL_0241, IL_028b, IL_0461, IL_0470, IL_04c3, IL_052d, IL_053c, IL_05bf, IL_063c, IL_064b, IL_0758, IL_0767, IL_085b, IL_087b, IL_088a, IL_09a8, IL_09f7, IL_0a12, IL_0a21, IL_0aad, IL_0b38, IL_0b78, IL_0b87, IL_0b93, IL_0ba2, IL_0c3f, IL_0d2b, IL_0d3a, IL_0ece, IL_0edd, IL_0f96, IL_0fa5, IL_0fb6, IL_1023, IL_10bd, IL_113d, IL_1181, IL_11b1, IL_11c0
		int num = 4;
		IEnumerator enumerator = default(IEnumerator);
		Match match = default(Match);
		object obj11 = default(object);
		ParameterInfo[] array = default(ParameterInfo[]);
		string text2 = default(string);
		string text3 = default(string);
		ParameterInfo[] array2 = default(ParameterInfo[]);
		object obj4 = default(object);
		Type type = default(Type);
		MethodInfo method = default(MethodInfo);
		Type genericTypeDefinition = default(Type);
		object obj5 = default(object);
		int result = default(int);
		object obj9 = default(object);
		IEnumerable<object> source2 = default(IEnumerable<object>);
		string text4 = default(string);
		MethodInfo method2 = default(MethodInfo);
		object obj10 = default(object);
		object obj12 = default(object);
		int result2 = default(int);
		IEnumerable<object> source = default(IEnumerable<object>);
		object obj3 = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 7:
					return;
				case 2:
					if (Regex.IsMatch(filterFields, (string)yMuYLNhUIyYVKnh00LDw(0x3B36AB09 ^ 0x3B350209)))
					{
						num2 = 5;
						continue;
					}
					return;
				case 1:
					return;
				case 6:
					try
					{
						while (true)
						{
							int num3;
							if (!pfDdNwhUxuZLfrN5KSfL(enumerator))
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
								{
									num3 = 0;
								}
								goto IL_00b4;
							}
							goto IL_10ed;
							IL_10ed:
							match = (Match)BBpFGvhUitqSs1OyMpjk(enumerator);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
							{
								num3 = 1;
							}
							goto IL_00b4;
							IL_00b4:
							switch (num3)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								try
								{
									IEnumerable<string> enumerable = from m in ((IEnumerable)OAcW8DhUVNjhhqqRVMnX(sKGLFghUKsOnP6tHLLlF(HcI91RhUquhuIoTC1EJu(UJMGuQhURgRghmI2xVno(match), 1)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x26FFCB59 ^ 0x26FC600D))).OfType<Match>()
										select (string)_003C_003Ec.xI6FDevydXDVaVDH16DI(m);
									object obj = filter;
									PropertyInfo propertyInfo = null;
									string text = null;
									IEnumerator<string> enumerator2 = enumerable.GetEnumerator();
									int num4 = 24;
									while (true)
									{
										object obj2;
										int num5;
										switch (num4)
										{
										case 32:
											obj11 = ((TypeConverter)sZe5nahUDFyHaQXokUoF(yk9bV7hUaceTdtvtKrFO(array[0]))).ConvertFrom((ITypeDescriptorContext)null, (CultureInfo)j2em7ChUtKFETkaTikaM(), (object)text2);
											num4 = 16;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
											{
												num4 = 23;
											}
											continue;
										case 27:
											goto end_IL_0145;
										case 7:
											if (text != null)
											{
												num4 = 21;
												continue;
											}
											goto case 5;
										case 14:
											if (obj != null)
											{
												num4 = 18;
												continue;
											}
											goto case 5;
										case 18:
											if (!k0jJiYhU2joo9MHauUC8(propertyInfo, null))
											{
												num4 = 7;
												continue;
											}
											goto case 21;
										case 24:
											try
											{
												while (true)
												{
													IL_04c8:
													int num6;
													if (!pfDdNwhUxuZLfrN5KSfL(enumerator2))
													{
														num6 = 10;
														goto IL_0295;
													}
													goto IL_0793;
													IL_0575:
													num6 = 54;
													goto IL_0295;
													IL_0793:
													text3 = enumerator2.Current;
													int num7 = 3;
													goto IL_0299;
													IL_0299:
													while (true)
													{
														object obj7;
														object obj6;
														object obj8;
														switch (num7)
														{
														case 20:
															if (array2.Length == 2)
															{
																num7 = 38;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
																{
																	num7 = 11;
																}
																continue;
															}
															goto case 16;
														case 49:
															if (vUb5SbhU4dO86JkBwKue(obj as IDictionary, obj4))
															{
																num7 = 18;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
																{
																	num7 = 11;
																}
																continue;
															}
															goto case 40;
														case 15:
															if (qY9yl3hUTnhvroQi1qow(text3, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951451890)))
															{
																num7 = 55;
																continue;
															}
															goto case 14;
														case 17:
															type = oqqmoihUPTXM8Bem0aXj(propertyInfo);
															num7 = 37;
															continue;
														case 23:
															obj = null;
															num7 = 29;
															continue;
														case 56:
															if (!D22mIBhU7KDJExIJFVpa(propertyInfo, null))
															{
																num7 = 35;
																continue;
															}
															goto case 4;
														case 2:
															if (!(method != null))
															{
																num7 = 27;
																continue;
															}
															obj7 = aSla23hUpnf274kkMjA8(method);
															goto IL_0ac2;
														case 26:
														case 53:
															break;
														case 33:
															if (xFJnnohUX1ZxmRGqI0S3(text3, yMuYLNhUIyYVKnh00LDw(-1876063057 ^ -1876067763)))
															{
																num7 = 15;
																continue;
															}
															goto case 14;
														case 52:
															obj6 = null;
															goto IL_0aec;
														case 13:
														case 35:
															goto IL_04c8;
														case 25:
														case 30:
														case 41:
														case 46:
															if (text3 == null)
															{
																num7 = 9;
																continue;
															}
															obj8 = X0xN0jhUAlVi0Sps2B1M(obj.GetType(), text3);
															goto IL_0b06;
														case 5:
															type = typeof(List<>).MakeGenericType(type.GetGenericArguments());
															num7 = 32;
															continue;
														case 43:
															genericTypeDefinition = type.GetGenericTypeDefinition();
															num7 = 31;
															continue;
														case 39:
															text3 = null;
															num7 = 14;
															continue;
														case 22:
															if (array2.Length == 1)
															{
																num7 = 50;
																continue;
															}
															goto case 11;
														case 14:
															if (k0jJiYhU2joo9MHauUC8(propertyInfo, null))
															{
																goto IL_0575;
															}
															goto case 57;
														case 38:
															obj4 = YshgJWhUwwBAyPJlKhnl(sZe5nahUDFyHaQXokUoF(yk9bV7hUaceTdtvtKrFO(array2[0])), null, j2em7ChUtKFETkaTikaM(), text);
															num7 = 1;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
															{
																num7 = 49;
															}
															continue;
														case 29:
															goto end_IL_04c8;
														case 51:
															LUvIg1hU3ZcgHCJT5ONl(propertyInfo, obj, obj5, null);
															num7 = 2;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
															{
																num7 = 12;
															}
															continue;
														case 31:
															if (genericTypeDefinition == SM7T93hU1sUK9loCEARO(typeof(IDictionary<, >).TypeHandle))
															{
																num7 = 28;
																continue;
															}
															goto case 7;
														case 16:
															if (int.TryParse(text, out result))
															{
																num7 = 53;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
																{
																	num7 = 25;
																}
																continue;
															}
															goto case 23;
														case 42:
															obj = obj9;
															num7 = 41;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
															{
																num7 = 46;
															}
															continue;
														case 6:
															if (!DRT7guhUNJ0UJ3L0qYun(genericTypeDefinition, SM7T93hU1sUK9loCEARO(typeof(ICollection<>).TypeHandle)))
															{
																num7 = 44;
																continue;
															}
															goto case 5;
														case 44:
															if (!DRT7guhUNJ0UJ3L0qYun(genericTypeDefinition, SM7T93hU1sUK9loCEARO(typeof(IList<>).TypeHandle)))
															{
																num7 = 34;
																continue;
															}
															goto case 5;
														case 7:
															if (!DRT7guhUNJ0UJ3L0qYun(genericTypeDefinition, SM7T93hU1sUK9loCEARO(typeof(IEnumerable<>).TypeHandle)))
															{
																num7 = 4;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
																{
																	num7 = 6;
																}
																continue;
															}
															goto case 5;
														case 4:
															if (text != null)
															{
																num7 = 13;
																continue;
															}
															goto end_IL_04c8;
														case 59:
															PRJmXVhUHcNXrRCVcbsP(method, obj, new object[1] { InterfaceActivator.Create(yk9bV7hUaceTdtvtKrFO(array2[0])) });
															num7 = 20;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
															{
																num7 = 36;
															}
															continue;
														case 19:
															if (obj5 != null)
															{
																num7 = 58;
																continue;
															}
															goto case 17;
														case 24:
															goto IL_0741;
														case 60:
															if (obj != null)
															{
																num7 = 39;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
																{
																	num7 = 41;
																}
																continue;
															}
															goto end_IL_04c8;
														case 45:
															goto IL_0793;
														case 12:
														case 58:
															obj = obj5;
															num7 = 30;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
															{
																num7 = 30;
															}
															continue;
														case 28:
															type = SM7T93hU1sUK9loCEARO(typeof(Dictionary<, >).TypeHandle).MakeGenericType(type.GetGenericArguments());
															num7 = 7;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
															{
																num7 = 0;
															}
															continue;
														case 50:
															if (result == source2.Count())
															{
																num7 = 59;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
																{
																	num7 = 41;
																}
																continue;
															}
															goto case 11;
														case 18:
															goto IL_081e;
														case 48:
															(obj as IDictionary).Add(obj4, obj9);
															num7 = 42;
															continue;
														case 57:
															if (text != null)
															{
																num7 = 8;
																continue;
															}
															goto case 25;
														case 32:
														case 34:
															obj5 = InterfaceActivator.Create(type);
															num7 = 40;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
															{
																num7 = 51;
															}
															continue;
														case 55:
															text4 = (string)bL9oCfhUOVEhoSCNsidt(((string)bL9oCfhUOVEhoSCNsidt(pcPwQGhUnut1mpj7HstB(text3, 1, YxtcHJhUkYBd2ZCAcFvD(text3) - 2), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53F9AB56), yMuYLNhUIyYVKnh00LDw(-475857671 ^ -475919845))).Replace((string)yMuYLNhUIyYVKnh00LDw(0x10E41EDB ^ 0x10E7B57B), (string)yMuYLNhUIyYVKnh00LDw(0x12A5FAC7 ^ 0x12A50C2F)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70002653), yMuYLNhUIyYVKnh00LDw(0x12A5FAC7 ^ 0x12A5E5B1));
															num7 = 39;
															continue;
														case 8:
															if (obj is IEnumerable)
															{
																num7 = 1;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
																{
																	num7 = 1;
																}
																continue;
															}
															goto case 25;
														case 40:
															obj9 = InterfaceActivator.Create(yk9bV7hUaceTdtvtKrFO(array2[1]));
															num7 = 48;
															continue;
														case 9:
															obj8 = null;
															goto IL_0b06;
														case 1:
															method = obj.GetType().GetMethod((string)yMuYLNhUIyYVKnh00LDw(-1459557599 ^ -1459597539));
															num7 = 2;
															continue;
														default:
															if (obj is IDictionary)
															{
																num7 = 47;
																continue;
															}
															goto case 16;
														case 27:
															obj7 = null;
															goto IL_0ac2;
														case 47:
															if (array2 != null)
															{
																num7 = 20;
																continue;
															}
															goto case 16;
														case 11:
														case 36:
															if (result < 0)
															{
																num7 = 52;
																continue;
															}
															obj6 = source2.Skip(result).FirstOrDefault();
															goto IL_0aec;
														case 3:
															text4 = null;
															num7 = 23;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
															{
																num7 = 33;
															}
															continue;
														case 54:
															obj5 = qr8DiDhUeoNACFOlfMGL(propertyInfo, obj, null);
															num7 = 19;
															continue;
														case 37:
															if (type.IsGenericType)
															{
																num7 = 43;
																continue;
															}
															goto case 32;
														case 21:
															if (array2 == null)
															{
																num7 = 11;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
																{
																	num7 = 1;
																}
																continue;
															}
															goto case 22;
														case 10:
															goto end_IL_04c8;
															IL_0aec:
															obj = obj6;
															num7 = 60;
															continue;
															IL_0ac2:
															array2 = (ParameterInfo[])obj7;
															num7 = 0;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
															{
																num7 = 0;
															}
															continue;
															IL_0b06:
															propertyInfo = (PropertyInfo)obj8;
															num7 = 24;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
															{
																num7 = 20;
															}
															continue;
														}
														break;
													}
													source2 = (obj as IEnumerable).Cast<object>();
													num6 = 21;
													goto IL_0295;
													IL_081e:
													obj = Ai7d8LhU6KCmMGn7OMGu(obj as IDictionary, obj4);
													num6 = 25;
													goto IL_0295;
													IL_0741:
													text = text4;
													num6 = 56;
													goto IL_0295;
													IL_0295:
													num7 = num6;
													goto IL_0299;
													continue;
													end_IL_04c8:
													break;
												}
											}
											finally
											{
												int num8;
												if (enumerator2 == null)
												{
													num8 = 2;
													goto IL_0b3c;
												}
												goto IL_0b52;
												IL_0b3c:
												switch (num8)
												{
												case 2:
													goto end_IL_0b27;
												case 1:
													goto end_IL_0b27;
												}
												goto IL_0b52;
												IL_0b52:
												enumerator2.Dispose();
												num8 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
												{
													num8 = 1;
												}
												goto IL_0b3c;
												end_IL_0b27:;
											}
											goto case 14;
										case 19:
											if (array.Length == 1)
											{
												num4 = 6;
												continue;
											}
											goto end_IL_0145;
										case 25:
											if (!(method2 != null))
											{
												num4 = 3;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
												{
													num4 = 0;
												}
												continue;
											}
											obj2 = method2.GetParameters();
											break;
										case 4:
											if (array == null)
											{
												num4 = 27;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
												{
													num4 = 0;
												}
												continue;
											}
											goto case 19;
										case 26:
											if (!k0jJiYhU2joo9MHauUC8(propertyInfo, null))
											{
												num4 = 10;
												continue;
											}
											goto default;
										case 2:
											if (obj is IEnumerable)
											{
												num5 = 15;
												goto IL_0141;
											}
											goto end_IL_0145;
										case 28:
											goto end_IL_0145;
										case 21:
											text2 = (string)bL9oCfhUOVEhoSCNsidt(bL9oCfhUOVEhoSCNsidt(((string)sKGLFghUKsOnP6tHLLlF(HcI91RhUquhuIoTC1EJu(UJMGuQhURgRghmI2xVno(match), 7))).Replace((string)yMuYLNhUIyYVKnh00LDw(0x49E27B8A ^ 0x49E1D022), (string)yMuYLNhUIyYVKnh00LDw(-1426094279 ^ -1426074167)), yMuYLNhUIyYVKnh00LDw(0x4EDCBA32 ^ 0x4EDF1182), yMuYLNhUIyYVKnh00LDw(0x1ECE530A ^ 0x1ECF0248)), yMuYLNhUIyYVKnh00LDw(-3333094 ^ -3327180), yMuYLNhUIyYVKnh00LDw(0x18A6761F ^ 0x18A66969));
											num4 = 16;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
											{
												num4 = 26;
											}
											continue;
										case 9:
											irtbeZhU0dcE6n93yItZ(obj as IDictionary, obj10, obj12);
											num5 = 20;
											goto IL_0141;
										case 30:
											goto end_IL_0145;
										case 6:
											if (int.TryParse(text, out result2))
											{
												num4 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
												{
													num4 = 13;
												}
												continue;
											}
											goto end_IL_0145;
										case 16:
											if (array != null)
											{
												num4 = 8;
												continue;
											}
											goto case 4;
										case 15:
											method2 = obj.GetType().GetMethod((string)yMuYLNhUIyYVKnh00LDw(0x638095EB ^ 0x638031D7));
											num4 = 5;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
											{
												num4 = 25;
											}
											continue;
										case 22:
											if (result2 == source.Count())
											{
												num4 = 32;
												continue;
											}
											goto end_IL_0145;
										case 11:
											obj12 = ((TypeConverter)sZe5nahUDFyHaQXokUoF(yk9bV7hUaceTdtvtKrFO(array[1]))).ConvertFrom((ITypeDescriptorContext)null, CultureInfo.InvariantCulture, (object)text2);
											num4 = 9;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
											{
												num4 = 0;
											}
											continue;
										case 5:
											((ILogger)jIbJOrhUmqmoqQ0XdQ7a()).Warn(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459404647), filter.GetType().CastAsRealType(), sKGLFghUKsOnP6tHLLlF(HcI91RhUquhuIoTC1EJu(UJMGuQhURgRghmI2xVno(match), 1)), sKGLFghUKsOnP6tHLLlF(((GroupCollection)UJMGuQhURgRghmI2xVno(match))[7])));
											num4 = 31;
											continue;
										case 23:
											method2.Invoke(obj, new object[1] { obj11 });
											num4 = 28;
											continue;
										case 17:
											obj10 = YshgJWhUwwBAyPJlKhnl(sZe5nahUDFyHaQXokUoF(yk9bV7hUaceTdtvtKrFO(array[0])), null, j2em7ChUtKFETkaTikaM(), text);
											num4 = 11;
											continue;
										case 10:
										case 33:
											if (text == null)
											{
												num4 = 30;
												continue;
											}
											goto case 2;
										case 29:
											goto end_IL_0145;
										case 13:
											source = (obj as IEnumerable).Cast<object>();
											num4 = 22;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
											{
												num4 = 7;
											}
											continue;
										case 12:
											LUvIg1hU3ZcgHCJT5ONl(propertyInfo, obj, obj3, null);
											num4 = 17;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
											{
												num4 = 29;
											}
											continue;
										case 1:
											if (obj is IDictionary)
											{
												num4 = 16;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
												{
													num4 = 10;
												}
												continue;
											}
											goto case 4;
										default:
											obj3 = YshgJWhUwwBAyPJlKhnl(TypeDescriptor.GetConverter(oqqmoihUPTXM8Bem0aXj(propertyInfo)), null, j2em7ChUtKFETkaTikaM(), text2);
											num4 = 6;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
											{
												num4 = 12;
											}
											continue;
										case 20:
											goto end_IL_0145;
										case 3:
											obj2 = null;
											break;
										case 8:
											if (array.Length == 2)
											{
												num4 = 17;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
												{
													num4 = 13;
												}
												continue;
											}
											goto case 4;
										case 31:
											goto end_IL_0145;
											IL_0141:
											num4 = num5;
											continue;
										}
										array = (ParameterInfo[])obj2;
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
										{
											num4 = 1;
										}
										continue;
										end_IL_0145:
										break;
									}
								}
								catch (Exception ex)
								{
									int num9 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
									{
										num9 = 0;
									}
									while (true)
									{
										switch (num9)
										{
										case 1:
											abbtdohUy96KhQhbgxHs(jIbJOrhUmqmoqQ0XdQ7a(), SR.T((string)yMuYLNhUIyYVKnh00LDw(-195614443 ^ -195788115), filter.GetType().CastAsRealType(), ((Capture)HcI91RhUquhuIoTC1EJu(UJMGuQhURgRghmI2xVno(match), 1)).Value, sKGLFghUKsOnP6tHLLlF(HcI91RhUquhuIoTC1EJu(UJMGuQhURgRghmI2xVno(match), 7))), ex);
											num9 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
											{
												num9 = 0;
											}
											continue;
										case 0:
											break;
										}
										break;
									}
								}
								break;
							case 2:
								break;
							case 3:
								goto IL_10ed;
							}
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						int num10 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
						{
							num10 = 1;
						}
						while (true)
						{
							switch (num10)
							{
							case 2:
								sufPKohUMuaxjDDNdmZp(disposable);
								num10 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
								{
									num10 = 0;
								}
								continue;
							case 0:
								break;
							case 1:
								if (disposable == null)
								{
									num10 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
									{
										num10 = 0;
									}
									continue;
								}
								goto case 2;
							case 3:
								break;
							}
							break;
						}
					}
				case 5:
					enumerator = (IEnumerator)RHOSCthUSbLDGS8lgI8b(OAcW8DhUVNjhhqqRVMnX(filterFields, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-978351861 ^ -978574437)));
					num2 = 6;
					continue;
				case 0:
					return;
				case 3:
					if (jtauMQhUuhCClCQPODVU(filterFields))
					{
						num2 = 7;
						continue;
					}
					goto case 2;
				case 4:
					if (filter == null)
					{
						return;
					}
					num = 3;
					break;
				}
				break;
			}
		}
	}

	public static long CountAllEntitiesWithFilter(Type entityType, string eqlQuery)
	{
		return CountAllEntitiesWithFilter(entityType, eqlQuery, null, null, null);
	}

	public static long CountAllEntitiesWithFilter(Type entityType, string eqlQuery, Guid? filterProviderUid, string filterProviderData, string filterFields)
	{
		IEntityManager entityManager = ModelHelper.GetEntityManager(GetUsableType(entityType));
		if (entityManager == null)
		{
			throw new ArgumentException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289694576), entityType), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1870880349));
		}
		IEntityFilter filter = CreateFilter(entityType, eqlQuery, filterProviderUid, filterProviderData, filterFields);
		return entityManager.Count(filter);
	}

	public static IEnumerable<IEntity> QueryAllEntitiesWithFilter(Type entityType, string eqlQuery, string sort, int limit, int offset)
	{
		return QueryAllEntitiesWithFilter(entityType, eqlQuery, sort, limit, offset, null, null, null);
	}

	public static IEnumerable<IEntity> QueryAllEntitiesWithFilter(Type entityType, string eqlQuery, string sort, int limit, int offset, Guid? filterProviderUid, string filterProviderData)
	{
		return QueryAllEntitiesWithFilter(entityType, eqlQuery, sort, limit, offset, filterProviderUid, filterProviderData, null);
	}

	public static IEnumerable<IEntity> QueryAllEntitiesWithFilter(Type entityType, string eqlQuery, string sort, int limit, int offset, Guid? filterProviderUid, string filterProviderData, string filterFields)
	{
		IEntityManager entityManager = ModelHelper.GetEntityManager(GetUsableType(entityType));
		if (entityManager == null)
		{
			throw new ArgumentException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4DC2B14D ^ 0x4DC263B7), entityType), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12A5FAC7 ^ 0x12A52953));
		}
		IEntityFilter filter = CreateFilter(entityType, eqlQuery, filterProviderUid, filterProviderData, filterFields);
		FetchOptions fetchOptions = new FetchOptions(offset, limit, sort);
		if (!string.IsNullOrWhiteSpace(sort))
		{
			string[] array = sort.Split(';');
			if (array.Length > 1)
			{
				string[] array2 = array;
				foreach (string text in array2)
				{
					ListSortDirection sortDirection = ListSortDirection.Descending;
					string sortExpression;
					if (text.EndsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638615039), StringComparison.OrdinalIgnoreCase))
					{
						sortDirection = ListSortDirection.Descending;
						sortExpression = text.Remove(text.Length - 5);
					}
					else
					{
						sortExpression = ((!text.EndsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2AFAD63), StringComparison.OrdinalIgnoreCase)) ? text : text.Remove(text.Length - 4));
					}
					fetchOptions.SortDescriptors.Add(new FetchOptionsSortDescriptor(sortExpression, sortDirection));
				}
			}
		}
		return entityManager.Find(filter, fetchOptions).Cast<IEntity>();
	}

	internal static EntityMetadataType L00sMYhU8dBXUi2MryKd(object P_0)
	{
		return ((EntityMetadata)P_0).Type;
	}

	internal static Guid hSI23ehUZRIBAWo1n5EU(object P_0)
	{
		return ((EntityMetadata)P_0).ImplementationUid;
	}

	internal static bool OnsA1DhUCqHIGCLcyj27()
	{
		return HOGulQhUQFPUc347gbgh == null;
	}

	internal static EntityQueryHelper rq9SqjhUv7Ayg4fpiZVQ()
	{
		return HOGulQhUQFPUc347gbgh;
	}

	internal static bool jtauMQhUuhCClCQPODVU(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object yMuYLNhUIyYVKnh00LDw(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object OAcW8DhUVNjhhqqRVMnX(object P_0, object P_1)
	{
		return Regex.Matches((string)P_0, (string)P_1);
	}

	internal static object RHOSCthUSbLDGS8lgI8b(object P_0)
	{
		return ((MatchCollection)P_0).GetEnumerator();
	}

	internal static object BBpFGvhUitqSs1OyMpjk(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static object UJMGuQhURgRghmI2xVno(object P_0)
	{
		return ((Match)P_0).Groups;
	}

	internal static object HcI91RhUquhuIoTC1EJu(object P_0, int P_1)
	{
		return ((GroupCollection)P_0)[P_1];
	}

	internal static object sKGLFghUKsOnP6tHLLlF(object P_0)
	{
		return ((Capture)P_0).Value;
	}

	internal static bool xFJnnohUX1ZxmRGqI0S3(object P_0, object P_1)
	{
		return ((string)P_0).StartsWith((string)P_1);
	}

	internal static bool qY9yl3hUTnhvroQi1qow(object P_0, object P_1)
	{
		return ((string)P_0).EndsWith((string)P_1);
	}

	internal static int YxtcHJhUkYBd2ZCAcFvD(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object pcPwQGhUnut1mpj7HstB(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static object bL9oCfhUOVEhoSCNsidt(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static bool k0jJiYhU2joo9MHauUC8(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 != (PropertyInfo)P_1;
	}

	internal static object qr8DiDhUeoNACFOlfMGL(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static Type oqqmoihUPTXM8Bem0aXj(object P_0)
	{
		return ((PropertyInfo)P_0).PropertyType;
	}

	internal static Type SM7T93hU1sUK9loCEARO(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool DRT7guhUNJ0UJ3L0qYun(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static void LUvIg1hU3ZcgHCJT5ONl(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static object aSla23hUpnf274kkMjA8(object P_0)
	{
		return ((MethodBase)P_0).GetParameters();
	}

	internal static Type yk9bV7hUaceTdtvtKrFO(object P_0)
	{
		return ((ParameterInfo)P_0).ParameterType;
	}

	internal static object sZe5nahUDFyHaQXokUoF(Type P_0)
	{
		return TypeDescriptor.GetConverter(P_0);
	}

	internal static object j2em7ChUtKFETkaTikaM()
	{
		return CultureInfo.InvariantCulture;
	}

	internal static object YshgJWhUwwBAyPJlKhnl(object P_0, object P_1, object P_2, object P_3)
	{
		return ((TypeConverter)P_0).ConvertFrom((ITypeDescriptorContext)P_1, (CultureInfo)P_2, P_3);
	}

	internal static bool vUb5SbhU4dO86JkBwKue(object P_0, object P_1)
	{
		return ((IDictionary)P_0).Contains(P_1);
	}

	internal static object Ai7d8LhU6KCmMGn7OMGu(object P_0, object P_1)
	{
		return ((IDictionary)P_0)[P_1];
	}

	internal static object PRJmXVhUHcNXrRCVcbsP(object P_0, object P_1, object P_2)
	{
		return ((MethodBase)P_0).Invoke(P_1, (object[])P_2);
	}

	internal static object X0xN0jhUAlVi0Sps2B1M(Type type, object P_1)
	{
		return type.GetReflectionProperty((string)P_1);
	}

	internal static bool D22mIBhU7KDJExIJFVpa(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static bool pfDdNwhUxuZLfrN5KSfL(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void irtbeZhU0dcE6n93yItZ(object P_0, object P_1, object P_2)
	{
		((IDictionary)P_0).Add(P_1, P_2);
	}

	internal static object jIbJOrhUmqmoqQ0XdQ7a()
	{
		return Logger.Log;
	}

	internal static void abbtdohUy96KhQhbgxHs(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static void sufPKohUMuaxjDDNdmZp(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}
