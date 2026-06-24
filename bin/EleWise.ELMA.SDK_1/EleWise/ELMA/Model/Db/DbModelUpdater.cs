// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Db.DbModelUpdater
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Db.Actions;
using EleWise.ELMA.Model.Db.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Actions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using Microsoft.Win32;
using NHibernate;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;

namespace EleWise.ELMA.Model.Db
{
  /// <summary>
  /// Обработчик изменения структуры БД, преобразующий структуры для хранения моделей
  /// </summary>
  [Component(Order = -1)]
  public class DbModelUpdater : DbUpdateHandler, IDbModelUpdater, IActionsHolder
  {
    private RegistryKey _processEntityPropertyMetadataChangesHackWriteKey;
    private IList<string> processEntityPropertyMetadataChangesHack;
    private bool hasChanges;
    private IEnumerable<string> deactivatingModules;
    private readonly Dictionary<Guid, EleWise.ELMA.Model.Metadata.AbstractMetadata> currMetadata;
    private readonly Dictionary<Guid, EleWise.ELMA.Model.Metadata.AbstractMetadata> prevMetadata;
    private readonly Dictionary<EleWise.ELMA.Model.Metadata.AbstractMetadata, DbModelUpdater.ModuleRef> currMetadataModules;
    private readonly Dictionary<EleWise.ELMA.Model.Metadata.AbstractMetadata, DbModelUpdater.ModuleRef> prevMetadataModules;
    private readonly Dictionary<string, DbModelUpdater.ModuleRef> moduleRefs;
    private bool recreateConstraints;
    private bool needRecreateConstraints;
    private static readonly ILogger DbUpdateLog;
    internal static DbModelUpdater O5qXfSoorDF2hrPyRPyX;

    /// <summary>Для всех провайдеров</summary>
    public override Guid ProviderUid => Guid.Empty;

    /// <summary>Если есть изменение в моделях, возвращает True</summary>
    public override bool HasChanges => this.hasChanges;

    /// <summary>
    /// Нужно ли пересоздавать все ограничения, индексы и внешние ключи
    /// </summary>
    public override bool NeedRecreateConstraints => this.needRecreateConstraints;

    /// <summary>
    /// Пересоздаются ли ограничения (внешние ключи, индексы, триггеры и т.д.) полностью
    /// </summary>
    public bool RecreateConstraints => this.recreateConstraints;

    /// <summary>Инициализация</summary>
    public override void Init()
    {
      int num = 5;
      IRuntimeApplication serviceNotNull;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            this.deactivatingModules = ((DbPreUpdater) DbModelUpdater.QkXxEfoojJa6FFLIIxGn((object) serviceNotNull)).GetDeactivatingModules();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 3 : 7;
            continue;
          case 3:
            this.RemoveProcessEntityPropertyMetadataChangesHack();
            num = 6;
            continue;
          case 4:
            serviceNotNull = Locator.GetServiceNotNull<IRuntimeApplication>();
            num = 2;
            continue;
          case 5:
            base.Init();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 4 : 4;
            continue;
          case 6:
            this.CheckAllActions();
            num = 9;
            continue;
          case 7:
            this.LoadCurrentMetadata();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 10 : 10;
            continue;
          case 8:
            goto label_2;
          case 9:
            this.hasChanges = this.HasActions;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
            continue;
          case 10:
            this.LoadPreviousMetadata();
            num = 11;
            continue;
          case 11:
            this.ProcessMetadataChanges();
            num = 3;
            continue;
          case 12:
            this.SaveMetadata();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 1 : 0;
            continue;
          default:
            if (this.hasChanges)
            {
              num = 8;
              continue;
            }
            goto case 12;
        }
      }
label_5:
      return;
label_2:;
    }

    /// <summary>Начало преобразования</summary>
    /// <param name="parameters">Параметры</param>
    public override void OnStart(DbUpdateParameters parameters)
    {
      int num1 = 6;
      IEnumerable<IEntityActionExtender> extensionPoints;
      IEnumerator<EntityMetadata> enumerator1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_37;
            case 2:
              goto label_38;
            case 3:
              goto label_32;
            case 4:
              goto label_7;
            case 5:
              this.recreateConstraints = parameters.RecreateConstraints;
              num2 = 7;
              continue;
            case 6:
              base.OnStart(parameters);
              num2 = 5;
              continue;
            case 7:
              if (!this.recreateConstraints)
              {
                num2 = 3;
                continue;
              }
              goto case 8;
            case 8:
              DbModelUpdater.apqCMZooYmYusrPGTi54((object) this.ForeignKeysCreatedActions);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
              continue;
            default:
              extensionPoints = ((ComponentManager) DbModelUpdater.axumBMooLlY7Mhn4KKDC()).GetExtensionPoints<IEntityActionExtender>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 1 : 0;
              continue;
          }
        }
label_37:
        IEnumerable<EntityMetadata> source = this.currMetadata.Values.OfType<EntityMetadata>();
        // ISSUE: reference to a compiler-generated field
        System.Func<EntityMetadata, bool> func = DbModelUpdater.\u003C\u003Ec.\u003C\u003E9__9_0;
        System.Func<EntityMetadata, bool> predicate;
        if (func == null)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          DbModelUpdater.\u003C\u003Ec.\u003C\u003E9__9_0 = predicate = (System.Func<EntityMetadata, bool>) (m => !DbModelUpdater.\u003C\u003Ec.rrMINtChjLS0hxxbkuhO((object) m));
        }
        else
          goto label_16;
label_40:
        enumerator1 = source.Where<EntityMetadata>(predicate).GetEnumerator();
        num1 = 4;
        continue;
label_16:
        predicate = func;
        goto label_40;
      }
label_38:
      return;
label_32:
      return;
label_7:
      try
      {
label_12:
        if (DbModelUpdater.a6Xjbsooc1RoelgwJJWa((object) enumerator1))
          goto label_9;
        else
          goto label_13;
label_8:
        EntityMetadata current;
        IEnumerator<IEntityActionExtender> enumerator2;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_27;
            case 2:
              enumerator2 = extensionPoints.GetEnumerator();
              num3 = 3;
              continue;
            case 3:
              goto label_14;
            case 4:
              goto label_9;
            case 5:
              this.ForeignKeysCreatedActions.Add((IDbAction) new EntityForeignKeysAction((IDbModelUpdater) this, current));
              num3 = 2;
              continue;
            default:
              goto label_12;
          }
        }
label_27:
        return;
label_14:
        try
        {
label_17:
          if (enumerator2.MoveNext())
            goto label_19;
          else
            goto label_18;
label_15:
          int num4;
          switch (num4)
          {
            case 1:
              goto label_17;
            case 2:
              goto label_12;
            default:
              goto label_19;
          }
label_18:
          num4 = 2;
          goto label_15;
label_19:
          DbModelUpdater.xUmpYIooUCTMsJGTfpw6((object) enumerator2.Current, (object) this, (object) current);
          num4 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
          {
            num4 = 1;
            goto label_15;
          }
          else
            goto label_15;
        }
        finally
        {
          if (enumerator2 != null)
          {
            int num5 = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
              num5 = 1;
            while (true)
            {
              switch (num5)
              {
                case 1:
                  DbModelUpdater.VJ6qT2oosW0aSBDWnQVE((object) enumerator2);
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_26;
              }
            }
          }
label_26:;
        }
label_9:
        current = enumerator1.Current;
        num3 = 5;
        goto label_8;
label_13:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 1 : 1;
        goto label_8;
      }
      finally
      {
        if (enumerator1 != null)
        {
          int num6 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
            num6 = 0;
          while (true)
          {
            switch (num6)
            {
              case 1:
                DbModelUpdater.VJ6qT2oosW0aSBDWnQVE((object) enumerator1);
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
                continue;
              default:
                goto label_34;
            }
          }
        }
label_34:;
      }
    }

    /// <summary>Сохранение информации о метаданных в БД</summary>
    public override void OnComplete()
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            DbModelUpdater.D9XgoIobBbfV8d0grcZV((object) this.prevMetadata);
            num = 5;
            continue;
          case 2:
            DbModelUpdater.gmxKaIobo0Q20fYMCIVo((object) this.moduleRefs);
            num = 7;
            continue;
          case 3:
            DbModelUpdater.O8pRgBobFuS1ZtsNc4iW(DbModelUpdater.S8PJ74oozuGqpBF5WjuB(), (object) (System.Action) (() => this.SaveMetadata()));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 1 : 1;
            continue;
          case 4:
            base.OnComplete();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 3 : 3;
            continue;
          case 5:
            this.prevMetadataModules.Clear();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 4 : 6;
            continue;
          case 6:
            DbModelUpdater.D9XgoIobBbfV8d0grcZV((object) this.currMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
            continue;
          case 7:
            goto label_2;
          default:
            DbModelUpdater.d1ATmaobWrN6aZpTfQR7((object) this.currMetadataModules);
            num = 2;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Сгенерировать временное имя для удаляемой колонки</summary>
    /// <param name="tableName">Имя таблицы</param>
    /// <param name="columnName">Оригинальное имя колонки</param>
    /// <returns>Имя временной колонки</returns>
    public virtual string GenerateDeletingColumnTemporaryName(string tableName, string columnName) => this.Transform.GenerateDeletingColumnTemporaryName(tableName, columnName);

    /// <summary>Получить временное имя удаляемой колонки</summary>
    /// <remarks>
    /// Перед удалением колонки она переименовывается, чтобы можно было перенести данные из старой колонки в новую.
    /// </remarks>
    /// <param name="tableName">Имя таблицы</param>
    /// <param name="columnName">Оригинальное имя колонки</param>
    /// <returns>Временное имя удаляемой колонки</returns>
    public virtual string GetDeletingColumnTemporaryName(string tableName, string columnName) => (string) DbModelUpdater.wPi26hobbLmeXJ3nvZgQ((object) this.Transform, (object) tableName, (object) columnName);

    public override void OnTablesCreated()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!this.RecreateConstraints)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          case 2:
            base.OnTablesCreated();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 1 : 0;
            continue;
          case 3:
            goto label_2;
          default:
            DbModelUpdater.YWXZxVobhoDJcXyjIbPJ((object) this);
            num = 3;
            continue;
        }
      }
label_2:
      return;
label_7:;
    }

    /// <summary>Получить имя БД по умолчанию</summary>
    /// <returns>Имя БД</returns>
    protected virtual string GetDbName() => string.Empty;

    /// <summary>
    /// Обработать изменения метаданных (создать действия по преобразованию БД)
    /// </summary>
    protected virtual void ProcessMetadataChanges()
    {
      int num1 = 2;
      Dictionary<Guid, EleWise.ELMA.Model.Metadata.AbstractMetadata>.ValueCollection.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            try
            {
label_33:
              if (enumerator.MoveNext())
                goto label_36;
              else
                goto label_34;
label_32:
              EleWise.ELMA.Model.Metadata.AbstractMetadata current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_33;
                  case 2:
                    goto label_29;
                  case 3:
                    DbModelUpdater.OKvq5FobGNk8egotQQvw((object) this, (object) current);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 1 : 0;
                    continue;
                  default:
                    goto label_36;
                }
              }
