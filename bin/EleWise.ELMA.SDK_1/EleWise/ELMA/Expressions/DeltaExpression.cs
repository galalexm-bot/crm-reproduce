// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Expressions.DeltaExpression
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator;
using j3AmrhgkCleVTGdEwA;
using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Collections.Generic;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Expressions
{
  /// <summary>
  /// Методы расширения для <see cref="T:System.Linq.Expressions.Expression" /> поддерживающие дельта-публикацию
  /// </summary>
  /// <remarks>
  /// Данный класс и его методы не предназначены для публичного использования.
  /// </remarks>
  [EditorBrowsable(EditorBrowsableState.Never)]
  public static class DeltaExpression
  {
    private static readonly DeltaExpression.InternalMethodInfo[] MethodsToReplace;
    internal static DeltaExpression cj6KYYBejQXBgV7ZQ0dF;

    /// <summary>Ctor</summary>
    static DeltaExpression()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            DeltaExpression.MethodsToReplace = ((IEnumerable<MethodInfo>) typeof (DeltaExpression).GetMethods(BindingFlags.Static | BindingFlags.Public)).Where<MethodInfo>((Func<MethodInfo, bool>) (method => DeltaExpression.\u003C\u003Ec.aKb5FMQq3Y3I1IpG7EBW(DeltaExpression.\u003C\u003Ec.jmYMNRQq1JQVNnqyTebu((object) method), DeltaExpression.\u003C\u003Ec.ai5KHfQqNO6jXSJgqBt3(1304605005 ^ 1304465215)))).Select<MethodInfo, DeltaExpression.InternalMethodInfo>((Func<MethodInfo, DeltaExpression.InternalMethodInfo>) (method => new DeltaExpression.InternalMethodInfo((string) DeltaExpression.\u003C\u003Ec.jmYMNRQq1JQVNnqyTebu((object) method), (string) DeltaExpression.\u003C\u003Ec.jmYMNRQq1JQVNnqyTebu((object) DeltaExpression.\u003C\u003Ec.kM8FTPQqprRhySkrFVOE((object) method)), (IEnumerable<string>) ((IEnumerable<ParameterInfo>) DeltaExpression.\u003C\u003Ec.vUXhm3QqaAbWSRiF8q4T((object) method)).Select<ParameterInfo, string>((Func<ParameterInfo, string>) (parameter => (string) DeltaExpression.\u003C\u003Ec.jmYMNRQq1JQVNnqyTebu((object) parameter.ParameterType))).ToArray<string>(), method))).ToArray<DeltaExpression.InternalMethodInfo>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Проверить и заменить вызов метода в инструкции</summary>
    /// <param name="module">Модуль</param>
    /// <param name="instruction">Инструкция IL-кода</param>
    /// <returns><c>true</c> если замена произведена</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal static bool CheckAndReplace(ModuleDefinition module, Instruction instruction)
    {
      int num1 = 9;
      while (true)
      {
        int num2 = num1;
        MethodReference methodReference1;
        while (true)
        {
          DeltaExpression.InternalMethodInfo internalMethodInfo;
          MethodReference methodReference2;
          int index;
          DeltaExpression.InternalMethodInfo[] methodsToReplace;
          switch (num2)
          {
            case 1:
              index = 0;
              num2 = 10;
              continue;
            case 2:
              goto label_13;
            case 3:
            case 10:
              if (index >= methodsToReplace.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 2 : 2;
                continue;
              }
              break;
            case 4:
              if (!DeltaExpression.kkpPg3BesckTs6vvmlGH((object) internalMethodInfo, (object) methodReference1))
              {
                ++index;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 1 : 3;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 3 : 5;
              continue;
            case 5:
              methodReference2 = module.Import((MethodBase) internalMethodInfo.MethodInfo);
              num2 = 7;
              continue;
            case 6:
              goto label_6;
            case 7:
              DeltaExpression.HQhZFQBecA6SlIjYnE6C((object) instruction, (object) methodReference2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 6;
              continue;
            case 8:
              methodsToReplace = DeltaExpression.MethodsToReplace;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 1 : 1;
              continue;
            case 9:
              goto label_10;
          }
          internalMethodInfo = methodsToReplace[index];
          num2 = 4;
        }
label_10:
        methodReference1 = (MethodReference) DeltaExpression.pHWoFsBeUxjDFLSFdHae((object) instruction);
        num1 = 8;
      }
label_6:
      return true;
label_13:
      return false;
    }

    /// <summary>Создать выражение для досnупа к свойству</summary>
    /// <param name="expression">Выражение</param>
    /// <param name="propertyAccessor">Метод доступа к свойству</param>
    /// <returns>Выражение</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static MemberExpression Property(Expression expression, MethodInfo propertyAccessor)
    {
      int num1 = 10;
      ParameterInfo parameterInfo;
      string str;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 6:
            case 8:
              goto label_9;
            case 2:
              if (!((string) DeltaExpression.SrT6CvBPWJsD2ERVX9IX((object) propertyAccessor)).StartsWith((string) DeltaExpression.I8oRoUBezhdHWuHcZFjF(-1839087379 - 334718690 ^ 2121160327)))
              {
                num2 = 6;
                continue;
              }
              goto case 7;
            case 3:
              str = ((string) DeltaExpression.SrT6CvBPWJsD2ERVX9IX((object) propertyAccessor)).Substring(4);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 9 : 11;
              continue;
            case 4:
              if (!propertyAccessor.Name.StartsWith((string) DeltaExpression.I8oRoUBezhdHWuHcZFjF(-740338220 ^ -740337324)))
              {
                num2 = 2;
                continue;
              }
              goto case 7;
            case 5:
              if (parameterInfo == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 3 : 8;
                continue;
              }
              goto label_13;
            case 7:
              if (DeltaExpression.xFLcOnBPhyHydqAMCtX5(DeltaExpression.hJO5CbBPoxcjhOh8Ukof(), DeltaExpression.NVuFbdBPbl52A17PZhMY((object) parameterInfo)))
              {
                num2 = 3;
                continue;
              }
              goto label_9;
            case 9:
              parameterInfo = ((IEnumerable<ParameterInfo>) propertyAccessor.GetParameters()).FirstOrDefault<ParameterInfo>();
              num2 = 5;
              continue;
            case 10:
              DeltaExpression.Tuh1mWBPFbtm6q8n1PiI((object) propertyAccessor, DeltaExpression.I8oRoUBezhdHWuHcZFjF(~1767720452 ^ -1767667867));
              num2 = 9;
              continue;
            case 11:
              goto label_15;
            default:
              goto label_13;
          }
        }
label_13:
        if (DeltaExpression.SZaBbJBPBWv7aPXdpiZw((object) propertyAccessor))
          num1 = 4;
        else
          break;
      }
label_9:
      return (MemberExpression) DeltaExpression.v6bxG1BPGeHV5aov5kte((object) expression, (object) propertyAccessor);
label_15:
      return (MemberExpression) DeltaExpression.xwNFj6BPEWue5XOyjLYe((object) expression, DeltaExpression.NVuFbdBPbl52A17PZhMY((object) parameterInfo), (object) str);
    }

    /// <summary>Создать выражение для доступа к свойству</summary>
    /// <param name="expression">Выражение</param>
    /// <param name="property">Информация о свойстве</param>
    /// <returns>Выражение</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static MemberExpression Property(Expression expression, PropertyInfo property)
    {
      int num = 2;
      System.Type type;
      while (true)
      {
        switch (num)
        {
          case 1:
            type = DeltaExpression.E0rFFlBPfOb5fO8vGH4b((object) property);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
            continue;
          case 2:
            DeltaExpression.Tuh1mWBPFbtm6q8n1PiI((object) property, DeltaExpression.I8oRoUBezhdHWuHcZFjF(-97972138 ^ -98039472));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 1 : 1;
            continue;
          case 3:
          case 5:
            goto label_7;
          case 4:
            if (!DeltaExpression.xFLcOnBPhyHydqAMCtX5(DeltaExpression.hJO5CbBPoxcjhOh8Ukof(), type))
            {
              num = 5;
              continue;
            }
            goto label_8;
          default:
            if (DeltaExpression.Q93vSWBPQMbIc62D3MD5(type, (System.Type) null))
            {
              num = 3;
              continue;
            }
            goto case 4;
        }
      }
label_7:
      return Expression.Property(expression, property);
label_8:
      return (MemberExpression) DeltaExpression.xwNFj6BPEWue5XOyjLYe((object) expression, type, DeltaExpression.SrT6CvBPWJsD2ERVX9IX((object) property));
    }

    /// <summary>Создать выражение для доступа к свойству</summary>
    /// <param name="expression">Выражение</param>
    /// <param name="propertyName">Название свойства</param>
    /// <returns>Выражение</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static MemberExpression Property(Expression expression, string propertyName)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            DeltaExpression.Tuh1mWBPFbtm6q8n1PiI((object) expression, DeltaExpression.I8oRoUBezhdHWuHcZFjF(-649342099 - -1150814748 ^ 501469325));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return DeltaExpression.Property(expression, DeltaExpression.FZZEd8BPCQ5BFwYM4hoR((object) expression), propertyName);
    }

    /// <summary>Создать выражение для доступа к свойству</summary>
    /// <param name="expression">Выражение</param>
    /// <param name="type">Тип содержащий свойство</param>
    /// <param name="propertyName">Название свойства</param>
    /// <returns>Выражение</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static MemberExpression Property(Expression expression, System.Type type, string propertyName)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            DeltaExpression.Tuh1mWBPFbtm6q8n1PiI((object) type, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740337162));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 0 : 0;
            continue;
          case 2:
            if (!DeltaExpression.xFLcOnBPhyHydqAMCtX5((object) EntityDynamicProvider.Instance, type))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 3;
              continue;
            }
            goto label_6;
          case 3:
            goto label_5;
          default:
            DeltaExpression.TsWWvCBPvxvHcO7BruWd((object) propertyName, DeltaExpression.I8oRoUBezhdHWuHcZFjF(-1290212282 ^ -644262414 ^ 1786808182));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 2;
            continue;
        }
      }
