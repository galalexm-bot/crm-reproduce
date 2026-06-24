// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Projects.ModelProject
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using Microsoft.Build.Construction;
using Microsoft.Build.Evaluation;
using Microsoft.Build.Framework;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml;

namespace EleWise.ELMA.Model.Projects
{
  /// <summary>Проект метаданных моделей</summary>
  public class ModelProject : IDisposable
  {
    private string prjDir;
    private string prjName;
    private string prjFileName;
    private Project prj;
    private ProjectItemGroupElement prjGroupRefs;
    private ProjectItemGroupElement prjGroupCompile;
    private ProjectItemGroupElement prjGroupNone;
    private List<ModelProjectItem> items;
    private List<ModelProjectReference> references;
    internal static ModelProject jdKIKTW5NuAwfBSoMrCi;

    /// <summary>
    /// Создать объект проекта. Если файл проекта существует, то он загружается, если нет - создается новый
    /// </summary>
    /// <param name="projectFileName">Имя файла проекта</param>
    public ModelProject(string projectFileName)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.items = new List<ModelProjectItem>();
      this.references = new List<ModelProjectReference>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!ModelProject.qRfbg0W5DWlCLDC2o6KW((object) projectFileName))
            {
              this.CreateNew();
              num = 3;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
            continue;
          case 2:
            this.ProjectFileName = projectFileName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_4;
          case 4:
            ModelProject.ev3laVW5aU842l81P4Wd((object) projectFileName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082266548));
            num = 2;
            continue;
          case 5:
            goto label_2;
          default:
            this.Load();
            num = 5;
            continue;
        }
      }
label_4:
      return;
label_2:;
    }

    /// <summary>Загрузить проект</summary>
    public void Load()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (ModelProject.qRfbg0W5DWlCLDC2o6KW((object) this.ProjectFileName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          case 2:
            goto label_2;
          case 3:
            this.ParseProject();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 2 : 1;
            continue;
          default:
            this.prj = new Project(this.ProjectFileName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 3 : 3;
            continue;
        }
      }
label_2:
      return;
label_7:;
    }

    /// <summary>Полное имя файла проекта</summary>
    public string ProjectFileName
    {
      get => this.prjFileName;
      set
      {
        int num1 = 1;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                this.prjFileName = value;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
                continue;
              case 2:
                goto label_4;
              case 3:
                goto label_3;
              default:
                this.prjDir = (string) ModelProject.UFBV7oW5tw7ZRSd0QgPG((object) this.prjFileName);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 2;
                continue;
            }
          }
label_4:
          this.prjName = (string) ModelProject.w1kZOfW5wrJVW85KHYt4((object) this.prjFileName);
          num1 = 3;
        }
