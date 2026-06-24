// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.FormNotifier
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Web.Mvc;

namespace EleWise.ELMA.Model.Views
{
  internal class FormNotifier : IFormNotifier
  {
    /// <summary>Список сообщений</summary>
    [Obsolete("Поле устарело, используйте mvcMessages")]
    private List<KeyValuePair<string, string>> messages;
    /// <summary>Список сообщений</summary>
    private List<KeyValuePair<string, MvcHtmlString>> mvcMessages;
    internal static FormNotifier RTa8ckoXUDtOI0mBfkKC;

    public FormNotifier()
    {
      FormNotifier.BS80fDoXz6i1yAKdjrMm();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.mvcMessages = new List<KeyValuePair<string, MvcHtmlString>>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 2 : 2;
            continue;
          case 2:
            goto label_3;
          default:
            this.messages = new List<KeyValuePair<string, string>>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Отобразить информативное сообщение</summary>
    /// <param name="text"></param>
    public void Information(string text)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.mvcMessages.Add(new KeyValuePair<string, MvcHtmlString>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108798308), (MvcHtmlString) FormNotifier.hrLJ3foTFSPlRIjL5k6Q((object) text.HtmlEncode())));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Отобразить предупреждающее сообщение</summary>
    /// <param name="text"></param>
    public void Warning(string text)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.mvcMessages.Add(new KeyValuePair<string, MvcHtmlString>((string) FormNotifier.pTIxr5oTBa244Tdnskso(-1939377524 ^ -1939526070), (MvcHtmlString) FormNotifier.hrLJ3foTFSPlRIjL5k6Q(FormNotifier.C7bNSToTWFSyem3tTyAk((object) text))));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Отобразить сообщение об ошибке</summary>
    /// <param name="text"></param>
    public void Error(string text)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.mvcMessages.Add(new KeyValuePair<string, MvcHtmlString>((string) FormNotifier.pTIxr5oTBa244Tdnskso(1319452732 ^ 1319574756), (MvcHtmlString) FormNotifier.hrLJ3foTFSPlRIjL5k6Q((object) text.HtmlEncode())));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Отобразить информативное сообщение</summary>
    /// <param name="text"></param>
    public void Information(MvcHtmlString text)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.mvcMessages.Add(new KeyValuePair<string, MvcHtmlString>((string) FormNotifier.pTIxr5oTBa244Tdnskso(1033719030 - 2012070891 ^ -978463321), text));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Отобразить предупреждающее сообщение</summary>
    /// <param name="text"></param>
    public void Warning(MvcHtmlString text)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.mvcMessages.Add(new KeyValuePair<string, MvcHtmlString>((string) FormNotifier.pTIxr5oTBa244Tdnskso(-812025778 ^ -811916152), text));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Отобразить сообщение об ошибке</summary>
    /// <param name="text"></param>
    public void Error(MvcHtmlString text)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.mvcMessages.Add(new KeyValuePair<string, MvcHtmlString>((string) FormNotifier.pTIxr5oTBa244Tdnskso(--1333735954 ^ 1333620426), text));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Список сообщений</summary>
    [Obsolete("Свойство устарело, используйте MvcMessages")]
    public List<KeyValuePair<string, string>> Messages => this.messages;

    /// <summary>Список сообщений</summary>
    public List<KeyValuePair<string, MvcHtmlString>> MvcMessages => this.mvcMessages;

    internal static void BS80fDoXz6i1yAKdjrMm() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool XfD8iKoXsdvvenConXLw() => FormNotifier.RTa8ckoXUDtOI0mBfkKC == null;

    internal static FormNotifier s6j9vjoXcNBVHTQSp3j1() => FormNotifier.RTa8ckoXUDtOI0mBfkKC;

    internal static object hrLJ3foTFSPlRIjL5k6Q([In] object obj0) => (object) MvcHtmlString.Create((string) obj0);

    internal static object pTIxr5oTBa244Tdnskso(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object C7bNSToTWFSyem3tTyAk([In] object obj0) => (object) ((string) obj0).HtmlEncode();
  }
}
