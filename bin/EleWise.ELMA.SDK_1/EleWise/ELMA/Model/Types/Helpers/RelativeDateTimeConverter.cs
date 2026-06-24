// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.RelativeDateTimeConverter
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
  [Component(Order = 3000)]
  public class RelativeDateTimeConverter : IConvertTypeWrapper
  {
    internal static RelativeDateTimeConverter sDiHZJbhGM73NNxqlypD;

    public Type OriginalType => RelativeDateTimeConverter.BY7gIHbhQpjhjDuLqo1X(__typeref (DateTimeRange));

    public Type ConvertType => typeof (RelativeDateTime);

    public bool RelativeConvertNeeded(Type type) => type.IsAssignableFrom(RelativeDateTimeConverter.BY7gIHbhQpjhjDuLqo1X(__typeref (DateTimeRange)));

    public object ConvertWrapper(object obj)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!this.RelativeConvertNeeded(obj.GetType()))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      RelativeDateTime relativeDateTime = new RelativeDateTime();
      RelativeDateTimeConverter.uvhAnXbhCLnBffOxkZa3((object) relativeDateTime, new DateTimeRange()
      {
        From = ((DateTimeRange) obj).From,
        To = ((DateTimeRange) obj).To
      });
      RelativeDateTimeConverter.S1cdVsbhvVvuF2UUrDcV((object) relativeDateTime, false);
      RelativeDateTimeConverter.IcArkibh8Phgli3RXbKt((object) relativeDateTime, (object) null);
      relativeDateTime.RelativeTo = (string) null;
      return (object) relativeDateTime;
label_3:
      return obj;
    }

    public RelativeDateTimeConverter()
    {
      RelativeDateTimeConverter.BWQWZsbhZEp0YjfaGn1L();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type BY7gIHbhQpjhjDuLqo1X([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool JNv3lEbhEc9FuRZ0Fs5K() => RelativeDateTimeConverter.sDiHZJbhGM73NNxqlypD == null;

    internal static RelativeDateTimeConverter KmOpAXbhfVSof7d5PkV2() => RelativeDateTimeConverter.sDiHZJbhGM73NNxqlypD;

    internal static void uvhAnXbhCLnBffOxkZa3([In] object obj0, DateTimeRange value) => ((RelativeDateTime) obj0).DateTimeRange = value;

    internal static void S1cdVsbhvVvuF2UUrDcV([In] object obj0, bool value) => ((RelativeDateTime) obj0).IsRelative = value;

    internal static void IcArkibh8Phgli3RXbKt([In] object obj0, [In] object obj1) => ((RelativeDateTime) obj0).RelativeFrom = (string) obj1;

    internal static void BWQWZsbhZEp0YjfaGn1L() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
