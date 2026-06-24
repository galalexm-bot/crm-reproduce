// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FormNotifierExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Views;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA
{
  public static class FormNotifierExtensions
  {
    internal static FormNotifierExtensions sYbuCyQp9ZeQO0WcFDT;

    public static void Error(this IFormNotifier notifier, Exception exception)
    {
      int num = 5;
      while (true)
      {
        string message;
        Exception exception1;
        switch (num)
        {
          case 1:
            exception1 = (Exception) null;
            break;
          case 2:
            exception1 = exception;
            goto label_11;
          case 3:
            goto label_2;
          case 4:
            exception1 = exception.InnerException;
            break;
          case 5:
            if (exception is ElmaInvalidOperationException)
            {
              num = 4;
              continue;
            }
            goto case 1;
          default:
            FormNotifierExtensions.f2FPP6Qtmf5AsCS8nhE((object) notifier, (object) message);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 3 : 3;
            continue;
        }
        if (exception1 == null)
        {
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 1 : 2;
          continue;
        }
label_11:
        message = exception1.Message;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
      }
label_2:;
    }

    internal static void f2FPP6Qtmf5AsCS8nhE([In] object obj0, [In] object obj1) => ((IFormNotifier) obj0).Error((string) obj1);

    internal static bool BEW54PQa4vmoOhlZySI() => FormNotifierExtensions.sYbuCyQp9ZeQO0WcFDT == null;

    internal static FormNotifierExtensions zH6tBoQDe0cRRp87Gik() => FormNotifierExtensions.sYbuCyQp9ZeQO0WcFDT;
  }
}
