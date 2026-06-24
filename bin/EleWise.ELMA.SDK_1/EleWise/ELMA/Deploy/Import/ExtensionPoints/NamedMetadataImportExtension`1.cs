// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.NamedMetadataImportExtension`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.BPMApps.Enum;
using EleWise.ELMA.Deploy.Import.Helpers;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Model.Scripts.Manager;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  /// <summary>
  /// Точка расширения для обработки NamedMetadata при импорте конфигурации
  /// </summary>
  /// <typeparam name="T">Тип метаданных</typeparam>
  public abstract class NamedMetadataImportExtension<T> : IConfigImportActionExtension where T : NamedMetadata
  {
    private static object x7QID5El21aAyqENoiUC;

    /// <summary>Точки расширения обработки метаданных при импорте</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public IEnumerable<IMetadataImport> MetadataImports { private get; set; }

    /// <summary>Служба управления метаданными</summary>
    internal IMetadataService MetadataService => MetadataServiceContext.Service;

    /// <summary>Служба управления метаданными в режиме Runtime</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public IMetadataRuntimeService MetadataRuntimeService
    {
      internal get => this.\u003CMetadataRuntimeService\u003Ek__BackingField;
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
              this.\u003CMetadataRuntimeService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
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

    /// <summary>Сервис редактирования метаданных</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public IMetadataEditorService MetadataEditorService
    {
      internal get => this.\u003CMetadataEditorService\u003Ek__BackingField;
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
              this.\u003CMetadataEditorService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
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

    /// <summary>Менеджер модуля скриптов</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ScriptModuleManager ScriptModuleManager
    {
      internal get => this.\u003CScriptModuleManager\u003Ek__BackingField;
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
              this.\u003CScriptModuleManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
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

    /// <inheritdoc />
    public virtual void OnPreStartTest(PreStartTestImportParameters parameters)
    {
    }

    IReadMetadataResult IConfigImportActionExtension.OnReadMetadata(
      ReadMetadataParameters parameters,
      bool isTestRead)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (parameters.Metadata is T metadata)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return (IReadMetadataResult) null;
label_3:
      return this.ReadMetadata(metadata, parameters, isTestRead);
    }

    /// <inheritdoc />
    public virtual void OnPrePublish(PrePublishParameters parameters)
    {
    }

    /// <inheritdoc />
    public virtual void OnPostPublish(PostPublishParameters parameters)
    {
    }

    /// <summary>Чтение менаданных</summary>
    /// <param name="mdImported">Метаданные</param>
    /// <param name="parameters">Параметры</param>
    /// <param name="isTestRead">Тестовое чтение</param>
    protected virtual IReadMetadataResult ReadMetadata(
      T mdImported,
      ReadMetadataParameters parameters,
      bool isTestRead)
    {
      parameters.Messages.Add(new DeployLogMessage(BPMAppItemImportStatus.InProgress, mdImported.Uid, parameters.TreeUid));
      IConfigImportSettings configImportSettings;
      if (isTestRead && (configImportSettings = parameters.ImportSettings as IConfigImportSettings) != null && configImportSettings.FakeManifest != null)
        this.MetadataImports.ForEach<IMetadataImport>((Action<IMetadataImport>) (e =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                e.CreateFakeChapter((NamedMetadata) mdImported, configImportSettings.FakeManifest, parameters.ManifestExecuteMetadata);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
      if (!this.CheckSystemMetadata(mdImported, parameters, isTestRead))
        return (IReadMetadataResult) null;
      T draft = this.GetDraft(mdImported, parameters);
      T obj;
      if ((object) draft == null)
      {
        this.CheckNewMetadata(mdImported, isTestRead, parameters);
        obj = mdImported;
      }
      else
      {
        obj = ClassSerializationHelper.CloneObjectByXml<T>(draft);
        if (!this.CheckMetadata(mdImported, obj, parameters))
          return (IReadMetadataResult) null;
        this.MergeMetadata(mdImported, obj, isTestRead, parameters);
      }
      parameters.MetadataNotIsUnique.Add(mdImported.Uid);
      return (IReadMetadataResult) new NamedMetadataImportExtension<T>.ReadMetadataResult(obj, parameters, isTestRead, this);
    }

    /// <summary>Проверка системных метаданных</summary>
    /// <param name="mdImported">Метаданные</param>
    /// <param name="parameters">Параметры</param>
    /// <param name="isTestRead">Тестовое чтение</param>
    protected virtual bool CheckSystemMetadata(
      T mdImported,
      ReadMetadataParameters parameters,
      bool isTestRead)
    {
      T metadata = this.MetadataRuntimeService.GetMetadataList().FirstOrDefault<IMetadata>((Func<IMetadata, bool>) (md => md.Uid == mdImported.Uid)) as T;
      if (parameters.IsSystemMetadata)
      {
        if ((object) metadata == null)
        {
          if (!isTestRead || this.MetadataService.GetMetadataList().All<IMetadata>((Func<IMetadata, bool>) (md => md.Uid != mdImported.Uid)))
            parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Warning, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479219500), (object) mdImported.Name, (object) mdImported.Uid, (object) mdImported.DisplayName)));
          if (!isTestRead)
            throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97661976)));
        }
        else if (!metadata.IsSystem())
          parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 539149845), (object) mdImported.Name, (object) mdImported.Uid, (object) metadata.DisplayName, (object) mdImported.DisplayName, (object) metadata.Name, (object) metadata.Uid)));
        else if (metadata.Name != mdImported.Name)
          parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 1418687478), (object) mdImported.Uid, (object) mdImported.Name, (object) metadata.Name, (object) mdImported.DisplayName, (object) metadata.DisplayName, (object) metadata.Uid)));
        else if (metadata.GetType() != mdImported.GetType())
          parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477383850), (object) mdImported.Uid, (object) mdImported.Name, (object) metadata.Name, (object) mdImported.DisplayName, (object) metadata.DisplayName, (object) metadata.Uid)));
        return false;
      }
      if ((object) metadata == null || !metadata.IsSystem())
        return true;
      parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138399266), (object) mdImported.DisplayName, (object) mdImported.Uid, (object) metadata.DisplayName, (object) mdImported.Name, (object) metadata.Name, (object) metadata.Uid)));
      return false;
    }

    /// <summary>Получение черновика метаданных</summary>
    /// <param name="mdImported">Метаданные</param>
    /// <param name="parameters">Параметры</param>
    /// <returns></returns>
    protected virtual T GetDraft(T mdImported, ReadMetadataParameters parameters) => this.MetadataEditorService.GetMetadataList().FirstOrDefault<IMetadata>((Func<IMetadata, bool>) (md => md.Uid == mdImported.Uid)) as T;

    /// <summary>Проверить прочитанные метаданные</summary>
    /// <param name="mdMerged">Метаданные</param>
    /// <param name="parameters">Параметры</param>
    /// <param name="isTestRead">Тестовое чтение</param>
    protected virtual bool TestMetadata(
      T mdMerged,
      ReadMetadataParameters parameters,
      bool isTestRead)
    {
      TestImportMessages message = MetadataImportHelper.ValidateObjectName((NamedMetadata) mdMerged, mdMerged.Name);
      if (message != null)
      {
        parameters.TestMessagesAdd(message);
        if (message.Type == TestImportMessagesType.Error)
          return false;
      }
      return true;
    }

    /// <summary>Сохранение метаданных</summary>
    /// <param name="mdMerged">Метаданные</param>
    /// <param name="parameters">Параметры</param>
    protected abstract void SaveMetadata(T mdMerged, ReadMetadataParameters parameters);

    /// <summary>
    /// Установка модуля сценариев к <paramref name="metadataItem" />
    /// </summary>
    /// <param name="metadataItem">Элемент метаданных</param>
    /// <param name="propertyExpression">Выражение свойства модуля сценариев</param>
    /// <param name="parameters">Параметры импорта</param>
    /// <typeparam name="TMetadataItem">Тип элемента метаданных</typeparam>
    internal void SetScriptModule<TMetadataItem>(
      TMetadataItem metadataItem,
      Expression<Func<TMetadataItem, ScriptModule>> propertyExpression,
      ReadMetadataParameters parameters)
    {
      PropertyInfo scriptModulePropertyInfo = (PropertyInfo) ((MemberExpression) propertyExpression.Body).Member;
      this.SetScriptModule(scriptModulePropertyInfo.Name, (Func<IScriptModule>) (() => (IScriptModule) scriptModulePropertyInfo.GetValue((object) (TMetadataItem) metadataItem)), (Action<ScriptModule>) (scriptModule =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              scriptModulePropertyInfo.SetValue((object) (TMetadataItem) metadataItem, (object) scriptModule);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }), parameters);
    }

    /// <summary>
    /// Установка модуля сценариев к <paramref name="metadataItem" />
    /// </summary>
    /// <param name="metadataItem">Элемент метаданных</param>
    /// <param name="propertyExpression">Выражение свойства модуля сценариев</param>
    /// <param name="parameters">Параметры импорта</param>
    /// <typeparam name="TMetadataItem">Тип элемента метаданных</typeparam>
    internal void SetScriptModule<TMetadataItem>(
      TMetadataItem metadataItem,
      Expression<Func<TMetadataItem, ScriptModuleDTO>> propertyExpression,
      ReadMetadataParameters parameters)
    {
      PropertyInfo scriptModulePropertyInfo = (PropertyInfo) ((MemberExpression) propertyExpression.Body).Member;
      this.SetScriptModule(scriptModulePropertyInfo.Name, (Func<IScriptModule>) (() => (IScriptModule) scriptModulePropertyInfo.GetValue((object) (TMetadataItem) metadataItem)), (Action<ScriptModule>) (scriptModule =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              scriptModulePropertyInfo.SetValue((object) (TMetadataItem) metadataItem, scriptModule != null ? (object) Mapper.Map<ScriptModule, ScriptModuleDTO>(scriptModule, new ScriptModuleDTO()) : (object) (ScriptModuleDTO) null);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }), parameters);
    }

    private void SetScriptModule(
      string scriptModulePropertyName,
      Func<IScriptModule> getOriginalScriptModuleFunc,
      Action<ScriptModule> setScriptModuleAction,
      ReadMetadataParameters parameters)
    {
      ICollection<string> source;
      Guid result;
      if (!parameters.Attributes.TryGetValue(scriptModulePropertyName, out source) || !Guid.TryParse(source.First<string>(), out result))
        return;
      ScriptModule scriptModule1 = result != Guid.Empty ? this.ScriptModuleManager.LoadOrNull(result) : (ScriptModule) null;
      IScriptModule scriptModule2 = scriptModule1 != null ? getOriginalScriptModuleFunc() : (IScriptModule) null;
      if (scriptModule2 != null && scriptModule2.SourceCode != null && scriptModule2.Uid != result)
      {
        string str = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858663845), (object) scriptModule2.SourceCode.Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217524067), string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 44584821), (object) Environment.NewLine)));
        scriptModule1.SourceCode = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1012087039 ^ 1012389935), (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767483123)), (object) str, (object) scriptModule1.SourceCode);
      }
      setScriptModuleAction(scriptModule1);
    }

    /// <summary>Мерж метаданных</summary>
    /// <param name="mdImported">Метаданные</param>
    /// <param name="mdDraft">Черновик</param>
    /// <param name="isTestRead">Тестовое чтение</param>
    /// <param name="parameters">Параметры импорта</param>
    protected virtual void MergeMetadata(
      T mdImported,
      T mdDraft,
      bool isTestRead,
      ReadMetadataParameters parameters)
    {
      if (isTestRead)
        return;
      mdDraft.DisplayName = mdImported.DisplayName;
      mdDraft.Description = mdImported.Description;
      if (mdImported.Images != null && mdImported.Images.Count > 0)
        mdDraft.Images = mdImported.Images;
      this.MergeMetadataNamedImages((NamedMetadata) mdImported, (NamedMetadata) mdDraft);
    }

    /// <summary>Проверка новых метаданных</summary>
    /// <param name="mdImported">Метаданные</param>
    /// <param name="isTestRead">Тестовое чтение</param>
    /// <param name="parameters">Параметры импорта</param>
    protected virtual void CheckNewMetadata(
      T mdImported,
      bool isTestRead,
      ReadMetadataParameters parameters)
    {
    }

    /// <summary>Проверка метаданных</summary>
    /// <param name="mdImported">Метаданные</param>
    /// <param name="mdDraft">Черновик</param>
    /// <param name="parameters">Параметры импорта</param>
    protected virtual bool CheckMetadata(
      T mdImported,
      T mdDraft,
      ReadMetadataParameters parameters)
    {
      bool flag = true;
      if (mdDraft.Name != mdImported.Name)
      {
        parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146272749), (object) mdImported.DisplayName, (object) mdImported.Uid, (object) mdDraft.DisplayName, (object) mdImported.Name, (object) mdDraft.Name, (object) mdDraft.Uid)));
        flag = false;
      }
      return flag;
    }

    private void MergeMetadataNamedImages(NamedMetadata mdImported, NamedMetadata mdDraft)
    {
      int num1 = 1;
      List<NamedImageMetadata> namedImages1;
      List<NamedImageMetadata>.Enumerator enumerator;
      List<NamedImageMetadata> namedImages2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            namedImages1 = mdImported.NamedImages;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
            continue;
          case 2:
            if (namedImages1.Count != 0)
            {
              namedImages2 = mdDraft.NamedImages;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 6 : 5;
              continue;
            }
            num1 = 8;
            continue;
          case 3:
          case 10:
            mdDraft.NamedImages = namedImages1;
            num1 = 9;
            continue;
          case 4:
            goto label_30;
          case 5:
            goto label_3;
          case 6:
            if (namedImages2 == null)
            {
              num1 = 3;
              continue;
            }
            goto case 7;
          case 7:
            if (namedImages2.Count != 0)
            {
              enumerator = namedImages1.GetEnumerator();
              num1 = 5;
              continue;
            }
            num1 = 10;
            continue;
          case 8:
            goto label_25;
          case 9:
            goto label_27;
          default:
            if (namedImages1 != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 2 : 1;
              continue;
            }
            goto label_21;
        }
      }