label_34:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 2 : 1;
              goto label_32;
label_36:
              current = enumerator.Current;
              num2 = 3;
              goto label_32;
            }
            finally
            {
              enumerator.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
          case 2:
            enumerator = this.currMetadata.Values.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_41;
          case 4:
label_29:
            enumerator = this.prevMetadata.Values.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_41:
      return;
label_2:
      try
      {
label_19:
        if (enumerator.MoveNext())
          goto label_5;
        else
          goto label_20;
label_4:
        EleWise.ELMA.Model.Metadata.AbstractMetadata current;
        DbModelUpdater.ModuleRef prevMetadataModule;
        EleWise.ELMA.Model.Metadata.AbstractMetadata key;
        EleWise.ELMA.Model.Metadata.AbstractMetadata abstractMetadata;
        EntityMetadata entityMetadata;
        int num4;
        while (true)
        {
          switch (num4)
          {
            case 1:
              if (entityMetadata.Type == EntityMetadataType.InterfaceImplementation)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 5 : 1;
                continue;
              }
              goto case 2;
            case 2:
            case 3:
            case 13:
              prevMetadataModule = this.prevMetadataModules[key];
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 12 : 12;
              continue;
            case 4:
              key = current;
              num4 = 6;
              continue;
            case 5:
              if (this.prevMetadata.TryGetValue(DbModelUpdater.gakq6OobfvJAprkvEFC2((object) entityMetadata), out key))
              {
                num4 = 13;
                continue;
              }
              goto case 14;
            case 6:
              if (entityMetadata == null)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 2 : 2;
                continue;
              }
              goto case 1;
            case 7:
              goto label_5;
            case 8:
              this.currMetadata.TryGetValue(DbModelUpdater.DmN37SobEks2fuJmC4C1((object) current), out abstractMetadata);
              num4 = 11;
              continue;
            case 9:
              goto label_37;
            case 10:
              entityMetadata = current as EntityMetadata;
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 4 : 4;
              continue;
            case 11:
              if (abstractMetadata == null)
              {
                num4 = 10;
                continue;
              }
              goto label_19;
            case 12:
              if (this.deactivatingModules.Contains<string>((string) DbModelUpdater.TIHVUOobQdEVVPZy6uvd((object) prevMetadataModule)))
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
                continue;
              }
              goto label_19;
            case 14:
              key = current;
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 3;
              continue;
            case 15:
              goto label_19;
            default:
              this.ProcessDeletedMetadataItem(current);
              num4 = 15;
              continue;
          }
        }
label_37:
        return;
label_5:
        current = enumerator.Current;
        num4 = 3;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
        {
          num4 = 8;
          goto label_4;
        }
        else
          goto label_4;
