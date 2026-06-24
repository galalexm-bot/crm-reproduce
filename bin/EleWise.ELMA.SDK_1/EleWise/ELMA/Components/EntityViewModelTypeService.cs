// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Components.EntityViewModelTypeService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Components
{
  /// <summary>
  /// Компонент для получения типа модели представления для сущностей
  /// </summary>
  internal sealed class EntityViewModelTypeService : ViewModelTypeService
  {
    /// <summary>Код метаданных сущностей</summary>
    public const string MetadataTypeCode = "Entity";
    private static EntityViewModelTypeService hPYVQJfhHBPo0QZoHDgS;

    /// <inheritdoc />
    public override bool Check(string metadataTypeCode) => EntityViewModelTypeService.PoDwyZfhxB3mKRP0ovFE((object) metadataTypeCode, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751419412));

    public EntityViewModelTypeService()
    {
      EntityViewModelTypeService.UpqHbMfh0mBrfw7L89FM();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool PoDwyZfhxB3mKRP0ovFE([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static bool i6110tfhACG36jxLvVFC() => EntityViewModelTypeService.hPYVQJfhHBPo0QZoHDgS == null;

    internal static EntityViewModelTypeService RLyiJffh7cfEc18OM8Y7() => EntityViewModelTypeService.hPYVQJfhHBPo0QZoHDgS;

    internal static void UpqHbMfh0mBrfw7L89FM() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
