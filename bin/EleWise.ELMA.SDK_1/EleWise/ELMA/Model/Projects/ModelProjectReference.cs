// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Projects.ModelProjectReference
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using Microsoft.Build.Construction;
using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Projects
{
  /// <summary>Ссылка проекта модели на другой проект/сборку</summary>
  public class ModelProjectReference
  {
    private ModelProject project;
    private ProjectItemElement item;
    private string path;
    private static ModelProjectReference NN9ToJWjQ4ouHPVnDQMi;

    /// <summary>Конструктор</summary>
    /// <param name="project">Проект-владелец</param>
    /// <param name="item">Элемент проекта со ссылкой на сборку</param>
    public ModelProjectReference(ModelProject project, ProjectItemElement item)
    {
      ModelProjectReference.XK7B5UWj8LKKFcTLiUJY();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
        num = 0;
      ProjectMetadataElement projectMetadataElement;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.project = project;
            num = 2;
            continue;
          case 2:
            this.item = item;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 4 : 1;
            continue;
          case 3:
            this.path = projectMetadataElement != null ? (string) ModelProjectReference.XF3ZxpWjZVnGwRceTmcI((object) projectMetadataElement) : (string) (object) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 0 : 0;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            projectMetadataElement = item.Metadata.FirstOrDefault<ProjectMetadataElement>((Func<ProjectMetadataElement, bool>) (m => (string) ModelProjectReference.\u003C\u003Ec.Noag7iCFO6K3LRgmkKRY((object) m) == (string) ModelProjectReference.\u003C\u003Ec.QJZW8ICF2WJDUiSyXKQD(1253244298 - 1829393894 ^ -576022296)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 3;
            continue;
          default:
            goto label_8;
        }
      }
label_3:
      return;
label_8:;
    }

    /// <summary>Имя сборки</summary>
    public string Name => (string) ModelProjectReference.puprxpWjuS3jO87mY7HB((object) this.item);

    /// <summary>Относительный путь до сборки</summary>
    public string HintPath => this.path;

    /// <summary>Полный путь до сборки</summary>
    public string FullPath
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!string.IsNullOrEmpty(this.path))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 2:
              goto label_4;
            default:
              goto label_5;
          }
        }
label_4:
        return (string) null;
label_5:
        return Path.Combine((string) ModelProjectReference.HhTDKnWjI4NrZYS2xnRf((object) this.project), this.path);
      }
    }

    internal static void XK7B5UWj8LKKFcTLiUJY() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object XF3ZxpWjZVnGwRceTmcI([In] object obj0) => (object) ((ProjectMetadataElement) obj0).Value;

    internal static bool zgloeUWjC8hJQBcBeWc7() => ModelProjectReference.NN9ToJWjQ4ouHPVnDQMi == null;

    internal static ModelProjectReference Ph7ljnWjvd4UHqwvlaca() => ModelProjectReference.NN9ToJWjQ4ouHPVnDQMi;

    internal static object puprxpWjuS3jO87mY7HB([In] object obj0) => (object) ((ProjectItemElement) obj0).Include;

    internal static object HhTDKnWjI4NrZYS2xnRf([In] object obj0) => (object) ((ModelProject) obj0).ProjectDir;
  }
}
