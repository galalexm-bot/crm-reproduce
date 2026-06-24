// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.CloneHelperBuilder`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
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
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EleWise.ELMA.Helpers
{
  public class CloneHelperBuilder<T> where T : class
  {
    private T cloneObject;
    private T resultObject;
    private RestrictionList restrictions;
    private Dictionary<object, object> clonedObjects;
    internal static object yFpD6uhcxI8kOGtSMOoS;

    internal RestrictionList RestrictionList
    {
      get => this.restrictions;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.restrictions = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Клонированный объект</summary>
    public T CloneObject
    {
      get => this.cloneObject;
      set => this.cloneObject = value;
    }

    /// <summary>Скопированные во время клонирования объекты</summary>
    public Dictionary<object, object> ClonedObjects
    {
      get => this.clonedObjects;
      set => this.clonedObjects = value;
    }

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

    /// <summary>
    /// 
    /// </summary>
    /// <param name="cloneObject">Клонируемый объект</param>
    public CloneHelperBuilder(T cloneObject)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.restrictions = new RestrictionList();
      this.clonedObjects = new Dictionary<object, object>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.cloneObject = cloneObject;
      if (!cloneObject.IsProxy())
        return;
      this.cloneObject = (T) ((INHibernateProxy) (object) cloneObject).HibernateLazyInitializer.GetImplementation();
    }

    /// <summary>Задать правила для клонирования</summary>
    /// <param name="restrictionBuilder"></param>
    /// <returns></returns>
    public CloneHelperBuilder<T> Restrictions(Action<RestrictionsBuilder<T>> restrictionBuilder)
    {
      RestrictionsBuilder<T> restrictionsBuilder = new RestrictionsBuilder<T>(this.restrictions);
      restrictionBuilder(restrictionsBuilder);
      return this;
    }

    /// <summary>Установить предварительно склонированный объект</summary>
    /// <returns></returns>
    public CloneHelperBuilder<T> SetClonedObject<T2>(T2 obj, T2 clonedObj)
    {
      this.clonedObjects.Add((object) obj, (object) clonedObj);
      return this;
    }

    private static bool IsSimpleType(Type type)
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            MethodInfo[] methods = type.GetMethods();
            // ISSUE: reference to a compiler-generated field
            Func<MethodInfo, bool> func = CloneHelperBuilder<T>.\u003C\u003Ec.\u003C\u003E9__17_0;
            Func<MethodInfo, bool> predicate;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              CloneHelperBuilder<T>.\u003C\u003Ec.\u003C\u003E9__17_0 = predicate = (Func<MethodInfo, bool>) (m =>
              {
                int num2 = 4;
                while (true)
                {
                  switch (num2)
                  {
                    case 1:
                      if (m.Name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536555254))
                      {
                        num2 = 5;
                        continue;
                      }
                      goto label_7;
                    case 2:
                      if (m.GetParameters()[0].ParameterType == typeof (string))
                      {
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_7;
                    case 3:
                      goto label_7;
                    case 4:
                      if (!m.IsStatic)
                      {
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 3 : 1;
                        continue;
                      }
                      goto case 1;
                    case 5:
                      if (m.GetParameters().Length == 2)
                      {
                        num2 = 2;
                        continue;
                      }
                      goto label_7;
                    default:
                      goto label_6;
                  }
                }
label_6:
                return m.GetParameters()[1].IsOut;
label_7:
                return false;
              });
            }
            else
              goto label_2;
label_7:
            if (((IEnumerable<MethodInfo>) methods).FirstOrDefault<MethodInfo>(predicate) != (MethodInfo) null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
label_2:
            predicate = func;
            goto label_7;
          case 2:
            goto label_3;
          default:
            goto label_4;
        }
      }
label_3:
      return type == typeof (string);
label_4:
      return true;
    }

    private static bool IsSimpleOrNullable(Type type)
    {
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_7;
          case 2:
            if (!CloneHelperBuilder<T>.IsSimpleType(type))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
              continue;
            }
            goto label_8;
          case 3:
            goto label_6;
          case 5:
            if (type.IsGenericType)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 4 : 0;
              continue;
            }
            goto case 2;
          default:
            if (!type.IsGenericType)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 1;
              continue;
            }
            goto label_6;
        }
      }
