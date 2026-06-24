// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.TypeExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.NH.Proxy;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Proxy;
using NHibernate.Proxy.DynamicProxy;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.Extensions
{
  public static class TypeExtensions
  {
    internal static readonly Type[] PredefinedTypes;
    private static readonly Func<Type, string, PropertyInfo> getPropertyCached;
    private static readonly Func<Type, string, BindingFlags, PropertyInfo> getPropertyWithBindingFlagsCached;
    private static readonly System.Func<Type, PropertyInfo[]> getPropertiesCached;
    /// <summary>Типы функций</summary>
    private static readonly HashSet<Type> FunctionTypes;
    private static IEnumerable<ITypePropertyExtensionPoint> typePropertyExtensions;
    internal static TypeExtensions yhgJtiGAevwljcsZdAGJ;

    internal static bool IsPredefinedType(this Type type)
    {
      int num = 2;
      Type type1;
      while (true)
      {
        switch (num)
        {
          case 1:
            type1 = type;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
            continue;
          case 2:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated method
      return ((IEnumerable<Type>) TypeExtensions.PredefinedTypes).Any<Type>((System.Func<Type, bool>) (t => TypeExtensions.\u003C\u003Ec__DisplayClass1_0.qtux4R8QQison50jo6EG(t, type1)));
    }

    internal static string FirstSortableProperty(this Type type)
    {
      object source = TypeExtensions.XiV8YTGANEw6bTpQMIH7(type);
      // ISSUE: reference to a compiler-generated field
      System.Func<PropertyInfo, bool> func = TypeExtensions.\u003C\u003Ec.\u003C\u003E9__2_0;
      System.Func<PropertyInfo, bool> predicate;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        TypeExtensions.\u003C\u003Ec.\u003C\u003E9__2_0 = predicate = (System.Func<PropertyInfo, bool>) (property => property.PropertyType.IsPredefinedType());
      }
      else
        goto label_1;
label_3:
      PropertyInfo propertyInfo = ((IEnumerable<PropertyInfo>) source).FirstOrDefault<PropertyInfo>(predicate);
      return !TypeExtensions.Kq06pdGA3kCenFfv31dF((object) propertyInfo, (object) null) ? (string) TypeExtensions.pnWPeyGAajbwsJT2dQUr((object) propertyInfo) : throw new NotSupportedException((string) TypeExtensions.BtJq4uGApa5eJ364GC3o(-1334993905 ^ -1335256667));
label_1:
      predicate = func;
      goto label_3;
    }

    internal static bool IsNullableType(this Type type)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (!type.IsGenericType)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      // ISSUE: type reference
      return type.GetGenericTypeDefinition() == TypeExtensions.smL2k9GADPP32TicHiLn(__typeref (Nullable<>));
label_5:
      return false;
    }

    internal static Type GetNonNullableType(this Type type)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!TypeExtensions.J11aKKGAtRM7sIM2Drsm(type))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return type;
label_5:
      return type.GetGenericArguments()[0];
    }

    /// <summary>Можно ли установить в этот тип значение null</summary>
    /// <param name="type">Тип</param>
    /// <returns></returns>
    public static bool IsAssignableFromNull(this Type type)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!type.IsInterface)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            if (type.IsClass)
            {
              num = 4;
              continue;
            }
            goto case 1;
          case 3:
            if (!type.IsByRef)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 2 : 2;
              continue;
            }
            goto label_3;
          case 4:
            goto label_3;
          case 5:
            goto label_2;
          default:
            // ISSUE: type reference
            if (!TypeExtensions.cBEGC9GAwJdkSZRNtkfl(type, TypeExtensions.smL2k9GADPP32TicHiLn(__typeref (string))))
            {
              num = 5;
              continue;
            }
            goto label_3;
        }
      }
label_2:
      return TypeExtensions.J11aKKGAtRM7sIM2Drsm(type);
