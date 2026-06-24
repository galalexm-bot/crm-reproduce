// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Cache.InvocationParameters
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Castle.DynamicProxy;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Cache
{
  /// <summary>
  /// Параметры исполнения метода, основаны на <c>IInvocation</c> из сборки <c>Casle.Core</c>
  /// </summary>
  public class InvocationParameters
  {
    internal static InvocationParameters Fe53lafKuNZEmLxNNsqa;

    internal InvocationParameters(IInvocation invocation)
    {
      InvocationParameters.lPvFYofKS97bHrKoEyZE();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.TargetType = InvocationParameters.w3JX9TfKRM41I4muyf3a((object) invocation);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
            continue;
          case 2:
            this.GenericArguments = invocation.GenericArguments;
            num = 5;
            continue;
          case 3:
            this.Method = (MethodInfo) InvocationParameters.OoxtH1fKixVuKd7cF0KD((object) invocation);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 1 : 1;
            continue;
          case 4:
            this.Arguments = invocation.Arguments;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 2 : 2;
            continue;
          case 5:
            this.InvocationTarget = invocation.InvocationTarget;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 3;
            continue;
          default:
            goto label_8;
        }
      }
label_2:
      return;
label_8:;
    }

    /// <summary>
    /// Gets the object on which the invocation is performed.
    /// </summary>
    /// <value>The invocation target.</value>
    public object InvocationTarget
    {
      get => this.\u003CInvocationTarget\u003Ek__BackingField;
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
              this.\u003CInvocationTarget\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
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

    /// <summary>
    /// Gets the type of the target object for the intercepted method.
    /// </summary>
    /// <value>The type of the target object.</value>
    public Type TargetType
    {
      get => this.\u003CTargetType\u003Ek__BackingField;
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
              this.\u003CTargetType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
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

    /// <summary>
    /// Gets the arguments that the <see cref="P:EleWise.ELMA.Cache.InvocationParameters.Method" /> has been invoked with.
    /// </summary>
    /// <value>The arguments the method was invoked with.</value>
    public object[] Arguments
    {
      get => this.\u003CArguments\u003Ek__BackingField;
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
              this.\u003CArguments\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
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

    /// <summary>Gets the generic arguments of the method.</summary>
    /// <value>The generic arguments, or null if not a generic method.</value>
    public Type[] GenericArguments
    {
      get => this.\u003CGenericArguments\u003Ek__BackingField;
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
              this.\u003CGenericArguments\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
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

    /// <summary>
    /// Gets the <see cref="T:System.Reflection.MethodInfo" /> representing the method being invoked.
    /// </summary>
    /// <value>
    /// The <see cref="T:System.Reflection.MethodInfo" /> representing the method being invoked.
    /// </value>
    public MethodInfo Method
    {
      get => this.\u003CMethod\u003Ek__BackingField;
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
              this.\u003CMethod\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
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

    internal static void lPvFYofKS97bHrKoEyZE() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object OoxtH1fKixVuKd7cF0KD([In] object obj0) => (object) ((IInvocation) obj0).Method;

    internal static Type w3JX9TfKRM41I4muyf3a([In] object obj0) => ((IInvocation) obj0).TargetType;

    internal static bool k6W4S3fKIZNPTtZDGG9y() => InvocationParameters.Fe53lafKuNZEmLxNNsqa == null;

    internal static InvocationParameters lUwdeufKVZ5kK3c2ZL3p() => InvocationParameters.Fe53lafKuNZEmLxNNsqa;
  }
}