label_6:
      return type.GetGenericTypeDefinition() == typeof (Nullable<>);
label_7:
      return false;
label_8:
      return true;
    }

    /// <summary>Создаем копию коллекции</summary>
    /// <param name="value">данные исходной коллекции</param>
    /// <param name="valueType">тип коллекции</param>
    /// <param name="selectFunc">функция клонирования</param>
    /// <param name="resCollection">коллекция, в которую нужно записать данные</param>
    /// <param name="isNoneCascadeModeFunc">функция, которая проверяет есть каскадное сохранение или нет</param>
    /// <param name="collectionUpdateMode">
    /// <para>параметр, указывающий как элементы дописываются в коллекцию:</para>
    /// <para>CollectionUpdateMode.AppendMissing - записи исходной коллекции, которых нет в результирующей, добавляются в нее</para>
    /// <para>CollectionUpdateMode.AppendAll - все записи исходной коллекции добавляются в результирующую</para>
    /// <para>CollectionUpdateMode.Match - исходная коллекция записывается в результирующую, записи, которых нет в исходной коллекции удаляются</para>
    /// </param>
    /// <param name="comparer">компаратор, определяющий, совпадают элементы коллекции или нет</param>
    /// <returns>склонированная коллекция</returns>
    private static object CloneCollection(
      IEnumerable value,
      Type valueType,
      Func<Type, object, object> selectFunc,
      object resCollection,
      Func<bool> isNoneCascadeModeFunc = null,
      CollectionUpdateMode collectionUpdateMode = CollectionUpdateMode.AppendMissing,
      IEqualityComparer<object> comparer = null)
    {
      if (value == null)
        return (object) null;
      bool flag1 = resCollection is Array || valueType.IsArray;
      Type elementType = flag1 ? (resCollection != null ? resCollection.GetType() : valueType).GetElementType() : (Type) null;
      if (!flag1)
      {
        if (resCollection == null)
        {
          try
          {
            if (!valueType.IsInterface)
            {
              resCollection = Activator.CreateInstance(valueType);
            }
            else
            {
              flag1 = value is Array;
              if (flag1)
                elementType = value.GetType().GetElementType();
              else
                resCollection = Activator.CreateInstance(value.GetType());
            }
          }
          catch (Exception ex)
          {
            CloneHelperBuilder<T>.Logger.Error((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882352092), ex);
          }
          if (!flag1 && resCollection == null)
            return (object) null;
        }
      }
      MethodInfo methodInfo1 = !flag1 ? ((IEnumerable<MethodInfo>) resCollection.GetType().GetMethods()).FirstOrDefault<MethodInfo>((Func<MethodInfo, bool>) (m =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!(m.Name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-122002947 ^ 121977406)))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_2;
            default:
              goto label_3;
          }
        }
label_2:
        return !m.IsGenericMethod;
label_3:
        return false;
      })) : (MethodInfo) null;
      MethodInfo methodInfo2 = flag1 || collectionUpdateMode != CollectionUpdateMode.Match ? (MethodInfo) null : ((IEnumerable<MethodInfo>) resCollection.GetType().GetMethods()).FirstOrDefault<MethodInfo>((Func<MethodInfo, bool>) (m =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (m.Name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1380439818 << 3 ^ 1841423144))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_2;
          }
        }
label_2:
        return !m.IsGenericMethod;
label_3:
        return false;
      }));
      if (!flag1)
      {
        if (methodInfo1 != (MethodInfo) null)
        {
          ParameterInfo[] parameters = methodInfo1.GetParameters();
          if (parameters.Length == 1)
            elementType = parameters[0].ParameterType;
        }
        else
        {
          if (!(methodInfo2 != (MethodInfo) null))
            return resCollection;
          ParameterInfo[] parameters = methodInfo2.GetParameters();
          if (parameters.Length == 1)
            elementType = parameters[0].ParameterType;
        }
      }
      object[] val = value.Cast<object>().ToArray<object>();
      IEnumerable source1 = resCollection as IEnumerable;
      object[] res = source1 == null ? new object[0] : source1.Cast<object>().ToArray<object>();
      object[] array = ((IEnumerable<object>) val).Select<object, object>((Func<object, object>) (o => selectFunc(elementType, o))).Where<object>((Func<object, bool>) (v =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (resCollection != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            case 2:
              goto label_2;
            default:
              if (collectionUpdateMode != CollectionUpdateMode.AppendAll)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 2 : 0;
                continue;
              }
              goto label_3;
          }
        }
