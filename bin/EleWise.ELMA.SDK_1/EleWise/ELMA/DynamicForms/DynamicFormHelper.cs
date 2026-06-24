// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.DynamicForms.DynamicFormHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using Iesi.Collections;
using Iesi.Collections.Generic;
using Newtonsoft.Json;
using NHibernate.Collection;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web.Mvc;

namespace EleWise.ELMA.DynamicForms
{
  /// <summary>Помощник для обработки динамических форм</summary>
  public static class DynamicFormHelper
  {
    internal const string ParentFormPrefix = "ParentB5857BD3_6DBE_48F0_9489_FD6C08F1528E";
    internal const string Separator = "-BEFE1D44-62F6-457E-B628-F6CDC62FC2C9-";
    internal const string FormActionsProviderId = "EleWise.ELMA.Web.Components.FormActionProvider";
    private static IMetadataRuntimeService metadataRuntimeService;
    internal static DynamicFormHelper QDnTn9OTtnmGr7FGCxv;

    private static IMetadataRuntimeService MetadataRuntimeService
    {
      get
      {
        int num = 1;
        IMetadataRuntimeService metadataRuntimeService;
        while (true)
        {
          switch (num)
          {
            case 1:
              metadataRuntimeService = DynamicFormHelper.metadataRuntimeService;
              if (metadataRuntimeService == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return metadataRuntimeService;
label_5:
        return DynamicFormHelper.metadataRuntimeService = Locator.GetServiceNotNull<IMetadataRuntimeService>();
      }
    }

    public static bool ClosePopup
    {
      get
      {
        int num = 1;
        bool closePopup;
        while (true)
        {
          switch (num)
          {
            case 1:
              ContextVars.TryGetValue<bool>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1405822995), out closePopup);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return closePopup;
      }
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
              ContextVars.Set<bool>((string) DynamicFormHelper.R4jn40OOW7stH3wiytf(1149433385 + 173655049 ^ 1323095146), value);
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

    /// <summary>Получить сообщение для вывода</summary>
    /// <returns>Список сообщений</returns>
    [Obsolete("Метод устарел, используйте GetContextNotifyMvcMessages")]
    public static List<KeyValuePair<string, string>> GetContextNotifyMessages()
    {
      FormNotifier formNotifier;
      ContextVars.TryGetValue<FormNotifier>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909155773), out formNotifier);
      return formNotifier?.Messages;
    }

    /// <summary>Получить сообщение для вывода</summary>
    /// <returns>Список сообщений</returns>
    public static List<KeyValuePair<string, MvcHtmlString>> GetContextNotifyMvcMessages()
    {
      FormNotifier formNotifier;
      ContextVars.TryGetValue<FormNotifier>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712505707), out formNotifier);
      return formNotifier?.MvcMessages;
    }

    public static IFormNotifier GetContextFormNotifier()
    {
      int num1 = 4;
      FormNotifier contextFormNotifier;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              ContextVars.Set<FormNotifier>((string) DynamicFormHelper.R4jn40OOW7stH3wiytf(44884861 ^ 44862881), contextFormNotifier);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
              continue;
            case 2:
              contextFormNotifier = new FormNotifier();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 0;
              continue;
            case 3:
              if (contextFormNotifier == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 2 : 2;
                continue;
              }
              goto label_6;
            case 4:
              goto label_8;
            default:
              goto label_6;
          }
        }
label_8:
        ContextVars.TryGetValue<FormNotifier>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583750104), out contextFormNotifier);
        num1 = 3;
      }
label_6:
      return (IFormNotifier) contextFormNotifier;
    }

    /// <summary>
    /// Получить информацию о построителе представления для модели
    /// </summary>
    /// <param name="propertyContainer">Контейнер информации о свойствах</param>
    /// <returns>Информация о построителе представления для модели</returns>
    public static FormViewBuilderInfo GetFormViewBuilderInfo(
      PropertyViewInfoContainer propertyContainer)
    {
      int num1 = 5;
      FormViewBuilderInfo formViewBuilderInfo;
      IEnumerator<PropertyViewInfo> enumerator1;
      List<KeyValuePair<string, MvcHtmlString>> notifyMvcMessages;
      List<KeyValuePair<string, MvcHtmlString>>.Enumerator enumerator2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            try
            {
label_22:
              if (DynamicFormHelper.OZjnAqO2BlE7BGG7gQU((object) enumerator1))
                goto label_13;
              else
                goto label_23;
label_5:
              PropertyViewInfo current;
              int num2;
              while (true)
              {
                int num3;
                bool? nullable;
                switch (num2)
                {
                  case 1:
                    nullable = current.Required;
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 11 : 13;
                    continue;
                  case 2:
                    if (nullable.HasValue)
                    {
                      num2 = 11;
                      continue;
                    }
                    goto case 12;
                  case 3:
                    if (!nullable.HasValue)
                    {
                      num3 = 4;
                      break;
                    }
                    goto case 6;
                  case 4:
                    if (current.Settings == null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 8 : 8;
                      continue;
                    }
                    goto case 6;
                  case 5:
                    nullable = current.IsValid;
                    num2 = 3;
                    continue;
                  case 6:
                  case 10:
                  case 11:
                    formViewBuilderInfo.Properties.Add(current);
                    num3 = 7;
                    break;
                  case 7:
                  case 8:
                    goto label_22;
                  case 9:
                    nullable = current.Visible;
                    num2 = 2;
                    continue;
                  case 12:
                    nullable = current.ReadOnly;
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
                    continue;
                  case 13:
                    if (!nullable.HasValue)
                    {
                      num2 = 9;
                      continue;
                    }
                    goto case 6;
                  case 14:
                    goto label_32;
                  case 15:
                    goto label_13;
                  default:
                    if (nullable.HasValue)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 4 : 6;
                      continue;
                    }
                    goto case 5;
                }
                num2 = num3;
              }
label_13:
              current = enumerator1.Current;
              num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
              {
                num2 = 1;
                goto label_5;
              }
              else
                goto label_5;
label_23:
              num2 = 14;
              goto label_5;
            }
            finally
            {
              if (enumerator1 != null)
              {
                int num4 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
                  num4 = 0;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      enumerator1.Dispose();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_30;
                  }
                }
              }
label_30:;
            }
          case 2:
          case 7:
