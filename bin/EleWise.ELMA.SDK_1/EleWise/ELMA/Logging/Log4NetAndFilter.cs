// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Logging.Log4NetAndFilter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using log4net.Core;
using log4net.Filter;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Logging
{
  public class Log4NetAndFilter : FilterSkeleton
  {
    private readonly IList<IFilter> filters;
    internal static Log4NetAndFilter gBLRn4h9LwW09v0v4ZIW;

    public override FilterDecision Decide(LoggingEvent loggingEvent)
    {
      int num1 = 4;
      bool flag;
      FilterDecision filterDecision;
      IEnumerator<IFilter> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator = this.filters.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 2 : 2;
            continue;
          case 2:
            try
            {
label_12:
              if (enumerator.MoveNext())
                goto label_14;
              else
                goto label_13;
label_10:
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_12;
                  case 2:
                    filterDecision = FilterDecision.Deny;
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
                    continue;
                  case 3:
                    goto label_25;
                  case 4:
                    goto label_14;
                  default:
                    goto label_6;
                }
              }
label_13:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 2 : 3;
              goto label_10;
label_14:
              int num3 = (int) enumerator.Current.Decide(loggingEvent);
              if (num3 != 1)
                flag = false;
              if (num3 == -1)
              {
                num2 = 2;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0)
                {
                  num2 = 0;
                  goto label_10;
                }
                else
                  goto label_10;
              }
              else
                goto label_12;
            }
            finally
            {
              if (enumerator != null)
              {
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
                  num4 = 0;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_24;
                    default:
                      Log4NetAndFilter.z3Y6Gch9zWQxaSvN2EnU((object) enumerator);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 0;
                      continue;
                  }
                }
              }
label_24:;
            }
          case 3:
            goto label_2;
          case 4:
            if (loggingEvent != null)
            {
              flag = true;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 1 : 1;
              continue;
            }
            num1 = 3;
            continue;
          case 5:
label_25:
            if (!flag)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_2:
      throw new ArgumentNullException((string) Log4NetAndFilter.FRLG0oh9cuSpunqILUk0(~541731958 ^ -541702835));
label_4:
      return FilterDecision.Neutral;
label_5:
      return FilterDecision.Accept;
label_6:
      return filterDecision;
    }

    public IFilter Filter
    {
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.filters.Add(value);
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
    }

    public Log4NetAndFilter()
    {
      Log4NetAndFilter.D5U1DShdFSEhcekdmycW();
      this.filters = (IList<IFilter>) new List<IFilter>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object FRLG0oh9cuSpunqILUk0(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void z3Y6Gch9zWQxaSvN2EnU([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool NwR3hwh9UvVULyHmQKuG() => Log4NetAndFilter.gBLRn4h9LwW09v0v4ZIW == null;

    internal static Log4NetAndFilter G3Hxn8h9sGVsXoPO1GjF() => Log4NetAndFilter.gBLRn4h9LwW09v0v4ZIW;

    internal static void D5U1DShdFSEhcekdmycW() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
