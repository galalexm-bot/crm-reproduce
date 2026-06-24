// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.EntityPropertyAccessor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Bytecode.Lightweight;
using NHibernate.Engine;
using NHibernate.Properties;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH
{
  /// <summary>
  /// Стратегия NHibernate получения getter-ов и setter-ов для свойств.
  /// </summary>
  /// <remarks>
  /// <para>Для свойств дельта-сущностей (<see cref="T:EleWise.ELMA.Model.Entities.EntityDynamic`1" />) используется внутренний механизм получения значения свойства.</para>
  /// <para>Для свойств остальных классов используется рефлексия.</para>
  /// <para>В констркуторе можно задать использовать или нет оптимизацию рефлексии (по умолчанию использовать): компилируемые методы для получения/установки значения свойства.</para>
  /// <para>Для типа <see cref="T:System.DateTime" /> используется специальный getter, который значение <see cref="F:System.DateTime.MinValue" /> заменяет на <see langword="null" /></para>
  /// </remarks>
  [Serializable]
  public class EntityPropertyAccessor : IPropertyAccessor
  {
    private readonly bool reflectionOptimize;
    private RunWithSoftDeletableService runWithSoftDeletableService;
    private static EntityPropertyAccessor XxD0mVW12aEXpldD8bo5;

    public EntityPropertyAccessor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(true);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public EntityPropertyAccessor(bool reflectionOptimize)
    {
      EntityPropertyAccessor.nxvfhRW115kiXGRXlUOd();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.reflectionOptimize = reflectionOptimize;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <inheritdoc />
    public bool CanAccessThroughReflectionOptimizer => false;

    /// <inheritdoc />
    public IGetter GetGetter(Type type, string propertyName)
    {
      int num1 = 4;
      IGetter getter1;
      Type type1;
      string propertyName1;
      while (true)
      {
        int num2 = num1;
        EntityPropertyAccessor propertyAccessor;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_9;
            case 2:
              IGetter getter2 = this.Get<IGetter>(type1, propertyName1, (Func<PropertyInfo, bool>) (p =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      if ((object) p == null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
                        continue;
                      }
                      goto label_5;
                    default:
                      goto label_4;
                  }
                }
label_4:
                return false;
label_5:
                // ISSUE: reference to a compiler-generated method
                return EntityPropertyAccessor.\u003C\u003Ec.tsvZtYQmEKQMaSRFegeG((object) p);
              }), new Func<Type, string, IGetter>(this.GetGetterInternal), (Func<PropertyInfo, IGetter>) (p => propertyAccessor.GetterFactory(type1, p, propertyName1)));
              if (getter2 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 9 : 3;
                continue;
              }
              getter1 = getter2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
              continue;
            case 3:
              propertyAccessor = this;
              num2 = 6;
              continue;
            case 4:
              num2 = 3;
              continue;
            case 5:
              propertyName1 = propertyName;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 2 : 2;
              continue;
            case 6:
              type1 = type;
              num2 = 5;
              continue;
            case 7:
              goto label_5;
            case 8:
              getter1 = (IGetter) new EntityPropertyAccessor.DateTimeGetter(getter1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 1 : 0;
              continue;
            case 9:
              goto label_15;
            default:
              // ISSUE: type reference
              if (EntityPropertyAccessor.gxOHjhW1N7eH5UJApVWn(__typeref (IEntity)).IsAssignableFrom(type1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 7 : 6;
                continue;
              }
              goto label_9;
          }
        }
label_5:
        if (EntityPropertyAccessor.txJiixW1pcGDj0iBN4hd(EntityPropertyAccessor.eLuoqWW13I1XNrAcsxfd(getter1.ReturnType), TypeOf<DateTime>.Raw))
          num1 = 8;
        else
          break;
      }
label_9:
      return getter1;
label_15:
      throw new PropertyNotFoundException(type1, propertyName1, z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306580566));
    }

    /// <inheritdoc />
    public ISetter GetSetter(Type type, string propertyName)
    {
      int num1 = 2;
      ISetter setter;
      EntityPropertyAccessor propertyAccessor;
      Type type1;
      string propertyName1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            propertyAccessor = this;
            num1 = 4;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 1;
            continue;
          case 3:
            setter = this.Get<ISetter>(type1, propertyName1, (Func<PropertyInfo, bool>) (p =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    if ((object) p != null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
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
              return false;
label_3:
              // ISSUE: reference to a compiler-generated method
              return EntityPropertyAccessor.\u003C\u003Ec.pxAKc0QmfCV88qErQeI9((object) p);
            }), new Func<Type, string, ISetter>(this.GetSetterInternal), (Func<PropertyInfo, ISetter>) (p => propertyAccessor.SetterFactory(type1, p, propertyName1)));
            if (setter == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 4:
            type1 = type;
            num1 = 5;
            continue;
          case 5:
            propertyName1 = propertyName;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 1 : 3;
            continue;
          default:
            goto label_9;
        }
      }