label_2:
        return !((IEnumerable<object>) res).Contains<object>(v, comparer);
label_3:
        return true;
      })).ToArray<object>();
      object[] source2 = collectionUpdateMode == CollectionUpdateMode.Match ? ((IEnumerable<object>) res).Select<object, object>((Func<object, object>) (o => selectFunc(elementType, o))).Where<object>((Func<object, bool>) (x => !((IEnumerable<object>) val).Contains<object>(x, comparer))).ToArray<object>() : new object[0];
      bool flag2 = isNoneCascadeModeFunc != null && isNoneCascadeModeFunc() && (((IEnumerable<object>) array).Any<object>() || ((IEnumerable<object>) source2).Any<object>());
      if (flag1)
      {
        int num1 = ((IEnumerable<object>) res).Count<object>() - source2.Length;
        Array instance = Array.CreateInstance(elementType, num1 + array.Length);
        int num2 = 0;
        for (int index = 0; index < val.Length; ++index)
        {
          object obj = val[index];
          if (((IEnumerable<object>) source2).Contains<object>(obj, comparer))
            instance.SetValue(obj, num2++);
        }
        for (int index = 0; index < array.Length; ++index)
        {
          object obj = array[index];
          if (flag2 && obj is IEntity)
            ((IEntity) obj).Save();
          instance.SetValue(obj, index + num1);
        }
        resCollection = (object) instance;
      }
      else
      {
        if (methodInfo2 != (MethodInfo) null)
        {
          foreach (object obj in res)
          {
            if (((IEnumerable<object>) source2).Contains<object>(obj, comparer))
              methodInfo2.Invoke(resCollection, new object[1]
              {
                obj
              });
          }
        }
        if (methodInfo1 != (MethodInfo) null)
        {
          foreach (object obj in array)
          {
            if (flag2 && obj is IEntity)
              ((IEntity) obj).Save();
            methodInfo1.Invoke(resCollection, new object[1]
            {
              obj
            });
          }
        }
      }
      return resCollection;
    }

    /// <summary>Клонировать объект</summary>
    /// <param name="resObj">Оъект, в который записать данные</param>
    /// <returns>Копия объекта</returns>
    public T Clone(T resObj = null)
    {
      if ((object) this.cloneObject == null)
        return default (T);
      Type type1 = this.cloneObject.GetType();
      if (this.cloneObject.IsProxy())
        type1 = NHibernateUtil.GetClass((object) this.cloneObject);
      if (this.cloneObject is IEnumerable cloneObject)
        return (T) CloneHelperBuilder<T>.CloneCollection(cloneObject, typeof (T), (Func<Type, object, object>) ((elementType, value) =>
        {
          int num = 2;
          while (true)
          {
            switch (num)
            {
              case 1:
                if (CloneHelperBuilder<T>.IsSimpleOrNullable(value.GetType()))
                {
                  num = 3;
                  continue;
                }
                goto label_6;
              case 2:
                if (value != null)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 1;
                  continue;
                }
                goto label_7;
              case 3:
                goto label_7;
              default:
                goto label_6;
            }
          }
label_6:
          return this.Create<object>(value, this).Clone(value.GetType().IsInheritOrSame(elementType) ? (object) null : InterfaceActivator.Create(elementType));
label_7:
          return value;
        }), (object) resObj);
      if (typeof (EnumBase).IsAssignableFrom(type1) || type1.IsEnum)
        return this.cloneObject;
      if (this.clonedObjects.ContainsKey((object) this.cloneObject))
        return (T) this.clonedObjects[(object) this.cloneObject];
      if ((object) this.cloneObject is ICloneable)
        CloneHelperBuilder<T>.Logger.Debug((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218728660)));
      PropertyInfo[] reflectionProperties = type1.GetReflectionProperties();
      if (!((IEnumerable<ConstructorInfo>) type1.GetConstructors()).Any<ConstructorInfo>((Func<ConstructorInfo, bool>) (c => c.GetParameters().Length == 0)))
        return this.cloneObject;
      try
      {
        this.resultObject = resObj ?? (T) InterfaceActivator.Create(type1);
      }
      catch (Exception ex)
      {
        CloneHelperBuilder<T>.Logger.Error((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638644619), (object) type1), ex);
        throw;
      }
      this.clonedObjects.Add((object) this.cloneObject, (object) this.resultObject);
      if ((object) this.cloneObject is ReferenceOnEntity)
      {
        ((object) this.resultObject as ReferenceOnEntity).ObjectTypeUId = ((object) this.cloneObject as ReferenceOnEntity).ObjectTypeUId;
        ((object) this.resultObject as ReferenceOnEntity).ObjectId = ((object) this.cloneObject as ReferenceOnEntity).ObjectId;
        return this.resultObject;
      }
      if ((object) this.cloneObject is ReferenceOnEntityType)
      {
        ((object) this.resultObject as ReferenceOnEntityType).TypeUid = ((object) this.cloneObject as ReferenceOnEntityType).TypeUid;
        return this.resultObject;
      }
      ClassMetadata metadata = (ClassMetadata) MetadataLoader.LoadMetadata(type1);
      foreach (PropertyInfo propertyInfo in reflectionProperties)
      {
        if (propertyInfo.GetCustomAttributes(typeof (ObsoleteAttribute), false).Length == 0 && propertyInfo.CanWrite && !(propertyInfo.GetSetMethod() == (MethodInfo) null))
        {
          object obj1 = propertyInfo.GetValue((object) this.cloneObject, (object[]) null);
          CopyAction rulesPropertyCopyAction = this.restrictions.IsPropertyIgnore(propertyInfo, type1) ? CopyAction.Ignore : (this.restrictions.IsPropertyClone(propertyInfo, type1) ? CopyAction.Clone : (this.restrictions.IsPropertyByRef(propertyInfo, type1) ? CopyAction.ByRef : (this.restrictions.IsPropertySaveRef(propertyInfo, type1) ? CopyAction.SaveRef : (this.restrictions.IsPropertyAction(propertyInfo, type1) ? this.restrictions.PropertyAction(propertyInfo.Name, type1, (object) this.cloneObject, obj1) : (this.restrictions.IsAllPropertiesIgnore(type1) ? CopyAction.Ignore : (this.restrictions.IsAllPropertiesClone(type1) ? CopyAction.Clone : (this.restrictions.IsAllPropertiesByRef(type1) ? CopyAction.ByRef : (this.restrictions.IsAllPropertiesSaveRef(type1) ? CopyAction.SaveRef : (this.restrictions.IsAllPropertiesAction(type1) ? CopyAction.Default : CopyAction.Default)))))))));
          if (rulesPropertyCopyAction != CopyAction.Ignore)
          {
            CopyAction copyAction1 = rulesPropertyCopyAction != CopyAction.Default ? rulesPropertyCopyAction : (obj1 == null ? CopyAction.ByRef : (this.restrictions.IsTypeIgnore(obj1) ? CopyAction.Ignore : (this.restrictions.IsTypeClone(obj1) ? CopyAction.Clone : (this.restrictions.IsTypeByRef(obj1) ? CopyAction.ByRef : (this.restrictions.IsTypeSaveRef(obj1) ? CopyAction.SaveRef : (this.restrictions.IsTypeAction(obj1) ? this.restrictions.Action((object) this.cloneObject, obj1) : CopyAction.Default))))));
            CopyAction copyAction4Property = CloneHelperBuilder<T>.GetCopyAction4Property(metadata, propertyInfo);
            CopyAction copyAction4PropertyRelation = CloneHelperBuilder<T>.GetCopyAction4PropertyRelation(metadata, propertyInfo);
            CopyAction copyAction2 = copyAction1 != CopyAction.Default ? copyAction1 : copyAction4Property;
            if (copyAction2 == CopyAction.Default)
            {
              CopyActionAttribute attribute = AttributeHelper<CopyActionAttribute>.GetAttribute((MemberInfo) propertyInfo, true);
              if (attribute != null)
                copyAction2 = attribute.CopyAction;
            }
            CopyAction copyAction3 = copyAction2 != CopyAction.Default ? copyAction2 : CloneHelperBuilder<T>.GetCopyAction4Entity(obj1);
            CopyAction copyAction4 = copyAction3 != CopyAction.Default ? copyAction3 : copyAction4PropertyRelation;
            CopyAction copyAction5 = copyAction4 != CopyAction.Default ? copyAction4 : (this.restrictions.CloneRecursive ? CopyAction.Clone : CopyAction.ByRef);
            if (copyAction5 != CopyAction.Ignore)
            {
              Type type2 = propertyInfo.PropertyType == typeof (IEnumerable) ? propertyInfo.PropertyType : propertyInfo.PropertyType.GetInterface(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710557756), true);
              PropertyInfo reflectionProperty = this.resultObject.GetType().GetReflectionProperty(propertyInfo.Name);
              if (!(reflectionProperty == (PropertyInfo) null))
              {
                if (obj1 != null && !CloneHelperBuilder<T>.IsSimpleOrNullable(propertyInfo.PropertyType) && (!propertyInfo.PropertyType.IsArray || !(obj1.GetType() == typeof (byte[]))))
                {
                  if (type2 == (Type) null)
                  {
                    switch (copyAction5)
                    {
                      case CopyAction.ByRef:
                        if (this.clonedObjects.ContainsKey(obj1))
                          break;
                        goto label_32;
                      case CopyAction.SaveRef:
                        goto label_32;
                    }
                  }
                  if (this.clonedObjects.ContainsKey(obj1) || type2 == (Type) null)
                  {
                    object source = this.clonedObjects.ContainsKey(obj1) ? this.clonedObjects[obj1] : this.Create<object>(obj1, this).Clone();
                    if ((source is IEntity || source is IEnumerable) && CloneHelperBuilder<T>.IsNoneCascadeMode(metadata, propertyInfo))
                    {
                      CloneHelperBuilder<T>.Logger.WarnFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 88022547), (object) propertyInfo.DeclaringType, (object) propertyInfo.Name);
                      if (source is IEntity entity1)
                      {
                        entity1.Save();
                      }
                      else
                      {
                        foreach (IEntity entity in ((IEnumerable) source).OfType<IEntity>())
                          entity.Save();
                      }
                    }
                    if (reflectionProperty.CanWrite)
                    {
                      reflectionProperty.SetValue((object) this.resultObject, source, (object[]) null);
                      continue;
                    }
                    continue;
                  }
                  object resCollection = reflectionProperty.CanRead ? reflectionProperty.GetValue((object) this.resultObject, (object[]) null) : (object) null;
                  if (resCollection != null && !resCollection.GetType().IsArray || reflectionProperty.CanWrite)
                  {
                    PropertyInfo info = propertyInfo;
                    object obj2 = CloneHelperBuilder<T>.CloneCollection((IEnumerable) obj1, reflectionProperty.PropertyType, (Func<Type, object, object>) ((elementType, value) =>
                    {
                      int num1 = 2;
                      while (true)
                      {
                        int num2 = num1;
                        while (true)
                        {
                          CopyAction copyAction6;
                          CopyAction copyAction7;
                          CopyAction copyAction8;
                          CopyAction copyAction9;
                          CopyAction copyAction10;
                          int num3;
                          int num4;
                          int num5;
                          int num6;
                          int num7;
                          switch (num2)
                          {
                            case 1:
                              num4 = (int) rulesPropertyCopyAction;
                              break;
                            case 2:
                              if (rulesPropertyCopyAction != CopyAction.Default)
                              {
                                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 1 : 1;
                                continue;
                              }
                              goto case 3;
                            case 3:
                              if (value == null)
                              {
                                num2 = 28;
                                continue;
                              }
                              goto case 14;
                            case 4:
                              num5 = (int) CloneHelperBuilder<T>.GetCopyAction4Entity(value);
                              goto label_52;
                            case 5:
                              num6 = (int) copyAction4PropertyRelation;
                              goto label_54;
                            case 6:
                              num3 = 1;
                              goto label_56;
                            case 7:
                              if (CloneHelperBuilder<T>.IsSimpleOrNullable(value.GetType()))
                              {
                                num2 = 30;
                                continue;
                              }
                              goto case 9;
                            case 8:
                              goto label_57;
                            case 9:
                              if (copyAction8 != CopyAction.ByRef)
                              {
                                num2 = 26;
                                continue;
                              }
                              goto label_58;
                            case 10:
                              num7 = (int) copyAction4Property;
                              goto label_50;
                            case 11:
                            case 30:
                              goto label_58;
                            case 12:
                              num3 = (int) copyAction10;
                              goto label_56;
                            case 13:
                              if (copyAction9 == CopyAction.Default)
                              {
                                num2 = 10;
                                continue;
                              }
                              num7 = (int) copyAction9;
                              goto label_50;
                            case 14:
                              if (!this.restrictions.IsTypeIgnore(value))
                              {
                                num2 = 27;
                                continue;
                              }
                              num4 = 3;
                              break;
                            case 15:
                              num4 = 2;
                              break;
                            case 16:
                              if (this.restrictions.CloneRecursive)
                              {
                                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 19 : 5;
                                continue;
                              }
                              goto case 6;
                            case 17:
                              if (this.restrictions.IsTypeSaveRef(value))
                              {
                                num2 = 25;
                                continue;
                              }
                              goto case 18;
                            case 18:
                              num4 = 0;
                              break;
                            case 19:
                              num3 = 2;
                              goto label_56;
                            case 20:
                              if (this.restrictions.IsTypeByRef(value))
                              {
                                num4 = 1;
                                break;
                              }
                              goto label_19;
                            case 21:
                              if (copyAction8 != CopyAction.Ignore)
                              {
                                if (value == null)
                                {
                                  num2 = 11;
                                  continue;
                                }
                                goto case 7;
                              }
                              else
                                goto label_23;
                            case 22:
                              num5 = (int) copyAction6;
                              goto label_52;
                            case 23:
                              if (copyAction6 != CopyAction.Default)
                              {
                                num2 = 22;
                                continue;
                              }
                              goto case 4;
                            case 24:
                              if (copyAction7 == CopyAction.Default)
                              {
                                num2 = 5;
                                continue;
                              }
                              num6 = (int) copyAction7;
                              goto label_54;
                            case 25:
                              num4 = 4;
                              break;
                            case 26:
                              if (copyAction8 != CopyAction.SaveRef)
                              {
                                num2 = 8;
                                continue;
                              }
                              goto label_58;
                            case 27:
                              if (this.restrictions.IsTypeClone(value))
                              {
                                num2 = 15;
                                continue;
                              }
                              goto case 20;
                            case 28:
                              num4 = 3;
                              break;
                            case 29:
                              goto label_13;
                            default:
                              if (copyAction10 != CopyAction.Default)
                              {
                                num2 = 12;
                                continue;
                              }
                              goto case 16;
                          }
                          copyAction9 = (CopyAction) num4;
                          num2 = 13;
                          continue;
label_50:
                          copyAction6 = (CopyAction) num7;
                          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 23 : 13;
                          continue;
label_52:
                          copyAction7 = (CopyAction) num5;
                          num2 = 24;
                          continue;
label_54:
                          copyAction10 = (CopyAction) num6;
                          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
                          continue;
label_56:
                          copyAction8 = (CopyAction) num3;
                          num2 = 21;
                        }
label_19:
                        num1 = 17;
                        continue;
label_23:
                        num1 = 29;
                      }
label_13:
                      return (object) null;
label_57:
                      return this.Create<object>(value, this).Clone(!value.GetType().IsInheritOrSame(elementType) ? InterfaceActivator.Create(elementType) : (object) null);
label_58:
                      return value;
                    }), resCollection, (Func<bool>) (() =>
                    {
                      int num = 3;
                      bool flag;
                      while (true)
                      {
                        switch (num)
                        {
                          case 1:
                            CloneHelperBuilder<T>.Logger.WarnFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36080797), (object) info.DeclaringType, (object) info.Name);
                            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
                            continue;
                          case 2:
                            if (flag)
                            {
                              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 1;
                              continue;
                            }
                            goto label_3;
                          case 3:
                            flag = CloneHelperBuilder<T>.IsNoneCascadeMode(metadata, info);
                            num = 2;
                            continue;
                          default:
                            goto label_3;
                        }
                      }
label_3:
                      return flag;
                    }), this.restrictions.GetCollectionUpdateMode(propertyInfo), (IEqualityComparer<object>) this.restrictions.GetComparer(propertyInfo));
                    if (obj2 != null)
                    {
                      reflectionProperty.SetValue((object) this.resultObject, obj2, (object[]) null);
                      continue;
                    }
                    continue;
                  }
                  continue;
                }