label_30:
      return;
label_25:
      return;
label_27:
      return;
label_3:
      try
      {
label_15:
        if (enumerator.MoveNext())
          goto label_12;
        else
          goto label_16;
label_4:
        int num2;
        while (true)
        {
          int index;
          NamedImageMetadata namedImageMetadata;
          NamedImageMetadata importedImage;
          switch (num2)
          {
            case 1:
              namedImages2.Insert(index, importedImage);
              num2 = 10;
              continue;
            case 2:
            case 9:
              goto label_15;
            case 3:
              if (namedImageMetadata == null)
              {
                num2 = 6;
                continue;
              }
              break;
            case 4:
              namedImageMetadata = namedImages2.FirstOrDefault<NamedImageMetadata>((Func<NamedImageMetadata, bool>) (v => v.ImageKey == importedImage.ImageKey));
              num2 = 3;
              continue;
            case 5:
              goto label_17;
            case 6:
            case 8:
              namedImages2.Add(importedImage);
              num2 = 2;
              continue;
            case 7:
              goto label_12;
            case 10:
              namedImages2.Remove(namedImageMetadata);
              num2 = 9;
              continue;
            case 11:
              importedImage = enumerator.Current;
              num2 = 4;
              continue;
          }
          index = namedImages2.IndexOf(namedImageMetadata);
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 1;
        }
label_17:
        return;
label_12:
        num2 = 11;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
        {
          num2 = 7;
          goto label_4;
        }
        else
          goto label_4;
label_16:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 5 : 0;
        goto label_4;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
label_21:;
    }

    protected NamedMetadataImportExtension()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool xaulOwEleywUHx5FiB7X() => NamedMetadataImportExtension<T>.x7QID5El21aAyqENoiUC == null;

    internal static object rhD3NmElP0kmTFjB5jKi() => NamedMetadataImportExtension<T>.x7QID5El21aAyqENoiUC;

    private sealed class ReadMetadataResult : IReadMetadataResult
    {
      private readonly T mdMerged;
      private readonly ReadMetadataParameters parameters;
      private readonly bool isTestRead;
      private readonly NamedMetadataImportExtension<T> importExtension;
      private static object YMBAkY8AAE0y2FTylHHP;

      public ReadMetadataResult(
        T mdMerged,
        ReadMetadataParameters parameters,
        bool isTestRead,
        NamedMetadataImportExtension<T> importExtension)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.mdMerged = mdMerged;
        this.parameters = parameters;
        this.isTestRead = isTestRead;
        this.importExtension = importExtension;
      }

      IMetadata IReadMetadataResult.Metadata => (IMetadata) this.mdMerged;

      public bool TestMetadata() => this.importExtension.TestMetadata(this.mdMerged, this.parameters, this.isTestRead);

      public void SaveMetadata()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.importExtension.SaveMetadata(this.mdMerged, this.parameters);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      internal static bool Sf275G8A7s7GCD1eR1yQ() => NamedMetadataImportExtension<T>.ReadMetadataResult.YMBAkY8AAE0y2FTylHHP == null;

      internal static object LIWkuR8Axn1Cw2cumikE() => NamedMetadataImportExtension<T>.ReadMetadataResult.YMBAkY8AAE0y2FTylHHP;
    }
  }
}