label_3:;
      }
    }

    /// <summary>Имя проекта</summary>
    public string Name => this.prjName;

    /// <summary>Полное имя построенного бинарного файла</summary>
    public string CompiledFileName => (string) ModelProject.CcBgoYW5H7xgTiHRCOge((object) this.prjDir, ModelProject.Sgf5RiW54HcdlDS046cf(-1998538950 ^ -1998484728), ModelProject.Sgf5RiW54HcdlDS046cf(-35995181 ^ -36110563), ModelProject.BQ9KSXW566GdlpwvJKhP((object) this.prjName, ModelProject.Sgf5RiW54HcdlDS046cf(-1380439818 << 3 ^ 1841300234)));

    /// <summary>Сохранить проект</summary>
    public void Save()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.GenerateTemplates(new Dictionary<string, string>()
            {
              {
                (string) ModelProject.Sgf5RiW54HcdlDS046cf(1052221104 - 768835541 ^ 283516935),
                (string) ModelProject.Sgf5RiW54HcdlDS046cf(1642859704 ^ 1643000748)
              }
            });
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
            continue;
          case 2:
            ModelProject.cLt60KW5ALQZFBTDsjmH((object) this.prj, (object) this.prjFileName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 1;
            continue;
          case 3:
            this.CheckProjectFileNameDefined();
            num = 2;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    /// <summary>Построить сборку</summary>
    /// <param name="buildLogger">Логгер событий сборки</param>
    /// <returns>Собрана или нет</returns>
    public bool Build(ILogger buildLogger) => this.prj.Build(buildLogger);

    /// <summary>Добавить новый элемент</summary>
    /// <param name="metadata">Метаданные</param>
    /// <returns>Элемент проекта</returns>
    public ModelProjectItem AddItem(IMetadata metadata) => this.AddItem(metadata, (Action<string>) null, (Action<string>) null);

    /// <summary>Добавить новый элемент</summary>
    /// <param name="metadata">Метаданные</param>
    /// <param name="fileAddedAction">Действие после добавление файла</param>
    /// <param name="fileRemovedAction">Действие после удаления файла</param>
    /// <returns>Элемент проекта</returns>
    public ModelProjectItem AddItem(
      IMetadata metadata,
      Action<string> fileAddedAction = null,
      Action<string> fileRemovedAction = null)
    {
      using (new MetadataServiceContext((IMetadataService) new ExtendedMetadataService(MetadataServiceContext.Service, (IEnumerable<IMetadata>) new IMetadata[1]
      {
        metadata
      })))
        return this.GetOrCreateProjectItem(metadata, true, fileAddedAction);
    }

    /// <summary>Добавить ссылку на сборку</summary>
    /// <param name="name">Имя сборки</param>
    /// <param name="hintPath">Путь до сборки</param>
    /// <returns></returns>
    public ModelProjectReference AddReference(string name, string hintPath = null)
    {
      int num = 7;
      Dictionary<string, string> metadata;
      ModelProjectReference projectReference;
      ProjectItemElement projectItemElement;
      while (true)
      {
        switch (num)
        {
          case 1:
            projectReference = new ModelProjectReference(this, projectItemElement);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_8;
          case 3:
            metadata[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1380439818 << 3 ^ 1841527036)] = hintPath;
            num = 4;
            continue;
          case 4:
          case 5:
            projectItemElement = this.prjGroupRefs.AddItem((string) ModelProject.Sgf5RiW54HcdlDS046cf(1574260816 ^ 1574229288), name, (IEnumerable<KeyValuePair<string, string>>) metadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 1;
            continue;
          case 6:
            if (ModelProject.VgIifLW57TZ8EPN1iLPE((object) hintPath))
            {
              num = 5;
              continue;
            }
            goto case 3;
          case 7:
            metadata = new Dictionary<string, string>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 5 : 6;
            continue;
          default:
            this.references.Add(projectReference);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 1 : 2;
            continue;
        }
      }
label_8:
      return projectReference;
    }

    /// <summary>
    /// Создать элементы проекта из списка метаданных (без сохранения элементов в файл)
    /// </summary>
    /// <param name="metadataList">Список метаданных</param>
    /// <returns>Список созданных элементов проекта</returns>
    public IEnumerable<ModelProjectItem> CreateItems(IEnumerable<IMetadata> metadataList)
    {
      List<ModelProjectItem> items = new List<ModelProjectItem>();
      foreach (IMetadata metadata in metadataList)
        items.Add(this.GetOrCreateProjectItem(metadata, false));
      return (IEnumerable<ModelProjectItem>) items;
    }

    /// <summary>Элементы проекта</summary>
    public List<ModelProjectItem> Items => this.items;

    /// <summary>Ссылки</summary>
    public List<ModelProjectReference> References => this.references;

    /// <summary>Сгенерировать файл AssemblyInfo.cs</summary>
    /// <returns>Текст файла AssemblyInfo.cs</returns>
    public static string GenerateAssemblyInfoFile(string projectName) => ModelProject.GenerateAssemblyInfoFile();

    /// <summary>Сгенерировать файл AssemblyInfo.cs</summary>
    /// <param name="conversions">Преобразования с текстом шаблона</param>
    /// <returns>Текст файла AssemblyInfo.cs</returns>
    public static string GenerateAssemblyInfoFile(Func<string, string> conversions = null)
    {
      if (conversions == null)
        conversions = (Func<string, string>) (str => str);
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return ModelProject.GenerateTemplateToString((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3204338), (Func<string, string>) (str => (string) ModelProject.\u003C\u003Ec__DisplayClass20_0.nSjM4nQzlgG8nPwDld77(ModelProject.\u003C\u003Ec__DisplayClass20_0.nSjM4nQzlgG8nPwDld77(ModelProject.\u003C\u003Ec__DisplayClass20_0.nSjM4nQzlgG8nPwDld77((object) conversions(str).Replace((string) ModelProject.\u003C\u003Ec__DisplayClass20_0.nwojHLQzdFj2TIEtSbdI(-1886646897 ^ -1886806471), "").Replace((string) ModelProject.\u003C\u003Ec__DisplayClass20_0.nwojHLQzdFj2TIEtSbdI(1149433385 + 173655049 ^ 1322854888), ""), ModelProject.\u003C\u003Ec__DisplayClass20_0.nwojHLQzdFj2TIEtSbdI(-1350312861 << 3 ^ 2082174738), ModelProject.\u003C\u003Ec__DisplayClass20_0.nwojHLQzdFj2TIEtSbdI(1574260816 ^ 1574288000)), ModelProject.\u003C\u003Ec__DisplayClass20_0.nwojHLQzdFj2TIEtSbdI(--1867379187 ^ 1867015617), ModelProject.\u003C\u003Ec__DisplayClass20_0.nwojHLQzdFj2TIEtSbdI(1461825605 - 1531863589 ^ -70015760)), ModelProject.\u003C\u003Ec__DisplayClass20_0.nwojHLQzdFj2TIEtSbdI(572119659 - -337058038 ^ 909469445), (object) ModelProject.\u003C\u003Ec__DisplayClass20_0.H1lcAmQzrTE5v5b3SbP1().Year.ToString())));
    }

    /// <summary>Dispose</summary>
    public void Dispose()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            goto label_2;
          case 3:
            if (this.prj == null)
            {
              num = 2;
              continue;
            }
            break;
          case 4:
            this.prj = (Project) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 1 : 1;
            continue;
        }
        ModelProject.pAH4eOW50mbTS8bbXFSG(ModelProject.zTk1mZW5xVHKl4kT4L9J(), (object) this.prj);
        num = 4;
      }