label_2:
            DynamicFormHelper.LgZAI0Oe16njA87xmwd((object) formViewBuilderInfo, DynamicFormHelper.ClosePopup);
            num1 = 3;
            continue;
          case 3:
            goto label_37;
          case 4:
            if (propertyContainer == null)
            {
              num1 = 8;
              continue;
            }
            goto case 10;
          case 5:
            formViewBuilderInfo = new FormViewBuilderInfo();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 4 : 0;
            continue;
          case 6:
            if (notifyMvcMessages == null)
            {
              num1 = 7;
              continue;
            }
            goto case 11;
          case 8:
          case 9:
label_32:
            notifyMvcMessages = DynamicFormHelper.GetContextNotifyMvcMessages();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 6 : 6;
            continue;
          case 10:
            enumerator1 = propertyContainer.GetAll().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 1 : 1;
            continue;
          case 11:
            enumerator2 = notifyMvcMessages.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
            continue;
          default:
            try
            {
label_43:
              if (enumerator2.MoveNext())
                goto label_46;
              else
                goto label_44;
label_40:
              KeyValuePair<string, MvcHtmlString> current;
              NotificationType result;
              int num5;
              while (true)
              {
                switch (num5)
                {
                  case 1:
                    goto label_46;
                  case 2:
                    goto label_2;
                  case 3:
                    if (Enum.TryParse<NotificationType>(current.Key, out result))
                    {
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
                      continue;
                    }
                    goto label_43;
                  case 4:
                    goto label_43;
                  default:
                    formViewBuilderInfo.Notifications.Add(new NotificationInfo(current.Value.ToString(), result));
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 2 : 4;
                    continue;
                }
              }
label_44:
              num5 = 2;
              goto label_40;
label_46:
              current = enumerator2.Current;
              num5 = 3;
              goto label_40;
            }
            finally
            {
              enumerator2.Dispose();
              int num6 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
                num6 = 0;
              switch (num6)
              {
                default:
              }
            }
        }
      }