label_5:
      return (MemberExpression) DeltaExpression.mBTQ5EBP8EI91jw4hDXP((object) expression, (object) propertyName);
label_6:
      return (MemberExpression) DeltaExpression.xwNFj6BPEWue5XOyjLYe((object) expression, type, (object) propertyName);
    }

    /// <summary>Создать выражение для доступа к свойству или полю</summary>
    /// <param name="expression">Выражение</param>
    /// <param name="propertyOrFieldName">Название свойства/поля</param>
    /// <returns></returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static MemberExpression PropertyOrField(
      Expression expression,
      string propertyOrFieldName)
    {
      int num1 = 7;
      PropertyInfo propertyInfo;
      while (true)
      {
        int num2 = num1;
        System.Type type;
        while (true)
        {
          switch (num2)
          {
            case 1:
              type = expression.Type;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 3 : 2;
              continue;
            case 2:
              goto label_11;
            case 3:
              if (((TypeDescriptionProvider) DeltaExpression.hJO5CbBPoxcjhOh8Ukof()).IsSupportedType(type))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
                continue;
              }
              goto label_6;
            case 4:
              goto label_9;
            case 5:
              goto label_6;
            case 6:
              DeltaExpression.TsWWvCBPvxvHcO7BruWd((object) propertyOrFieldName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051276242 - 990076387 ^ 61139761));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 1 : 1;
              continue;
            case 7:
              DeltaExpression.Tuh1mWBPFbtm6q8n1PiI((object) expression, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408896458));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 6 : 4;
              continue;
            default:
              propertyInfo = (PropertyInfo) DeltaExpression.fOLlYFBPuoYy1HU5NqoF(type, (object) propertyOrFieldName, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 3 : 4;
              continue;
          }
        }
