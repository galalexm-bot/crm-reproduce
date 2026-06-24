// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.Modules.ModuleHeaderImportSaveActions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.Linq;

namespace EleWise.ELMA.Deploy.Import.Modules
{
  /// <summary>Действия выполняемые при сохранении заголовка модуля</summary>
  [Component]
  internal sealed class ModuleHeaderImportSaveActions : EntityImportSaveActions
  {
    private readonly IEntityManager<ModuleMetadataItemHeader> moduleHeaderManager;
    private static ModuleHeaderImportSaveActions JAexc9EM7CJh82NkNJsc;

    /// <summary>Ctor</summary>
    /// <param name="moduleHeaderManager">Менеджер заголовков модулей</param>
    public ModuleHeaderImportSaveActions(
      IEntityManager<ModuleMetadataItemHeader> moduleHeaderManager)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.moduleHeaderManager = moduleHeaderManager;
    }

    /// <inheritdoc />
    public override bool IsSupported(Guid typeGuid) => typeGuid == ModuleMetadataItemHeader.UID;

    /// <inheritdoc />
    public override void TestRead(ImportTestReadData data, ImportTestReadResult result)
    {
      int num1 = 2;
      while (true)
      {
        TestModuleImportSettings moduleImportSettings;
        string text;
        ImportTestReadResult result1;
        TestModuleImportSettings testModuleImportSettings;
        switch (num1)
        {
          case 1:
            result1 = result;
            num1 = 6;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 1 : 1;
            continue;
          case 3:
            ((IImportSettings) ModuleHeaderImportSaveActions.XfZWU1EMmcCQBeUqQhgw((object) data)).TestResult.Add(new TestImportMessages(TestImportMessagesType.Error, text));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 9 : 10;
            continue;
          case 4:
            testModuleImportSettings.ModuleHeaderUid = new ModuleHeaderImportSaveActions.Tester((XmlReader) ModuleHeaderImportSaveActions.rWUbjQEMMi5N4Wp52klO((object) data), testModuleImportSettings, new Action<TestImportMessagesType, string>(Logger)).Test();
            num1 = 9;
            continue;
          case 5:
            int num2 = (int) ModuleHeaderImportSaveActions.kka9egEMJJjeX3eAD9m4(ModuleHeaderImportSaveActions.rWUbjQEMMi5N4Wp52klO((object) data));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 4 : 4;
            continue;
          case 6:
            testModuleImportSettings = moduleImportSettings = ModuleHeaderImportSaveActions.XfZWU1EMmcCQBeUqQhgw((object) data) as TestModuleImportSettings;
            num1 = 8;
            continue;
          case 7:
            result1.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, text));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 3 : 1;
            continue;
          case 8:
            if (moduleImportSettings != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 4 : 5;
              continue;
            }
            break;
          case 9:
            goto label_3;
          case 10:
            goto label_6;
        }
        text = EleWise.ELMA.SR.T((string) ModuleHeaderImportSaveActions.vuSWONEMyVXubo5LbMTK(993438473 ^ 993160005), ModuleHeaderImportSaveActions.vuSWONEMyVXubo5LbMTK(874012245 ^ 874291035));
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 7 : 7;

        void Logger(TestImportMessagesType messagesType, string message)
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                result1.Messages.Add(new TestImportMessages(messagesType, message));
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
                continue;
              case 2:
                goto label_2;
              default:
                testModuleImportSettings.TestResult.Add(new TestImportMessages(messagesType, message));
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 2;
                continue;
            }
          }
label_2:;
        }
      }
label_3:
      return;