label_20:
        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 9 : 5;
        goto label_4;
      }
      finally
      {
        enumerator.Dispose();
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
          num5 = 0;
        switch (num5)
        {
          default:
        }
      }
    }

    /// <summary>Обработать изменения в элементе метаданных</summary>
    /// <param name="metadata">Элемент метаданных</param>
    protected virtual void ProcessMetadataItemChanges(EleWise.ELMA.Model.Metadata.AbstractMetadata metadata)
    {
      int num = 6;
      EntityMetadata metadata1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_9;
          case 1:
            this.ProcessEntityMetadataChanges(metadata1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 4;
            continue;
          case 2:
            if (DbModelUpdater.dqbLe5obCPq9twLJqUed((object) metadata1))
            {
              num = 3;
              continue;
            }
            goto case 1;
          case 3:
            goto label_4;
          case 4:
            goto label_10;
          case 5:
            if (metadata1 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 6:
            metadata1 = metadata as EntityMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 5 : 2;
            continue;
          default:
            goto label_2;
        }
      }
label_9:
      return;
label_4:
      return;
label_10:
      return;
label_2:;
    }

    /// <summary>Обработать изменения в элементе метаданных сущности</summary>
    /// <param name="metadata">Метаданные сущности</param>
    protected virtual void ProcessEntityMetadataChanges(EntityMetadata metadata)
    {
      int num1 = 46;
      EleWise.ELMA.Model.Metadata.AbstractMetadata abstractMetadata;
      List<TablePartMetadata>.Enumerator enumerator1;
      EntityMetadata metadata1;
      while (true)
      {
        int num2 = num1;
        EntityMetadata oldMetadata;
        SimpleTypeSettings simpleTypeSettings1;
        SimpleTypeSettings simpleTypeSettings2;
        PropertyMetadata propertyMetadata1;
        List<PropertyMetadata>.Enumerator enumerator2;
        PropertyMetadata propertyMetadata2;
        while (true)
        {
          string isGroupColumnName;
          int startTableActionsIndex;
          string tableName;
          string parentColumnName;
          int num3;
          switch (num2)
          {
            case 1:
              if (!DbModelUpdater.DDYo5Pobn7938k5w0fhI((object) metadata1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 15 : 31;
                continue;
              }
              goto case 51;
            case 2:
              this.TablesCreatedActions.Add((IDbAction) new DbCreateColumnAction(this.Transform, (string) DbModelUpdater.j9HeB4obukWkAm8EyPOq((object) metadata1), new Column((string) DbModelUpdater.qIR95KobvejQeGSTm33y(-630932142 - 1120244082 ^ -1751160446), DbType.Guid)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 40 : 25;
              continue;
            case 3:
              goto label_26;
            case 4:
            case 8:
            case 28:
              startTableActionsIndex = DbModelUpdater.KbckdKobiYyR0e0WHwuK((object) this.TablesCreatedActions);
              num2 = 6;
              continue;
            case 5:
              goto label_40;
            case 6:
              enumerator2 = metadata1.Properties.GetEnumerator();
              num2 = 3;
              continue;
            case 7:
            case 16:
            case 39:
            case 54:
              enumerator1 = oldMetadata.TableParts.GetEnumerator();
              num2 = 9;
              continue;
            case 9:
              goto label_97;
            case 10:
              if (abstractMetadata != null)
              {
                num2 = 50;
                continue;
              }
              goto case 37;
            case 11:
              if (oldMetadata.HierarchyType != HierarchyType.GroupAndElements)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 1 : 1;
                continue;
              }
              goto case 20;
            case 12:
              this.prevMetadata.TryGetValue(DbModelUpdater.DmN37SobEks2fuJmC4C1((object) metadata1), out abstractMetadata);
              num2 = 10;
              continue;
            case 13:
            case 50:
              if (metadata1 != abstractMetadata)
              {
                if (abstractMetadata == null)
                {
                  num2 = 30;
                  continue;
                }
                oldMetadata = abstractMetadata as EntityMetadata;
                num2 = 17;
                continue;
              }
              num2 = 44;
              continue;
            case 14:
              tableName = (string) DbModelUpdater.j9HeB4obukWkAm8EyPOq((object) metadata1);
              num2 = 32;
              continue;
            case 15:
              this.prevMetadata.TryGetValue(metadata1.ImplementationUid, out abstractMetadata);
              num2 = 13;
              continue;
            case 17:
              if (oldMetadata != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 3 : 25;
                continue;
              }
              goto label_125;
            case 18:
              try
              {
label_75:
                if (enumerator2.MoveNext())
                  goto label_70;
                else
                  goto label_76;
label_69:
                int num4;
                EntityPropertyMetadata oldPropertyMetadata;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      oldPropertyMetadata = (EntityPropertyMetadata) enumerator2.Current;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_70;
                    case 3:
                      goto label_77;
                    case 4:
                      goto label_75;
                    case 5:
                      goto label_43;
                    default:
                      // ISSUE: reference to a compiler-generated method
                      if ((EntityPropertyMetadata) metadata1.Properties.FirstOrDefault<PropertyMetadata>((System.Func<PropertyMetadata, bool>) (m => DbModelUpdater.\u003C\u003Ec__DisplayClass17_2.mA20ZECGvnXuTsjIfV37(m.Uid, oldPropertyMetadata.Uid))) == null)
                      {
                        num4 = 3;
                        continue;
                      }
                      goto label_75;
                  }
                }
label_77:
                try
                {
                  this.TablesDeletedActions.Add((IDbAction) new DeletePropertyAction((IDbModelUpdater) this, metadata1, oldPropertyMetadata, ref startTableActionsIndex));
                  int num5 = 5;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                      case 2:
                        goto label_75;
                      case 3:
                        if (!DbModelUpdater.wbEh2vobX2YmLKjrVTVs(DbModelUpdater.GoSmeTobSdkgVWAra1YL((object) metadata1), Guid.Empty))
                        {
                          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 1;
                          continue;
                        }
                        break;
                      case 4:
                        if (!metadata1.IsUnique)
                        {
                          num5 = 3;
                          continue;
                        }
                        goto label_75;
                      case 5:
                        if (DbModelUpdater.hky8mPobKfZK3oy0mlNJ(DbModelUpdater.QaeEHfobqLG62l2dFAWy((object) oldPropertyMetadata), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2092274397 << 4 ^ 883342754)))
                        {
                          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 4 : 3;
                          continue;
                        }
                        goto label_75;
                    }
                    this.needRecreateConstraints = true;
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 2 : 1;
                  }
                }
                catch (Exception ex)
                {
                  int num6 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
                    num6 = 0;
                  while (true)
                  {
                    switch (num6)
                    {
                      case 1:
                        goto label_75;
                      default:
                        DbModelUpdater.uZ3SrMobkDN6qTaVKWvZ(DbModelUpdater.vELDWgobTRh3h9ejUk7Q(), DbModelUpdater.gnAQ19obZTRBE0PrrqGx((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669371371 ^ 1669514451), DbModelUpdater.QaeEHfobqLG62l2dFAWy((object) oldMetadata), DbModelUpdater.QaeEHfobqLG62l2dFAWy((object) oldPropertyMetadata)), (object) ex);
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
label_70:
                num4 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
                {
                  num4 = 0;
                  goto label_69;
                }
                else
                  goto label_69;
label_76:
                num4 = 5;
                goto label_69;
              }
              finally
              {
                enumerator2.Dispose();
                int num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
                  num7 = 0;
                switch (num7)
                {
                  default:
                }
              }
            case 19:
              this.needRecreateConstraints = true;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 4 : 1;
              continue;
            case 20:
              num3 = 0;
              break;
            case 21:
              if (simpleTypeSettings2 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 7;
                continue;
              }
              goto case 47;
            case 22:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              propertyMetadata2 = metadata1.Properties.FirstOrDefault<PropertyMetadata>((System.Func<PropertyMetadata, bool>) (k => DbModelUpdater.\u003C\u003Ec__DisplayClass17_0.uRupVUChz31EgilpHwer(DbModelUpdater.\u003C\u003Ec__DisplayClass17_0.v9JYJSChckAdwkUGKxlg((object) k), DbModelUpdater.\u003C\u003Ec__DisplayClass17_0.Vn2VnhCGFrVhy96721F4((object) metadata1))));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 48 : 41;
              continue;
            case 23:
label_8:
              if (!DbModelUpdater.jFdspcob2SPPIVFpZp9Q(metadata1.IsGroupPropertyUid, Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 37 : 39;
                continue;
              }
              goto case 29;
            case 24:
              if (propertyMetadata1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 42 : 35;
                continue;
              }
              goto label_133;
            case 25:
              if (!DbModelUpdater.myJ0rUobI0gEkYVqH1ca(DbModelUpdater.j9HeB4obukWkAm8EyPOq((object) metadata1), DbModelUpdater.j9HeB4obukWkAm8EyPOq((object) oldMetadata)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 52 : 4;
                continue;
              }
              goto case 43;
            case 26:
              goto label_125;
            case 27:
              this.TablesDeletedActions.Add((IDbAction) new DbUpdateIsGroupColumnAction(this.Transform, tableName, isGroupColumnName, parentColumnName));
              num2 = 16;
              continue;
            case 29:
              if (DbModelUpdater.jFdspcob2SPPIVFpZp9Q(metadata1.ParentPropertyUid, Guid.Empty))
              {
                num2 = 14;
                continue;
              }
              goto case 7;
            case 30:
              this.TablesCreatedActions.Add((IDbAction) new NewEntityAction((IDbModelUpdater) this, metadata1));
              num2 = 35;
              continue;
            case 31:
              num3 = 0;
              break;
            case 32:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              propertyMetadata1 = metadata1.Properties.FirstOrDefault<PropertyMetadata>((System.Func<PropertyMetadata, bool>) (k => DbModelUpdater.\u003C\u003Ec__DisplayClass17_0.uRupVUChz31EgilpHwer(DbModelUpdater.\u003C\u003Ec__DisplayClass17_0.v9JYJSChckAdwkUGKxlg((object) k), metadata1.IsGroupPropertyUid)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 22 : 24;
              continue;
            case 33:
              parentColumnName = (string) DbModelUpdater.jE1VN7obPG2JUAqJI4vB((object) simpleTypeSettings2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 15 : 27;
              continue;
            case 34:
              if (simpleTypeSettings1 != null)
              {
                num2 = 21;
                continue;
              }
              goto case 7;
            case 35:
              goto label_60;
            case 36:
              if (!(DbModelUpdater.GoSmeTobSdkgVWAra1YL((object) metadata1) == Guid.Empty))
                goto case 4;
              else
                goto label_15;
            case 37:
              if (metadata1.Type == EntityMetadataType.InterfaceImplementation)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 9 : 15;
                continue;
              }
              goto case 13;
            case 38:
              if (DbModelUpdater.PBkId4obVVbEnTesSK9P((object) oldMetadata))
              {
                num2 = 28;
                continue;
              }
              goto case 36;
            case 40:
              this.TablesDeletedActions.Add((IDbAction) new DbUpdateAction(this.Transform, (string) DbModelUpdater.j9HeB4obukWkAm8EyPOq((object) metadata1), new string[1]
              {
                (string) DbModelUpdater.qIR95KobvejQeGSTm33y(825385222 ^ 825369444)
              }, new object[1]
              {
                (object) DbModelUpdater.DmN37SobEks2fuJmC4C1((object) metadata1)
              }, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-710283084 ^ -537863435 ^ 173767511)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 19 : 6;
              continue;
            case 41:
            case 52:
              if (!metadata1.AllowCreateHeirs)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 8 : 5;
                continue;
              }
              goto case 38;
            case 42:
              goto label_61;
            case 43:
              this.TablesCreatedActions.Add((IDbAction) new ChangeEntityAction((IDbModelUpdater) this, metadata1, oldMetadata));
              num2 = 41;
              continue;
            case 44:
              goto label_122;
            case 45:
              metadata1 = metadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 3 : 12;
              continue;
            case 46:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 45 : 21;
              continue;
            case 47:
              isGroupColumnName = (string) DbModelUpdater.jE1VN7obPG2JUAqJI4vB((object) simpleTypeSettings1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 33 : 10;
              continue;
            case 48:
              goto label_41;
            case 49:
              goto label_16;
            case 51:
              num3 = DbModelUpdater.PeNFtAobO0og5s85Gpgs((object) metadata1) == HierarchyType.GroupAndElements ? 1 : 0;
              break;
            case 53:
              goto label_21;
            default:
label_43:
              if (!DbModelUpdater.DDYo5Pobn7938k5w0fhI((object) oldMetadata))
              {
                num2 = 20;
                continue;
              }
              goto case 11;
          }
          if (num3 == 0)
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 45 : 54;
          else
            goto label_8;
        }
label_15:
        num1 = 2;
        continue;
label_21:
        SimpleTypeSettings simpleTypeSettings3 = (SimpleTypeSettings) null;
        goto label_136;
label_26:
        try
        {
label_29:
          if (enumerator2.MoveNext())
            goto label_31;
          else
            goto label_30;
label_27:
          EntityPropertyMetadata propertyMetadata3;
          int num8;
          EntityPropertyMetadata propertyMetadata;
          while (true)
          {
            switch (num8)
            {
              case 1:
                goto label_40;
              case 2:
                propertyMetadata = (EntityPropertyMetadata) enumerator2.Current;
                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
                continue;
              case 3:
                goto label_29;
              case 4:
                DbModelUpdater.uLoNkeobRWTde8qV8CRS((object) this, (object) metadata1, (object) propertyMetadata, (object) oldMetadata, (object) propertyMetadata3);
                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 3 : 1;
                continue;
              case 5:
                goto label_31;
              default:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                propertyMetadata3 = (EntityPropertyMetadata) oldMetadata.Properties.FirstOrDefault<PropertyMetadata>((System.Func<PropertyMetadata, bool>) (m => DbModelUpdater.\u003C\u003Ec__DisplayClass17_1.J2v80ZCGGAWnJDsPLaud(DbModelUpdater.\u003C\u003Ec__DisplayClass17_1.iCDwoGCGhSs3eKoL5Arc((object) m), DbModelUpdater.\u003C\u003Ec__DisplayClass17_1.iCDwoGCGhSs3eKoL5Arc((object) propertyMetadata))));
                num8 = 4;
                continue;
            }
          }
label_30:
          num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 1;
          goto label_27;
label_31:
          num8 = 2;
          goto label_27;
        }
        finally
        {
          enumerator2.Dispose();
          int num9 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
            num9 = 0;
          switch (num9)
          {
            default:
          }
        }
label_40:
        enumerator2 = oldMetadata.Properties.GetEnumerator();
        num1 = 18;
        continue;
label_41:
        if (propertyMetadata2 == null)
        {
          num1 = 53;
          continue;
        }
        simpleTypeSettings3 = DbModelUpdater.SeXBgpobeNim7CurEAMC((object) propertyMetadata2) as SimpleTypeSettings;
        goto label_136;
label_61:
        SimpleTypeSettings simpleTypeSettings4 = (SimpleTypeSettings) null;
        goto label_134;
label_133:
        simpleTypeSettings4 = DbModelUpdater.SeXBgpobeNim7CurEAMC((object) propertyMetadata1) as SimpleTypeSettings;
label_134:
        simpleTypeSettings1 = simpleTypeSettings4;
        num1 = 22;
        continue;
label_136:
        simpleTypeSettings2 = simpleTypeSettings3;
        num1 = 34;
      }
label_60:
      return;
label_122:
      return;
label_16:
      return;
label_97:
      try
      {
label_102:
        if (enumerator1.MoveNext())
          goto label_104;
        else
          goto label_103;
label_98:
        int num10;
        int num11 = num10;
label_99:
        TablePartMetadata tablePartMetadata;
        TablePartMetadata oldTablePartMetadata;
        while (true)
        {
          switch (num11)
          {
            case 1:
              oldTablePartMetadata = enumerator1.Current;
              num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 11 : 8;
              continue;
            case 2:
              if (tablePartMetadata != null)
              {
                num11 = 4;
                continue;
              }
              goto case 12;
            case 3:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              tablePartMetadata = metadata1.TableParts.FirstOrDefault<TablePartMetadata>((System.Func<TablePartMetadata, bool>) (m => DbModelUpdater.\u003C\u003Ec__DisplayClass17_3.igsGxHCGiJpWuXa5mRJW(m.Uid, DbModelUpdater.\u003C\u003Ec__DisplayClass17_3.MciQNMCGS4mCO59By3UJ((object) oldTablePartMetadata))));
              num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 2 : 1;
              continue;
            case 4:
              if (!DbModelUpdater.rLBBp3ob1V7seHSNwmYq((object) tablePartMetadata))
              {
                num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 12;
                continue;
              }
              goto label_102;
            case 5:
              goto label_120;
            case 8:
              goto label_113;
            case 9:
              goto label_104;
            case 10:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (metadata1.TableParts.FirstOrDefault<TablePartMetadata>((System.Func<TablePartMetadata, bool>) (m => DbModelUpdater.\u003C\u003Ec__DisplayClass17_3.rBxgQfCGV6PqpMcZ1sog((object) m) == DbModelUpdater.\u003C\u003Ec__DisplayClass17_3.rBxgQfCGV6PqpMcZ1sog((object) oldTablePartMetadata))) != null)
              {
                num11 = 6;
                continue;
              }
              goto case 3;
            case 11:
              if (oldTablePartMetadata == null)
              {
                num11 = 7;
                continue;
              }
              goto label_113;
            case 12:
              this.DeleteSubTableParts(oldTablePartMetadata);
              num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
              continue;
            default:
              goto label_102;
          }
        }
label_120:
        return;
label_113:
        if (!DbModelUpdater.rLBBp3ob1V7seHSNwmYq((object) oldTablePartMetadata))
        {
          num10 = 10;
          goto label_98;
        }
        else
          goto label_102;
label_103:
        num10 = 5;
        goto label_98;
label_104:
        num11 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
        {
          num11 = 1;
          goto label_99;
        }
        else
          goto label_99;
      }
      finally
      {
        enumerator1.Dispose();
        int num12 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
          num12 = 0;
        switch (num12)
        {
          default:
        }
      }
label_125:
      throw new DbModelException((string) DbModelUpdater.gnAQ19obZTRBE0PrrqGx(DbModelUpdater.nWpKsFob8KMuUwOEbHQY(DbModelUpdater.qIR95KobvejQeGSTm33y(222162814 ^ 222281704)), (object) metadata1.FullTypeName, (object) abstractMetadata.GetType().FullName));
    }

    /// <summary>Рекурсивный проход по вложенным блокам и их удаление</summary>
    /// <param name="tablePartMetadata"></param>
    protected void DeleteSubTableParts(TablePartMetadata tablePartMetadata)
    {
      int num1 = 1;
      List<TablePartMetadata>.Enumerator enumerator1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (tablePartMetadata.TableParts != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 2:
label_13:
            num1 = 5;
            continue;
          case 3:
            try
            {
label_5:
              if (enumerator1.MoveNext())
                goto label_4;
              else
                goto label_6;
label_3:
              TablePartMetadata current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_4;
                  case 2:
                    goto label_5;
                  case 3:
                    this.DeleteSubTableParts(current);
                    num2 = 2;
                    continue;
                  default:
                    goto label_13;
                }
              }
label_4:
              current = enumerator1.Current;
              num2 = 3;
              goto label_3;
label_6:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
              goto label_3;
            }
            finally
            {
              enumerator1.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
          case 4:
            goto label_48;
          case 5:
            goto label_14;
          default:
            enumerator1 = tablePartMetadata.TableParts.GetEnumerator();
            num1 = 3;
            continue;
        }
      }
label_48:
      return;
label_14:
      try
      {
        DbDeleteTableAction deleteTableAction = new DbDeleteTableAction(this.Transform, tablePartMetadata.TableName);
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
          num4 = 1;
        List<PropertyMetadata>.Enumerator enumerator2;
        while (true)
        {
          switch (num4)
          {
            case 0:
              goto label_46;
            case 1:
              enumerator2 = tablePartMetadata.Properties.GetEnumerator();
              num4 = 2;
              continue;
            case 2:
              try
              {
label_22:
                if (enumerator2.MoveNext())
                  goto label_20;
                else
                  goto label_23;
label_19:
                PropertyMetadata current1;
                List<EleWise.ELMA.Runtime.Db.Migrator.Framework.Table>.Enumerator enumerator3;
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      goto label_22;
                    case 2:
                      goto label_20;
                    case 3:
                      goto label_25;
                    case 4:
                      goto label_41;
                    default:
                      enumerator3 = DbModelHelper.GetPropertyDbStructures((EntityMetadata) tablePartMetadata, (EntityPropertyMetadata) current1).Tables.GetEnumerator();
                      num5 = 3;
                      continue;
                  }
                }
label_25:
                try
                {
label_27:
                  if (enumerator3.MoveNext())
                    goto label_29;
                  else
                    goto label_28;
label_26:
                  EleWise.ELMA.Runtime.Db.Migrator.Framework.Table current2;
                  int num6;
                  while (true)
                  {
                    switch (num6)
                    {
                      case 1:
                        goto label_22;
                      case 2:
                        goto label_27;
                      case 3:
                        goto label_29;
                      default:
                        this.TablesDeletedActions.Add((IDbAction) new DbDeleteTableAction(this.Transform, (string) DbModelUpdater.psUqrsobNrtwRxujMK24((object) current2)));
                        num6 = 2;
                        continue;
                    }
                  }
label_28:
                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 1 : 0;
                  goto label_26;
label_29:
                  current2 = enumerator3.Current;
                  num6 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
                  {
                    num6 = 0;
                    goto label_26;
                  }
                  else
                    goto label_26;
                }
                finally
                {
                  enumerator3.Dispose();
                  int num7 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
                    num7 = 0;
                  switch (num7)
                  {
                    default:
                  }
                }
label_20:
                current1 = enumerator2.Current;
                num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
                {
                  num5 = 0;
                  goto label_19;
                }
                else
                  goto label_19;
label_23:
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 3 : 4;
                goto label_19;
              }
              finally
              {
                enumerator2.Dispose();
                int num8 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
                  num8 = 0;
                switch (num8)
                {
                  default:
                }
              }
            case 3:
label_41:
              this.TablesDeletedActions.Add((IDbAction) deleteTableAction);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
              continue;
            default:
              goto label_42;
          }
        }
label_46:
        return;
label_42:;
      }
      catch (Exception ex)
      {
        int num9 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0)
          num9 = 0;
        while (true)
        {
          switch (num9)
          {
            case 1:
              goto label_39;
            default:
              DbModelUpdater.P34K8gob3TkRdjQ59amL(DbModelUpdater.vELDWgobTRh3h9ejUk7Q(), (object) string.Format((string) DbModelUpdater.qIR95KobvejQeGSTm33y(864270449 << 6 ^ -521384502), (object) tablePartMetadata.Name, (object) tablePartMetadata.TableName), (object) ex);
              num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 0;
              continue;
          }
        }
label_39:;
      }
    }

    /// <summary>Обработать изменения в свойстве метаданных</summary>
    /// <param name="metadata">Новые метаданные сущности</param>
    /// <param name="propertyMetadata">Новые метаданные свойства</param>
    /// <param name="oldMetadata">Старые метаданные сущности</param>
    /// <param name="oldPropertyMetadata">Старые метаданные свойства</param>
    protected virtual void ProcessEntityPropertyMetadataChanges(
      EntityMetadata metadata,
      EntityPropertyMetadata propertyMetadata,
      EntityMetadata oldMetadata,
      EntityPropertyMetadata oldPropertyMetadata)
    {
      int num1 = 9;
      string propertyTypeDisplayName;
      string str;
      EntityMetadata metadata1;
      while (true)
      {
        int num2 = num1;
        IPropertyTypeInfo propertyTypeInfo1;
        IPropertyTypeInfo propertyTypeInfo2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (DbModelUpdater.hNac88obp6warxwvY3bC((object) metadata1))
              {
                num2 = 12;
                continue;
              }
              goto case 21;
            case 2:
              if (!DbModelUpdater.jFdspcob2SPPIVFpZp9Q(DbModelUpdater.IxgolWob6qRxyFEnBoxu((object) propertyMetadata), DbModelUpdater.IxgolWob6qRxyFEnBoxu((object) oldPropertyMetadata)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 18 : 27;
                continue;
              }
              goto case 14;
            case 3:
              if (DbModelUpdater.hNac88obp6warxwvY3bC((object) metadata1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 36 : 10;
                continue;
              }
              goto label_45;
            case 4:
              if (propertyTypeInfo2 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
                continue;
              }
              goto label_38;
            case 5:
            case 27:
              if (DbModelUpdater.SeXBgpobeNim7CurEAMC((object) propertyMetadata) == null)
              {
                num2 = 28;
                continue;
              }
              goto label_3;
            case 6:
              if (!DbModelUpdater.hky8mPobKfZK3oy0mlNJ(DbModelUpdater.QaeEHfobqLG62l2dFAWy((object) propertyMetadata), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234311550)))
              {
                num2 = 26;
                continue;
              }
              goto case 3;
            case 7:
              goto label_59;
            case 8:
              metadata1 = metadata;
              num2 = 15;
              continue;
            case 9:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 8 : 7;
              continue;
            case 10:
              goto label_3;
            case 11:
              goto label_56;
            case 12:
              if (!DbModelUpdater.wbEh2vobX2YmLKjrVTVs(metadata1.BaseClassUid, Guid.Empty))
                goto case 21;
              else
                goto label_22;
            case 13:
              this.needRecreateConstraints = true;
              num2 = 33;
              continue;
            case 14:
            case 22:
              if (this.GetProcessEntityPropertyMetadataChangesHack().Contains((string) DbModelUpdater.uNvZP7obHutjOLc3DoFB(DbModelUpdater.QaeEHfobqLG62l2dFAWy((object) metadata1), DbModelUpdater.qIR95KobvejQeGSTm33y(993438473 ^ 993440205), DbModelUpdater.QaeEHfobqLG62l2dFAWy((object) propertyMetadata))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 4 : 5;
                continue;
              }
              goto case 38;
            case 15:
              if (oldPropertyMetadata != null)
              {
                if (!DbModelUpdater.hky8mPobKfZK3oy0mlNJ(DbModelUpdater.QaeEHfobqLG62l2dFAWy((object) propertyMetadata), DbModelUpdater.qIR95KobvejQeGSTm33y(-105199646 ^ -105207696)))
                {
                  num2 = 21;
                  continue;
                }
                goto case 1;
              }
              else
                goto label_27;
            case 16:
              if (!ComponentManager.Current.GetExtensionPoints<IIgnoreUidUI>().Any<IIgnoreUidUI>((System.Func<IIgnoreUidUI, bool>) (m => m.NeedIgnoreUid(metadata1))))
                goto case 30;
              else
                goto label_53;
            case 17:
              goto label_38;
            case 18:
              goto label_42;
            case 19:
            case 31:
              this.TablesDeletedActions.Add((IDbAction) new UidInitializeAction((IDbModelUpdater) this, metadata1, propertyMetadata, this.Session));
              num2 = 37;
              continue;
            case 20:
              goto label_60;
            case 21:
            case 33:
            case 34:
              if (DbModelUpdater.jFdspcob2SPPIVFpZp9Q(propertyMetadata.TypeUid, DbModelUpdater.zbIT8gob4Xrdk5sPA8Un((object) oldPropertyMetadata)))
              {
                num2 = 22;
                continue;
              }
              goto case 2;
            case 23:
              if (!DbModelUpdater.bto49BobwI9bJck2GyDT((object) oldPropertyMetadata))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 32 : 27;
                continue;
              }
              goto case 21;
            case 24:
              if (propertyMetadata.Settings != DbModelUpdater.SeXBgpobeNim7CurEAMC((object) oldPropertyMetadata))
              {
                num2 = 40;
                continue;
              }
              goto label_32;
            case 25:
              propertyTypeInfo1 = (IPropertyTypeInfo) DbModelUpdater.pwRxABobA2OrFRos66rC((object) this.MetadataService, propertyMetadata.TypeUid, DbModelUpdater.IxgolWob6qRxyFEnBoxu((object) propertyMetadata));
              num2 = 4;
              continue;
            case 26:
              goto label_31;
            case 28:
              goto label_17;
            case 29:
              str = (string) DbModelUpdater.eChi4wob7Q9DXaGjhcb4((object) propertyTypeInfo1, (object) propertyMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 20 : 17;
              continue;
            case 30:
              List<IDbAction> keysCreatedActions = this.ForeignKeysCreatedActions;
              ITransformationProvider transform = this.Transform;
              EleWise.ELMA.Runtime.Db.Migrator.Framework.Index index = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Index();
              DbModelUpdater.jpKUQMobDaRFgrqClaZD((object) index, DbModelUpdater.cxEXv4obayf6pPYOwsak((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 45003411), DbModelUpdater.j9HeB4obukWkAm8EyPOq((object) metadata1)));
              DbModelUpdater.zkeN31obt4Fv0xx7kf1E((object) index, DbModelUpdater.j9HeB4obukWkAm8EyPOq((object) metadata1));
              index.Columns = new List<string>()
              {
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87344155)
              };
              DbCreateUniqueIndexAction uniqueIndexAction = new DbCreateUniqueIndexAction(transform, index);
              keysCreatedActions.Add((IDbAction) uniqueIndexAction);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 11 : 19;
              continue;
            case 32:
              this.OnCompleteActions.Add((IDbAction) new UidInitializeAction((IDbModelUpdater) this, metadata1, propertyMetadata, this.Session));
              num2 = 13;
              continue;
            case 35:
              if (!DbModelUpdater.bto49BobwI9bJck2GyDT((object) propertyMetadata))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 4 : 34;
                continue;
              }
              goto case 23;
            case 36:
              if (DbModelUpdater.wbEh2vobX2YmLKjrVTVs(DbModelUpdater.GoSmeTobSdkgVWAra1YL((object) metadata1), Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 16 : 6;
                continue;
              }
              goto label_43;
            case 37:
              goto label_20;
            case 38:
              propertyTypeInfo2 = (IPropertyTypeInfo) DbModelUpdater.pwRxABobA2OrFRos66rC((object) this.MetadataService, DbModelUpdater.zbIT8gob4Xrdk5sPA8Un((object) oldPropertyMetadata), DbModelUpdater.IxgolWob6qRxyFEnBoxu((object) oldPropertyMetadata));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 25 : 6;
              continue;
            case 39:
              goto label_44;
            case 40:
              ChangePropertyAction changePropertyAction = new ChangePropertyAction((IDbModelUpdater) this, metadata1, propertyMetadata, oldPropertyMetadata);
              num2 = 7;
              continue;
            default:
              if (propertyTypeInfo1 == null)
              {
                num2 = 11;
                continue;
              }
              propertyTypeDisplayName = propertyTypeInfo2.GetPropertyTypeDisplayName((PropertyMetadata) oldPropertyMetadata);
              num2 = 29;
              continue;
          }
        }
label_3:
        if (DbModelUpdater.SeXBgpobeNim7CurEAMC((object) oldPropertyMetadata) != null)
        {
          num1 = 24;
          continue;
        }
        goto label_54;
label_20:
        this.needRecreateConstraints = true;
        num1 = 18;
        continue;
label_22:
        num1 = 35;
        continue;
label_27:
        num1 = 39;
        continue;
label_44:
        this.TablesCreatedActions.Add((IDbAction) new NewPropertyAction((IDbModelUpdater) this, metadata1, propertyMetadata));
        num1 = 6;
        continue;
label_53:
        num1 = 31;
      }
