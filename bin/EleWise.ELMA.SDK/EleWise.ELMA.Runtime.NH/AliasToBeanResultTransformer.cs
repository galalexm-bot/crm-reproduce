using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Collections;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Bytecode;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Properties;
using NHibernate.Transform;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH;

[Serializable]
public class AliasToBeanResultTransformer : IResultTransformer
{
	private ConstructorInfo constructor;

	private readonly IPropertyAccessor propertyAccessor;

	private Type resultClass;

	private Dictionary<Type, (ISetter[] setters, Type[] types)> settersDict;

	private List<KeyValuePair<string, string>> collectionProperties;

	internal static AliasToBeanResultTransformer SbUN4MWwctUX4cPeBsdI;

	public AliasToBeanResultTransformer(Type resultClass)
	{
		//Discarded unreachable code: IL_004a, IL_008a, IL_00ca, IL_00d9, IL_0161
		l2jVVfW4BmC5Vy0I0GUZ();
		settersDict = new Dictionary<Type, (ISetter[], Type[])>();
		collectionProperties = new List<KeyValuePair<string, string>>();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				throw new ArgumentNullException((string)DhoOTWW4oy6kWawS3xbo(-1979251663 ^ -1979374217));
			case 9:
			{
				this.resultClass = resultClass;
				int num2 = 5;
				num = num2;
				break;
			}
			case 2:
				if (!zsjG9CW4WaMipc9tDsy1(resultClass, null))
				{
					num = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num = 9;
					}
					break;
				}
				goto case 3;
			case 1:
				throw new ArgumentException((string)DhoOTWW4oy6kWawS3xbo(0x6DC147B0 ^ 0x6DC366D0), (string)DhoOTWW4oy6kWawS3xbo(0x57A5235E ^ 0x57A70218));
			case 4:
			case 6:
				propertyAccessor = (IPropertyAccessor)(object)new EntityPropertyAccessor(reflectionOptimize: false);
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num = 7;
				}
				break;
			case 8:
				if (!resultClass.IsClass)
				{
					num = 6;
					break;
				}
				goto case 1;
			case 5:
				constructor = resultClass.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Type.EmptyTypes, null);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num = 0;
				}
				break;
			default:
				if (!Jypf7NW4b8wRma5mm8GE(constructor, null))
				{
					num = 4;
					break;
				}
				goto case 8;
			case 7:
				return;
			}
		}
	}

	public virtual IList TransformList(IList collection)
	{
		//Discarded unreachable code: IL_0063, IL_0112, IL_027d, IL_028c, IL_029c, IL_02af, IL_02be, IL_03ac, IL_03bb, IL_04ea, IL_0572, IL_084c, IL_0899, IL_08cf, IL_08e2, IL_08f1, IL_0982
		int num = 1;
		int num2 = num;
		IMetadataRuntimeService service = default(IMetadataRuntimeService);
		List<KeyValuePair<string, string>>.Enumerator enumerator = default(List<KeyValuePair<string, string>>.Enumerator);
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
		IEnumerator enumerator2 = default(IEnumerator);
		object obj = default(object);
		PropertyMetadata propertyMetadata3 = default(PropertyMetadata);
		EntityMetadata entityMetadata2 = default(EntityMetadata);
		_003C_003Ec__DisplayClass7_2 _003C_003Ec__DisplayClass7_3 = default(_003C_003Ec__DisplayClass7_2);
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		ISession val = default(ISession);
		Type typeByUid = default(Type);
		PropertyInfo property = default(PropertyInfo);
		bool flag = default(bool);
		_003C_003Ec__DisplayClass7_1 _003C_003Ec__DisplayClass7_2 = default(_003C_003Ec__DisplayClass7_1);
		Func<ICollection<object>> func = default(Func<ICollection<object>>);
		ConstructorInfo constructorInfo = default(ConstructorInfo);
		Type[] genericArguments = default(Type[]);
		object obj2 = default(object);
		EntityMetadata entityMetadata = default(EntityMetadata);
		object value = default(object);
		ITransformationProvider service2 = default(ITransformationProvider);
		while (true)
		{
			switch (num2)
			{
			case 4:
				service = Locator.GetService<IMetadataRuntimeService>();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num2 = 2;
				}
				break;
			case 6:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
							{
								num3 = 0;
							}
							goto IL_0075;
						}
						goto IL_00fb;
						IL_00fb:
						_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
						num3 = 4;
						goto IL_0075;
						IL_0075:
						while (true)
						{
							switch (num3)
							{
							case 2:
								enumerator2 = (IEnumerator)VHbhwyW4EOw1ZiYlAmkD(collection);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
								{
									num3 = 0;
								}
								continue;
							case 4:
							{
								_003C_003Ec__DisplayClass7_.collectionProperty = enumerator.Current;
								int num7 = 2;
								num3 = num7;
								continue;
							}
							case 5:
								break;
							case 3:
								goto IL_00fb;
							default:
								try
								{
									while (true)
									{
										IL_0512:
										int num4;
										if (!GmLHJvW41xkMnDcFQ26c(enumerator2))
										{
											num4 = 21;
											goto IL_0120;
										}
										goto IL_02c9;
										IL_0120:
										int num5 = num4;
										goto IL_0124;
										IL_02c9:
										obj = ooogC5W4ffNkmWMVQKnW(enumerator2);
										num5 = 29;
										goto IL_0124;
										IL_0124:
										while (true)
										{
											switch (num5)
											{
											case 20:
												break;
											case 14:
												propertyMetadata3 = entityMetadata2.Properties.FirstOrDefault(_003C_003Ec__DisplayClass7_3._003CTransformList_003Eb__2);
												num5 = 22;
												continue;
											case 8:
												_003C_003Ec__DisplayClass7_3.settings = (EntitySettings)EC84S4W4ZrLmwNPFLktC(propertyMetadata2);
												num5 = 9;
												continue;
											case 25:
												if (dyor5uW4VnL1vO7i00JZ(_003C_003Ec__DisplayClass7_3.settings) == RelationType.ManyToManyInverse)
												{
													num5 = 14;
													continue;
												}
												goto case 3;
											case 16:
												if (propertyMetadata != null)
												{
													num5 = 6;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
													{
														num5 = 5;
													}
													continue;
												}
												goto IL_0512;
											case 2:
												goto IL_02c9;
											case 39:
												_003C_003Ec__DisplayClass7_3.crit = (ICriteria)drkn88W4IfumbFFW9iqI(val, typeByUid);
												num5 = 15;
												continue;
											case 13:
												if (Fi2BHrW4vDXKP1rQkReS(property, null))
												{
													num5 = 28;
													continue;
												}
												goto case 12;
											case 38:
												flag = true;
												num5 = 3;
												continue;
											default:
												entityMetadata2 = (EntityMetadata)MetadataLoader.LoadMetadata(propertyMetadata2.SubTypeUid);
												num5 = 30;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
												{
													num5 = 39;
												}
												continue;
											case 10:
												if (!YAFkWCW48Z1LW2im9vj2(_003C_003Ec__DisplayClass7_2.propertyInfo, null))
												{
													num5 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
													{
														num5 = 1;
													}
													continue;
												}
												goto case 40;
											case 36:
												if (propertyMetadata2 != null)
												{
													num5 = 2;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
													{
														num5 = 23;
													}
													continue;
												}
												goto IL_0512;
											case 22:
												if (propertyMetadata3 == null)
												{
													num5 = 33;
													continue;
												}
												goto case 31;
											case 18:
												func = _003C_003Ec__DisplayClass7_3._003CTransformList_003Eb__4;
												num5 = 17;
												continue;
											case 41:
												if (!bPOZlAW42Goe6toveDbO(constructorInfo, null))
												{
													num5 = 7;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
													{
														num5 = 7;
													}
													continue;
												}
												goto case 18;
											case 23:
												_003C_003Ec__DisplayClass7_3 = new _003C_003Ec__DisplayClass7_2();
												num5 = 8;
												continue;
											case 26:
											case 34:
												genericArguments = _003C_003Ec__DisplayClass7_2.propertyInfo.PropertyType.GetGenericArguments();
												num5 = 4;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
												{
													num5 = 0;
												}
												continue;
											case 4:
												if (genericArguments.Length == 0)
												{
													num5 = 35;
													continue;
												}
												goto case 5;
											case 29:
												_003C_003Ec__DisplayClass7_2 = new _003C_003Ec__DisplayClass7_1();
												num5 = 42;
												continue;
											case 9:
												typeByUid = service.GetTypeByUid(bXT2dPW4ueVFtwROiJ9W(propertyMetadata2));
												num5 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
												{
													num5 = 0;
												}
												continue;
											case 32:
												propertyMetadata = entityMetadata2.Properties.FirstOrDefault(_003C_003Ec__DisplayClass7_3._003CTransformList_003Eb__3);
												num5 = 16;
												continue;
											case 6:
												uKtBQMW4kBaKiORLTOZC(_003C_003Ec__DisplayClass7_3.crit, propertyMetadata.Name, DhoOTWW4oy6kWawS3xbo(-2099751081 ^ -2099612373));
												num5 = 11;
												continue;
											case 17:
												obj2 = umRXpIW4e86OLcRmk8eX(constructorInfo, new object[1] { func });
												num5 = 20;
												continue;
											case 1:
											case 7:
											case 24:
											case 28:
											case 33:
											case 35:
												goto IL_0512;
											case 42:
												entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(iUAx1dW4QXZxCxdSIy5Y(obj.GetType()));
												num5 = 27;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
												{
													num5 = 4;
												}
												continue;
											case 15:
												flag = false;
												num5 = 25;
												continue;
											case 11:
												noT9jIW4TYVHGyTIh2BO(_003C_003Ec__DisplayClass7_3.crit, M3mBhxW4n26btH84xD5Y(DhoOTWW4oy6kWawS3xbo(0x1ECE530A ^ 0x1ECC718C), value));
												num5 = 34;
												continue;
											case 3:
												if (dyor5uW4VnL1vO7i00JZ(_003C_003Ec__DisplayClass7_3.settings) == RelationType.ManyToMany)
												{
													num5 = 24;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
													{
														num5 = 37;
													}
													continue;
												}
												goto case 32;
											case 5:
												constructorInfo = qr6GjHW4OFaA6xQGOR3l(typeof(LazyHashedSet<>).TypeHandle).MakeGenericType(genericArguments).GetConstructor(new Type[1] { qr6GjHW4OFaA6xQGOR3l(typeof(Func<ICollection<object>>).TypeHandle) });
												num5 = 41;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
												{
													num5 = 25;
												}
												continue;
											case 12:
												value = property.GetValue(obj, null);
												num5 = 10;
												continue;
											case 19:
												property = obj.GetType().GetProperty((string)DhoOTWW4oy6kWawS3xbo(-583745292 ^ -583777878));
												num5 = 13;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
												{
													num5 = 6;
												}
												continue;
											case 30:
												_003C_003Ec__DisplayClass7_2.propertyInfo = (PropertyInfo)Fds08qW4CdHaQmJwmrfC(obj.GetType(), _003C_003Ec__DisplayClass7_.collectionProperty.Value);
												num5 = 19;
												continue;
											case 31:
												_003C_003Ec__DisplayClass7_3.settings = (EntitySettings)EC84S4W4ZrLmwNPFLktC(propertyMetadata3);
												num5 = 38;
												continue;
											case 40:
												propertyMetadata2 = entityMetadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass7_2._003CTransformList_003Eb__1);
												num5 = 31;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
												{
													num5 = 36;
												}
												continue;
											case 27:
											{
												List<ClassMetadata> baseClasses = MetadataLoader.GetBaseClasses(entityMetadata);
												baseClasses.Add(entityMetadata);
												if (baseClasses.Any(_003C_003Ec__DisplayClass7_._003CTransformList_003Eb__0))
												{
													num5 = 30;
													continue;
												}
												goto IL_0512;
											}
											case 37:
												goto IL_073a;
											case 21:
												goto end_IL_0512;
											}
											break;
										}
										CJrLnmW4PU0iZ3y7MfoF(_003C_003Ec__DisplayClass7_2.propertyInfo, obj, obj2, null);
										num4 = 24;
										goto IL_0120;
										IL_073a:
										noT9jIW4TYVHGyTIh2BO(_003C_003Ec__DisplayClass7_3.crit, eXfK8GW4XiMWmJmD8Fe6(string.Format((string)DhoOTWW4oy6kWawS3xbo(0xE1229CF ^ 0xE100BC3), ((Dialect)dh55CKW4SlpTRJDXtQoK(service2)).QuoteIfNeeded((string)((!flag) ? O8WorIW4R1e3Wg9ejTOs(_003C_003Ec__DisplayClass7_3.settings) : yN0fvlW4iPxpVsWHuTPP(_003C_003Ec__DisplayClass7_3.settings))), ((Dialect)dh55CKW4SlpTRJDXtQoK(service2)).QuoteIfNeeded((string)fj99eNW4qAHaOptLgTyu(_003C_003Ec__DisplayClass7_3.settings)), QsqJWwW4KlZgkOXF9JEl(dh55CKW4SlpTRJDXtQoK(service2), (!flag) ? _003C_003Ec__DisplayClass7_3.settings.ParentColumnName : O8WorIW4R1e3Wg9ejTOs(_003C_003Ec__DisplayClass7_3.settings)), value, QsqJWwW4KlZgkOXF9JEl(dh55CKW4SlpTRJDXtQoK(service2), DhoOTWW4oy6kWawS3xbo(-1822890472 ^ -1822922938)))));
										num4 = 26;
										goto IL_0120;
										continue;
										end_IL_0512:
										break;
									}
								}
								finally
								{
									IDisposable disposable = enumerator2 as IDisposable;
									int num6 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
									{
										num6 = 0;
									}
									while (true)
									{
										switch (num6)
										{
										case 2:
											hFMMIaW4NSjNln6lXp9D(disposable);
											num6 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
											{
												num6 = 0;
											}
											continue;
										case 1:
											if (disposable != null)
											{
												num6 = 2;
												continue;
											}
											break;
										case 0:
											break;
										}
										break;
									}
								}
								break;
							case 1:
								return collection;
							}
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num8 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num8 = 0;
					}
					switch (num8)
					{
					case 0:
						break;
					}
				}
			case 3:
				return collection;
			default:
				val = (ISession)kO7tvZW4Gljol1qyDr9s(Locator.GetService<ISessionProvider>(), "");
				num2 = 4;
				break;
			case 7:
				enumerator = collectionProperties.GetEnumerator();
				num2 = 6;
				break;
			case 2:
				service2 = Locator.GetService<ITransformationProvider>();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
				{
					num2 = 7;
				}
				break;
			case 5:
				return collection;
			case 1:
				if (icvAraW4h3YtJYXr2IiJ(collectionProperties) != 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public virtual object TransformTuple(object[] tuple, string[] aliases)
	{
		//Discarded unreachable code: IL_024c, IL_0279, IL_02b7, IL_0426, IL_04c7, IL_04d6, IL_04e5, IL_04f5, IL_0524, IL_054f, IL_055e, IL_0631, IL_0648, IL_0657, IL_0698, IL_06a7, IL_0727, IL_0736, IL_07ac, IL_082c, IL_0843, IL_0852, IL_0862, IL_0871, IL_08f0, IL_08fa, IL_09b9, IL_09c8, IL_09d7, IL_0a1d, IL_0a2c, IL_0a48, IL_0a79, IL_0a88, IL_0a97, IL_0aa7, IL_0ad2, IL_0c26, IL_0caa, IL_0cd4, IL_0def, IL_0e46, IL_0e81, IL_0e90, IL_0ec8
		//IL_0dd5: Expected O, but got Unknown
		//IL_0e24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7b: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num2 = num;
		List<string> list2 = default(List<string>);
		ISetter val = default(ISetter);
		object obj = default(object);
		object v = default(object);
		_003C_003Ec__DisplayClass8_1 _003C_003Ec__DisplayClass8_2 = default(_003C_003Ec__DisplayClass8_1);
		ISetter[] array = default(ISetter[]);
		int num5 = default(int);
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		Type type = default(Type);
		Type typeByUid = default(Type);
		Type type3 = default(Type);
		ConstructorInfo constructorInfo = default(ConstructorInfo);
		EntityMetadata entityMetadata = default(EntityMetadata);
		IMetadataRuntimeService service = default(IMetadataRuntimeService);
		int num6 = default(int);
		byte[] array3 = default(byte[]);
		(ISetter[], Type[]) tuple2 = default((ISetter[], Type[]));
		Guid uid = default(Guid);
		Type[] array2 = default(Type[]);
		Type type2 = default(Type);
		PropertyInfo propertyInfo = default(PropertyInfo);
		bool flag = default(bool);
		while (true)
		{
			List<string> list;
			switch (num2)
			{
			case 3:
				try
				{
					int num3 = list2.FindIndex((string a) => ((StringComparer)_003C_003Ec.vuXVc9QlPHUDr3xdVQ9y()).Compare(a, (string)_003C_003Ec.gTT8BQQl19TYHuNcGRYV(-1108654032 ^ -1108425420)) == 0);
					int num4 = 67;
					while (true)
					{
						object obj2;
						int num9;
						int num10;
						switch (num4)
						{
						case 31:
						case 64:
						case 73:
							val.Set(obj, v);
							num4 = 55;
							break;
						case 18:
						case 22:
							num4 = 74;
							break;
						case 4:
							_003C_003Ec__DisplayClass8_2 = new _003C_003Ec__DisplayClass8_1();
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
							{
								num4 = 1;
							}
							break;
						case 63:
							_ = array[num5];
							num4 = 50;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
							{
								num4 = 12;
							}
							break;
						case 27:
						case 43:
							if (_003C_003Ec__DisplayClass8_.propertyName == null)
							{
								num4 = 34;
								break;
							}
							goto case 86;
						case 28:
							type = typeByUid;
							num4 = 8;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
							{
								num4 = 0;
							}
							break;
						case 58:
							if (array[num5] == null)
							{
								num4 = 17;
								break;
							}
							goto case 63;
						case 61:
							obj2 = nHJWA8W4xBFTggF3QXEK(L3YmviW4ADjtBYg8Flmd(AkNtr9W4HhI4dtgQtLtx()), n9yNWLW47ZLhFx1E3fcu(resultClass), true);
							goto IL_0d76;
						case 35:
							if (!zsjG9CW4WaMipc9tDsy1(type3.GetGenericTypeDefinition(), qr6GjHW4OFaA6xQGOR3l(typeof(ISet<>).TypeHandle)))
							{
								num4 = 73;
								break;
							}
							goto case 4;
						case 5:
							if (bPOZlAW42Goe6toveDbO(constructorInfo, null))
							{
								num4 = 39;
								break;
							}
							goto case 9;
						case 13:
							if (!D97k2JW4pVloGwJ1IK6W(_003C_003Ec__DisplayClass8_.resClassName))
							{
								num4 = 19;
								break;
							}
							goto case 27;
						case 71:
							collectionProperties.Add(new KeyValuePair<string, string>(_003C_003Ec__DisplayClass8_2.resClassName, _003C_003Ec__DisplayClass8_2.propertyName));
							num4 = 41;
							break;
						case 78:
							array = (ISetter[])(object)new ISetter[aliases.Length];
							num4 = 10;
							break;
						case 86:
							if (D97k2JW4pVloGwJ1IK6W(_003C_003Ec__DisplayClass8_.resClassName))
							{
								num4 = 18;
								break;
							}
							goto case 11;
						case 12:
							entityMetadata = service.GetMetadataList().OfType<EntityMetadata>().FirstOrDefault(_003C_003Ec__DisplayClass8_._003CTransformTuple_003Eb__1);
							num4 = 49;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
							{
								num4 = 7;
							}
							break;
						case 51:
							num6 = 0;
							num4 = 57;
							break;
						case 83:
							num5 = 0;
							num4 = 52;
							break;
						default:
							if (type3.IsEnum)
							{
								num4 = 7;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
								{
									num4 = 16;
								}
								break;
							}
							goto IL_08ea;
						case 81:
							_003C_003Ec__DisplayClass8_.resClassName = "";
							num9 = 54;
							goto IL_0062;
						case 36:
							ipwS1rW40RDhAydB4esg(val, obj, new Guid(array3));
							num9 = 53;
							goto IL_0062;
						case 56:
							val = tuple2.Item1[num6];
							num4 = 24;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
							{
								num4 = 10;
							}
							break;
						case 2:
							typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(uid);
							num4 = 14;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
							{
								num4 = 8;
							}
							break;
						case 9:
							if (bPOZlAW42Goe6toveDbO(constructor, null))
							{
								num4 = 13;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
								{
									num4 = 25;
								}
								break;
							}
							goto case 23;
						case 10:
							array2 = new Type[aliases.Length];
							num9 = 3;
							goto IL_0062;
						case 68:
							type2 = null;
							num4 = 13;
							break;
						case 17:
							try
							{
								Type type4 = type;
								int num7;
								if ((object)type4 == null)
								{
									num7 = 5;
									goto IL_0528;
								}
								goto IL_05ac;
								IL_0528:
								while (true)
								{
									switch (num7)
									{
									case 4:
										goto end_IL_0528;
									case 3:
										array2[num5] = hdusqUW46NbFHdm0IlV8(propertyInfo);
										num7 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
										{
											num7 = 1;
										}
										continue;
									default:
										if (!YAFkWCW48Z1LW2im9vj2(propertyInfo, null))
										{
											num7 = 4;
											continue;
										}
										goto case 2;
									case 5:
										type4 = resultClass;
										break;
									case 2:
										array[num5] = (ISetter)XvmH9yW4t29pLJtQnebc(propertyAccessor, type ?? resultClass, iF0dDWW4401GLUiVwxmQ(propertyInfo));
										num7 = 3;
										continue;
									case 1:
										goto end_IL_0528;
									}
									goto IL_05ac;
									continue;
									end_IL_0528:
									break;
								}
								goto end_IL_0511;
								IL_05ac:
								propertyInfo = type4.GetReflectionProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).FirstOrDefault(_003C_003Ec__DisplayClass8_._003CTransformTuple_003Eb__2);
								num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
								{
									num7 = 0;
								}
								goto IL_0528;
								end_IL_0511:;
							}
							catch
							{
								int num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
								{
									num8 = 0;
								}
								switch (num8)
								{
								case 0:
									break;
								}
							}
							goto case 63;
						case 41:
						case 53:
						case 55:
						case 82:
						case 85:
							num6++;
							num4 = 66;
							break;
						case 30:
							if (v != null)
							{
								num4 = 72;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
								{
									num4 = 46;
								}
								break;
							}
							goto case 65;
						case 79:
							if (tuple[num3] == null)
							{
								num4 = 84;
								break;
							}
							goto case 33;
						case 44:
							if (!zsjG9CW4WaMipc9tDsy1(type3, qr6GjHW4OFaA6xQGOR3l(typeof(Guid).TypeHandle)))
							{
								num4 = 75;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
								{
									num4 = 5;
								}
								break;
							}
							goto case 36;
						case 42:
							if (v == null)
							{
								num4 = 7;
								break;
							}
							goto case 30;
						case 48:
							constructorInfo = typeByUid.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Type.EmptyTypes, null);
							num4 = 28;
							break;
						case 67:
							constructorInfo = null;
							num4 = 62;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
							{
								num4 = 34;
							}
							break;
						case 62:
							type = null;
							num4 = 60;
							break;
						case 74:
							try
							{
								array[num5] = (ISetter)XvmH9yW4t29pLJtQnebc(propertyAccessor, type ?? resultClass, _003C_003Ec__DisplayClass8_.propertyName);
								int num11 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
								{
									num11 = 1;
								}
								while (true)
								{
									switch (num11)
									{
									case 1:
										array2[num5] = ((IGetter)TUIp52W4wRnh0mwV4g6Q(propertyAccessor, type ?? resultClass, _003C_003Ec__DisplayClass8_.propertyName)).get_ReturnType();
										num11 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
										{
											num11 = 0;
										}
										continue;
									case 0:
										break;
									}
									break;
								}
							}
							catch
							{
								int num12 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
								{
									num12 = 0;
								}
								switch (num12)
								{
								case 0:
									break;
								}
							}
							goto case 58;
						case 23:
							if (VsC7TxW43wrjXn6fAWJ5(type, null))
							{
								num4 = 59;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
								{
									num4 = 35;
								}
								break;
							}
							goto case 61;
						case 14:
							if (VsC7TxW43wrjXn6fAWJ5(typeByUid, null))
							{
								num4 = 48;
								break;
							}
							goto case 8;
						case 72:
							if (IsCompatible(ref v, type3))
							{
								num9 = 20;
								goto IL_0062;
							}
							goto case 65;
						case 87:
							array3 = v as byte[];
							num4 = 69;
							break;
						case 77:
							if (service != null)
							{
								num9 = 12;
								goto IL_0062;
							}
							goto case 27;
						case 46:
							if (collectionProperties.Any(_003C_003Ec__DisplayClass8_2._003CTransformTuple_003Eb__3))
							{
								num9 = 85;
								goto IL_0062;
							}
							goto case 71;
						case 60:
							if (num3 >= 0)
							{
								num4 = 79;
								break;
							}
							goto case 8;
						case 29:
							if (DCpoVlW4DEnGW8wUYGX6(_003C_003Ec__DisplayClass8_.resClassName, resultClass.Name))
							{
								num4 = 22;
								break;
							}
							goto case 34;
						case 32:
						case 40:
						case 45:
							if (zsjG9CW4WaMipc9tDsy1(type3, null))
							{
								num4 = 37;
								break;
							}
							goto case 42;
						case 54:
							_003C_003Ec__DisplayClass8_.propertyName = CustomPropertyProjection.GetExpressionFromString(aliases[num5], out _003C_003Ec__DisplayClass8_.resClassName);
							num4 = 68;
							break;
						case 38:
							_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
							num4 = 81;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
							{
								num4 = 66;
							}
							break;
						case 24:
							type3 = tuple2.Item2[num6];
							num4 = 87;
							break;
						case 25:
							obj2 = umRXpIW4e86OLcRmk8eX(constructor, null);
							goto IL_0d76;
						case 80:
							if (!(val != null && flag))
							{
								num4 = 11;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
								{
									num4 = 82;
								}
								break;
							}
							goto case 15;
						case 26:
						case 52:
							if (num5 >= aliases.Length)
							{
								num9 = 5;
								goto IL_0062;
							}
							goto case 38;
						case 57:
						case 66:
							if (num6 >= aliases.Length)
							{
								num4 = 70;
								break;
							}
							goto case 21;
						case 7:
							if (!clAWPvW4mYpngSlfHxxi(type3))
							{
								num4 = 30;
								break;
							}
							goto case 20;
						case 11:
							if (VsC7TxW43wrjXn6fAWJ5(type2, null))
							{
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
								{
									num4 = 6;
								}
								break;
							}
							goto case 29;
						case 34:
						case 50:
							num5++;
							num4 = 25;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
							{
								num4 = 26;
							}
							break;
						case 69:
							if (array3 == null)
							{
								num4 = 40;
								break;
							}
							goto case 44;
						case 47:
							type2 = service.GetTypeByUid(OnUrfOW4ajMJ2h3cesPs(entityMetadata));
							num4 = 43;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
							{
								num4 = 35;
							}
							break;
						case 21:
							v = tuple[num6];
							num4 = 19;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
							{
								num4 = 56;
							}
							break;
						case 1:
							_003C_003Ec__DisplayClass8_2.propertyName = CustomPropertyProjection.GetExpressionFromString(aliases[num6], out _003C_003Ec__DisplayClass8_2.resClassName);
							num4 = 23;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
							{
								num4 = 46;
							}
							break;
						case 15:
							if (!type3.IsGenericType)
							{
								num4 = 31;
								break;
							}
							goto case 35;
						case 33:
							uid = new Guid(tuple[num3].ToString());
							num4 = 2;
							break;
						case 16:
							num10 = (zsjG9CW4WaMipc9tDsy1(Enum.GetUnderlyingType(type3), v.GetType()) ? 1 : 0);
							goto IL_0db2;
						case 19:
							service = Locator.GetService<IMetadataRuntimeService>();
							num4 = 77;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
							{
								num4 = 15;
							}
							break;
						case 49:
							if (entityMetadata == null)
							{
								num4 = 27;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
								{
									num4 = 12;
								}
								break;
							}
							goto case 47;
						case 65:
							if (v != null)
							{
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
								{
									num4 = 0;
								}
								break;
							}
							goto IL_08ea;
						case 59:
							obj2 = Environment.get_BytecodeProvider().get_ObjectsFactory().CreateInstance(n9yNWLW47ZLhFx1E3fcu(type), true);
							goto IL_0d76;
						case 75:
							if (!zsjG9CW4WaMipc9tDsy1(type3, qr6GjHW4OFaA6xQGOR3l(typeof(Guid?).TypeHandle)))
							{
								num4 = 45;
								break;
							}
							goto case 36;
						case 8:
						case 84:
							if (!settersDict.ContainsKey(type ?? resultClass))
							{
								num4 = 78;
								break;
							}
							goto case 5;
						case 3:
							settersDict.Add(type ?? resultClass, (array, array2));
							num4 = 34;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
							{
								num4 = 83;
							}
							break;
						case 6:
							if (!type2.IsAssignableFrom(type ?? resultClass))
							{
								num4 = 29;
								break;
							}
							goto case 18;
						case 39:
							obj2 = constructorInfo.Invoke(null);
							goto IL_0d76;
						case 76:
							tuple2 = settersDict[type ?? resultClass];
							num4 = 51;
							break;
						case 20:
						case 37:
							num10 = 1;
							goto IL_0db2;
						case 70:
							{
								return obj;
							}
							IL_0d76:
							obj = obj2;
							num9 = 76;
							goto IL_0062;
							IL_0062:
							num4 = num9;
							break;
							IL_08ea:
							num10 = 0;
							goto IL_0db2;
							IL_0db2:
							flag = (byte)num10 != 0;
							num4 = 28;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
							{
								num4 = 80;
							}
							break;
						}
					}
				}
				catch (InstantiationException val2)
				{
					InstantiationException val3 = val2;
					int num13 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num13 = 0;
					}
					switch (num13)
					{
					default:
						throw new HibernateException((string)nCsKAlW4y9Y3IyonjtOd(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123771672), resultClass), (Exception)(object)val3);
					}
				}
				catch (MethodAccessException ex)
				{
					int num14 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num14 = 0;
					}
					switch (num14)
					{
					default:
						throw new HibernateException((string)nCsKAlW4y9Y3IyonjtOd(DhoOTWW4oy6kWawS3xbo(-1459557599 ^ -1459435081), resultClass), (Exception)ex);
					}
				}
			case 2:
				return obj;
			case 1:
				if (aliases == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				list = new List<string>(aliases);
				break;
			default:
				list = new List<string>();
				break;
			}
			list2 = list;
			num2 = 3;
		}
	}

	private bool IsCompatible(ref object v, Type propType)
	{
		//Discarded unreachable code: IL_0078, IL_011d, IL_0155
		int num = 2;
		int num2 = num;
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				propType = ebSw4MW4MOEag92iIt3d(propType);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				flag = false;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 1;
				}
				continue;
			case 3:
				return flag;
			}
			try
			{
				flag = v.GetType().IsCompatibleWith(propType);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num3 = 3;
				}
				while (true)
				{
					switch (num3)
					{
					case 4:
						if (!flag)
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
							{
								num3 = 0;
							}
							break;
						}
						return flag;
					case 3:
						if (v != null)
						{
							num3 = 4;
							break;
						}
						return flag;
					case 1:
						v = i7XMW2W4JcoR0te0Jtdg(v, propType);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
						{
							num3 = 0;
						}
						break;
					default:
						flag = true;
						num3 = 2;
						break;
					case 2:
						return flag;
					}
				}
			}
			catch
			{
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
				{
					num4 = 0;
				}
				while (true)
				{
					switch (num4)
					{
					case 1:
						return flag;
					}
					flag = false;
					num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num4 = 1;
					}
				}
			}
		}
	}

	internal static void l2jVVfW4BmC5Vy0I0GUZ()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool zsjG9CW4WaMipc9tDsy1(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object DhoOTWW4oy6kWawS3xbo(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool Jypf7NW4b8wRma5mm8GE(object P_0, object P_1)
	{
		return (ConstructorInfo)P_0 == (ConstructorInfo)P_1;
	}

	internal static bool lAgvM4Wwzx8uB3v3HHP5()
	{
		return SbUN4MWwctUX4cPeBsdI == null;
	}

	internal static AliasToBeanResultTransformer RDcqEvW4Fl2LjxCWeFAL()
	{
		return SbUN4MWwctUX4cPeBsdI;
	}

	internal static int icvAraW4h3YtJYXr2IiJ(object P_0)
	{
		return ((List<KeyValuePair<string, string>>)P_0).Count;
	}

	internal static object kO7tvZW4Gljol1qyDr9s(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static object VHbhwyW4EOw1ZiYlAmkD(object P_0)
	{
		return ((IEnumerable)P_0).GetEnumerator();
	}

	internal static object ooogC5W4ffNkmWMVQKnW(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static Type iUAx1dW4QXZxCxdSIy5Y(Type type)
	{
		return type.GetTypeWithoutProxy();
	}

	internal static object Fds08qW4CdHaQmJwmrfC(Type type, object P_1)
	{
		return type.GetReflectionProperty((string)P_1);
	}

	internal static bool Fi2BHrW4vDXKP1rQkReS(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static bool YAFkWCW48Z1LW2im9vj2(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 != (PropertyInfo)P_1;
	}

	internal static object EC84S4W4ZrLmwNPFLktC(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static Guid bXT2dPW4ueVFtwROiJ9W(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}

	internal static object drkn88W4IfumbFFW9iqI(object P_0, Type P_1)
	{
		return ((ISession)P_0).CreateCriteria(P_1);
	}

	internal static RelationType dyor5uW4VnL1vO7i00JZ(object P_0)
	{
		return ((EntitySettings)P_0).RelationType;
	}

	internal static object dh55CKW4SlpTRJDXtQoK(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object yN0fvlW4iPxpVsWHuTPP(object P_0)
	{
		return ((EntitySettings)P_0).ParentColumnName;
	}

	internal static object O8WorIW4R1e3Wg9ejTOs(object P_0)
	{
		return ((EntitySettings)P_0).ChildColumnName;
	}

	internal static object fj99eNW4qAHaOptLgTyu(object P_0)
	{
		return ((EntitySettings)P_0).RelationTableName;
	}

	internal static object QsqJWwW4KlZgkOXF9JEl(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object eXfK8GW4XiMWmJmD8Fe6(object P_0)
	{
		return Expression.Sql((string)P_0);
	}

	internal static object noT9jIW4TYVHGyTIh2BO(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object uKtBQMW4kBaKiORLTOZC(object P_0, object P_1, object P_2)
	{
		return ((ICriteria)P_0).CreateAlias((string)P_1, (string)P_2);
	}

	internal static object M3mBhxW4n26btH84xD5Y(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static Type qr6GjHW4OFaA6xQGOR3l(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool bPOZlAW42Goe6toveDbO(object P_0, object P_1)
	{
		return (ConstructorInfo)P_0 != (ConstructorInfo)P_1;
	}

	internal static object umRXpIW4e86OLcRmk8eX(object P_0, object P_1)
	{
		return ((ConstructorInfo)P_0).Invoke((object[])P_1);
	}

	internal static void CJrLnmW4PU0iZ3y7MfoF(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static bool GmLHJvW41xkMnDcFQ26c(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void hFMMIaW4NSjNln6lXp9D(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool VsC7TxW43wrjXn6fAWJ5(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static bool D97k2JW4pVloGwJ1IK6W(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static Guid OnUrfOW4ajMJ2h3cesPs(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static bool DCpoVlW4DEnGW8wUYGX6(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object XvmH9yW4t29pLJtQnebc(object P_0, Type P_1, object P_2)
	{
		return ((IPropertyAccessor)P_0).GetSetter(P_1, (string)P_2);
	}

	internal static object TUIp52W4wRnh0mwV4g6Q(object P_0, Type P_1, object P_2)
	{
		return ((IPropertyAccessor)P_0).GetGetter(P_1, (string)P_2);
	}

	internal static object iF0dDWW4401GLUiVwxmQ(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static Type hdusqUW46NbFHdm0IlV8(object P_0)
	{
		return ((PropertyInfo)P_0).PropertyType;
	}

	internal static object AkNtr9W4HhI4dtgQtLtx()
	{
		return Environment.get_BytecodeProvider();
	}

	internal static object L3YmviW4ADjtBYg8Flmd(object P_0)
	{
		return ((IBytecodeProvider)P_0).get_ObjectsFactory();
	}

	internal static Type n9yNWLW47ZLhFx1E3fcu(Type t)
	{
		return InterfaceActivator.TypeOf(t);
	}

	internal static object nHJWA8W4xBFTggF3QXEK(object P_0, Type P_1, bool P_2)
	{
		return ((IObjectsFactory)P_0).CreateInstance(P_1, P_2);
	}

	internal static void ipwS1rW40RDhAydB4esg(object P_0, object P_1, object P_2)
	{
		((ISetter)P_0).Set(P_1, P_2);
	}

	internal static bool clAWPvW4mYpngSlfHxxi(Type type)
	{
		return type.IsAssignableFromNull();
	}

	internal static object nCsKAlW4y9Y3IyonjtOd(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static Type ebSw4MW4MOEag92iIt3d(Type type)
	{
		return type.GetNonNullableType();
	}

	internal static object i7XMW2W4JcoR0te0Jtdg(object P_0, Type P_1)
	{
		return Convert.ChangeType(P_0, P_1);
	}
}