label_2:
      return setter;
label_9:
      throw new PropertyNotFoundException(type1, propertyName1, (string) EntityPropertyAccessor.MBLH3aW1ajRH4FR0E9Ys(-630932142 - 1120244082 ^ -1751303454));
    }

    private IGetter GetGetterInternal(Type type, string propertyName)
    {
      int num = 5;
      IGetter getter1;
      RunWithSoftDeletableService serviceNotNull;
      RunWithSoftDeletableService deletableService;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_11;
          case 2:
            deletableService = this.runWithSoftDeletableService;
            if (deletableService == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 3 : 2;
              continue;
            }
            goto label_2;
          case 3:
            this.runWithSoftDeletableService = serviceNotNull = Locator.GetServiceNotNull<RunWithSoftDeletableService>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
            continue;
          case 4:
            if (getter1 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 1 : 0;
              continue;
            }
            goto case 2;
          case 5:
            getter1 = (IGetter) EntityPropertyAccessor.w4i14rW1DpODdBLV2a4A(type, (object) propertyName, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 4 : 3;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      RunWithSoftDeletableService runWithSoftDeletableService = serviceNotNull;
label_10:
      IGetter getter2 = getter1;
      return (IGetter) new EntityPropertyAccessor.SoftDeletableGetter(runWithSoftDeletableService, getter2);
label_2:
      runWithSoftDeletableService = deletableService;
      goto label_10;
label_11:
      return (IGetter) null;
    }

    private ISetter GetSetterInternal(Type type, string propertyName) => (ISetter) EntityPropertyAccessor.bcsS5YW1tgRZmrvlM5KT(type, (object) propertyName, true);

    private IGetter GetterFactory(Type type, PropertyInfo propertyInfo, string propertyName)
    {
      int num = 1;
      RunWithSoftDeletableService serviceNotNull;
      RunWithSoftDeletableService runWithSoftDeletableService;
      while (true)
      {
        switch (num)
        {
          case 1:
            runWithSoftDeletableService = this.runWithSoftDeletableService;
            if (runWithSoftDeletableService == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            goto label_5;
          default:
            this.runWithSoftDeletableService = serviceNotNull = Locator.GetServiceNotNull<RunWithSoftDeletableService>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 2;
            continue;
        }
      }
label_5:
      runWithSoftDeletableService = serviceNotNull;
label_6:
      return (IGetter) new EntityPropertyAccessor.SoftDeletableGetter(runWithSoftDeletableService, this.reflectionOptimize ? (IGetter) new EntityPropertyAccessor.ReflectionOptimizedBasicGetter(propertyInfo) : (IGetter) new BasicPropertyAccessor.BasicGetter(type, propertyInfo, propertyName));
    }

    private ISetter SetterFactory(Type type, PropertyInfo propertyInfo, string propertyName)
    {
      int num = 1;
      ISetter setter;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.reflectionOptimize)
            {
              setter = (ISetter) new EntityPropertyAccessor.ReflectionOptimizedBasicSetter(propertyInfo);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 3 : 3;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_2;
          default:
            setter = (ISetter) new BasicPropertyAccessor.BasicSetter(type, propertyInfo, propertyName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:
      return setter;
label_3:
      return setter;
    }

    /// <summary>
    /// Перебор типов по иерархии наследования и выбор правильного типа реализации getter/setter.
    /// </summary>
    private T Get<T>(
      Type type,
      string propertyName,
      Func<PropertyInfo, bool> check,
      Func<Type, string, T> resolver,
      Func<PropertyInfo, T> factory)
      where T : class
    {
      if (type == typeof (object) || type == (Type) null)
        return default (T);
      if (type.IsInheritOrSame(TypeOf<IValueContainerObjectInternal>.Raw))
      {
        T obj = resolver(type, propertyName);
        if ((object) obj != null)
          return obj;
      }
      BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public;
      if (type.IsValueType)
        bindingAttr |= BindingFlags.IgnoreCase;
      PropertyInfo property = type.GetProperty(propertyName, bindingAttr);
      if (property == (PropertyInfo) null && !this.reflectionOptimize)
        property = type.GetProperty(propertyName, bindingAttr | BindingFlags.IgnoreCase);
      return check(property) ? factory(property) : this.Get<T>(type.BaseType, propertyName, check, resolver, factory) ?? ((IEnumerable<Type>) type.GetInterfaces()).Select<Type, T>((Func<Type, T>) (i => this.Get<T>(i, propertyName, check, resolver, factory))).FirstOrDefault<T>();
    }

    internal static bool pLsXRUW1eqwIGxbXEVgt() => EntityPropertyAccessor.XxD0mVW12aEXpldD8bo5 == null;

    internal static EntityPropertyAccessor JvBBuMW1P2ieiQBkuqw7() => EntityPropertyAccessor.XxD0mVW12aEXpldD8bo5;

    internal static void nxvfhRW115kiXGRXlUOd() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Type gxOHjhW1N7eH5UJApVWn([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static Type eLuoqWW13I1XNrAcsxfd(Type type) => type.GetNonNullableType();

    internal static bool txJiixW1pcGDj0iBN4hd([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object MBLH3aW1ajRH4FR0E9Ys(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object w4i14rW1DpODdBLV2a4A(Type type, [In] object obj1, bool declaredOnly) => (object) type.GetGetter((string) obj1, declaredOnly);

    internal static object bcsS5YW1tgRZmrvlM5KT(Type type, [In] object obj1, bool declaredOnly) => (object) type.GetSetter((string) obj1, declaredOnly);

    private static class ReflectionOptimizer
    {
      private static readonly Dictionary<Type, OpCode> typeToOpcode;
      private static object nxPN8UQ0EA4PP8S0vMBH;

      public static GetPropertyValueInvoker GenerateGetPropertyValueMethod(object propertyInfo)
      {
        // ISSUE: type reference
        // ISSUE: type reference
        DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, EntityPropertyAccessor.ReflectionOptimizer.IQuepbQ0CE7q95off9Vt(__typeref (object)), new Type[1]
        {
          EntityPropertyAccessor.ReflectionOptimizer.IQuepbQ0CE7q95off9Vt(__typeref (object))
        }, EntityPropertyAccessor.ReflectionOptimizer.xlxtFJQ0vTHnP3QffmAJ(propertyInfo), false);
        object il = EntityPropertyAccessor.ReflectionOptimizer.HrLt2dQ08EOP1wEpbOmW((object) dynamicMethod);
        EntityPropertyAccessor.ReflectionOptimizer.adrVmIQ0ZSAo56XmtVtT(il, OpCodes.Ldarg_0);
        EntityPropertyAccessor.ReflectionOptimizer.Y1VsqhQ0umFrsjVFli3N(il, ((MemberInfo) propertyInfo).DeclaringType);
        EntityPropertyAccessor.ReflectionOptimizer.qiRk8qQ0VupDw03H556t(il, OpCodes.Callvirt, EntityPropertyAccessor.ReflectionOptimizer.DfwLj5Q0I0nr3dCEmx6q(propertyInfo), (object) null);
        EntityPropertyAccessor.ReflectionOptimizer.EmitBoxIfNeeded(il, ((PropertyInfo) propertyInfo).PropertyType);
        EntityPropertyAccessor.ReflectionOptimizer.adrVmIQ0ZSAo56XmtVtT(il, OpCodes.Ret);
        // ISSUE: type reference
        return (GetPropertyValueInvoker) EntityPropertyAccessor.ReflectionOptimizer.JRnf9SQ0Si9LCUuQNlrG((object) dynamicMethod, EntityPropertyAccessor.ReflectionOptimizer.IQuepbQ0CE7q95off9Vt(__typeref (GetPropertyValueInvoker)));
      }

      public static SetPropertyValueInvoker GenerateSetPropertyValueMethod(object propertyInfo)
      {
        // ISSUE: type reference
        DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, (Type) null, new Type[2]
        {
          EntityPropertyAccessor.ReflectionOptimizer.IQuepbQ0CE7q95off9Vt(__typeref (object)),
          typeof (object)
        }, EntityPropertyAccessor.ReflectionOptimizer.xlxtFJQ0vTHnP3QffmAJ(propertyInfo), false);
        object obj = EntityPropertyAccessor.ReflectionOptimizer.HrLt2dQ08EOP1wEpbOmW((object) dynamicMethod);
        EntityPropertyAccessor.ReflectionOptimizer.adrVmIQ0ZSAo56XmtVtT(obj, OpCodes.Ldarg_0);
        EntityPropertyAccessor.ReflectionOptimizer.Y1VsqhQ0umFrsjVFli3N(obj, EntityPropertyAccessor.ReflectionOptimizer.xlxtFJQ0vTHnP3QffmAJ(propertyInfo));
        EntityPropertyAccessor.ReflectionOptimizer.adrVmIQ0ZSAo56XmtVtT(obj, OpCodes.Ldarg_1);
        EntityPropertyAccessor.ReflectionOptimizer.RCpMLjQ0R8JmUsAR3Z3n(obj, EntityPropertyAccessor.ReflectionOptimizer.z2i30xQ0iWrRYQhEOCJU(propertyInfo));
        EntityPropertyAccessor.ReflectionOptimizer.qiRk8qQ0VupDw03H556t(obj, OpCodes.Callvirt, EntityPropertyAccessor.ReflectionOptimizer.vW8oc8Q0qEnC6ypVtfjc(propertyInfo), (object) null);
        EntityPropertyAccessor.ReflectionOptimizer.adrVmIQ0ZSAo56XmtVtT(obj, OpCodes.Ret);
        // ISSUE: type reference
        return (SetPropertyValueInvoker) dynamicMethod.CreateDelegate(EntityPropertyAccessor.ReflectionOptimizer.IQuepbQ0CE7q95off9Vt(__typeref (SetPropertyValueInvoker)));
      }

      private static void EmitCastToReference(object il, Type type)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!type.IsValueType)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
                continue;
              }
              goto case 4;
            case 2:
              goto label_3;
            case 3:
              goto label_4;
            case 4:
              EntityPropertyAccessor.ReflectionOptimizer.o5ndvMQ0KmwSRamvMq93(il, OpCodes.Unbox, type);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 2 : 2;
              continue;
            default:
              EntityPropertyAccessor.ReflectionOptimizer.o5ndvMQ0KmwSRamvMq93(il, OpCodes.Castclass, type);
              num = 3;
              continue;
          }
        }
label_3:
        return;
label_4:;
      }

      private static void EmitBoxIfNeeded(object il, Type type)
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              EntityPropertyAccessor.ReflectionOptimizer.o5ndvMQ0KmwSRamvMq93(il, OpCodes.Box, type);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
              continue;
            case 2:
              if (type.IsValueType)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 1 : 1;
                continue;
              }
              goto label_6;
            default:
              goto label_7;
          }
        }