label_32:
                if (reflectionProperty.CanWrite)
                  reflectionProperty.SetValue((object) this.resultObject, obj1, (object[]) null);
              }
            }
          }
        }
      }
      return this.resultObject;
    }

    private static bool IsNoneCascadeMode(ClassMetadata metadata, PropertyInfo propertyInfo)
    {
      int num = 3;
      EntitySettings settings;
      PropertyMetadata propertyMetadata;
      PropertyInfo propertyInfo1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (settings != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 2 : 6;
              continue;
            }
            goto label_5;
          case 2:
            propertyInfo1 = propertyInfo;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
            continue;
          case 3:
            num = 2;
            continue;
          case 4:
            goto label_12;
          case 5:
            if (propertyMetadata == null)
            {
              num = 4;
              continue;
            }
            settings = propertyMetadata.Settings as EntitySettings;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 1;
            continue;
          case 6:
            goto label_4;
          case 7:
            goto label_8;
          default:
            if (metadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 1 : 7;
              continue;
            }
            propertyMetadata = metadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => p.Name == propertyInfo1.Name));
            num = 5;
            continue;
        }
      }
label_4:
      return settings.CascadeMode == CascadeMode.None;
label_5:
      return false;
label_8:
      return false;
label_12:
      return false;
    }

    private static CopyAction GetCopyAction4Property(
      ClassMetadata metadata,
      PropertyInfo propertyInfo)
    {
      int num1 = 7;
      EntitySettings entitySettings1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          PropertyMetadata propertyMetadata1;
          EntitySettings entitySettings2;
          PropertyMetadata propertyMetadata2;
          PropertyInfo propertyInfo1;
          switch (num2)
          {
            case 1:
              entitySettings2 = propertyMetadata1.Settings as EntitySettings;
              goto label_18;
            case 2:
              propertyMetadata2 = metadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => p.Name == propertyInfo1.Name));
              break;
            case 3:
              goto label_10;
            case 4:
              if (metadata != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 2;
                continue;
              }
              propertyMetadata2 = (PropertyMetadata) null;
              break;
            case 5:
              goto label_7;
            case 6:
              propertyInfo1 = propertyInfo;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 4 : 3;
              continue;
            case 7:
              num2 = 6;
              continue;
            case 8:
              goto label_9;
            case 9:
              if (propertyMetadata1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
                continue;
              }
              goto case 1;
            default:
              entitySettings2 = (EntitySettings) null;
              goto label_18;
          }
          propertyMetadata1 = propertyMetadata2;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 9 : 9;
          continue;
