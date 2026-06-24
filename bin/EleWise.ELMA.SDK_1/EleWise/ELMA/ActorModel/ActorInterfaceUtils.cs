// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.ActorInterfaceUtils
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Attributes;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.ActorModel
{
  /// <summary>
  /// Вспомогательный класс для работы с интерфейсами Акторов.
  /// </summary>
  public static class ActorInterfaceUtils
  {
    private static readonly IEqualityComparer<MethodInfo> MethodComparer;
    internal static ActorInterfaceUtils otK16Rf3uqyqCKqYL4I9;

    /// <summary>
    /// Определяет является ли указанный интерфейс интерфейсом Актора
    /// </summary>
    /// <param name="t">Тип</param>
    /// <returns>Является ли указанный интерфейс интерфейсом Актора</returns>
    public static bool IsActorInterface(Type t)
    {
      int num = 10;
      while (true)
      {
        switch (num)
        {
          case 2:
            if (t != TypeOf<IActorWithStringKey>.Raw)
            {
              num = 6;
              continue;
            }
            goto label_13;
          case 3:
            if (ActorInterfaceUtils.qaU6qFf3Sn4fw9r0bwCA(t.GetInterface(typeof (IActor).FullName), (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 13 : 14;
              continue;
            }
            goto label_13;
          case 4:
            if (!(t != TypeOf<IActor>.Raw))
            {
              num = 13;
              continue;
            }
            goto case 7;
          case 6:
            if (!ActorInterfaceUtils.qaU6qFf3Sn4fw9r0bwCA(t, TypeOf<IActorWithGuidCompoundKey>.Raw))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
              continue;
            }
            goto label_12;
          case 7:
            if (ActorInterfaceUtils.qaU6qFf3Sn4fw9r0bwCA(t, TypeOf<IActorWithIntegerKey>.Raw))
            {
              num = 12;
              continue;
            }
            goto label_13;
          case 8:
            if (AttributeHelper<AbstractActorAttribute>.GetAttribute(t, false) != null)
            {
              num = 5;
              continue;
            }
            goto case 4;
          case 10:
            if (!t.IsInterface)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 9 : 9;
              continue;
            }
            goto case 3;
          case 11:
            goto label_12;
          case 12:
            if (!ActorInterfaceUtils.qaU6qFf3Sn4fw9r0bwCA(t, TypeOf<IActorWithGuidKey>.Raw))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 1 : 1;
              continue;
            }
            goto case 2;
          case 14:
            if (!t.IsGenericType)
            {
              num = 8;
              continue;
            }
            goto label_13;
          default:
            goto label_13;
        }
      }
label_12:
      return ActorInterfaceUtils.qaU6qFf3Sn4fw9r0bwCA(t, TypeOf<IServerPlacementActor>.Raw);
label_13:
      return false;
    }

    /// <summary>Возвращает методы Актора</summary>
    /// <param name="actorType">Тип Актора</param>
    /// <param name="bAllMethods">True, если будут проверяться все методы, включая унаследованные</param>
    /// <returns>Методы Актора</returns>
    public static MethodInfo[] GetMethods(Type actorType, bool bAllMethods = true)
    {
      int num1 = 8;
      List<MethodInfo> methodInfoList;
      while (true)
      {
        int num2 = num1;
        BindingFlags bindingAttr;
        int index;
        MethodInfo[] methods;
        MethodInfo methodInfo;
        while (true)
        {
          switch (num2)
          {
            case 2:
              index = 0;
              num2 = 9;
              continue;
            case 3:
              if (methodInfoList.Contains<MethodInfo>(methodInfo, ActorInterfaceUtils.MethodComparer))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 1 : 1;
                continue;
              }
              goto case 6;
            case 4:
              goto label_9;
            case 5:
            case 9:
              if (index >= methods.Length)
              {
                num2 = 4;
                continue;
              }
              goto case 14;
            case 6:
              methodInfoList.Add(methodInfo);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
              continue;
            case 7:
              ActorInterfaceUtils.GetMethodsImpl(actorType, actorType, methodInfoList);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 2 : 15;
              continue;
            case 8:
              methodInfoList = new List<MethodInfo>();
              num2 = 7;
              continue;
            case 10:
              if (bAllMethods)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 4 : 12;
                continue;
              }
              goto case 13;
            case 11:
            case 12:
              methods = actorType.GetMethods(bindingAttr);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 2 : 0;
              continue;
            case 13:
              bindingAttr |= BindingFlags.DeclaredOnly;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 7 : 11;
              continue;
            case 14:
              methodInfo = methods[index];
              num2 = 3;
              continue;
            case 15:
              bindingAttr = BindingFlags.Instance | BindingFlags.Public | BindingFlags.InvokeMethod;
              num2 = 10;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        ++index;
        num1 = 5;
      }
label_9:
      return (MethodInfo[]) ActorInterfaceUtils.gv25Q9f3i2gkHGEavM2O((object) methodInfoList);
    }

    /// <summary>Recurses through interface graph accumulating methods</summary>
    /// <param name="actorType">Actor type</param>
    /// <param name="serviceType">Service interface type</param>
    /// <param name="methodInfos">Accumulated </param>
    private static void GetMethodsImpl(
      Type actorType,
      Type serviceType,
      List<MethodInfo> methodInfos)
    {
      Type[] array = ActorInterfaceUtils.GetRemoteInterfaces(serviceType, false).ToArray();
      IEqualityComparer<MethodInfo> methodComparer = (IEqualityComparer<MethodInfo>) new ActorInterfaceUtils.MethodInfoComparer();
      TypeInfo typeInfo = IntrospectionExtensions.GetTypeInfo(actorType);
      foreach (Type interfaceType in array)
      {
        InterfaceMapping interfaceMapping = new InterfaceMapping();
        if (typeInfo.IsClass)
          interfaceMapping = typeInfo.GetRuntimeInterfaceMap(interfaceType);
        if (typeInfo.IsInterface || interfaceMapping.TargetType == actorType)
        {
          foreach (MethodInfo method in interfaceType.GetMethods())
          {
            if (typeInfo.IsClass)
            {
              MethodInfo mi = method;
              if (((IEnumerable<MethodInfo>) interfaceMapping.TargetMethods).Any<MethodInfo>((Func<MethodInfo, bool>) (info =>
              {
                int num = 1;
                while (true)
                {
                  switch (num)
                  {
                    case 1:
                      if (!methodComparer.Equals(mi, info))
                      {
                        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
                        continue;
                      }
                      goto label_4;
                    case 2:
                      goto label_4;
                    default:
                      goto label_5;
                  }
                }
label_4:
                // ISSUE: reference to a compiler-generated method
                return ActorInterfaceUtils.\u003C\u003Ec__DisplayClass3_1.oImyWUZW3V1OQCLyK9In(info.DeclaringType, actorType);
label_5:
                return false;
              })) && !methodInfos.Contains<MethodInfo>(mi, methodComparer))
                methodInfos.Add(mi);
            }
            else if (!methodInfos.Contains<MethodInfo>(method, methodComparer))
              methodInfos.Add(method);
          }
        }
      }
    }

    /// <summary>Recurses through interface graph accumulating types</summary>
    /// <param name="type">Actor type</param>
    /// <param name="checkIsActorInterface"></param>
    /// <returns>Accumulated</returns>
    private static List<Type> GetRemoteInterfaces(Type type, bool checkIsActorInterface = true)
    {
      List<Type> remoteInterfaces = new List<Type>();
      if (ActorInterfaceUtils.IsActorInterface(type))
        remoteInterfaces.Add(type);
      foreach (Type type1 in ((IEnumerable<Type>) type.GetInterfaces()).Where<Type>((Func<Type, bool>) (i =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!checkIsActorInterface)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 2:
              goto label_4;
            default:
              goto label_5;
          }
        }
label_4:
        // ISSUE: reference to a compiler-generated method
        return ActorInterfaceUtils.\u003C\u003Ec__DisplayClass4_0.yKHe5MZWtHtxjqgKBjWC(i);
label_5:
        return true;
      })))
        remoteInterfaces.Add(type1);
      return remoteInterfaces;
    }

    static ActorInterfaceUtils()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ActorInterfaceUtils.UIfXwff3RTAw9esjScnv();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ActorInterfaceUtils.MethodComparer = (IEqualityComparer<MethodInfo>) new ActorInterfaceUtils.MethodInfoComparer();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool qaU6qFf3Sn4fw9r0bwCA([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static bool kHaBM6f3IlxlBA8HOpmF() => ActorInterfaceUtils.otK16Rf3uqyqCKqYL4I9 == null;

    internal static ActorInterfaceUtils rbsAIPf3VfFYu0weyPs4() => ActorInterfaceUtils.otK16Rf3uqyqCKqYL4I9;

    internal static object gv25Q9f3i2gkHGEavM2O([In] object obj0) => (object) ((List<MethodInfo>) obj0).ToArray();

    internal static void UIfXwff3RTAw9esjScnv() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    private class MethodInfoComparer : IEqualityComparer<MethodInfo>
    {
      internal static object Lk6G7SZWZRUU6p0NCtQV;

      /// <inheritdoc />
      public bool Equals(MethodInfo x, MethodInfo y) => ActorInterfaceUtils.MethodInfoComparer.bu7aL9ZWSPgeajJdLAdB(ActorInterfaceUtils.MethodInfoComparer.fGnxEFZWVQg5Ci0noQZM((object) x), ActorInterfaceUtils.MethodInfoComparer.fGnxEFZWVQg5Ci0noQZM((object) y), StringComparison.Ordinal);

      /// <inheritdoc />
      public int GetHashCode(MethodInfo obj) => throw new NotImplementedException();

      private static string GetSignature(object method)
      {
        int num1 = 1;
        StringBuilder stringBuilder;
        while (true)
        {
          int num2 = num1;
          int index1;
          Type[] typeArray;
          int index2;
          ParameterInfo[] parameterInfoArray;
          ParameterInfo parameterInfo;
          Type type1;
          TypeInfo typeInfo;
          Type type2;
          while (true)
          {
            switch (num2)
            {
              case 1:
                stringBuilder = new StringBuilder(((MemberInfo) method).Name);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
                continue;
              case 2:
              case 27:
                if (index1 < typeArray.Length)
                {
                  num2 = 7;
                  continue;
                }
                goto case 3;
              case 3:
              case 16:
                parameterInfoArray = (ParameterInfo[]) ActorInterfaceUtils.MethodInfoComparer.Y2TME9ZWKpJsbu4Xc09G(method);
                num2 = 23;
                continue;
              case 4:
                ++index2;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 8;
                continue;
              case 5:
                index2 = 0;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 24 : 22;
                continue;
              case 6:
              case 14:
                if (index1 >= parameterInfoArray.Length)
                {
                  num2 = 10;
                  continue;
                }
                goto case 17;
              case 7:
              case 22:
                type1 = typeArray[index1];
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 26 : 25;
                continue;
              case 8:
              case 24:
                if (index2 < typeArray.Length)
                {
                  num2 = 11;
                  continue;
                }
                goto case 9;
              case 9:
              case 15:
                ++index1;
                num2 = 6;
                continue;
              case 10:
                goto label_18;
              case 11:
              case 18:
                type2 = typeArray[index2];
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 16 : 28;
                continue;
              case 12:
                typeInfo = (TypeInfo) ActorInterfaceUtils.MethodInfoComparer.EZBiDpZWTQPv2g2t9nbj(ActorInterfaceUtils.MethodInfoComparer.fpeZMnZWXtVaBfVI6B9e((object) parameterInfo));
                num2 = 19;
                continue;
              case 13:
                typeArray = (Type[]) ActorInterfaceUtils.MethodInfoComparer.pAHncSZWRD1FvOfjt1Si(method);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 21 : 25;
                continue;
              case 17:
                parameterInfo = parameterInfoArray[index1];
                num2 = 12;
                continue;
              case 19:
                ActorInterfaceUtils.MethodInfoComparer.C94qkwZWkSDlGJRaWAsd((object) stringBuilder, ActorInterfaceUtils.MethodInfoComparer.LefsOGZWqjjZME8t8Ooi((object) typeInfo));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 20 : 16;
                continue;
              case 20:
                if (!typeInfo.IsGenericType)
                {
                  num2 = 15;
                  continue;
                }
                goto case 29;
              case 21:
                ++index1;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 12 : 27;
                continue;
              case 23:
                index1 = 0;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 14 : 0;
                continue;
              case 25:
                index1 = 0;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 2 : 1;
                continue;
              case 26:
                stringBuilder.Append((string) ActorInterfaceUtils.MethodInfoComparer.LefsOGZWqjjZME8t8Ooi((object) type1));
                num2 = 21;
                continue;
              case 28:
                goto label_14;
              case 29:
                typeArray = parameterInfo.ParameterType.GetGenericArguments();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 5 : 3;
                continue;
              default:
                if (!ActorInterfaceUtils.MethodInfoComparer.ax7tirZWiRXVKcnSPJd3(method))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 3 : 0;
                  continue;
                }
                goto case 13;
            }
          }
label_14:
          stringBuilder.Append((string) ActorInterfaceUtils.MethodInfoComparer.LefsOGZWqjjZME8t8Ooi((object) type2));
          num1 = 4;
        }
label_18:
        return stringBuilder.ToString();
      }

      public MethodInfoComparer()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static object fGnxEFZWVQg5Ci0noQZM([In] object obj0) => (object) ActorInterfaceUtils.MethodInfoComparer.GetSignature(obj0);

      internal static bool bu7aL9ZWSPgeajJdLAdB([In] object obj0, [In] object obj1, [In] StringComparison obj2) => string.Equals((string) obj0, (string) obj1, obj2);

      internal static bool p5m6tTZWumhqr45t5la8() => ActorInterfaceUtils.MethodInfoComparer.Lk6G7SZWZRUU6p0NCtQV == null;

      internal static ActorInterfaceUtils.MethodInfoComparer hHRfRrZWI6fLuFMZcXUN() => (ActorInterfaceUtils.MethodInfoComparer) ActorInterfaceUtils.MethodInfoComparer.Lk6G7SZWZRUU6p0NCtQV;

      internal static bool ax7tirZWiRXVKcnSPJd3([In] object obj0) => ((MethodBase) obj0).IsGenericMethodDefinition;

      internal static object pAHncSZWRD1FvOfjt1Si([In] object obj0) => (object) ((MethodBase) obj0).GetGenericArguments();

      internal static object LefsOGZWqjjZME8t8Ooi([In] object obj0) => (object) ((MemberInfo) obj0).Name;

      internal static object Y2TME9ZWKpJsbu4Xc09G([In] object obj0) => (object) ((MethodBase) obj0).GetParameters();

      internal static Type fpeZMnZWXtVaBfVI6B9e([In] object obj0) => ((ParameterInfo) obj0).ParameterType;

      internal static object EZBiDpZWTQPv2g2t9nbj([In] Type obj0) => (object) IntrospectionExtensions.GetTypeInfo(obj0);

      internal static object C94qkwZWkSDlGJRaWAsd([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).Append((string) obj1);
    }
  }
}