label_37:
      return formViewBuilderInfo;
    }

    /// <summary>Выполнить сценарий для динамической формы</summary>
    /// <param name="entity"></param>
    /// <param name="settings"></param>
    /// <param name="view"></param>
    /// <param name="scriptName"></param>
    /// <returns></returns>
    public static DynamicFormResult ExecuteScript(
      [NotNull] IEntity entity,
      [NotNull] DynamicFormSettings settings,
      RootViewItem view,
      string scriptName)
    {
      return DynamicFormHelper.ExecuteScript(entity, settings, view, scriptName, (object) null);
    }

    /// <summary>Выполнить сценарий для динамической формы</summary>
    /// <param name="entity"></param>
    /// <param name="settings"></param>
    /// <param name="view"></param>
    /// <param name="scriptName"></param>
    /// <param name="originalStateObj"></param>
    /// <returns></returns>
    public static DynamicFormResult ExecuteScript(
      [NotNull] IEntity entity,
      [NotNull] DynamicFormSettings settings,
      RootViewItem view,
      string scriptName,
      object originalStateObj)
    {
      int num1 = 4;
      DynamicFormSettings settings1;
      IDynamicFormsProvider provider;
      IEntity entity1;
      string sn;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            provider = ((ComponentManager) DynamicFormHelper.AVePmvOPq14pBfYiTJ5()).GetExtensionPoints<IDynamicFormsProvider>().FirstOrDefault<IDynamicFormsProvider>((Func<IDynamicFormsProvider, bool>) (p => DynamicFormHelper.\u003C\u003Ec__DisplayClass16_0.rP3WajfmOXj5gkAKRt4l(DynamicFormHelper.\u003C\u003Ec__DisplayClass16_0.VaKhWIfmkWc1Eljpw2E8((object) p), DynamicFormHelper.\u003C\u003Ec__DisplayClass16_0.WWbkyTfmnmZjwdDHKlOE((object) settings1))));
            num1 = 6;
            continue;
          case 2:
            goto label_2;
          case 3:
            settings1 = settings;
            num1 = 5;
            continue;
          case 4:
            num1 = 3;
            continue;
          case 5:
            entity1 = entity;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 1 : 1;
            continue;
          case 6:
            if (provider != null)
            {
              sn = scriptName;
              num1 = 2;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_2:
      return DynamicFormHelper.ExecuteScript(entity1, settings1, view, originalStateObj, (Action<RootViewItem, DynamicFormResultData>) ((v, data) =>
      {
        int num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_2;
            case 1:
              // ISSUE: reference to a compiler-generated method
              DynamicFormHelper.\u003C\u003Ec__DisplayClass16_0.W4UkJcfm287pdpeZ1tgG((object) provider, (object) entity1, (object) v, (object) settings1, (object) sn, (object) data);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
label_3:
      return (DynamicFormResult) null;
    }

    /// <summary>Выполнить сценарий для динамической формы</summary>
    /// <param name="entity"></param>
    /// <param name="settings"></param>
    /// <param name="view"></param>
    /// <param name="originalStateObj"></param>
    /// <returns></returns>
    public static DynamicFormResult ExecuteScript(
      [NotNull] IEntity entity,
      [NotNull] DynamicFormSettings settings,
      RootViewItem view,
      object originalStateObj,
      Action<RootViewItem, DynamicFormResultData> executeScriptAction)
    {
      return DynamicFormHelper.ExecuteScript(entity, settings, view, originalStateObj, executeScriptAction, (IDictionary<string, object>) null);
    }

    /// <summary>Выполнить сценарий для динамической формы</summary>
    /// <param name="entity"></param>
    /// <param name="settings"></param>
    /// <param name="view"></param>
    /// <param name="scriptName"></param>
    /// <param name="originalStateObj"></param>
    /// <returns></returns>
    public static DynamicFormResult ExecuteScript(
      [NotNull] IEntity entity,
      [NotNull] DynamicFormSettings settings,
      RootViewItem view,
      string scriptName,
      object originalStateObj,
      IDictionary<string, object> realrootEntityState)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      IDynamicFormsProvider provider = ComponentManager.Current.GetExtensionPoints<IDynamicFormsProvider>().FirstOrDefault<IDynamicFormsProvider>((Func<IDynamicFormsProvider, bool>) (p => DynamicFormHelper.\u003C\u003Ec__DisplayClass18_0.IVt1WafmprYDuFjWSj70(DynamicFormHelper.\u003C\u003Ec__DisplayClass18_0.CUMYaVfm3HFw4tUSYWFQ((object) p), settings.DynamicFormsProviderUid)));
      if (provider == null)
        return (DynamicFormResult) null;
      string sn = scriptName;
      return DynamicFormHelper.ExecuteScript(entity, settings, view, originalStateObj, (Action<RootViewItem, DynamicFormResultData>) ((v, data) =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              provider.ExecuteScript(entity, v, settings, sn, data);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }), realrootEntityState);
    }

    public static DynamicFormResult ExecuteScript(
      [NotNull] IEntity entity,
      [NotNull] DynamicFormSettings settings,
      RootViewItem view,
      object originalStateObj,
      Action<RootViewItem, DynamicFormResultData> executeScriptAction,
      IDictionary<string, object> realrootEntityState = null)
    {
      RootViewItem originalItem1 = view;
      RootViewItem originalItem2 = view;
      if (view != null)
      {
        view = view.Transformate(settings.ViewTransformation) as RootViewItem;
        if (settings.ViewTransformationAdditional != null)
          settings.ViewTransformationAdditional.Apply((ViewItem) view);
        originalItem2 = ClassSerializationHelper.CloneObjectByXml<RootViewItem>(view);
      }
      IDictionary<string, object> state = realrootEntityState == null ? EntityCompareHelper.GetState(entity) : realrootEntityState;
      EntityMetadata metadata = (EntityMetadata) MetadataLoader.LoadMetadata(entity.CastAsRealType<IEntity>().GetType());
      TypeSettingsInstanceData settingsInstanceData = DynamicFormHelper.GetTypeSettingsInstanceData((object) entity, (object) metadata);
      DynamicFormResult dynamicFormResult = new DynamicFormResult();
      executeScriptAction(view, dynamicFormResult.ResultData);
      IEntity rootEntity = entity.GetRootEntity();
      DynamicFormHelper.ProcessNewTablePartItems(rootEntity, (IEntityMetadata) null);
      if (rootEntity != entity)
        DynamicFormHelper.ProcessNewTablePartItems(entity, (IEntityMetadata) metadata);
      dynamicFormResult.ChangedPropertyNames = ((IEnumerable<string>) EntityCompareHelper.Compare(entity, state)).ToList<string>();
      if (view != null)
      {
        FormViewItemTransformation transformation = view.CreateTransformation(originalItem2);
        if (transformation != null)
        {
          IEnumerable<IPropertyMetadata> propertiesAndTableParts = metadata.GetPropertiesAndTableParts();
          PropertyViewItem[] transformatedItems = transformation.Items.Select<ViewItemTransformation, PropertyViewItem>((Func<ViewItemTransformation, PropertyViewItem>) (t => view.FindItem<PropertyViewItem>(t.Uid))).Where<PropertyViewItem>((Func<PropertyViewItem, bool>) (i => i != null)).ToArray<PropertyViewItem>();
          Func<IPropertyMetadata, bool> predicate = (Func<IPropertyMetadata, bool>) (p =>
          {
            int num = 1;
            IPropertyMetadata p1;
            while (true)
            {
              switch (num)
              {
                case 1:
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
                  continue;
                case 2:
                  goto label_2;
                default:
                  p1 = p;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 2 : 0;
                  continue;
              }
            }
label_2:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            return ((IEnumerable<PropertyViewItem>) transformatedItems).Any<PropertyViewItem>((Func<PropertyViewItem, bool>) (i => DynamicFormHelper.\u003C\u003Ec__DisplayClass19_2.hGPXW1fmMwvrrvOvtViL(DynamicFormHelper.\u003C\u003Ec__DisplayClass19_2.vLRmIffmmu1S5QqMnDYK((object) i), DynamicFormHelper.\u003C\u003Ec__DisplayClass19_2.dDBny4fmy85omlQKpaQw((object) p1))));
          });
          foreach (IPropertyMetadata propertyMetadata in propertiesAndTableParts.Where<IPropertyMetadata>(predicate))
          {
            if (!dynamicFormResult.ChangedPropertyNames.Contains(propertyMetadata.Name))
              dynamicFormResult.ChangedPropertyNames.Add(propertyMetadata.Name);
          }
        }
        PropertyViewItem[] array1 = originalItem2.GetAllProperties().ToArray<PropertyViewItem>();
        PropertyViewItem[] array2 = view.GetAllProperties().ToArray<PropertyViewItem>();
        dynamicFormResult.ChangedValidationPropertyUids = new List<Guid>();
        foreach (PropertyViewItem propertyViewItem1 in array2)
        {
          PropertyViewItem propertyAfter = propertyViewItem1;
          // ISSUE: reference to a compiler-generated method
          PropertyViewItem propertyViewItem2 = ((IEnumerable<PropertyViewItem>) array1).FirstOrDefault<PropertyViewItem>((Func<PropertyViewItem, bool>) (p => DynamicFormHelper.\u003C\u003Ec__DisplayClass19_3.Rq8uiIfmlGHFb1RAKYIF(p.Uid, propertyAfter.Uid)));
          if (propertyViewItem2 != null)
          {
            bool flag1 = !string.IsNullOrEmpty(propertyViewItem2.Attributes.ValidationError);
            bool flag2 = !string.IsNullOrEmpty(propertyAfter.Attributes.ValidationError);
            int num1 = flag1 & flag2 ? (propertyViewItem2.Attributes.ValidationError != propertyAfter.Attributes.ValidationError ? 1 : 0) : (flag1 | flag2 ? 1 : 0);
            bool flag3 = propertyViewItem2.Attributes.Required != propertyAfter.Attributes.Required;
            bool? nullable1 = propertyViewItem2.Attributes.ReadOnly;
            bool? nullable2 = propertyAfter.Attributes.ReadOnly;
            bool flag4 = !(nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() & nullable1.HasValue == nullable2.HasValue);
            bool flag5 = propertyAfter.Attributes.Visible && propertyViewItem2.Attributes.Visible != propertyAfter.Attributes.Visible;
            int num2 = flag3 ? 1 : 0;
            if ((num1 | num2 | (flag4 ? 1 : 0) | (flag5 ? 1 : 0)) != 0)
              dynamicFormResult.ChangedValidationPropertyUids.Add(propertyAfter.PropertyUid);
          }
        }
      }
      foreach (TypeSettingsInstanceData.DataItem dataItem in DynamicFormHelper.GetTypeSettingsInstanceData((object) entity, (object) metadata).Items)
      {
        TypeSettings right = settingsInstanceData[dataItem.PropertyUid];
        if (right == null || !DynamicFormHelper.IsEquals((object) dataItem.Settings, (object) right))
        {
          IPropertyMetadata property = DynamicFormHelper.FindProperty((object) metadata, dataItem.PropertyUid);
          if (property != null && !dynamicFormResult.ChangedPropertyNames.Contains(property.Name))
            dynamicFormResult.ChangedPropertyNames.Add(property.Name);
        }
      }
      dynamicFormResult.ModelJsonState = DynamicFormHelper.ModelJsonState(entity, originalStateObj, false);
      dynamicFormResult.ChangedView = view;
      if (dynamicFormResult.ChangedView != null)
        dynamicFormResult.ViewTransformation = (ViewItemTransformation) dynamicFormResult.ChangedView.CreateTransformation(originalItem1);
      return dynamicFormResult;
    }

    private static bool IsEquals(object left, object right)
    {
      int num1 = 1;
      MemoryStream memoryStream1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            memoryStream1 = ClassSerializationHelper.SerializeObjectByXmlToMemoryStream(left);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_23;
          default:
            goto label_3;
        }
      }
label_3:
      bool flag;
      try
      {
        MemoryStream memoryStream2 = ClassSerializationHelper.SerializeObjectByXmlToMemoryStream(right);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              flag = DynamicFormHelper.bBtyrvO197gaqZcHcK6((object) memoryStream1, (object) memoryStream2);
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
                num3 = 0;
              switch (num3)
              {
              }
            }
            finally
            {
              if (memoryStream2 != null)
              {
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
                  num4 = 0;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_16;
                    default:
                      DynamicFormHelper.NlXpfgONDUYLivmVaw5((object) memoryStream2);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 1 : 1;
                      continue;
                  }
                }
              }
