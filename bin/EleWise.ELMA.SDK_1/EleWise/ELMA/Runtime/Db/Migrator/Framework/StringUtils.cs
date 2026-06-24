// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Migrator.Framework.StringUtils
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace EleWise.ELMA.Runtime.Db.Migrator.Framework
{
  public class StringUtils
  {
    private static StringUtils luvhWKW2nf19fkRwB4Fq;

    /// <summary>
    /// Convert a classname to something more readable.
    /// ex.: CreateATable =&gt; Create a table
    /// </summary>
    /// <param name="className"></param>
    /// <returns></returns>
    public static string ToHumanName(string className)
    {
      int num = 1;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            str = (string) StringUtils.Xa4pceW21E7xssTicXs8(StringUtils.X9T0P5W2PXlWQkUSlSAR((object) className, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1380439818 << 3 ^ 1841512550), StringUtils.tF8gJLW2eAMc93F7wfb5(-1638402543 ^ -1638534663)), 1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (string) StringUtils.kNVPG1W2pIbHZ4vkxPqw(StringUtils.voEPKrW2NOPgVUSBgDfH((object) str.Substring(0, 1)), StringUtils.yXuGXdW23Pl1x7G3HHfu((object) str.Substring(1)));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="template"></param>
    /// <param name="placeholder"></param>
    /// <param name="replacement"></param>
    /// <returns></returns>
    public static string ReplaceOnce(string template, string placeholder, string replacement)
    {
      int num = 2;
      int length;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (length >= 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            length = StringUtils.y93deiW2aqPS3W8rq9I2((object) template, (object) placeholder);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 1 : 0;
            continue;
          case 3:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return template;
label_3:
      return ((StringBuilder) StringUtils.rrXwhBW2DEPV8lK1ZPm9((object) new StringBuilder(template.Substring(0, length)), (object) replacement)).Append((string) StringUtils.Xa4pceW21E7xssTicXs8((object) template, length + StringUtils.Y8WN0EW2tyDFyVr3CjLQ((object) placeholder))).ToString();
    }

    public StringUtils()
    {
      StringUtils.wSV08aW2wtBLLaI6CwqU();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object tF8gJLW2eAMc93F7wfb5(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object X9T0P5W2PXlWQkUSlSAR([In] object obj0, [In] object obj1, [In] object obj2) => (object) Regex.Replace((string) obj0, (string) obj1, (string) obj2);

    internal static object Xa4pceW21E7xssTicXs8([In] object obj0, [In] int obj1) => (object) ((string) obj0).Substring(obj1);

    internal static object voEPKrW2NOPgVUSBgDfH([In] object obj0) => (object) ((string) obj0).ToUpper();

    internal static object yXuGXdW23Pl1x7G3HHfu([In] object obj0) => (object) ((string) obj0).ToLower();

    internal static object kNVPG1W2pIbHZ4vkxPqw([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static bool IHlJS2W2O6aQq84yUhp4() => StringUtils.luvhWKW2nf19fkRwB4Fq == null;

    internal static StringUtils MV8oLgW222LPIEMCiWA7() => StringUtils.luvhWKW2nf19fkRwB4Fq;

    internal static int y93deiW2aqPS3W8rq9I2([In] object obj0, [In] object obj1) => ((string) obj0).IndexOf((string) obj1);

    internal static object rrXwhBW2DEPV8lK1ZPm9([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).Append((string) obj1);

    internal static int Y8WN0EW2tyDFyVr3CjLQ([In] object obj0) => ((string) obj0).Length;

    internal static void wSV08aW2wtBLLaI6CwqU() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
