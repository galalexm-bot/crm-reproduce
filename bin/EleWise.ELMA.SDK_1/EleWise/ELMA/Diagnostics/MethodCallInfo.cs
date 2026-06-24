// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.MethodCallInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Diagnostics.Attributes;
using EleWise.ELMA.Diagnostics.Events;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Diagnostics
{
  /// <summary>Информация о вызове метода</summary>
  [DiagnosticEvents(StartEvent = typeof (MethodCallStartEvent), EndEvent = typeof (MethodCallEndEvent), ErrorEvent = typeof (MethodCallErrorEvent))]
  [Serializable]
  public class MethodCallInfo : AbstractCallInfo, IEmptyCallInfo
  {
    internal static MethodCallInfo z2CKSgEWFvd3tRw9kSxO;

    /// <summary>Ctor</summary>
    public MethodCallInfo()
    {
      MethodCallInfo.APAEV2EWoqcrIpOShAA6();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="ownerType">Тип владельца метода</param>
    protected MethodCallInfo(Type ownerType)
    {
      MethodCallInfo.APAEV2EWoqcrIpOShAA6();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            if (!MethodCallInfo.bbWc2DEWbWtIPhxOYfED(ownerType, (Type) null))
            {
              this.OwnerType = ownerType;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
              continue;
            }
            num = 2;
            continue;
          case 2:
            goto label_4;
          default:
            goto label_8;
        }
      }
label_3:
      return;
label_8:
      return;
label_4:
      throw new ArgumentNullException((string) MethodCallInfo.AJXowPEWhKPru7iYksXP(-1886646897 ^ -1886903053));
    }

    /// <summary>Ctor</summary>
    /// <param name="ownerType">Тип владельца метода</param>
    /// <param name="method">Информация о методе</param>
    /// <param name="arguments">Аргументы метода</param>
    public MethodCallInfo(Type ownerType, MethodInfo method, object[] arguments)
    {
      MethodCallInfo.APAEV2EWoqcrIpOShAA6();
      // ISSUE: explicit constructor call
      this.\u002Ector(ownerType);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            if (!MethodCallInfo.xsJSYKEWGqP9CgU6kLBs((object) method, (object) null))
            {
              this.Method = method;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 3 : 2;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 2 : 1;
            continue;
          case 2:
            goto label_4;
          case 3:
            this.Arguments = arguments;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
            continue;
          default:
            goto label_9;
        }
      }
label_3:
      return;
label_9:
      return;
label_4:
      throw new ArgumentNullException((string) MethodCallInfo.AJXowPEWhKPru7iYksXP(1461825605 - 1531863589 ^ -70102218));
    }

    /// <summary>Тип владельца метода</summary>
    public Type OwnerType
    {
      get => this.\u003COwnerType\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003COwnerType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
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

    /// <summary>Информация о методе</summary>
    public MethodInfo Method
    {
      get => this.\u003CMethod\u003Ek__BackingField;
      private set
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
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

    /// <summary>Аргументы метода</summary>
    public object[] Arguments
    {
      get => this.\u003CArguments\u003Ek__BackingField;
      private set
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
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

    /// <inheritdoc />
    public override string CallType => (string) MethodCallInfo.AJXowPEWhKPru7iYksXP(813604817 ^ 813348451);

    /// <inheritdoc />
    public override string Description => DiagnosticsHelper.GetMethodCallName(this.OwnerType, this.Method);

    /// <inheritdoc />
    public bool IsEmpty
    {
      get => this.\u003CIsEmpty\u003Ek__BackingField;
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
              this.\u003CIsEmpty\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
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

    protected override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (this.Arguments.Length != 0)
              {
                num2 = 2;
                continue;
              }
              goto label_3;
            case 2:
              SerializationInfo serializationInfo = info;
              object name = MethodCallInfo.AJXowPEWhKPru7iYksXP(654297945 ^ 654041741);
              object[] arguments = this.Arguments;
              // ISSUE: reference to a compiler-generated field
              Func<object, string> func = MethodCallInfo.\u003C\u003Ec.\u003C\u003E9__23_0;
              Func<object, string> selector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                MethodCallInfo.\u003C\u003Ec.\u003C\u003E9__23_0 = selector = (Func<object, string>) (a => a.ToString());
              }
              else
                goto label_15;
label_13:
              IEnumerable<string> strings = ((IEnumerable<object>) arguments).Select<object, string>(selector);
              serializationInfo.AddValue((string) name, (object) strings);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 5 : 5;
              continue;
label_15:
              selector = func;
              goto label_13;
            case 3:
              MethodCallInfo.u69eJAEWEY2HlH3Y3HGq((object) info, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138415238), (object) this.Method);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
              continue;
            case 4:
              goto label_6;
            case 5:
              goto label_11;
            default:
              if (this.Arguments != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 1;
                continue;
              }
              goto label_14;
          }
        }
label_6:
        info.AddValue((string) MethodCallInfo.AJXowPEWhKPru7iYksXP(-1939377524 ^ -1939645646), (object) this.OwnerType);
        num1 = 3;
      }
label_11:
      return;
label_3:
      return;
label_14:;
    }

    internal static void APAEV2EWoqcrIpOShAA6() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Ecct7gEWBDfpqC9gLvJX() => MethodCallInfo.z2CKSgEWFvd3tRw9kSxO == null;

    internal static MethodCallInfo vXYJBGEWW2QhrpKSM0J9() => MethodCallInfo.z2CKSgEWFvd3tRw9kSxO;

    internal static bool bbWc2DEWbWtIPhxOYfED([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object AJXowPEWhKPru7iYksXP(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool xsJSYKEWGqP9CgU6kLBs([In] object obj0, [In] object obj1) => (MethodInfo) obj0 == (MethodInfo) obj1;

    internal static void u69eJAEWEY2HlH3Y3HGq([In] object obj0, [In] object obj1, [In] object obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);
  }
}