label_16:;
            }
            break;
        }
      }
      finally
      {
        if (memoryStream1 != null)
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
            num5 = 0;
          while (true)
          {
            switch (num5)
            {
              case 1:
                goto label_22;
              default:
                memoryStream1.Dispose();
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_22:;
      }
label_23:
      return flag;
    }

    private static bool? NeedPostfixCheck(
      object viewItem,
      IEnumerable<PropertyViewItem> props,
      Func<PropertyViewItem, bool> checkType,
      Func<PropertyViewItem, bool> checkNonType)
    {
      PropertyViewItem viewItem1 = (PropertyViewItem) viewItem;
      if (!checkType(viewItem1))
        return new bool?();
      PropertyViewItem propertyViewItem = props.FirstOrDefault<PropertyViewItem>((Func<PropertyViewItem, bool>) (p => !checkNonType(viewItem1)));
      return new bool?(propertyViewItem != viewItem1 && (checkType(propertyViewItem) || !checkNonType(props.FirstOrDefault<PropertyViewItem>())));
    }

    public static bool NeedPostfix(this PropertyViewItem viewItem)
    {
      int num1 = 8;
      bool? nullable1;
      bool? nullable2;
      bool flag;
      PropertyViewItem[] source;
      bool? nullable3;
      Func<PropertyViewItem, bool> func1;
      PropertyViewItem viewItem1;
      while (true)
      {
        int num2 = num1;
        FormViewItem formViewItem;
        while (true)
        {
          switch (num2)
          {
            case 1:
              formViewItem = (FormViewItem) DynamicFormHelper.p179oUO37BQuIITNNpM((object) viewItem1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 12 : 15;
              continue;
            case 2:
              PropertyViewItem viewItem2 = viewItem1;
              PropertyViewItem[] props1 = source;
              // ISSUE: reference to a compiler-generated field
              Func<PropertyViewItem, bool> func2 = DynamicFormHelper.\u003C\u003Ec.\u003C\u003E9__22_4;
              Func<PropertyViewItem, bool> checkNonType1;
              if (func2 == null)
              {
                // ISSUE: reference to a compiler-generated field
                DynamicFormHelper.\u003C\u003Ec.\u003C\u003E9__22_4 = checkNonType1 = (Func<PropertyViewItem, bool>) (i =>
                {
                  int num3 = 2;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 1:
                        goto label_5;
                      case 2:
                        if (i is PropertyCaptionViewItem)
                        {
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 1;
                          continue;
                        }
                        goto label_4;
                      default:
                        goto label_4;
                    }
                  }
label_4:
                  return i is PropertyDescriptionViewItem;
label_5:
                  return true;
                });
              }
              else
                goto label_38;
label_28:
              nullable3 = DynamicFormHelper.NeedPostfixCheck((object) viewItem2, (IEnumerable<PropertyViewItem>) props1, (Func<PropertyViewItem, bool>) (i => i is PropertyValueViewItem), checkNonType1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
              continue;
label_38:
              checkNonType1 = func2;
              goto label_28;
            case 3:
              goto label_29;
            case 4:
              PropertyViewItem viewItem3 = viewItem1;
              PropertyViewItem[] props2 = source;
              // ISSUE: reference to a compiler-generated field
              Func<PropertyViewItem, bool> func3 = DynamicFormHelper.\u003C\u003Ec.\u003C\u003E9__22_2;
              Func<PropertyViewItem, bool> checkNonType2;
              if (func3 == null)
              {
                // ISSUE: reference to a compiler-generated field
                DynamicFormHelper.\u003C\u003Ec.\u003C\u003E9__22_2 = checkNonType2 = (Func<PropertyViewItem, bool>) (i =>
                {
                  int num4 = 2;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        goto label_3;
                      case 2:
                        if (i is PropertyValueViewItem)
                        {
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 0;
                          continue;
                        }
                        goto label_2;
                      default:
                        goto label_2;
                    }
                  }
label_2:
                  return i is PropertyDescriptionViewItem;
label_3:
                  return true;
                });
              }
              else
                goto label_41;
label_25:
              nullable1 = DynamicFormHelper.NeedPostfixCheck((object) viewItem3, (IEnumerable<PropertyViewItem>) props2, (Func<PropertyViewItem, bool>) (i => i is PropertyCaptionViewItem), checkNonType2);
              num2 = 10;
              continue;
label_41:
              checkNonType2 = func3;
              goto label_25;
            case 5:
              goto label_13;
            case 6:
              goto label_35;
            case 7:
              viewItem1 = viewItem;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 1 : 1;
              continue;
            case 8:
              num2 = 7;
              continue;
            case 9:
              source = (PropertyViewItem[]) DynamicFormHelper.eRKG2wOaBImpglaklIG((object) viewItem1, (object) formViewItem);
              num2 = 14;
              continue;
            case 10:
              if (nullable1.HasValue)
              {
                num2 = 6;
                continue;
              }
              goto case 2;
            case 11:
              if (!nullable2.HasValue)
              {
                num2 = 5;
                continue;
              }
              goto label_5;
            case 12:
              goto label_6;
            case 13:
              goto label_19;
            case 14:
              func1 = (Func<PropertyViewItem, bool>) (prop =>
              {
                int num5 = 1;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      if (prop == null)
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_4;
                    case 2:
                      goto label_4;
                    default:
                      goto label_5;
                  }
                }
label_4:
                return prop != viewItem1;
label_5:
                return false;
              });
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 1 : 4;
              continue;
            case 15:
              if (formViewItem == null)
              {
                num2 = 13;
                continue;
              }
              if (!((PropertiesContainer) DynamicFormHelper.hfUHPfOpoNa4759K0Px((object) viewItem1)).TryGetValue<bool>((string) DynamicFormHelper.R4jn40OOW7stH3wiytf(-1921202237 ^ -1921210201), out flag))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 9 : 9;
                continue;
              }
              goto label_6;
            default:
              if (!nullable3.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 3 : 1;
                continue;
              }
              goto label_8;
          }
        }
