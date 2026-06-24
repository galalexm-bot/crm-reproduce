// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Components.ComponentObjectFormProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Components
{
  /// <summary>Провайдер форм для компонентов</summary>
  [Component]
  internal sealed class ComponentObjectFormProvider : IObjectFormProvider
  {
    private readonly IComponentMetadataItemManager componentMetadataItemManager;
    internal static ComponentObjectFormProvider rSkOGnBZlhh2sOSGmJkN;

    /// <summary>Ctor</summary>
    /// <param name="componentMetadataItemManager">Менеджер метаданных компонентов</param>
    public ComponentObjectFormProvider(
      IComponentMetadataItemManager componentMetadataItemManager)
    {
      ComponentObjectFormProvider.RMPyprBZ5XGV6KhaWIrh();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.componentMetadataItemManager = componentMetadataItemManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public bool Check(Guid typeUid, Guid subTypeUid)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (ComponentObjectFormProvider.BKlKr8BZjv2INQ3MKsaO(typeUid, PageComponentMetadata.TypeUid))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 2:
            goto label_4;
          case 3:
            if (!ComponentObjectFormProvider.BKlKr8BZjv2INQ3MKsaO(typeUid, ComponentMetadata.TypeUid))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 2 : 1;
              continue;
            }
            goto label_5;
          default:
            goto label_5;
        }
      }
label_4:
      return ComponentObjectFormProvider.BKlKr8BZjv2INQ3MKsaO(typeUid, PortletComponentMetadata.TypeUid);
label_5:
      return true;
    }

    /// <inheritdoc />
    public (object, ClassMetadata) GetObjectInfo(Guid typeUid, Guid subTypeUid, string model)
    {
      ComponentMetadataItem componentMetadataItem = this.componentMetadataItemManager.Load(subTypeUid);
      ComponentMetadata metadata = (ComponentMetadata) componentMetadataItem.Metadata;
      Assembly assembly = ComponentManager.FindLoadedAssembly(ScriptExecutionHandlerHelper.CreateFullAssemblyName(componentMetadataItem.AssemblyName, componentMetadataItem.AssemblyVersion, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633531469), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1255365154 ^ 596875508 ^ -1765855796)), true);
      if (assembly == (Assembly) null)
        assembly = ComponentManager.LoadAssembly(componentMetadataItem.ScriptModule.AssemblyRaw, componentMetadataItem.ScriptModule.DebugRaw);
      string name = metadata.FullTypeName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459575553) + metadata.Content.Context.Name;
      Type type = assembly.GetType(name);
      return (model != string.Empty ? new EntityJsonSerializer().Deserialize(model, type, false) : Activator.CreateInstance(type), (ClassMetadata) metadata.Content.Context);
    }

    /// <inheritdoc />
    public FormViewItem GetFormByType(object obj, ViewType viewType) => throw new NotImplementedException((string) ComponentObjectFormProvider.C2hmgNBZYjDBLcS7jyJB((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998471946)));

    /// <inheritdoc />
    public FormViewItem GetFormByUid(object obj, Guid formUid) => (FormViewItem) ComponentObjectFormProvider.OTZ4AOBZsQfHBtHv6Rq0(ComponentObjectFormProvider.cRRlmEBZU5kBRHtiennA((object) (ComponentMetadata) ComponentObjectFormProvider.DlhyhxBZLoQeZuUiXGUp((object) this.componentMetadataItemManager.Load(formUid))));

    /// <inheritdoc />
    public void InitObject(object obj, ViewType viewType, IDictionary<string, object> arguments)
    {
    }

    internal static void RMPyprBZ5XGV6KhaWIrh() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool QBaNLyBZrRrVSr29SH8f() => ComponentObjectFormProvider.rSkOGnBZlhh2sOSGmJkN == null;

    internal static ComponentObjectFormProvider CoptviBZgXORFplPWNLX() => ComponentObjectFormProvider.rSkOGnBZlhh2sOSGmJkN;

    internal static bool BKlKr8BZjv2INQ3MKsaO([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object C2hmgNBZYjDBLcS7jyJB([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object DlhyhxBZLoQeZuUiXGUp([In] object obj0) => ((ComponentMetadataItem) obj0).Metadata;

    internal static object cRRlmEBZU5kBRHtiennA([In] object obj0) => (object) ((ComponentMetadata) obj0).Content;

    internal static object OTZ4AOBZsQfHBtHv6Rq0([In] object obj0) => (object) ((ComponentContentMetadata) obj0).View;
  }
}