label_2:
        return;
label_7:
        return;
label_6:;
      }

      private static void PreparePropertyForSet(object il, Type propertyType)
      {
        int num = 1;
        LocalBuilder local;
        OpCode opCode;
        Label loc;
        Label label;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!propertyType.IsValueType)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
                continue;
              }
              goto case 16;
            case 2:
              EntityPropertyAccessor.ReflectionOptimizer.FkV4DqQ0nKo9sLiRmhIe(il, OpCodes.Ldloc, (object) local);
              num = 10;
              continue;
            case 3:
              if (!EntityPropertyAccessor.ReflectionOptimizer.typeToOpcode.TryGetValue(propertyType, out opCode))
              {
                num = 19;
                continue;
              }
              goto case 15;
            case 4:
              EntityPropertyAccessor.ReflectionOptimizer.adrVmIQ0ZSAo56XmtVtT(il, OpCodes.Pop);
              num = 20;
              continue;
            case 5:
            case 17:
              EntityPropertyAccessor.ReflectionOptimizer.FT0mSaQ0Os7lFRKX2a3c(il, label);
              num = 11;
              continue;
            case 6:
              label = EntityPropertyAccessor.ReflectionOptimizer.ihmqedQ0XDoDlMiUis7l(il);
              num = 22;
              continue;
            case 7:
              EntityPropertyAccessor.ReflectionOptimizer.wQmoehQ0kA5sKXJF7Lpi(il, OpCodes.Brtrue_S, loc);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 4 : 4;
              continue;
            case 8:
              ((ILGenerator) il).Emit(OpCodes.Unbox, propertyType);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 3 : 3;
              continue;
            case 9:
              EntityPropertyAccessor.ReflectionOptimizer.adrVmIQ0ZSAo56XmtVtT(il, OpCodes.Dup);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 7 : 6;
              continue;
            case 10:
              EntityPropertyAccessor.ReflectionOptimizer.wQmoehQ0kA5sKXJF7Lpi(il, OpCodes.Br_S, label);
              num = 12;
              continue;
            case 11:
              goto label_5;
            case 12:
              ((ILGenerator) il).MarkLabel(loc);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 6 : 8;
              continue;
            case 13:
              EntityPropertyAccessor.ReflectionOptimizer.o5ndvMQ0KmwSRamvMq93(il, OpCodes.Initobj, propertyType);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 1 : 2;
              continue;
            case 14:
            case 19:
              EntityPropertyAccessor.ReflectionOptimizer.o5ndvMQ0KmwSRamvMq93(il, OpCodes.Ldobj, propertyType);
              num = 5;
              continue;
            case 15:
              EntityPropertyAccessor.ReflectionOptimizer.adrVmIQ0ZSAo56XmtVtT(il, opCode);
              num = 17;
              continue;
            case 16:
              loc = EntityPropertyAccessor.ReflectionOptimizer.ihmqedQ0XDoDlMiUis7l(il);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 3 : 6;
              continue;
            case 18:
              ((ILGenerator) il).Emit(OpCodes.Castclass, propertyType);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 12 : 21;
              continue;
            case 20:
              ((ILGenerator) il).Emit(OpCodes.Ldloca, local);
              num = 13;
              continue;
            case 21:
              goto label_21;
            case 22:
              local = (LocalBuilder) EntityPropertyAccessor.ReflectionOptimizer.eOORfTQ0TfNbHUrrOXLF(il, propertyType);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 9;
              continue;
            default:
              if (propertyType != typeof (object))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 3 : 18;
                continue;
              }
              goto label_15;
          }
        }
