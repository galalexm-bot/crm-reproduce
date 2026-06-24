// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.DbLock
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Entities
{
  /// <summary>
  /// Служебный класс, предназначенный для работы с блокировками через <see cref="!:DbLockService" />
  /// </summary>
  [ShowInDesigner(false)]
  [ShowInTypeTree(false)]
  [Entity("DbLock")]
  [ClassMap(typeof (DbLockMap))]
  [MetadataType(typeof (EntityMetadata))]
  [Uid("{8FCAA656-9215-401B-BDDD-BABE43A73D17}")]
  [IdType("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
  [NonUnique]
  public class DbLock : Entity<string>
  {
    internal static DbLock KtxKNYhZtg8ZfoYHiMt8;

    /// <summary>Имя машины, захватившей блокировку</summary>
    [Uid("{4EC047C9-3A2A-4ED1-B760-4619DECCF1A4}")]
    [Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
    [EntityProperty]
    [StringSettings(FieldName = "MachineName")]
    public string MachineName
    {
      get => this.\u003CMachineName\u003Ek__BackingField;
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
              this.\u003CMachineName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
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

    /// <summary>Дата создания блокировки в UTC</summary>
    [CanBeNull]
    [DateTimeSettings(SetCurrentDate = true, WithoutOffset = true, FieldName = "CreationDate")]
    [Uid("{F1222FE7-B4A3-446A-B91E-DAFC230B55C0}")]
    [EntityProperty]
    public DateTime? CreationDate { get; set; }

    /// <summary>Дата истечения действия блокировки в UTC</summary>
    [CanBeNull]
    [EntityProperty]
    [Uid("{1268080F-A967-4CDE-A561-25B7F8C33A95}")]
    [DateTimeSettings(SetCurrentDate = true, WithoutOffset = true, FieldName = "ValidUntilDate")]
    public DateTime? ValidUntilDate { get; set; }

    /// <summary>Токен блокировки</summary>
    [Uid("{031BCCAE-2D41-49BD-9669-DF999AB3386F}")]
    [Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
    [EntityProperty]
    [GuidSettings(FieldName = "Value")]
    public Guid Value
    {
      get => this.\u003CValue\u003Ek__BackingField;
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
              this.\u003CValue\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
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

    public DbLock()
    {
      DbLock.obBGGlhZ64PSpbVv7RRG();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool ffplZPhZwRB9EvC2mUPZ() => DbLock.KtxKNYhZtg8ZfoYHiMt8 == null;

    internal static DbLock jSR5cShZ43QBRZ7sDuXH() => DbLock.KtxKNYhZtg8ZfoYHiMt8;

    internal static void obBGGlhZ64PSpbVv7RRG() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