label_59:
      return;
label_42:
      return;
label_31:
      return;
label_17:
      return;
label_54:
      return;
label_45:
      return;
label_43:
      return;
label_32:
      return;
label_38:
      throw new DbModelException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536652182), (object) propertyMetadata.Name, DbModelUpdater.QaeEHfobqLG62l2dFAWy((object) metadata1), (object) DbModelUpdater.zbIT8gob4Xrdk5sPA8Un((object) oldPropertyMetadata)));
label_56:
      throw new DbModelException(EleWise.ELMA.SR.T((string) DbModelUpdater.qIR95KobvejQeGSTm33y(-882126494 ^ -882278242), DbModelUpdater.QaeEHfobqLG62l2dFAWy((object) propertyMetadata), DbModelUpdater.QaeEHfobqLG62l2dFAWy((object) metadata1), (object) DbModelUpdater.zbIT8gob4Xrdk5sPA8Un((object) propertyMetadata)));
label_60:
      throw new DbModelException(EleWise.ELMA.SR.T((string) DbModelUpdater.qIR95KobvejQeGSTm33y(1597012150 ^ 1597123114), (object) propertyMetadata.Name, (object) metadata1.Name, (object) propertyTypeDisplayName, (object) str));
    }

    /// <summary>Обработать удаленный элемент метаданных</summary>
    /// <param name="metadata">Элемент метаданных</param>
    protected virtual void ProcessDeletedMetadataItem(EleWise.ELMA.Model.Metadata.AbstractMetadata metadata)
    {
      int num = 2;
      while (true)
      {
        EntityMetadata entityMetadata;
        switch (num)
        {
          case 1:
            if (entityMetadata != null)
            {
              num = 5;
              continue;
            }
            goto label_8;
          case 2:
            entityMetadata = metadata as EntityMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 1;
            continue;
          case 3:
            goto label_9;
          case 4:
            goto label_2;
          case 5:
            if (entityMetadata.IsInterfaceType)
            {
              num = 4;
              continue;
            }
            break;
        }
        DbModelUpdater.Lr0TxIobxQDBhfNZd9Eq((object) this, (object) entityMetadata);
        num = 3;
      }
label_9:
      return;
label_2:
      return;
label_8:;
    }

    /// <summary>Обработать удаленный элемент метаданных сущности</summary>
    /// <param name="metadata">Метаданные сущности</param>
    protected virtual void ProcessDeletedEntityMetadata(EntityMetadata metadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.needRecreateConstraints = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.TablesDeletedActions.Add((IDbAction) new DeleteEntityAction((IDbModelUpdater) this, metadata));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    private IList<string> GetProcessEntityPropertyMetadataChangesHack()
    {
      if (this.processEntityPropertyMetadataChangesHack != null)
        return this.processEntityPropertyMetadataChangesHack;
      try
      {
        this._processEntityPropertyMetadataChangesHackWriteKey = Registry.LocalMachine.OpenSubKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-397266137 ^ 397234908), true);
        if (this._processEntityPropertyMetadataChangesHackWriteKey != null)
        {
          string name = Guid.NewGuid().ToString();
          this._processEntityPropertyMetadataChangesHackWriteKey.SetValue(name, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886645757));
          this._processEntityPropertyMetadataChangesHackWriteKey.DeleteValue(name);
        }
      }
      catch (IOException ex)
      {
        this._processEntityPropertyMetadataChangesHackWriteKey = (RegistryKey) null;
      }
      catch (SecurityException ex)
      {
        this._processEntityPropertyMetadataChangesHackWriteKey = (RegistryKey) null;
      }
      catch (UnauthorizedAccessException ex)
      {
        this._processEntityPropertyMetadataChangesHackWriteKey = (RegistryKey) null;
      }
      if (this._processEntityPropertyMetadataChangesHackWriteKey != null)
      {
        string s = this._processEntityPropertyMetadataChangesHackWriteKey.GetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909287425)) as string;
        if (!s.IsNullOrWhiteSpace())
          this.processEntityPropertyMetadataChangesHack = (IList<string>) ((IEnumerable<string>) s.Split(new char[1]
          {
            ';'
          }, StringSplitOptions.RemoveEmptyEntries)).ToArray<string>();
      }
      this.processEntityPropertyMetadataChangesHack = (IList<string>) ((object) this.processEntityPropertyMetadataChangesHack ?? (object) new string[0]);
      return this.processEntityPropertyMetadataChangesHack;
    }

    private void RemoveProcessEntityPropertyMetadataChangesHack()
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 4:
              this.processEntityPropertyMetadataChangesHack = (IList<string>) new string[0];
              num2 = 3;
              continue;
            case 2:
              goto label_7;
            case 3:
              goto label_8;
            case 5:
              if (this._processEntityPropertyMetadataChangesHackWriteKey == null)
              {
                num2 = 4;
                continue;
              }
              break;
          }
          DbModelUpdater.iOjfLwob0urUEgPqhoi9((object) this._processEntityPropertyMetadataChangesHackWriteKey, DbModelUpdater.qIR95KobvejQeGSTm33y(647913418 ^ 647761066));
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 0;
        }
