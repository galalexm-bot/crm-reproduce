// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Model.ContinueInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.FullTextSearch.Model
{
  /// <summary>Информация о продолжении индексации</summary>
  internal class ContinueInfo
  {
    /// <summary>Литера страницы</summary>
    public const string PageChar = "p";
    /// <summary>Литера последнего обработанного идентификатора</summary>
    public const string LastIdChar = "i";
    /// <summary>Литера попытки индексации</summary>
    public const string AttemptChar = "a";
    /// <summary>
    /// Информация о продолжении индексации в виде номеров проиндексированных страниц типов
    /// </summary>
    private readonly Dictionary<Guid, ContinueInfo.PageInfo> pagesInfo;
    private static ContinueInfo aqXCNxGRiTxLA4hCqcAI;

    /// <summary>Сгенерировать начальные данные</summary>
    public void PrepareEmptyPages()
    {
      int num1 = 1;
      IEnumerator<Type> enumerator;
      List<KeyValuePair<Type, Guid>> typePairs;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
            continue;
          case 2:
            List<KeyValuePair<Type, Guid>> source = typePairs;
            // ISSUE: reference to a compiler-generated field
            Func<KeyValuePair<Type, Guid>, Type> func1 = ContinueInfo.\u003C\u003Ec.\u003C\u003E9__0_1;
            Func<KeyValuePair<Type, Guid>, Type> selector;
            if (func1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              ContinueInfo.\u003C\u003Ec.\u003C\u003E9__0_1 = selector = (Func<KeyValuePair<Type, Guid>, Type>) (p => p.Key);
            }
            else
              goto label_33;
label_28:
            List<Type> list1 = source.Select<KeyValuePair<Type, Guid>, Type>(selector).ToList<Type>();
            // ISSUE: reference to a compiler-generated field
            Func<Type, bool> func2 = ContinueInfo.\u003C\u003Ec.\u003C\u003E9__0_2;
            Func<Type, bool> predicate;
            if (func2 == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              ContinueInfo.\u003C\u003Ec.\u003C\u003E9__0_2 = predicate = (Func<Type, bool>) (t => ContinueInfo.\u003C\u003Ec.CQjv1Wvck1Ze66pDQv6L(t, (Type) null));
            }
            else
              goto label_32;
label_31:
            enumerator = list1.Where<Type>(predicate).Distinct<Type>().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 4 : 1;
            continue;
label_32:
            predicate = func2;
            goto label_31;
label_33:
            selector = func1;
            goto label_28;
          case 3:
            goto label_29;
          case 4:
            goto label_4;
          default:
            List<IModuleFullTextSearchExtension> list2 = ComponentManager.Current.GetExtensionPoints<IModuleFullTextSearchExtension>().ToList<IModuleFullTextSearchExtension>();
            typePairs = new List<KeyValuePair<Type, Guid>>();
            Action<IModuleFullTextSearchExtension> action = (Action<IModuleFullTextSearchExtension>) (p =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    typePairs.AddRange((IEnumerable<KeyValuePair<Type, Guid>>) p.GetSupportedCardTypes());
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            });
            list2.ForEach(action);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 2 : 0;
            continue;
        }
      }
label_29:
      return;
label_4:
      try
      {
label_10:
        if (ContinueInfo.r0NCXkGRXbV0CI6QjxVJ((object) enumerator))
          goto label_12;
        else
          goto label_11;
label_5:
        int num3;
        while (true)
        {
          KeyValuePair<Type, Guid> keyValuePair;
          Guid empty;
          Type type;
          switch (num3)
          {
            case 1:
              type = enumerator.Current;
              num3 = 5;
              continue;
            case 2:
              goto label_10;
            case 3:
              empty = keyValuePair.Value;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
              continue;
            case 4:
              if (typePairs.Any<KeyValuePair<Type, Guid>>((Func<KeyValuePair<Type, Guid>, bool>) (p => p.Key == type)))
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 8;
                continue;
              }
              break;
            case 5:
              empty = Guid.Empty;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 4 : 2;
              continue;
            case 6:
              this.PagesInfo.Add(empty, new ContinueInfo.PageInfo());
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 2 : 0;
              continue;
            case 7:
              goto label_12;
            case 8:
              keyValuePair = typePairs.First<KeyValuePair<Type, Guid>>((Func<KeyValuePair<Type, Guid>, bool>) (p => p.Key == type));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 3 : 2;
              continue;
            case 9:
              goto label_26;
          }
          if (ContinueInfo.qivIgZGRK54qbGj3SeR3(empty, Guid.Empty))
            num3 = 6;
          else
            goto label_10;
        }
label_26:
        return;
label_11:
        num3 = 9;
        goto label_5;