label_29:
        PropertyViewItem viewItem4 = viewItem1;
        PropertyViewItem[] props3 = source;
        // ISSUE: reference to a compiler-generated field
        Func<PropertyViewItem, bool> func4 = DynamicFormHelper.\u003C\u003Ec.\u003C\u003E9__22_5;
        Func<PropertyViewItem, bool> checkType;
        if (func4 == null)
        {
          // ISSUE: reference to a compiler-generated field
          DynamicFormHelper.\u003C\u003Ec.\u003C\u003E9__22_5 = checkType = (Func<PropertyViewItem, bool>) (i => i is PropertyDescriptionViewItem);
        }
        else
          goto label_40;
label_31:
        // ISSUE: reference to a compiler-generated field
        Func<PropertyViewItem, bool> func5 = DynamicFormHelper.\u003C\u003Ec.\u003C\u003E9__22_6;
        Func<PropertyViewItem, bool> checkNonType3;
        if (func5 == null)
        {
          // ISSUE: reference to a compiler-generated field
          DynamicFormHelper.\u003C\u003Ec.\u003C\u003E9__22_6 = checkNonType3 = (Func<PropertyViewItem, bool>) (i =>
          {
            int num6 = 1;
            while (true)
            {
              switch (num6)
              {
                case 1:
                  if (!(i is PropertyCaptionViewItem))
                  {
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
                    continue;
                  }
                  goto label_5;
                default:
                  goto label_4;
              }
            }
label_4:
            return i is PropertyValueViewItem;
label_5:
            return true;
          });
        }
        else
          goto label_39;
label_34:
        nullable2 = DynamicFormHelper.NeedPostfixCheck((object) viewItem4, (IEnumerable<PropertyViewItem>) props3, checkType, checkNonType3);
        num1 = 11;
        continue;
label_39:
        checkNonType3 = func5;
        goto label_34;
label_40:
        checkType = func4;
        goto label_31;
      }
label_5:
      int num7 = nullable2.GetValueOrDefault() ? 1 : 0;
      goto label_36;
label_6:
      return flag;
label_8:
      num7 = nullable3.GetValueOrDefault() ? 1 : 0;
      goto label_36;
label_13:
      num7 = func1(((IEnumerable<PropertyViewItem>) source).FirstOrDefault<PropertyViewItem>()) ? 1 : 0;
      goto label_36;
label_19:
      return false;
label_35:
      num7 = nullable1.GetValueOrDefault() ? 1 : 0;
label_36:
      if (num7 == 0)
        return num7 != 0;
      DynamicFormHelper.yN5WkIODOevLiQXWNLy((object) viewItem1.TypeSettings, DynamicFormHelper.R4jn40OOW7stH3wiytf(-1867198571 ^ -1867210511), (object) true);
      return num7 != 0;
    }

    public static string ModelJsonState(IEntity entity) => DynamicFormHelper.ModelJsonState(entity, (object) null);

    public static string ModelJsonState(
      IEntity entity,
      object originalStateObj,
      bool needProcessNewTablePartItems = true)
    {
      int num = 4;
      EntityMetadata entityMetadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            DynamicFormHelper.pG8wEXOtE71WlY0nJEj((object) entity, (object) entityMetadata);
            num = 2;
            continue;
          case 2:
            goto label_2;
          case 3:
            entityMetadata = MetadataLoader.LoadMetadata(entity.CastAsRealType<IEntity>().GetType()) as EntityMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
            continue;
          case 4:
            if (needProcessNewTablePartItems)
            {
              num = 3;
              continue;
            }
            goto label_2;
          default:
            if (entityMetadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 1 : 0;
              continue;
            }
            goto label_2;
        }
      }
label_2:
      EntityJsonSerializer entityJsonSerializer = new EntityJsonSerializer();
      IEntity entity1 = entity;
      EntitySerializationSettings settings = new EntitySerializationSettings();
      DynamicFormHelper.FosQu4Owe8KXOrtcw1e((object) settings, EntitySerializationMode.ChangesOnly);
      settings.OriginalState = originalStateObj;
      return (string) DynamicFormHelper.FfFQYNO4ECxXpNDUpwH(entityJsonSerializer.ConvertToSerializable((object) entity1, settings));
    }

    public static FormViewItem FormWithExecutedLoadScripts(
      FormViewItem formViewItem,
      IEntity entity,
      ClassMetadata metadata,
      DynamicFormSettings dynamicFormSettings)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        DynamicFormResult dynamicFormResult;
        while (true)
        {
          string scriptName;
          object obj;
          switch (num2)
          {
            case 1:
              obj = DynamicFormHelper.n0q4hEOAIUfJW5lZ5gm((object) metadata);
              break;
            case 2:
              if (DynamicFormHelper.MAijTKOHp6qpEQWRFQJ(DynamicFormHelper.Ter285O62QVYPoTml8P((object) formViewItem)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 9 : 4;
                continue;
              }
              obj = DynamicFormHelper.Ter285O62QVYPoTml8P((object) formViewItem);
              break;
            case 3:
              if (formViewItem != null)
              {
                num2 = 2;
                continue;
              }
              goto label_14;
            case 4:
              if (!string.IsNullOrEmpty(scriptName))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
                continue;
              }
              goto case 11;
            case 5:
            case 12:
              goto label_17;
            case 6:
              goto label_9;
            case 7:
              obj = (object) string.Empty;
              break;
            case 8:
              DynamicFormHelper.Don6brOxFB1TJbxLkPo((object) dynamicFormSettings, DynamicFormHelper.aDp8X5O71as9MtHdoJW((object) dynamicFormResult));
              num2 = 13;
              continue;
            case 9:
              if (metadata != null)
                goto case 1;
              else
                goto label_13;
            case 10:
              goto label_14;
            case 11:
              dynamicFormSettings.ModelJsonState = (string) DynamicFormHelper.FfogdSOyFLMv4KsS6ja((object) entity);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 5 : 12;
              continue;
            case 13:
              dynamicFormSettings.ViewTransformation = (ViewItemTransformation) DynamicFormHelper.qZw9RDO0OvQSgK9yKUO((object) dynamicFormResult);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 14 : 12;
              continue;
            case 14:
              if (DynamicFormHelper.w6fQWAOmwDDGQcprBnR((object) dynamicFormResult) != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 6 : 0;
                continue;
              }
              goto label_17;
            default:
              dynamicFormResult = DynamicFormHelper.ExecuteScript(entity, dynamicFormSettings, (RootViewItem) formViewItem, scriptName);
              num2 = 8;
              continue;
          }
          scriptName = (string) obj;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 4 : 4;
        }
