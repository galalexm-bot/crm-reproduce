// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Modules.Impl.ModuleBase
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Modules.Impl
{
  internal abstract class ModuleBase : 
    CompositeApplicationUnit,
    IModule,
    ICompositeApplicationUnit,
    IApplicationUnit
  {
    private List<IModuleAssembly> assemblies;
    private List<IModule> extensionModules;
    private static ModuleBase fGFFJn3TN5UrElGA4R0;

    public ModuleType ModuleType
    {
      get => this.\u003CModuleType\u003Ek__BackingField;
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
              this.\u003CModuleType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
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

    public abstract string WebSite { get; }

    public abstract string HtmlDescription { get; }

    public ModuleStatus Status
    {
      get => this.\u003CStatus\u003Ek__BackingField;
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
              this.\u003CStatus\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
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

    public ModuleDisabledReason DisabledReason
    {
      get => this.\u003CDisabledReason\u003Ek__BackingField;
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
              this.\u003CDisabledReason\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
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

    public abstract bool ServerModuleRequired { get; }

    public override IEnumerable<IApplicationUnit> Units => this.ExtensionModules.Cast<IApplicationUnit>().Union<IApplicationUnit>((IEnumerable<IApplicationUnit>) this.Assemblies);

    public IEnumerable<IModuleAssembly> Assemblies => (IEnumerable<IModuleAssembly>) this.assemblies;

    public IEnumerable<IModule> ExtensionModules => (IEnumerable<IModule>) this.extensionModules;

    public void AddAssembly(IModuleAssembly asm)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            goto label_2;
          case 3:
            if (this.assemblies.Contains(asm))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 2 : 2;
              continue;
            }
            break;
        }
        this.assemblies.Add(asm);
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 1 : 0;
      }
label_3:
      return;
label_2:;
    }

    public void AddExtensionModule(IModule module)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_5;
            case 1:
              this.extensionModules.Add(module);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_3;
            case 3:
              if (!this.extensionModules.Contains(module))
                goto case 1;
              else
                goto label_7;
            default:
              goto label_8;
          }
        }
label_7:
        num1 = 2;
      }
label_5:
      return;
label_3:
      return;
label_8:;
    }

    protected ModuleBase()
    {
      ModuleBase.i74EJv3ONjWaSJvGa4l();
      this.assemblies = new List<IModuleAssembly>();
      this.extensionModules = new List<IModule>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool urawT13kL3V1xtqZFhd() => ModuleBase.fGFFJn3TN5UrElGA4R0 == null;

    internal static ModuleBase CyIk8Y3nhHBahMiNGlK() => ModuleBase.fGFFJn3TN5UrElGA4R0;

    internal static void i74EJv3ONjWaSJvGa4l() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
