// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.MetadataItemUidAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Атрибут, отмечающий сборку, принадлежащую определенному item в БД
  /// </summary>
  [AttributeUsage(AttributeTargets.Assembly)]
  public class MetadataItemUidAttribute : Attribute
  {
    private static MetadataItemUidAttribute bu6aNoofTwBtMn95UAw4;

    /// <summary>
    /// Новый атрибут, содержащий уникальный идентификатор элемента
    /// </summary>
    /// <param name="itemUid">Уникальный идентификатор элемента</param>
    public MetadataItemUidAttribute(string itemUid)
    {
      MetadataItemUidAttribute.oTl2eVofOanHaNPkEvcw();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            Contract.NotNullOrEmpty(itemUid, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1872275253 >> 6 ^ -29112895));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 2 : 1;
            continue;
          case 2:
            this.ItemUid = new Guid(itemUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    /// <summary>
    /// Новый атрибут, содержащий уникальный идентификатор элемента
    /// </summary>
    /// <param name="itemUid">Уникальный идентификатор элемента</param>
    public MetadataItemUidAttribute(Guid itemUid)
    {
      MetadataItemUidAttribute.oTl2eVofOanHaNPkEvcw();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.ItemUid = itemUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Уникальный идентификатор Item в БД</summary>
    public Guid ItemUid { get; }

    internal static void oTl2eVofOanHaNPkEvcw() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool El9k2rofk5BeKqvQIjVS() => MetadataItemUidAttribute.bu6aNoofTwBtMn95UAw4 == null;

    internal static MetadataItemUidAttribute r70xRIofnFC974vDmoA0() => MetadataItemUidAttribute.bu6aNoofTwBtMn95UAw4;
  }
}
