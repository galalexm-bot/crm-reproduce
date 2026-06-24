using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Proxy;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Helpers;

public class CloneHelperBuilder
{
	private static CloneHelperBuilder eObpUehc6ZBKAJwmVHui;

	public static CloneHelperBuilder<T> Create<T>(T cloneObject) where T : class
	{
		_003C_003Ec__DisplayClass0_0<T> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass0_0<T>();
		CS_0024_003C_003E8__locals0.cloneObject = cloneObject;
		CloneHelperBuilder<T> cloneHelperBuilder = new CloneHelperBuilder<T>(CS_0024_003C_003E8__locals0.cloneObject);
		foreach (IEntityCopyRuleProvider item in from p in ComponentManager.Current.GetExtensionPoints<IEntityCopyRuleProvider>()
			where p.CheckType(CS_0024_003C_003E8__locals0.cloneObject)
			select p)
		{
			cloneHelperBuilder.Restrictions(item.InitRules);
		}
		return cloneHelperBuilder;
	}

	public CloneHelperBuilder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		gWBl7Ahc76OAZFdGWjl3();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void gWBl7Ahc76OAZFdGWjl3()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool dHxEhBhcHA3Wlhi7tUW1()
	{
		return eObpUehc6ZBKAJwmVHui == null;
	}

	internal static CloneHelperBuilder YN7yEWhcAE7kraQIFFUL()
	{
		return eObpUehc6ZBKAJwmVHui;
	}
}
public class CloneHelperBuilder<T> where T : class
{
	private T cloneObject;

	private T resultObject;

	private RestrictionList restrictions;

	private Dictionary<object, object> clonedObjects;

	internal static object yFpD6uhcxI8kOGtSMOoS;

	internal RestrictionList RestrictionList
	{
		get
		{
			return restrictions;
		}
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
					restrictions = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
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

	public T CloneObject
	{
		get
		{
			return cloneObject;
		}
		set
		{
			cloneObject = value;
		}
	}

	public Dictionary<object, object> ClonedObjects
	{
		get
		{
			return clonedObjects;
		}
		set
		{
			clonedObjects = value;
		}
	}

	private static ILogger Logger => Locator.GetServiceNotNull<ILogger>();

	private CloneHelperBuilder<T1> Create<T1>(T1 cloneObject, CloneHelperBuilder<T> helper) where T1 : class
	{
		CloneHelperBuilder<T1> cloneHelperBuilder = new CloneHelperBuilder<T1>(cloneObject);
		if (helper != null)
		{
			cloneHelperBuilder.RestrictionList = helper.RestrictionList;
			cloneHelperBuilder.ClonedObjects = helper.ClonedObjects;
		}
		return cloneHelperBuilder;
	}

	public CloneHelperBuilder(T cloneObject)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		SingletonReader.JJCZtPuTvSt();
		restrictions = new RestrictionList();
		clonedObjects = new Dictionary<object, object>();
		base._002Ector();
		this.cloneObject = cloneObject;
		if (NHibernateProxyHelper.IsProxy((object)cloneObject))
		{
			this.cloneObject = (T)((INHibernateProxy)cloneObject).get_HibernateLazyInitializer().GetImplementation();
		}
	}

	public CloneHelperBuilder<T> Restrictions(Action<RestrictionsBuilder<T>> restrictionBuilder)
	{
		RestrictionsBuilder<T> obj = new RestrictionsBuilder<T>(restrictions);
		restrictionBuilder(obj);
		return this;
	}

	public CloneHelperBuilder<T> SetClonedObject<T2>(T2 obj, T2 clonedObj)
	{
		clonedObjects.Add(obj, clonedObj);
		return this;
	}

