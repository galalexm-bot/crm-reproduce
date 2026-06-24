// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.Exceptions.GlobalScriptModulePublishingException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Model.Scripts.Exceptions
{
  /// <summary>Исключение при публикации глобального модуля</summary>
  [Serializable]
  public class GlobalScriptModulePublishingException : Exception
  {
    private static readonly string GlobalScriptModuleHeaderIdFieldName;
    private static readonly string ScriptCompileResultFieldName;
    internal static GlobalScriptModulePublishingException wGKS01bq4YMvT8uV0EIG;

    /// <summary>Ctor</summary>
    public GlobalScriptModulePublishingException(Exception innerException)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(GlobalScriptModulePublishingException.DefaultMessage, innerException);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="caHeaderId">Id заголовка пользовательского расширения</param>
    /// <param name="message">Сообщение</param>
    public GlobalScriptModulePublishingException(long caHeaderId, string message)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(message);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.GlobalScriptModuleId = caHeaderId;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Ctor</summary>
    /// <param name="caHeaderId">Id заголовка пользовательского расширения</param>
    /// <param name="innerException">Исключение</param>
    public GlobalScriptModulePublishingException(long caHeaderId, Exception innerException)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector((string) GlobalScriptModulePublishingException.cNAsQabqAbZ949pqIjgG(), innerException);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.GlobalScriptModuleId = caHeaderId;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Ctor</summary>
    /// <param name="caHeaderId">Id заголовка пользовательского расширения</param>
    /// <param name="message">Сообщение</param>
    /// <param name="innerException">Исключение</param>
    public GlobalScriptModulePublishingException(
      long caHeaderId,
      string message,
      Exception innerException)
    {
      GlobalScriptModulePublishingException.hFUsvMbq7TfriR8ahPwR();
      // ISSUE: explicit constructor call
      base.\u002Ector(message, innerException);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.GlobalScriptModuleId = caHeaderId;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Ctor</summary>
    /// <param name="caHeaderId">Id заголовка пользовательского расширения</param>
    /// <param name="scriptCompileResult">Результаты компиляции сценариев</param>
    public GlobalScriptModulePublishingException(
      long caHeaderId,
      ScriptCompileResult scriptCompileResult)
    {
      GlobalScriptModulePublishingException.hFUsvMbq7TfriR8ahPwR();
      // ISSUE: explicit constructor call
      base.\u002Ector((string) GlobalScriptModulePublishingException.cEq5s6bqmfY34xGYrqdp((object) GlobalScriptModulePublishingException.DefaultMessage, GlobalScriptModulePublishingException.dxalh9bqx7B6JcFlRRRJ(-643786247 ^ -643763795), GlobalScriptModulePublishingException.AQDFA5bq0U63Ln8bDdTw(GlobalScriptModulePublishingException.dxalh9bqx7B6JcFlRRRJ(-1255365154 ^ 596875508 ^ -1765828798))));
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.GlobalScriptModuleId = caHeaderId;
            num = 2;
            continue;
          case 2:
            this.ScriptCompileResult = scriptCompileResult;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    /// <summary>Ctor for serialization</summary>
    /// <param name="info"></param>
    /// <param name="context"></param>
    protected GlobalScriptModulePublishingException(
      SerializationInfo info,
      StreamingContext context)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.ScriptCompileResult = (ScriptCompileResult) GlobalScriptModulePublishingException.aKkEqibqyfJudOdMiKpL((object) info, (object) GlobalScriptModulePublishingException.ScriptCompileResultFieldName, typeof (ScriptCompileResult));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.GlobalScriptModuleId = GlobalScriptModulePublishingException.nthJwCbqMTl4PneZMRh8((object) info, (object) GlobalScriptModulePublishingException.GlobalScriptModuleHeaderIdFieldName);
            num = 2;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
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

    /// <summary>Id заголовка глобального модуля</summary>
    public long GlobalScriptModuleId
    {
      get => this.\u003CGlobalScriptModuleId\u003Ek__BackingField;
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
              this.\u003CGlobalScriptModuleId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
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
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            GlobalScriptModulePublishingException.q5Pp7Bbq9MteOvhdUs2w((object) info, (object) GlobalScriptModulePublishingException.ScriptCompileResultFieldName, (object) this.ScriptCompileResult);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
            continue;
          case 2:
            GlobalScriptModulePublishingException.wicVDkbqJRqWmwehPSfd((object) this, (object) info, context);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          default:
            GlobalScriptModulePublishingException.cZHTfDbqdF8qZJdx6r00((object) info, (object) GlobalScriptModulePublishingException.GlobalScriptModuleHeaderIdFieldName, this.GlobalScriptModuleId);
            num = 3;
            continue;
        }
      }
label_2:;
    }

    private static string DefaultMessage => (string) GlobalScriptModulePublishingException.AQDFA5bq0U63Ln8bDdTw((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 1418292866));

    static GlobalScriptModulePublishingException()
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              GlobalScriptModulePublishingException.GlobalScriptModuleHeaderIdFieldName = (string) GlobalScriptModulePublishingException.dxalh9bqx7B6JcFlRRRJ(-105199646 ^ -105379952);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
              continue;
            case 2:
              TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_3;
            default:
              goto label_6;
          }
        }
label_6:
        GlobalScriptModulePublishingException.ScriptCompileResultFieldName = (string) GlobalScriptModulePublishingException.dxalh9bqx7B6JcFlRRRJ(372753449 ^ 372731531);
        num1 = 3;
      }
label_3:;
    }

    internal static bool BvgQJgbq68vyaa0gOdIg() => GlobalScriptModulePublishingException.wGKS01bq4YMvT8uV0EIG == null;

    internal static GlobalScriptModulePublishingException weRvYLbqHu3cerErQwgI() => GlobalScriptModulePublishingException.wGKS01bq4YMvT8uV0EIG;

    internal static object cNAsQabqAbZ949pqIjgG() => (object) GlobalScriptModulePublishingException.DefaultMessage;

    internal static void hFUsvMbq7TfriR8ahPwR() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object dxalh9bqx7B6JcFlRRRJ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object AQDFA5bq0U63Ln8bDdTw([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object cEq5s6bqmfY34xGYrqdp([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object aKkEqibqyfJudOdMiKpL([In] object obj0, [In] object obj1, [In] Type obj2) => ((SerializationInfo) obj0).GetValue((string) obj1, obj2);

    internal static long nthJwCbqMTl4PneZMRh8([In] object obj0, [In] object obj1) => ((SerializationInfo) obj0).GetInt64((string) obj1);

    internal static void wicVDkbqJRqWmwehPSfd([In] object obj0, [In] object obj1, [In] StreamingContext obj2) => __nonvirtual (((Exception) obj0).GetObjectData((SerializationInfo) obj1, obj2));

    internal static void q5Pp7Bbq9MteOvhdUs2w([In] object obj0, [In] object obj1, [In] object obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);

    internal static void cZHTfDbqdF8qZJdx6r00([In] object obj0, [In] object obj1, [In] long obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);
  }
}