label_5:
      return;
label_2:;
    }

    /// <summary>Полное имя папки проекта</summary>
    internal string ProjectDir => this.prjDir;

    /// <summary>Группа элементов "Compile"</summary>
    internal ProjectItemGroupElement ProjectGroupCompile => this.prjGroupCompile;

    /// <summary>Группа элементов "None"</summary>
    internal ProjectItemGroupElement ProjectGroupNone => this.prjGroupNone;

    private void CheckProjectFileNameDefined()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (ModelProject.VgIifLW57TZ8EPN1iLPE((object) this.prjFileName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:
      throw new NotInitializedException((string) ModelProject.XNPk4uW5mbxA5i4ZOF7A((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108773040)));
    }

    private void ParseProject()
    {
      int num1 = 2;
      IEnumerator<ProjectItemElement> enumerator1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          IEnumerator<ProjectItemGroupElement> enumerator2;
          Dictionary<string, ModelProjectItem> dictionary;
          switch (num2)
          {
            case 1:
              try
              {
label_27:
                if (ModelProject.FZnJFXW5dJmoMo8lmGBx((object) enumerator2))
                  goto label_31;
                else
                  goto label_28;
label_18:
                string str;
                ProjectItemElement projectItemElement;
                ProjectItemGroupElement current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 2:
                      this.prjGroupRefs = current;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 5 : 0;
                      continue;
                    case 3:
                      goto label_43;
                    case 4:
                      this.prjGroupNone = current;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
                      continue;
                    case 6:
                      if (projectItemElement != null)
                      {
                        num3 = 8;
                        continue;
                      }
                      goto label_27;
                    case 7:
                    case 14:
                      this.prjGroupCompile = current;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 0;
                      continue;
                    case 8:
                      str = (string) ModelProject.FZWsDTW5JDITqFdjbx5l((object) projectItemElement);
                      num3 = 9;
                      continue;
                    case 9:
                      if (!ModelProject.Kk6na8W59r1hNkbTy7nM((object) str, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 901890819)))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 1 : 13;
                        continue;
                      }
                      goto case 2;
                    case 10:
                      goto label_31;
                    case 12:
                      projectItemElement = ModelProject.xUQZxDW5MFj9F7EnKmKk((object) current) as ProjectItemElement;
                      num3 = 6;
                      continue;
                    case 13:
                      if (str == (string) ModelProject.Sgf5RiW54HcdlDS046cf(~541731958 ^ -541829657))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 7 : 6;
                        continue;
                      }
                      goto case 15;
                    case 15:
                      if (!(str == (string) ModelProject.Sgf5RiW54HcdlDS046cf(-441065788 ^ -2092910478 ^ 1727324372)))
                      {
                        num3 = 11;
                        continue;
                      }
                      goto case 4;
                    default:
                      goto label_27;
                  }
                }
label_28:
                num3 = 3;
                goto label_18;
label_31:
                current = enumerator2.Current;
                num3 = 12;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
                {
                  num3 = 4;
                  goto label_18;
                }
                else
                  goto label_18;
              }
              finally
              {
                if (enumerator2 != null)
                {
                  int num4 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
                    num4 = 0;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        goto label_41;
                      default:
                        enumerator2.Dispose();
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 1;
                        continue;
                    }
                  }
                }
label_41:;
              }
            case 2:
              enumerator2 = ((ProjectRootElement) ModelProject.j0qTRoW5y3JUDwjqYGDu((object) this.prj)).ItemGroups.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 1 : 1;
              continue;
            case 3:
              this.prjGroupRefs = (ProjectItemGroupElement) ModelProject.oWDGsaW5lCD76J3tDaPM(ModelProject.j0qTRoW5y3JUDwjqYGDu((object) this.prj));
              num2 = 17;
              continue;
            case 4:
