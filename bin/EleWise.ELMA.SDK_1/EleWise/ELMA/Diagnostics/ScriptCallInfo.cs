// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.ScriptCallInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Diagnostics
{
  /// <summary>Информация о вызове метода пользовательского сценария</summary>
  [Serializable]
  public class ScriptCallInfo : MethodCallInfo
  {
    internal static ScriptCallInfo FKbQyNEWyHZkypGWxsh8;

    /// <summary>Ctor</summary>
    public ScriptCallInfo()
    {
      ScriptCallInfo.JZUexLEW9GGnGc1O34Cr();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="ownerType">Тип владельца скрипта</param>
    /// <param name="ownerName">Название владельца скрипта</param>
    /// <param name="method">Информация о методе скрипта</param>
    /// <param name="arguments">Аргументы</param>
    public ScriptCallInfo(Type ownerType, string ownerName, MethodInfo method, object[] arguments)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(ownerType, method, arguments);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.OwnerName = ownerName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Имя владельца скрипта</summary>
    public string OwnerName
    {
      get => this.\u003COwnerName\u003Ek__BackingField;
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
              this.\u003COwnerName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
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
    public override string CallType => (string) ScriptCallInfo.zHONpOEWd8UTY6SlT9QI(1051802738 - -1831968059 ^ -1411178541);

    protected override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            base.GetObjectData(info, context);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            info.AddValue((string) ScriptCallInfo.zHONpOEWd8UTY6SlT9QI(864270449 << 6 ^ -521521304), (object) this.OwnerName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 2;
            continue;
          default:
            if (!ScriptCallInfo.bnHRvQEWlqnTGDAv09AK((object) this.OwnerName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 3;
              continue;
            }
            goto label_7;
        }
      }
label_2:
      return;
label_7:;
    }

    internal static void JZUexLEW9GGnGc1O34Cr() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool hjxkbvEWMHyiMyZLY4Ia() => ScriptCallInfo.FKbQyNEWyHZkypGWxsh8 == null;

    internal static ScriptCallInfo HjCUtLEWJPXKShHWp4BZ() => ScriptCallInfo.FKbQyNEWyHZkypGWxsh8;

    internal static object zHONpOEWd8UTY6SlT9QI(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool bnHRvQEWlqnTGDAv09AK([In] object obj0) => ((string) obj0).IsNullOrEmpty();
  }
}
