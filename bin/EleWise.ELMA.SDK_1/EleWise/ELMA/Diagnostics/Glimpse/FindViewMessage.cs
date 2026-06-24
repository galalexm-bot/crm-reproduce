// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Glimpse.FindViewMessage
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Glimpse.Core.Message;
using Glimpse.Mvc.AlternateType;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Glimpse
{
  internal class FindViewMessage : 
    ViewEngine.FindViews.Message,
    ITimelineMessage,
    ITimedMessage,
    IMessage
  {
    private static FindViewMessage Jj3YZaEifyNIINXfbqi9;

    public FindViewMessage(
      Guid id,
      string viewName,
      string masterName,
      bool useCache,
      IEnumerable<string> searchedLocations,
      Type baseType,
      bool isPartial,
      bool isFound,
      string displayModeId,
      Type displayModeType)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(id, viewName, masterName, useCache, searchedLocations, baseType, isPartial, isFound, displayModeId, displayModeType);
    }

    [SpecialName]
    string ITimelineMessage.get_EventName() => (string) FindViewMessage.XJJHt5EivcRQlNYktYps((object) this);

    [SpecialName]
    void ITimelineMessage.set_EventName(string value)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            FindViewMessage.oZ9OCOEi8RKa5q30XuSw((object) this, (object) value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    [SpecialName]
    TimelineCategoryItem ITimelineMessage.get_EventCategory() => (TimelineCategoryItem) FindViewMessage.ARSL8vEiZvcvV68P6sAg((object) this);

    [SpecialName]
    void ITimelineMessage.set_EventCategory(TimelineCategoryItem value)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            FindViewMessage.SSamw3Eiuo0cDLTq4ryX((object) this, (object) value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    [SpecialName]
    string ITimelineMessage.get_EventSubText() => (string) FindViewMessage.FiH463EiIoTATQSx0KVH((object) this);

    [SpecialName]
    void ITimelineMessage.set_EventSubText(string value)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            FindViewMessage.aWI2ncEiV2lNB7K12amf((object) this, (object) value);
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

    internal static object XJJHt5EivcRQlNYktYps([In] object obj0) => (object) ((ViewEngine.FindViews.Message) obj0).EventName;

    internal static void oZ9OCOEi8RKa5q30XuSw([In] object obj0, [In] object obj1) => ((ViewEngine.FindViews.Message) obj0).EventName = (string) obj1;

    internal static bool poZNttEiQ9ixa2RbVKIL() => FindViewMessage.Jj3YZaEifyNIINXfbqi9 == null;

    internal static FindViewMessage DFBUbdEiC44bW7Dhpjx3() => FindViewMessage.Jj3YZaEifyNIINXfbqi9;

    internal static object ARSL8vEiZvcvV68P6sAg([In] object obj0) => (object) ((ViewEngine.FindViews.Message) obj0).EventCategory;

    internal static void SSamw3Eiuo0cDLTq4ryX([In] object obj0, [In] object obj1) => ((ViewEngine.FindViews.Message) obj0).EventCategory = (TimelineCategoryItem) obj1;

    internal static object FiH463EiIoTATQSx0KVH([In] object obj0) => (object) ((ViewEngine.FindViews.Message) obj0).EventSubText;

    internal static void aWI2ncEiV2lNB7K12amf([In] object obj0, [In] object obj1) => ((ViewEngine.FindViews.Message) obj0).EventSubText = (string) obj1;
  }
}