label_8:
        this._processEntityPropertyMetadataChangesHackWriteKey = (RegistryKey) null;
        num1 = 2;
      }
label_7:;
    }

    /// <summary>Сервис управления метаданными в режиме Runtime</summary>
    public IMetadataRuntimeService MetadataService
    {
      get => this.\u003CMetadataService\u003Ek__BackingField;
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
              this.\u003CMetadataService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
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

    /// <summary>
    /// Новые метаданные системы.
    /// Доступно только на этапе преобразования БД.
    /// Не содержат метаданных процессов.
    /// </summary>
    public IEnumerable<EleWise.ELMA.Model.Metadata.AbstractMetadata> CurrentMetadata => (IEnumerable<EleWise.ELMA.Model.Metadata.AbstractMetadata>) this.currMetadata.Values.ToReadOnlyCollection<EleWise.ELMA.Model.Metadata.AbstractMetadata>();

    /// <summary>
    /// Предыдущие метаданные Объектов системы.
    /// Доступно только на этапе преобразования БД.
    /// Не содержат метаданных процессов.
    /// </summary>
    public IEnumerable<EleWise.ELMA.Model.Metadata.AbstractMetadata> PreviousMetadata => (IEnumerable<EleWise.ELMA.Model.Metadata.AbstractMetadata>) this.prevMetadata.Values.ToReadOnlyCollection<EleWise.ELMA.Model.Metadata.AbstractMetadata>();

    private void LoadCurrentMetadata()
    {
      int num1 = 4;
      IEnumerator<AssemblyModelsMetadata> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
            goto label_24;
          case 3:
            DbModelUpdater.d1ATmaobWrN6aZpTfQR7((object) this.currMetadataModules);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
            continue;
          case 4:
            DbModelUpdater.D9XgoIobBbfV8d0grcZV((object) this.currMetadata);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 3 : 1;
            continue;
          default:
            enumerator = this.MetadataService.GetAssemblyModelsMetadataList().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 1 : 1;
            continue;
        }
      }
label_24:
      return;
