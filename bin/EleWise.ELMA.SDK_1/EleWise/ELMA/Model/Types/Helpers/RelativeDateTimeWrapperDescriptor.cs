// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.RelativeDateTimeWrapperDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types.Helpers
{
  [Component(Order = 2000)]
  public class RelativeDateTimeWrapperDescriptor : ITypeWrapperDescriptor
  {
    internal static RelativeDateTimeWrapperDescriptor jxYRjEbb5POJBYifcjx0;

    public Type OriginalType => RelativeDateTimeWrapperDescriptor.zUOB0ybbLy5eZLZnh8kA(__typeref (RelativeDateTime));

    public Type WrapperType => RelativeDateTimeWrapperDescriptor.zUOB0ybbLy5eZLZnh8kA(__typeref (RelativeDateTimeWrapper));

    public bool TestType(Type type) => false;

    public object CreateWrapper(object obj) => (object) new RelativeDateTimeWrapper((RelativeDateTime) obj);

    public object GetObject(object wrapper)
    {
      int num = 2;
      DateTimeRangeWrapper timeRangeWrapper;
      DateTimeRange dateTimeRange;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (timeRangeWrapper != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
              continue;
            }
            goto label_9;
          case 2:
            timeRangeWrapper = wrapper as DateTimeRangeWrapper;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 1 : 1;
            continue;
          case 3:
            dateTimeRange.To = ((DateTimeWrapper) RelativeDateTimeWrapperDescriptor.HnfbqibbskIFx4AswUpm((object) timeRangeWrapper)).Value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 4;
            continue;
          case 4:
            goto label_8;
          case 5:
            dateTimeRange.From = ((DateTimeWrapper) RelativeDateTimeWrapperDescriptor.T8Tt5EbbUZxxpqj64orO((object) timeRangeWrapper)).Value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 1 : 3;
            continue;
          default:
            dateTimeRange = new DateTimeRange();
            num = 5;
            continue;
        }
      }
label_8:
      return (object) dateTimeRange;
label_9:
      RelativeDateTime relativeDateTime = new RelativeDateTime();
      RelativeDateTimeWrapperDescriptor.QuDYDPbbzjJejuZB6oI3((object) relativeDateTime, RelativeDateTimeWrapperDescriptor.volvD3bbcHKcvrOFeIMG((object) (RelativeDateTimeWrapper) wrapper));
      RelativeDateTimeWrapperDescriptor.yP1HSZbhBwtYAq4w0RwF((object) relativeDateTime, RelativeDateTimeWrapperDescriptor.uBsH7EbhFQypJMJCI4aS((object) (RelativeDateTimeWrapper) wrapper) == null ? new DateTimeRange(new DateTime?(), new DateTime?()) : new DateTimeRange(((DateTimeWrapper) RelativeDateTimeWrapperDescriptor.T8Tt5EbbUZxxpqj64orO(RelativeDateTimeWrapperDescriptor.uBsH7EbhFQypJMJCI4aS((object) (RelativeDateTimeWrapper) wrapper))).Value, ((DateTimeRangeWrapper) RelativeDateTimeWrapperDescriptor.uBsH7EbhFQypJMJCI4aS((object) (RelativeDateTimeWrapper) wrapper)).To.Value));
      relativeDateTime.RelativeFrom = (string) RelativeDateTimeWrapperDescriptor.oOgVC6bhW93aW5Fbrqg1((object) (RelativeDateTimeWrapper) wrapper);
      RelativeDateTimeWrapperDescriptor.GX9TMEbhbcvYMrPQImTy((object) relativeDateTime, RelativeDateTimeWrapperDescriptor.AJbJqEbhoarvo6KbeFLe((object) (RelativeDateTimeWrapper) wrapper));
      return (object) relativeDateTime;
    }

    public RelativeDateTimeWrapperDescriptor()
    {
      RelativeDateTimeWrapperDescriptor.VcgnGZbhh5kAZNnpfOlS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type zUOB0ybbLy5eZLZnh8kA([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool qJQTt4bbj5j1eVCcdSC3() => RelativeDateTimeWrapperDescriptor.jxYRjEbb5POJBYifcjx0 == null;

    internal static RelativeDateTimeWrapperDescriptor y5tURqbbYkihaGIOVNiy() => RelativeDateTimeWrapperDescriptor.jxYRjEbb5POJBYifcjx0;

    internal static object T8Tt5EbbUZxxpqj64orO([In] object obj0) => (object) ((DateTimeRangeWrapper) obj0).From;

    internal static object HnfbqibbskIFx4AswUpm([In] object obj0) => (object) ((DateTimeRangeWrapper) obj0).To;

    internal static bool volvD3bbcHKcvrOFeIMG([In] object obj0) => ((RelativeDateTimeWrapper) obj0).IsRelative;

    internal static void QuDYDPbbzjJejuZB6oI3([In] object obj0, bool value) => ((RelativeDateTime) obj0).IsRelative = value;

    internal static object uBsH7EbhFQypJMJCI4aS([In] object obj0) => (object) ((RelativeDateTimeWrapper) obj0).DateTimeRange;

    internal static void yP1HSZbhBwtYAq4w0RwF([In] object obj0, DateTimeRange value) => ((RelativeDateTime) obj0).DateTimeRange = value;

    internal static object oOgVC6bhW93aW5Fbrqg1([In] object obj0) => (object) ((RelativeDateTimeWrapper) obj0).RelativeFrom;

    internal static object AJbJqEbhoarvo6KbeFLe([In] object obj0) => (object) ((RelativeDateTimeWrapper) obj0).RelativeTo;

    internal static void GX9TMEbhbcvYMrPQImTy([In] object obj0, [In] object obj1) => ((RelativeDateTime) obj0).RelativeTo = (string) obj1;

    internal static void VcgnGZbhh5kAZNnpfOlS() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