label_5:
        return;
label_21:
        return;
label_15:;
      }

      static ReflectionOptimizer()
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              // ISSUE: type reference
              // ISSUE: type reference
              // ISSUE: type reference
              // ISSUE: type reference
              // ISSUE: type reference
              // ISSUE: type reference
              // ISSUE: type reference
              // ISSUE: type reference
              // ISSUE: type reference
              EntityPropertyAccessor.ReflectionOptimizer.typeToOpcode = new Dictionary<Type, OpCode>()
              {
                [typeof (bool)] = OpCodes.Ldind_I1,
                [EntityPropertyAccessor.ReflectionOptimizer.IQuepbQ0CE7q95off9Vt(__typeref (sbyte))] = OpCodes.Ldind_I1,
                [EntityPropertyAccessor.ReflectionOptimizer.IQuepbQ0CE7q95off9Vt(__typeref (byte))] = OpCodes.Ldind_U1,
                [EntityPropertyAccessor.ReflectionOptimizer.IQuepbQ0CE7q95off9Vt(__typeref (char))] = OpCodes.Ldind_U2,
                [typeof (short)] = OpCodes.Ldind_I2,
                [EntityPropertyAccessor.ReflectionOptimizer.IQuepbQ0CE7q95off9Vt(__typeref (ushort))] = OpCodes.Ldind_U2,
                [EntityPropertyAccessor.ReflectionOptimizer.IQuepbQ0CE7q95off9Vt(__typeref (int))] = OpCodes.Ldind_I4,
                [typeof (uint)] = OpCodes.Ldind_U4,
                [EntityPropertyAccessor.ReflectionOptimizer.IQuepbQ0CE7q95off9Vt(__typeref (long))] = OpCodes.Ldind_I8,
                [EntityPropertyAccessor.ReflectionOptimizer.IQuepbQ0CE7q95off9Vt(__typeref (ulong))] = OpCodes.Ldind_I8,
                [EntityPropertyAccessor.ReflectionOptimizer.IQuepbQ0CE7q95off9Vt(__typeref (float))] = OpCodes.Ldind_R4,
                [EntityPropertyAccessor.ReflectionOptimizer.IQuepbQ0CE7q95off9Vt(__typeref (double))] = OpCodes.Ldind_R8
              };
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
              continue;
            case 2:
              EntityPropertyAccessor.ReflectionOptimizer.syddh6Q02gWlKnNYMHrN();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 1 : 1;
              continue;
            default:
              goto label_5;
          }
        }