label_3:
      return true;
    }

    internal static string GetTypeName(this Type type)
    {
      int num1 = 3;
      string name;
      while (true)
      {
        int num2 = num1;
        Type type1;
        while (true)
        {
          switch (num2)
          {
            case 2:
              name = type1.Name;
              num2 = 5;
              continue;
            case 3:
              goto label_3;
            case 4:
              name += (string) TypeExtensions.BtJq4uGApa5eJ364GC3o(694673736 ^ -23604109 ^ -672125583);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
              continue;
            case 5:
              if (!TypeExtensions.oU0wejGA6Uk1xQxoF083(type, type1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 0;
                continue;
              }
              goto case 4;
            default:
              goto label_5;
          }
        }
label_3:
        type1 = TypeExtensions.ordBKSGA4jmr2Fy38y2i(type);
        num1 = 2;
      }
label_5:
      return name;
    }

    internal static bool IsNumericType(this Type type) => type.GetNumericTypeKind() != 0;

    internal static bool IsSignedIntegralType(this Type type) => type.GetNumericTypeKind() == 2;

    internal static bool IsUnsignedIntegralType(this Type type) => TypeExtensions.DfpENyGAH2LKm1q91vZ1(type) == 3;

    internal static int GetNumericTypeKind(this Type type)
    {
      int num = 3;
      TypeCode typeCode;
      while (true)
      {
        switch (num)
        {
          case 1:
            switch (typeCode)
            {
              case TypeCode.Char:
              case TypeCode.Single:
              case TypeCode.Double:
              case TypeCode.Decimal:
                goto label_6;
              case TypeCode.SByte:
              case TypeCode.Int16:
              case TypeCode.Int32:
              case TypeCode.Int64:
                goto label_7;
              case TypeCode.Byte:
              case TypeCode.UInt16:
              case TypeCode.UInt32:
              case TypeCode.UInt64:
                goto label_8;
              default:
                num = 4;
                continue;
            }
          case 2:
            type = TypeExtensions.ordBKSGA4jmr2Fy38y2i(type);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
            continue;
          case 3:
            if (!TypeExtensions.cBEGC9GAwJdkSZRNtkfl(type, (Type) null))
            {
              num = 2;
              continue;
            }
            goto label_4;
          case 4:
            goto label_9;
          case 5:
            goto label_12;
          case 6:
            goto label_6;
          case 7:
            goto label_4;
          default:
            if (type.IsEnum)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 5 : 3;
              continue;
            }
            typeCode = TypeExtensions.nE2wDjGAAxob0mmmeboZ(type);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 1 : 1;
            continue;
        }
      }
label_4:
      return 0;
label_6:
      return 1;
label_7:
      return 2;
label_8:
      return 3;
label_9:
      return 0;
label_12:
      return 0;
    }

    internal static PropertyInfo GetIndexerPropertyInfo(
      this Type type,
      params Type[] indexerArguments)
    {
      int num = 1;
      Type[] indexerArguments1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            indexerArguments1 = indexerArguments;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 2 : 1;
            continue;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated method
      return ((IEnumerable<PropertyInfo>) TypeExtensions.XiV8YTGANEw6bTpQMIH7(type)).Where<PropertyInfo>((System.Func<PropertyInfo, bool>) (p => TypeExtensions.AreArgumentsApplicable((IEnumerable<Type>) indexerArguments1, (IEnumerable<ParameterInfo>) TypeExtensions.\u003C\u003Ec__DisplayClass11_0.f1fF8I8Qicc0tr48qPUj((object) p)))).FirstOrDefault<PropertyInfo>();
    }

    private static bool AreArgumentsApplicable(
      IEnumerable<Type> arguments,
      IEnumerable<ParameterInfo> parameters)
    {
      List<Type> list1 = arguments.ToList<Type>();
      List<ParameterInfo> list2 = parameters.ToList<ParameterInfo>();
      if (list1.Count != list2.Count)
        return false;
      for (int index = 0; index < list1.Count; ++index)
      {
        if (list2[index].ParameterType != list1[index])
          return false;
      }
      return true;
    }

    internal static bool IsEnumType(this Type type) => type.GetNonNullableType().IsEnum;

    internal static bool IsCompatibleWith(this Type source, Type target)
    {
      int num1 = 11;
      while (true)
      {
        int num2 = num1;
        TypeCode typeCode1;
        Type nonNullableType;
        while (true)
        {
          Type type;
          TypeCode typeCode2;
          int num3;
          int num4;
          switch (num2)
          {
            case 1:
            case 6:
            case 9:
            case 25:
            case 33:
            case 34:
              goto label_51;
            case 2:
              goto label_26;
            case 3:
              goto label_44;
            case 4:
              goto label_39;
            case 5:
              goto label_16;
            case 7:
              switch (typeCode2)
              {
                case TypeCode.SByte:
                  goto label_29;
                case TypeCode.Byte:
                  switch (typeCode1)
                  {
                    case TypeCode.Byte:
                    case TypeCode.Int16:
                    case TypeCode.UInt16:
                    case TypeCode.Int32:
                    case TypeCode.UInt32:
                    case TypeCode.Int64:
                    case TypeCode.UInt64:
                    case TypeCode.Single:
                    case TypeCode.Double:
                    case TypeCode.Decimal:
                      num2 = 14;
                      continue;
                    default:
                      goto label_51;
                  }
                case TypeCode.Int16:
                  switch (typeCode1)
                  {
                    case TypeCode.Int16:
                    case TypeCode.Int32:
                    case TypeCode.Int64:
                    case TypeCode.Single:
                    case TypeCode.Double:
                    case TypeCode.Decimal:
                      goto label_3;
                    case TypeCode.UInt16:
                    case TypeCode.UInt32:
                    case TypeCode.UInt64:
                      goto label_51;
                    default:
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 1 : 0;
                      continue;
                  }
                case TypeCode.UInt16:
                  switch (typeCode1)
                  {
                    case TypeCode.UInt16:
                    case TypeCode.Int32:
                    case TypeCode.UInt32:
                    case TypeCode.Int64:
                    case TypeCode.UInt64:
                    case TypeCode.Single:
                    case TypeCode.Double:
                    case TypeCode.Decimal:
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 3;
                      continue;
                    default:
                      goto label_51;
                  }
                case TypeCode.Int32:
                  switch (typeCode1)
                  {
                    case TypeCode.Int32:
                    case TypeCode.Int64:
                    case TypeCode.Single:
                    case TypeCode.Double:
                    case TypeCode.Decimal:
                      goto label_16;
                    case TypeCode.UInt32:
                    case TypeCode.UInt64:
                      goto label_51;
                    default:
                      num2 = 25;
                      continue;
                  }
                case TypeCode.UInt32:
                  goto label_17;
                case TypeCode.Int64:
                  if (typeCode1 != TypeCode.Int64)
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 23 : 6;
                    continue;
                  }
                  goto label_11;
                case TypeCode.UInt64:
                  switch (typeCode1)
                  {
                    case TypeCode.UInt64:
                    case TypeCode.Single:
                    case TypeCode.Double:
                    case TypeCode.Decimal:
                      goto label_26;
                    default:
                      num2 = 6;
                      continue;
                  }
                case TypeCode.Single:
                  switch (typeCode1)
                  {
                    case TypeCode.Single:
                    case TypeCode.Double:
                      num2 = 22;
                      continue;
                    default:
                      goto label_51;
                  }
                default:
                  num2 = 19;
                  continue;
              }
            case 8:
              goto label_11;
            case 10:
              if (target.IsValueType)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 13 : 29;
                continue;
              }
              goto label_14;
            case 11:
              if (!TypeExtensions.cBEGC9GAwJdkSZRNtkfl(source, target))
              {
                num2 = 10;
                continue;
              }
              goto label_39;
            case 12:
            case 18:
              if (nonNullableType.IsEnum)
              {
                num2 = 13;
                continue;
              }
              goto default;
            case 13:
              num3 = 1;
              break;
            case 14:
              goto label_47;
            case 15:
              goto label_19;
            case 16:
              goto label_50;
            case 17:
label_29:
              switch (typeCode1)
              {
                case TypeCode.SByte:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.Single:
                case TypeCode.Double:
                case TypeCode.Decimal:
                  goto label_54;
                case TypeCode.Byte:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                  goto label_51;
                default:
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 34 : 30;
                  continue;
              }
            case 19:
              if (TypeExtensions.cBEGC9GAwJdkSZRNtkfl(nonNullableType, type))
              {
                num2 = 16;
                continue;
              }
              goto label_51;
            case 20:
              goto label_14;
            case 21:
              if (!TypeExtensions.cBEGC9GAwJdkSZRNtkfl(type, target))
              {
                num2 = 18;
                continue;
              }
              goto label_19;
            case 22:
              goto label_6;
            case 23:
              switch (typeCode1)
              {
                case TypeCode.Single:
                case TypeCode.Double:
                case TypeCode.Decimal:
                  goto label_11;
                default:
                  num2 = 9;
                  continue;
              }
            case 24:
              type = TypeExtensions.ordBKSGA4jmr2Fy38y2i(target);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 12 : 26;
              continue;
            case 26:
              if (!(nonNullableType != source))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 9 : 12;
                continue;
              }
              goto case 21;
            case 27:
              goto label_54;
            case 28:
              goto label_22;
            case 29:
              goto label_15;
            case 30:
              if (!type.IsEnum)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 32 : 14;
                continue;
              }
              num4 = 1;
              goto label_60;
            case 31:
              goto label_3;
            case 32:
              num4 = (int) TypeExtensions.nE2wDjGAAxob0mmmeboZ(type);
              goto label_60;
            default:
              num3 = (int) TypeExtensions.nE2wDjGAAxob0mmmeboZ(nonNullableType);
              break;
          }
          typeCode2 = (TypeCode) num3;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 18 : 30;
          continue;
