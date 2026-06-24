// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.HashCodeHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Collections;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Helpers
{
  public static class HashCodeHelper
  {
    internal static HashCodeHelper DggWwbhc81qpplBV6ACE;

    public static int GetGashCode32(IEnumerable enumerable)
    {
      HashCodeCombiner hashCodeCombiner = new HashCodeCombiner();
      HashCodeHelper.pZ1YBihcI7K2fHERkmaQ((object) hashCodeCombiner, (object) enumerable);
      return HashCodeHelper.jfOfsDhcV8Tke2R2Rv0P((object) hashCodeCombiner);
    }

    public static string GetGashCodeString(IEnumerable enumerable)
    {
      HashCodeCombiner hashCodeCombiner = new HashCodeCombiner();
      HashCodeHelper.pZ1YBihcI7K2fHERkmaQ((object) hashCodeCombiner, (object) enumerable);
      return hashCodeCombiner.CombinedHashString;
    }

    internal static void pZ1YBihcI7K2fHERkmaQ([In] object obj0, [In] object obj1) => ((HashCodeCombiner) obj0).AddEnumerable((IEnumerable) obj1);

    internal static int jfOfsDhcV8Tke2R2Rv0P([In] object obj0) => ((HashCodeCombiner) obj0).CombinedHash32;

    internal static bool LAr55KhcZvQdhcnhHQrF() => HashCodeHelper.DggWwbhc81qpplBV6ACE == null;

    internal static HashCodeHelper G7aophhcucgJPuQkZ83u() => HashCodeHelper.DggWwbhc81qpplBV6ACE;
  }
}