label_2:
        return;
label_5:;
      }

      internal static Type IQuepbQ0CE7q95off9Vt([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

      internal static Type xlxtFJQ0vTHnP3QffmAJ([In] object obj0) => ((MemberInfo) obj0).DeclaringType;

      internal static object HrLt2dQ08EOP1wEpbOmW([In] object obj0) => (object) ((DynamicMethod) obj0).GetILGenerator();

      internal static void adrVmIQ0ZSAo56XmtVtT([In] object obj0, [In] OpCode obj1) => ((ILGenerator) obj0).Emit(obj1);

      internal static void Y1VsqhQ0umFrsjVFli3N([In] object obj0, Type type) => EntityPropertyAccessor.ReflectionOptimizer.EmitCastToReference(obj0, type);

      internal static object DfwLj5Q0I0nr3dCEmx6q([In] object obj0) => (object) ((PropertyInfo) obj0).GetMethod;

      internal static void qiRk8qQ0VupDw03H556t(
        [In] object obj0,
        [In] OpCode obj1,
        [In] object obj2,
        [In] object obj3)
      {
        ((ILGenerator) obj0).EmitCall(obj1, (MethodInfo) obj2, (Type[]) obj3);
      }

      internal static object JRnf9SQ0Si9LCUuQNlrG([In] object obj0, [In] Type obj1) => (object) ((MethodInfo) obj0).CreateDelegate(obj1);

      internal static bool J63w7SQ0fsvSRb5u4ja8() => EntityPropertyAccessor.ReflectionOptimizer.nxPN8UQ0EA4PP8S0vMBH == null;

      internal static EntityPropertyAccessor.ReflectionOptimizer it5VSyQ0QiPZIXKUZ0Bw() => (EntityPropertyAccessor.ReflectionOptimizer) EntityPropertyAccessor.ReflectionOptimizer.nxPN8UQ0EA4PP8S0vMBH;

      internal static Type z2i30xQ0iWrRYQhEOCJU([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

      internal static void RCpMLjQ0R8JmUsAR3Z3n([In] object obj0, Type propertyType) => EntityPropertyAccessor.ReflectionOptimizer.PreparePropertyForSet(obj0, propertyType);

      internal static object vW8oc8Q0qEnC6ypVtfjc([In] object obj0) => (object) ((PropertyInfo) obj0).SetMethod;

      internal static void o5ndvMQ0KmwSRamvMq93([In] object obj0, [In] OpCode obj1, [In] Type obj2) => ((ILGenerator) obj0).Emit(obj1, obj2);

      internal static Label ihmqedQ0XDoDlMiUis7l([In] object obj0) => ((ILGenerator) obj0).DefineLabel();

      internal static object eOORfTQ0TfNbHUrrOXLF([In] object obj0, [In] Type obj1) => (object) ((ILGenerator) obj0).DeclareLocal(obj1);

      internal static void wQmoehQ0kA5sKXJF7Lpi([In] object obj0, [In] OpCode obj1, [In] Label obj2) => ((ILGenerator) obj0).Emit(obj1, obj2);

      internal static void FkV4DqQ0nKo9sLiRmhIe([In] object obj0, [In] OpCode obj1, [In] object obj2) => ((ILGenerator) obj0).Emit(obj1, (LocalBuilder) obj2);

      internal static void FT0mSaQ0Os7lFRKX2a3c([In] object obj0, [In] Label obj1) => ((ILGenerator) obj0).MarkLabel(obj1);

      internal static void syddh6Q02gWlKnNYMHrN() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }

    /// <summary>Оптимизированный геттер для сущностей через рефлексию</summary>
    [Serializable]
    private sealed class ReflectionOptimizedBasicGetter : IGetter
    {
      private readonly object invoker;
      private static object q5CX8gQ0eh0V2TvnInfZ;

      public ReflectionOptimizedBasicGetter(PropertyInfo propertyInfo)
      {
        EntityPropertyAccessor.ReflectionOptimizedBasicGetter.wKWloIQ0NAxZ5Uwr1pUj();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.invoker = (object) EntityPropertyAccessor.ReflectionOptimizer.GenerateGetPropertyValueMethod((object) propertyInfo);
              num = 3;
              continue;
            case 2:
              this.ReturnType = propertyInfo.PropertyType;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
              continue;
            case 3:
              goto label_2;
            default:
              this.PropertyName = (string) EntityPropertyAccessor.ReflectionOptimizedBasicGetter.nd4pUNQ03VnZB8dMhedn((object) propertyInfo);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 1 : 0;
              continue;
          }
        }
label_2:;
      }

      public Type ReturnType { get; }

      public string PropertyName { get; }

      public MethodInfo Method => (MethodInfo) null;

      public object Get(object target) => EntityPropertyAccessor.ReflectionOptimizedBasicGetter.t34gnLQ0pDrEP4G0QxIf(this.invoker, target);

      public object GetForInsert(object owner, IDictionary mergeMap, ISessionImplementor session) => this.Get(owner);

      internal static void wKWloIQ0NAxZ5Uwr1pUj() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static object nd4pUNQ03VnZB8dMhedn([In] object obj0) => (object) ((MemberInfo) obj0).Name;

      internal static bool zj3klQQ0PpsVoxuQrqTE() => EntityPropertyAccessor.ReflectionOptimizedBasicGetter.q5CX8gQ0eh0V2TvnInfZ == null;

      internal static EntityPropertyAccessor.ReflectionOptimizedBasicGetter z3xjkkQ01AgEiUF9F5Bm() => (EntityPropertyAccessor.ReflectionOptimizedBasicGetter) EntityPropertyAccessor.ReflectionOptimizedBasicGetter.q5CX8gQ0eh0V2TvnInfZ;

      internal static object t34gnLQ0pDrEP4G0QxIf([In] object obj0, [In] object obj1) => ((GetPropertyValueInvoker) obj0)(obj1);
    }

    /// <summary>
    /// Геттер-обертка, для получения "мягко"-удаленных сущностей
    /// </summary>
    [Serializable]
    private sealed class SoftDeletableGetter : IGetter
    {
      private readonly object runWithSoftDeletableService;
      private readonly object getter;
      private static object uvdVD7Q0a5y4g0p8UMt2;

      public SoftDeletableGetter(
        RunWithSoftDeletableService runWithSoftDeletableService,
        IGetter getter)
      {
        EntityPropertyAccessor.SoftDeletableGetter.LOdF44Q0wIid7q9VZ4k6();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.getter = (object) getter;
              num = 2;
              continue;
            case 2:
              goto label_3;
            default:
              this.runWithSoftDeletableService = (object) runWithSoftDeletableService;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 1 : 0;
              continue;
          }
        }
label_3:;
      }

      public Type ReturnType => EntityPropertyAccessor.SoftDeletableGetter.N1lBgiQ045p6PuNj43N9(this.getter);

      public string PropertyName => (string) EntityPropertyAccessor.SoftDeletableGetter.uFb72CQ06kKk7mJSLyim(this.getter);

      public MethodInfo Method => (MethodInfo) EntityPropertyAccessor.SoftDeletableGetter.Wjve2yQ0HqfyuSXaDvqD(this.getter);

      public object Get(object target)
      {
        int num1 = 2;
        IDisposable disposable;
        while (true)
        {
          switch (num1)
          {
            case 1:
              goto label_4;
            case 2:
              disposable = (IDisposable) EntityPropertyAccessor.SoftDeletableGetter.vZaDwnQ0ACONokBrYYAU();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 1;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        object obj;
        return obj;
label_4:
        try
        {
          bool flag = EntityPropertyAccessor.SoftDeletableGetter.prKZ0yQ07AGdOBqkbJkR(this.runWithSoftDeletableService);
          int num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
            num2 = 0;
          switch (num2)
          {
            default:
              try
              {
                EntityPropertyAccessor.SoftDeletableGetter.B3nK2iQ0xbFlxda9MOqB(this.runWithSoftDeletableService, true);
                int num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
                  num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      obj = ((IGetter) this.getter).Get(target);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_2;
                  }
                }
              }
              finally
              {
                ((RunWithSoftDeletableService) this.runWithSoftDeletableService).Turned = flag;
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
          }
        }
        finally
        {
          if (disposable != null)
          {
            int num5 = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
              num5 = 0;
            while (true)
            {
              switch (num5)
              {
                case 1:
                  EntityPropertyAccessor.SoftDeletableGetter.pnXSaLQ00iWG0N7lPpoJ((object) disposable);
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
                  continue;
                default:
                  goto label_21;
              }
            }
          }
label_21:;
        }
      }

      public object GetForInsert(object owner, IDictionary mergeMap, ISessionImplementor session)
      {
        int num1 = 1;
        IDisposable disposable;
        while (true)
        {
          switch (num1)
          {
            case 1:
              disposable = ELMAContext.Create();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              goto label_3;
          }
        }
label_2:
        object forInsert;
        return forInsert;
label_3:
        try
        {
          bool flag = EntityPropertyAccessor.SoftDeletableGetter.prKZ0yQ07AGdOBqkbJkR(this.runWithSoftDeletableService);
          int num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
            num2 = 0;
          switch (num2)
          {
            default:
              try
              {
                EntityPropertyAccessor.SoftDeletableGetter.B3nK2iQ0xbFlxda9MOqB(this.runWithSoftDeletableService, true);
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
                  num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      forInsert = EntityPropertyAccessor.SoftDeletableGetter.XxvjPJQ0mULQjNfTQZqM(this.getter, owner, (object) mergeMap, (object) session);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_2;
                  }
                }
              }
              finally
              {
                ((RunWithSoftDeletableService) this.runWithSoftDeletableService).Turned = flag;
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
          }
        }
        finally
        {
          if (disposable != null)
          {
            int num5 = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
              num5 = 1;
            while (true)
            {
              switch (num5)
              {
                case 1:
                  EntityPropertyAccessor.SoftDeletableGetter.pnXSaLQ00iWG0N7lPpoJ((object) disposable);
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
                  continue;
                default:
                  goto label_21;
              }
            }
          }
label_21:;
        }
      }

      internal static void LOdF44Q0wIid7q9VZ4k6() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool srs65TQ0DaCaoScG5Buy() => EntityPropertyAccessor.SoftDeletableGetter.uvdVD7Q0a5y4g0p8UMt2 == null;

      internal static EntityPropertyAccessor.SoftDeletableGetter C7Dk28Q0tWcyxYZcg6II() => (EntityPropertyAccessor.SoftDeletableGetter) EntityPropertyAccessor.SoftDeletableGetter.uvdVD7Q0a5y4g0p8UMt2;

      internal static Type N1lBgiQ045p6PuNj43N9([In] object obj0) => ((IGetter) obj0).ReturnType;

      internal static object uFb72CQ06kKk7mJSLyim([In] object obj0) => (object) ((IGetter) obj0).PropertyName;

      internal static object Wjve2yQ0HqfyuSXaDvqD([In] object obj0) => (object) ((IGetter) obj0).Method;

      internal static object vZaDwnQ0ACONokBrYYAU() => (object) ELMAContext.Create();

      internal static bool prKZ0yQ07AGdOBqkbJkR([In] object obj0) => ((RunWithSoftDeletableService) obj0).Turned;

      internal static void B3nK2iQ0xbFlxda9MOqB([In] object obj0, bool value) => ((RunWithSoftDeletableService) obj0).Turned = value;

      internal static void pnXSaLQ00iWG0N7lPpoJ([In] object obj0) => ((IDisposable) obj0).Dispose();

      internal static object XxvjPJQ0mULQjNfTQZqM(
        [In] object obj0,
        [In] object obj1,
        [In] object obj2,
        [In] object obj3)
      {
        return ((IGetter) obj0).GetForInsert(obj1, (IDictionary) obj2, (ISessionImplementor) obj3);
      }
    }

    /// <summary>
    /// Геттер для типа <see cref="T:System.DateTime" />
    /// </summary>
    [Serializable]
    private sealed class DateTimeGetter : IGetter
    {
      private readonly object getter;
      private static object U2P1JyQ0yyRhO7ru9EOg;

      public DateTimeGetter(IGetter getter)
      {
        EntityPropertyAccessor.DateTimeGetter.pXHaV6Q09MMpKdNFngS7();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this.getter = (object) getter;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 1;
              continue;
          }
        }