label_60:
          typeCode1 = (TypeCode) num4;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 2 : 7;
        }
label_15:
        nonNullableType = source.GetNonNullableType();
        num1 = 24;
        continue;
label_17:
        switch (typeCode1)
        {
          case TypeCode.UInt32:
          case TypeCode.Int64:
          case TypeCode.UInt64:
          case TypeCode.Single:
          case TypeCode.Double:
          case TypeCode.Decimal:
            goto label_22;
          default:
            num1 = 33;
            continue;
        }
      }
label_3:
      return true;
label_6:
      return true;
label_11:
      return true;
label_14:
      return target.IsAssignableFrom(source);
label_16:
      return true;
label_19:
      return false;
label_22:
      return true;
label_26:
      return true;
label_39:
      return true;
label_44:
      return true;
label_47:
      return true;
label_50:
      return true;
label_51:
      return false;
label_54:
      return true;
    }

    public static PropertyInfo GetPropertyFor<TType, TValue>(
      this Type typeObject,
      [NotNull] Expression<System.Func<TType, TValue>> propertyExpression)
    {
      if (propertyExpression == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1406092199));
      if (!(propertyExpression.Body is MemberExpression body) || (object) (body.Member as PropertyInfo) == null)
        throw new ArgumentException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1012087039 ^ 1012350699)));
      return (PropertyInfo) body.Member;
    }

    /// <summary>
    /// Получить информацию о свойстве с кешированием результата
    /// </summary>
    /// <param name="typeObject">Тип объекта</param>
    /// <param name="propertyName">Имя свойства</param>
    /// <param name="bindingAttr">Флаги, отвечающие за отображение в типе</param>
    /// <returns>Информация о свойстве</returns>
    internal static PropertyInfo GetPropertyCached(
      [NotNull] this Type typeObject,
      [NotNull] string propertyName,
      BindingFlags bindingAttr)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TypeExtensions.H8EWG7GA7U93mfT0707H((object) typeObject, TypeExtensions.BtJq4uGApa5eJ364GC3o(-1146510045 ^ -1146248369));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            Contract.ArgumentNotNullOrEmpty(propertyName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 87921249));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 2 : 2;
            continue;
        }
      }
label_2:
      return TypeExtensions.getPropertyWithBindingFlagsCached(typeObject, propertyName, bindingAttr);
    }

    public static PropertyInfo GetPropertyCached([NotNull] this Type typeObject, [NotNull] string propertyName)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (propertyName != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            if (!TypeExtensions.cBEGC9GAwJdkSZRNtkfl(typeObject, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          case 3:
            goto label_4;
          case 4:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 1867304753));
label_3:
      return TypeExtensions.getPropertyCached(typeObject, propertyName);
label_4:
      throw new ArgumentNullException((string) TypeExtensions.BtJq4uGApa5eJ364GC3o(--1418440330 ^ 1418701030));
    }

    public static PropertyInfo[] GetPropertiesCached([NotNull] this Type typeObject)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (TypeExtensions.cBEGC9GAwJdkSZRNtkfl(typeObject, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      throw new ArgumentNullException((string) TypeExtensions.BtJq4uGApa5eJ364GC3o(1253244298 - 1829393894 ^ -575888952));
label_3:
      return TypeExtensions.getPropertiesCached(typeObject);
    }

    public static Type FindGenericType(this Type type, Type genericType)
    {
      int num = 11;
      Type genericType1;
      int index;
      Type[] interfaces;
      while (true)
      {
        switch (num)
        {
          case 1:
            type = type.BaseType;
            num = 7;
            continue;
          case 2:
          case 6:
            genericType1 = TypeExtensions.gCEJdMGAxXpuL6tCFvL9(interfaces[index], genericType);
            num = 16;
            continue;
          case 3:
            ++index;
            num = 17;
            continue;
          case 4:
            if (type.GetGenericTypeDefinition() == genericType)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 12 : 2;
              continue;
            }
            goto case 15;
          case 5:
            index = 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 13 : 10;
            continue;
          case 7:
          case 11:
            if (TypeExtensions.oU0wejGA6Uk1xQxoF083(type, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 8 : 5;
              continue;
            }
            goto label_6;
          case 8:
            // ISSUE: type reference
            if (!(type != TypeExtensions.smL2k9GADPP32TicHiLn(__typeref (object))))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 14 : 1;
              continue;
            }
            goto case 10;
          case 9:
            goto label_2;
          case 10:
            if (!type.IsGenericType)
            {
              num = 15;
              continue;
            }
            goto case 4;
          case 12:
            goto label_11;
          case 13:
          case 17:
            if (index < interfaces.Length)
            {
              num = 2;
              continue;
            }
            goto case 1;
          case 14:
            goto label_6;
          case 15:
            if (genericType.IsInterface)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
              continue;
            }
            goto case 1;
          case 16:
            if (!TypeExtensions.oU0wejGA6Uk1xQxoF083(genericType1, (Type) null))
            {
              num = 3;
              continue;
            }
            goto label_2;
          default:
            interfaces = type.GetInterfaces();
            num = 5;
            continue;
        }
      }
label_2:
      return genericType1;
label_6:
      return (Type) null;
label_11:
      return type;
    }

    internal static string GetName(this Type type) => (string) TypeExtensions.BkXAMuGAmca9Lvf3mBZs((object) type.FullName, TypeExtensions.VhosKoGA0yq75QqaG88B((object) type.Namespace, TypeExtensions.BtJq4uGApa5eJ364GC3o(--1333735954 ^ 1333733590)), (object) "");

    /// <summary>Получить значение по умолчанию для типа</summary>
    /// <param name="type">Тип</param>
    public static object DefaultValue(this Type type)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!type.IsValueType)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
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
      return TypeExtensions.tAbrcAGAydmxyfmLE2N4(type);
