// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Modules.Impl.ModuleAssembly
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Modules.Impl
{
  internal class ModuleAssembly : ApplicationUnit, IModuleAssembly, IApplicationUnit
  {
    private Assembly assembly;
    private AssemblyInfoMetadata info;
    internal static ModuleAssembly jxuZdD32VAlcBiQPG3I;

    public ModuleAssembly(Assembly assembly)
    {
      ModuleAssembly.cRSKiL31kWeUsqAbZPm();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.info.LoadFromAssembly(assembly);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 1 : 4;
            continue;
          case 2:
            if (ModuleAssembly.Qv6hlA3NTZ9srFhoTyd((object) assembly, (object) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
              continue;
            }
            this.assembly = assembly;
            num = 3;
            continue;
          case 3:
            this.info = new AssemblyInfoMetadata();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 1 : 1;
            continue;
          case 4:
            goto label_2;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_7:
      throw new ArgumentNullException((string) ModuleAssembly.voJMYf33vy8TPmFO4uu(-1858887263 ^ -1858874161));
    }

    public override string Id => (string) ModuleAssembly.FW7rkX3pUD5nAx9hmOp((object) this.info);

    public override Guid Uid => this.info.Uid;

    public override string Title => (string) ModuleAssembly.mYs9aU3aVacy6ocfqb8((object) this.info);

    public override string Description => (string) ModuleAssembly.l0l38Z3DTpM971tb0Vg((object) this.info);

    public Assembly Assembly => this.assembly;

    public Guid ModuleUid => ModuleAssembly.lNtpud3tN8MYcCYVquR((object) this.info);

    public override string Version => this.info.FileVersion;

    public override string Author => (string) ModuleAssembly.qBh2KN3wRWGyhCEGFt4((object) this.info);

    internal static void cRSKiL31kWeUsqAbZPm() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Qv6hlA3NTZ9srFhoTyd([In] object obj0, [In] object obj1) => (Assembly) obj0 == (Assembly) obj1;

    internal static object voJMYf33vy8TPmFO4uu(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool L9pdgw3euvldpBO80n1() => ModuleAssembly.jxuZdD32VAlcBiQPG3I == null;

    internal static ModuleAssembly Pcv85V3PuxJxxhPsa93() => ModuleAssembly.jxuZdD32VAlcBiQPG3I;

    internal static object FW7rkX3pUD5nAx9hmOp([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object mYs9aU3aVacy6ocfqb8([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static object l0l38Z3DTpM971tb0Vg([In] object obj0) => (object) ((NamedMetadata) obj0).Description;

    internal static Guid lNtpud3tN8MYcCYVquR([In] object obj0) => ((AbstractMetadata) obj0).ModuleUid;

    internal static object qBh2KN3wRWGyhCEGFt4([In] object obj0) => (object) ((AssemblyInfoMetadata) obj0).Company;
  }
}
