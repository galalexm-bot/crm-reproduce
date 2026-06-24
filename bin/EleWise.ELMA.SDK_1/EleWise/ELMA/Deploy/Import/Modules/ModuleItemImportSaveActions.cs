// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.Modules.ModuleItemImportSaveActions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
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
  /// <summary>Действия выполняемые при сохранении модуля</summary>
  [Component]
  internal sealed class ModuleItemImportSaveActions : EntityImportSaveActions
  {
    private static ILogger defaultLogger;
    private readonly IModuleMetadataLoader moduleMetadataLoader;
    private readonly IModulePublishDataProvider modulePublishDataProvider;
    private readonly ITagService tagService;
    private readonly ISessionProvider sessionProvider;
    internal static ModuleItemImportSaveActions kuxwdlEJbOa01BZYMwgq;

    /// <summary>Ctor</summary>
    /// <param name="moduleMetadataLoader">Загрузчик метаданных модулей</param>
    /// <param name="modulePublishDataProvider">Сервис проверки данных для публикации</param>
    /// <param name="tagService">Сервис валидации тегов</param>
    /// <param name="sessionProvider">Провайдер сессий</param>
    public ModuleItemImportSaveActions(
      IModuleMetadataLoader moduleMetadataLoader,
      IModulePublishDataProvider modulePublishDataProvider,
      ITagService tagService,
      ISessionProvider sessionProvider)
    {
      ModuleItemImportSaveActions.wQ1I5kEJE0h2aeYQCCjy();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
        num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.sessionProvider = sessionProvider;
            num = 3;
            continue;
          case 2:
            this.tagService = tagService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_3;
          case 4:
            this.moduleMetadataLoader = moduleMetadataLoader;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
            continue;
          default:
            this.modulePublishDataProvider = modulePublishDataProvider;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 2;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public override bool IsSupported(Guid typeGuid) => typeGuid == ModuleItemImportSaveActions.DneLHHEJf7MSD7mF2Jrv();

    /// <inheritdoc />
    public override void TestRead(ImportTestReadData data, ImportTestReadResult result)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        TestModuleImportSettings moduleImportSettings;
        ImportTestReadResult result1;
        TestModuleImportSettings testModuleImportSettings;
        while (true)
        {
          switch (num2)
          {
            case 1:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_9;
            case 3:
              result1.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) ModuleItemImportSaveActions.xixuUrEJQA0DUgTDOpN2(-542721635 ^ -543000111), ModuleItemImportSaveActions.xixuUrEJQA0DUgTDOpN2(-1824388195 ^ -1824077165))));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 2 : 2;
              continue;
            case 4:
              goto label_13;
            case 5:
              ModuleItemImportSaveActions importSaveActions = this;
              num2 = 4;
              continue;

              bool CheckName(Guid moduleUid, string name)
              {
                int num = 2;
                Guid guid;
                // ISSUE: variable of a compiler-generated type
                ModuleItemImportSaveActions.\u003C\u003Ec__DisplayClass7_1 cDisplayClass71;
                while (true)
                {
                  switch (num)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated field
                      cDisplayClass71.name = name;
                      num = 5;
                      continue;
                    case 2:
                      // ISSUE: object of a compiler-generated type is created
                      cDisplayClass71 = new ModuleItemImportSaveActions.\u003C\u003Ec__DisplayClass7_1();
                      num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 1 : 0;
                      continue;
                    case 3:
                      // ISSUE: reference to a compiler-generated method
                      if (ModuleItemImportSaveActions.\u003C\u003Ec__DisplayClass7_0.tOedAP86Wx2CxkINyLuQ(guid, Guid.Empty))
                      {
                        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 2 : 4;
                        continue;
                      }
                      goto label_2;
                    case 4:
                      goto label_3;
                    case 5:
                      IQueryable<ModuleMetadataItemHeader> source1 = importSaveActions.Session.Query<ModuleMetadataItemHeader>();
                      // ISSUE: type reference
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      ParameterExpression parameterExpression1 = (ParameterExpression) ModuleItemImportSaveActions.\u003C\u003Ec__DisplayClass7_0.OpAdj984LurLgi2Y7hvE(ModuleItemImportSaveActions.\u003C\u003Ec__DisplayClass7_0.PXEUsy84YYCb4udtC3MA(__typeref (ModuleMetadataItemHeader)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867784456));
                      // ISSUE: method reference
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: type reference
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: field reference
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      Expression<Func<ModuleMetadataItemHeader, bool>> predicate = Expression.Lambda<Func<ModuleMetadataItemHeader, bool>>((Expression) ModuleItemImportSaveActions.\u003C\u003Ec__DisplayClass7_0.kKkmqn84zu5PXh32VHSv((object) Expression.Property((Expression) parameterExpression1, (MethodInfo) ModuleItemImportSaveActions.\u003C\u003Ec__DisplayClass7_0.xFqJVY84UnkpcRaG4C67(__methodref (ModuleMetadataItemHeader.get_Name))), ModuleItemImportSaveActions.\u003C\u003Ec__DisplayClass7_0.pndcoI84cgFxVHAHedv4((object) Expression.Constant((object) cDisplayClass71, ModuleItemImportSaveActions.\u003C\u003Ec__DisplayClass7_0.PXEUsy84YYCb4udtC3MA(__typeref (ModuleItemImportSaveActions.\u003C\u003Ec__DisplayClass7_1))), ModuleItemImportSaveActions.\u003C\u003Ec__DisplayClass7_0.XBtKE384sT07pgyAAjYx(__fieldref (ModuleItemImportSaveActions.\u003C\u003Ec__DisplayClass7_1.name)))), parameterExpression1);
                      IQueryable<ModuleMetadataItemHeader> source2 = source1.Where<ModuleMetadataItemHeader>(predicate);
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      ParameterExpression parameterExpression2 = (ParameterExpression) ModuleItemImportSaveActions.\u003C\u003Ec__DisplayClass7_0.OpAdj984LurLgi2Y7hvE(typeof (ModuleMetadataItemHeader), ModuleItemImportSaveActions.\u003C\u003Ec__DisplayClass7_0.zHbRTv86FURHGh6EAIxx(~-397266137 ^ 397238380));
                      // ISSUE: method reference
                      // ISSUE: reference to a compiler-generated method
                      Expression<Func<ModuleMetadataItemHeader, Guid>> selector = Expression.Lambda<Func<ModuleMetadataItemHeader, Guid>>((Expression) ModuleItemImportSaveActions.\u003C\u003Ec__DisplayClass7_0.FeYw0E86BSsNcUM1bh6f((object) parameterExpression2, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ModuleMetadataItemHeader.get_Uid))), parameterExpression2);
                      guid = source2.Select<ModuleMetadataItemHeader, Guid>(selector).FirstOrDefault<Guid>();
                      num = 3;
                      continue;
                    default:
                      goto label_2;
                  }
                }
