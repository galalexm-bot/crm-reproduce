// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Db.Actions.ModelAction
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Actions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Db.Actions
{
  /// <summary>
  /// Абстрактное действие по преобразованию структур БД для хранения моделей
  /// </summary>
  public abstract class ModelAction : DbAction
  {
    private IDbModelUpdater updater;
    private IMetadataRuntimeService metadataService;
    private static ModelAction mxxOdloEvFJ1bIVL8bm2;

    /// <summary>Создать действие</summary>
    /// <param name="updater">Обработчик изменения структуры БД моделей</param>
    public ModelAction(IDbModelUpdater updater)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector((ITransformationProvider) ModelAction.vrtVSpoEuSbtifg3SrXS((object) updater));
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            ModelAction.JxF02ooEVktAnaHSTRLI(ModelAction.vrtVSpoEuSbtifg3SrXS((object) updater), ModelAction.Ej3ix0oEIjNXGZl00xkY(1917998801 >> 2 ^ 479642214));
            num = 2;
            continue;
          case 2:
            this.updater = updater;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
            continue;
          case 3:
            ModelAction.JxF02ooEVktAnaHSTRLI((object) updater, ModelAction.Ej3ix0oEIjNXGZl00xkY(1917256330 ^ 1917146442));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 1 : 1;
            continue;
          case 4:
            goto label_2;
          default:
            this.metadataService = Locator.GetServiceNotNull<IMetadataRuntimeService>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 1 : 4;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Обработчик изменения структуры БД моделей</summary>
    protected IDbModelUpdater Updater => this.updater;

    /// <summary>Служба работы с метаданными</summary>
    protected IMetadataRuntimeService MetadataService => this.metadataService;

    internal static object vrtVSpoEuSbtifg3SrXS([In] object obj0) => (object) ((IDbModelUpdater) obj0).Transform;

    internal static object Ej3ix0oEIjNXGZl00xkY(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void JxF02ooEVktAnaHSTRLI([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static bool z8M9kxoE8Xt8AEAvP5bZ() => ModelAction.mxxOdloEvFJ1bIVL8bm2 == null;

    internal static ModelAction z9uKpHoEZdRTXwwwHy4B() => ModelAction.mxxOdloEvFJ1bIVL8bm2;
  }
}
