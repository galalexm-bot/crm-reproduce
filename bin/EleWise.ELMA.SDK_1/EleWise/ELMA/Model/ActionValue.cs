// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.ActionValue
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Scripts.Models;
using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Model
{
  /// <summary>Значение для действия</summary>
  [DataContract]
  [Serializable]
  public sealed class ActionValue
  {
    internal static ActionValue cZFMvRWgE9HRRsb92Vvi;

    /// <summary>Имя метода</summary>
    [DataMember]
    [DefaultValue("")]
    public string MethodName
    {
      get => this.\u003CMethodName\u003Ek__BackingField;
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
              this.\u003CMethodName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
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

    /// <summary>Уникальный идентификатор заголовка функции</summary>
    [DataMember]
    public Guid FunctionHeaderUid
    {
      get => this.\u003CFunctionHeaderUid\u003Ek__BackingField;
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
              this.\u003CFunctionHeaderUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
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

    /// <summary>Тип сценария</summary>
    [DefaultValue(CodeType.Client)]
    [DataMember]
    public CodeType CodeType
    {
      get => this.\u003CCodeType\u003Ek__BackingField;
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
              this.\u003CCodeType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
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
    /// Нужно ли сериализовать <see cref="P:EleWise.ELMA.Model.ActionValue.FunctionHeaderUid" />
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeFunctionHeaderUid() => ActionValue.XeOwW0WgCcnl9KSBKDQ4(this.FunctionHeaderUid, Guid.Empty);

    /// <inheritdoc />
    public override bool Equals(object obj)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(obj is ActionValue actionValue))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
              continue;
            }
            goto case 5;
          case 2:
            if (!ActionValue.gyRTniWgZFjpjOHxnOQj(ActionValue.iwPgklWg863I2GqOyVRP((object) actionValue), this.FunctionHeaderUid))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 1 : 3;
              continue;
            }
            goto label_6;
          case 4:
            goto label_6;
          case 5:
            if (ActionValue.RbfEs9WgvQPxAocRyoRc((object) actionValue) == this.CodeType)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 2 : 1;
              continue;
            }
            goto label_7;
          default:
            goto label_7;
        }
      }
label_6:
      return ActionValue.BgcdmOWgImGxLAf5YneO(ActionValue.qDvPa0WgueJVtoRG22Jv((object) actionValue), (object) this.MethodName);
label_7:
      return false;
    }

    public ActionValue()
    {
      ActionValue.l6nisHWgVoUNbR8OIJMH();
      // ISSUE: reference to a compiler-generated field
      this.\u003CMethodName\u003Ek__BackingField = string.Empty;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool UoeKf4WgftqdAvip8d05() => ActionValue.cZFMvRWgE9HRRsb92Vvi == null;

    internal static ActionValue gunm0rWgQ4BCNlvWctE9() => ActionValue.cZFMvRWgE9HRRsb92Vvi;

    internal static bool XeOwW0WgCcnl9KSBKDQ4([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static CodeType RbfEs9WgvQPxAocRyoRc([In] object obj0) => ((ActionValue) obj0).CodeType;

    internal static Guid iwPgklWg863I2GqOyVRP([In] object obj0) => ((ActionValue) obj0).FunctionHeaderUid;

    internal static bool gyRTniWgZFjpjOHxnOQj([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object qDvPa0WgueJVtoRG22Jv([In] object obj0) => (object) ((ActionValue) obj0).MethodName;

    internal static bool BgcdmOWgImGxLAf5YneO([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static void l6nisHWgVoUNbR8OIJMH() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
