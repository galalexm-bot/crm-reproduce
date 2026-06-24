// Decompiled with JetBrains decompiler
// Type: System.Linq.Dynamic.DynamicProperty
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace System.Linq.Dynamic
{
  public class DynamicProperty
  {
    private string name;
    private Type type;
    internal static DynamicProperty XZNAFKbHSMyfIFgnWm9;

    public DynamicProperty(string name, Type type)
    {
      DynamicProperty.dt2LNCbxhBlKySCBSSA();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            if (name != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
              continue;
            }
            goto label_8;
          case 3:
            goto label_2;
          case 4:
            this.type = type;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 0;
            continue;
          case 5:
            goto label_8;
          default:
            if (!DynamicProperty.CnUrVYb0Q9CXQd5GYcP(type, (Type) null))
            {
              this.name = name;
              num = 4;
              continue;
            }
            num = 3;
            continue;
        }
      }
label_4:
      return;
label_2:
      throw new ArgumentNullException((string) DynamicProperty.kjXxgdbmOVp7PFu6JM3(323422137 << 2 ^ 1293685446));
label_8:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -576148558));
    }

    public string Name => this.name;

    public Type Type => this.type;

    internal static void dt2LNCbxhBlKySCBSSA() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool CnUrVYb0Q9CXQd5GYcP([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object kjXxgdbmOVp7PFu6JM3(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool R7EuGebApLxPGHK41Du() => DynamicProperty.XZNAFKbHSMyfIFgnWm9 == null;

    internal static DynamicProperty pfJk3Db7FF0It54iFiw() => DynamicProperty.XZNAFKbHSMyfIFgnWm9;
  }
}
