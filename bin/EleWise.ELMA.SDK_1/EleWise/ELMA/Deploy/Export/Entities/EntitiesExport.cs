// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.Entities.EntitiesExport
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace EleWise.ELMA.Deploy.Export.Entities
{
  /// <summary>Экспорт данных экспортируемого справочника</summary>
  [Component(Order = 1000)]
  public class EntitiesExport : IExportDataExtension
  {
    private static EntitiesExport HOPUJmELGwY0Fq5dOi0E;

    private int Portion => EleWise.ELMA.SR.GetSetting<int>((string) EntitiesExport.uXbADOELQ6q4rB5vUqbl(-2107978722 ^ -2107652044), 100);

    /// <inheritdoc />
    public virtual bool CheckMetadata(IMetadata metadata) => metadata is ClassMetadata;

    /// <inheritdoc />
    public List<ClassMetadata> ExportObjects(
      XmlWriter writer,
      ClassMetadata metadata,
      List<DeployLogMessage> messages,
      List<ClassMetadata> wasExported,
      List<string> fileUids)
    {
      if (wasExported == null)
        wasExported = new List<ClassMetadata>();
      IMetadataRuntimeService mdRtServise = Locator.GetServiceNotNull<IMetadataRuntimeService>();
      IEntityManager entityManager1 = ModelHelper.GetEntityManager(mdRtServise.GetTypeByUid(metadata.Uid, false));
      long num1 = entityManager1.Count();
      int num2 = 0;
      int firstResult = 0;
      IEntityFilter filter1 = this.GetFilter();
      int portion = this.Portion;
      for (; num1 > 0L && (long) firstResult < num1; firstResult = num2 * portion)
      {
        int maxResults = portion;
        if ((long) (firstResult + portion) > num1)
          maxResults = Convert.ToInt32(num1 - (long) firstResult);
        IEntityManager entityManager2 = entityManager1;
        IEntityFilter filter2 = filter1;
        foreach (object e1 in entityManager2.Find(filter2, new FetchOptions(firstResult, maxResults, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105232708))
        {
          DisableDefaultGroupSorting = true
        }))
        {
          EntityExportObject entityExportObject1 = (EntityExportObject) new EntityExportObject((IEntity) e1).Read();
          Type type = entityExportObject1.Entity.GetType();
          if (!wasExported.Select<ClassMetadata, Type>((Func<ClassMetadata, Type>) (mdC => mdRtServise.GetTypeByUid(mdC.Uid))).Contains<Type>(type))
          {
            writer.WriteStartElement(z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -671847593));
            messages.Add(entityExportObject1.Write(writer, (IMetadata) metadata));
            IEnumerable<IAddEntityToData> extensionPoints = ComponentManager.Current.GetExtensionPoints<IAddEntityToData>();
            if (extensionPoints != null)
            {
              List<IEntity> entityList = new List<IEntity>();
              foreach (IAddEntityToData addEntityToData in extensionPoints)
                entityList.AddRange((IEnumerable<IEntity>) addEntityToData.AddEntities(metadata, e1 as IEntity));
              foreach (IEntity e2 in entityList)
              {
                EntityExportObject entityExportObject2 = (EntityExportObject) new EntityExportObject(e2).Read();
                messages.Add(entityExportObject2.Write(writer));
                fileUids.AddRange((IEnumerable<string>) entityExportObject2.FileUids);
              }
            }
            writer.WriteEndElement();
            fileUids.AddRange((IEnumerable<string>) entityExportObject1.FileUids);
          }
        }
        ++num2;
      }
      wasExported.Add(metadata);
      return wasExported;
    }

    /// <summary>Получить фильтр для выборки данных</summary>
    protected virtual IEntityFilter GetFilter() => (IEntityFilter) null;

    public EntitiesExport()
    {
      EntitiesExport.lqswL4ELC6HFrIBMEJX0();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object uXbADOELQ6q4rB5vUqbl(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool l7qMUxELEisp9FRqmwdl() => EntitiesExport.HOPUJmELGwY0Fq5dOi0E == null;

    internal static EntitiesExport icJHOdELfoksvNEDo988() => EntitiesExport.HOPUJmELGwY0Fq5dOi0E;

    internal static void lqswL4ELC6HFrIBMEJX0() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
