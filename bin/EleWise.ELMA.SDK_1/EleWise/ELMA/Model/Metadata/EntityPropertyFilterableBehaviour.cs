// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.EntityPropertyFilterableBehaviour
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Enums;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>
  /// Расширитель поведения публикации, требущий перезапуска при отключении "Использовать ли в фильтре" у свойства метаданных сущности
  /// </summary>
  internal sealed class EntityPropertyFilterableBehaviour : IPublicationBehaviourChecker
  {
    private static EntityPropertyFilterableBehaviour Vderedb1qZY9l5ImcyyW;

    /// <inheritdoc />
    public PublicationType Check(CheckType action, object oldValue, object newValue)
    {
      int num = 6;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            goto label_14;
          case 3:
            goto label_2;
          case 4:
            if (newValue.Equals((object) false))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
              continue;
            }
            goto label_12;
          case 5:
            if (action == CheckType.Change)
            {
              if (!oldValue.Equals(newValue))
              {
                num = 7;
                continue;
              }
              goto label_2;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 2 : 1;
              continue;
            }
          case 6:
            if (action != CheckType.Create)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 5 : 2;
              continue;
            }
            goto label_5;
          case 7:
            if (oldValue.Equals((object) true))
            {
              num = 4;
              continue;
            }
            goto label_12;
          case 8:
            goto label_12;
          default:
            goto label_13;
        }
      }
label_2:
      return PublicationType.Soft;
label_5:
      return PublicationType.Delta;
label_12:
      return PublicationType.Delta;
label_13:
      return PublicationType.Restart;
label_14:
      throw new ArgumentOutOfRangeException((string) EntityPropertyFilterableBehaviour.e61MxRb1TeiqclNgBexF(323422137 << 2 ^ 1293747984), (object) action, EleWise.ELMA.SR.T((string) EntityPropertyFilterableBehaviour.e61MxRb1TeiqclNgBexF(964881585 - -1459193222 ^ -1870751927)));
    }

    public EntityPropertyFilterableBehaviour()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object e61MxRb1TeiqclNgBexF(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool CUi2l6b1KVhnPbjAa8Zk() => EntityPropertyFilterableBehaviour.Vderedb1qZY9l5ImcyyW == null;

    internal static EntityPropertyFilterableBehaviour InvVTgb1X0r2Ou0BpcEM() => EntityPropertyFilterableBehaviour.Vderedb1qZY9l5ImcyyW;
  }
}