label_43:
              if (this.prjGroupRefs != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 18 : 18;
                continue;
              }
              goto case 3;
            case 5:
              this.prjGroupCompile = (ProjectItemGroupElement) ModelProject.oWDGsaW5lCD76J3tDaPM(ModelProject.j0qTRoW5y3JUDwjqYGDu((object) this.prj));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 2 : 12;
              continue;
            case 6:
              goto label_4;
            case 7:
              try
              {
label_65:
                if (ModelProject.FZnJFXW5dJmoMo8lmGBx((object) enumerator1))
                  goto label_63;
                else
                  goto label_66;
label_57:
                ProjectMetadataElement projectMetadataElement;
                ProjectItemElement current;
                string key;
                ModelProjectItem modelProjectItem;
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      modelProjectItem.DependentItems.Add(current);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 8 : 3;
                      continue;
                    case 2:
                      if (projectMetadataElement == null)
                      {
                        num5 = 9;
                        continue;
                      }
                      goto case 4;
                    case 3:
                      if (current.Metadata.Count<ProjectMetadataElement>((Func<ProjectMetadataElement, bool>) (m =>
                      {
                        int num6 = 1;
                        while (true)
                        {
                          switch (num6)
                          {
                            case 1:
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              if (!ModelProject.\u003C\u003Ec.KpsgO8QzUZNbUlVA7lCl((object) m.Name, ModelProject.\u003C\u003Ec.FEcy24QzLF7qrDLWe2ix(~-122002947 ^ 121903234)))
                              {
                                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
                                continue;
                              }
                              goto label_2;
                            case 2:
                              goto label_2;
                            default:
                              goto label_3;
                          }
                        }
label_2:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        return ModelProject.\u003C\u003Ec.KpsgO8QzUZNbUlVA7lCl(ModelProject.\u003C\u003Ec.A6wYBEQzsFTWGCR29sWe((object) m), ModelProject.\u003C\u003Ec.FEcy24QzLF7qrDLWe2ix(1581325282 << 3 ^ -234268286));
label_3:
                        return false;
                      })) <= 0)
                      {
                        num5 = 7;
                        continue;
                      }
                      goto case 2;
                    case 4:
                      key = (string) ModelProject.GZgIlNW556BLD6efVhjX(ModelProject.UFBV7oW5tw7ZRSd0QgPG(ModelProject.R0bx4UW5rarv4GmI6LlO((object) current)), ModelProject.lpfCcfW5LdDDJiYKIBcB((object) projectMetadataElement));
                      num5 = 10;
                      continue;
                    case 5:
                      goto label_63;
                    case 6:
                      if (ModelProject.R0bx4UW5rarv4GmI6LlO((object) current) != null)
                      {
                        num5 = 11;
                        continue;
                      }
                      goto label_65;
                    case 7:
                    case 8:
                    case 9:
                      goto label_65;
                    case 10:
                      if (dictionary.TryGetValue(key, out modelProjectItem))
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 1 : 1;
                        continue;
                      }
                      goto label_65;
                    case 11:
                      ICollection<ProjectMetadataElement> metadata = current.Metadata;
                      // ISSUE: reference to a compiler-generated field
                      Func<ProjectMetadataElement, bool> func = ModelProject.\u003C\u003Ec.\u003C\u003E9__44_0;
                      Func<ProjectMetadataElement, bool> predicate;
                      if (func == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        ModelProject.\u003C\u003Ec.\u003C\u003E9__44_0 = predicate = (Func<ProjectMetadataElement, bool>) (m => ModelProject.\u003C\u003Ec.KpsgO8QzUZNbUlVA7lCl(ModelProject.\u003C\u003Ec.sslGwiQzYSsE3iYhcUjj((object) m), ModelProject.\u003C\u003Ec.FEcy24QzLF7qrDLWe2ix(-1120607109 - 305487170 ^ -1426194033)));
                      }
                      else
                        goto label_107;
label_72:
                      projectMetadataElement = metadata.FirstOrDefault<ProjectMetadataElement>(predicate);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 3 : 3;
                      continue;
label_107:
                      predicate = func;
                      goto label_72;
                    default:
                      goto label_3;
                  }
                }
label_63:
                current = enumerator1.Current;
                num5 = 6;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
                {
                  num5 = 1;
                  goto label_57;
                }
                else
                  goto label_57;
label_66:
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
                goto label_57;
              }
              finally
              {
                if (enumerator1 != null)
                {
                  int num7 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
                    num7 = 0;
                  while (true)
                  {
                    switch (num7)
                    {
                      case 1:
                        goto label_80;
                      default:
                        ModelProject.BlefyFW5Ym23tZnbW4uE((object) enumerator1);
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 1;
                        continue;
                    }
                  }
                }
label_80:;
              }
            case 8:
