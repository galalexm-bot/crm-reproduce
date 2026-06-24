// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Exceptions.ExternalDataSourceExecutorConnectionException
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
  /// <summary>Исключение подключения к внешнему источнику данных</summary>
  [Serializable]
  public class ExternalDataSourceExecutorConnectionException : Exception
  {
    protected const string ExecutorNameKey = "ExecutorName";
    internal static ExternalDataSourceExecutorConnectionException fvGTDUGgLgXbPcFhwgcG;

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
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
    public ExternalDataSourceExecutorConnectionException(
      string executorName,
      Exception innerException)
    {
      ExternalDataSourceExecutorConnectionException.EotPHrGgc08F8UhwQE0d();
      // ISSUE: explicit constructor call
      base.\u002Ector(EleWise.ELMA.SR.T((string) ExternalDataSourceExecutorConnectionException.m16OsnGgzgGvBsalM6r2(-1852837372 ^ -1853103074), (object) executorName), innerException);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.ExecutorName = executorName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Ctor для десериализации</summary>
    /// <param name="info"></param>
    /// <param name="context"></param>
    public ExternalDataSourceExecutorConnectionException(
      SerializationInfo info,
      StreamingContext context)
    {
      ExternalDataSourceExecutorConnectionException.EotPHrGgc08F8UhwQE0d();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
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
            this.ExecutorName = (string) ExternalDataSourceExecutorConnectionException.N3UpvOG5Fo3dngtL2dls((object) info, ExternalDataSourceExecutorConnectionException.m16OsnGgzgGvBsalM6r2(372753449 ^ 372495009));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ExternalDataSourceExecutorConnectionException.GJTG5cG5BerLIDg4S6Sd((object) info, ExternalDataSourceExecutorConnectionException.m16OsnGgzgGvBsalM6r2(-1380439818 << 3 ^ 1841647928), (object) this.ExecutorName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
            continue;
          case 2:
            base.GetObjectData(info, context);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool rUWiuFGgU7u4ga4YlfSn() => ExternalDataSourceExecutorConnectionException.fvGTDUGgLgXbPcFhwgcG == null;

    internal static ExternalDataSourceExecutorConnectionException jbmsPBGgsAc1vQEyXWLw() => ExternalDataSourceExecutorConnectionException.fvGTDUGgLgXbPcFhwgcG;

    internal static void EotPHrGgc08F8UhwQE0d() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object m16OsnGgzgGvBsalM6r2(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object N3UpvOG5Fo3dngtL2dls([In] object obj0, [In] object obj1) => (object) ((SerializationInfo) obj0).GetString((string) obj1);

    internal static void GJTG5cG5BerLIDg4S6Sd([In] object obj0, [In] object obj1, [In] object obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);
  }
}
