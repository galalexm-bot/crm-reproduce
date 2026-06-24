// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Metadata.ComponentMetadataHelperInternal
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Toolbar;
using EleWise.ELMA.Scripts.Models;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Metadata
{
  /// <summary>Внутренний помощник для метаданных компонентов</summary>
  internal static class ComponentMetadataHelperInternal
  {
    /// <summary>Prefix сборки для компонентов</summary>
    internal const string AssemblyPrefix = "__ComponentAssembly__";
    internal static ComponentMetadataHelperInternal fZYAYaBb7Cq797VAl4VP;

    /// <summary>Имя серверной сборки для эмуляции</summary>
    /// <param name="metadata">Метаданные</param>
    /// <returns>Имя серверной сборки</returns>
    internal static string ServerEmulationAssemblyName(ComponentMetadata metadata) => (string) ComponentMetadataHelperInternal.G147tNBbJDSJkgrrCkv1(ComponentMetadataHelperInternal.ReMQvMBbmCRHMythLFtY(1597012150 ^ 1597018708), ComponentMetadataHelperInternal.ReMQvMBbmCRHMythLFtY(-1317790512 ^ -1317734798), ComponentMetadataHelperInternal.XSPWChBbyjMAZlWl8cM5((object) metadata), (object) ComponentMetadataHelperInternal.zyxJYfBbMb7yK7ISqHXF());

    /// <summary>Полное имя типа контроллера компонента</summary>
    /// <param name="metadata">Метаданные компонента</param>
    /// <returns>Полное имя типа контроллера компонента</returns>
    internal static string ControllerTypeName(ComponentMetadata metadata) => (string) ComponentMetadataHelperInternal.RmhkKnBb92iPAh9EBvV0(ComponentMetadataHelperInternal.XSPWChBbyjMAZlWl8cM5((object) metadata), ComponentMetadataHelperInternal.ReMQvMBbmCRHMythLFtY(-1939377524 ^ -1939367822));

    /// <summary>Полное имя типа контекста компонента</summary>
    /// <param name="metadata">Метаданные компонента</param>
    /// <returns>Полное имя типа контекста компонента</returns>
    internal static string ContextTypeName(ComponentMetadata metadata) => (string) ComponentMetadataHelperInternal.EUYtgpBbgGSu7owZoosS((object) metadata.FullTypeName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767705051), ComponentMetadataHelperInternal.sIhFy6BbrsDswkrEF9Hj(ComponentMetadataHelperInternal.SYWKTMBbl0FBLxY13hkG(ComponentMetadataHelperInternal.m4sIIbBbd2daoVxdWyG9((object) metadata))));

    /// <summary>Заменить идентификаторы в ScriptMethodInfo</summary>
    /// <param name="metadata">Новые метаданные</param>
    /// <param name="oldMetadataUid">Идентификатор старых метаданных</param>
    internal static void ReplaceOldUids(ComponentMetadata metadata, Guid oldMetadataUid)
    {
      int num1 = 2;
      List<ComponentDependency>.Enumerator enumerator1;
      while (true)
      {
        int num2 = num1;
        FormViewItem view;
        IEnumerator<ViewItem> enumerator2;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_74;
            case 1:
              enumerator2 = view.GetAllItems(false).Concat<ViewItem>((ViewItem) view).GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 3;
              continue;
            case 2:
              view = ((ComponentContentMetadata) ComponentMetadataHelperInternal.m4sIIbBbd2daoVxdWyG9((object) metadata)).View;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 1 : 1;
              continue;
            case 3:
              goto label_29;
            case 4:
              goto label_4;
            case 5:
              goto label_28;
            default:
              goto label_71;
          }
        }
label_28:
        enumerator1 = metadata.ComponentDependencies.GetEnumerator();
        num1 = 4;
        continue;
label_29:
        try
        {
label_65:
          if (enumerator2.MoveNext())
            goto label_43;
          else
            goto label_66;
label_30:
          EleWise.ELMA.Model.Views.Toolbar.Toolbar toolbar;
          ViewItem current1;
          IEnumerator<ToolbarItem> enumerator3;
          int num3;
          while (true)
          {
            switch (num3)
            {
              case 1:
                if (ComponentMetadataHelperInternal.RDj3T4BbzsQ1CKPynsBA((object) propertyViewItem) == null)
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 11 : 10;
                  continue;
                }
                goto case 13;
              case 2:
                toolbar = (EleWise.ELMA.Model.Views.Toolbar.Toolbar) ComponentMetadataHelperInternal.FddqtoBbs2g8lSSxPU5L((object) formViewItem);
                num3 = 14;
                continue;
              case 3:
                ComponentMetadataHelperInternal.TdqOSVBbUfxh25J9vNbQ((object) formViewItem, ComponentMetadataHelperInternal.PmidbmBbYiZY61bl0N76((object) formViewItem.OnLoadScriptName, ComponentMetadataHelperInternal.lSrgp7BbjaX7svq8u4j7((object) metadata), oldMetadataUid));
                num3 = 2;
                continue;
              case 4:
                if (current1 is ButtonViewItem buttonViewItem)
                {
                  num3 = 6;
                  continue;
                }
                goto case 16;
              case 5:
                ((ViewAttributes) ComponentMetadataHelperInternal.RDj3T4BbzsQ1CKPynsBA((object) propertyViewItem)).ValidationScriptName = (string) ComponentMetadataHelperInternal.PmidbmBbYiZY61bl0N76(ComponentMetadataHelperInternal.ESZUHrBhBnxZNyfgq38o(ComponentMetadataHelperInternal.RDj3T4BbzsQ1CKPynsBA((object) propertyViewItem)), ComponentMetadataHelperInternal.lSrgp7BbjaX7svq8u4j7((object) metadata), oldMetadataUid);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 8 : 7;
                continue;
              case 6:
                ComponentMetadataHelperInternal.LlldD1BbLCqcVR7yTCFT((object) buttonViewItem, ComponentMetadataHelperInternal.PmidbmBbYiZY61bl0N76(ComponentMetadataHelperInternal.tfJC0RBb5UJw5OUAWtti((object) buttonViewItem), ComponentMetadataHelperInternal.lSrgp7BbjaX7svq8u4j7((object) metadata), oldMetadataUid));
                num3 = 16;
                continue;
              case 7:
                goto label_65;
              case 8:
              case 11:
                ComponentMetadataHelperInternal.ReplaceDynamicPropertiesOldUids(current1.DynamicProperties, metadata.Uid, oldMetadataUid);
                num3 = 7;
                continue;
              case 9:
                goto label_28;
              case 10:
                goto label_43;
              case 12:
                ComponentMetadataHelperInternal.ReplaceDynamicPropertiesOldUids(toolbar.DynamicProperties, metadata.Uid, oldMetadataUid);
                num3 = 17;
                continue;
              case 13:
                ((ViewAttributes) ComponentMetadataHelperInternal.RDj3T4BbzsQ1CKPynsBA((object) propertyViewItem)).OnChangeScriptName = (string) ComponentMetadataHelperInternal.PmidbmBbYiZY61bl0N76(ComponentMetadataHelperInternal.BVApZIBhFIwpaZdy89l5(ComponentMetadataHelperInternal.RDj3T4BbzsQ1CKPynsBA((object) propertyViewItem)), ComponentMetadataHelperInternal.lSrgp7BbjaX7svq8u4j7((object) metadata), oldMetadataUid);
                num3 = 5;
                continue;
              case 14:
                if (toolbar == null)
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
                  continue;
                }
                goto case 12;
              case 15:
                try
                {
label_47:
                  if (enumerator3.MoveNext())
                    goto label_49;
                  else
                    goto label_48;
label_46:
                  int num4;
                  switch (num4)
                  {
                    case 1:
                      goto label_47;
                    case 2:
                      goto label_40;
                    default:
                      goto label_49;
                  }
label_48:
                  num4 = 2;
                  goto label_46;
label_49:
                  ToolbarItem current2 = enumerator3.Current;
                  if (current2 is Button button)
                    button.ScriptName = (string) ComponentMetadataHelperInternal.PmidbmBbYiZY61bl0N76((object) button.ScriptName, ComponentMetadataHelperInternal.lSrgp7BbjaX7svq8u4j7((object) metadata), oldMetadataUid);
                  ComponentMetadataHelperInternal.ReplaceDynamicPropertiesOldUids(current2.DynamicProperties, metadata.Uid, oldMetadataUid);
                  num4 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
                  {
                    num4 = 1;
                    goto label_46;
                  }
                  else
                    goto label_46;
                }
                finally
                {
                  if (enumerator3 != null)
                  {
                    int num5 = 1;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
                      num5 = 0;
                    while (true)
                    {
                      switch (num5)
                      {
                        case 1:
                          ComponentMetadataHelperInternal.Eama3eBbcZZhkpHS1fIc((object) enumerator3);
                          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
                          continue;
                        default:
                          goto label_58;
                      }
                    }
                  }
label_58:;
                }
              case 16:
                if (current1 is FormViewItem formViewItem)
                {
                  num3 = 3;
                  continue;
                }
                goto default;
              case 17:
                enumerator3 = toolbar.GetAllItems(false).GetEnumerator();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 15;
                continue;
              default:
label_40:
                if (current1 is PropertyViewItem propertyViewItem)
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 1;
                  continue;
                }
                goto case 8;
            }
          }