label_2:
                // ISSUE: reference to a compiler-generated method
                return ModuleItemImportSaveActions.\u003C\u003Ec__DisplayClass7_0.tOedAP86Wx2CxkINyLuQ(guid, moduleUid);
label_3:
                return true;
              }
            case 6:
              if (moduleImportSettings == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 2 : 3;
                continue;
              }
              int num3 = (int) ModuleItemImportSaveActions.SFvceYEJvbFet49kq0gN(ModuleItemImportSaveActions.Vo3a1NEJCYuFNdCFpBW9((object) data));
              num2 = 7;
              continue;
            case 7:
              ModuleItemImportSaveActions.QAUuQbEJ87qCmxrceHJF((object) testModuleImportSettings, (object) new ModuleItemImportSaveActions.Tester((XmlReader) ModuleItemImportSaveActions.Vo3a1NEJCYuFNdCFpBW9((object) data), testModuleImportSettings, this.moduleMetadataLoader, this.modulePublishDataProvider, this.tagService, new Action<TestImportMessagesType, string>(Logger), new Func<string, ModuleInfoMetadata>(Deserializer), new Func<Guid, string, bool>(CheckName)).Test((IEnumerable<ModuleVersion>) testModuleImportSettings.ModuleMetadataContext));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 8 : 3;
              continue;
            case 8:
              goto label_3;
            default:
              result1 = result;
              num2 = 5;
              continue;
          }
        }
label_13:
        IConfigImportSettings configImportSettings = data?.ConfigImportSettings;
        testModuleImportSettings = moduleImportSettings = configImportSettings as TestModuleImportSettings;
        num1 = 6;

        void Logger(TestImportMessagesType messagesType, string message)
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                result1.Messages.Add(new TestImportMessages(messagesType, message));
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
                continue;
              case 2:
                goto label_2;
              default:
                testModuleImportSettings.TestResult.Add(new TestImportMessages(messagesType, message));
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 2;
                continue;
            }
          }