label_3:
      try
      {
label_7:
        if (DbModelUpdater.a6Xjbsooc1RoelgwJJWa((object) enumerator))
          goto label_9;
        else
          goto label_8;
label_4:
        AssemblyModelsMetadata current;
        DbModelUpdater.ModuleRef moduleRef1;
        int index;
        EleWise.ELMA.Model.Metadata.AbstractMetadata metadata;
        EleWise.ELMA.Model.Metadata.AbstractMetadata[] abstractMetadataArray;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 13:
              abstractMetadataArray = (EleWise.ELMA.Model.Metadata.AbstractMetadata[]) DbModelUpdater.zLHD4gobMPBpLIyGZ6Wy((object) current);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 14 : 8;
              continue;
            case 2:
              this.AddMetadataToDictionary(this.currMetadata, this.currMetadataModules, metadata, moduleRef1);
              num2 = 10;
              continue;
            case 3:
              goto label_7;
            case 4:
            case 12:
              metadata = abstractMetadataArray[index];
              num2 = 2;
              continue;
            case 5:
              DbModelUpdater.ModuleRef moduleRef2 = new DbModelUpdater.ModuleRef();
              DbModelUpdater.kPebmFobypcVVrFP5d7B((object) moduleRef2, (object) current.Name);
              moduleRef1 = moduleRef2;
              num2 = 8;
              continue;
            case 7:
              goto label_23;
            case 8:
              this.moduleRefs[current.Name] = moduleRef1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 1;
              continue;
            case 9:
              goto label_9;
            case 10:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
              continue;
            case 11:
              if (this.moduleRefs.TryGetValue((string) DbModelUpdater.CjDwcyobm1tkAWd4ZShC((object) current), out moduleRef1))
              {
                num2 = 13;
                continue;
              }
              goto case 5;
            case 14:
              index = 0;
              num2 = 6;
              continue;
            default:
              if (index < abstractMetadataArray.Length)
              {
                num2 = 4;
                continue;
              }
              goto label_7;
          }
        }
label_23:
        return;
label_8:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 6 : 7;
        goto label_4;
label_9:
        current = enumerator.Current;
        num2 = 10;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
        {
          num2 = 11;
          goto label_4;
        }
        else
          goto label_4;
      }
      finally
      {
        int num3;
        if (enumerator == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
        else
          goto label_25;
label_22:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_25:
        DbModelUpdater.VJ6qT2oosW0aSBDWnQVE((object) enumerator);
        num3 = 2;
        goto label_22;
      }
    }

    private void LoadPreviousMetadata()
    {
      int num1 = 2;
      IEnumerator<AssemblyModelsMetadata> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_26;
          case 1:
            this.prevMetadataModules.Clear();
            num1 = 3;
            continue;
          case 2:
            DbModelUpdater.D9XgoIobBbfV8d0grcZV((object) this.prevMetadata);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 1;
            continue;
          case 3:
            enumerator = this.MetadataService.GetPreviousAssemblyModelsMetadataList().GetEnumerator();
            num1 = 4;
            continue;
          case 4:
            goto label_3;
          default:
            goto label_21;
        }
      }
label_26:
      return;
label_21:
      return;
label_3:
      try
      {
label_17:
        if (enumerator.MoveNext())
          goto label_5;
        else
          goto label_18;
label_4:
        AssemblyModelsMetadata current;
        DbModelUpdater.ModuleRef moduleRef1;
        int index;
        EleWise.ELMA.Model.Metadata.AbstractMetadata[] abstractMetadataArray;
        EleWise.ELMA.Model.Metadata.AbstractMetadata metadata;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
              continue;
            case 3:
              this.AddMetadataToDictionary(this.prevMetadata, this.prevMetadataModules, metadata, moduleRef1);
              num2 = 8;
              continue;
            case 4:
              goto label_19;
            case 5:
              DbModelUpdater.ModuleRef moduleRef2 = new DbModelUpdater.ModuleRef();
              DbModelUpdater.kPebmFobypcVVrFP5d7B((object) moduleRef2, DbModelUpdater.CjDwcyobm1tkAWd4ZShC((object) current));
              moduleRef1 = moduleRef2;
              num2 = 10;
              continue;
            case 6:
              metadata = abstractMetadataArray[index];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 3 : 0;
              continue;
            case 7:
              if (!this.moduleRefs.TryGetValue((string) DbModelUpdater.CjDwcyobm1tkAWd4ZShC((object) current), out moduleRef1))
              {
                num2 = 5;
                continue;
              }
              goto case 9;
            case 8:
              ++index;
              num2 = 2;
              continue;
            case 9:
              abstractMetadataArray = (EleWise.ELMA.Model.Metadata.AbstractMetadata[]) DbModelUpdater.zLHD4gobMPBpLIyGZ6Wy((object) current);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 1 : 1;
              continue;
            case 10:
              this.moduleRefs[(string) DbModelUpdater.CjDwcyobm1tkAWd4ZShC((object) current)] = moduleRef1;
              num2 = 9;
              continue;
            case 11:
              goto label_17;
            case 12:
              goto label_5;
            default:
              if (index >= abstractMetadataArray.Length)
              {
                num2 = 11;
                continue;
              }
              goto case 6;
          }
        }
label_19:
        return;
label_5:
        current = enumerator.Current;
        num2 = 3;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
        {
          num2 = 7;
          goto label_4;
        }
        else
          goto label_4;
label_18:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 4 : 2;
        goto label_4;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                enumerator.Dispose();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
                continue;
              default:
                goto label_28;
            }
          }
        }
label_28:;
      }
    }

    private void AddMetadataToDictionary(
      Dictionary<Guid, EleWise.ELMA.Model.Metadata.AbstractMetadata> dictionary,
      Dictionary<EleWise.ELMA.Model.Metadata.AbstractMetadata, DbModelUpdater.ModuleRef> modulesDict,
      EleWise.ELMA.Model.Metadata.AbstractMetadata metadata,
      DbModelUpdater.ModuleRef moduleRef)
    {
      dictionary[metadata.Uid] = metadata;
      modulesDict[metadata] = moduleRef;
      if (!(metadata is ICompositeMetadata compositeMetadata))
        return;
      IEnumerable<IMetadata> compositeParts = compositeMetadata.GetCompositeParts();
      if (compositeParts == null)
        return;
      foreach (IMetadata metadata1 in compositeParts)
      {
        if (metadata1 is EleWise.ELMA.Model.Metadata.AbstractMetadata metadata2)
          this.AddMetadataToDictionary(dictionary, modulesDict, metadata2, moduleRef);
      }
    }

    private void SaveMetadata()
    {
      int num1 = 6;
      IEnumerable<AssemblyModelsMetadata> modelsMetadataList1;
      IEnumerator<AssemblyModelsMetadata> enumerator1;
      bool flag;
      List<NamespaceMetadata.TreeNode>.Enumerator enumerator2;
      IEnumerable<AssemblyModelsMetadata> modelsMetadataList2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            flag = false;
            num1 = 9;
            continue;
          case 2:
            enumerator2 = NamespaceMetadata.BuildNamespaceTree(this.currMetadata.Values.OfType<NamespaceMetadata>().ToList<NamespaceMetadata>()).Nodes.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
            continue;
          case 3:
            goto label_70;
          case 4:
label_24:
            enumerator1 = modelsMetadataList1.GetEnumerator();
            num1 = 10;
            continue;
          case 5:
            modelsMetadataList1 = this.MetadataService.GetPreviousAssemblyModelsMetadataList();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 1;
            continue;
          case 6:
            modelsMetadataList2 = this.MetadataService.GetAssemblyModelsMetadataList();
            num1 = 5;
            continue;
          case 7:
label_40:
            if (flag)
            {
              num1 = 2;
              continue;
            }
            goto label_65;
          case 8:
            try
            {
label_5:
              if (DbModelUpdater.a6Xjbsooc1RoelgwJJWa((object) enumerator1))
                goto label_11;
              else
                goto label_6;
label_4:
              AssemblyModelsMetadata assemblyModelsMetadata;
              int num2;
              AssemblyModelsMetadata newMetadata;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                  case 8:
                    goto label_5;
                  case 2:
                    if (newMetadata != assemblyModelsMetadata)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 6 : 6;
                      continue;
                    }
                    goto label_5;
                  case 3:
                    DbModelUpdater.c2rFr7ob9BQeWLocSF5D((object) this.Session, (object) newMetadata);
                    num2 = 8;
                    continue;
                  case 4:
                    this.Session.Merge<AssemblyModelsMetadata>(newMetadata);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 1;
                    continue;
                  case 5:
                    newMetadata = enumerator1.Current;
                    num2 = 7;
                    continue;
                  case 6:
                    flag = true;
                    num2 = 9;
                    continue;
                  case 7:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    assemblyModelsMetadata = modelsMetadataList1.FirstOrDefault<AssemblyModelsMetadata>((System.Func<AssemblyModelsMetadata, bool>) (a => DbModelUpdater.\u003C\u003Ec__DisplayClass50_0.Xgm6ryCGevdXKF0yvUog((object) a.Name, DbModelUpdater.\u003C\u003Ec__DisplayClass50_0.d5P7F6CG2K2QMVm0CpEX((object) newMetadata))));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 2 : 1;
                    continue;
                  case 9:
                    if (newMetadata.Id > 0L)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
                      continue;
                    }
                    goto case 3;
                  case 10:
                    goto label_11;
                  case 11:
                    goto label_24;
                  default:
                    DbModelUpdater.pld11pobJSyldIpiBuoa((object) newMetadata, AssemblyModelsMetadataStatus.Runned);
                    num2 = 4;
                    continue;
                }
              }
label_6:
              num2 = 11;
              goto label_4;
label_11:
              num2 = 5;
              goto label_4;
            }
            finally
            {
              int num3;
              if (enumerator1 == null)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
              else
                goto label_21;
label_20:
              switch (num3)
              {
                case 2:
                  break;
                default:
              }
label_21:
              DbModelUpdater.VJ6qT2oosW0aSBDWnQVE((object) enumerator1);
              num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
              {
                num3 = 1;
                goto label_20;
              }
              else
                goto label_20;
            }
          case 9:
            enumerator1 = modelsMetadataList2.GetEnumerator();
            num1 = 8;
            continue;
          case 10:
            try
            {
label_47:
              if (enumerator1.MoveNext())
                goto label_58;
              else
                goto label_48;
label_44:
              int num4;
              AssemblyModelsMetadata prevMetadata;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    if (DbModelUpdater.LHsEFpobdGuvddHU1PoL((object) prevMetadata) <= 0L)
                    {
                      num4 = 6;
                      continue;
                    }
                    goto case 14;
                  case 2:
                    this.Session.Delete((object) prevMetadata.Id, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87366483));
                    num4 = 8;
                    continue;
                  case 3:
                    DbModelUpdater.pld11pobJSyldIpiBuoa((object) prevMetadata, AssemblyModelsMetadataStatus.RunnedDisable);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
                    continue;
                  case 4:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    if (modelsMetadataList2.Any<AssemblyModelsMetadata>((System.Func<AssemblyModelsMetadata, bool>) (m => DbModelUpdater.\u003C\u003Ec__DisplayClass50_1.HTxpyyCGpNc662ZaIb3D(DbModelUpdater.\u003C\u003Ec__DisplayClass50_1.UUJdGBCG3yY8RErLOI5O((object) m), DbModelUpdater.\u003C\u003Ec__DisplayClass50_1.UUJdGBCG3yY8RErLOI5O((object) prevMetadata)))))
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 5 : 4;
                      continue;
                    }
                    goto case 1;
                  case 5:
                  case 8:
                  case 13:
                  case 15:
                    goto label_47;
                  case 6:
                  case 12:
                    DbModelUpdater.c2rFr7ob9BQeWLocSF5D((object) this.Session, (object) prevMetadata);
                    num4 = 15;
                    continue;
                  case 7:
                    if (!DbModelUpdater.hky8mPobKfZK3oy0mlNJ((object) prevMetadata.Name, DbModelUpdater.qIR95KobvejQeGSTm33y(~-397266137 ^ 397264630)))
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 4 : 2;
                      continue;
                    }
                    goto label_47;
                  case 9:
                    if (!DbModelUpdater.hky8mPobKfZK3oy0mlNJ(DbModelUpdater.CjDwcyobm1tkAWd4ZShC((object) prevMetadata), DbModelUpdater.qIR95KobvejQeGSTm33y(1514961705 ^ 1514959181)))
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 7 : 7;
                      continue;
                    }
                    goto label_47;
                  case 10:
                    prevMetadata = enumerator1.Current;
                    num4 = 9;
                    continue;
                  case 11:
                    goto label_58;
                  case 14:
                    if (this.deactivatingModules.Contains<string>((string) DbModelUpdater.CjDwcyobm1tkAWd4ZShC((object) prevMetadata)))
                    {
                      num4 = 2;
                      continue;
                    }
                    goto case 3;
                  case 16:
                    goto label_40;
                  default:
                    this.Session.Merge<AssemblyModelsMetadata>(prevMetadata);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 13 : 0;
                    continue;
                }
              }