label_9:
        formViewItem = (FormViewItem) DynamicFormHelper.w6fQWAOmwDDGQcprBnR((object) dynamicFormResult);
        num1 = 5;
        continue;
label_13:
        num1 = 7;
      }
label_14:
      return (FormViewItem) null;
label_17:
      return formViewItem;
    }

    public static void ProcessNewTablePartItems(IEntity entity, IEntityMetadata metadata)
    {
      int num1 = 3;
      IEnumerator<ITablePartMetadata> enumerator1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_59;
          case 2:
            if (metadata == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
              continue;
            }
            goto case 6;
          case 3:
            if (entity != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 2 : 0;
              continue;
            }
            goto label_55;
          case 4:
            goto label_58;
          case 5:
            enumerator1 = metadata.GetPropertiesAndTableParts().OfType<ITablePartMetadata>().GetEnumerator();
            num1 = 7;
            continue;
          case 6:
            if (metadata != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 5 : 2;
              continue;
            }
            goto label_50;
          case 7:
            goto label_3;
          default:
            metadata = MetadataLoader.LoadMetadata(entity.CastAsRealType<IEntity>().GetType()) as IEntityMetadata;
            num1 = 6;
            continue;
        }
      }
label_59:
      return;
label_58:
      return;
label_3:
      try
      {
label_36:
        if (enumerator1.MoveNext())
          goto label_38;
        else
          goto label_37;
label_4:
        ITablePartMetadata current1;
        IEnumerator<IEntity> enumerator2;
        HashedSet<Guid> hashedSet;
        ISet source;
        IPersistentCollection persistentCollection;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (source != null)
              {
                num2 = 4;
                continue;
              }
              goto label_36;
            case 3:
              goto label_39;
            case 4:
              persistentCollection = source as IPersistentCollection;
              num2 = 7;
              continue;
            case 5:
              source = DynamicFormHelper.kWs6KvOJ7lZJPNolBuc((object) entity, DynamicFormHelper.Xy4blNOMasG8jl54bYd((object) current1)) as ISet;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 1 : 1;
              continue;
            case 6:
              enumerator2 = source.OfType<IEntity>().GetEnumerator();
              num2 = 8;
              continue;
            case 7:
              if (persistentCollection == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
                continue;
              }
              goto case 11;
            case 8:
              goto label_5;
            case 9:
              goto label_38;
            case 10:
              goto label_36;
            case 11:
              if (DynamicFormHelper.KQMXGaO9Ryrkw66EFUL((object) persistentCollection))
              {
                num2 = 2;
                continue;
              }
              goto label_36;
            default:
              hashedSet = new HashedSet<Guid>();
              num2 = 6;
              continue;
          }
        }
label_39:
        return;
label_5:
        try
        {
label_21:
          if (DynamicFormHelper.OZjnAqO2BlE7BGG7gQU((object) enumerator2))
            goto label_26;
          else
            goto label_22;
label_6:
          object id;
          IEntity current2;
          ITablePartManager tablePartManager;
          Guid? nullable;
          int num3;
          while (true)
          {
            switch (num3)
            {
              case 1:
                nullable = DynamicFormHelper.DW3jh7OlMg5H6CTTcdG((object) current2, DynamicFormHelper.R4jn40OOW7stH3wiytf(1199946765 ^ 1199952799), (object) null) as Guid?;
                num3 = 12;
                continue;
              case 2:
                if (DynamicFormHelper.xXO9fDOrN7VcuN1DiUi(nullable.Value, Guid.Empty))
                {
                  num3 = 4;
                  continue;
                }
                goto case 13;
              case 3:
              case 10:
              case 19:
                DynamicFormHelper.pG8wEXOtE71WlY0nJEj((object) current2, (object) (IEntityMetadata) current1);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
                continue;
              case 4:
                current2.SetPropertyValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088314294), (object) Guid.NewGuid());
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 7 : 0;
                continue;
              case 5:
                goto label_36;
              case 6:
                goto label_28;
              case 7:
              case 18:
              case 20:
                id = current2.GetId();
                num3 = 16;
                continue;
              case 8:
                if (tablePartManager == null)
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 1 : 3;
                  continue;
                }
                goto case 9;
              case 9:
                DynamicFormHelper.V43RUHOseSTJL0w8W32((object) tablePartManager, (object) current2);
                num3 = 10;
                continue;
              case 11:
                goto label_26;
              case 12:
                if (!nullable.HasValue)
                {
                  num3 = 18;
                  continue;
                }
                goto case 2;
              case 13:
                if (hashedSet.Add(nullable.Value))
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 7 : 20;
                  continue;
                }
                goto label_28;
              case 14:
                tablePartManager = DynamicFormHelper.kOLjKXOUeguao4IQxc6(current2.CastAsRealType<IEntity>().GetType()) as ITablePartManager;
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 8 : 3;
                continue;
              case 15:
                DynamicFormHelper.Wu920JOLXlyMvhQhqw2((object) current2, (object) DynamicFormHelper.LEtdyUOY0rANOBylVcg());
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 14 : 0;
                continue;
              case 16:
                Type typeByUid = ((IMetadataRuntimeService) DynamicFormHelper.cQBfu1OgR4rLOUcPH0d()).GetTypeByUid(DynamicFormHelper.gsxbmqO51XhE33prNwt((object) current1));
                if (!DynamicFormHelper.zlP3tUOjtsnvPi98xDu(typeByUid, ModelHelper.GetEntityIdType(typeByUid), id))
                {
                  num3 = 19;
                  continue;
                }
                goto case 15;
              case 17:
                if (DynamicFormHelper.A5q1iKOdKAFPEyy52Yf((object) current2))
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 0;
                  continue;
                }
                goto case 3;
              default:
                goto label_21;
            }
          }