label_12:
        num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
        {
          num3 = 0;
          goto label_5;
        }
        else
          goto label_5;
      }
      finally
      {
        if (enumerator != null)
        {
          int num4 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
            num4 = 0;
          while (true)
          {
            switch (num4)
            {
              case 1:
                ContinueInfo.ztWMu8GRTBBDdDpyEDvH((object) enumerator);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
                continue;
              default:
                goto label_24;
            }
          }
        }
label_24:;
      }
    }

    /// <summary>
    /// Информация о продолжении индексации в виде последних проиндексированных идентификаторов по типам
    /// </summary>
    public Dictionary<Guid, ContinueInfo.PageInfo> PagesInfo => this.pagesInfo;

    /// <summary>
    /// Добавление/обновление информации об обработанных страницах типа карточки
    /// </summary>
    /// <param name="typeUid">Идентификатор карточки</param>
    /// <param name="pageIndex">Индекс страницы</param>
    /// <param name="attempt">Попытка</param>
    public void AddPageInfo(Guid typeUid, int pageIndex, int attempt)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!ContinueInfo.NxEvLxGRktKcIatIfUCL(typeUid, Guid.Empty))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_4;
          case 3:
            goto label_3;
          default:
            Dictionary<Guid, ContinueInfo.PageInfo> pagesInfo = this.pagesInfo;
            Guid key = typeUid;
            ContinueInfo.PageInfo pageInfo = new ContinueInfo.PageInfo();
            pageInfo.Page = new int?(pageIndex);
            ContinueInfo.r4qr9FGRnCv2VyBN4lDP((object) pageInfo, attempt);
            pagesInfo[key] = pageInfo;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 2 : 2;
            continue;
        }
      }
label_4:
      return;
label_3:
      return;
label_2:;
    }

    /// <summary>
    /// Добавление/обновление информации об обработанных страницах типа карточки
    /// </summary>
    /// <param name="typeUid">Идентификатор карточки</param>
    /// <param name="lastId">Послнедний обработанный Id</param>
    /// <param name="attempt">Попытка</param>
    public void AddIdInfo(Guid typeUid, long lastId, int attempt)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_7;
          case 1:
            goto label_3;
          case 2:
            this.pagesInfo[typeUid] = new ContinueInfo.PageInfo()
            {
              LastId = new long?(lastId),
              Attempt = attempt
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 0;
            continue;
          case 3:
            if (!(typeUid == Guid.Empty))
            {
              num = 2;
              continue;
            }
            goto label_2;
          default:
            goto label_8;
        }
      }
label_7:
      return;
label_3:
      return;
label_8:
      return;
label_2:;
    }

    /// <summary>
    /// Удаление информации об обработанных страницах типа карточки
    /// </summary>
    /// <param name="typeUid">Идентификатор карточки</param>
    public void RemovePageInfo(Guid typeUid)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!ContinueInfo.NxEvLxGRktKcIatIfUCL(typeUid, Guid.Empty))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_5;
          case 3:
            goto label_6;
          default:
            this.pagesInfo.Remove(typeUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 2 : 2;
            continue;
        }
      }
label_5:
      return;
label_6:
      return;
label_2:;
    }

    public ContinueInfo()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.pagesInfo = new Dictionary<Guid, ContinueInfo.PageInfo>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool qivIgZGRK54qbGj3SeR3([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static bool r0NCXkGRXbV0CI6QjxVJ([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void ztWMu8GRTBBDdDpyEDvH([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool tVBXBfGRRAvDLsvDCl9S() => ContinueInfo.aqXCNxGRiTxLA4hCqcAI == null;

    internal static ContinueInfo q7TcpxGRqAtHSds9C2uu() => ContinueInfo.aqXCNxGRiTxLA4hCqcAI;

    internal static bool NxEvLxGRktKcIatIfUCL([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static void r4qr9FGRnCv2VyBN4lDP([In] object obj0, int value) => ((ContinueInfo.PageInfo) obj0).Attempt = value;

    /// <summary>Информация о текущей обрабатываемой пачке</summary>
    public class PageInfo
    {
      internal static ContinueInfo.PageInfo b5NUZ4vcQ4dAgTilH86g;

      /// <summary>Попытка индексации</summary>
      public int Attempt
      {
        get => this.\u003CAttempt\u003Ek__BackingField;
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
                this.\u003CAttempt\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
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

      /// <summary>Страница</summary>
      public int? Page { get; internal set; }

      /// <summary>Идентификатор последнего обработанного элемента</summary>
      public long? LastId { get; internal set; }

      public PageInfo()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool vQ5sEMvcC7wWbsNRWFtN() => ContinueInfo.PageInfo.b5NUZ4vcQ4dAgTilH86g == null;

      internal static ContinueInfo.PageInfo gxWxTYvcvdYTYYDCmcEU() => ContinueInfo.PageInfo.b5NUZ4vcQ4dAgTilH86g;
    }
  }
}
