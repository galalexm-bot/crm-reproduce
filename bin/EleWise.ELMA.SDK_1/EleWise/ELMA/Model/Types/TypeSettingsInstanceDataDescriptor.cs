// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.TypeSettingsInstanceDataDescriptor
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
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>
  /// Описанаие типа "Данные хранилища настроек свойств для экземпляров объектов"
  /// </summary>
  public class TypeSettingsInstanceDataDescriptor : 
    CLRTypeDescriptor<TypeSettingsInstanceData, TypeSettingsInstanceDataSettings>
  {
    /// <summary>Uid типа</summary>
    public const string UID_S = "{C0E3456C-53BA-4815-9D0A-262420F061A3}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    internal static TypeSettingsInstanceDataDescriptor yj28bWoyH0IGhv6uLyK3;

    /// <summary>Uid типа</summary>
    public override Guid Uid => TypeSettingsInstanceDataDescriptor.UID;

    /// <summary>Uid родительской группы типов данных</summary>
    public override Guid ParentUid => SystemTypesDescriptor.UID;

    /// <summary>
    /// Имя "Данные хранилища настроек свойств для экземпляров объектов"
    /// </summary>
    public override string Name => (string) TypeSettingsInstanceDataDescriptor.SeyRR4oy0SxhD0gVjDlH(TypeSettingsInstanceDataDescriptor.v1xWy9oyxS1dx1JjPCuB(-1217523399 ^ -1217624621));

    /// <inheritdoc />
    public override bool Visible
    {
      get
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (MetadataAccessInfo.EnvironmentType != MetadataEnvironmentType.VisualStudio)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            case 2:
              if (base.Visible)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 1;
                continue;
              }
              goto label_6;
            default:
              goto label_4;
          }
        }
label_4:
        return MetadataAccessInfo.EnvironmentType == MetadataEnvironmentType.DevServer;
label_5:
        return true;
label_6:
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

    public TypeSettingsInstanceDataDescriptor()
    {
      TypeSettingsInstanceDataDescriptor.mJhnuMoymKDHcC3ycnI7();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static TypeSettingsInstanceDataDescriptor()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TypeSettingsInstanceDataDescriptor.mJhnuMoymKDHcC3ycnI7();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            TypeSettingsInstanceDataDescriptor.UID = new Guid((string) TypeSettingsInstanceDataDescriptor.v1xWy9oyxS1dx1JjPCuB(-345420348 ^ -345253722));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static object v1xWy9oyxS1dx1JjPCuB(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object SeyRR4oy0SxhD0gVjDlH([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool rdeTtGoyArLCIsXpcj3P() => TypeSettingsInstanceDataDescriptor.yj28bWoyH0IGhv6uLyK3 == null;

    internal static TypeSettingsInstanceDataDescriptor TRRycZoy7enSkugAcJXR() => TypeSettingsInstanceDataDescriptor.yj28bWoyH0IGhv6uLyK3;

    internal static void mJhnuMoymKDHcC3ycnI7() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