label_3:;
      }

      public Type ReturnType => TypeOf<DateTime?>.Raw;

      public string PropertyName => (string) EntityPropertyAccessor.DateTimeGetter.Kfh4nbQ0dqGbp7bGft36(this.getter);

      public MethodInfo Method => (MethodInfo) EntityPropertyAccessor.DateTimeGetter.V8LCTJQ0l8LTOHJJhKRY(this.getter);

      public object Get(object target) => this.GetResult((DateTime?) EntityPropertyAccessor.DateTimeGetter.gQQ14sQ0rXX1MIs7kvm4(this.getter, target));

      public object GetForInsert(object owner, IDictionary mergeMap, ISessionImplementor session) => this.GetResult((DateTime?) EntityPropertyAccessor.DateTimeGetter.cdP4tCQ0gDdd91pXZJIO(this.getter, owner, (object) mergeMap, (object) session));

      private object GetResult(DateTime? value)
      {
        DateTime? nullable = value;
        DateTime minValue = DateTime.MinValue;
        return (object) ((nullable.HasValue ? (nullable.HasValue ? (nullable.GetValueOrDefault() == minValue ? 1 : 0) : 1) : 0) != 0 ? new DateTime?() : value);
      }

      internal static void pXHaV6Q09MMpKdNFngS7() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool zpkEdVQ0MTFowZBofZ9I() => EntityPropertyAccessor.DateTimeGetter.U2P1JyQ0yyRhO7ru9EOg == null;

      internal static EntityPropertyAccessor.DateTimeGetter Y7GHqiQ0JCrsmHInBX80() => (EntityPropertyAccessor.DateTimeGetter) EntityPropertyAccessor.DateTimeGetter.U2P1JyQ0yyRhO7ru9EOg;

      internal static object Kfh4nbQ0dqGbp7bGft36([In] object obj0) => (object) ((IGetter) obj0).PropertyName;

      internal static object V8LCTJQ0l8LTOHJJhKRY([In] object obj0) => (object) ((IGetter) obj0).Method;

      internal static object gQQ14sQ0rXX1MIs7kvm4([In] object obj0, [In] object obj1) => ((IGetter) obj0).Get(obj1);

      internal static object cdP4tCQ0gDdd91pXZJIO(
        [In] object obj0,
        [In] object obj1,
        [In] object obj2,
        [In] object obj3)
      {
        return ((IGetter) obj0).GetForInsert(obj1, (IDictionary) obj2, (ISessionImplementor) obj3);
      }
    }

    /// <summary>Оптимизированный сеттер для сущностей через рефлексию</summary>
    [Serializable]
    private sealed class ReflectionOptimizedBasicSetter : ISetter
    {
      private readonly object invoker;
      internal static object YveVY9Q05jEaCSIS48Pc;

      public ReflectionOptimizedBasicSetter(PropertyInfo propertyInfo)
      {
        EntityPropertyAccessor.ReflectionOptimizedBasicSetter.rHXE8lQ0Lxqr2igHjttx();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.invoker = EntityPropertyAccessor.ReflectionOptimizedBasicSetter.TVPaaVQ0suaZ29HkG36N((object) propertyInfo);
              num = 2;
              continue;
            case 2:
              goto label_3;
            default:
              this.PropertyName = (string) EntityPropertyAccessor.ReflectionOptimizedBasicSetter.dulMOsQ0Ufn9VKwdCWVS((object) propertyInfo);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 1;
              continue;
          }
        }
