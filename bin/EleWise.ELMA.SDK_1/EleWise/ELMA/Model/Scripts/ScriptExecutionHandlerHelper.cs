// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.ScriptExecutionHandlerHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>Помощник для исполнителя сценариев</summary>
  public static class ScriptExecutionHandlerHelper
  {
    internal static ScriptExecutionHandlerHelper yqEvgRbu8d0Wh3xpA8IZ;

    /// <summary>Создать полное имя сборки из короткого имени</summary>
    /// <param name="assemblyShortName">Короткое имя сборки</param>
    /// <param name="version">Версия</param>
    /// <param name="culture">Культура</param>
    /// <param name="publicKey">Публичный ключ</param>
    /// <returns>Полное имя сборки</returns>
    public static string CreateFullAssemblyName(
      string assemblyShortName,
      string version = "1.0.0.0",
      string culture = "neutral",
      string publicKey = "null")
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_6;
            case 2:
              if (ScriptExecutionHandlerHelper.eeNUkFbuVqjSWPlh5lir((object) version))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
                continue;
              }
              goto label_6;
            case 3:
              goto label_5;
            default:
              version = (string) ScriptExecutionHandlerHelper.ikaZbNbuSaNsUb5nMZsj(-1822890472 ^ -1822946104);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 1;
              continue;
          }
        }
label_5:
        ScriptExecutionHandlerHelper.EK8mMsbuIU5KPRL9I1LQ((object) assemblyShortName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740433296));
        num1 = 2;
      }
label_6:
      return (string) ScriptExecutionHandlerHelper.dIktP6buia1WH5vX3PK3((object) new string[7]
      {
        assemblyShortName,
        (string) ScriptExecutionHandlerHelper.ikaZbNbuSaNsUb5nMZsj(~1767720452 ^ -1767895503),
        version,
        (string) ScriptExecutionHandlerHelper.ikaZbNbuSaNsUb5nMZsj(~-306453669 ^ 306621254),
        culture,
        (string) ScriptExecutionHandlerHelper.ikaZbNbuSaNsUb5nMZsj(-1867198571 ^ -1867089809),
        publicKey
      });
    }

    internal static void EK8mMsbuIU5KPRL9I1LQ([In] object obj0, [In] object obj1) => Contract.ArgumentNotNullOrEmpty((string) obj0, (string) obj1);

    internal static bool eeNUkFbuVqjSWPlh5lir([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object ikaZbNbuSaNsUb5nMZsj(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object dIktP6buia1WH5vX3PK3([In] object obj0) => (object) string.Concat((string[]) obj0);

    internal static bool vQslFwbuZW67fwdORBWN() => ScriptExecutionHandlerHelper.yqEvgRbu8d0Wh3xpA8IZ == null;

    internal static ScriptExecutionHandlerHelper OU0SRybuuiVka0rdkYJ9() => ScriptExecutionHandlerHelper.yqEvgRbu8d0Wh3xpA8IZ;
  }
}
