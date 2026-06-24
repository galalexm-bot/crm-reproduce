// Decompiled with JetBrains decompiler
// Type: rTtVXgHRgBSsFavshV.fousyr1O5TImehMQsy
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace rTtVXgHRgBSsFavshV
{
  internal class fousyr1O5TImehMQsy
  {
    internal static Module fou1syrO5;
    internal static fousyr1O5TImehMQsy VhS1xYZDvQgHLPlDKKjk;

    internal static void PfsZt2h2WRD(int typemdt)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        FieldInfo[] fields;
        int index;
        FieldInfo fieldInfo;
        Type type;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 10:
              fieldInfo = fields[index];
              num2 = 5;
              continue;
            case 2:
              ++index;
              num2 = fousyr1O5TImehMQsy.OeIt4mZD8wVJ6YgxjfCA() ? 0 : 0;
              continue;
            case 3:
              fields = type.GetFields();
              num2 = 7;
              continue;
            case 4:
              type = fousyr1O5TImehMQsy.wvfpo5ZDuRfraCwqCJuj((object) fousyr1O5TImehMQsy.fou1syrO5, 33554432 + typemdt);
              num2 = !fousyr1O5TImehMQsy.OeIt4mZD8wVJ6YgxjfCA() ? 2 : 3;
              continue;
            case 5:
              goto label_4;
            case 7:
              index = 0;
              num2 = fousyr1O5TImehMQsy.OeIt4mZD8wVJ6YgxjfCA() ? 6 : 6;
              continue;
            case 8:
              goto label_9;
            case 9:
              goto label_10;
            default:
              if (index < fields.Length)
              {
                num2 = !fousyr1O5TImehMQsy.OeIt4mZD8wVJ6YgxjfCA() ? 0 : 1;
                continue;
              }
              goto label_8;
          }
        }
label_4:
        MethodInfo methodInfo = (MethodInfo) fousyr1O5TImehMQsy.fou1syrO5.ResolveMethod(fousyr1O5TImehMQsy.xmokcSZDIgccbImxTuou((object) fieldInfo) + 100663296);
        num1 = 9;
        continue;
label_10:
        fousyr1O5TImehMQsy.dj3iYcZDSo1GtHtLT8Yr((object) fieldInfo, (object) null, (object) (MulticastDelegate) fousyr1O5TImehMQsy.NCapjLZDVAlJHevK9tZy(type, (object) methodInfo));
        num1 = 2;
      }
label_9:
      return;
label_8:;
    }

    public fousyr1O5TImehMQsy()
    {
      fousyr1O5TImehMQsy.NVnOtoZDilkdREZZSnSU();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (false)
        num = 0;
      switch (num)
      {
      }
    }

    static fousyr1O5TImehMQsy()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            fousyr1O5TImehMQsy.NVnOtoZDilkdREZZSnSU();
            num = false ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            // ISSUE: type reference
            fousyr1O5TImehMQsy.fou1syrO5 = (Module) fousyr1O5TImehMQsy.XM6ATDZDqg4yHPRKeeeK((object) fousyr1O5TImehMQsy.mhv8bdZDRZgcgavAkTnr(__typeref (fousyr1O5TImehMQsy)).Assembly);
            num = true ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static Type wvfpo5ZDuRfraCwqCJuj([In] object obj0, [In] int obj1) => ((Module) obj0).ResolveType(obj1);

    internal static int xmokcSZDIgccbImxTuou([In] object obj0) => ((MemberInfo) obj0).MetadataToken;

    internal static object NCapjLZDVAlJHevK9tZy([In] Type obj0, [In] object obj1) => (object) Delegate.CreateDelegate(obj0, (MethodInfo) obj1);

    internal static void dj3iYcZDSo1GtHtLT8Yr([In] object obj0, [In] object obj1, [In] object obj2) => ((FieldInfo) obj0).SetValue(obj1, obj2);

    internal static bool OeIt4mZD8wVJ6YgxjfCA() => fousyr1O5TImehMQsy.VhS1xYZDvQgHLPlDKKjk == null;

    internal static fousyr1O5TImehMQsy T5PVTmZDZs4kbda7JWoN() => fousyr1O5TImehMQsy.VhS1xYZDvQgHLPlDKKjk;

    internal static void NVnOtoZDilkdREZZSnSU() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Type mhv8bdZDRZgcgavAkTnr([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object XM6ATDZDqg4yHPRKeeeK([In] object obj0) => (object) ((Assembly) obj0).ManifestModule;

    internal delegate void SFU4mbT3GMret7THonf(object o);
  }
}
