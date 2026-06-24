// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.StreamReaderExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using SG9KiyIbtdgGDf12qr;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions
{
  /// <summary>
  /// Методы расширения для <see cref="T:System.IO.StreamReader" />
  /// </summary>
  public static class StreamReaderExtensions
  {
    private static StreamReaderExtensions bB6sJXG3JyDuDqWEdlQ0;

    /// <summary>
    /// Проверить наличие внутренного BOM символа и скорректировать его
    /// </summary>
    /// <param name="streamReader">Читатель потока</param>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static void CheckAndCorrectInternalBOMSymbols(this StreamReader streamReader)
    {
      int num1 = 5;
      while (true)
      {
        int num2;
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            if (num2 != 65279)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 3 : 2;
              continue;
            }
            break;
          case 3:
            if (num2 == 65534)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
              continue;
            }
            goto label_10;
          case 4:
            num2 = StreamReaderExtensions.L2owD2G3gXX6Rdx4nqGc((object) streamReader);
            num1 = 2;
            continue;
          case 5:
            StreamReaderExtensions.XhRbLsG3rifkrdreVcnx((object) streamReader, StreamReaderExtensions.l4QKiTG3l1nctrdQ3gWe(-1852837372 ^ -1853094750));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 4 : 1;
            continue;
        }
        StreamReaderExtensions.EtKRcdG35kCBaqu7958n((object) streamReader);
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 0;
      }
label_2:
      return;
label_10:;
    }

    internal static object l4QKiTG3l1nctrdQ3gWe(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void XhRbLsG3rifkrdreVcnx([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static int L2owD2G3gXX6Rdx4nqGc([In] object obj0) => ((TextReader) obj0).Peek();

    internal static int EtKRcdG35kCBaqu7958n([In] object obj0) => ((TextReader) obj0).Read();

    internal static bool CIQHjqG39JXYYY0QogrN() => StreamReaderExtensions.bB6sJXG3JyDuDqWEdlQ0 == null;

    internal static StreamReaderExtensions os5BeBG3dQ36adCTsupd() => StreamReaderExtensions.bB6sJXG3JyDuDqWEdlQ0;
  }
}
