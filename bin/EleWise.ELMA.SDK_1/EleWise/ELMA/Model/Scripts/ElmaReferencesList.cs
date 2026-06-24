// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.ElmaReferencesList
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>Список ссылок на сборки ELMA</summary>
  internal class ElmaReferencesList
  {
    private readonly HashSet<string> referenceContainer;
    private static ElmaReferencesList kB5OQbbZs5KJtniYp37i;

    /// <summary>Ctor</summary>
    /// <param name="marker">Значение маркера подключения всех ссылок на сборки ELMA</param>
    /// <param name="references">Начальный набор ссылок</param>
    public ElmaReferencesList(bool marker, IEnumerable<string> references)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.referenceContainer = new HashSet<string>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.AllReferencesMarker = marker;
      this.referenceContainer.AddAll<string>(references);
    }

    /// <summary>
    /// Маркер (признак) подключения всех ссылок на сборки ELMA для редактора кода (omnisharp)
    /// </summary>
    internal bool AllReferencesMarker
    {
      get => this.\u003CAllReferencesMarker\u003Ek__BackingField;
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
              this.\u003CAllReferencesMarker\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
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

    /// <summary>Список используемых сборок</summary>
    internal IEnumerable<string> References => (IEnumerable<string>) this.referenceContainer;

    /// <summary>Включать ли все ссылки в проект?</summary>
    internal bool IncudeAllReferences => this.AllReferencesMarker;

    /// <summary>Добавить ссылку на сборку. Дубликаты не добавляются!</summary>
    /// <param name="reference">Имя сборки</param>
    internal void Add(string reference)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.referenceContainer.Add(reference);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>
    /// Добавить набор ссылок на сборки. Дубликаты не добавляются!
    /// </summary>
    /// <param name="references">Набор имён сборок</param>
    internal void AddRange(IEnumerable<string> references) => this.referenceContainer.AddAll<string>(references);

    /// <summary>Проверить наличие ссылки в списке</summary>
    /// <param name="reference">Имя сборки</param>
    /// <returns><c>true</c> - ссылка присутствует в списке, <c>false</c> - ссылки нет в списке</returns>
    internal bool Contains(string reference) => this.referenceContainer.Contains(reference);

    /// <summary>Удалить ссылку из списка</summary>
    /// <param name="reference">Имя сборки</param>
    /// <returns><c>true</c> - ссылка была удалена, <c>false</c> - ссылки нет в списке</returns>
    internal bool Remove(string reference) => this.referenceContainer.Remove(reference);

    internal static bool eF1eg8bZcr2pQdV1Pita() => ElmaReferencesList.kB5OQbbZs5KJtniYp37i == null;

    internal static ElmaReferencesList TlvEBxbZzy4NQRDgpCGj() => ElmaReferencesList.kB5OQbbZs5KJtniYp37i;
  }
}
