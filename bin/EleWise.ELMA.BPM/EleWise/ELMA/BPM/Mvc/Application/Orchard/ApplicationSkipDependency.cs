// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPM.Mvc.Application.Orchard.ApplicationSkipDependency
// Assembly: EleWise.ELMA.BPM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EE1B80B5-F464-4FFF-85CF-6A69B66F676D
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.BPM.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.BPM.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Orchard.Enviroment.ShellBuilders;
using j3AmrhgkCleVTGdEwA;
using Orchard.Environment.ShellBuilders.Models;
using Orchard.Security.Providers;
using Orchard.UI.Navigation;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.BPM.Mvc.Application.Orchard
{
  [Component]
  public class ApplicationSkipDependency : ISkipDependency
  {
    internal static ApplicationSkipDependency qg6pSrifu53BYH8mpT5;

    public bool Skip(DependencyBlueprint dependencyBlueprint)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            goto label_5;
          case 3:
            // ISSUE: type reference
            if (!ApplicationSkipDependency.IjPiiXi2JymhD8ccB02(dependencyBlueprint.Type, ApplicationSkipDependency.zoREc4itu6GTQ6D33U4(__typeref (FormsAuthenticationService))))
            {
              // ISSUE: type reference
              if (!ApplicationSkipDependency.IjPiiXi2JymhD8ccB02(ApplicationSkipDependency.vsUj2niKx3NLC1sQWo0((object) dependencyBlueprint), ApplicationSkipDependency.zoREc4itu6GTQ6D33U4(__typeref (MenuFilter))))
              {
                if (ApplicationSkipDependency.ihDBqQiS6N9c009yVqa((object) ApplicationSkipDependency.vsUj2niKx3NLC1sQWo0((object) dependencyBlueprint).FullName, ApplicationSkipDependency.I0gr4QivT6xUeCL8lMv(-1903117678 << 4 ^ -385111448)))
                {
                  num = <Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_64676479b67d49ce9c1e5b9e46e65697 == 0 ? 0 : 0;
                  continue;
                }
                goto label_11;
              }
              else
              {
                num = <Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_e3c5f5fc1e564390911b44e74f171948 == 0 ? 1 : 1;
                continue;
              }
            }
            else
            {
              num = 2;
              continue;
            }
          default:
            goto label_10;
        }
      }
label_2:
      return true;
label_5:
      return true;
label_10:
      return true;
label_11:
      return false;
    }

    public ApplicationSkipDependency()
    {
      TKW1L3mlUyvXmg29jA.RWk58XigPN();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (<Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_4857ff0c85a64b17b36a438afd6598b1 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type zoREc4itu6GTQ6D33U4([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool IjPiiXi2JymhD8ccB02([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static Type vsUj2niKx3NLC1sQWo0([In] object obj0) => ((ShellBlueprintItem) obj0).Type;

    internal static object I0gr4QivT6xUeCL8lMv(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool ihDBqQiS6N9c009yVqa([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static bool cN8goxi7jGvWDOtdlJT() => ApplicationSkipDependency.qg6pSrifu53BYH8mpT5 == null;

    internal static ApplicationSkipDependency pwbgsFinVC7UDKCII2x() => ApplicationSkipDependency.qg6pSrifu53BYH8mpT5;
  }
}
