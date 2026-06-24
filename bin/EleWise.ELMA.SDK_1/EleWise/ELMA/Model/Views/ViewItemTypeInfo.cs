// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ViewItemTypeInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Информация о типе элемента представления</summary>
  public class ViewItemTypeInfo
  {
    private Type viewItemType;
    internal string name;
    internal string originalName;
    private static ViewItemTypeInfo U80R0poPqN5uhtTCJoVD;

    public ViewItemTypeInfo(Type viewItemType)
    {
      ViewItemTypeInfo.IFs2XmoPTtWbUAMuar1H();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0)
        num = 0;
      ClassMetadata classMetadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            classMetadata = (ClassMetadata) MetadataLoader.LoadMetadata(viewItemType);
            num = 2;
            continue;
          case 2:
            this.originalName = (string) ViewItemTypeInfo.zKLAhpoPncP5NfhbaXpS((object) classMetadata);
            num = 4;
            continue;
          case 3:
            goto label_5;
          case 4:
            goto label_3;
          default:
            if (!(viewItemType == (Type) null))
            {
              this.viewItemType = viewItemType;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 1 : 1;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 3 : 3;
            continue;
        }
      }
label_3:
      return;
label_5:
      throw new ArgumentNullException((string) ViewItemTypeInfo.l8wVswoPkHMG1pjDvofH(825385222 ^ 825229984));
    }

    /// <summary>Тип элемента представления</summary>
    public Type ViewItemType => this.viewItemType;

    /// <summary>Имя элемента представления</summary>
    public string Name
    {
      get
      {
        int num = 1;
        string name;
        while (true)
        {
          switch (num)
          {
            case 1:
              name = this.name;
              if (name == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return name;
label_5:
        return this.originalName;
      }
    }

    internal static void IFs2XmoPTtWbUAMuar1H() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object l8wVswoPkHMG1pjDvofH(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object zKLAhpoPncP5NfhbaXpS([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static bool SJNiXuoPKMoCDx4yKCw7() => ViewItemTypeInfo.U80R0poPqN5uhtTCJoVD == null;

    internal static ViewItemTypeInfo Fm8uIkoPXIVN4OCkEbwo() => ViewItemTypeInfo.U80R0poPqN5uhtTCJoVD;
  }
}