label_3:
              ModelProject.mVMmZRW5UjPTdE1UNTpy((object) this.references);
              num2 = 9;
              continue;
            case 9:
              if (this.prjGroupRefs == null)
              {
                num2 = 15;
                continue;
              }
              goto case 19;
            case 10:
            case 20:
              dictionary = new Dictionary<string, ModelProjectItem>();
              num2 = 11;
              continue;
            case 11:
              goto label_52;
            case 12:
              if (this.prjGroupNone != null)
              {
                num2 = 20;
                continue;
              }
              goto case 13;
            case 13:
              this.prjGroupNone = (ProjectItemGroupElement) ModelProject.oWDGsaW5lCD76J3tDaPM(ModelProject.j0qTRoW5y3JUDwjqYGDu((object) this.prj));
              num2 = 10;
              continue;
            case 14:
              try
              {
label_88:
                if (ModelProject.FZnJFXW5dJmoMo8lmGBx((object) enumerator1))
                  goto label_95;
                else
                  goto label_89;
label_82:
                ProjectItemElement current;
                IMetadata metadata;
                ModelProjectItem modelProjectItem;
                int num8;
                while (true)
                {
                  switch (num8)
                  {
                    case 1:
                    case 6:
                      goto label_88;
                    case 2:
                      if (ModelProject.zE2Iv6W5gJYcVkSD6NF1(ModelProject.R0bx4UW5rarv4GmI6LlO((object) current), ModelProject.Sgf5RiW54HcdlDS046cf(95909607 + 343705423 ^ 439563366)))
                      {
                        num8 = 9;
                        continue;
                      }
                      goto label_88;
                    case 3:
                      goto label_95;
                    case 4:
                      dictionary[current.Include] = modelProjectItem;
                      num8 = 5;
                      continue;
                    case 5:
                      this.items.Add(modelProjectItem);
                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 1 : 1;
                      continue;
                    case 7:
                      if (ModelProject.R0bx4UW5rarv4GmI6LlO((object) current) == null)
                      {
                        num8 = 6;
                        continue;
                      }
                      goto case 2;
                    case 8:
                      modelProjectItem = new ModelProjectItem(this, metadata, current);
                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 3 : 4;
                      continue;
                    case 9:
                      if (!dictionary.ContainsKey((string) ModelProject.R0bx4UW5rarv4GmI6LlO((object) current)))
                      {
                        num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
                        continue;
                      }
                      goto label_88;
                    case 10:
                      goto label_55;
                    default:
                      metadata = (IMetadata) ModelProject.ySIFqJW5jVqhZoTlb0Ai(ModelProject.GZgIlNW556BLD6efVhjX((object) this.prjDir, (object) current.Include));
                      num8 = 8;
                      continue;
                  }
                }
label_89:
                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 10 : 10;
                goto label_82;
label_95:
                current = enumerator1.Current;
                num8 = 7;
                goto label_82;
              }
              finally
              {
                if (enumerator1 != null)
                {
                  int num9 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
                    num9 = 0;
                  while (true)
                  {
                    switch (num9)
                    {
                      case 1:
                        ModelProject.BlefyFW5Ym23tZnbW4uE((object) enumerator1);
                        num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_103;
                    }
                  }
                }
label_103:;
              }
            case 15:
              goto label_105;
            case 16:
              goto label_96;
            case 17:
            case 18:
              if (this.prjGroupCompile == null)
              {
                num2 = 5;
                continue;
              }
              goto case 12;
            case 19:
              enumerator1 = this.prjGroupRefs.Items.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 6 : 2;
              continue;
          }
label_55:
          enumerator1 = this.prjGroupCompile.Items.GetEnumerator();
          num2 = 7;
        }
label_52:
        enumerator1 = this.prjGroupNone.Items.GetEnumerator();
        num1 = 14;
      }
label_105:
      return;
label_96:
      return;
label_4:
      try
      {
label_9:
        if (ModelProject.FZnJFXW5dJmoMo8lmGBx((object) enumerator1))
          goto label_6;
        else
          goto label_10;
label_5:
        ProjectItemElement current;
        int num10;
        while (true)
        {
          switch (num10)
          {
            case 1:
              goto label_101;
            case 2:
              goto label_9;
            case 3:
              goto label_6;
            default:
              this.references.Add(new ModelProjectReference(this, current));
              num10 = 2;
              continue;
          }
        }
label_101:
        return;
label_6:
        current = enumerator1.Current;
        num10 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
        {
          num10 = 0;
          goto label_5;
        }
        else
          goto label_5;
label_10:
        num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 1 : 1;
        goto label_5;
      }
      finally
      {
        if (enumerator1 != null)
        {
          int num11 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
            num11 = 0;
          while (true)
          {
            switch (num11)
            {
              case 1:
                goto label_16;
              default:
                ModelProject.BlefyFW5Ym23tZnbW4uE((object) enumerator1);
                num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_16:;
      }
    }

    private string GetMetadataFileName(IMetadata metadata)
    {
      int num = 5;
      ICodeItemMetadata codeItemMetadata;
      string metadataFileName;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!((string) ModelProject.RIQ43rW5sykaYBfupoJw((object) codeItemMetadata)).StartsWith(this.prjName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 8 : 3;
              continue;
            }
            goto case 11;
          case 2:
            goto label_4;
          case 3:
            goto label_5;
          case 4:
            Contract.CheckArgument(metadata is ICodeItemMetadata, (string) ModelProject.Sgf5RiW54HcdlDS046cf(516838154 ^ 516713652));
            num = 7;
            continue;
          case 5:
            ModelProject.ev3laVW5aU842l81P4Wd((object) metadata, ModelProject.Sgf5RiW54HcdlDS046cf(1149433385 + 173655049 ^ 1323102988));
            num = 4;
            continue;
          case 6:
            codeItemMetadata = (ICodeItemMetadata) metadata;
            num = 9;
            continue;
          case 7:
            str = "";
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 3 : 6;
            continue;
          case 8:
          case 12:
            metadataFileName = (string) ModelProject.BQ9KSXW566GdlpwvJKhP(ModelProject.i21q3wWjBGeTWTp5NHRv((object) codeItemMetadata), ModelProject.Sgf5RiW54HcdlDS046cf(813604817 ^ 813585793));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
            continue;
          case 9:
            if (!ModelProject.VgIifLW57TZ8EPN1iLPE(ModelProject.RIQ43rW5sykaYBfupoJw((object) codeItemMetadata)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 1 : 1;
              continue;
            }
            goto case 8;
          case 10:
            str = (string) ModelProject.RvhpG6WjFjLQ9dROvpA2((object) codeItemMetadata.Namespace.Substring(ModelProject.qA0DZkW5zjt4EjJt5xAD((object) this.prjName) + 1), ModelProject.Sgf5RiW54HcdlDS046cf(1232639661 >> 3 ^ 154077201), ModelProject.Sgf5RiW54HcdlDS046cf(-2107978722 ^ -2107976856));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 10 : 12;
            continue;
          case 11:
            if (ModelProject.tHcqVqW5cmhqoZX5pocL(ModelProject.RIQ43rW5sykaYBfupoJw((object) codeItemMetadata), (object) this.prjName))
            {
              num = 10;
              continue;
            }
            goto case 8;
          default:
            if (str != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 2 : 3;
              continue;
            }
            goto label_4;
        }
      }
label_4:
      return metadataFileName;
label_5:
      return (string) ModelProject.GZgIlNW556BLD6efVhjX((object) str, (object) metadataFileName);
    }

    private ProjectItemElement GetOrCreateMdItem(string fileName)
    {
      int num1 = 4;
      ProjectItemElement mdItem;
      while (true)
      {
        int num2 = num1;
        Dictionary<string, string> metadata;
        string fileName1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_10;
            case 2:
              if (mdItem == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 6;
                continue;
              }
              goto label_10;
            case 3:
              fileName1 = fileName;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
              continue;
            case 4:
              goto label_3;
            case 5:
              mdItem = (ProjectItemElement) this.prjGroupNone.Children.FirstOrDefault<ProjectElement>((Func<ProjectElement, bool>) (i =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      if (!(i is ProjectItemElement))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_2;
                    case 2:
                      goto label_2;
                    default:
                      goto label_3;
                  }
                }
label_2:
                // ISSUE: reference to a compiler-generated method
                return ModelProject.\u003C\u003Ec__DisplayClass46_0.Ux00cmCFWJwBTELSrssR((object) ((ProjectItemElement) i).Include, (object) fileName1);
label_3:
                return false;
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 2 : 2;
              continue;
            case 6:
              mdItem = this.prjGroupNone.AddItem(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146608831), fileName1, (IEnumerable<KeyValuePair<string, string>>) metadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 1 : 1;
              continue;
            case 7:
              metadata[z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 44918185)] = (string) ModelProject.Sgf5RiW54HcdlDS046cf(277947046 - -1479185048 ^ 1756990146);
              num2 = 5;
              continue;
            default:
              metadata = new Dictionary<string, string>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 7 : 7;
              continue;
          }
        }