label_3:
      return (object) null;
    }

    /// <summary>
    /// Получить значение по умолчанию для идентификатора типа
    /// </summary>
    /// <param name="type">Тип</param>
    /// <param name="idType">Тип идентификатора</param>
    public static object DefaultIdentifierValue(this Type type, Type idType)
    {
      int num = 1;
      ITypePropertyExtensionPoint propertyExtension;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!idType.IsValueType)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
              continue;
            }
            goto label_8;
          case 2:
            goto label_8;
          case 3:
            if (propertyExtension == null)
            {
              num = 4;
              continue;
            }
            goto label_7;
          case 4:
            goto label_6;
          default:
            propertyExtension = TypeExtensions.GetTypePropertyExtension(type);
            num = 3;
            continue;
        }
      }
label_6:
      return (object) null;
label_7:
      return TypeExtensions.GL6oCeGAMDKnFoLKFiFo((object) propertyExtension, type, idType, true);
label_8:
      return TypeExtensions.tAbrcAGAydmxyfmLE2N4(idType);
    }

    /// <summary>
    /// Проверяет, является ли значение идентификатора значением по умолчанию
    /// </summary>
    /// <param name="type">Тип для которого осуществляется проверка</param>
    /// <param name="idType">Тип идентификатора</param>
    /// <param name="idValue">Значение идентификатора</param>
    public static bool IsDefaultId(this Type type, Type idType, object idValue)
    {
      int num = 3;
      ITypePropertyExtensionPoint propertyExtensionPoint;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (idValue == null)
            {
              num = 4;
              continue;
            }
            goto label_2;
          case 2:
            if (propertyExtensionPoint == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 1 : 0;
              continue;
            }
            goto label_4;
          case 3:
            propertyExtensionPoint = (ITypePropertyExtensionPoint) TypeExtensions.O89GUqGAJAIQg9w0buIG(type);
            num = 2;
            continue;
          case 4:
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return Convert.ToInt64(idValue) == 0L;
label_3:
      return true;
label_4:
      return TypeExtensions.ICUCE6GA93ucJUpZu8h5((object) propertyExtensionPoint, type, idType, idValue);
    }

    /// <summary>
    /// Конвертирует значение идентификатора в числовое для проверки на значение по умолчанию
    /// </summary>
    /// <param name="type">Тип сущности</param>
    /// <param name="idType">Тип идентификатора</param>
    /// <param name="idValue">Значение идентификатора</param>
    private static long ConvertToNewId(this Type type, Type idType, object idValue)
    {
      int num = 2;
      ITypePropertyExtensionPoint propertyExtension;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            if (!TypeExtensions.AaFS5eGAdOcd9buB7j3B(type, idType, idValue))
            {
              propertyExtension = TypeExtensions.GetTypePropertyExtension(type);
              num = 4;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_9;
          case 4:
            if (propertyExtension != null)
            {
              num = 3;
              continue;
            }
            goto label_8;
          default:
            goto label_8;
        }
      }
label_4:
      return 0;
label_8:
      return TypeExtensions.KekYNwGAlrx8dfYqfExn(idValue);
label_9:
      return propertyExtension.ConvertToNewId(type, idType, idValue);
    }

    /// <summary>
    /// Конвертировать целочисленный идентификатор в идентификатор типа
    /// </summary>
    /// <param name="type">Тип сущности</param>
    /// <param name="idType">Тип идентификатора</param>
    /// <param name="id">Целочисленное значение идентификатора</param>
    public static object ConvertId(this Type type, Type idType, object id)
    {
      int num = 2;
      ITypePropertyExtensionPoint propertyExtensionPoint;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 4:
            propertyExtensionPoint = (ITypePropertyExtensionPoint) TypeExtensions.O89GUqGAJAIQg9w0buIG(type);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
            continue;
          case 2:
            if (id != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 1 : 1;
              continue;
            }
            goto case 3;
          case 3:
            id = TypeExtensions.kP8jBHGAr4Te5pcUWRVm(type, idType);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 4 : 1;
            continue;
          case 5:
            goto label_3;
          case 6:
            goto label_2;
          default:
            if (propertyExtensionPoint != null)
            {
              num = 5;
              continue;
            }
            goto label_2;
        }
      }
label_2:
      return Convert.ChangeType(id, idType);
label_3:
      return TypeExtensions.cWK2E1GAgYilLCCd7cFw((object) propertyExtensionPoint, type, idType, id);
    }

    /// <summary>
    /// Проверяет, является ли значение идентификатора новым значением
    /// </summary>
    /// <param name="type">Тип сущности</param>
    /// <param name="idType">Тип идентификатора</param>
    /// <param name="idValue">Значение идентификатора</param>
    public static bool IsNewId(this Type type, Type idType, object idValue) => type.ConvertToNewId(idType, idValue) <= 0L;

    internal static MemberInfo FindPropertyOrField(this Type type, string memberName)
    {
      int num = 1;
      object propertyOrField;
      while (true)
      {
        switch (num)
        {
          case 1:
            propertyOrField = TypeExtensions.DC7BFMGA5dLCqkDMR6nD(type, (object) memberName, false);
            if (propertyOrField == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_5;
        }
      }
label_2:
      return (MemberInfo) propertyOrField;
label_5:
      return (MemberInfo) TypeExtensions.DC7BFMGA5dLCqkDMR6nD(type, (object) memberName, true);
    }

    internal static MemberInfo FindPropertyOrField(
      this Type type,
      string memberName,
      bool staticAccess)
    {
      int num1 = 2;
      IEnumerator<Type> enumerator;
      BindingFlags bindingAttr;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator = type.SelfAndBaseTypes().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 3 : 1;
            continue;
          case 2:
            bindingAttr = (BindingFlags) (18 | (!staticAccess ? 4 : 8));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_5;
          default:
            goto label_3;
        }
      }
label_3:
      return (MemberInfo) null;