label_2:;
        }
      }
label_9:
      return;
label_3:

      ModuleInfoMetadata Deserializer(string metadata) => ClassSerializationHelper.DeserializeObjectByXml<ModuleInfoMetadata>(metadata);
    }

    private ISession Session => this.sessionProvider.GetSession(string.Empty);

    static ModuleItemImportSaveActions()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ModuleItemImportSaveActions.defaultLogger = Logger.Log;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static void wQ1I5kEJE0h2aeYQCCjy() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool YGtKPJEJhJAfEaxpVRpf() => ModuleItemImportSaveActions.kuxwdlEJbOa01BZYMwgq == null;

    internal static ModuleItemImportSaveActions hLdv5TEJGG5IHlGEO9bw() => ModuleItemImportSaveActions.kuxwdlEJbOa01BZYMwgq;

    internal static Guid DneLHHEJf7MSD7mF2Jrv() => ModuleMetadataItem.UID;

    internal static object xixuUrEJQA0DUgTDOpN2(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object Vo3a1NEJCYuFNdCFpBW9([In] object obj0) => (object) ((ImportTestReadData) obj0).Reader;

    internal static XmlNodeType SFvceYEJvbFet49kq0gN([In] object obj0) => ((XmlReader) obj0).MoveToContent();

    internal static void QAUuQbEJ87qCmxrceHJF([In] object obj0, [In] object obj1) => ((TestModuleImportSettings) obj0).ModuleMetadata = (ModuleInfoMetadata) obj1;

    /// <summary>Класс проверки данных заголовка модуля</summary>
    internal sealed class Tester
    {
      private static readonly string errorStart;
      private readonly Func<string, ModuleInfoMetadata> deserializer;
      private readonly Func<Guid, string, bool> nameChecker;
      private readonly Action<TestImportMessagesType, string> logger;
      private readonly IModulePublishDataProvider modulePublishDataProvider;
      private readonly ITagService tagService;
      private readonly XmlReader reader;
      private readonly TestModuleImportSettings settings;
      private readonly IModuleMetadataLoader moduleMetadataLoader;
      internal static ModuleItemImportSaveActions.Tester cH6ve38447FjMj6XQ8Sa;

      /// <summary>Ctor</summary>
      /// <param name="reader">Объект для чтения файла импорта</param>
      /// <param name="settings">Настройки импорта</param>
      /// <param name="moduleMetadataLoader">Загрузчик метаданных модулей</param>
      /// <param name="modulePublishDataProvider">Сервис проверки метаданных модуля</param>
      /// <param name="tagService">Сервис валидации тегов</param>
      /// <param name="logger">Логер</param>
      /// <param name="deserializer">Функция для десериализации метаданных модуля</param>
      /// <param name="nameChecker">Функция проверки имени на совпадение с существующими модулями</param>
      public Tester(
        XmlReader reader,
        TestModuleImportSettings settings,
        IModuleMetadataLoader moduleMetadataLoader,
        IModulePublishDataProvider modulePublishDataProvider,
        ITagService tagService,
        Action<TestImportMessagesType, string> logger,
        Func<string, ModuleInfoMetadata> deserializer,
        Func<Guid, string, bool> nameChecker)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.reader = reader;
        this.settings = settings;
        this.moduleMetadataLoader = moduleMetadataLoader;
        this.modulePublishDataProvider = modulePublishDataProvider;
        this.tagService = tagService;
        this.logger = logger;
        this.deserializer = deserializer;
        this.nameChecker = nameChecker;
      }

      /// <summary>Проверка данных заголовка модуля</summary>
      /// <param name="moduleVersions">Текущий контекст проверки модулей</param>
      /// <returns>Идентификатор заголовка модуля</returns>
      public ModuleInfoMetadata Test(IEnumerable<ModuleVersion> moduleVersions)
      {
        if (!this.TestTags(this.settings.Manifest))
        {
          this.logger(TestImportMessagesType.Warning, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998239154)));
          this.settings.Incompatible = true;
        }
        Version moduleVersion;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if (Version.TryParse(this.settings.Manifest.Version, out moduleVersion) && this.moduleMetadataLoader.GetModuleVersionHeaders(this.settings.Manifest.ModuleUid).Any<ModuleVersionHeader>((Func<ModuleVersionHeader, bool>) (v => ModuleItemImportSaveActions.Tester.\u003C\u003Ec__DisplayClass10_0.dWUF7fZeHwtkqq3LgsAO(ModuleItemImportSaveActions.Tester.\u003C\u003Ec__DisplayClass10_0.aWNhvUZe6Bylthi3BQW5((object) v), (object) moduleVersion))))
        {
          this.logger(TestImportMessagesType.Warning, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398910328)));
          this.settings.Incompatible = true;
          return (ModuleInfoMetadata) null;
        }
        if (!this.settings.ModuleHeaderUid.HasValue)
        {
          this.LogError(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16408371)));
          return (ModuleInfoMetadata) null;
        }
        if (this.settings.ModuleMetadata != null)
        {
          this.LogError(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2092274397 << 4 ^ 883109106)));
          return this.settings.ModuleMetadata;
        }
        XElement element = XElement.Load(this.reader.ReadSubtree());
        XElement xelement = element.Descendants().FirstOrDefault<XElement>((Func<XElement, bool>) (e =>
        {
          // ISSUE: reference to a compiler-generated method
          object obj = ModuleItemImportSaveActions.Tester.\u003C\u003Ec.U9FM0KZempGioemffQCY((object) e);
          // ISSUE: type reference
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          ParameterExpression parameterExpression = (ParameterExpression) ModuleItemImportSaveActions.Tester.\u003C\u003Ec.NiQGw5ZeJjnA9IvsZTPO(ModuleItemImportSaveActions.Tester.\u003C\u003Ec.u7H9ceZeyY0HYphpbjGw(__typeref (ModuleMetadataItem)), ModuleItemImportSaveActions.Tester.\u003C\u003Ec.j0T4CTZeM0YnKlbZJgDR(-441065788 ^ -2092910478 ^ 1727384066));
          // ISSUE: method reference
          // ISSUE: reference to a compiler-generated method
          XName xname = (XName) LinqUtils.NameOf<ModuleMetadataItem>(Expression.Lambda<Func<ModuleMetadataItem, object>>((Expression) ModuleItemImportSaveActions.Tester.\u003C\u003Ec.iaJGBbZe9mXKMLw7TVRj((object) parameterExpression, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ModuleMetadataItem.get_Header))), parameterExpression));
          // ISSUE: reference to a compiler-generated method
          return ModuleItemImportSaveActions.Tester.\u003C\u003Ec.dfNAPTZedpr277tr9fMC(obj, (object) xname);
        }));
        Guid result;
        if (xelement == null || !Guid.TryParse(xelement.Value, out result))
        {
          this.LogError(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123859274)));
          return (ModuleInfoMetadata) null;
        }
        Guid? moduleHeaderUid = this.settings.ModuleHeaderUid;
        Guid guid = result;
        if ((moduleHeaderUid.HasValue ? (moduleHeaderUid.HasValue ? (moduleHeaderUid.GetValueOrDefault() != guid ? 1 : 0) : 0) : 1) != 0)
        {
          this.LogError(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951257394)));
          return (ModuleInfoMetadata) null;
        }
        ModuleInfoMetadata moduleMetadata;
        try
        {
          moduleMetadata = this.GetModuleMetadata(result, element);
        }
        catch (InvalidOperationException ex)
        {
          this.LogError(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1304605005 ^ 1304907475), (object) ex.Message));
          return (ModuleInfoMetadata) null;
        }
        catch (Exception ex)
        {
          this.LogError(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1486995382), (object) ex.Message));
          ModuleItemImportSaveActions.defaultLogger.Log(EleWise.ELMA.Logging.LogLevel.Error, (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1322957500)), ex);
          return (ModuleInfoMetadata) null;
        }
        if (moduleMetadata.Name != this.settings.Manifest.Id)
        {
          this.LogError(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 1867247893), (object) moduleMetadata.Name, (object) this.settings.Manifest.Id));
          return (ModuleInfoMetadata) null;
        }
        if (!this.nameChecker(moduleMetadata.Uid, moduleMetadata.Name))
        {
          this.LogError(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1838055659)));
          return (ModuleInfoMetadata) null;
        }
        try
        {
          ModuleVersion defaultModuleVersion = this.moduleMetadataLoader.GetDefaultModuleVersion(result);
          if (defaultModuleVersion != null)
          {
            if (defaultModuleVersion.Metadata.Name != moduleMetadata.Name)
            {
              this.LogError(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909570699), (object) defaultModuleVersion.Metadata.Name));
              return (ModuleInfoMetadata) null;
            }
          }
        }
        catch (ModuleNotFoundException ex)
        {
        }
        if (moduleMetadata.Dependency == null)
        {
          this.LogError(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479369178)));
          return (ModuleInfoMetadata) null;
        }
        if (this.settings.Incompatible)
          return moduleMetadata;
        try
        {
          this.modulePublishDataProvider.PrepareData(moduleMetadata, moduleVersions);
        }
        catch (ModuleNotFoundException ex)
        {
          if (ex.DisabledReason != ModuleDisabledReason.Unknown || !ModuleItemImportSaveActions.Tester.StrictModuleAvailabilityCheck)
          {
            this.logger(TestImportMessagesType.Warning, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 132782025)));
            this.settings.Incompatible = true;
            return moduleMetadata;
          }
          this.LogError(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -607047124), (object) ex.Message, (object) ex.AdditionalInformation));
          return (ModuleInfoMetadata) null;
        }
        return moduleMetadata;
      }

      private ModuleInfoMetadata GetModuleMetadata(Guid moduleUid, XElement element)
      {
        int num = 1;
        Guid moduleUid1;
        while (true)
        {
          switch (num)
          {
            case 1:
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_3;
            default:
              moduleUid1 = moduleUid;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 2 : 2;
              continue;
          }
        }
label_3:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return element.Elements((XName) (string) ModuleItemImportSaveActions.Tester.wWqd6e84AceRHEOw5s1x(-345420348 ^ -345375994)).Select<XElement, ModuleInfoMetadata>(new Func<XElement, ModuleInfoMetadata>(this.ReadMetadataNode)).Single<ModuleInfoMetadata>((Func<ModuleInfoMetadata, bool>) (m => ModuleItemImportSaveActions.Tester.\u003C\u003Ec__DisplayClass11_0.AMx1RnZeYrbhY6gXwjkb(ModuleItemImportSaveActions.Tester.\u003C\u003Ec__DisplayClass11_0.lTm2OyZejcjFwsJdj2Mw((object) m), moduleUid1)));
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
              this.logger(TestImportMessagesType.Error, (string) ModuleItemImportSaveActions.Tester.wHZhSS847mANpuMBX164((object) ModuleItemImportSaveActions.Tester.errorStart, (object) message));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      /// <summary>Прочитать метаданные из узла.</summary>
      /// <remarks>
      /// Предполагается, что метаданные в особом формате упакованы в блок CDATA.
      /// Содержимое блока: сначала полное имя типа, затем уже XML сериализованные метаданные.
      /// </remarks>
      /// <param name="element">Элемент XML</param>
      /// <returns>Метаданные</returns>
      private ModuleInfoMetadata ReadMetadataNode(XElement element)
      {
        int num1 = 11;
        string str;
        while (true)
        {
          int num2 = num1;
          Type type;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_13;
              case 2:
                goto label_6;
              case 3:
                if (!ModuleItemImportSaveActions.Tester.AeJ4T984yYLdFvnpQ9bC(type, (Type) null))
                {
                  num2 = 4;
                  continue;
                }
                goto label_12;
              case 4:
                if (!ModuleItemImportSaveActions.Tester.fD9FMP84MIkEfP9vQ2xK(type, typeof (ModuleInfoMetadata)))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
                  continue;
                }
                goto case 7;
              case 5:
                goto label_12;
              case 6:
                goto label_5;
              case 7:
                this.LogError(EleWise.ELMA.SR.T((string) ModuleItemImportSaveActions.Tester.wWqd6e84AceRHEOw5s1x(-1998538950 ^ -1998146760), (object) str));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 0;
                continue;
              case 8:
                this.LogError(EleWise.ELMA.SR.T((string) ModuleItemImportSaveActions.Tester.wWqd6e84AceRHEOw5s1x(1142330761 ^ 1541959139 ^ 536411174), (object) str));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 6 : 0;
                continue;
              case 9:
                goto label_16;
              case 10:
                type = ModuleItemImportSaveActions.Tester.j3rNHu84mIlJIkkQ2ykE(ModuleItemImportSaveActions.Tester.RTUk3W8404o92Wds782R((object) str, 0, ModuleItemImportSaveActions.Tester.BkgONJ84xHwU2DHTpgNY((object) str, ModuleItemImportSaveActions.Tester.wWqd6e84AceRHEOw5s1x(--1333735954 ^ 1333755348))));
                num2 = 3;
                continue;
              case 11:
                str = element.Value;
                num2 = 10;
                continue;
              case 12:
                if (!ModuleItemImportSaveActions.Tester.Exmrcp849qKRIa0cE2C0((object) str))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 2 : 2;
                  continue;
                }
                goto case 8;
              default:
                str = (string) ModuleItemImportSaveActions.Tester.Od796p84J14PiVLfgoqv((object) str, 0, str.IndexOf((string) ModuleItemImportSaveActions.Tester.wWqd6e84AceRHEOw5s1x(-35995181 ^ -36008427)));
                num2 = 12;
                continue;
            }
          }