label_6:;
    }

    /// <inheritdoc />
    public override void ExecSaveActions(IEntity entity, Dictionary<string, string> serviceData)
    {
      if (serviceData.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(993438473 ^ 993138617)) && this.moduleHeaderManager.LoadOrNull(entity.GetId()) != null)
        return;
      base.ExecSaveActions(entity, serviceData);
    }

    internal static bool xIkJZTEMxmAUkJ1wLjT4() => ModuleHeaderImportSaveActions.JAexc9EM7CJh82NkNJsc == null;

    internal static ModuleHeaderImportSaveActions s7cUlhEM0xvFjcaHU1FU() => ModuleHeaderImportSaveActions.JAexc9EM7CJh82NkNJsc;

    internal static object XfZWU1EMmcCQBeUqQhgw([In] object obj0) => (object) ((ImportTestReadData) obj0).ConfigImportSettings;

    internal static object vuSWONEMyVXubo5LbMTK(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object rWUbjQEMMi5N4Wp52klO([In] object obj0) => (object) ((ImportTestReadData) obj0).Reader;

    internal static XmlNodeType kka9egEMJJjeX3eAD9m4([In] object obj0) => ((XmlReader) obj0).MoveToContent();

    /// <summary>Класс проверки данных заголовка модуля</summary>
    internal sealed class Tester
    {
      private static readonly string errorStart;
      private readonly Action<TestImportMessagesType, string> logger;
      private readonly XmlReader reader;
      private readonly TestModuleImportSettings settings;
      private static ModuleHeaderImportSaveActions.Tester Jr5b5w84exsSl3hZdV19;

      /// <summary>Ctor</summary>
      /// <param name="reader">Объект для чтения файла импорта</param>
      /// <param name="settings">Настройки импорта</param>
      /// <param name="logger">Логер</param>
      public Tester(
        XmlReader reader,
        TestModuleImportSettings settings,
        Action<TestImportMessagesType, string> logger)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.reader = reader;
        this.settings = settings;
        this.logger = logger;
      }

      /// <summary>Проверка данных заголовка модуля</summary>
      /// <returns>Идентификатор заголовка модуля</returns>
      public Guid? Test()
      {
        if (this.settings.ModuleHeaderUid.HasValue)
        {
          this.LogError(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939697982)));
          return this.settings.ModuleHeaderUid;
        }
        XElement xelement = XElement.Load(this.reader.ReadSubtree()).Descendants().FirstOrDefault<XElement>((Func<XElement, bool>) (e =>
        {
          // ISSUE: reference to a compiler-generated method
          object obj = ModuleHeaderImportSaveActions.Tester.\u003C\u003Ec.br8FPtZePAdEca1LEhDH((object) e);
          // ISSUE: type reference
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          ParameterExpression parameterExpression = (ParameterExpression) ModuleHeaderImportSaveActions.Tester.\u003C\u003Ec.cj5Uw2ZeNTaqMCrPoXCF(ModuleHeaderImportSaveActions.Tester.\u003C\u003Ec.yg3D9vZe1tFIUEcp4Mwv(__typeref (ModuleMetadataItemHeader)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669371371 ^ 1669347679));
          // ISSUE: method reference
          // ISSUE: reference to a compiler-generated method
          // ISSUE: type reference
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          XName xname = (XName) LinqUtils.NameOf<ModuleMetadataItemHeader>(Expression.Lambda<Func<ModuleMetadataItemHeader, object>>((Expression) ModuleHeaderImportSaveActions.Tester.\u003C\u003Ec.MJBk0KZepJCq0ImxVsUP(ModuleHeaderImportSaveActions.Tester.\u003C\u003Ec.Mp4Z1VZe39cLixdIrg76((object) parameterExpression, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ModuleMetadataItemHeader.get_Uid))), ModuleHeaderImportSaveActions.Tester.\u003C\u003Ec.yg3D9vZe1tFIUEcp4Mwv(__typeref (object))), parameterExpression));
          // ISSUE: reference to a compiler-generated method
          return ModuleHeaderImportSaveActions.Tester.\u003C\u003Ec.J2XFo7ZeaDI2ndkhU1EN(obj, (object) xname);
        }));
        Guid result;
        if (xelement != null && Guid.TryParse(xelement.Value, out result))
          return new Guid?(result);
        this.LogError(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108429576)));
        return new Guid?();
      }

      private void LogError(string message)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.logger(TestImportMessagesType.Error, ModuleHeaderImportSaveActions.Tester.errorStart + message);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      static Tester()
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              ModuleHeaderImportSaveActions.Tester.errorStart = (string) ModuleHeaderImportSaveActions.Tester.fPrjDZ84pHDKqV0Pm2gt(ModuleHeaderImportSaveActions.Tester.GI3vtB84336BsXKsxRgA(1461825605 - 1531863589 ^ -69815492));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
              continue;
            case 2:
              ModuleHeaderImportSaveActions.Tester.z2B9DW84NyYXSUjIsPGT();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 1;
              continue;
            default:
              goto label_5;
          }
        }
label_2:
        return;
label_5:;
      }

      internal static bool JnIUhB84PhEWuVrcw4mF() => ModuleHeaderImportSaveActions.Tester.Jr5b5w84exsSl3hZdV19 == null;

      internal static ModuleHeaderImportSaveActions.Tester mGeBTp841EbMy4iYmmnm() => ModuleHeaderImportSaveActions.Tester.Jr5b5w84exsSl3hZdV19;

      internal static void z2B9DW84NyYXSUjIsPGT() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static object GI3vtB84336BsXKsxRgA(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object fPrjDZ84pHDKqV0Pm2gt([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);
    }
  }
}
