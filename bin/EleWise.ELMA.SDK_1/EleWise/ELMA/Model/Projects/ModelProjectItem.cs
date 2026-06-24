// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Projects.ModelProjectItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using Microsoft.Build.Construction;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EleWise.ELMA.Model.Projects
{
  /// <summary>Элемент проекта модели</summary>
  public class ModelProjectItem
  {
    private ModelProject project;
    private IMetadata metadata;
    private ProjectItemElement mdItem;
    private List<ProjectItemElement> dependentItems;
    private static ModelProjectItem dbvAWpWjhpivvcydbBCr;

    /// <summary>Конструктор</summary>
    /// <param name="project">Проект-владелец</param>
    /// <param name="metadata">Метаданные</param>
    /// <param name="mdItem">MD-файл</param>
    internal ModelProjectItem(ModelProject project, IMetadata metadata, ProjectItemElement mdItem)
    {
      ModelProjectItem.G8SbXRWjfBskx1QePR77();
      this.dependentItems = new List<ProjectItemElement>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.project = project;
            num = 3;
            continue;
          case 2:
            this.mdItem = mdItem;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
            continue;
          case 3:
            this.metadata = metadata;
            num = 2;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_7:;
    }

    /// <summary>Метаданные</summary>
    public IMetadata Metadata
    {
      get => this.metadata;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.metadata = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>MD-файл</summary>
    internal ProjectItemElement MdItem => this.mdItem;

    /// <summary>Зависимые файлы</summary>
    internal List<ProjectItemElement> DependentItems => this.dependentItems;

    /// <summary>Сохранить элемент</summary>
    public void Save(Action<string> fileAddedAction, Action<string> fileRemovedAction)
    {
      string str = Path.Combine(this.project.ProjectDir, this.mdItem.Include);
      string directoryName = Path.GetDirectoryName(str);
      if (!Directory.Exists(directoryName))
        Directory.CreateDirectory(directoryName);
      MetadataSerializer.SaveMetadata(this.metadata, str);
      if (fileAddedAction != null)
        fileAddedAction(this.mdItem.Include);
      GeneratedFileInfo[] generatedFileInfoArray = Locator.GetServiceNotNull<IMetadataEditorService>().CreateCodeGenerator(this.metadata).Generate();
      List<ProjectItemElement> projectItemElementList = new List<ProjectItemElement>((IEnumerable<ProjectItemElement>) this.dependentItems);
      bool flag = true;
      foreach (GeneratedFileInfo generatedFileInfo in generatedFileInfoArray)
      {
        string genFileName = Path.ChangeExtension(this.mdItem.Include, generatedFileInfo.Extension);
        File.WriteAllBytes(Path.Combine(this.project.ProjectDir, genFileName), generatedFileInfo.Data);
        if (fileAddedAction != null)
          fileAddedAction(genFileName);
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        ProjectItemElement projectItemElement = this.dependentItems.FirstOrDefault<ProjectItemElement>((Func<ProjectItemElement, bool>) (i => ModelProjectItem.\u003C\u003Ec__DisplayClass12_0.xTIw3qCFuiWrvYMSkaVt(ModelProjectItem.\u003C\u003Ec__DisplayClass12_0.fgh4pECFZMQgci11Xgni((object) i), (object) genFileName)));
        if (projectItemElement != null)
          projectItemElementList.Remove(projectItemElement);
        else
          this.dependentItems.Add(this.project.ProjectGroupCompile.AddItem(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3366284), genFileName, (IEnumerable<KeyValuePair<string, string>>) new Dictionary<string, string>()
          {
            [z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317692826)] = Path.GetFileName(this.mdItem.Include),
            [z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882223134)] = z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272527335)
          }));
        if (flag)
        {
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          ProjectMetadataElement projectMetadataElement = this.mdItem.Metadata != null ? this.mdItem.Metadata.FirstOrDefault<ProjectMetadataElement>((Func<ProjectMetadataElement, bool>) (mi => ModelProjectItem.\u003C\u003Ec.IouV1ACFKic3rpsvglsy(ModelProjectItem.\u003C\u003Ec.swfEm1CFR3JA2i7MkYMT((object) mi), ModelProjectItem.\u003C\u003Ec.n8aMaUCFqIKOccFxvBOD(-398663332 ^ -398629302)))) : (ProjectMetadataElement) null;
          if (projectMetadataElement != null)
            projectMetadataElement.Value = Path.GetFileName(genFileName);
          else
            this.mdItem.AddMetadata(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70072010), Path.GetFileName(genFileName));
        }
        flag = false;
      }
      foreach (ProjectItemElement child in projectItemElementList)
      {
        Path.Combine(this.project.ProjectDir, child.Include);
        if (child.Parent is ProjectItemGroupElement parent)
        {
          parent.RemoveChild((ProjectElement) child);
          if (fileRemovedAction != null)
            fileRemovedAction(child.Include);
        }
        this.dependentItems.Remove(child);
      }
    }

    internal static void G8SbXRWjfBskx1QePR77() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool fPyaiBWjGsNVbNZHWjiE() => ModelProjectItem.dbvAWpWjhpivvcydbBCr == null;

    internal static ModelProjectItem Otxf6uWjEhgxHPr37rKO() => ModelProjectItem.dbvAWpWjhpivvcydbBCr;
  }
}
