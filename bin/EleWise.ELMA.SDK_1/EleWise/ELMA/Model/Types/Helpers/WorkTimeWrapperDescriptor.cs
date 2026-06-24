// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.WorkTimeWrapperDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types.Helpers
{
  [Component]
  public class WorkTimeWrapperDescriptor : ITypeWrapperDescriptor
  {
    private static WorkTimeWrapperDescriptor QI7QSZboUAkxPA0AGXPq;

    public Type OriginalType => typeof (WorkTime);

    public Type WrapperType => WorkTimeWrapperDescriptor.yVuo1pbozm5sh3nqB7nk(__typeref (WorkTimeWrapper));

    public object CreateWrapper(object obj)
    {
      int num = 1;
      WorkTime source;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(obj is WorkTime))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
              continue;
            }
            goto case 4;
          case 2:
            goto label_3;
          case 3:
            if (source.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 2 : 2;
              continue;
            }
            goto label_4;
          case 4:
            source = (WorkTime) obj;
            num = 3;
            continue;
          default:
            goto label_4;
        }
      }
label_3:
      return (object) new WorkTimeWrapper(source);
label_4:
      return (object) null;
    }

    public object GetObject(object wrapper)
    {
      int num = 3;
      WorkTimeWrapper workTimeWrapper;
      WorkTime workTime;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (workTimeWrapper == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 3:
            workTimeWrapper = wrapper as WorkTimeWrapper;
            num = 2;
            continue;
          case 4:
            goto label_3;
          default:
            workTime = new WorkTime();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:
      return (object) new WorkTime(WorkTimeWrapperDescriptor.rCROVQbbFv3bXmCq8lBh((object) workTimeWrapper));
label_5:
      return (object) workTime;
    }

    public Type[] GenericArgumentsTypes => (Type[]) null;

    public bool TestType(Type type) => false;

    public WorkTimeWrapperDescriptor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type yVuo1pbozm5sh3nqB7nk([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool yUBiHobosgjXsupGQttp() => WorkTimeWrapperDescriptor.QI7QSZboUAkxPA0AGXPq == null;

    internal static WorkTimeWrapperDescriptor E9r0Nuboc11ev9x7Wr0j() => WorkTimeWrapperDescriptor.QI7QSZboUAkxPA0AGXPq;

    internal static long rCROVQbbFv3bXmCq8lBh([In] object obj0) => ((WorkTimeWrapper) obj0).Value;
  }
}
