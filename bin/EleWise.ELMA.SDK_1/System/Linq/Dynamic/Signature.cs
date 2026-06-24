// Decompiled with JetBrains decompiler
// Type: System.Linq.Dynamic.Signature
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace System.Linq.Dynamic
{
  internal class Signature : IEquatable<Signature>
  {
    public DynamicProperty[] properties;
    public int hashCode;
    private static Signature rmnLHpbjjwt1s00H5mB;

    public Signature(IEnumerable<DynamicProperty> properties)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.properties = properties.ToArray<DynamicProperty>();
      this.hashCode = 0;
      foreach (DynamicProperty property in properties)
        this.hashCode ^= property.Name.GetHashCode() ^ property.Type.GetHashCode();
    }

    public override int GetHashCode() => this.hashCode;

    public override bool Equals(object obj)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (obj is Signature)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return false;
label_3:
      return this.Equals((Signature) obj);
    }

    public bool Equals(Signature other)
    {
      int num = 8;
      while (true)
      {
        int index;
        switch (num)
        {
          case 1:
          case 2:
            if (index >= this.properties.Length)
            {
              num = 3;
              continue;
            }
            goto case 4;
          case 3:
            goto label_14;
          case 4:
            if (Signature.XCYyVAbs18vu68lxRJk((object) this.properties[index].Name, Signature.syf582bUtLw2cPT7odm((object) other.properties[index])))
            {
              num = 5;
              continue;
            }
            break;
          case 5:
          case 6:
            goto label_12;
          case 7:
            goto label_6;
          case 8:
            if (this.properties.Length == other.properties.Length)
            {
              index = 0;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 1 : 1;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 1 : 7;
            continue;
        }
        if (Signature.Tr6gk1bzeIW8fgaOtgv(Signature.nR3hJMbcCHQIPa1i503((object) this.properties[index]), other.properties[index].Type))
        {
          num = 6;
        }
        else
        {
          ++index;
          num = 2;
        }
      }
label_6:
      return false;
label_12:
      return false;
label_14:
      return true;
    }

    internal static bool C9qqkIbYeF3nfxdAUpY() => Signature.rmnLHpbjjwt1s00H5mB == null;

    internal static Signature wdK8b3bL0jEbAVAFiiP() => Signature.rmnLHpbjjwt1s00H5mB;

    internal static object syf582bUtLw2cPT7odm([In] object obj0) => (object) ((DynamicProperty) obj0).Name;

    internal static bool XCYyVAbs18vu68lxRJk([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static Type nR3hJMbcCHQIPa1i503([In] object obj0) => ((DynamicProperty) obj0).Type;

    internal static bool Tr6gk1bzeIW8fgaOtgv([In] Type obj0, [In] Type obj1) => obj0 != obj1;
  }
}
