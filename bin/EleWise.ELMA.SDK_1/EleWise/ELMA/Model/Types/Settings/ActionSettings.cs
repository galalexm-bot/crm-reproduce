// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.ActionSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Signatures;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>Настройки действия</summary>
  [Serializable]
  public class ActionSettings : SimpleTypeSettings, IHasDefaultValue<ActionValue>
  {
    private static ActionSettings dQXxCsoUmVg83LybIGqy;

    /// <summary>Ctor</summary>
    public ActionSettings()
    {
      ActionSettings.WsECICoUJnud1LdMWFMu();
      // ISSUE: reference to a compiler-generated field
      this.\u003CReturnType\u003Ek__BackingField = new TypeSignature();
      // ISSUE: reference to a compiler-generated field
      this.\u003CParameterType\u003Ek__BackingField = new TypeSignature();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor for serialization</summary>
    /// <param name="info">SerializationInfo</param>
    /// <param name="context">StreamingContext</param>
    protected ActionSettings(SerializationInfo info, StreamingContext context)
    {
      ActionSettings.WsECICoUJnud1LdMWFMu();
      // ISSUE: reference to a compiler-generated field
      this.\u003CReturnType\u003Ek__BackingField = new TypeSignature();
      // ISSUE: reference to a compiler-generated field
      this.\u003CParameterType\u003Ek__BackingField = new TypeSignature();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Сигнатура возвращаемого типа</summary>
    public TypeSignature ReturnType
    {
      get => this.\u003CReturnType\u003Ek__BackingField;
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
              this.\u003CReturnType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
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

    /// <summary>Сигнатура типа параметра</summary>
    public TypeSignature ParameterType
    {
      get => this.\u003CParameterType\u003Ek__BackingField;
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
              this.\u003CParameterType\u003Ek__BackingField = value;
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

    /// <inheritdoc />
    public ActionValue DefaultValue
    {
      get => this.\u003CDefaultValue\u003Ek__BackingField;
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
              this.\u003CDefaultValue\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
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

    internal static void WsECICoUJnud1LdMWFMu() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Ae3w3qoUyCkpuGG29cva() => ActionSettings.dQXxCsoUmVg83LybIGqy == null;

    internal static ActionSettings Bk35lmoUMoA1qp1i6KjO() => ActionSettings.dQXxCsoUmVg83LybIGqy;
  }
}