label_48:
              num4 = 16;
              goto label_44;
label_58:
              num4 = 4;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
              {
                num4 = 10;
                goto label_44;
              }
              else
                goto label_44;
            }
            finally
            {
              if (enumerator1 != null)
              {
                int num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0)
                  num5 = 0;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      goto label_72;
                    default:
                      DbModelUpdater.VJ6qT2oosW0aSBDWnQVE((object) enumerator1);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 1 : 0;
                      continue;
                  }
                }
              }
label_72:;
            }
          default:
            goto label_25;
        }
      }
label_70:
      return;
label_25:
      try
      {
label_28:
        if (enumerator2.MoveNext())
          goto label_30;
        else
          goto label_29;
label_27:
        NamespaceMetadata.TreeNode current;
        int num6;
        while (true)
        {
          switch (num6)
          {
            case 1:
              this.SaveNamespaceGroup(current, (IMetadataItemGroup) null);
              num6 = 2;
              continue;
            case 2:
              goto label_28;
            case 3:
              goto label_62;
            default:
              goto label_30;
          }
        }
label_62:
        return;
label_29:
        num6 = 3;
        goto label_27;
label_30:
        current = enumerator2.Current;
        num6 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
        {
          num6 = 1;
          goto label_27;
        }
        else
          goto label_27;
      }
      finally
      {
        enumerator2.Dispose();
        int num7 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
          num7 = 0;
        switch (num7)
        {
          default:
        }
      }
label_65:;
    }

    private void SaveNamespaceGroup(NamespaceMetadata.TreeNode node, IMetadataItemGroup parent)
    {
      int num1 = 9;
      IMetadataItemGroup parent1;
      List<NamespaceMetadata.TreeNode>.Enumerator enumerator;
      while (true)
      {
        int num2 = num1;
        // ISSUE: variable of a compiler-generated type
        DbModelUpdater.\u003C\u003Ec__DisplayClass51_0 cDisplayClass510;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_4;
            case 2:
              goto label_16;
            case 3:
              // ISSUE: reference to a compiler-generated field
              DbModelUpdater.YYKvM6ohW5braayyVceP((object) parent1, (object) cDisplayClass510.node.Namespace);
              num2 = 4;
              continue;
            case 4:
              parent1.Parent = parent;
              num2 = 5;
              continue;
            case 5:
              DbModelUpdater.BFj6wTohoQNaclFkQkrS((object) parent1, true);
              num2 = 12;
              continue;
            case 6:
              IEntityManager<IMetadataItemGroup> instance = EntityManager<IMetadataItemGroup>.Instance;
              // ISSUE: type reference
              ParameterExpression parameterExpression = (ParameterExpression) DbModelUpdater.DnC2bIobrICpddRQ8BC7(DbModelUpdater.FsCAnmoblbbXgkXkbhds(__typeref (IMetadataItemGroup)), DbModelUpdater.qIR95KobvejQeGSTm33y(1253244298 - 1829393894 ^ -576171996));
              // ISSUE: method reference
              // ISSUE: type reference
              // ISSUE: field reference
              // ISSUE: method reference
              // ISSUE: method reference
              // ISSUE: type reference
              Expression<System.Func<IMetadataItemGroup, bool>> condition = Expression.Lambda<System.Func<IMetadataItemGroup, bool>>((Expression) DbModelUpdater.K0t3GbobsrmKEMhm0PKw(DbModelUpdater.vK0QKmobUaa5f56cMBqI((object) Expression.Property((Expression) parameterExpression, (MethodInfo) DbModelUpdater.Wn9nb5obg2av6LSXi1o0(__methodref (IMetadataItemGroup.get_Namespace))), DbModelUpdater.v3LhnoobLFhSrbO6VLy9(DbModelUpdater.EqRGw8obYFlMDoSHeNF1(DbModelUpdater.ogWWMtob5CajJr6VYA6S((object) cDisplayClass510, DbModelUpdater.FsCAnmoblbbXgkXkbhds(__typeref (DbModelUpdater.\u003C\u003Ec__DisplayClass51_0))), DbModelUpdater.n4amMTobjvcEh7Yu44vN(__fieldref (DbModelUpdater.\u003C\u003Ec__DisplayClass51_0.node))), (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (NamespaceMetadata.TreeNode.get_Namespace)))), DbModelUpdater.vK0QKmobUaa5f56cMBqI(DbModelUpdater.v3LhnoobLFhSrbO6VLy9((object) parameterExpression, (object) (MethodInfo) DbModelUpdater.Wn9nb5obg2av6LSXi1o0(__methodref (IMetadataItemGroup.get_IsSystem))), DbModelUpdater.ogWWMtob5CajJr6VYA6S((object) true, DbModelUpdater.FsCAnmoblbbXgkXkbhds(__typeref (bool))))), parameterExpression);
              parent1 = instance.Find(condition).FirstOrDefault<IMetadataItemGroup>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
              continue;
            case 7:
              // ISSUE: reference to a compiler-generated field
              DbModelUpdater.gOsSvuobzNg6BNxnCFCW((object) parent1, DbModelUpdater.Mv9dCDobcU5eQLn2Wayr((object) cDisplayClass510.node));
              num2 = 13;
              continue;
            case 8:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass510.node = node;
              num2 = 6;
              continue;
            case 9:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass510 = new DbModelUpdater.\u003C\u003Ec__DisplayClass51_0();
              num2 = 8;
              continue;
            case 10:
              // ISSUE: reference to a compiler-generated field
              enumerator = cDisplayClass510.node.Nodes.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 1 : 0;
              continue;
            case 11:
              goto label_24;
            case 12:
              DbModelUpdater.FKtpSUohbGuQh4e7hLtF((object) parent1);
              num2 = 10;
              continue;
            case 13:
              // ISSUE: reference to a compiler-generated field
              DbModelUpdater.qNF0bHohBeKo50v5ipdD((object) parent1, DbModelUpdater.TJDiSHohFJLtZjVmycSs((object) cDisplayClass510.node));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 3 : 3;
              continue;
            default:
              if (parent1 == null)
              {
                num2 = 11;
                continue;
              }
              goto case 7;
          }
        }
label_24:
        parent1 = InterfaceActivator.Create<IMetadataItemGroup>();
        num1 = 7;
      }
label_16:
      return;
label_4:
      try
      {
label_10:
        if (enumerator.MoveNext())
          goto label_7;
        else
          goto label_11;
label_5:
        NamespaceMetadata.TreeNode current;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 0:
              goto label_12;
            case 1:
              goto label_7;
            case 2:
              goto label_10;
            case 3:
              this.SaveNamespaceGroup(current, parent1);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 2 : 1;
              continue;
            default:
              goto label_6;
          }
        }
label_12:
        return;
label_6:
        return;
label_7:
        current = enumerator.Current;
        num3 = 3;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
        {
          num3 = 2;
          goto label_5;
        }
        else
          goto label_5;
