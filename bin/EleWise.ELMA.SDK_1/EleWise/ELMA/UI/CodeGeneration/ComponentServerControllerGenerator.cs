// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.CodeGeneration.ComponentServerControllerGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.CodeGeneration
{
  /// <summary>
  /// Генератор невидимой части серверного контроллера компонента
  /// </summary>
  internal sealed class ComponentServerControllerGenerator : ClassGenerator
  {
    private ComponentMetadata componentMetadata;
    private static ComponentServerControllerGenerator hPSncTBIv6ZBYdT76Mcu;

    /// <summary>Сгенерировать класс ViewModel</summary>
    /// <returns>Класс ViewModel</returns>
    internal ISyntaxNode Generate() => ((string) ComponentServerControllerGenerator.cnmvE4BIuGX88jSS6r22((object) this.componentMetadata)).NamespaceDeclaration(((string) ComponentServerControllerGenerator.qcBg6jBIIu616YuqiJns((object) this.componentMetadata)).ClassDeclaration(modifiers: DeclarationModifiers.Partial, members: (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
    {
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(1199946765 ^ 1199877615).ClassDeclaration(Accessibility.Private, DeclarationModifiers.Partial)
    }));

    /// <inheritdoc />
    protected override void InitInternal(IMetadata metadata)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            Contract.CheckArgument(metadata is ComponentMetadata, (string) ComponentServerControllerGenerator.jvieGMBIVn48xBF2Ny8V(1505778440 - 1981636111 ^ -475794727));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 3 : 2;
            continue;
          case 2:
            ComponentServerControllerGenerator.T0tgdiBISkgxta9CU6fL((object) metadata, ComponentServerControllerGenerator.jvieGMBIVn48xBF2Ny8V(1304605005 ^ 1304623219));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 1 : 1;
            continue;
          case 3:
            this.componentMetadata = (ComponentMetadata) metadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    public ComponentServerControllerGenerator()
    {
      ComponentServerControllerGenerator.qxH6sKBIibN9oPGFVZIk();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object cnmvE4BIuGX88jSS6r22([In] object obj0) => (object) ((ComponentMetadata) obj0).Namespace;

    internal static object qcBg6jBIIu616YuqiJns([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static bool jiTpPxBI8DNDuZpuicZ4() => ComponentServerControllerGenerator.hPSncTBIv6ZBYdT76Mcu == null;

    internal static ComponentServerControllerGenerator qVbRadBIZUkYns2BMnGi() => ComponentServerControllerGenerator.hPSncTBIv6ZBYdT76Mcu;

    internal static object jvieGMBIVn48xBF2Ny8V(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void T0tgdiBISkgxta9CU6fL([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void qxH6sKBIibN9oPGFVZIk() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
