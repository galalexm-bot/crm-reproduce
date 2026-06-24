// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.Components.LinkedObjectsExportCheckingRule
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export.Enums;
using EleWise.ELMA.Deploy.Export.ExtensionPoints;
using EleWise.ELMA.Deploy.Export.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Export.Components
{
  /// <summary>Правило проверки на наличие связанных объектов</summary>
  [Component]
  internal sealed class LinkedObjectsExportCheckingRule : IExportCheckingRule
  {
    /// <summary>Сервис поиска связанных объектов</summary>
    private IFindLinkedObjectService findLinkedObjectService;
    internal static LinkedObjectsExportCheckingRule AqURk7EULNQE5GUi04C2;

    /// <summary>Ctor</summary>
    /// <param name="findLinkedObjectService">Сервис поиска связанных объектов</param>
    public LinkedObjectsExportCheckingRule(IFindLinkedObjectService findLinkedObjectService)
    {
      LinkedObjectsExportCheckingRule.FwsauKEUclfs0brkDyNn();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.findLinkedObjectService = findLinkedObjectService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public IExportCheckingResult Check(IExportCheckingContext context)
    {
      int num1 = 7;
      ExportCheckingMessageType? exportLinkChecking;
      ILinkedExportCheckingContext exportCheckingContext;
      BaseExportCheckingResult result;
      ILinkedExportCheckingContext exportContext;
      while (true)
      {
        switch (num1)
        {
          case 1:
          case 3:
            goto label_3;
          case 2:
            result = new BaseExportCheckingResult();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
            continue;
          case 4:
            ICollection<ILinkedObject> findedObjects = this.findLinkedObjectService.FindLinkedObjects((LinkedObjectsSearchParams) LinkedObjectsExportCheckingRule.aWV1x3EsFQW2w9hP7kEM((object) exportContext)).FindedObjects;
            if (findedObjects == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 1 : 1;
              continue;
            }
            findedObjects.ForEach<ILinkedObject>((Action<ILinkedObject>) (linkedObject =>
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
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    LinkedObjectsExportCheckingRule.\u003C\u003Ec__DisplayClass2_0.TZu6wx8mZNOc8Jk1S39G((object) result, exportContext.DefaultExportLinkChecking.Value, (object) EleWise.ELMA.SR.T((string) LinkedObjectsExportCheckingRule.\u003C\u003Ec__DisplayClass2_0.srJ3ER8mCNx8t4RbhGxO(-1852837372 ^ -1853229056), LinkedObjectsExportCheckingRule.\u003C\u003Ec__DisplayClass2_0.K4H0hB8mvTXnuO6ovG2Y((object) linkedObject)), LinkedObjectsExportCheckingRule.\u003C\u003Ec__DisplayClass2_0.yquPm88m82MhsP1S4sK4((object) linkedObject));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = 3;
            continue;
          case 5:
            if (exportCheckingContext != null)
            {
              num1 = 8;
              continue;
            }
            goto label_3;
          case 6:
            LinkedObjectsExportCheckingRule.CPwticEUzsVEOMksWK4u((object) context, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218946908));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 2 : 0;
            continue;
          case 7:
            num1 = 6;
            continue;
          case 8:
            exportLinkChecking = exportContext.DefaultExportLinkChecking;
            num1 = 9;
            continue;
          case 9:
            if (exportLinkChecking.HasValue)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 4 : 0;
              continue;
            }
            goto label_3;
          default:
            exportContext = exportCheckingContext = context as ILinkedExportCheckingContext;
            num1 = 5;
            continue;
        }
      }
label_3:
      return (IExportCheckingResult) result;
    }

    internal static void FwsauKEUclfs0brkDyNn() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool U25i3NEUUNy4wYGIch4g() => LinkedObjectsExportCheckingRule.AqURk7EULNQE5GUi04C2 == null;

    internal static LinkedObjectsExportCheckingRule fRx5ZkEUsAmZ2qfqa9ee() => LinkedObjectsExportCheckingRule.AqURk7EULNQE5GUi04C2;

    internal static void CPwticEUzsVEOMksWK4u([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object aWV1x3EsFQW2w9hP7kEM([In] object obj0) => (object) ((ILinkedExportCheckingContext) obj0).SearchParams;
  }
}
