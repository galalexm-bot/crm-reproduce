// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.RelativeDateTimeDateTimeNullConverter
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
  public class RelativeDateTimeDateTimeNullConverter : IConvertTypeWrapper
  {
    internal static RelativeDateTimeDateTimeNullConverter JoqV5ubh7MgXOdMqvrW7;

    public Type OriginalType => RelativeDateTimeDateTimeNullConverter.glQgtVbhmgs9LiIrBCDF(__typeref (RelativeDateTime));

    public Type ConvertType => RelativeDateTimeDateTimeNullConverter.glQgtVbhmgs9LiIrBCDF(__typeref (DateTime?));

    public bool RelativeConvertNeeded(Type type) => true;

    public object ConvertWrapper(object obj)
    {
      int num = 1;
      DateTimeRange dateTimeRange;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.RelativeConvertNeeded(obj.GetType()))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            goto label_5;
          default:
            dateTimeRange = RelativeDateTimeDateTimeNullConverter.QKPJBRbhywTx91aNbr8w((object) (RelativeDateTime) obj);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 2;
            continue;
        }
      }
label_5:
      return (object) dateTimeRange.From;
label_6:
      return obj;
    }

    public RelativeDateTimeDateTimeNullConverter()
    {
      RelativeDateTimeDateTimeNullConverter.gFPqINbhMYFQ09PZkNJs();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type glQgtVbhmgs9LiIrBCDF([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static DateTimeRange QKPJBRbhywTx91aNbr8w([In] object obj0) => ((RelativeDateTime) obj0).DateTimeRange;

    internal static bool k2lxFebhxuP2CBSFWUS4() => RelativeDateTimeDateTimeNullConverter.JoqV5ubh7MgXOdMqvrW7 == null;

    internal static RelativeDateTimeDateTimeNullConverter UpNV4jbh0F5H7qQGfiYN() => RelativeDateTimeDateTimeNullConverter.JoqV5ubh7MgXOdMqvrW7;

    internal static void gFPqINbhMYFQ09PZkNJs() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