label_5:
      MemberInfo propertyOrField;
      try
      {
label_7:
        if (enumerator.MoveNext())
          goto label_12;
        else
          goto label_8;
label_6:
        MemberInfo[] members;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              propertyOrField = members[0];
              num2 = 3;
              continue;
            case 3:
              goto label_4;
            case 4:
              if (members.Length != 0)
              {
                num2 = 2;
                continue;
              }
              goto label_7;
            case 5:
              goto label_7;
            default:
              goto label_12;
          }
        }
label_8:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 1 : 1;
        goto label_6;
label_12:
        members = enumerator.Current.FindMembers(MemberTypes.Field | MemberTypes.Property, bindingAttr, Type.FilterNameIgnoreCase, (object) memberName);
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
        {
          num2 = 4;
          goto label_6;
        }
        else
          goto label_6;
      }
      finally
      {
        int num3;
        if (enumerator == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 1 : 1;
        else
          goto label_17;
label_16:
        switch (num3)
        {
          case 2:
            break;
          default:
        }
label_17:
        TypeExtensions.cGJrr8GAj7WYi6vBIAwA((object) enumerator);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
        {
          num3 = 0;
          goto label_16;
        }
        else
          goto label_16;
      }
label_4:
      return propertyOrField;
    }

    internal static IEnumerable<Type> SelfAndBaseTypes(this Type type)
    {
      if (!type.IsInterface)
        return type.SelfAndBaseClasses();
      List<Type> types = new List<Type>();
      TypeExtensions.AddInterface(types, type);
      return (IEnumerable<Type>) types;
    }

    internal static IEnumerable<Type> SelfAndBaseClasses(this Type type) => (IEnumerable<Type>) new TypeExtensions.\u003CSelfAndBaseClasses\u003Ed__33(-2)
    {
      \u003C\u003E3__type = type
    };

    private static void AddInterface(List<Type> types, Type type)
    {
      if (types.Contains(type))
        return;
      types.Add(type);
      foreach (Type type1 in type.GetInterfaces())
        TypeExtensions.AddInterface(types, type1);
    }

    internal static bool IsDataRow(this Type type)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            // ISSUE: type reference
            if (TypeExtensions.OMi2tLGAYKqyZE9qZq1O(type, TypeExtensions.smL2k9GADPP32TicHiLn(__typeref (DataRow))))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      // ISSUE: type reference
      return TypeExtensions.OMi2tLGAYKqyZE9qZq1O(type, TypeExtensions.smL2k9GADPP32TicHiLn(__typeref (DataRowView)));
label_5:
      return true;
    }

    internal static bool IsDateTime(this Type type)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: type reference
            if (!TypeExtensions.cBEGC9GAwJdkSZRNtkfl(type, TypeExtensions.smL2k9GADPP32TicHiLn(__typeref (DateTime))))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      // ISSUE: type reference
      return TypeExtensions.cBEGC9GAwJdkSZRNtkfl(type, TypeExtensions.smL2k9GADPP32TicHiLn(__typeref (DateTime?)));
label_3:
      return true;
    }

    public static string ToJavaScriptType(this Type type)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (TypeExtensions.cBEGC9GAwJdkSZRNtkfl(type, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
              continue;
            }
            if (!type.IsNumericType())
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 1 : 12;
              continue;
            }
            goto label_16;
          case 2:
          case 4:
            goto label_7;
          case 3:
            goto label_22;
          case 5:
            goto label_16;
          case 6:
            if (!(type == typeof (string)))
            {
              // ISSUE: type reference
              if (!(type == TypeExtensions.smL2k9GADPP32TicHiLn(__typeref (bool))))
              {
                num = 7;
                continue;
              }
              goto label_22;
            }
            else
            {
              num = 10;
              continue;
            }
          case 7:
            // ISSUE: type reference
            if (!TypeExtensions.cBEGC9GAwJdkSZRNtkfl(type, TypeExtensions.smL2k9GADPP32TicHiLn(__typeref (bool?))))
            {
              num = 8;
              continue;
            }
            goto label_22;
          case 8:
            if (type.IsEnum)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 8 : 11;
              continue;
            }
            goto label_6;
          case 9:
            // ISSUE: type reference
            if (!TypeExtensions.cBEGC9GAwJdkSZRNtkfl(type, TypeExtensions.smL2k9GADPP32TicHiLn(__typeref (DateTime?))))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 5 : 6;
              continue;
            }
            goto label_7;
          case 10:
            goto label_2;
          case 11:
            goto label_5;
          case 12:
            // ISSUE: type reference
            if (type == TypeExtensions.smL2k9GADPP32TicHiLn(__typeref (DateTime)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 2;
              continue;
            }
            goto case 9;
          default:
            goto label_19;
        }
      }
label_2:
      return (string) TypeExtensions.BtJq4uGApa5eJ364GC3o(1142330761 ^ 1541959139 ^ 536716966);
label_5:
      return (string) TypeExtensions.BtJq4uGApa5eJ364GC3o(-398663332 ^ -398923780);
label_6:
      return (string) TypeExtensions.BtJq4uGApa5eJ364GC3o(1505778440 - 1981636111 ^ -475893347);
label_7:
      return (string) TypeExtensions.BtJq4uGApa5eJ364GC3o(-1255365154 ^ 596875508 ^ -1766114370);
label_16:
      return (string) TypeExtensions.BtJq4uGApa5eJ364GC3o(-1886646897 ^ -1886909685);
label_19:
      return (string) TypeExtensions.BtJq4uGApa5eJ364GC3o(-2138160520 ^ -2138124516);
label_22:
      return (string) TypeExtensions.BtJq4uGApa5eJ364GC3o(-710283084 ^ -537863435 ^ 173700169);
    }

    public static bool IsProxy(this Type type)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!TypeExtensions.oU0wejGA6Uk1xQxoF083(type.GetInterface(typeof (INHibernateProxy).FullName), (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            if (!type.IsInheritOrSame<IEntityProxy>())
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      // ISSUE: type reference
      return TypeExtensions.oU0wejGA6Uk1xQxoF083(type.GetInterface(TypeExtensions.smL2k9GADPP32TicHiLn(__typeref (IProxy)).FullName), (Type) null);
label_3:
      return true;
    }

    /// <summary>Получить метод в реализации по методу интерфейса</summary>
    /// <param name="type">Тип реализации интерфейса</param>
    /// <param name="interfaceMethod">Метод интерфейса</param>
    public static MethodInfo GetImlementationMethodInfoFromInterface(
      this Type type,
      MethodInfo interfaceMethod)
    {
      int num1 = 1;
      InterfaceMapping interfaceMap;
      int index;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              TypeExtensions.H8EWG7GA7U93mfT0707H((object) interfaceMethod, TypeExtensions.BtJq4uGApa5eJ364GC3o(572119659 - -337058038 ^ 909440461));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_6;
            case 3:
              if (index == -1)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 2 : 2;
                continue;
              }
              goto label_7;
            case 4:
              index = Array.IndexOf<MethodInfo>(interfaceMap.InterfaceMethods, interfaceMethod);
              num2 = 3;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        interfaceMap = type.GetInterfaceMap(interfaceMethod.DeclaringType);
        num1 = 4;
      }