label_28:
          throw new Exception(EleWise.ELMA.SR.T((string) DynamicFormHelper.R4jn40OOW7stH3wiytf(-1255365154 ^ 596875508 ^ -1765846346), (object) nullable.Value));
label_22:
          num3 = 5;
          goto label_6;
label_26:
          current2 = enumerator2.Current;
          num3 = 17;
          goto label_6;
        }
        finally
        {
          if (enumerator2 != null)
          {
            int num4 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
              num4 = 0;
            while (true)
            {
              switch (num4)
              {
                case 1:
                  goto label_35;
                default:
                  enumerator2.Dispose();
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 1;
                  continue;
              }
            }
          }
label_35:;
        }
label_37:
        num2 = 3;
        goto label_4;
label_38:
        current1 = enumerator1.Current;
        num2 = 5;
        goto label_4;
      }
      finally
      {
        if (enumerator1 != null)
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0)
            num5 = 0;
          while (true)
          {
            switch (num5)
            {
              case 1:
                goto label_57;
              default:
                DynamicFormHelper.NlXpfgONDUYLivmVaw5((object) enumerator1);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 1 : 0;
                continue;
            }
          }
        }
label_57:;
      }
label_55:
      return;
label_50:;
    }

    private static TypeSettingsInstanceData GetTypeSettingsInstanceData(
      object entity,
      object metadata)
    {
      TypeSettingsInstanceData settingsInstanceData = new TypeSettingsInstanceData();
      DynamicFormHelper.QUDZLTOc5i2vXc7NY47((object) settingsInstanceData, entity, metadata);
      return settingsInstanceData;
    }

    private static void GetTypeSettingsInstanceData(object data, object entity, object metadata)
    {
      int num1 = 3;
      List<TablePartMetadata>.Enumerator enumerator1;
      List<PropertyMetadata>.Enumerator enumerator2;
      while (true)
      {
        switch (num1)
        {
          case 1:
label_2:
            enumerator1 = ((EntityMetadata) metadata).TableParts.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
            continue;
          case 2:
            try
            {
label_11:
              if (enumerator2.MoveNext())
                goto label_7;
              else
                goto label_12;
label_5:
              PropertyMetadata current;
              TypeSettings typeSettings;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_2;
                  case 2:
                    DynamicFormHelper.bry0CN2BpuAhOgDZDVF(data, current.Uid, (object) ClassSerializationHelper.CloneObjectByXml<TypeSettings>(typeSettings));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
                    continue;
                  case 3:
                    goto label_7;
                  case 4:
                    typeSettings = (TypeSettings) DynamicFormHelper.vtDgBR2FHDlFmsCt1Gw(entity, DynamicFormHelper.bb8irROzDf3CaVuHaAl((object) current));
                    num2 = 5;
                    continue;
                  case 5:
                    if (typeSettings != null)
                    {
                      num2 = 2;
                      continue;
                    }
                    goto label_11;
                  default:
                    goto label_11;
                }
              }
label_7:
              current = enumerator2.Current;
              num2 = 2;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
              {
                num2 = 4;
                goto label_5;
              }
              else
                goto label_5;
label_12:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 1 : 0;
              goto label_5;
            }
            finally
            {
              enumerator2.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
          case 3:
            enumerator2 = ((ClassMetadata) metadata).Properties.GetEnumerator();
            num1 = 2;
            continue;
          case 4:
            goto label_30;
          default:
            goto label_18;
        }
      }
label_30:
      return;
label_18:
      try
      {
label_23:
        if (enumerator1.MoveNext())
          goto label_21;
        else
          goto label_24;
label_20:
        TablePartMetadata current;
        int num4;
        while (true)
        {
          switch (num4)
          {
            case 1:
              DynamicFormHelper.QUDZLTOc5i2vXc7NY47(data, entity, (object) current);
              num4 = 3;
              continue;
            case 2:
              goto label_26;
            case 3:
              goto label_23;
            default:
              goto label_21;
          }
        }
label_26:
        return;
label_21:
        current = enumerator1.Current;
        num4 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
        {
          num4 = 0;
          goto label_20;
        }
        else
          goto label_20;
label_24:
        num4 = 2;
        goto label_20;
      }
      finally
      {
        enumerator1.Dispose();
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
          num5 = 0;
        switch (num5)
        {
          default:
        }
      }
    }

    private static IPropertyMetadata FindProperty(object metadata, Guid propertyUid)
    {
      int num1 = 3;
      PropertyMetadata property1;
      List<TablePartMetadata>.Enumerator enumerator;
      Guid propertyUid1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_12;
            case 2:
              propertyUid1 = propertyUid;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
              continue;
            case 3:
              goto label_6;
            case 4:
              if (property1 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 6 : 3;
                continue;
              }
              enumerator = ((EntityMetadata) metadata).TableParts.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 1;
              continue;
            case 5:
              goto label_8;
            case 6:
              goto label_10;
            default:
              goto label_7;
          }
        }
label_6:
        num1 = 2;
        continue;
label_7:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        property1 = ((ClassMetadata) metadata).Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => DynamicFormHelper.\u003C\u003Ec__DisplayClass30_0.k65otWfyhbyqjPRZdcHc(DynamicFormHelper.\u003C\u003Ec__DisplayClass30_0.wDP06Rfybipj4uvmfcxo((object) p), propertyUid1)));
        num1 = 4;
      }
label_8:
      return (IPropertyMetadata) null;
label_10:
      return (IPropertyMetadata) property1;