label_18:
          entitySettings1 = entitySettings2;
          num2 = 5;
        }
label_7:
        if (entitySettings1 == null)
          num1 = 3;
        else
          break;
      }
label_9:
      return entitySettings1.CopyAction;
label_10:
      return CopyAction.Default;
    }

    private static CopyAction GetCopyAction4Entity(object value)
    {
      int num = 3;
      CopyAction copyAction4Entity;
      while (true)
      {
        EntityMetadata entityMetadata1;
        TypeDescriptor typeDescriptor;
        Type runtimeType;
        EntityMetadata entityMetadata2;
        Guid uid;
        EntityMetadata entityMetadata3;
        Type type;
        Guid guid;
        switch (num)
        {
          case 1:
            typeDescriptor = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeDescriptor(runtimeType) as TypeDescriptor;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 4 : 19;
            continue;
          case 2:
            if (value != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 9 : 12;
              continue;
            }
            entityMetadata3 = (EntityMetadata) null;
            break;
          case 3:
            copyAction4Entity = CopyAction.Default;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 2;
            continue;
          case 4:
            if (value == null)
            {
              num = 21;
              continue;
            }
            goto case 25;
          case 5:
            copyAction4Entity = typeDescriptor.CopyAction;
            num = 22;
            continue;
          case 6:
            copyAction4Entity = entityMetadata1.CopyAction;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 25 : 28;
            continue;
          case 7:
          case 8:
            if (copyAction4Entity == CopyAction.Default)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 26 : 14;
              continue;
            }
            goto label_33;
          case 9:
            typeDescriptor = (TypeDescriptor) null;
            num = 30;
            continue;
          case 10:
            guid = Guid.Empty;
            goto label_40;
          case 11:
            if (entityMetadata2 != null)
            {
              num = 18;
              continue;
            }
            goto case 4;
          case 12:
            entityMetadata3 = MetadataLoader.LoadMetadata(value.GetType()) as EntityMetadata;
            break;
          case 13:
          case 22:
            goto label_33;
          case 14:
          case 20:
            entityMetadata1 = MetadataLoader.LoadMetadata(uid) as EntityMetadata;
            num = 27;
            continue;
          case 15:
            guid = entityMetadata1.BaseClassUid;
            goto label_40;
          case 17:
          case 30:
            if (typeDescriptor != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 12 : 24;
              continue;
            }
            goto case 29;
          case 18:
            copyAction4Entity = entityMetadata2.CopyAction;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 3 : 23;
            continue;
          case 19:
            runtimeType = runtimeType.BaseType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 17 : 10;
            continue;
          case 21:
            type = (Type) null;
            goto label_42;
          case 23:
            uid = entityMetadata2.BaseClassUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 7 : 3;
            continue;
          case 24:
            if (typeDescriptor.CopyAction != CopyAction.Default)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 16 : 12;
              continue;
            }
            goto case 29;
          case 25:
            type = value.GetType();
            goto label_42;
          case 26:
            if (uid != Guid.Empty)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 4 : 20;
              continue;
            }
            goto label_33;
          case 27:
            if (entityMetadata1 != null)
            {
              num = 6;
              continue;
            }
            goto case 28;
          case 28:
            if (entityMetadata1 != null)
            {
              num = 15;
              continue;
            }
            goto case 10;
          case 29:
            if (!(runtimeType != (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
              continue;
            }
            goto case 1;
          default:
            if (typeDescriptor != null)
            {
              num = 5;
              continue;
            }
            goto label_33;
        }
        entityMetadata2 = entityMetadata3;
        num = 11;
        continue;
label_40:
        uid = guid;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 7 : 8;
        continue;
label_42:
        runtimeType = type;
        num = 9;
      }
