// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.Int32RangeWrapperDescriptor
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
  [Component(Order = 1000)]
  public class Int32RangeWrapperDescriptor : ITypeWrapperDescriptor
  {
    private static Int32RangeWrapperDescriptor mXHo4xbE62OGpy5OMviZ;

    public Type OriginalType => typeof (Int32Range);

    public Type WrapperType => typeof (Int32RangeWrapper);

    public object CreateWrapper(object obj) => (object) new Int32RangeWrapper((Int32Range) obj);

    public object GetObject(object wrapper)
    {
      int num = 2;
      Int32Range int32Range;
      Int32RangeWrapper int32RangeWrapper;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (int32RangeWrapper == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 6 : 5;
              continue;
            }
            goto case 5;
          case 2:
            int32RangeWrapper = wrapper as Int32RangeWrapper;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 1;
            continue;
          case 3:
            int32Range.From = Int32RangeWrapperDescriptor.tS5PPPbE77WG7GLCAvEJ((object) int32RangeWrapper) ? new int?(Int32RangeWrapperDescriptor.T1Jm3ZbExpY7UlJI5pvk((object) int32RangeWrapper)) : new int?();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 7 : 4;
            continue;
          case 4:
            goto label_2;
          case 5:
            int32Range = new Int32Range();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 3;
            continue;
          case 6:
            int32Range = new Int32Range();
            num = 4;
            continue;
          case 7:
            int32Range.To = Int32RangeWrapperDescriptor.lkEAnnbE08FnrbkJKuOL((object) int32RangeWrapper) ? new int?(Int32RangeWrapperDescriptor.PSPYHxbEmFlvCp8y36Hb((object) int32RangeWrapper)) : new int?();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return (object) int32Range;
label_5:
      return (object) int32Range;
    }

    public Type[] GenericArgumentsTypes => (Type[]) null;

    public bool TestType(Type type) => false;

    public Int32RangeWrapperDescriptor()
    {
      Int32RangeWrapperDescriptor.aVcBUibEyxxWsvdoFySX();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool edS3CEbEHuC6hkewW06V() => Int32RangeWrapperDescriptor.mXHo4xbE62OGpy5OMviZ == null;

    internal static Int32RangeWrapperDescriptor SG85lAbEAY9CjINtQh6t() => Int32RangeWrapperDescriptor.mXHo4xbE62OGpy5OMviZ;

    internal static bool tS5PPPbE77WG7GLCAvEJ([In] object obj0) => ((Int32RangeWrapper) obj0).HasFromValue;

    internal static int T1Jm3ZbExpY7UlJI5pvk([In] object obj0) => ((Int32RangeWrapper) obj0).From;

    internal static bool lkEAnnbE08FnrbkJKuOL([In] object obj0) => ((Int32RangeWrapper) obj0).HasToValue;

    internal static int PSPYHxbEmFlvCp8y36Hb([In] object obj0) => ((Int32RangeWrapper) obj0).To;

    internal static void aVcBUibEyxxWsvdoFySX() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
