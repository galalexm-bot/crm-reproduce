// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.ExportHelper.ExportFormDependencyHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Deploy.ExportHelper
{
  public static class ExportFormDependencyHelper
  {
    internal static readonly string ObjectFormsPrefix;
    internal static readonly string FormDependencyPrefix;
    internal static readonly string FormDependencyDisplayName;
    private static ExportFormDependencyHelper UvnAkwEaLNEu6JB5dDdt;

    /// <summary>Добавить в раздел ServiceData описание зависимостей</summary>
    public static void AddFormDependenciesInfo(
      Guid uid,
      string displayName,
      Dictionary<string, object> serviceData)
    {
      IMetadataRuntimeService serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
      foreach (IFormDependencyData formDependencyData in FormDependencyHelper.LoadByDependObjectUid(uid))
      {
        IFormDependencyData dep = formDependencyData;
        Type typeByUidOrNull = serviceNotNull.GetTypeByUidOrNull(dep.UsesObjectUid, false);
        bool flag = false;
        if (typeByUidOrNull != (Type) null && serviceNotNull.GetMetadata(dep.UsesObjectUid, false) is EntityMetadata metadata)
        {
          // ISSUE: reference to a compiler-generated method
          flag = metadata.Forms.Any<FormViewItem>((Func<FormViewItem, bool>) (q => q.Uid == ExportFormDependencyHelper.\u003C\u003Ec__DisplayClass3_1.TV8L9f82q8NIyj7uIcJS((object) dep)));
        }
        if (flag || typeByUidOrNull == (Type) null)
        {
          string key1 = string.Join(FormDependencyHelper.KeySplitter, new string[2]
          {
            ExportFormDependencyHelper.FormDependencyPrefix,
            dep.GenerateDependInfo()
          });
          if (!serviceData.ContainsKey(key1))
            serviceData.Add(key1, (object) dep.GenerateUsesInfo());
          string key2 = string.Join(FormDependencyHelper.KeySplitter, new string[2]
          {
            ExportFormDependencyHelper.FormDependencyDisplayName,
            dep.GenerateDependInfo()
          });
          if (!serviceData.ContainsKey(key2))
            serviceData.Add(key2, (object) displayName);
        }
      }
      // ISSUE: reference to a compiler-generated method
      IFormDependencyExtension dependencyExtension = ComponentManager.Current.GetExtensionPoints<IFormDependencyExtension>().FirstOrDefault<IFormDependencyExtension>((Func<IFormDependencyExtension, bool>) (q => ExportFormDependencyHelper.\u003C\u003Ec__DisplayClass3_0.YxJSsH82Is5boggvocVd((object) q, uid)));
      if (dependencyExtension == null)
        return;
      List<Guid> list = dependencyExtension.GetFormUids(uid).ToList<Guid>();
      if (list.Count == 0)
        return;
      string key = string.Join(FormDependencyHelper.KeySplitter, (object) ExportFormDependencyHelper.ObjectFormsPrefix, (object) uid);
      if (serviceData.ContainsKey(key))
        return;
      serviceData.Add(key, (object) string.Join<Guid>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -671855227), (IEnumerable<Guid>) list));
    }

    static ExportFormDependencyHelper()
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            ExportFormDependencyHelper.FormDependencyDisplayName = (string) ExportFormDependencyHelper.yrVE7QEazeDndxBi0cGM(1669212571 ^ 1668984603);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 1;
            continue;
          case 3:
            ExportFormDependencyHelper.ObjectFormsPrefix = (string) ExportFormDependencyHelper.yrVE7QEazeDndxBi0cGM(-16752921 ^ -16459615);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
            continue;
          case 4:
            ExportFormDependencyHelper.yh5MtCEacaRcR5AB3Zql();
            num = 3;
            continue;
          default:
            ExportFormDependencyHelper.FormDependencyPrefix = (string) ExportFormDependencyHelper.yrVE7QEazeDndxBi0cGM(1597012150 ^ 1597308630);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static void yh5MtCEacaRcR5AB3Zql() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object yrVE7QEazeDndxBi0cGM(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool xqQx1aEaUY8hOuFJ663P() => ExportFormDependencyHelper.UvnAkwEaLNEu6JB5dDdt == null;

    internal static ExportFormDependencyHelper cK1fsNEas9hdJYaT7WZB() => ExportFormDependencyHelper.UvnAkwEaLNEu6JB5dDdt;
  }
}
