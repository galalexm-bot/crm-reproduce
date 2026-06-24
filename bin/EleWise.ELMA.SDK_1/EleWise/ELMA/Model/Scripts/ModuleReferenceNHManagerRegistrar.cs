// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.ModuleReferenceNHManagerRegistrar
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Autofac;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Managers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>Регистратор менеджера для ссылок метаданных на модули</summary>
  [Component]
  internal sealed class ModuleReferenceNHManagerRegistrar : INHManagerRegistrar
  {
    internal static ModuleReferenceNHManagerRegistrar VWHNXRbVwWOESmq4GEVg;

    /// <inheritdoc />
    public void Register(NHManagerRegisterParams parameters)
    {
      int num1 = 2;
      IStartInformation startInformation;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_12;
          case 1:
            goto label_2;
          case 2:
            startInformation = StartInformation.Operation(98.0, (string) ModuleReferenceNHManagerRegistrar.qa456ybVAfRska3Cx15O(ModuleReferenceNHManagerRegistrar.Uhu27GbVHIIrvPlaTiVC(-218496594 ^ -218580264)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 1 : 1;
            continue;
          default:
            goto label_10;
        }
      }
label_12:
      return;
label_10:
      return;
label_2:
      try
      {
        // ISSUE: type reference
        ((ContainerBuilder) ModuleReferenceNHManagerRegistrar.NPjnAebV7ySj0LsLsHtW((object) parameters)).RegisterNHManager(ModuleReferenceNHManagerRegistrar.NZBjOWbVxjAbVRS3t4im(__typeref (ModuleReferenceManager))).As<ModuleReferenceManager, IModuleReferenceManager>().SingleInstance();
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_6;
            default:
              parameters.Add<ModuleReferenceNHMap>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 1;
              continue;
          }
        }
label_6:;
      }
      finally
      {
        int num3;
        if (startInformation == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 1 : 1;
        else
          goto label_11;
label_9:
        switch (num3)
        {
          case 1:
          case 2:
        }
label_11:
        ModuleReferenceNHManagerRegistrar.BOlJxCbV0xsUpBKPYe9F((object) startInformation);
        num3 = 2;
        goto label_9;
      }
    }

    public ModuleReferenceNHManagerRegistrar()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object Uhu27GbVHIIrvPlaTiVC(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object qa456ybVAfRska3Cx15O([In] object obj0) => (object) EleWise.ELMA.SR.M((string) obj0);

    internal static object NPjnAebV7ySj0LsLsHtW([In] object obj0) => (object) ((NHManagerRegisterParams) obj0).Builder;

    internal static Type NZBjOWbVxjAbVRS3t4im([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static void BOlJxCbV0xsUpBKPYe9F([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool Jl8YBQbV4M9m44h1qYyF() => ModuleReferenceNHManagerRegistrar.VWHNXRbVwWOESmq4GEVg == null;

    internal static ModuleReferenceNHManagerRegistrar tkUJXCbV62cMdQQomvDH() => ModuleReferenceNHManagerRegistrar.VWHNXRbVwWOESmq4GEVg;
  }
}
