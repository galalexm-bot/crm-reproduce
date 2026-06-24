// Decompiled with JetBrains decompiler
// Type: System.Linq.Dynamic.DynamicClass
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Linq.Dynamic
{
  public abstract class DynamicClass
  {
    private static DynamicClass yQXYGsbpSfx546jttAY;

    public override string ToString()
    {
      int num = 12;
      StringBuilder stringBuilder;
      while (true)
      {
        PropertyInfo[] properties;
        int index;
        switch (num)
        {
          case 1:
            DynamicClass.a6uebUbwtN9XHE2aRu5((object) stringBuilder, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112702316));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
            continue;
          case 2:
          case 6:
            if (index >= properties.Length)
            {
              num = 7;
              continue;
            }
            goto case 8;
          case 3:
            DynamicClass.a6uebUbwtN9XHE2aRu5((object) stringBuilder, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -138016253));
            num = 9;
            continue;
          case 4:
            stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138157454));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 10 : 2;
            continue;
          case 5:
            goto label_3;
          case 7:
            stringBuilder.Append((string) DynamicClass.bAFjiZb6kOF3OflbMtI(1149433385 + 173655049 ^ 1323087394));
            num = 5;
            continue;
          case 8:
            if (index > 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 0;
              continue;
            }
            break;
          case 9:
            index = 0;
            num = 2;
            continue;
          case 10:
            DynamicClass.qhp36lb4EUuPFxDXwu9((object) stringBuilder, properties[index].GetValue((object) this, (object[]) null));
            num = 13;
            continue;
          case 11:
            stringBuilder = new StringBuilder();
            num = 3;
            continue;
          case 12:
            properties = DynamicClass.Uhe6JXbtm2jHc5o0NA3((object) this).GetProperties(BindingFlags.Instance | BindingFlags.Public);
            num = 11;
            continue;
          case 13:
            ++index;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 6 : 6;
            continue;
        }
        DynamicClass.a6uebUbwtN9XHE2aRu5((object) stringBuilder, (object) properties[index].Name);
        num = 4;
      }
label_3:
      return stringBuilder.ToString();
    }

    protected DynamicClass()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type Uhe6JXbtm2jHc5o0NA3([In] object obj0) => obj0.GetType();

    internal static object a6uebUbwtN9XHE2aRu5([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).Append((string) obj1);

    internal static object qhp36lb4EUuPFxDXwu9([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).Append(obj1);

    internal static object bAFjiZb6kOF3OflbMtI(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool ysS542baRrkOb8M9ptJ() => DynamicClass.yQXYGsbpSfx546jttAY == null;

    internal static DynamicClass ujYlnNbDEhcqqL4LWDE() => DynamicClass.yQXYGsbpSfx546jttAY;
  }
}