label_9:
        if (!DeltaExpression.d10FL3BPIIcqbRqDrH6Y((object) propertyInfo, (object) null))
          num1 = 2;
        else
          goto label_12;
      }
label_6:
      return (MemberExpression) DeltaExpression.bxUkiCBPZIRFqXhnuQFT((object) expression, (object) propertyOrFieldName);
label_11:
      return (MemberExpression) DeltaExpression.bxUkiCBPZIRFqXhnuQFT((object) expression, (object) propertyOrFieldName);
label_12:
      return (MemberExpression) DeltaExpression.mbFqmBBPVETN3mvrMgHw((object) expression, (object) propertyInfo);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static MemberExpression PropertyInternal(
      object expression,
      System.Type type,
      object propertyName)
    {
      int num = 1;
      PropertyInfo propertyInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
            propertyInfo = (PropertyInfo) DeltaExpression.lMNeyoBPS2SBFWHLl3bq(type, propertyName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            if (DeltaExpression.Va27l1BPioZdRsB1ryoQ((object) propertyInfo, (object) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 2;
              continue;
            }
            goto label_5;
        }
      }
label_4:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) DeltaExpression.I8oRoUBezhdHWuHcZFjF(-53329496 >> 4 ^ -3400942), propertyName, (object) type.FullName));
label_5:
      return (MemberExpression) DeltaExpression.mbFqmBBPVETN3mvrMgHw(expression, (object) propertyInfo);
    }

    internal static bool e92LI6BeYTpeamFNOf2w() => DeltaExpression.cj6KYYBejQXBgV7ZQ0dF == null;

    internal static DeltaExpression vk8phKBeLg9Z9TGZnVrw() => DeltaExpression.cj6KYYBejQXBgV7ZQ0dF;

    internal static object pHWoFsBeUxjDFLSFdHae([In] object obj0) => ((Instruction) obj0).Operand;

    internal static bool kkpPg3BesckTs6vvmlGH([In] object obj0, [In] object obj1) => ((DeltaExpression.InternalMethodInfo) obj0).Equals((MethodReference) obj1);

    internal static void HQhZFQBecA6SlIjYnE6C([In] object obj0, [In] object obj1) => ((Instruction) obj0).Operand = obj1;

    internal static object I8oRoUBezhdHWuHcZFjF(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void Tuh1mWBPFbtm6q8n1PiI([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static bool SZaBbJBPBWv7aPXdpiZw([In] object obj0) => ((MethodBase) obj0).IsStatic;

    internal static object SrT6CvBPWJsD2ERVX9IX([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static object hJO5CbBPoxcjhOh8Ukof() => (object) EntityDynamicProvider.Instance;

    internal static System.Type NVuFbdBPbl52A17PZhMY([In] object obj0) => ((ParameterInfo) obj0).ParameterType;

    internal static bool xFLcOnBPhyHydqAMCtX5([In] object obj0, [In] System.Type obj1) => ((TypeDescriptionProvider) obj0).IsSupportedType(obj1);

    internal static object v6bxG1BPGeHV5aov5kte([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static object xwNFj6BPEWue5XOyjLYe([In] object obj0, System.Type type, [In] object obj2) => (object) DeltaExpression.PropertyInternal(obj0, type, obj2);

    internal static System.Type E0rFFlBPfOb5fO8vGH4b([In] object obj0) => ((MemberInfo) obj0).DeclaringType;

    internal static bool Q93vSWBPQMbIc62D3MD5([In] System.Type obj0, [In] System.Type obj1) => obj0 == obj1;

    internal static System.Type FZZEd8BPCQ5BFwYM4hoR([In] object obj0) => ((Expression) obj0).Type;

    internal static void TsWWvCBPvxvHcO7BruWd([In] object obj0, [In] object obj1) => Contract.ArgumentNotNullOrEmpty((string) obj0, (string) obj1);

    internal static object mBTQ5EBP8EI91jw4hDXP([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (string) obj1);

    internal static object bxUkiCBPZIRFqXhnuQFT([In] object obj0, [In] object obj1) => (object) Expression.PropertyOrField((Expression) obj0, (string) obj1);

    internal static object fOLlYFBPuoYy1HU5NqoF(System.Type type, [In] object obj1, BindingFlags bindingAttr) => (object) type.GetReflectionProperty((string) obj1, bindingAttr);

    internal static bool d10FL3BPIIcqbRqDrH6Y([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 != (PropertyInfo) obj1;

    internal static object mbFqmBBPVETN3mvrMgHw([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (PropertyInfo) obj1);

    internal static object lMNeyoBPS2SBFWHLl3bq(System.Type type, [In] object obj1) => (object) type.GetReflectionProperty((string) obj1);

    internal static bool Va27l1BPioZdRsB1ryoQ([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    /// <summary>Информация о заменяемом методе в IL-коде</summary>
    private sealed class InternalMethodInfo : IEquatable<MethodReference>
    {
      /// <summary>Название метода</summary>
      private readonly object methodName;
      /// <summary>Название типа возвращаемого результа</summary>
      private readonly object returnTypeName;
      /// <summary>Названия типов параметров</summary>
      private readonly IEnumerable<string> paramsTypeName;
      /// <summary>Информация о методе</summary>
      public readonly object MethodInfo;
      private static object rI5OCnQqK668d8NfLi9L;

      /// <summary>Ctor</summary>
      /// <param name="methodName">Название метода</param>
      /// <param name="returnTypeName">Название типа возвращаемого результа</param>
      /// <param name="paramsTypeName">Названия типов параметров</param>
      public InternalMethodInfo(
        string methodName,
        string returnTypeName,
        IEnumerable<string> paramsTypeName,
        MethodInfo methodInfo)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.methodName = (object) methodName;
        this.returnTypeName = (object) returnTypeName;
        this.paramsTypeName = paramsTypeName;
        this.MethodInfo = (object) methodInfo;
      }

      /// <inheritdoc />
      public bool Equals(MethodReference obj)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (obj != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 2:
              goto label_4;
            case 3:
              goto label_12;
            case 4:
              if (!DeltaExpression.InternalMethodInfo.Eq6egWQqnVVm2asXFYJg(this.returnTypeName, (object) obj.ReturnType.Name))
              {
                num = 3;
                continue;
              }
              goto label_9;
            case 5:
              goto label_9;
            default:
              if (DeltaExpression.InternalMethodInfo.Eq6egWQqnVVm2asXFYJg(this.methodName, DeltaExpression.InternalMethodInfo.irxAK8QqkfgfAsXiGSwF((object) obj)))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 4;
                continue;
              }
              goto label_12;
          }
        }
label_4:
        return false;
label_9:
        IEnumerable<string> paramsTypeName = this.paramsTypeName;
        Collection<ParameterDefinition> parameters = obj.Parameters;
        // ISSUE: reference to a compiler-generated field
        Func<ParameterDefinition, string> func = DeltaExpression.InternalMethodInfo.\u003C\u003Ec.\u003C\u003E9__4_0;
        Func<ParameterDefinition, string> selector;
        if (func == null)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          DeltaExpression.InternalMethodInfo.\u003C\u003Ec.\u003C\u003E9__4_0 = selector = (Func<ParameterDefinition, string>) (parameter => (string) DeltaExpression.InternalMethodInfo.\u003C\u003Ec.pwQMJwZvHPaeCOhy336J(DeltaExpression.InternalMethodInfo.\u003C\u003Ec.pk5abPZv6XFErXUWuHDo((object) parameter)));
        }
        else
          goto label_13;
label_11:
        IEnumerable<string> second = parameters.Select<ParameterDefinition, string>(selector);
        return paramsTypeName.SequenceEqual<string>(second);
label_13:
        selector = func;
        goto label_11;
label_12:
        return false;
      }

      internal static object irxAK8QqkfgfAsXiGSwF([In] object obj0) => (object) ((MemberReference) obj0).Name;

      internal static bool Eq6egWQqnVVm2asXFYJg([In] object obj0, [In] object obj1) => ((string) obj0).Equals((string) obj1);

      internal static bool Vv3FqmQqXLEcIoDfBjqb() => DeltaExpression.InternalMethodInfo.rI5OCnQqK668d8NfLi9L == null;

      internal static DeltaExpression.InternalMethodInfo RAKbIfQqTLVUvEZEnvrt() => (DeltaExpression.InternalMethodInfo) DeltaExpression.InternalMethodInfo.rI5OCnQqK668d8NfLi9L;
    }
  }
}
