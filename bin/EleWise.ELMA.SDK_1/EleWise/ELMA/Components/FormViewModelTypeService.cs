// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Components.FormViewModelTypeService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Components
{
  /// <summary>
  /// Компонент для получения типа модели представления для форм
  /// </summary>
  internal sealed class FormViewModelTypeService : ViewModelTypeService
  {
    /// <summary>Код метаданных форм</summary>
    public const string MetadataTypeCode = "Form";
    internal static FormViewModelTypeService QGNM3Dfhmf0fPau540BZ;

    /// <inheritdoc />
    public override bool Check(string metadataTypeCode) => FormViewModelTypeService.TEFZ5afh9TZemsnaDjrL((object) metadataTypeCode, FormViewModelTypeService.zCYutnfhJNa2H8n5eQMA(~-397266137 ^ 397243196));

    /// <inheritdoc />
    public override ViewModelTypeName GetViewPropertyModelType(
      IPropertyMetadata property,
      string metadataNamespace)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (property is ITablePartMetadata)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return (ViewModelTypeName) null;
label_3:
      return base.GetViewPropertyModelType(property, metadataNamespace);
    }

    /// <inheritdoc />
    public override ViewModelTypeName GetViewModelType(
      string metadataName,
      string metadataNamespace,
      bool useOriginalModel)
    {
      return (ViewModelTypeName) null;
    }

    public FormViewModelTypeService()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object zCYutnfhJNa2H8n5eQMA(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool TEFZ5afh9TZemsnaDjrL([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static bool vrc4x6fhywFQMaG6E3sC() => FormViewModelTypeService.QGNM3Dfhmf0fPau540BZ == null;

    internal static FormViewModelTypeService tKE2bqfhMbdRpbr27X1J() => FormViewModelTypeService.QGNM3Dfhmf0fPau540BZ;
  }
}
