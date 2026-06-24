// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Exceptions.MetadataPublishingException
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

namespace EleWise.ELMA.Exceptions
{
  /// <summary>Ошибка при публикации процесса</summary>
  [Serializable]
  public class MetadataPublishingException : Exception
  {
    internal static MetadataPublishingException wG0efAGjFed0ufFG8Rel;

    /// <summary>Ctor</summary>
    public MetadataPublishingException(Exception innerException)
    {
      MetadataPublishingException.mZpXYdGjocTFbBXH3mMl();
      // ISSUE: explicit constructor call
      base.\u002Ector((string) MetadataPublishingException.wbapkaGjbnw4SFSl73CV(), innerException);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="message">Сообщение</param>
    public MetadataPublishingException(string message)
    {
      MetadataPublishingException.mZpXYdGjocTFbBXH3mMl();
      // ISSUE: explicit constructor call
      base.\u002Ector(message);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="message">Сообщение</param>
    /// <param name="innerException">Исключение</param>
    public MetadataPublishingException(string message, Exception innerException)
    {
      MetadataPublishingException.mZpXYdGjocTFbBXH3mMl();
      // ISSUE: explicit constructor call
      base.\u002Ector(message, innerException);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="scriptCompileResult">Результаты компиляции сценариев</param>
    public MetadataPublishingException(ScriptCompileResult scriptCompileResult)
    {
      MetadataPublishingException.mZpXYdGjocTFbBXH3mMl();
      // ISSUE: explicit constructor call
      base.\u002Ector((string) MetadataPublishingException.wbapkaGjbnw4SFSl73CV() + (string) MetadataPublishingException.KIN4EeGjh1BvQEEldNS5(-1487388570 ^ -1487394766) + (string) MetadataPublishingException.HiR2NUGjGb3S3cUGSYAI(MetadataPublishingException.KIN4EeGjh1BvQEEldNS5(1461825605 - 1531863589 ^ -69999544)));
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.ScriptCompileResult = scriptCompileResult;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Ctor for serialization</summary>
    /// <param name="info"></param>
    /// <param name="context"></param>
    protected MetadataPublishingException(SerializationInfo info, StreamingContext context)
    {
      MetadataPublishingException.mZpXYdGjocTFbBXH3mMl();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: type reference
            this.ScriptCompileResult = (ScriptCompileResult) info.GetValue((string) MetadataPublishingException.KIN4EeGjh1BvQEEldNS5(1470440286 ^ 1470466556), MetadataPublishingException.SV2FPjGjEYZUWq0wAatl(__typeref (ScriptCompileResult)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            // ISSUE: type reference
            this.ValidationErrors = (MetadataItemValidationError[]) MetadataPublishingException.EJVNoxGjf0xOCXatLK6m((object) info, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886607549), MetadataPublishingException.SV2FPjGjEYZUWq0wAatl(__typeref (MetadataItemValidationError[])));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 2 : 2;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
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
            base.GetObjectData(info, context);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            MetadataPublishingException.KODxcWGjQLM3xpYCAK4F((object) info, MetadataPublishingException.KIN4EeGjh1BvQEEldNS5(-1146510045 ^ -1146548241), (object) this.ValidationErrors);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 2 : 1;
            continue;
          default:
            info.AddValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1574304498), (object) this.ScriptCompileResult);
            num = 3;
            continue;
        }
      }
label_2:;
    }

    private static string DefaultMessage => EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1410939939));

    internal static void mZpXYdGjocTFbBXH3mMl() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object wbapkaGjbnw4SFSl73CV() => (object) MetadataPublishingException.DefaultMessage;

    internal static bool F8KtKcGjBOuejMU1FYmj() => MetadataPublishingException.wG0efAGjFed0ufFG8Rel == null;

    internal static MetadataPublishingException CRGovLGjWBymfFtwOqnJ() => MetadataPublishingException.wG0efAGjFed0ufFG8Rel;

    internal static object KIN4EeGjh1BvQEEldNS5(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object HiR2NUGjGb3S3cUGSYAI([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static Type SV2FPjGjEYZUWq0wAatl([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object EJVNoxGjf0xOCXatLK6m([In] object obj0, [In] object obj1, [In] Type obj2) => ((SerializationInfo) obj0).GetValue((string) obj1, obj2);

    internal static void KODxcWGjQLM3xpYCAK4F([In] object obj0, [In] object obj1, [In] object obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);
  }
}