	private static bool IsSimpleType(Type type)
	{
		//Discarded unreachable code: IL_0040, IL_004f
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return type == typeof(string);
			default:
				return true;
			case 1:
				if (type.GetMethods().FirstOrDefault(delegate(MethodInfo m)
				{
					//Discarded unreachable code: IL_009c, IL_00ab
					int num3 = 4;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						case 5:
							if (m.GetParameters().Length == 2)
							{
								num4 = 2;
								break;
							}
							goto case 3;
						case 2:
							if (m.GetParameters()[0].ParameterType == typeof(string))
							{
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
								{
									num4 = 0;
								}
								break;
							}
							goto case 3;
						default:
							return m.GetParameters()[1].IsOut;
						case 3:
							return false;
						case 1:
							if (m.Name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFB2EF6))
							{
								num4 = 5;
								break;
							}
							goto case 3;
						case 4:
							if (!m.IsStatic)
							{
								num4 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
								{
									num4 = 1;
								}
								break;
							}
							goto case 1;
						}
					}
				}) != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	private static bool IsSimpleOrNullable(Type type)
	{
		//Discarded unreachable code: IL_00c2, IL_00d1
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				if (!type.IsGenericType)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 3;
			case 5:
				if (type.IsGenericType)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 3:
				return type.GetGenericTypeDefinition() == typeof(Nullable<>);
			case 1:
				return false;
			case 2:
				break;
			}
			if (IsSimpleType(type))
			{
				break;
			}
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
			{
				num2 = 0;
			}
		}
		return true;
	}

	private static object CloneCollection(IEnumerable value, Type valueType, Func<Type, object, object> selectFunc, object resCollection, Func<bool> isNoneCascadeModeFunc = null, CollectionUpdateMode collectionUpdateMode = CollectionUpdateMode.AppendMissing, IEqualityComparer<object> comparer = null)
	{
		_003C_003Ec__DisplayClass19_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass19_0();
		CS_0024_003C_003E8__locals0.selectFunc = selectFunc;
		CS_0024_003C_003E8__locals0.resCollection = resCollection;
		CS_0024_003C_003E8__locals0.collectionUpdateMode = collectionUpdateMode;
		CS_0024_003C_003E8__locals0.comparer = comparer;
		if (value == null)
		{
			return null;
		}
		bool flag = CS_0024_003C_003E8__locals0.resCollection is Array || valueType.IsArray;
		CS_0024_003C_003E8__locals0.elementType = (flag ? ((CS_0024_003C_003E8__locals0.resCollection != null) ? CS_0024_003C_003E8__locals0.resCollection.GetType() : valueType).GetElementType() : null);
		if (!flag && CS_0024_003C_003E8__locals0.resCollection == null)
		{
			try
			{
				if (!valueType.IsInterface)
				{
					CS_0024_003C_003E8__locals0.resCollection = Activator.CreateInstance(valueType);
				}
				else
				{
					flag = value is Array;
					if (flag)
					{
						CS_0024_003C_003E8__locals0.elementType = value.GetType().GetElementType();
					}
					else
					{
						CS_0024_003C_003E8__locals0.resCollection = Activator.CreateInstance(value.GetType());
					}
				}
			}
			catch (Exception exception)
			{
				Logger.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882352092), exception);
			}
			if (!flag && CS_0024_003C_003E8__locals0.resCollection == null)
			{
				return null;
			}
		}
		MethodInfo methodInfo = ((!flag) ? CS_0024_003C_003E8__locals0.resCollection.GetType().GetMethods().FirstOrDefault(delegate(MethodInfo m)
		{
			//Discarded unreachable code: IL_0074, IL_0083
			int num7 = 1;
			int num8 = num7;
			while (true)
			{
				switch (num8)
				{
				case 2:
					return !m.IsGenericMethod;
				default:
					return false;
				case 1:
					if (!(m.Name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7459E02 ^ 0x7453A3E)))
					{
						num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
						{
							num8 = 0;
						}
						break;
					}
					goto case 2;
				}
			}
		}) : null);
		MethodInfo methodInfo2 = ((!flag && CS_0024_003C_003E8__locals0.collectionUpdateMode == CollectionUpdateMode.Match) ? CS_0024_003C_003E8__locals0.resCollection.GetType().GetMethods().FirstOrDefault(delegate(MethodInfo m)
		{
			int num5 = 1;
			int num6 = num5;
			while (true)
			{
				switch (num6)
				{
				default:
					return !m.IsGenericMethod;
				case 1:
					if (!(m.Name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6DC147B0 ^ 0x6DC1E328)))
					{
						return false;
					}
					num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num6 = 0;
					}
					break;
				}
			}
		}) : null);
		if (!flag)
		{
			if (methodInfo != null)
			{
				ParameterInfo[] parameters = methodInfo.GetParameters();
				if (parameters.Length == 1)
				{
					CS_0024_003C_003E8__locals0.elementType = parameters[0].ParameterType;
				}
			}
			else
			{
				if (!(methodInfo2 != null))
				{
					return CS_0024_003C_003E8__locals0.resCollection;
				}
				ParameterInfo[] parameters2 = methodInfo2.GetParameters();
				if (parameters2.Length == 1)
				{
					CS_0024_003C_003E8__locals0.elementType = parameters2[0].ParameterType;
				}
			}
		}
		CS_0024_003C_003E8__locals0.val = value.Cast<object>().ToArray();
		IEnumerable enumerable = CS_0024_003C_003E8__locals0.resCollection as IEnumerable;
		CS_0024_003C_003E8__locals0.res = ((enumerable == null) ? new object[0] : enumerable.Cast<object>().ToArray());
		object[] array = CS_0024_003C_003E8__locals0.val.Select((object o) => CS_0024_003C_003E8__locals0.selectFunc(CS_0024_003C_003E8__locals0.elementType, o)).Where(delegate(object v)
		{
			int num3 = 1;
			int num4 = num3;
			while (true)
			{
				switch (num4)
				{
				case 2:
					return !CS_0024_003C_003E8__locals0.res.Contains(v, CS_0024_003C_003E8__locals0.comparer);
				default:
					if (CS_0024_003C_003E8__locals0.collectionUpdateMode != CollectionUpdateMode.AppendAll)
					{
						num4 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
						{
							num4 = 0;
						}
						break;
					}
					goto IL_003e;
				case 1:
					{
						if (CS_0024_003C_003E8__locals0.resCollection != null)
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
							{
								num4 = 0;
							}
							break;
						}
						goto IL_003e;
					}
					IL_003e:
					return true;
				}
			}
		}).ToArray();
		object[] array2 = ((CS_0024_003C_003E8__locals0.collectionUpdateMode == CollectionUpdateMode.Match) ? (from o in CS_0024_003C_003E8__locals0.res
			select CS_0024_003C_003E8__locals0.selectFunc(CS_0024_003C_003E8__locals0.elementType, o) into x
			where !CS_0024_003C_003E8__locals0.val.Contains(x, CS_0024_003C_003E8__locals0.comparer)
			select x).ToArray() : new object[0]);
		bool flag2 = isNoneCascadeModeFunc != null && isNoneCascadeModeFunc() && (array.Any() || array2.Any());
		if (flag)
		{
			int num = CS_0024_003C_003E8__locals0.res.Count() - array2.Length;
			Array array3 = Array.CreateInstance(CS_0024_003C_003E8__locals0.elementType, num + array.Length);
			int num2 = 0;
			for (int i = 0; i < CS_0024_003C_003E8__locals0.val.Length; i++)
			{
				object value2 = CS_0024_003C_003E8__locals0.val[i];
				if (array2.Contains(value2, CS_0024_003C_003E8__locals0.comparer))
				{
					array3.SetValue(value2, num2++);
				}
			}
			for (int j = 0; j < array.Length; j++)
			{
				object obj = array[j];
				if (flag2 && obj is IEntity)
				{
					((IEntity)obj).Save();
				}
				array3.SetValue(obj, j + num);
			}
			CS_0024_003C_003E8__locals0.resCollection = array3;
		}
		else
		{
			if (methodInfo2 != null)
			{
				object[] res = CS_0024_003C_003E8__locals0.res;
				foreach (object obj2 in res)
				{
					if (array2.Contains(obj2, CS_0024_003C_003E8__locals0.comparer))
					{
						methodInfo2.Invoke(CS_0024_003C_003E8__locals0.resCollection, new object[1] { obj2 });
					}
				}
			}
			if (methodInfo != null)
			{
				object[] res = array;
				foreach (object obj3 in res)
				{
					if (flag2 && obj3 is IEntity)
					{
						((IEntity)obj3).Save();
					}
					methodInfo.Invoke(CS_0024_003C_003E8__locals0.resCollection, new object[1] { obj3 });
				}
			}
		}
		return CS_0024_003C_003E8__locals0.resCollection;
	}

	public T Clone(T resObj = null)
	{
		_003C_003Ec__DisplayClass20_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass20_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		if (cloneObject == null)
		{
			return null;
		}
		Type type = cloneObject.GetType();
		if (NHibernateProxyHelper.IsProxy((object)cloneObject))
		{
			type = NHibernateUtil.GetClass((object)cloneObject);
		}
		if (cloneObject is IEnumerable value2)
		{
			return (T)CloneCollection(value2, typeof(T), delegate(Type elementType, object value)
			{
				//Discarded unreachable code: IL_006b, IL_007a
				int num10 = 2;
				int num11 = num10;
				while (true)
				{
					switch (num11)
					{
					case 1:
						if (IsSimpleOrNullable(value.GetType()))
						{
							num11 = 3;
							continue;
						}
						goto default;
					case 2:
						if (value != null)
						{
							num11 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
							{
								num11 = 1;
							}
							continue;
						}
						break;
					default:
						return CS_0024_003C_003E8__locals0._003C_003E4__this.Create(value, CS_0024_003C_003E8__locals0._003C_003E4__this).Clone(value.GetType().IsInheritOrSame(elementType) ? null : InterfaceActivator.Create(elementType));
					case 3:
						break;
					}
					break;
				}
				return value;
			}, resObj);
		}
		if (typeof(EnumBase).IsAssignableFrom(type) || type.IsEnum)
		{
			return cloneObject;
		}
		if (clonedObjects.ContainsKey(cloneObject))
		{
			return (T)clonedObjects[cloneObject];
		}
		if (cloneObject is ICloneable)
		{
			Logger.Debug(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A452D4)));
		}
		PropertyInfo[] reflectionProperties = type.GetReflectionProperties();
		if (type.GetConstructors().Any((ConstructorInfo c) => c.GetParameters().Length == 0))
		{
			try
			{
				resultObject = resObj ?? ((T)InterfaceActivator.Create(type));
			}
			catch (Exception exception)
			{
				Logger.Error(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638644619), type), exception);
				throw;
			}
			clonedObjects.Add(cloneObject, resultObject);
			if (cloneObject is ReferenceOnEntity)
			{
				(resultObject as ReferenceOnEntity).ObjectTypeUId = (cloneObject as ReferenceOnEntity).ObjectTypeUId;
				(resultObject as ReferenceOnEntity).ObjectId = (cloneObject as ReferenceOnEntity).ObjectId;
				return resultObject;
			}
			if (cloneObject is ReferenceOnEntityType)
			{
				(resultObject as ReferenceOnEntityType).TypeUid = (cloneObject as ReferenceOnEntityType).TypeUid;
				return resultObject;
			}
			CS_0024_003C_003E8__locals0.metadata = (ClassMetadata)MetadataLoader.LoadMetadata(type);
			PropertyInfo[] array = reflectionProperties;
			foreach (PropertyInfo propertyInfo in array)
			{
				_003C_003Ec__DisplayClass20_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass20_1();
				CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
				if (propertyInfo.GetCustomAttributes(typeof(ObsoleteAttribute), inherit: false).Length != 0 || !propertyInfo.CanWrite || propertyInfo.GetSetMethod() == null)
				{
					continue;
				}
				object value3 = propertyInfo.GetValue(cloneObject, null);
				CS_0024_003C_003E8__locals1.rulesPropertyCopyAction = (restrictions.IsPropertyIgnore(propertyInfo, type) ? CopyAction.Ignore : (restrictions.IsPropertyClone(propertyInfo, type) ? CopyAction.Clone : (restrictions.IsPropertyByRef(propertyInfo, type) ? CopyAction.ByRef : (restrictions.IsPropertySaveRef(propertyInfo, type) ? CopyAction.SaveRef : (restrictions.IsPropertyAction(propertyInfo, type) ? restrictions.PropertyAction(propertyInfo.Name, type, cloneObject, value3) : (restrictions.IsAllPropertiesIgnore(type) ? CopyAction.Ignore : (restrictions.IsAllPropertiesClone(type) ? CopyAction.Clone : (restrictions.IsAllPropertiesByRef(type) ? CopyAction.ByRef : (restrictions.IsAllPropertiesSaveRef(type) ? CopyAction.SaveRef : (restrictions.IsAllPropertiesAction(type) ? CopyAction.Default : CopyAction.Default))))))))));
				if (CS_0024_003C_003E8__locals1.rulesPropertyCopyAction == CopyAction.Ignore)
				{
					continue;
				}
				CopyAction copyAction = ((CS_0024_003C_003E8__locals1.rulesPropertyCopyAction != 0) ? CS_0024_003C_003E8__locals1.rulesPropertyCopyAction : ((value3 == null) ? CopyAction.ByRef : (restrictions.IsTypeIgnore(value3) ? CopyAction.Ignore : (restrictions.IsTypeClone(value3) ? CopyAction.Clone : (restrictions.IsTypeByRef(value3) ? CopyAction.ByRef : (restrictions.IsTypeSaveRef(value3) ? CopyAction.SaveRef : (restrictions.IsTypeAction(value3) ? restrictions.Action(cloneObject, value3) : CopyAction.Default)))))));
				CS_0024_003C_003E8__locals1.copyAction4Property = GetCopyAction4Property(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.metadata, propertyInfo);
				CS_0024_003C_003E8__locals1.copyAction4PropertyRelation = GetCopyAction4PropertyRelation(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.metadata, propertyInfo);
				CopyAction copyAction2 = ((copyAction != 0) ? copyAction : CS_0024_003C_003E8__locals1.copyAction4Property);
				if (copyAction2 == CopyAction.Default)
				{
					CopyActionAttribute attribute = AttributeHelper<CopyActionAttribute>.GetAttribute(propertyInfo, inherited: true);
					if (attribute != null)
					{
						copyAction2 = attribute.CopyAction;
					}
				}
				CopyAction copyAction3 = ((copyAction2 != 0) ? copyAction2 : GetCopyAction4Entity(value3));
				CopyAction copyAction4 = ((copyAction3 != 0) ? copyAction3 : CS_0024_003C_003E8__locals1.copyAction4PropertyRelation);
				CopyAction copyAction5 = ((copyAction4 != 0) ? copyAction4 : ((!restrictions.CloneRecursive) ? CopyAction.ByRef : CopyAction.Clone));
				if (copyAction5 == CopyAction.Ignore)
				{
					continue;
				}
				Type type2 = ((propertyInfo.PropertyType == typeof(IEnumerable)) ? propertyInfo.PropertyType : propertyInfo.PropertyType.GetInterface(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710557756), ignoreCase: true));
				PropertyInfo reflectionProperty = resultObject.GetType().GetReflectionProperty(propertyInfo.Name);
				if (reflectionProperty == null)
				{
					continue;
				}
				if (value3 == null || IsSimpleOrNullable(propertyInfo.PropertyType) || (propertyInfo.PropertyType.IsArray && value3.GetType() == typeof(byte[])) || (type2 == null && (copyAction5 == CopyAction.SaveRef || (copyAction5 == CopyAction.ByRef && !clonedObjects.ContainsKey(value3)))))
				{
					if (reflectionProperty.CanWrite)
					{
						reflectionProperty.SetValue(resultObject, value3, null);
					}
					continue;
				}
				if (clonedObjects.ContainsKey(value3) || type2 == null)
				{
					object obj = (clonedObjects.ContainsKey(value3) ? clonedObjects[value3] : Create(value3, this).Clone());
					if ((obj is IEntity || obj is IEnumerable) && IsNoneCascadeMode(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.metadata, propertyInfo))
					{
						Logger.WarnFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53F1E13), propertyInfo.DeclaringType, propertyInfo.Name);
						if (obj is IEntity entity)
						{
							entity.Save();
						}
						else
						{
							foreach (IEntity item in ((IEnumerable)obj).OfType<IEntity>())
							{
								item.Save();
							}
						}
					}
					if (reflectionProperty.CanWrite)
					{
						reflectionProperty.SetValue(resultObject, obj, null);
					}
					continue;
				}
				object obj2 = (reflectionProperty.CanRead ? reflectionProperty.GetValue(resultObject, null) : null);
				if ((obj2 == null || obj2.GetType().IsArray) && !reflectionProperty.CanWrite)
				{
					continue;
				}
				CS_0024_003C_003E8__locals1.info = propertyInfo;
				obj2 = CloneCollection((IEnumerable)value3, reflectionProperty.PropertyType, delegate(Type elementType, object value)
				{
					//Discarded unreachable code: IL_00d4, IL_00ef, IL_00fe, IL_0120, IL_012f, IL_013f, IL_0158, IL_0162, IL_01a8, IL_01fe, IL_0271, IL_02c0, IL_02d0, IL_02db, IL_02e5, IL_02f4, IL_032a, IL_0335, IL_0345, IL_0350, IL_035b, IL_0376, IL_0380
					int num3 = 2;
					CopyAction copyAction8 = default(CopyAction);
					CopyAction copyAction6 = default(CopyAction);
					CopyAction copyAction9 = default(CopyAction);
					CopyAction copyAction10 = default(CopyAction);
					CopyAction copyAction7 = default(CopyAction);
					while (true)
					{
						int num4 = num3;
						while (true)
						{
							int num7;
							CopyAction num8;
							CopyAction num9;
							CopyAction num5;
							int num6;
							switch (num4)
							{
							case 14:
								if (!CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1._003C_003E4__this.restrictions.IsTypeIgnore(value))
								{
									num4 = 27;
									continue;
								}
								num7 = 3;
								goto IL_0394;
							case 23:
								if (copyAction8 != 0)
								{
									num4 = 22;
									continue;
								}
								goto case 4;
							case 25:
								num7 = 4;
								goto IL_0394;
							case 24:
								if (copyAction6 == CopyAction.Default)
								{
									num4 = 5;
									continue;
								}
								num8 = copyAction6;
								goto IL_03ce;
							case 9:
								if (copyAction9 != CopyAction.ByRef)
								{
									num4 = 26;
									continue;
								}
								goto case 11;
							case 10:
								num9 = CS_0024_003C_003E8__locals1.copyAction4Property;
								goto IL_03a2;
							case 29:
								return null;
							case 2:
								if (CS_0024_003C_003E8__locals1.rulesPropertyCopyAction != 0)
								{
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
									{
										num4 = 1;
									}
									continue;
								}
								goto case 3;
							case 20:
								if (!CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1._003C_003E4__this.restrictions.IsTypeByRef(value))
								{
									num3 = 17;
									break;
								}
								num7 = 1;
								goto IL_0394;
							case 7:
								if (IsSimpleOrNullable(value.GetType()))
								{
									num4 = 30;
									continue;
								}
								goto case 9;
							case 21:
								if (copyAction9 == CopyAction.Ignore)
								{
									num3 = 29;
									break;
								}
								if (value == null)
								{
									num4 = 11;
									continue;
								}
								goto case 7;
							case 13:
								if (copyAction10 == CopyAction.Default)
								{
									num4 = 10;
									continue;
								}
								num9 = copyAction10;
								goto IL_03a2;
							case 26:
								if (copyAction9 != CopyAction.SaveRef)
								{
									num4 = 8;
									continue;
								}
								goto case 11;
							case 17:
								if (CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1._003C_003E4__this.restrictions.IsTypeSaveRef(value))
								{
									num4 = 25;
									continue;
								}
								goto case 18;
							case 5:
								num8 = CS_0024_003C_003E8__locals1.copyAction4PropertyRelation;
								goto IL_03ce;
							case 16:
								if (CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1._003C_003E4__this.restrictions.CloneRecursive)
								{
									num4 = 19;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
									{
										num4 = 5;
									}
									continue;
								}
								goto case 6;
							default:
								if (copyAction7 != 0)
								{
									num4 = 12;
									continue;
								}
								goto case 16;
							case 15:
								num7 = 2;
								goto IL_0394;
							case 27:
								if (CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1._003C_003E4__this.restrictions.IsTypeClone(value))
								{
									num4 = 15;
									continue;
								}
								goto case 20;
							case 18:
								num7 = 0;
								goto IL_0394;
							case 28:
								num7 = 3;
								goto IL_0394;
							case 4:
								num5 = GetCopyAction4Entity(value);
								goto IL_03c0;
							case 19:
								num6 = 2;
								goto IL_03ec;
							case 6:
								num6 = 1;
								goto IL_03ec;
							case 3:
								if (value == null)
								{
									num4 = 28;
									continue;
								}
								goto case 14;
							case 1:
								num7 = (int)CS_0024_003C_003E8__locals1.rulesPropertyCopyAction;
								goto IL_0394;
							case 22:
								num5 = copyAction8;
								goto IL_03c0;
							case 12:
								num6 = (int)copyAction7;
								goto IL_03ec;
							case 8:
								return CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1._003C_003E4__this.Create(value, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1._003C_003E4__this).Clone(value.GetType().IsInheritOrSame(elementType) ? null : InterfaceActivator.Create(elementType));
							case 11:
							case 30:
								{
									return value;
								}
								IL_03c0:
								copyAction6 = num5;
								num4 = 24;
								continue;
								IL_03ce:
								copyAction7 = num8;
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
								{
									num4 = 0;
								}
								continue;
								IL_03ec:
								copyAction9 = (CopyAction)num6;
								num4 = 21;
								continue;
								IL_03a2:
								copyAction8 = num9;
								num4 = 23;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
								{
									num4 = 13;
								}
								continue;
								IL_0394:
								copyAction10 = (CopyAction)num7;
								num4 = 13;
								continue;
							}
							break;
						}
					}
				}, obj2, delegate
				{
					int num = 3;
					int num2 = num;
					bool flag = default(bool);
					while (true)
					{
						switch (num2)
						{
						case 1:
							Logger.WarnFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36080797), CS_0024_003C_003E8__locals1.info.DeclaringType, CS_0024_003C_003E8__locals1.info.Name);
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
							{
								num2 = 0;
							}
							break;
						default:
							return flag;
						case 3:
							flag = IsNoneCascadeMode(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.metadata, CS_0024_003C_003E8__locals1.info);
							num2 = 2;
							break;
						case 2:
							if (flag)
							{
								num2 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
								{
									num2 = 1;
								}
								break;
							}
							goto default;
						}
					}
				}, restrictions.GetCollectionUpdateMode(propertyInfo), restrictions.GetComparer(propertyInfo));
				if (obj2 != null)
				{
					reflectionProperty.SetValue(resultObject, obj2, null);
				}
			}
			return resultObject;
		}
		return cloneObject;
	}

	private static bool IsNoneCascadeMode(ClassMetadata metadata, PropertyInfo propertyInfo)
	{
		int num = 3;
		int num2 = num;
		EntitySettings entitySettings = default(EntitySettings);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		_003C_003Ec__DisplayClass21_0 _003C_003Ec__DisplayClass21_ = default(_003C_003Ec__DisplayClass21_0);
		while (true)
		{
			switch (num2)
			{
			case 6:
				return entitySettings.CascadeMode == CascadeMode.None;
			case 1:
				if (entitySettings == null)
				{
					return false;
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
				{
					num2 = 6;
				}
				continue;
			case 7:
				return false;
			case 5:
				if (propertyMetadata == null)
				{
					num2 = 4;
					continue;
				}
				entitySettings = propertyMetadata.Settings as EntitySettings;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 1;
				}
				continue;
			case 4:
				return false;
			case 3:
				_003C_003Ec__DisplayClass21_ = new _003C_003Ec__DisplayClass21_0();
				num2 = 2;
				continue;
			case 2:
				_003C_003Ec__DisplayClass21_.propertyInfo = propertyInfo;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (metadata == null)
			{
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num2 = 7;
				}
			}
			else
			{
				propertyMetadata = metadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass21_._003CIsNoneCascadeMode_003Eb__0);
				num2 = 5;
			}
		}
	}

	private static CopyAction GetCopyAction4Property(ClassMetadata metadata, PropertyInfo propertyInfo)
	{
		//Discarded unreachable code: IL_00b1, IL_00c0, IL_00f2, IL_00fc, IL_0138
		int num = 7;
		_003C_003Ec__DisplayClass22_0 _003C_003Ec__DisplayClass22_ = default(_003C_003Ec__DisplayClass22_0);
		EntitySettings entitySettings = default(EntitySettings);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj2;
				object obj;
				switch (num2)
				{
				case 4:
					if (metadata != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
						{
							num2 = 2;
						}
						continue;
					}
					obj2 = null;
					goto IL_013e;
				case 7:
					_003C_003Ec__DisplayClass22_ = new _003C_003Ec__DisplayClass22_0();
					num2 = 6;
					continue;
				case 6:
					_003C_003Ec__DisplayClass22_.propertyInfo = propertyInfo;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 3;
					}
					continue;
				case 5:
					if (entitySettings == null)
					{
						goto end_IL_0012;
					}
					goto case 8;
				case 8:
					return entitySettings.CopyAction;
				case 3:
					return CopyAction.Default;
				case 2:
					obj2 = metadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass22_._003CGetCopyAction4Property_003Eb__0);
					goto IL_013e;
				case 9:
					if (propertyMetadata == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 1;
				case 1:
					obj = propertyMetadata.Settings as EntitySettings;
					break;
				default:
					{
						obj = null;
						break;
					}
					IL_013e:
					propertyMetadata = (PropertyMetadata)obj2;
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 9;
					}
					continue;
				}
				entitySettings = (EntitySettings)obj;
				num2 = 5;
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	private static CopyAction GetCopyAction4Entity(object value)
	{
		//Discarded unreachable code: IL_00c0, IL_0105, IL_014b, IL_01d0, IL_01df, IL_0273, IL_02b9, IL_02c8, IL_02ef, IL_02fe, IL_0308, IL_0317, IL_03ac
		int num = 3;
		int num2 = num;
		CopyAction copyAction = default(CopyAction);
		EntityMetadata entityMetadata = default(EntityMetadata);
		TypeDescriptor typeDescriptor = default(TypeDescriptor);
		Type type = default(Type);
		EntityMetadata entityMetadata2 = default(EntityMetadata);
		Guid guid2 = default(Guid);
		while (true)
		{
			object obj2;
			object obj;
			Guid guid;
			switch (num2)
			{
			case 6:
				copyAction = entityMetadata.CopyAction;
				num2 = 25;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num2 = 28;
				}
				continue;
			default:
				if (typeDescriptor != null)
				{
					num2 = 5;
					continue;
				}
				goto case 13;
			case 17:
			case 30:
				if (typeDescriptor != null)
				{
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
					{
						num2 = 24;
					}
					continue;
				}
				goto case 29;
			case 29:
				if (!(type != null))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 1;
			case 4:
				if (value == null)
				{
					num2 = 21;
					continue;
				}
				goto case 25;
			case 1:
				typeDescriptor = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeDescriptor(type) as TypeDescriptor;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num2 = 19;
				}
				continue;
			case 19:
				type = type.BaseType;
				num2 = 17;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 10;
				}
				continue;
			case 24:
				if (typeDescriptor.CopyAction != 0)
				{
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
					{
						num2 = 12;
					}
					continue;
				}
				goto case 29;
			case 9:
				typeDescriptor = null;
				num2 = 30;
				continue;
			case 2:
				if (value != null)
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 12;
					}
					continue;
				}
				obj2 = null;
				goto IL_03b2;
			case 28:
				if (entityMetadata != null)
				{
					num2 = 15;
					continue;
				}
				goto case 10;
			case 18:
				copyAction = entityMetadata2.CopyAction;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 23;
				}
				continue;
			case 23:
				guid2 = entityMetadata2.BaseClassUid;
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 3;
				}
				continue;
			case 14:
			case 20:
				entityMetadata = MetadataLoader.LoadMetadata(guid2) as EntityMetadata;
				num2 = 27;
				continue;
			case 3:
				copyAction = CopyAction.Default;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
				{
					num2 = 2;
				}
				continue;
			case 11:
				if (entityMetadata2 != null)
				{
					num2 = 18;
					continue;
				}
				goto case 4;
			case 25:
				obj = value.GetType();
				break;
			case 10:
				guid = Guid.Empty;
				goto IL_03c5;
			case 26:
				if (!(guid2 != Guid.Empty))
				{
					goto case 13;
				}
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
				{
					num2 = 20;
				}
				continue;
			case 27:
				if (entityMetadata != null)
				{
					num2 = 6;
					continue;
				}
				goto case 28;
			case 5:
				copyAction = typeDescriptor.CopyAction;
				num2 = 22;
				continue;
			case 13:
			case 22:
				return copyAction;
			case 7:
			case 8:
				if (copyAction == CopyAction.Default)
				{
					num2 = 26;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 14;
					}
					continue;
				}
				goto case 13;
			case 12:
				obj2 = MetadataLoader.LoadMetadata(value.GetType()) as EntityMetadata;
				goto IL_03b2;
			case 15:
				guid = entityMetadata.BaseClassUid;
				goto IL_03c5;
			case 21:
				{
					obj = null;
					break;
				}
				IL_03b2:
				entityMetadata2 = (EntityMetadata)obj2;
				num2 = 11;
				continue;
				IL_03c5:
				guid2 = guid;
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 8;
				}
				continue;
			}
			type = (Type)obj;
			num2 = 9;
		}
	}

	private static CopyAction GetCopyAction4PropertyRelation(ClassMetadata metadata, PropertyInfo propertyInfo)
	{
		//Discarded unreachable code: IL_0083, IL_00be, IL_00cd, IL_011b
		int num = 7;
		int num2 = num;
		_003C_003Ec__DisplayClass24_0 _003C_003Ec__DisplayClass24_ = default(_003C_003Ec__DisplayClass24_0);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		EntitySettings entitySettings = default(EntitySettings);
		while (true)
		{
			object obj2;
			object obj;
			switch (num2)
			{
			case 6:
				_003C_003Ec__DisplayClass24_.propertyInfo = propertyInfo;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
				{
					num2 = 0;
				}
				continue;
			case 8:
				obj2 = metadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass24_._003CGetCopyAction4PropertyRelation_003Eb__0);
				goto IL_013c;
			case 3:
				if (metadata != null)
				{
					num2 = 8;
					continue;
				}
				obj2 = null;
				goto IL_013c;
			case 7:
				_003C_003Ec__DisplayClass24_ = new _003C_003Ec__DisplayClass24_0();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 6;
				}
				continue;
			default:
				if (propertyMetadata != null)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				obj = null;
				break;
			case 4:
				if (entitySettings == null)
				{
					num2 = 9;
					continue;
				}
				goto case 1;
			case 5:
				obj = propertyMetadata.Settings as EntitySettings;
				break;
			case 2:
			case 9:
				return CopyAction.Default;
			case 1:
				{
					if (entitySettings.RelationType == RelationType.OneToMany)
					{
						return CopyAction.Clone;
					}
					num2 = 2;
					continue;
				}
				IL_013c:
				propertyMetadata = (PropertyMetadata)obj2;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			entitySettings = (EntitySettings)obj;
			num2 = 4;
		}
	}

	internal static bool qFniq9hc0h1VpiUvAVwp()
	{
		return yFpD6uhcxI8kOGtSMOoS == null;
	}

	internal static object tFIQBUhcmtkhJN0KH1Od()
	{
		return yFpD6uhcxI8kOGtSMOoS;
	}
}