label_3:
        num1 = 3;
      }
label_10:
      return mdItem;
    }

    private ModelProjectItem GetOrCreateProjectItem(
      IMetadata metadata,
      bool saveMetadata,
      Action<string> fileAddedAction = null,
      Action<string> fileRemovedAction = null)
    {
      Contract.ArgumentNotNull((object) metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-649342099 - -1150814748 ^ 501454007));
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      ModelProjectItem projectItem = this.items.FirstOrDefault<ModelProjectItem>((Func<ModelProjectItem, bool>) (i => ModelProject.\u003C\u003Ec__DisplayClass47_0.sdVNykCFfIng8vPokRZ1(ModelProject.\u003C\u003Ec__DisplayClass47_0.fUwmWkCFE0fjw0rlc5Sv((object) i.Metadata), ModelProject.\u003C\u003Ec__DisplayClass47_0.fUwmWkCFE0fjw0rlc5Sv((object) metadata))));
      string metadataFileName = this.GetMetadataFileName(metadata);
      if (projectItem != null)
      {
        projectItem.Metadata = metadata;
        projectItem.MdItem.Include = metadataFileName;
      }
      else
      {
        ProjectItemElement mdItem = this.GetOrCreateMdItem(metadataFileName);
        projectItem = new ModelProjectItem(this, metadata, mdItem);
        this.items.Add(projectItem);
      }
      Path.Combine(this.prjDir, metadataFileName);
      if (saveMetadata)
        projectItem.Save(fileAddedAction, fileRemovedAction);
      return projectItem;
    }

    private void SaveNewProject(IMetadata[] metadataList)
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        Stream input;
        int index;
        IMetadata[] metadataArray;
        IMetadata metadata;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_33;
            case 1:
label_26:
              this.ParseProject();
              num2 = 2;
              continue;
            case 2:
              metadataArray = metadataList;
              num2 = 11;
              continue;
            case 3:
            case 9:
              if (index >= metadataArray.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 7 : 5;
                continue;
              }
              goto case 13;
            case 4:
              ModelProject.cLt60KW5ALQZFBTDsjmH((object) this.prj, (object) this.prjFileName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
              continue;
            case 5:
              try
              {
                XmlTextReader xmlTextReader = new XmlTextReader(input);
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
                  num3 = 0;
                switch (num3)
                {
                  default:
                    try
                    {
                      this.prj = new Project((XmlReader) xmlTextReader);
                      int num4 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
                        num4 = 0;
                      switch (num4)
                      {
                        default:
                          goto label_26;
                      }
                    }
                    finally
                    {
                      if (xmlTextReader != null)
                      {
                        int num5 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
                          num5 = 1;
                        while (true)
                        {
                          switch (num5)
                          {
                            case 1:
                              ModelProject.BlefyFW5Ym23tZnbW4uE((object) xmlTextReader);
                              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
                              continue;
                            default:
                              goto label_16;
                          }
                        }
                      }
label_16:;
                    }
                }
              }
              finally
              {
                if (input != null)
                {
                  int num6 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
                    num6 = 0;
                  while (true)
                  {
                    switch (num6)
                    {
                      case 1:
                        goto label_23;
                      default:
                        input.Dispose();
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
label_23:;
              }
            case 6:
              input = (Stream) ModelProject.QjnSbhWjWDCNdxZigCVI((object) typeof (ModelProject).Assembly, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825237784));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 2 : 5;
              continue;
            case 7:
              if (ModelProject.gUl6yfWjotWkX1vEMuE9((object) this.prjDir))
                goto case 4;
              else
                goto label_28;
            case 8:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 8 : 9;
              continue;
            case 10:
              this.GetOrCreateProjectItem(metadata, true);
              num2 = 8;
              continue;
            case 11:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 3 : 3;
              continue;
            case 12:
              ModelProject.WNWwu4WjbBQl0oK4LiJ4((object) this.prjDir);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 4 : 4;
              continue;
            case 13:
              metadata = metadataArray[index];
              num2 = 10;
              continue;
            default:
              goto label_21;
          }
        }
label_28:
        num1 = 12;
      }
label_33:
      return;
label_21:;
    }

    private void CreateNew()
    {
      int num1 = 1;
      StringReader input;
      while (true)
      {
        switch (num1)
        {
          case 1:
            input = new StringReader(this.GenerateTemplate((string) ModelProject.Sgf5RiW54HcdlDS046cf(694673736 ^ -23604109 ^ -671976155)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_21;
          case 3:
label_24:
            this.ParseProject();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 2;
            continue;
          default:
            try
            {
              XmlReader xmlReader = XmlReader.Create((TextReader) input);
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
                num2 = 0;
              switch (num2)
              {
                default:
                  try
                  {
                    this.prj = new Project(xmlReader);
                    int num3 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
                      num3 = 0;
                    switch (num3)
                    {
                      default:
                        goto label_24;
                    }
                  }
                  finally
                  {
                    int num4;
                    if (xmlReader == null)
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
                    else
                      goto label_14;
label_13:
                    switch (num4)
                    {
                      case 2:
                        break;
                      default:
                    }
label_14:
                    ModelProject.BlefyFW5Ym23tZnbW4uE((object) xmlReader);
                    num4 = 1;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
                    {
                      num4 = 1;
                      goto label_13;
                    }
                    else
                      goto label_13;
                  }
              }
            }
            finally
            {
              if (input != null)
              {
                int num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
                  num5 = 0;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      goto label_23;
                    default:
                      input.Dispose();
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 1 : 1;
                      continue;
                  }
                }
              }
label_23:;
            }
        }
      }
label_21:;
    }

    private void GenerateTemplate(string resourceName, string fileName)
    {
      int num1 = 1;
      string directoryName;
      FileStream fileStream;
      while (true)
      {
        switch (num1)
        {
          case 1:
            directoryName = Path.GetDirectoryName(fileName);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
            continue;
          case 2:
          case 4:
            fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            num1 = 6;
            continue;
          case 3:
            ModelProject.WNWwu4WjbBQl0oK4LiJ4((object) directoryName);
            num1 = 4;
            continue;
          case 5:
            goto label_14;
          case 6:
            goto label_4;
          default:
            if (ModelProject.gUl6yfWjotWkX1vEMuE9((object) directoryName))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 2 : 2;
              continue;
            }
            goto case 3;
        }
      }
label_14:
      return;
label_4:
      try
      {
        this.GenerateTemplate(resourceName, (Stream) fileStream);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        int num3;
        if (fileStream == null)
          num3 = 2;
        else
          goto label_12;
label_10:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_12:
        ModelProject.BlefyFW5Ym23tZnbW4uE((object) fileStream);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
        {
          num3 = 0;
          goto label_10;
        }
        else
          goto label_10;
      }
    }

    private void GenerateTemplate(string resourceName, Stream stream)
    {
      int num1 = 2;
      StreamWriter streamWriter;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_11;
          case 1:
            goto label_2;
          case 2:
            streamWriter = new StreamWriter(stream);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 1;
            continue;
          default:
            goto label_10;
        }
      }
label_11:
      return;
label_10:
      return;