label_12:
          this.LogError(EleWise.ELMA.SR.T((string) ModuleItemImportSaveActions.Tester.wWqd6e84AceRHEOw5s1x(712480695 ^ 712086575), (object) str));
          num1 = 9;
        }
label_5:
        return (ModuleInfoMetadata) null;
label_6:
        return this.deserializer(str);
label_13:
        return (ModuleInfoMetadata) null;
label_16:
        return (ModuleInfoMetadata) null;
      }

      private bool TestTags(ElmaStoreComponentManifest manifest)
      {
        int num1 = 2;
        bool flag;
        List<TestImportMessages> messages;
        List<TestImportMessages>.Enumerator enumerator;
        while (true)
        {
          switch (num1)
          {
            case 1:
              enumerator = messages.GetEnumerator();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
              continue;
            case 2:
              flag = this.tagService.ValidateTags(manifest, out messages);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 0;
              continue;
            case 3:
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return flag;
label_5:
        try
        {
label_10:
          if (enumerator.MoveNext())
            goto label_8;
          else
            goto label_11;
label_7:
          TestImportMessages current;
          int num2;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_2;
              case 2:
                this.logger(TestImportMessagesType.InfoCommon, (string) ModuleItemImportSaveActions.Tester.j8G7Xa84d2GSjwBmWsSv((object) current));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
                continue;
              case 3:
                goto label_8;
              default:
                goto label_10;
            }
          }
label_8:
          current = enumerator.Current;
          num2 = 2;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
          {
            num2 = 0;
            goto label_7;
          }
          else
            goto label_7;
label_11:
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 1;
          goto label_7;
        }
        finally
        {
          enumerator.Dispose();
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
            num3 = 0;
          switch (num3)
          {
            default:
          }
        }
      }

      private static bool StrictModuleAvailabilityCheck => EleWise.ELMA.SR.GetSetting<bool>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178340342), true);

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
              ModuleItemImportSaveActions.Tester.errorStart = (string) ModuleItemImportSaveActions.Tester.ncVx5k84lTW9aDb5nt5T((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1319452732 ^ 1319322932));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
              continue;
            case 2:
              TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 1 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_2:
        return;