label_6:
      throw new Exception(EleWise.ELMA.SR.T((string) TypeExtensions.BtJq4uGApa5eJ364GC3o(-1204263869 ^ -1341583247 ^ 137720572), (object) interfaceMethod.Name, (object) type.FullName));
label_7:
      return interfaceMap.TargetMethods[index];
    }

    /// <summary>
    /// Является ли тип простым?
    /// Тип считается простым, если он примитивный, строка или Guid.
    /// </summary>
    /// <param name="type">Проверяемый тип</param>
    /// <returns>true, если тип простой.</returns>
    public static bool IsSimpleType(this Type type)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (type.IsPrimitive)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            case 2:
              goto label_3;
            case 3:
              goto label_5;
            default:
              goto label_6;
          }
        }
label_3:
        // ISSUE: type reference
        if (!(type == TypeExtensions.smL2k9GADPP32TicHiLn(__typeref (string))))
          num1 = 3;
        else
          goto label_6;
      }
label_5:
      // ISSUE: type reference
      return TypeExtensions.cBEGC9GAwJdkSZRNtkfl(type, TypeExtensions.smL2k9GADPP32TicHiLn(__typeref (Guid)));
label_6:
      return true;
    }

    /// <summary>
    /// Является ли тип перечислением?
    /// <para>!!! string тоже будет перечислением!</para>
    /// </summary>
    /// <param name="type">Проверяемый тип</param>
    /// <returns>true, если тип является перечислением.</returns>
    public static bool IsEnumerable(this Type type) => TypeExtensions.smL2k9GADPP32TicHiLn(__typeref (IEnumerable)).IsAssignableFrom(type);

    /// <summary>
    /// Является ли тип перечислением простого типа?
    /// <para>!!! string тоже будет перечислением!</para>
    /// </summary>
    /// <param name="type">Проверяемый тип</param>
    /// <returns>true, если тип является перечислением простого типа</returns>
    public static bool IsEnumerableOfSimpleType(this Type type)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (TypeExtensions.roWpWyGALPEWM4GI6mwT(type))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return ((IEnumerable<Type>) type.GetGenericArguments()).All<Type>(new System.Func<Type, bool>(TypeExtensions.IsSimpleType));
label_5:
      return false;
    }

    /// <summary>Является ли тип объектом с идентфиикатором</summary>
    /// <param name="type">Проверяемый тип</param>
    /// <returns><c>true</c>, если тип реализует интерфейс IIdentified</returns>
    public static bool IsIdentifiedType(this Type type)
    {
      int num = 2;
      Type identifiedType;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: type reference
            identifiedType = TypeExtensions.smL2k9GADPP32TicHiLn(__typeref (IIdentified));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
            continue;
          case 2:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 1 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return IntrospectionExtensions.GetTypeInfo(type).ImplementedInterfaces.Any<Type>((System.Func<Type, bool>) (@interface => @interface.Equals(identifiedType)));
    }

    /// <summary>Реализует ли тип дженериковый интерфейс</summary>
    /// <param name="type">Проверяемый тип</param>
    /// <param name="interfaceType">Тип интерфейса</param>
    /// <returns><c>true</c>, если тип реализует указанный дженериковый интерфейс</returns>
    public static bool ImplementsGenericInterface(this Type type, Type interfaceType)
    {
      int num1 = 1;
      Type interfaceType1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
            continue;
          case 2:
          case 6:
            goto label_2;
          case 3:
            goto label_3;
          case 4:
            if (TypeExtensions.cBEGC9GAwJdkSZRNtkfl(type.GetGenericTypeDefinition(), interfaceType1))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 3 : 2;
              continue;
            }
            goto label_2;
          case 5:
            if (!type.IsGenericType)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 2 : 0;
              continue;
            }
            goto case 4;
          default:
            interfaceType1 = interfaceType;
            num1 = 5;
            continue;
        }
      }
label_2:
      return ((TypeInfo) TypeExtensions.Daj1llGAUomDUhHFHagW(type)).ImplementedInterfaces.Any<Type>((System.Func<Type, bool>) (@interface =>
      {
        int num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (@interface.IsGenericType)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_2;
          }
        }
label_2:
        // ISSUE: reference to a compiler-generated method
        return TypeExtensions.\u003C\u003Ec__DisplayClass44_0.lgPQwr8QN8Sbm7iNgT9U(@interface.GetGenericTypeDefinition(), interfaceType1);
label_3:
        return false;
      }));
label_3:
      return true;
    }

    /// <summary>Получить список базовых классов</summary>
    /// <param name="type">Тип для которого необходимо получить список базовых классов</param>
    /// <returns>Список базовых классов</returns>
    public static IEnumerable<Type> GetBaseClasses(this Type type)
    {
      Contract.ArgumentNotNull((object) type, z2jc63fLkugS1X8Q9N.tE1kD1vbB(323422137 << 2 ^ 1293685446));
      if (type.IsInterface)
        return Enumerable.Empty<Type>();
      List<Type> baseClasses = new List<Type>();
      for (Type baseType = type.BaseType; baseType != (Type) null; baseType = baseType.BaseType)
        baseClasses.Add(baseType);
      return (IEnumerable<Type>) baseClasses;
    }

    /// <summary>
    /// Признак, что тип является <see cref="T:System.Threading.Tasks.Task" /> или <see cref="T:System.Threading.Tasks.Task`1" /> или <see cref="T:System.Threading.Tasks.ValueTask" /> или <see cref="T:System.Threading.Tasks.ValueTask`1" />
    /// </summary>
    /// <param name="type">Проверяемый тип</param>
    /// <returns><c>true</c> если является</returns>
    public static bool IsAsync(this Type type)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        Type genericTypeDefinition;
        while (true)
        {
          int num3;
          switch (num2)
          {
            case 1:
              if (!TypeExtensions.cBEGC9GAwJdkSZRNtkfl(type, TypeOf<Task>.Raw))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
                continue;
              }
              num3 = 1;
              break;
            case 2:
            case 4:
              goto label_9;
            case 3:
              goto label_8;
            case 5:
              goto label_11;
            case 6:
              if (type.IsGenericType)
              {
                num2 = 3;
                continue;
              }
              goto label_10;
            case 7:
              if (TypeExtensions.cBEGC9GAwJdkSZRNtkfl(genericTypeDefinition, TypeExtensions.otKWuHGAsaIaAEgRfdTS((object) TypeOf.Task1)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 4 : 4;
                continue;
              }
              goto case 8;
            case 8:
              if (TypeExtensions.cBEGC9GAwJdkSZRNtkfl(genericTypeDefinition, TypeExtensions.otKWuHGAsaIaAEgRfdTS((object) TypeOf.ValueTask1)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 2 : 1;
                continue;
              }
              goto label_10;
            default:
              num3 = TypeExtensions.cBEGC9GAwJdkSZRNtkfl(type, TypeOf<ValueTask>.Raw) ? 1 : 0;
              break;
          }
          if (num3 == 0)
            num2 = 6;
          else
            goto label_11;
        }
label_8:
        genericTypeDefinition = type.GetGenericTypeDefinition();
        num1 = 7;
      }
