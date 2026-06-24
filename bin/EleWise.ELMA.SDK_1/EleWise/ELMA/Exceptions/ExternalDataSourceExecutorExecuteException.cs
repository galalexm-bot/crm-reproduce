// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Exceptions.ExternalDataSourceExecutorExecuteException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Exceptions
{
  /// <summary>
  /// Исключение выполнения запроса к внешнему источнику данных
  /// </summary>
  [Serializable]
  public class ExternalDataSourceExecutorExecuteException : Exception
  {
    protected const string ExecutorNameKey = "ExecutorName";
    private static ExternalDataSourceExecutorExecuteException UgE8xyG5QR4UrnGEH1Sf;

    /// <summary>Имя исполнителя</summary>
    public string ExecutorName
    {
      get => this.\u003CExecutorName\u003Ek__BackingField;
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
              this.\u003CExecutorName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
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

    /// <summary>Ctor</summary>
    /// <param name="executorName">Имя исполнителя</param>
    public ExternalDataSourceExecutorExecuteException(string executorName, Exception innerException)
    {
      ExternalDataSourceExecutorExecuteException.aVoYe2G58ZDmuARpdLkx();
      // ISSUE: explicit constructor call
      base.\u002Ector(EleWise.ELMA.SR.T((string) ExternalDataSourceExecutorExecuteException.xDBb1gG5ZA1TRVbGWqS3(-740338220 ^ -740605196), (object) executorName), innerException);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.ExecutorName = executorName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Ctor для десериализации</summary>
    /// <param name="info"></param>
    /// <param name="context"></param>
    public ExternalDataSourceExecutorExecuteException(
      SerializationInfo info,
      StreamingContext context)
    {
      ExternalDataSourceExecutorExecuteException.aVoYe2G58ZDmuARpdLkx();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.ExecutorName = info.GetString((string) ExternalDataSourceExecutorExecuteException.xDBb1gG5ZA1TRVbGWqS3(-787452571 ^ -787186707));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
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
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ExternalDataSourceExecutorExecuteException.LHbU5WG5uBxsGMCnKs7c((object) info, ExternalDataSourceExecutorExecuteException.xDBb1gG5ZA1TRVbGWqS3(236071375 ^ 236339015), (object) this.ExecutorName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool HqQ6cDG5CAm8cQw89Jsj() => ExternalDataSourceExecutorExecuteException.UgE8xyG5QR4UrnGEH1Sf == null;

    internal static ExternalDataSourceExecutorExecuteException jh2IXAG5vjx2bG7n6JEq() => ExternalDataSourceExecutorExecuteException.UgE8xyG5QR4UrnGEH1Sf;

    internal static void aVoYe2G58ZDmuARpdLkx() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object xDBb1gG5ZA1TRVbGWqS3(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void LHbU5WG5uBxsGMCnKs7c([In] object obj0, [In] object obj1, [In] object obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);
  }
}