label_33:
      return copyAction4Entity;
    }

    private static CopyAction GetCopyAction4PropertyRelation(
      ClassMetadata metadata,
      PropertyInfo propertyInfo)
    {
      int num = 7;
      while (true)
      {
        PropertyMetadata propertyMetadata1;
        EntitySettings entitySettings1;
        EntitySettings entitySettings2;
        PropertyMetadata propertyMetadata2;
        PropertyInfo propertyInfo1;
        switch (num)
        {
          case 1:
            if (entitySettings1.RelationType != RelationType.OneToMany)
            {
              num = 2;
              continue;
            }
            goto label_13;
          case 2:
          case 9:
            goto label_12;
          case 3:
            if (metadata != null)
            {
              num = 8;
              continue;
            }
            propertyMetadata2 = (PropertyMetadata) null;
            break;
          case 4:
            if (entitySettings1 == null)
            {
              num = 9;
              continue;
            }
            goto case 1;
          case 5:
            entitySettings2 = propertyMetadata1.Settings as EntitySettings;
            goto label_19;
          case 6:
            propertyInfo1 = propertyInfo;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 3 : 0;
            continue;
          case 7:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 3 : 6;
            continue;
          case 8:
            propertyMetadata2 = metadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => p.Name == propertyInfo1.Name));
            break;
          default:
            if (propertyMetadata1 != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 5 : 1;
              continue;
            }
            entitySettings2 = (EntitySettings) null;
            goto label_19;
        }
        propertyMetadata1 = propertyMetadata2;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
        continue;
label_19:
        entitySettings1 = entitySettings2;
        num = 4;
      }
label_12:
      return CopyAction.Default;
label_13:
      return CopyAction.Clone;
    }

    private static ILogger Logger => Locator.GetServiceNotNull<ILogger>();

    internal static bool qFniq9hc0h1VpiUvAVwp() => CloneHelperBuilder<T>.yFpD6uhcxI8kOGtSMOoS == null;

    internal static object tFIQBUhcmtkhJN0KH1Od() => CloneHelperBuilder<T>.yFpD6uhcxI8kOGtSMOoS;
  }
}
