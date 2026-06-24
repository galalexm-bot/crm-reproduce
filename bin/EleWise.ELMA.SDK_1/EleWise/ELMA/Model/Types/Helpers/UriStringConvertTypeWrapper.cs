// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.UriStringConvertTypeWrapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types.Helpers
{
  [Component]
  public class UriStringConvertTypeWrapper : IConvertTypeWrapper
  {
    internal static UriStringConvertTypeWrapper opH4EIbbV7MN4Je0afdO;

    public Type OriginalType => UriStringConvertTypeWrapper.TG7B3obbRxlBVjFgevyf(__typeref (Uri));

    public Type ConvertType => UriStringConvertTypeWrapper.TG7B3obbRxlBVjFgevyf(__typeref (string));

    public bool RelativeConvertNeeded(Type type) => true;

    public object ConvertWrapper(object obj)
    {
      int num = 3;
      Uri uri;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (!UriStringConvertTypeWrapper.FxresJbbq6oanc41hXJG((object) uri, (object) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 3:
            uri = (Uri) obj;
            num = 2;
            continue;
          default:
            goto label_3;
        }
      }
label_2:
      return (object) string.Empty;
label_3:
      return (object) uri.OriginalString;
    }

    public UriStringConvertTypeWrapper()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type TG7B3obbRxlBVjFgevyf([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool FxresJbbq6oanc41hXJG([In] object obj0, [In] object obj1) => (Uri) obj0 == (Uri) obj1;

    internal static bool DgdTqjbbSctOfDXru9Jo() => UriStringConvertTypeWrapper.opH4EIbbV7MN4Je0afdO == null;

    internal static UriStringConvertTypeWrapper awKtjnbbiIPf82Qmon6t() => UriStringConvertTypeWrapper.opH4EIbbV7MN4Je0afdO;
  }
}
