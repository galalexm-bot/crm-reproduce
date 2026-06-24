// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.CodeGeneration.PortletPersonalizationGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.CodeGeneration
{
  public class PortletPersonalizationGenerator : EntityGenerator
  {
    private static PortletPersonalizationGenerator zCx7ZDBVZsqJZvJsAE55;

    protected override ISyntaxNode GetBaseClass() => ((string) PortletPersonalizationGenerator.l1LahIBVVcAY7ec5VXkA(-97972138 ^ -98039920)).CreateTypeSyntax();

    public IEnumerable<ISyntaxNode> Generate() => this.GenerateMainFile();

    protected override IEnumerable<ISyntaxNode> GetBaseInterfaces() => (IEnumerable<ISyntaxNode>) new PortletPersonalizationGenerator.\u003CGetBaseInterfaces\u003Ed__2(-2);

    protected override void WriteTypeAttributes(ISyntaxNode type)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            type.AddAttributes(typeof (SerializableAttribute).CreateAttribute());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    protected override void WritePropertyAttributes(
      ISyntaxNode property,
      PropertyMetadata propertyMetadata,
      string resourcePrefix = null)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            base.WritePropertyAttributes(property, propertyMetadata, resourcePrefix);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            property.AddAttributes(((string) PortletPersonalizationGenerator.l1LahIBVVcAY7ec5VXkA(-812025778 ^ -812097416)).CreateAttribute(PortletPersonalizationGenerator.RHXSLYBVS2n0F46aJR73(PortletPersonalizationGenerator.l1LahIBVVcAY7ec5VXkA(1021410165 ^ 1021338593))));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    protected override EntityGenerator CreateTablePartGenerator() => throw new NotImplementedException();

    public PortletPersonalizationGenerator()
    {
      PortletPersonalizationGenerator.iYeF4GBVih6tISTkVBc3();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object l1LahIBVVcAY7ec5VXkA(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool ReTlCxBVuhlB946FrWHV() => PortletPersonalizationGenerator.zCx7ZDBVZsqJZvJsAE55 == null;

    internal static PortletPersonalizationGenerator mLgww9BVIxWhM2vSUKik() => PortletPersonalizationGenerator.zCx7ZDBVZsqJZvJsAE55;

    internal static object RHXSLYBVS2n0F46aJR73([In] object obj0) => (object) ((string) obj0).ParseExpression();

    internal static void iYeF4GBVih6tISTkVBc3() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
