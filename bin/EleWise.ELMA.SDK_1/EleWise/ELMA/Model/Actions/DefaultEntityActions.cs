// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Actions.DefaultEntityActions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Model.Actions
{
  /// <summary>Стандартные действия с сущностью</summary>
  [DisplayName(typeof (__Resources_DefaultEntityActions), "DisplayName")]
  public class DefaultEntityActions
  {
    /// <summary>Создание</summary>
    [Image(typeof (DefaultEntityActions), "add_outline", 16, ImageFormatType.IconPack, false)]
    [DisplayName(typeof (__Resources_DefaultEntityActions), "P_Create_DisplayName")]
    [Uid("70c5300a-fafb-495c-bda9-4c5dc12cc8bd")]
    public const string Create = "70c5300a-fafb-495c-bda9-4c5dc12cc8bd";
    /// <summary>Создание</summary>
    public static readonly Guid CreateGuid;
    /// <summary>Просмотр</summary>
    [Uid("c573451f-5c32-469a-8e0b-a35ee73d80e0")]
    [DisplayName(typeof (__Resources_DefaultEntityActions), "P_View_DisplayName")]
    [Image(typeof (DefaultEntityActions), "visualibility", 16, ImageFormatType.IconPack, false)]
    public const string View = "c573451f-5c32-469a-8e0b-a35ee73d80e0";
    /// <summary>Просмотр</summary>
    public static readonly Guid ViewGuid;
    /// <summary>Обновление</summary>
    [Image(typeof (DefaultEntityActions), "edit", 16, ImageFormatType.IconPack, false)]
    [Uid("42986da3-d210-414d-9225-f3cde17c18c9")]
    [DisplayName(typeof (__Resources_DefaultEntityActions), "P_Update_DisplayName")]
    public const string Update = "42986da3-d210-414d-9225-f3cde17c18c9";
    /// <summary>Обновление</summary>
    public static readonly Guid UpdateGuid;
    /// <summary>Удаление</summary>
    [Image(typeof (DefaultEntityActions), "basket", 16, ImageFormatType.IconPack, false)]
    [DisplayName(typeof (__Resources_DefaultEntityActions), "P_Delete_DisplayName")]
    [Uid("f5d56c0f-95af-48d5-89a0-ea4e9a336429")]
    public const string Delete = "f5d56c0f-95af-48d5-89a0-ea4e9a336429";
    /// <summary>Изменение свойства коллекции</summary>
    public static readonly Guid EditCollectionGuid;
    /// <summary>Изменение свойства коллекции</summary>
    [DisplayName("SR.M('Изменение свойства коллекции')")]
    [Uid("f5d56c0f-95af-48d5-89a0-ea4e9a336429")]
    [Image(typeof (DefaultEntityActions), "edit", 16, ImageFormatType.IconPack, false)]
    public const string EditCollection = "f5d56c0f-95af-48d5-89a0-ea4e9a336429";
    /// <summary>Удаление</summary>
    public static readonly Guid DeleteGuid;
    internal static DefaultEntityActions hpgCXYWY2FOYa3mBtJem;

    /// <summary>Ctor</summary>
    protected DefaultEntityActions()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static DefaultEntityActions()
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            DefaultEntityActions.DeleteGuid = new Guid((string) DefaultEntityActions.jqBbVkWYNgGRqyKOepHG(-1317790512 ^ -1317642646));
            num = 5;
            continue;
          case 2:
            DefaultEntityActions.UpdateGuid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108800930));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 6 : 5;
            continue;
          case 3:
            DefaultEntityActions.CreateGuid = new Guid((string) DefaultEntityActions.jqBbVkWYNgGRqyKOepHG(~-306453669 ^ 306601330));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
            continue;
          case 4:
            DefaultEntityActions.jKmwQGWY1kMY5hY9duLa();
            num = 3;
            continue;
          case 5:
            goto label_2;
          case 6:
            DefaultEntityActions.EditCollectionGuid = new Guid((string) DefaultEntityActions.jqBbVkWYNgGRqyKOepHG(1319452732 ^ 1319568006));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 1;
            continue;
          default:
            DefaultEntityActions.ViewGuid = new Guid((string) DefaultEntityActions.jqBbVkWYNgGRqyKOepHG(1253244298 - 1829393894 ^ -576002682));
            num = 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool YIklNFWYeB6Uy6ewxswB() => DefaultEntityActions.hpgCXYWY2FOYa3mBtJem == null;

    internal static DefaultEntityActions jSrsnmWYPKtTUBtJkedo() => DefaultEntityActions.hpgCXYWY2FOYa3mBtJem;

    internal static void jKmwQGWY1kMY5hY9duLa() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object jqBbVkWYNgGRqyKOepHG(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