label_3:;
      }

      public string PropertyName { get; }

      public MethodInfo Method => (MethodInfo) null;

      public void Set(object target, object value)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              EntityPropertyAccessor.ReflectionOptimizedBasicSetter.UtxZDWQ0clHyhFS6sVn1(this.invoker, target, value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      internal static void rHXE8lQ0Lxqr2igHjttx() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static object dulMOsQ0Ufn9VKwdCWVS([In] object obj0) => (object) ((MemberInfo) obj0).Name;

      internal static object TVPaaVQ0suaZ29HkG36N([In] object obj0) => (object) EntityPropertyAccessor.ReflectionOptimizer.GenerateSetPropertyValueMethod(obj0);

      internal static bool nbFyViQ0jBmcIjdnAfOE() => EntityPropertyAccessor.ReflectionOptimizedBasicSetter.YveVY9Q05jEaCSIS48Pc == null;

      internal static EntityPropertyAccessor.ReflectionOptimizedBasicSetter ior7tVQ0YQVL5r4Jxqyc() => (EntityPropertyAccessor.ReflectionOptimizedBasicSetter) EntityPropertyAccessor.ReflectionOptimizedBasicSetter.YveVY9Q05jEaCSIS48Pc;

      internal static void UtxZDWQ0clHyhFS6sVn1([In] object obj0, [In] object obj1, [In] object obj2) => ((SetPropertyValueInvoker) obj0)(obj1, obj2);
    }
  }
}
