// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.DataClassMetadataItemFilter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Фильтр для объекта "Элемент метаданных датакласса"</summary>
  [FilterFor(typeof (DataClassMetadataItem))]
  public class DataClassMetadataItemFilter : Filter
  {
    private DateTimeRange _creationDate;
    private string _assemblyName;
    private string _assemblyVersion;
    private static DataClassMetadataItemFilter cgYybpbphHMHOeEWaXot;

    public DataClassMetadataItemFilter()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Фильтр для свойства "Дата создания"</summary>
    public virtual DateTimeRange CreationDate
    {
      get => this._creationDate;
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
              this._creationDate = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
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

    /// <summary>Фильтр для свойства "Имя сборки"</summary>
    public virtual string AssemblyName
    {
      get => this._assemblyName;
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
              this._assemblyName = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
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

    /// <summary>Фильтр для свойства "Версия сборки"</summary>
    public virtual string AssemblyVersion
    {
      get => this._assemblyVersion;
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
              this._assemblyVersion = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
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

    internal static bool T0B3RWbpG1yk3gt1ao6Y() => DataClassMetadataItemFilter.cgYybpbphHMHOeEWaXot == null;

    internal static DataClassMetadataItemFilter C4fWrfbpEftCbUMnT56G() => DataClassMetadataItemFilter.cgYybpbphHMHOeEWaXot;
  }
}