label_43:
          current1 = enumerator2.Current;
          num3 = 2;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
          {
            num3 = 4;
            goto label_30;
          }
          else
            goto label_30;
label_66:
          num3 = 9;
          goto label_30;
        }
        finally
        {
          int num6;
          if (enumerator2 == null)
            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 1;
          else
            goto label_72;
label_70:
          switch (num6)
          {
            case 2:
              break;
            default:
          }
label_72:
          ComponentMetadataHelperInternal.Eama3eBbcZZhkpHS1fIc((object) enumerator2);
          num6 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
          {
            num6 = 0;
            goto label_70;
          }
          else
            goto label_70;
        }
      }
label_74:
      return;
label_71:
      return;
label_4:
      try
      {
label_21:
        if (enumerator1.MoveNext())
          goto label_6;
        else
          goto label_22;
label_5:
        List<InputComputedValue>.Enumerator enumerator4;
        int num7;
        switch (num7)
        {
          case 1:
            break;
          case 2:
            goto label_21;
          case 3:
            return;
          default:
            try
            {
label_15:
              if (enumerator4.MoveNext())
                goto label_13;
              else
                goto label_16;
label_10:
              int num8;
              switch (num8)
              {
                case 1:
                case 2:
                  goto label_15;
                case 3:
                  goto label_13;
                case 4:
                  goto label_21;
              }
label_11:
              actionValue.MethodName = (string) ComponentMetadataHelperInternal.PmidbmBbYiZY61bl0N76((object) actionValue.MethodName, metadata.Uid, oldMetadataUid);
              num8 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
              {
                num8 = 1;
                goto label_10;
              }
              else
                goto label_10;
label_13:
              InputComputedValue current = enumerator4.Current;
              ComponentMetadataHelperInternal.k2H7x9BhoHke2PX3Vmau((object) current, ComponentMetadataHelperInternal.PmidbmBbYiZY61bl0N76(ComponentMetadataHelperInternal.eeei1nBhWisiF7wH696l((object) current), ComponentMetadataHelperInternal.lSrgp7BbjaX7svq8u4j7((object) metadata), oldMetadataUid));
              if (!(ComponentMetadataHelperInternal.qTlQSDBhb0qL1vyFML1X((object) current) is ActionValue actionValue))
              {
                num8 = 2;
                goto label_10;
              }
              else
                goto label_11;
label_16:
              num8 = 4;
              goto label_10;
            }
            finally
            {
              enumerator4.Dispose();
              int num9 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0)
                num9 = 0;
              switch (num9)
              {
                default:
              }
            }
        }