label_2:
      try
      {
        streamWriter.Write(this.GenerateTemplate(resourceName));
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        int num3;
        if (streamWriter == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
        else
          goto label_12;
label_9:
        switch (num3)
        {
          case 2:
            break;
          default:
        }
label_12:
        streamWriter.Dispose();
        num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
        {
          num3 = 1;
          goto label_9;
        }
        else
          goto label_9;
      }
    }

    private string GenerateTemplate(string resourceName) => ModelProject.GenerateTemplateToString((object) resourceName, (Func<string, string>) (s => (string) ModelProject.RvhpG6WjFjLQ9dROvpA2((object) s, ModelProject.Sgf5RiW54HcdlDS046cf(1033719030 - 2012070891 ^ -978466413), (object) this.prjName)));

    private static string GenerateTemplateToString(
      object resourceName,
      Func<string, string> conversions = null)
    {
      using (Stream manifestResourceStream = typeof (ModelProject).Assembly.GetManifestResourceStream(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333621338) + (string) resourceName))
      {
        using (StreamReader streamReader = new StreamReader(manifestResourceStream))
        {
          string end = streamReader.ReadToEnd();
          return conversions != null ? conversions(end) : end;
        }
      }
    }

    private void GenerateTemplates(Dictionary<string, string> fileNameTemplateMap)
    {
      foreach (KeyValuePair<string, string> fileNameTemplate in fileNameTemplateMap)
      {
        string str = Path.Combine(this.prjDir, fileNameTemplate.Key);
        if (!File.Exists(str))
          this.GenerateTemplate(fileNameTemplate.Value, str);
      }
    }

    internal static void ev3laVW5aU842l81P4Wd([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static bool qRfbg0W5DWlCLDC2o6KW([In] object obj0) => File.Exists((string) obj0);

    internal static bool v9rcBaW53BxcRcYjaPYQ() => ModelProject.jdKIKTW5NuAwfBSoMrCi == null;

    internal static ModelProject EH8mvSW5prY1kKXuhmuW() => ModelProject.jdKIKTW5NuAwfBSoMrCi;

    internal static object UFBV7oW5tw7ZRSd0QgPG([In] object obj0) => (object) Path.GetDirectoryName((string) obj0);

    internal static object w1kZOfW5wrJVW85KHYt4([In] object obj0) => (object) Path.GetFileNameWithoutExtension((string) obj0);

    internal static object Sgf5RiW54HcdlDS046cf(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object BQ9KSXW566GdlpwvJKhP([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object CcBgoYW5H7xgTiHRCOge(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) Path.Combine((string) obj0, (string) obj1, (string) obj2, (string) obj3);
    }

    internal static void cLt60KW5ALQZFBTDsjmH([In] object obj0, [In] object obj1) => ((Project) obj0).Save((string) obj1);

    internal static bool VgIifLW57TZ8EPN1iLPE([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object zTk1mZW5xVHKl4kT4L9J() => (object) ProjectCollection.GlobalProjectCollection;

    internal static void pAH4eOW50mbTS8bbXFSG([In] object obj0, [In] object obj1) => ((ProjectCollection) obj0).UnloadProject((Project) obj1);

    internal static object XNPk4uW5mbxA5i4ZOF7A([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object j0qTRoW5y3JUDwjqYGDu([In] object obj0) => (object) ((Project) obj0).Xml;

    internal static object xUQZxDW5MFj9F7EnKmKk([In] object obj0) => (object) ((ProjectElementContainer) obj0).FirstChild;

    internal static object FZWsDTW5JDITqFdjbx5l([In] object obj0) => (object) ((ProjectItemElement) obj0).ItemType;

    internal static bool Kk6na8W59r1hNkbTy7nM([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static bool FZnJFXW5dJmoMo8lmGBx([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static object oWDGsaW5lCD76J3tDaPM([In] object obj0) => (object) ((ProjectRootElement) obj0).AddItemGroup();

    internal static object R0bx4UW5rarv4GmI6LlO([In] object obj0) => (object) ((ProjectItemElement) obj0).Include;

    internal static bool zE2Iv6W5gJYcVkSD6NF1([In] object obj0, [In] object obj1) => ((string) obj0).EndsWith((string) obj1);

    internal static object GZgIlNW556BLD6efVhjX([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static object ySIFqJW5jVqhZoTlb0Ai([In] object obj0) => (object) MetadataSerializer.LoadMetadata((string) obj0);

    internal static void BlefyFW5Ym23tZnbW4uE([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object lpfCcfW5LdDDJiYKIBcB([In] object obj0) => (object) ((ProjectMetadataElement) obj0).Value;

    internal static void mVMmZRW5UjPTdE1UNTpy([In] object obj0) => ((List<ModelProjectReference>) obj0).Clear();

    internal static object RIQ43rW5sykaYBfupoJw([In] object obj0) => (object) ((ICodeItemMetadata) obj0).Namespace;

    internal static bool tHcqVqW5cmhqoZX5pocL([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static int qA0DZkW5zjt4EjJt5xAD([In] object obj0) => ((string) obj0).Length;

    internal static object RvhpG6WjFjLQ9dROvpA2([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static object i21q3wWjBGeTWTp5NHRv([In] object obj0) => (object) ((ICodeItemMetadata) obj0).Name;

    internal static object QjnSbhWjWDCNdxZigCVI([In] object obj0, [In] object obj1) => (object) ((Assembly) obj0).GetManifestResourceStream((string) obj1);

    internal static bool gUl6yfWjotWkX1vEMuE9([In] object obj0) => Directory.Exists((string) obj0);

    internal static object WNWwu4WjbBQl0oK4LiJ4([In] object obj0) => (object) Directory.CreateDirectory((string) obj0);
  }
}