label_9:
      return true;
label_10:
      return false;
label_11:
      return true;
    }

    /// <summary>Является ли тип функцией</summary>
    /// <param name="type">Тип</param>
    /// <returns><c>true</c>, если тип является функцией</returns>
    public static bool IsFunc(this Type type)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!TypeExtensions.FunctionTypes.Contains(type))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            goto label_5;
          case 3:
            goto label_4;
          default:
            if (!type.IsGenericType)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 2;
              continue;
            }
            goto label_4;
        }
      }
label_4:
      return TypeExtensions.FunctionTypes.Contains(type.GetGenericTypeDefinition());
label_5:
      return false;
label_6:
      return true;
    }

    private static ITypePropertyExtensionPoint GetTypePropertyExtension(Type type)
    {
      int num1 = 2;
      Type type1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_7;
            case 2:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 1;
              continue;
            case 3:
              TypeExtensions.typePropertyExtensions = ((ComponentManager) TypeExtensions.mAldGGGAc9kD2msfeNvC()).GetExtensionPoints<ITypePropertyExtensionPoint>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
              continue;
            case 4:
              if (TypeExtensions.typePropertyExtensions == null)
              {
                num2 = 3;
                continue;
              }
              goto label_6;
            default:
              goto label_6;
          }
        }
label_7:
        type1 = type;
        num1 = 4;
      }