label_5:;
      }

      internal static object wWqd6e84AceRHEOw5s1x(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static bool x964ob846ojrgn2Jn7lV() => ModuleItemImportSaveActions.Tester.cH6ve38447FjMj6XQ8Sa == null;

      internal static ModuleItemImportSaveActions.Tester mUaJN684HE1Hc3SDcjRx() => ModuleItemImportSaveActions.Tester.cH6ve38447FjMj6XQ8Sa;

      internal static object wHZhSS847mANpuMBX164([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

      internal static int BkgONJ84xHwU2DHTpgNY([In] object obj0, [In] object obj1) => ((string) obj0).IndexOf((string) obj1);

      internal static object RTUk3W8404o92Wds782R([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

      internal static Type j3rNHu84mIlJIkkQ2ykE([In] object obj0) => Type.GetType((string) obj0);

      internal static bool AeJ4T984yYLdFvnpQ9bC([In] Type obj0, [In] Type obj1) => obj0 == obj1;

      internal static bool fD9FMP84MIkEfP9vQ2xK([In] Type obj0, [In] Type obj1) => obj0 != obj1;

      internal static object Od796p84J14PiVLfgoqv([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Remove(obj1, obj2);

      internal static bool Exmrcp849qKRIa0cE2C0([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

      internal static object j8G7Xa84d2GSjwBmWsSv([In] object obj0) => (object) ((TestImportMessages) obj0).Text;

      internal static object ncVx5k84lTW9aDb5nt5T([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);
    }
  }
}
