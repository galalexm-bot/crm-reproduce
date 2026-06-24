// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Services.FindComponent.ComponentGraph
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Services.FindComponent
{
  /// <summary>Граф компонентов</summary>
  internal sealed class ComponentGraph
  {
    private readonly Dictionary<Guid, ComponentGraph.Vertex> vertices;
    private static ComponentGraph jm5dxeBBBefFsXqgPk6w;

    /// <summary>Ctor</summary>
    internal ComponentGraph()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.vertices = new Dictionary<Guid, ComponentGraph.Vertex>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Очистить граф</summary>
    internal void Clear()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ComponentGraph.tCG64fBBb2sduDh2w84v((object) this.vertices);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Добавить заголовочную вершину</summary>
    /// <param name="headerUid">Уникальный идентификатор заголовка</param>
    /// <param name="itemUid">Уникальный идентификатор элемента</param>
    /// <param name="moduleUid">Уникальный идентификатор модуля</param>
    /// <param name="async">Является асинхронным</param>
    /// <returns>Вершина</returns>
    internal ComponentGraph.Vertex AddHeadVertex(
      Guid headerUid,
      Guid itemUid,
      Guid moduleUid,
      bool async)
    {
      return this.AddVertex(headerUid, itemUid, moduleUid, Guid.Empty, (string) null, Guid.Empty, async);
    }

    /// <summary>Добавить вершину</summary>
    /// <param name="headerUid">Уникальный идентификатор заголовка</param>
    /// <param name="itemUid">Уникальный идентификатор элемента</param>
    /// <param name="moduleUid">Уникальный идентификатор модуля</param>
    /// <param name="parent">Уникальный идентификатор родительской вершины</param>
    /// <param name="renderUid">Уникальный идентификатор при рендере</param>
    /// <param name="owner">Уникальный идентификатор компонента, являющегося обладателем</param>
    /// <param name="async">Асинхронный</param>
    /// <returns>Вершина</returns>
    internal ComponentGraph.Vertex AddVertex(
      Guid headerUid,
      Guid itemUid,
      Guid moduleUid,
      Guid parent,
      string renderUid,
      Guid owner,
      bool async)
    {
      int num1 = 11;
      ComponentGraph.Vertex vertex1;
      while (true)
      {
        int num2 = num1;
        ComponentGraph.Vertex vertex2;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 10:
              if (!ComponentGraph.BdG6BkBBhyOZphEYdHFE((object) renderUid))
              {
                num2 = 2;
                continue;
              }
              goto case 5;
            case 2:
              vertex1.ViewItemUidList.Add(renderUid);
              num2 = 5;
              continue;
            case 3:
              if (vertex1.Async != async)
              {
                num2 = 8;
                continue;
              }
              goto label_10;
            case 4:
              if (!ComponentGraph.JfC6fRBBEOLn0V9caqvB((object) this.vertices[owner]))
              {
                num2 = 3;
                continue;
              }
              goto label_10;
            case 5:
              if (ComponentGraph.Uqep2sBBG1Npxvgft2WR(owner, Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 4 : 0;
                continue;
              }
              goto case 9;
            case 6:
              vertex1 = vertex2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 0;
              continue;
            case 7:
              this.vertices[itemUid] = vertex2 = new ComponentGraph.Vertex(headerUid, itemUid, moduleUid, async);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 1 : 6;
              continue;
            case 8:
              ComponentGraph.p8C8HGBBfKnhbYtB6SFQ((object) vertex1, false);
              num2 = 12;
              continue;
            case 9:
              ComponentGraph.OT7EKiBBQbY2Uemu2pMZ(parent, Guid.Empty);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
              continue;
            case 11:
              if (this.vertices.TryGetValue(itemUid, out vertex1))
              {
                num2 = 10;
                continue;
              }
              goto case 7;
            case 12:
              goto label_10;
            default:
              goto label_16;
          }
        }
label_10:
        vertex1.Owners.Add(owner);
        num1 = 9;
      }
label_16:
      return vertex1;
    }

    internal static bool pK2SYdBBWakhZl6GUwb1() => ComponentGraph.jm5dxeBBBefFsXqgPk6w == null;

    internal static ComponentGraph re0AixBBo0XLDoLT1kHa() => ComponentGraph.jm5dxeBBBefFsXqgPk6w;

    internal static void tCG64fBBb2sduDh2w84v([In] object obj0) => ((Dictionary<Guid, ComponentGraph.Vertex>) obj0).Clear();

    internal static bool BdG6BkBBhyOZphEYdHFE([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static bool Uqep2sBBG1Npxvgft2WR([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static bool JfC6fRBBEOLn0V9caqvB([In] object obj0) => ((ComponentGraph.Vertex) obj0).Async;

    internal static void p8C8HGBBfKnhbYtB6SFQ([In] object obj0, bool value) => ((ComponentGraph.Vertex) obj0).Async = value;

    internal static bool OT7EKiBBQbY2Uemu2pMZ([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    /// <summary>Вершина</summary>
    internal class Vertex
    {
      private static ComponentGraph.Vertex E7x7UhQWNbk6byR2aP1Q;

      /// <summary>Ctor</summary>
      /// <param name="headerUid">Уникальный идентификатор заголовка</param>
      /// <param name="itemUid">Уникальный идентификатор элемента</param>
      /// <param name="moduleUid">Уникальный идентификатор модуля</param>
      /// <param name="async">Является асинхронным</param>
      internal Vertex(Guid headerUid, Guid itemUid, Guid moduleUid, bool async)
      {
        ComponentGraph.Vertex.ae20kDQWaTpH6MeaG4cw();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 4;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
          num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.ModuleUid = moduleUid;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_3;
            case 3:
              this.ItemUid = itemUid;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 1 : 0;
              continue;
            case 4:
              this.HeaderUid = headerUid;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 1 : 3;
              continue;
            case 5:
              this.Owners = new HashSet<Guid>();
              num = 6;
              continue;
            case 6:
              this.ViewItemUidList = new HashSet<string>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 2 : 2;
              continue;
            default:
              this.Async = async;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 5;
              continue;
          }
        }
label_3:;
      }

      /// <summary>Уникальный идентификатор заголовка</summary>
      internal Guid HeaderUid { get; }

      /// <summary>Уникальный идентификатор элемента</summary>
      internal Guid ItemUid { get; }

      /// <summary>Уникальный идентификатор модуля</summary>
      internal Guid ModuleUid { get; }

      /// <summary>Является асинхронным</summary>
      internal bool Async
      {
        get => this.\u003CAsync\u003Ek__BackingField;
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
                this.\u003CAsync\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
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

      /// <summary>Список "обладателей"</summary>
      internal HashSet<Guid> Owners { get; }

      /// <summary>Список уникальных идентификаторов при рендере</summary>
      internal HashSet<string> ViewItemUidList { get; }

      internal static void ae20kDQWaTpH6MeaG4cw() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool M4gGE2QW36G6f5heeeOC() => ComponentGraph.Vertex.E7x7UhQWNbk6byR2aP1Q == null;

      internal static ComponentGraph.Vertex RZxMSxQWp6lc6uDmZfZT() => ComponentGraph.Vertex.E7x7UhQWNbk6byR2aP1Q;
    }
  }
}