label_6:
      // ISSUE: reference to a compiler-generated method
      return TypeExtensions.typePropertyExtensions.FirstOrDefault<ITypePropertyExtensionPoint>((System.Func<ITypePropertyExtensionPoint, bool>) (ext => TypeExtensions.\u003C\u003Ec__DisplayClass50_0.d9vZHM8QtRY9uvmT0fnH((object) ext, type1)));
    }

    static TypeExtensions()
    {
      int num = 12;
      ParameterExpression parameterExpression3;
      ParameterExpression parameterExpression4;
      ParameterExpression parameterExpression5;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            parameterExpression3 = Expression.Parameter(typeof (BindingFlags), (string) TypeExtensions.BtJq4uGApa5eJ364GC3o(-1939377524 ^ -1939638864));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 3 : 1;
            continue;
          case 3:
            // ISSUE: method reference
            TypeExtensions.getPropertyWithBindingFlagsCached = MetadataLoader.UseCachingForFunc<Type, string, BindingFlags, PropertyInfo>(Expression.Lambda<Func<Type, string, BindingFlags, PropertyInfo>>((Expression) TypeExtensions.kIpllBG7Wdfk4GFaaDxY((object) null, (object) (MethodInfo) TypeExtensions.DismAWG7BphmQflNXHmR(__methodref (GetReflectionTypeHelper.GetReflectionProperty)), (object) new Expression[3]
            {
              (Expression) parameterExpression5,
              (Expression) parameterExpression4,
              (Expression) parameterExpression3
            }), parameterExpression5, parameterExpression4, parameterExpression3));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 1 : 4;
            continue;
          case 4:
            parameterExpression3 = (ParameterExpression) TypeExtensions.LCrabIG7FYXPCGM7k0dI(typeof (Type), TypeExtensions.BtJq4uGApa5eJ364GC3o(-1146510045 ^ -1146509055));
            num = 7;
            continue;
          case 5:
            parameterExpression4 = Expression.Parameter(typeof (string), (string) TypeExtensions.BtJq4uGApa5eJ364GC3o(-1852837372 ^ -1852834286));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 2;
            continue;
          case 6:
            // ISSUE: type reference
            parameterExpression5 = (ParameterExpression) TypeExtensions.LCrabIG7FYXPCGM7k0dI(TypeExtensions.smL2k9GADPP32TicHiLn(__typeref (string)), TypeExtensions.BtJq4uGApa5eJ364GC3o(979449278 ^ 979450280));
            num = 10;
            continue;
          case 7:
            // ISSUE: method reference
            TypeExtensions.getPropertiesCached = MetadataLoader.UseCachingForFunc<Type, PropertyInfo[]>(Expression.Lambda<System.Func<Type, PropertyInfo[]>>((Expression) TypeExtensions.kIpllBG7Wdfk4GFaaDxY((object) null, (object) (MethodInfo) TypeExtensions.DismAWG7BphmQflNXHmR(__methodref (GetReflectionTypeHelper.GetReflectionProperties)), (object) new Expression[1]
            {
              (Expression) parameterExpression3
            }), parameterExpression3));
            num = 9;
            continue;
          case 8:
            // ISSUE: type reference
            parameterExpression5 = (ParameterExpression) TypeExtensions.LCrabIG7FYXPCGM7k0dI(TypeExtensions.smL2k9GADPP32TicHiLn(__typeref (Type)), TypeExtensions.BtJq4uGApa5eJ364GC3o(-542721635 ^ -542722625));
            num = 5;
            continue;
          case 9:
            TypeExtensions.FunctionTypes = new HashSet<Type>()
            {
              TypeOf.Func1.Raw,
              TypeOf.Func2.Raw,
              TypeOf.Func3.Raw
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 1 : 0;
            continue;
          case 10:
            TypeExtensions.getPropertyCached = MetadataLoader.UseCachingForFunc<Type, string, PropertyInfo>((Expression<Func<Type, string, PropertyInfo>>) ((parameterExpression1, parameterExpression2) => parameterExpression1.GetReflectionProperty(parameterExpression2)));
            num = 8;
            continue;
          case 11:
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: type reference
            TypeExtensions.PredefinedTypes = new Type[20]
            {
              TypeExtensions.smL2k9GADPP32TicHiLn(__typeref (object)),
              TypeExtensions.smL2k9GADPP32TicHiLn(__typeref (bool)),
              TypeExtensions.smL2k9GADPP32TicHiLn(__typeref (char)),
              typeof (string),
              TypeExtensions.smL2k9GADPP32TicHiLn(__typeref (sbyte)),
              typeof (byte),
              TypeExtensions.smL2k9GADPP32TicHiLn(__typeref (short)),
              TypeExtensions.smL2k9GADPP32TicHiLn(__typeref (ushort)),
              TypeExtensions.smL2k9GADPP32TicHiLn(__typeref (int)),
              TypeExtensions.smL2k9GADPP32TicHiLn(__typeref (uint)),
              TypeExtensions.smL2k9GADPP32TicHiLn(__typeref (long)),
              TypeExtensions.smL2k9GADPP32TicHiLn(__typeref (ulong)),
              TypeExtensions.smL2k9GADPP32TicHiLn(__typeref (float)),
              typeof (double),
              typeof (Decimal),
              TypeExtensions.smL2k9GADPP32TicHiLn(__typeref (DateTime)),
              typeof (TimeSpan),
              TypeExtensions.smL2k9GADPP32TicHiLn(__typeref (Guid)),
              typeof (Math),
              TypeExtensions.smL2k9GADPP32TicHiLn(__typeref (Convert))
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
            continue;
          case 12:
            TypeExtensions.aONjN0GAzx9Pc8SNt0uD();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 11 : 8;
            continue;
          default:
            // ISSUE: type reference
            parameterExpression4 = (ParameterExpression) TypeExtensions.LCrabIG7FYXPCGM7k0dI(TypeExtensions.smL2k9GADPP32TicHiLn(__typeref (Type)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 132913437));
            num = 6;
            continue;
        }
      }
label_2:;
    }

    internal static bool jagY6ZGAPBcJY9yXci1a() => TypeExtensions.yhgJtiGAevwljcsZdAGJ == null;

    internal static TypeExtensions nwL5P2GA15sSGSGMQclL() => TypeExtensions.yhgJtiGAevwljcsZdAGJ;

    internal static object XiV8YTGANEw6bTpQMIH7(Type type) => (object) type.GetReflectionProperties();

    internal static bool Kq06pdGA3kCenFfv31dF([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static object BtJq4uGApa5eJ364GC3o(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object pnWPeyGAajbwsJT2dQUr([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static Type smL2k9GADPP32TicHiLn([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool J11aKKGAtRM7sIM2Drsm(Type type) => type.IsNullableType();

    internal static bool cBEGC9GAwJdkSZRNtkfl([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static Type ordBKSGA4jmr2Fy38y2i(Type type) => type.GetNonNullableType();

    internal static bool oU0wejGA6Uk1xQxoF083([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static int DfpENyGAH2LKm1q91vZ1(Type type) => type.GetNumericTypeKind();

    internal static TypeCode nE2wDjGAAxob0mmmeboZ([In] Type obj0) => Type.GetTypeCode(obj0);

    internal static void H8EWG7GA7U93mfT0707H([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static Type gCEJdMGAxXpuL6tCFvL9(Type type, Type genericType) => type.FindGenericType(genericType);

    internal static object VhosKoGA0yq75QqaG88B([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object BkXAMuGAmca9Lvf3mBZs([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static object tAbrcAGAydmxyfmLE2N4([In] Type obj0) => Activator.CreateInstance(obj0);

    internal static object GL6oCeGAMDKnFoLKFiFo(
      [In] object obj0,
      Type type,
      Type idType,
      bool forIdentifier)
    {
      return ((ITypePropertyExtensionPoint) obj0).DefaultValue(type, idType, forIdentifier);
    }

    internal static object O89GUqGAJAIQg9w0buIG(Type type) => (object) TypeExtensions.GetTypePropertyExtension(type);

    internal static bool ICUCE6GA93ucJUpZu8h5([In] object obj0, Type type, Type idType, [In] object obj3) => ((ITypePropertyExtensionPoint) obj0).IsDefaultId(type, idType, obj3);

    internal static bool AaFS5eGAdOcd9buB7j3B(Type type, Type idType, [In] object obj2) => type.IsDefaultId(idType, obj2);

    internal static long KekYNwGAlrx8dfYqfExn([In] object obj0) => Convert.ToInt64(obj0);

    internal static object kP8jBHGAr4Te5pcUWRVm(Type type, Type idType) => type.DefaultIdentifierValue(idType);

    internal static object cWK2E1GAgYilLCCd7cFw([In] object obj0, Type type, Type idType, [In] object obj3) => ((ITypePropertyExtensionPoint) obj0).ConvertId(type, idType, obj3);

    internal static object DC7BFMGA5dLCqkDMR6nD(Type type, [In] object obj1, bool staticAccess) => (object) type.FindPropertyOrField((string) obj1, staticAccess);

    internal static void cGJrr8GAj7WYi6vBIAwA([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool OMi2tLGAYKqyZE9qZq1O(Type source, Type target) => source.IsCompatibleWith(target);

    internal static bool roWpWyGALPEWM4GI6mwT(Type type) => type.IsEnumerable();

    internal static object Daj1llGAUomDUhHFHagW([In] Type obj0) => (object) IntrospectionExtensions.GetTypeInfo(obj0);

    internal static Type otKWuHGAsaIaAEgRfdTS([In] object obj0) => ((RipeType) obj0).Raw;

    internal static object mAldGGGAc9kD2msfeNvC() => (object) ComponentManager.Current;

    internal static void aONjN0GAzx9Pc8SNt0uD() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object LCrabIG7FYXPCGM7k0dI([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object DismAWG7BphmQflNXHmR([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object kIpllBG7Wdfk4GFaaDxY([In] object obj0, [In] object obj1, [In] object obj2) => (object) Expression.Call((Expression) obj0, (MethodInfo) obj1, (Expression[]) obj2);
  }
}
