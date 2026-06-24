// Decompiled with JetBrains decompiler
// Type: rTtVXgHRgBSsFavshV.fousyr1O5TImehMQsy
// Assembly: EleWise.ELMA.BPM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EE1B80B5-F464-4FFF-85CF-6A69B66F676D
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.BPM.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.BPM.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace rTtVXgHRgBSsFavshV
{
  internal class fousyr1O5TImehMQsy
  {
    internal static object fou1syrO5;
    private static object ALGiMV0q9ulRuLoyyKI;

    internal static void Bsr5XbpwQN(int typemdt)
    {
      int num = 9;
      FieldInfo fieldInfo;
      Type type;
      MethodInfo methodInfo;
      FieldInfo[] fields;
      int index;
      while (true)
      {
        switch (num)
        {
          case 1:
            ++index;
            num = !fousyr1O5TImehMQsy.wW1XL40rTnHGWrpesQI() ? 0 : 0;
            continue;
          case 2:
          case 3:
            fieldInfo = fields[index];
            num = 4;
            continue;
          case 4:
            methodInfo = (MethodInfo) ((Module) fousyr1O5TImehMQsy.fou1syrO5).ResolveMethod(fousyr1O5TImehMQsy.A19tov0gXAsXvgVaZge((object) fieldInfo) + 100663296);
            num = 5;
            continue;
          case 5:
            fousyr1O5TImehMQsy.CQfCOEadexO40LQaMTN((object) fieldInfo, (object) null, (object) (MulticastDelegate) fousyr1O5TImehMQsy.yxLRNZ0zxRy8oqrEUcs(type, (object) methodInfo));
            num = !fousyr1O5TImehMQsy.wW1XL40rTnHGWrpesQI() ? 0 : 1;
            continue;
          case 7:
            goto label_11;
          case 8:
            fields = type.GetFields();
            num = 10;
            continue;
          case 9:
            type = fousyr1O5TImehMQsy.FcGPUn0HrhGHQFKRy0v(fousyr1O5TImehMQsy.fou1syrO5, 33554432 + typemdt);
            num = 8;
            continue;
          case 10:
            index = 0;
            num = 6;
            continue;
          default:
            if (index < fields.Length)
            {
              num = !fousyr1O5TImehMQsy.wW1XL40rTnHGWrpesQI() ? 2 : 2;
              continue;
            }
            goto label_5;
        }
      }
label_11:
      return;
label_5:;
    }

    public fousyr1O5TImehMQsy()
    {
      fousyr1O5TImehMQsy.OLc8eFai9UZog05DQIV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (true)
        num = 0;
      switch (num)
      {
      }
    }

    static fousyr1O5TImehMQsy()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            fousyr1O5TImehMQsy.fou1syrO5 = fousyr1O5TImehMQsy.sFZml4aurhJPYRveHII((object) typeof (fousyr1O5TImehMQsy).Assembly);
            num = true ? 0 : 0;
            continue;
          case 2:
            fousyr1O5TImehMQsy.OLc8eFai9UZog05DQIV();
            num = true ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static Type FcGPUn0HrhGHQFKRy0v([In] object obj0, [In] int obj1) => ((Module) obj0).ResolveType(obj1);

    internal static int A19tov0gXAsXvgVaZge([In] object obj0) => ((MemberInfo) obj0).MetadataToken;

    internal static object yxLRNZ0zxRy8oqrEUcs([In] Type obj0, [In] object obj1) => (object) Delegate.CreateDelegate(obj0, (MethodInfo) obj1);

    internal static void CQfCOEadexO40LQaMTN([In] object obj0, [In] object obj1, [In] object obj2) => ((FieldInfo) obj0).SetValue(obj1, obj2);

    internal static bool wW1XL40rTnHGWrpesQI() => fousyr1O5TImehMQsy.ALGiMV0q9ulRuLoyyKI == null;

    internal static fousyr1O5TImehMQsy m3EKg40QRVjhXcFZ3UP() => (fousyr1O5TImehMQsy) fousyr1O5TImehMQsy.ALGiMV0q9ulRuLoyyKI;

    internal static void OLc8eFai9UZog05DQIV() => TKW1L3mlUyvXmg29jA.RWk58XigPN();

    internal static object sFZml4aurhJPYRveHII([In] object obj0) => (object) ((Assembly) obj0).ManifestModule;

    internal delegate void SFU4mbT3GMret7THonf(object o);
  }
}