label_11:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
        goto label_5;
      }
      finally
      {
        enumerator.Dispose();
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
          num4 = 0;
        switch (num4)
        {
          default:
        }
      }
    }

    string IDbModelUpdater.GenerateForeignKeyName(string tableName, string columnName) => GenerateNameHelper.GenerateForeignKeyName((string) DbModelUpdater.qIR95KobvejQeGSTm33y(1149433385 + 173655049 ^ 1323231640), tableName, columnName);

    string IDbModelUpdater.GeneratePrimaryKeyName(string tableName, string columnName) => GenerateNameHelper.GeneratePrimaryKeyName((string) DbModelUpdater.qIR95KobvejQeGSTm33y(1669212571 ^ 1669102115), tableName, columnName);

    public DbModelUpdater()
    {
      DbModelUpdater.P2O0Jhohh0EcDSPOXcTQ();
      this.currMetadata = new Dictionary<Guid, EleWise.ELMA.Model.Metadata.AbstractMetadata>();
      this.prevMetadata = new Dictionary<Guid, EleWise.ELMA.Model.Metadata.AbstractMetadata>();
      this.currMetadataModules = new Dictionary<EleWise.ELMA.Model.Metadata.AbstractMetadata, DbModelUpdater.ModuleRef>();
      this.prevMetadataModules = new Dictionary<EleWise.ELMA.Model.Metadata.AbstractMetadata, DbModelUpdater.ModuleRef>();
      this.moduleRefs = new Dictionary<string, DbModelUpdater.ModuleRef>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static DbModelUpdater()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            DbModelUpdater.DbUpdateLog = (ILogger) DbModelUpdater.D6eFhKohG6e9X0KX3pP9(DbModelUpdater.qIR95KobvejQeGSTm33y(~541731958 ^ -541842459));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object QkXxEfoojJa6FFLIIxGn([In] object obj0) => (object) ((IRuntimeApplication) obj0).DbPreUpdater;

    internal static bool toRjdpoog6DFxSZdftXY() => DbModelUpdater.O5qXfSoorDF2hrPyRPyX == null;

    internal static DbModelUpdater LGxuxooo517XPctPV0Sk() => DbModelUpdater.O5qXfSoorDF2hrPyRPyX;

    internal static void apqCMZooYmYusrPGTi54([In] object obj0) => ((List<IDbAction>) obj0).Clear();

    internal static object axumBMooLlY7Mhn4KKDC() => (object) ComponentManager.Current;

    internal static void xUmpYIooUCTMsJGTfpw6([In] object obj0, [In] object obj1, [In] object obj2) => ((IEntityActionExtender) obj0).Extend((IDbModelUpdater) obj1, (EntityMetadata) obj2);

    internal static void VJ6qT2oosW0aSBDWnQVE([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool a6Xjbsooc1RoelgwJJWa([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static object S8PJ74oozuGqpBF5WjuB() => (object) EleWise.ELMA.SR.KeyCultureInfo;

    internal static void O8pRgBobFuS1ZtsNc4iW([In] object obj0, [In] object obj1) => EleWise.ELMA.SR.RunWithCulture((CultureInfo) obj0, (System.Action) obj1);

    internal static void D9XgoIobBbfV8d0grcZV([In] object obj0) => ((Dictionary<Guid, EleWise.ELMA.Model.Metadata.AbstractMetadata>) obj0).Clear();

    internal static void d1ATmaobWrN6aZpTfQR7([In] object obj0) => ((Dictionary<EleWise.ELMA.Model.Metadata.AbstractMetadata, DbModelUpdater.ModuleRef>) obj0).Clear();

    internal static void gmxKaIobo0Q20fYMCIVo([In] object obj0) => ((Dictionary<string, DbModelUpdater.ModuleRef>) obj0).Clear();

    internal static object wPi26hobbLmeXJ3nvZgQ([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((ITransformationProvider) obj0).GetDeletingColumnTemporaryName((string) obj1, (string) obj2);

    internal static void YWXZxVobhoDJcXyjIbPJ([In] object obj0) => ((DbUpdateHandler) obj0).OnForeignKeysCreated();

    internal static void OKvq5FobGNk8egotQQvw([In] object obj0, [In] object obj1) => ((DbModelUpdater) obj0).ProcessMetadataItemChanges((EleWise.ELMA.Model.Metadata.AbstractMetadata) obj1);

    internal static Guid DmN37SobEks2fuJmC4C1([In] object obj0) => ((EleWise.ELMA.Model.Metadata.AbstractMetadata) obj0).Uid;

    internal static Guid gakq6OobfvJAprkvEFC2([In] object obj0) => ((EntityMetadata) obj0).ImplementationUid;

    internal static object TIHVUOobQdEVVPZy6uvd([In] object obj0) => (object) ((DbModelUpdater.ModuleRef) obj0).Name;

    internal static bool dqbLe5obCPq9twLJqUed([In] object obj0) => ((ClassMetadata) obj0).IsInterfaceType;

    internal static object qIR95KobvejQeGSTm33y(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object nWpKsFob8KMuUwOEbHQY([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object gnAQ19obZTRBE0PrrqGx([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object j9HeB4obukWkAm8EyPOq([In] object obj0) => (object) ((EntityMetadata) obj0).TableName;

    internal static bool myJ0rUobI0gEkYVqH1ca([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static bool PBkId4obVVbEnTesSK9P([In] object obj0) => ((ClassMetadata) obj0).AllowCreateHeirs;

    internal static Guid GoSmeTobSdkgVWAra1YL([In] object obj0) => ((ClassMetadata) obj0).BaseClassUid;

    internal static int KbckdKobiYyR0e0WHwuK([In] object obj0) => ((List<IDbAction>) obj0).Count;

    internal static void uLoNkeobRWTde8qV8CRS(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3,
      [In] object obj4)
    {
      ((DbModelUpdater) obj0).ProcessEntityPropertyMetadataChanges((EntityMetadata) obj1, (EntityPropertyMetadata) obj2, (EntityMetadata) obj3, (EntityPropertyMetadata) obj4);
    }

    internal static object QaeEHfobqLG62l2dFAWy([In] object obj0) => (object) ((EleWise.ELMA.Model.Metadata.NamedMetadata) obj0).Name;

    internal static bool hky8mPobKfZK3oy0mlNJ([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static bool wbEh2vobX2YmLKjrVTVs([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object vELDWgobTRh3h9ejUk7Q() => (object) Logger.Log;

    internal static void uZ3SrMobkDN6qTaVKWvZ([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Info(obj1, (Exception) obj2);

    internal static bool DDYo5Pobn7938k5w0fhI([In] object obj0) => ((EntityMetadata) obj0).Hierarchical;

    internal static HierarchyType PeNFtAobO0og5s85Gpgs([In] object obj0) => ((EntityMetadata) obj0).HierarchyType;

    internal static bool jFdspcob2SPPIVFpZp9Q([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object SeXBgpobeNim7CurEAMC([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static object jE1VN7obPG2JUAqJI4vB([In] object obj0) => (object) ((SimpleTypeSettings) obj0).FieldName;

    internal static bool rLBBp3ob1V7seHSNwmYq([In] object obj0) => ((EntityMetadata) obj0).IsActivePermissionMetadata();

    internal static object psUqrsobNrtwRxujMK24([In] object obj0) => (object) ((EleWise.ELMA.Runtime.Db.Migrator.Framework.Table) obj0).Name;

    internal static void P34K8gob3TkRdjQ59amL([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static bool hNac88obp6warxwvY3bC([In] object obj0) => ((EntityMetadata) obj0).IsUnique;

    internal static object cxEXv4obayf6pPYOwsak([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static void jpKUQMobDaRFgrqClaZD([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Runtime.Db.Migrator.Framework.Index) obj0).Name = (string) obj1;

    internal static void zkeN31obt4Fv0xx7kf1E([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Runtime.Db.Migrator.Framework.Index) obj0).TableName = (string) obj1;

    internal static bool bto49BobwI9bJck2GyDT([In] object obj0) => ((PropertyMetadata) obj0).IsSystem;

    internal static Guid zbIT8gob4Xrdk5sPA8Un([In] object obj0) => ((PropertyMetadata) obj0).TypeUid;

    internal static Guid IxgolWob6qRxyFEnBoxu([In] object obj0) => ((PropertyMetadata) obj0).SubTypeUid;

    internal static object uNvZP7obHutjOLc3DoFB([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object pwRxABobA2OrFRos66rC([In] object obj0, Guid typeUid, Guid subTypeUid) => (object) ((IMetadataService) obj0).GetTypeDescriptor(typeUid, subTypeUid);

    internal static object eChi4wob7Q9DXaGjhcb4([In] object obj0, [In] object obj1) => (object) ((IPropertyTypeInfo) obj0).GetPropertyTypeDisplayName((PropertyMetadata) obj1);

    internal static void Lr0TxIobxQDBhfNZd9Eq([In] object obj0, [In] object obj1) => ((DbModelUpdater) obj0).ProcessDeletedEntityMetadata((EntityMetadata) obj1);

    internal static void iOjfLwob0urUEgPqhoi9([In] object obj0, [In] object obj1) => ((RegistryKey) obj0).DeleteValue((string) obj1);

    internal static object CjDwcyobm1tkAWd4ZShC([In] object obj0) => (object) ((AssemblyModelsMetadata) obj0).Name;

    internal static void kPebmFobypcVVrFP5d7B([In] object obj0, [In] object obj1) => ((DbModelUpdater.ModuleRef) obj0).Name = (string) obj1;

    internal static object zLHD4gobMPBpLIyGZ6Wy([In] object obj0) => (object) ((AssemblyModelsMetadata) obj0).RestoreMetadata();

    internal static void pld11pobJSyldIpiBuoa([In] object obj0, AssemblyModelsMetadataStatus value) => ((AssemblyModelsMetadata) obj0).Status = value;

    internal static object c2rFr7ob9BQeWLocSF5D([In] object obj0, [In] object obj1) => ((ISession) obj0).Save(obj1);

    internal static long LHsEFpobdGuvddHU1PoL([In] object obj0) => ((AssemblyModelsMetadata) obj0).Id;

    internal static Type FsCAnmoblbbXgkXkbhds([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object DnC2bIobrICpddRQ8BC7([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object Wn9nb5obg2av6LSXi1o0([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object ogWWMtob5CajJr6VYA6S([In] object obj0, [In] Type obj1) => (object) Expression.Constant(obj0, obj1);

    internal static object n4amMTobjvcEh7Yu44vN([In] RuntimeFieldHandle obj0) => (object) FieldInfo.GetFieldFromHandle(obj0);

    internal static object EqRGw8obYFlMDoSHeNF1([In] object obj0, [In] object obj1) => (object) Expression.Field((Expression) obj0, (FieldInfo) obj1);

    internal static object v3LhnoobLFhSrbO6VLy9([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static object vK0QKmobUaa5f56cMBqI([In] object obj0, [In] object obj1) => (object) Expression.Equal((Expression) obj0, (Expression) obj1);

    internal static object K0t3GbobsrmKEMhm0PKw([In] object obj0, [In] object obj1) => (object) Expression.AndAlso((Expression) obj0, (Expression) obj1);

    internal static object Mv9dCDobcU5eQLn2Wayr([In] object obj0) => (object) ((NamespaceMetadata.TreeNode) obj0).Name;

    internal static void gOsSvuobzNg6BNxnCFCW([In] object obj0, [In] object obj1) => ((IMetadataItemGroup) obj0).Name = (string) obj1;

    internal static object TJDiSHohFJLtZjVmycSs([In] object obj0) => (object) ((NamespaceMetadata.TreeNode) obj0).DisplayName;

    internal static void qNF0bHohBeKo50v5ipdD([In] object obj0, [In] object obj1) => ((IMetadataItemGroup) obj0).DisplayName = (string) obj1;

    internal static void YYKvM6ohW5braayyVceP([In] object obj0, [In] object obj1) => ((IMetadataItemGroup) obj0).Namespace = (string) obj1;

    internal static void BFj6wTohoQNaclFkQkrS([In] object obj0, bool value) => ((IMetadataItemGroup) obj0).IsSystem = value;

    internal static void FKtpSUohbGuQh4e7hLtF([In] object obj0) => ((IEntity) obj0).Save();

    internal static void P2O0Jhohh0EcDSPOXcTQ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object D6eFhKohG6e9X0KX3pP9([In] object obj0) => (object) Logger.GetLogger((string) obj0);

    private class ModuleRef
    {
      private static object DT78FNChJIirv90EVoJ8;

      public string Name
      {
        get => this.\u003CName\u003Ek__BackingField;
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
                this.\u003CName\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
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

      public ModuleRef()
      {
        DbModelUpdater.ModuleRef.LLMMTKChlGQlsPTjAhDP();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool TpDBFdCh9Lh7avR4T4h1() => DbModelUpdater.ModuleRef.DT78FNChJIirv90EVoJ8 == null;

      internal static DbModelUpdater.ModuleRef q1TBXUChd4lOaOOlIIcF() => (DbModelUpdater.ModuleRef) DbModelUpdater.ModuleRef.DT78FNChJIirv90EVoJ8;

      internal static void LLMMTKChlGQlsPTjAhDP() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
