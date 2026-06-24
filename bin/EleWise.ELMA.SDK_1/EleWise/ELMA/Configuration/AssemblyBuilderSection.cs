// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Configuration.AssemblyBuilderSection
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Web.Configuration;

namespace EleWise.ELMA.Configuration
{
  /// <summary>Секция для настроек построителя сборок</summary>
  public class AssemblyBuilderSection : ConfigurationSection
  {
    private static ConfigurationPropertyCollection _properties;
    private static readonly ConfigurationProperty _propAssemblies;
    private static readonly ConfigurationProperty _propModelAssemblies;
    internal static AssemblyBuilderSection PK3MJqfBxvYdM9PKVy8p;

    static AssemblyBuilderSection()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            AssemblyBuilderSection.mq3dS1fBy5Nwu3ChxJAD();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: type reference
            AssemblyBuilderSection._propModelAssemblies = new ConfigurationProperty((string) AssemblyBuilderSection.OhSLmjfBMRWmrafJAg8d(1051276242 - 990076387 ^ 60867939), AssemblyBuilderSection.wRNOtefBJIlUIRQUOl9t(__typeref (AssemblyCollection)), (object) null, ConfigurationPropertyOptions.IsDefaultCollection);
            num = 3;
            continue;
          case 3:
            AssemblyBuilderSection._properties.Add(AssemblyBuilderSection._propAssemblies);
            num = 4;
            continue;
          case 4:
            goto label_2;
          case 5:
            // ISSUE: type reference
            AssemblyBuilderSection._propAssemblies = new ConfigurationProperty((string) AssemblyBuilderSection.OhSLmjfBMRWmrafJAg8d(87862435 ^ 87873825), AssemblyBuilderSection.wRNOtefBJIlUIRQUOl9t(__typeref (AssemblyCollection)), (object) null, ConfigurationPropertyOptions.IsDefaultCollection);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 2 : 2;
            continue;
          default:
            AssemblyBuilderSection._properties = new ConfigurationPropertyCollection();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 5 : 1;
            continue;
        }
      }
label_2:;
    }

    [ConfigurationProperty("assemblies")]
    public AssemblyCollection Assemblies => (AssemblyCollection) this[AssemblyBuilderSection._propAssemblies];

    [ConfigurationProperty("modelAssemblies")]
    public AssemblyCollection ModelAssemblies => (AssemblyCollection) AssemblyBuilderSection.CoAS7mfB9BNFBUap2ijf((object) this, (object) AssemblyBuilderSection._propModelAssemblies);

    protected override ConfigurationPropertyCollection Properties => AssemblyBuilderSection._properties;

    public AssemblyBuilderSection()
    {
      AssemblyBuilderSection.mq3dS1fBy5Nwu3ChxJAD();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void mq3dS1fBy5Nwu3ChxJAD() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object OhSLmjfBMRWmrafJAg8d(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Type wRNOtefBJIlUIRQUOl9t([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool L9RHCifB0Iy6UOASWWHn() => AssemblyBuilderSection.PK3MJqfBxvYdM9PKVy8p == null;

    internal static AssemblyBuilderSection JB5mk3fBmG4FPVmLshpO() => AssemblyBuilderSection.PK3MJqfBxvYdM9PKVy8p;

    internal static object CoAS7mfB9BNFBUap2ijf([In] object obj0, [In] object obj1) => ((ConfigurationElement) obj0)[(ConfigurationProperty) obj1];
  }
}
