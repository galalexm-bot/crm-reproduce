// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.DTO.Models.ProjectFolderItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Model.Scripts.DTO.Models
{
  /// <summary>Папка проекта</summary>
  [Serializable]
  public class ProjectFolderItem : ProjectItem
  {
    private static ProjectFolderItem GJ9wBKbKQid9cBpULNh5;

    public ProjectFolderItem()
    {
      ProjectFolderItem.Hy5Ln2bK8c0FPs2ZHEhA();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Items = new List<ProjectItem>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Элементы папки</summary>
    public List<ProjectItem> Items { get; set; }

    /// <summary>Пространство имен</summary>
    public string Namespace
    {
      get => this.\u003CNamespace\u003Ek__BackingField;
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
              this.\u003CNamespace\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
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

    /// <summary>Проверить имя файла</summary>
    /// <param name="filename">Имя файла</param>
    /// <returns></returns>
    public bool CheckFileName(string filename)
    {
      int num = 2;
      string filename1;
      while (true)
      {
        switch (num)
        {
          case 1:
            filename1 = filename;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
            continue;
          case 2:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      // ISSUE: type reference
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.Items.Where<ProjectItem>((Func<ProjectItem, bool>) (f => ProjectFolderItem.\u003C\u003Ec.IXCYdtCNk6udFMKc6b7v(f.GetType(), ProjectFolderItem.\u003C\u003Ec.VGgr63CNTrYQKVw05Aev(__typeref (ProjectItem))))).Any<ProjectItem>((Func<ProjectItem, bool>) (a => a.Name == filename1));
    }

    /// <summary>Проверить имя папки</summary>
    /// <param name="foldername"></param>
    /// <returns></returns>
    public bool CheckFolderName(string foldername)
    {
      int num = 1;
      string foldername1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            foldername1 = foldername;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 2;
            continue;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.Items.Where<ProjectItem>((Func<ProjectItem, bool>) (f => f is ProjectFolderItem)).Any<ProjectItem>((Func<ProjectItem, bool>) (a => ProjectFolderItem.\u003C\u003Ec__DisplayClass10_0.EweTYfCN1aH5C4p47qA0(ProjectFolderItem.\u003C\u003Ec__DisplayClass10_0.awh683CNPcVpndreptt1((object) a), (object) foldername1)));
    }

    internal static void Hy5Ln2bK8c0FPs2ZHEhA() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool DLomaibKCdL0OKDreYDT() => ProjectFolderItem.GJ9wBKbKQid9cBpULNh5 == null;

    internal static ProjectFolderItem t4EJynbKvksvu14YvVLC() => ProjectFolderItem.GJ9wBKbKQid9cBpULNh5;
  }
}
