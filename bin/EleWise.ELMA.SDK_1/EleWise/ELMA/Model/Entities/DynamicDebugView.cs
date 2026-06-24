// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.DynamicDebugView
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Entities
{
  /// <summary>
  /// DebugView для <see cref="T:EleWise.ELMA.Model.Entities.IValueContainerObjectInternal" />
  /// </summary>
  internal class DynamicDebugView
  {
    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public readonly object data0;
    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public readonly object data1;
    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public readonly object data2;
    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public readonly object data3;
    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public readonly object data4;
    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public readonly object data5;
    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public readonly object data6;
    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public readonly object data7;
    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public readonly object data8;
    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public readonly object data9;
    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public readonly object data10;
    private static DynamicDebugView X2STtbh829ppvgyYgWK2;

    public DynamicDebugView(IValueContainerObjectInternal valueContainer)
    {
      DynamicDebugView.iah2p7h81NaxMNd763b9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 3;
      while (true)
      {
        switch (num1)
        {
          case 1:
            this.data0 = (object) new DynamicDebugView.EntityContainer(entity);
            num1 = 5;
            continue;
          case 2:
            this.data0 = (object) new DynamicDebugView.FilterContainer(filter);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
            continue;
          case 3:
            if (!(valueContainer is IEntity entity))
            {
              num1 = 6;
              continue;
            }
            goto case 1;
          case 4:
            goto label_9;
          case 5:
          case 6:
            if (!(valueContainer is IEntityFilter filter))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 5 : 7;
              continue;
            }
            goto case 2;
          default:
            valueContainer.GetData().Reverse<object>().Take<object>(10).ForEach<object>((Action<object, int>) ((d, i) =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: type reference
                    // ISSUE: explicit non-virtual call
                    __nonvirtual (DynamicDebugView.YjOmp9h8Ng7rePtUJO8X(__typeref (DynamicDebugView)).GetField((string) DynamicDebugView.jAT5y3h8pSK5ZMV035EI(DynamicDebugView.H4AltWh83nGEOxePmXUr(964881585 - -1459193222 ^ -1870712705), (object) (i + 1)))).SetValue((object) this, d);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 4;
            continue;
        }
      }
label_9:;
    }

    internal static void iah2p7h81NaxMNd763b9() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool QgcSHlh8e4qABvWLcd5w() => DynamicDebugView.X2STtbh829ppvgyYgWK2 == null;

    internal static DynamicDebugView bBKOuch8PqB7lkGJXuRw() => DynamicDebugView.X2STtbh829ppvgyYgWK2;

    internal static Type YjOmp9h8Ng7rePtUJO8X([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object H4AltWh83nGEOxePmXUr(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object jAT5y3h8pSK5ZMV035EI([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    private class EntityContainer
    {
      private static object XxyayXCsNsW3vDcoFj5s;

      public EntityContainer(IEntity entity)
      {
        DynamicDebugView.EntityContainer.Y9ddZUCsaElZ5nIZ0fcC();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.Id = entity.GetId();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_3:
        return;
label_5:;
      }

      public object Id { get; }

      internal static void Y9ddZUCsaElZ5nIZ0fcC() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool aO9thhCs3AeSWTWV2Qc8() => DynamicDebugView.EntityContainer.XxyayXCsNsW3vDcoFj5s == null;

      internal static DynamicDebugView.EntityContainer tqPygvCspRaloB6x9Mpt() => (DynamicDebugView.EntityContainer) DynamicDebugView.EntityContainer.XxyayXCsNsW3vDcoFj5s;
    }

    private class FilterContainer : IEntityFilter
    {
      private readonly object filter;
      internal static object MUxkMuCsDUhwZ2TUhh2N;

      public FilterContainer(IEntityFilter filter)
      {
        DynamicDebugView.FilterContainer.LiEtnRCs4eRy1rMXfJR8();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.filter = (object) filter;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_3:
        return;
label_5:;
      }

      public string SearchString
      {
        get => ((IEntityFilter) this.filter).SearchString;
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
                DynamicDebugView.FilterContainer.QN83PXCs6YxA3N1wrh6x(this.filter, (object) value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
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

      public Type Subtype
      {
        get => ((IEntityFilter) this.filter).Subtype;
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
                DynamicDebugView.FilterContainer.d4HKsfCsH1foqBYvXYoE(this.filter, value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
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

      public Guid? PermissionId
      {
        get => ((IEntityFilter) this.filter).PermissionId;
        set => ((IEntityFilter) this.filter).PermissionId = value;
      }

      public IUser PermissionUser
      {
        get => (IUser) DynamicDebugView.FilterContainer.lbjl64CsATikw3OV4Hiw(this.filter);
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
                DynamicDebugView.FilterContainer.RQoY8uCs7J9LnZJEZD2n(this.filter, (object) value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
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

      public bool DisableSecurity
      {
        get => DynamicDebugView.FilterContainer.rqpojaCsxHvVHIZ2shaE(this.filter);
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
                ((IEntityFilter) this.filter).DisableSecurity = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
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

      public bool DisableSoftDeletable
      {
        get => DynamicDebugView.FilterContainer.IGUTX4Cs0pONEckhNRIN(this.filter);
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
                DynamicDebugView.FilterContainer.lCXVAHCsmkX4WkAMlvDe(this.filter, value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
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

      public bool SkipAdminPermission
      {
        get => DynamicDebugView.FilterContainer.sMmcs9Csy38f6307lIjn(this.filter);
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
                DynamicDebugView.FilterContainer.NvafAnCsMkJQ7Od7roI3(this.filter, value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
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

      public object Id
      {
        get => DynamicDebugView.FilterContainer.dHDoDCCsJnGGekafBfsD(this.filter);
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
                DynamicDebugView.FilterContainer.baSSySCs92EBGho3nI0c(this.filter, value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
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

      public object HierarchyParent
      {
        get => DynamicDebugView.FilterContainer.zUDs6qCsdqOC2MYtjWwa(this.filter);
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
                DynamicDebugView.FilterContainer.o5WkM3CslMI4utVYnKqm(this.filter, value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
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

      public bool FilterByHierarchyParent
      {
        get => DynamicDebugView.FilterContainer.gnkhOBCsrZH0aQBx3mJL(this.filter);
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
                ((IEntityFilter) this.filter).FilterByHierarchyParent = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
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

      public bool DisableAutoFilter
      {
        get => DynamicDebugView.FilterContainer.o0T7hICsgpxaXWvaNMUf(this.filter);
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
                DynamicDebugView.FilterContainer.QM6isxCs51NXprEP6UrZ(this.filter, value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
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

      public bool ShowOnlyGroups
      {
        get => ((IEntityFilter) this.filter).ShowOnlyGroups;
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
                DynamicDebugView.FilterContainer.Oo9Oa1CsjDAtSrBf7V52(this.filter, value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
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

      public bool FullTextInAttachments
      {
        get => DynamicDebugView.FilterContainer.dJPbc4CsYX0qrAHQscch(this.filter);
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
                DynamicDebugView.FilterContainer.qCKx9fCsL8hbUa0X7qPN(this.filter, value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
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

      public string Query
      {
        get => (string) DynamicDebugView.FilterContainer.CWmVlZCsUT53PGbGWAej(this.filter);
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
                DynamicDebugView.FilterContainer.BykLmiCssq8pNRHSb1QR(this.filter, (object) value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
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

      public QueryParameters QueryParameters => (QueryParameters) DynamicDebugView.FilterContainer.mPvfsECscsyvnRV0Rsgf(this.filter);

      bool IEntityFilter.IsEmpty() => throw new NotImplementedException();

      internal static void LiEtnRCs4eRy1rMXfJR8() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool uVXK4WCstlTOi4bWVF9i() => DynamicDebugView.FilterContainer.MUxkMuCsDUhwZ2TUhh2N == null;

      internal static DynamicDebugView.FilterContainer FD4dm6Cswq9KmWtR8pHA() => (DynamicDebugView.FilterContainer) DynamicDebugView.FilterContainer.MUxkMuCsDUhwZ2TUhh2N;

      internal static void QN83PXCs6YxA3N1wrh6x([In] object obj0, [In] object obj1) => ((IEntityFilter) obj0).SearchString = (string) obj1;

      internal static void d4HKsfCsH1foqBYvXYoE([In] object obj0, Type value) => ((IEntityFilter) obj0).Subtype = value;

      internal static object lbjl64CsATikw3OV4Hiw([In] object obj0) => (object) ((IEntityFilter) obj0).PermissionUser;

      internal static void RQoY8uCs7J9LnZJEZD2n([In] object obj0, [In] object obj1) => ((IEntityFilter) obj0).PermissionUser = (IUser) obj1;

      internal static bool rqpojaCsxHvVHIZ2shaE([In] object obj0) => ((IEntityFilter) obj0).DisableSecurity;

      internal static bool IGUTX4Cs0pONEckhNRIN([In] object obj0) => ((IEntityFilter) obj0).DisableSoftDeletable;

      internal static void lCXVAHCsmkX4WkAMlvDe([In] object obj0, bool value) => ((IEntityFilter) obj0).DisableSoftDeletable = value;

      internal static bool sMmcs9Csy38f6307lIjn([In] object obj0) => ((IEntityFilter) obj0).SkipAdminPermission;

      internal static void NvafAnCsMkJQ7Od7roI3([In] object obj0, bool value) => ((IEntityFilter) obj0).SkipAdminPermission = value;

      internal static object dHDoDCCsJnGGekafBfsD([In] object obj0) => ((IEntityFilter) obj0).Id;

      internal static void baSSySCs92EBGho3nI0c([In] object obj0, [In] object obj1) => ((IEntityFilter) obj0).Id = obj1;

      internal static object zUDs6qCsdqOC2MYtjWwa([In] object obj0) => ((IEntityFilter) obj0).HierarchyParent;

      internal static void o5WkM3CslMI4utVYnKqm([In] object obj0, [In] object obj1) => ((IEntityFilter) obj0).HierarchyParent = obj1;

      internal static bool gnkhOBCsrZH0aQBx3mJL([In] object obj0) => ((IEntityFilter) obj0).FilterByHierarchyParent;

      internal static bool o0T7hICsgpxaXWvaNMUf([In] object obj0) => ((IEntityFilter) obj0).DisableAutoFilter;

      internal static void QM6isxCs51NXprEP6UrZ([In] object obj0, bool value) => ((IEntityFilter) obj0).DisableAutoFilter = value;

      internal static void Oo9Oa1CsjDAtSrBf7V52([In] object obj0, bool value) => ((IEntityFilter) obj0).ShowOnlyGroups = value;

      internal static bool dJPbc4CsYX0qrAHQscch([In] object obj0) => ((IEntityFilter) obj0).FullTextInAttachments;

      internal static void qCKx9fCsL8hbUa0X7qPN([In] object obj0, bool value) => ((IEntityFilter) obj0).FullTextInAttachments = value;

      internal static object CWmVlZCsUT53PGbGWAej([In] object obj0) => (object) ((IEntityFilter) obj0).Query;

      internal static void BykLmiCssq8pNRHSb1QR([In] object obj0, [In] object obj1) => ((IEntityFilter) obj0).Query = (string) obj1;

      internal static object mPvfsECscsyvnRV0Rsgf([In] object obj0) => (object) ((IEntityFilter) obj0).QueryParameters;
    }
  }
}
