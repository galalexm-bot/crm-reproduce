// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.DTO.Models.ProjectInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Model.Scripts.DTO.Models
{
  /// <summary>Информация о проекте глобального модуля сценариев</summary>
  [Component]
  [Serializable]
  public class ProjectInfo : ProjectFolderItem
  {
    internal static ProjectInfo zdrXfGbKZou84TbOWsDS;

    public ProjectInfo()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Items = new List<ProjectItem>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Папка содержащая исходники для компиляции проекта</summary>
    public string CompiledFolderPath
    {
      get => this.\u003CCompiledFolderPath\u003Ek__BackingField;
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
              this.\u003CCompiledFolderPath\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
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

    /// <summary>Рекурсивно найти элемент по идентификатору</summary>
    /// <param name="uid"></param>
    /// <param name="items"></param>
    /// <returns></returns>
    private ProjectItem GetItemByUid(Guid uid, List<ProjectItem> items)
    {
      // ISSUE: reference to a compiler-generated method
      ProjectItem itemByUid1 = items.FirstOrDefault<ProjectItem>((Func<ProjectItem, bool>) (a => ProjectInfo.\u003C\u003Ec__DisplayClass5_0.deVTeJCNDFCbW9ruTaLO((object) a) == uid));
      if (itemByUid1 != null)
        return itemByUid1;
      foreach (ProjectItem projectItem in items)
      {
        if (projectItem is ProjectFolderItem)
        {
          ProjectFolderItem projectFolderItem = projectItem as ProjectFolderItem;
          ProjectItem itemByUid2 = this.GetItemByUid(uid, projectFolderItem.Items);
          if (itemByUid2 != null)
            return itemByUid2;
        }
      }
      return (ProjectItem) null;
    }

    /// <summary>Рекурсивно найти элемент в проекте по идентификатору</summary>
    /// <param name="uid"></param>
    /// <returns></returns>
    public ProjectItem GetItemByUid(Guid uid) => this.GetItemByUid(uid, this.Items);

    /// <summary>Удалить элемент из дерева по идентификатору</summary>
    /// <param name="uid"></param>
    public void RemoveItemByUid(Guid uid)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.RemoveItemByUid(uid, this.Items);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private void RemoveItemByUid(Guid uid, List<ProjectItem> items)
    {
      // ISSUE: reference to a compiler-generated method
      ProjectItem projectItem1 = items.FirstOrDefault<ProjectItem>((Func<ProjectItem, bool>) (a => ProjectInfo.\u003C\u003Ec__DisplayClass8_0.RB5wMyCNHVsOyVOrcvgM(a.Uid, uid)));
      if (projectItem1 != null)
      {
        items.Remove(projectItem1);
      }
      else
      {
        foreach (ProjectItem projectItem2 in items)
        {
          if (projectItem2 is ProjectFolderItem)
          {
            ProjectFolderItem projectFolderItem = projectItem2 as ProjectFolderItem;
            this.RemoveItemByUid(uid, projectFolderItem.Items);
          }
        }
      }
    }

    internal static bool wpSF3VbKuvRo8SsTBWkf() => ProjectInfo.zdrXfGbKZou84TbOWsDS == null;

    internal static ProjectInfo pm5djUbKIIdnAcMPH6Lo() => ProjectInfo.zdrXfGbKZou84TbOWsDS;
  }
}
