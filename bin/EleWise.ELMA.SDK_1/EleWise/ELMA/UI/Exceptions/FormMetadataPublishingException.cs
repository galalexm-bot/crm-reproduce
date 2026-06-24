// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Exceptions.FormMetadataPublishingException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.UI.Exceptions
{
  /// <summary>Ошибка при публикации формы (страницы или портлета)</summary>
  [Serializable]
  public class FormMetadataPublishingException : Exception
  {
    internal static FormMetadataPublishingException z9oUoZMbyiXashwCGyY;

    /// <summary>Ctor</summary>
    public FormMetadataPublishingException(Exception innerException)
    {
      FormMetadataPublishingException.avNUPdMEYum37swU6il();
      // ISSUE: explicit constructor call
      base.\u002Ector(FormMetadataPublishingException.DefaultMessage, innerException);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="message">Сообщение</param>
    public FormMetadataPublishingException(string message)
    {
      FormMetadataPublishingException.avNUPdMEYum37swU6il();
      // ISSUE: explicit constructor call
      base.\u002Ector(message);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="message">Сообщение</param>
    /// <param name="innerException">Исключение</param>
    public FormMetadataPublishingException(string message, Exception innerException)
    {
      FormMetadataPublishingException.avNUPdMEYum37swU6il();
      // ISSUE: explicit constructor call
      base.\u002Ector(message, innerException);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="scriptCompileResult">Результаты компиляции сценариев</param>
    public FormMetadataPublishingException(ScriptCompileResult scriptCompileResult)
    {
      FormMetadataPublishingException.avNUPdMEYum37swU6il();
      // ISSUE: explicit constructor call
      base.\u002Ector((string) FormMetadataPublishingException.pysorLMfchfIMnL5oI2() + z2jc63fLkugS1X8Q9N.tE1kD1vbB(993438473 ^ 993444701) + (string) FormMetadataPublishingException.MPsXuPMC4dE9fqCyHNL(FormMetadataPublishingException.ORFrXWMQb6PtfJS2D4C(-138018305 ^ -137974889)));
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.ScriptCompileResult = scriptCompileResult;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Ctor for serialization</summary>
    /// <param name="info"></param>
    /// <param name="context"></param>
    protected FormMetadataPublishingException(SerializationInfo info, StreamingContext context)
    {
      FormMetadataPublishingException.avNUPdMEYum37swU6il();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: type reference
            this.ValidationErrors = (MetadataItemValidationError[]) FormMetadataPublishingException.FZQ05qMvlblsPw2EpHR((object) info, FormMetadataPublishingException.ORFrXWMQb6PtfJS2D4C(-882126494 ^ -882148434), FormMetadataPublishingException.Yx940CM8rHBqSu7Rv2j(__typeref (MetadataItemValidationError[])));
            num = 2;
            continue;
          case 2:
            goto label_3;
          default:
            this.ScriptCompileResult = (ScriptCompileResult) FormMetadataPublishingException.FZQ05qMvlblsPw2EpHR((object) info, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218922984), typeof (ScriptCompileResult));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Результаты компиляции сценариев</summary>
    public ScriptCompileResult ScriptCompileResult
    {
      get => this.\u003CScriptCompileResult\u003Ek__BackingField;
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
              this.\u003CScriptCompileResult\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
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

    /// <summary>Ошибки валидации метаданных</summary>
    public MetadataItemValidationError[] ValidationErrors
    {
      get => this.\u003CValidationErrors\u003Ek__BackingField;
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
              this.\u003CValidationErrors\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
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

    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            FormMetadataPublishingException.Th4oJ4MZ8EIM1Z0HF6y((object) this, (object) info, context);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
            continue;
          case 2:
            FormMetadataPublishingException.gKVrJRMujwAv5dCUcGo((object) info, FormMetadataPublishingException.ORFrXWMQb6PtfJS2D4C(-1598106783 - -968262081 ^ -629800978), (object) this.ValidationErrors);
            num = 3;
            continue;
          case 3:
            goto label_2;
          default:
            FormMetadataPublishingException.gKVrJRMujwAv5dCUcGo((object) info, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536761032), (object) this.ScriptCompileResult);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    private static string DefaultMessage => (string) FormMetadataPublishingException.MPsXuPMC4dE9fqCyHNL(FormMetadataPublishingException.ORFrXWMQb6PtfJS2D4C(1051276242 - 990076387 ^ 61177631));

    internal static void avNUPdMEYum37swU6il() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool OaQmAnMhcdarUwZOTSY() => FormMetadataPublishingException.z9oUoZMbyiXashwCGyY == null;

    internal static FormMetadataPublishingException wjrtZxMGIjZAyh0urTu() => FormMetadataPublishingException.z9oUoZMbyiXashwCGyY;

    internal static object pysorLMfchfIMnL5oI2() => (object) FormMetadataPublishingException.DefaultMessage;

    internal static object ORFrXWMQb6PtfJS2D4C(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object MPsXuPMC4dE9fqCyHNL([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object FZQ05qMvlblsPw2EpHR([In] object obj0, [In] object obj1, [In] Type obj2) => ((SerializationInfo) obj0).GetValue((string) obj1, obj2);

    internal static Type Yx940CM8rHBqSu7Rv2j([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static void Th4oJ4MZ8EIM1Z0HF6y([In] object obj0, [In] object obj1, [In] StreamingContext obj2) => __nonvirtual (((Exception) obj0).GetObjectData((SerializationInfo) obj1, obj2));

    internal static void gKVrJRMujwAv5dCUcGo([In] object obj0, [In] object obj1, [In] object obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);
  }
}
