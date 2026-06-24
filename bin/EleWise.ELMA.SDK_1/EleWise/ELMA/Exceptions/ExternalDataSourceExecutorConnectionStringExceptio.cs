// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Exceptions.ExternalDataSourceExecutorConnectionStringException
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
  /// Исключение строки подключения исполнителя внешнего источника данных
  /// </summary>
  [Serializable]
  public class ExternalDataSourceExecutorConnectionStringException : Exception
  {
    protected const string ExecutorNameKey = "ExecutorName";
    private static ExternalDataSourceExecutorConnectionStringException QcUeToG5WYiuvxKN4rDy;

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
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
    public ExternalDataSourceExecutorConnectionStringException(
      string executorName,
      Exception innerException)
    {
      ExternalDataSourceExecutorConnectionStringException.kUSLAYG5hOfnYbZkTagB();
      // ISSUE: explicit constructor call
      base.\u002Ector(EleWise.ELMA.SR.T((string) ExternalDataSourceExecutorConnectionStringException.HarFDYG5G7tfNjVD3n9i(--1360331293 ^ 1360073913), (object) executorName), innerException);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.ExecutorName = executorName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Ctor для десериализации</summary>
    /// <param name="info"></param>
    /// <param name="context"></param>
    public ExternalDataSourceExecutorConnectionStringException(
      SerializationInfo info,
      StreamingContext context)
    {
      ExternalDataSourceExecutorConnectionStringException.kUSLAYG5hOfnYbZkTagB();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.ExecutorName = (string) ExternalDataSourceExecutorConnectionStringException.bi7IekG5EC6HJ2sJLI55((object) info, ExternalDataSourceExecutorConnectionStringException.HarFDYG5G7tfNjVD3n9i(1581325282 << 3 ^ -234042984));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
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
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ExternalDataSourceExecutorConnectionStringException.nX91AdG5f2Ky8MfviG4B((object) this, (object) info, context);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            info.AddValue((string) ExternalDataSourceExecutorConnectionStringException.HarFDYG5G7tfNjVD3n9i(-643786247 ^ -643526799), (object) this.ExecutorName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool SeN7d6G5our9CBowDwdZ() => ExternalDataSourceExecutorConnectionStringException.QcUeToG5WYiuvxKN4rDy == null;

    internal static ExternalDataSourceExecutorConnectionStringException bsu5sSG5bw9mCLo1WtAZ() => ExternalDataSourceExecutorConnectionStringException.QcUeToG5WYiuvxKN4rDy;

    internal static void kUSLAYG5hOfnYbZkTagB() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object HarFDYG5G7tfNjVD3n9i(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object bi7IekG5EC6HJ2sJLI55([In] object obj0, [In] object obj1) => (object) ((SerializationInfo) obj0).GetString((string) obj1);

    internal static void nX91AdG5f2Ky8MfviG4B([In] object obj0, [In] object obj1, [In] StreamingContext obj2) => __nonvirtual (((Exception) obj0).GetObjectData((SerializationInfo) obj1, obj2));
  }
}