label_12:
      IPropertyMetadata property2;
      try
      {
label_16:
        if (enumerator.MoveNext())
          goto label_14;
        else
          goto label_17;
label_13:
        TablePartMetadata current;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_8;
            case 3:
              goto label_9;
            case 4:
              if (DynamicFormHelper.sZIFBM2Wfx5Jjapa2Jk((object) current, propertyUid1) == null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
                continue;
              }
              goto case 5;
            case 5:
              property2 = (IPropertyMetadata) current;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 2 : 3;
              continue;
            case 6:
              goto label_14;
            default:
              goto label_16;
          }
        }
label_14:
        current = enumerator.Current;
        num3 = 4;
        goto label_13;
label_17:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 1 : 1;
        goto label_13;
      }
      finally
      {
        enumerator.Dispose();
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
          num4 = 0;
        switch (num4)
        {
          default:
        }
      }
label_9:
      return property2;
    }

    internal static bool n1FpHIOkoB5AcD0jjyO() => DynamicFormHelper.QDnTn9OTtnmGr7FGCxv == null;

    internal static DynamicFormHelper lajhGHOnTMNX5TFPBrD() => DynamicFormHelper.QDnTn9OTtnmGr7FGCxv;

    internal static object R4jn40OOW7stH3wiytf(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool OZjnAqO2BlE7BGG7gQU([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void LgZAI0Oe16njA87xmwd([In] object obj0, bool value) => ((FormViewBuilderInfo) obj0).ClosePopup = value;

    internal static object AVePmvOPq14pBfYiTJ5() => (object) ComponentManager.Current;

    internal static bool bBtyrvO197gaqZcHcK6([In] object obj0, [In] object obj1) => ((MemoryStream) obj0).Compare((MemoryStream) obj1);

    internal static void NlXpfgONDUYLivmVaw5([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object p179oUO37BQuIITNNpM([In] object obj0) => (object) ((ViewItem) obj0).FormViewItem;

    internal static object hfUHPfOpoNa4759K0Px([In] object obj0) => (object) ((PropertyViewItem) obj0).TypeSettings;

    internal static object eRKG2wOaBImpglaklIG([In] object obj0, [In] object obj1) => (object) ((PropertyViewItem) obj0).GetEqualPropertiesFromForm((FormViewItem) obj1);

    internal static void yN5WkIODOevLiQXWNLy([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertiesContainer) obj0)[(string) obj1] = obj2;

    internal static void pG8wEXOtE71WlY0nJEj([In] object obj0, [In] object obj1) => DynamicFormHelper.ProcessNewTablePartItems((IEntity) obj0, (IEntityMetadata) obj1);

    internal static void FosQu4Owe8KXOrtcw1e([In] object obj0, EntitySerializationMode value) => ((EntitySerializationSettings) obj0).Mode = value;

    internal static object FfFQYNO4ECxXpNDUpwH([In] object obj0) => (object) JsonConvert.SerializeObject(obj0);

    internal static object Ter285O62QVYPoTml8P([In] object obj0) => (object) ((FormView) obj0).OnLoadScriptName;

    internal static bool MAijTKOHp6qpEQWRFQJ([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object n0q4hEOAIUfJW5lZ5gm([In] object obj0) => (object) ((ClassMetadata) obj0).OnViewLoadScriptName;

    internal static object aDp8X5O71as9MtHdoJW([In] object obj0) => (object) ((DynamicFormResult) obj0).ModelJsonState;

    internal static void Don6brOxFB1TJbxLkPo([In] object obj0, [In] object obj1) => ((DynamicFormSettings) obj0).ModelJsonState = (string) obj1;

    internal static object qZw9RDO0OvQSgK9yKUO([In] object obj0) => (object) ((DynamicFormResult) obj0).ViewTransformation;

    internal static object w6fQWAOmwDDGQcprBnR([In] object obj0) => (object) ((DynamicFormResult) obj0).ChangedView;

    internal static object FfogdSOyFLMv4KsS6ja([In] object obj0) => (object) DynamicFormHelper.ModelJsonState((IEntity) obj0);

    internal static Guid Xy4blNOMasG8jl54bYd([In] object obj0) => ((ITablePartMetadata) obj0).TablePartPropertyUid;

    internal static object kWs6KvOJ7lZJPNolBuc([In] object obj0, Guid propertyUid) => ((IEntity) obj0).GetPropertyValue(propertyUid);

    internal static bool KQMXGaO9Ryrkw66EFUL([In] object obj0) => ((IPersistentCollection) obj0).WasInitialized;

    internal static bool A5q1iKOdKAFPEyy52Yf([In] object obj0) => ((IEntity) obj0).IsNew();

    internal static object DW3jh7OlMg5H6CTTcdG([In] object obj0, [In] object obj1, [In] object obj2) => obj0.GetPropertyValue((string) obj1, obj2);

    internal static bool xXO9fDOrN7VcuN1DiUi([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object cQBfu1OgR4rLOUcPH0d() => (object) DynamicFormHelper.MetadataRuntimeService;

    internal static Guid gsxbmqO51XhE33prNwt([In] object obj0) => ((IMetadata) obj0).Uid;

    internal static bool zlP3tUOjtsnvPi98xDu(Type type, Type idType, [In] object obj2) => type.IsDefaultId(idType, obj2);

    internal static long LEtdyUOY0rANOBylVcg() => TablePartHelper.GetNextTemporaryId();

    internal static void Wu920JOLXlyMvhQhqw2([In] object obj0, [In] object obj1) => ((IIdentified) obj0).SetId(obj1);

    internal static object kOLjKXOUeguao4IQxc6(Type entityType) => (object) EntityHelper.GetEntityManager(entityType);

    internal static void V43RUHOseSTJL0w8W32([In] object obj0, [In] object obj1) => ((ITablePartManager) obj0).PutToContextCache((IEntity) obj1);

    internal static void QUDZLTOc5i2vXc7NY47([In] object obj0, [In] object obj1, [In] object obj2) => DynamicFormHelper.GetTypeSettingsInstanceData(obj0, obj1, obj2);

    internal static Guid bb8irROzDf3CaVuHaAl([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object vtDgBR2FHDlFmsCt1Gw([In] object obj0, Guid propertyUid) => (object) ((IEntity) obj0).LoadPropertyInstanceSettings(propertyUid);

    internal static void bry0CN2BpuAhOgDZDVF([In] object obj0, Guid uid, [In] object obj2) => ((TypeSettingsInstanceData) obj0)[uid] = (TypeSettings) obj2;

    internal static object sZIFBM2Wfx5Jjapa2Jk([In] object obj0, Guid propertyUid) => (object) DynamicFormHelper.FindProperty(obj0, propertyUid);
  }
}
