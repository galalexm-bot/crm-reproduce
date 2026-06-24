// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.RemoteServiceInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Castle.DynamicProxy;
using EleWise.ELMA.Remoting;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Services
{
  public class RemoteServiceInfo : EternalRefObject
  {
    internal static RemoteServiceInfo D6ptGjBxs8UDrl0XKdh6;

    public RemoteServiceInfo()
    {
      RemoteServiceInfo.iVk8wsB0FW5aiIdaU0J8();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public RemoteServiceInfo(EternalRefObject reference)
    {
      RemoteServiceInfo.iVk8wsB0FW5aiIdaU0J8();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
        num = 4;
      while (true)
      {
        Type type1;
        Type type2;
        switch (num)
        {
          case 1:
            if (reference.GetType().IsSecurityTransparent)
            {
              num = 6;
              continue;
            }
            goto default;
          case 2:
            this.AssemblyQualifiedTypeName = type1.AssemblyQualifiedName;
            num = 5;
            continue;
          case 3:
            type2 = reference.GetType();
            break;
          case 4:
            this.Reference = reference;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 0;
            continue;
          case 5:
            goto label_3;
          case 6:
            type2 = reference.GetType().BaseType;
            break;
          default:
            // ISSUE: type reference
            if (!(reference.GetType().GetInterface(RemoteServiceInfo.mG3bWaB0BZT5tTxyC7Z3(__typeref (IProxyTargetAccessor)).FullName) != (Type) null))
            {
              num = 3;
              continue;
            }
            goto case 6;
        }
        type1 = type2;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 2 : 1;
      }
label_3:;
    }

    public EternalRefObject Reference
    {
      get => this.\u003CReference\u003Ek__BackingField;
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
              this.\u003CReference\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
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

    public string AssemblyQualifiedTypeName
    {
      get => this.\u003CAssemblyQualifiedTypeName\u003Ek__BackingField;
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
              this.\u003CAssemblyQualifiedTypeName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
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

    internal static void iVk8wsB0FW5aiIdaU0J8() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool X8bIw6Bxc2DaZuZ4xZ6C() => RemoteServiceInfo.D6ptGjBxs8UDrl0XKdh6 == null;

    internal static RemoteServiceInfo SY2NBEBxz0NfwHYdeOhT() => RemoteServiceInfo.D6ptGjBxs8UDrl0XKdh6;

    internal static Type mG3bWaB0BZT5tTxyC7Z3([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);
  }
}