label_6:
        enumerator4 = enumerator1.Current.Inputs.GetEnumerator();
        num7 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
        {
          num7 = 0;
          goto label_5;
        }
        else
          goto label_5;
label_22:
        num7 = 3;
        goto label_5;
      }
      finally
      {
        enumerator1.Dispose();
        int num10 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
          num10 = 0;
        switch (num10)
        {
          default:
        }
      }
    }

    private static void ReplaceDynamicPropertiesOldUids(
      List<ComputedValue> list,
      Guid newMetadataUid,
      Guid oldMetadataUid)
    {
      foreach (ComputedValue computedValue in list)
      {
        computedValue.MethodName = ComponentMetadataHelperInternal.GetNewScriptMethodName((object) computedValue.MethodName, newMetadataUid, oldMetadataUid);
        if (computedValue.Value is ActionValue actionValue)
          actionValue.MethodName = ComponentMetadataHelperInternal.GetNewScriptMethodName((object) actionValue.MethodName, newMetadataUid, oldMetadataUid);
      }
    }

    private static string GetNewScriptMethodName(
      object oldMethodName,
      Guid componentMetadataUid,
      Guid oldMetadataUid)
    {
      int num = 5;
      ScriptMethodInfo scriptMethodInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 4:
            goto label_6;
          case 3:
            if (!ComponentMetadataHelperInternal.J4tVh4BhEygCMytQJ7MS(ComponentMetadataHelperInternal.Re4RywBhGwWVCshnQE48((object) scriptMethodInfo), oldMetadataUid))
            {
              ComponentMetadataHelperInternal.fQRWI1Bhf2vQXca1bk3B((object) scriptMethodInfo, componentMetadataUid);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 7 : 7;
              continue;
            }
            num = 2;
            continue;
          case 5:
            if (ComponentMetadataHelperInternal.quaVbgBhhi8EUovlqJOB(oldMethodName))
            {
              num = 4;
              continue;
            }
            goto case 8;
          case 6:
            if (scriptMethodInfo == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 7:
            goto label_12;
          case 8:
            if (((string) oldMethodName).StartsWith((string) ComponentMetadataHelperInternal.ReMQvMBbmCRHMythLFtY(2008901894 << 3 ^ -1108655156)))
            {
              scriptMethodInfo = ScriptMethodInfoHelper.Deserialize((string) oldMethodName);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 2 : 6;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 1;
            continue;
          default:
            goto label_8;
        }
      }
label_6:
      return (string) oldMethodName;
label_8:
      return (string) oldMethodName;
label_12:
      return (string) ComponentMetadataHelperInternal.xpcdKBBhQIaam6VUnUNw((object) scriptMethodInfo);
    }

    internal static object ReMQvMBbmCRHMythLFtY(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object XSPWChBbyjMAZlWl8cM5([In] object obj0) => (object) ((ComponentMetadata) obj0).FullTypeName;

    internal static Guid zyxJYfBbMb7yK7ISqHXF() => Guid.NewGuid();

    internal static object G147tNBbJDSJkgrrCkv1(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }

    internal static bool sVoxYmBbxCGRmxpsk4qS() => ComponentMetadataHelperInternal.fZYAYaBb7Cq797VAl4VP == null;

    internal static ComponentMetadataHelperInternal p7AaQZBb0SHlSmCEFwee() => ComponentMetadataHelperInternal.fZYAYaBb7Cq797VAl4VP;

    internal static object RmhkKnBb92iPAh9EBvV0([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object m4sIIbBbd2daoVxdWyG9([In] object obj0) => (object) ((ComponentMetadata) obj0).Content;

    internal static object SYWKTMBbl0FBLxY13hkG([In] object obj0) => (object) ((ComponentContentMetadata) obj0).Context;

    internal static object sIhFy6BbrsDswkrEF9Hj([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object EUYtgpBbgGSu7owZoosS([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object tfJC0RBb5UJw5OUAWtti([In] object obj0) => (object) ((ButtonViewItem) obj0).ScriptName;

    internal static Guid lSrgp7BbjaX7svq8u4j7([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object PmidbmBbYiZY61bl0N76(
      [In] object obj0,
      Guid componentMetadataUid,
      Guid oldMetadataUid)
    {
      return (object) ComponentMetadataHelperInternal.GetNewScriptMethodName(obj0, componentMetadataUid, oldMetadataUid);
    }

    internal static void LlldD1BbLCqcVR7yTCFT([In] object obj0, [In] object obj1) => ((ButtonViewItem) obj0).ScriptName = (string) obj1;

    internal static void TdqOSVBbUfxh25J9vNbQ([In] object obj0, [In] object obj1) => ((FormView) obj0).OnLoadScriptName = (string) obj1;

    internal static object FddqtoBbs2g8lSSxPU5L([In] object obj0) => (object) ((FormViewItem) obj0).Toolbar;

    internal static void Eama3eBbcZZhkpHS1fIc([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object RDj3T4BbzsQ1CKPynsBA([In] object obj0) => (object) ((PropertyViewItem) obj0).Attributes;

    internal static object BVApZIBhFIwpaZdy89l5([In] object obj0) => (object) ((ViewAttributes) obj0).OnChangeScriptName;

    internal static object ESZUHrBhBnxZNyfgq38o([In] object obj0) => (object) ((ViewAttributes) obj0).ValidationScriptName;

    internal static object eeei1nBhWisiF7wH696l([In] object obj0) => (object) ((ComputedValue) obj0).MethodName;

    internal static void k2H7x9BhoHke2PX3Vmau([In] object obj0, [In] object obj1) => ((ComputedValue) obj0).MethodName = (string) obj1;

    internal static object qTlQSDBhb0qL1vyFML1X([In] object obj0) => ((ComputedValue) obj0).Value;

    internal static bool quaVbgBhhi8EUovlqJOB([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static Guid Re4RywBhGwWVCshnQE48([In] object obj0) => ((ScriptMethodInfo) obj0).MetadataUid;

    internal static bool J4tVh4BhEygCMytQJ7MS([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static void fQRWI1Bhf2vQXca1bk3B([In] object obj0, Guid value) => ((ScriptMethodInfo) obj0).MetadataUid = value;

    internal static object xpcdKBBhQIaam6VUnUNw([In] object obj0) => (object) ScriptMethodInfoHelper.Serialize((ScriptMethodInfo) obj0);
  }
}
