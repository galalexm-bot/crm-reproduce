// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.TypeSettingsDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Data;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Описанаие типа "Настройки типа данных"</summary>
  public class TypeSettingsDescriptor : CLRTypeDescriptor<TypeSettings, TypeSettingsSettings>
  {
    /// <summary>Uid типа</summary>
    public const string UID_S = "{6B39BAB6-1274-477B-A4E1-4C699EAB4C75}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    internal static TypeSettingsDescriptor g1oKuuo9Syd7CHHvn9yp;

    /// <summary>Uid типа</summary>
    public override Guid Uid => TypeSettingsDescriptor.UID;

    /// <summary>Uid родительской группы типов данных</summary>
    public override Guid ParentUid => SystemTypesDescriptor.UID;

    /// <summary>Имя "Настройки типа данных"</summary>
    public override string Name => EleWise.ELMA.SR.T((string) TypeSettingsDescriptor.diM5iZo9qmUV8DFwkcId(1232639661 >> 3 ^ 153979363));

    /// <inheritdoc />
    public override bool Visible
    {
      get
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_6;
            case 2:
              goto label_8;
            case 3:
              if (!base.Visible)
              {
                num = 2;
                continue;
              }
              break;
          }
          if (MetadataAccessInfo.EnvironmentType != MetadataEnvironmentType.VisualStudio)
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 1;
          else
            goto label_7;
        }
label_6:
        return MetadataAccessInfo.EnvironmentType == MetadataEnvironmentType.DevServer;
label_7:
        return true;
label_8:
        return false;
      }
    }

    /// <summary>Получить тип колонки в БД</summary>
    /// <param name="propertyMetadata">Метаданные свойства (не может быть NULL)</param>
    /// <returns>Тип колонки БД</returns>
    protected override ColumnType GetDbColumnType(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      return new ColumnType(DbType.Binary);
    }

    public TypeSettingsDescriptor()
    {
      TypeSettingsDescriptor.xVEg9Qo9KR8CNnxXX9rg();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static TypeSettingsDescriptor()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            TypeSettingsDescriptor.UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886480661));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object diM5iZo9qmUV8DFwkcId(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool yGQ4hSo9i3UE0007CVwo() => TypeSettingsDescriptor.g1oKuuo9Syd7CHHvn9yp == null;

    internal static TypeSettingsDescriptor X3efllo9RAxL2OfuiN3T() => TypeSettingsDescriptor.g1oKuuo9Syd7CHHvn9yp;

    internal static void xVEg9Qo9KR8CNnxXX9rg() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
