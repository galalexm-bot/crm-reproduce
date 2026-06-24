// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.PublicApi.PublicApiStaticPropertyClassRootNode
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi
{
  public class PublicApiStaticPropertyClassRootNode : IPublicApiNode
  {
    protected readonly string className;
    protected readonly string propertyName;
    protected readonly string fieldName;
    protected readonly bool @sealed;
    protected const string ParentPath = "PublicAPI";
    internal static PublicApiStaticPropertyClassRootNode nsy6DihAzcCNDb3S8VUL;

    protected PublicApiStaticPropertyClassRootNode(
      string className,
      string propertyName,
      bool @sealed = true)
    {
      PublicApiStaticPropertyClassRootNode.K48aHlh7W9gmnQOn92PO();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
        num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.@sealed = @sealed;
            num = 4;
            continue;
          case 2:
            this.propertyName = propertyName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
            continue;
          case 3:
            this.className = className;
            num = 2;
            continue;
          case 4:
            goto label_3;
          default:
            this.fieldName = (string) PublicApiStaticPropertyClassRootNode.pWWGSyh7bKgpfleFRual(PublicApiStaticPropertyClassRootNode.z8Md7sh7o7l59kHmdoPJ(-1445902765 ^ -1980277732 ^ 539334893), (object) propertyName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    string IPublicApiNode.ParentPath => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837890197);

    public string Path => (string) PublicApiStaticPropertyClassRootNode.pWWGSyh7bKgpfleFRual(PublicApiStaticPropertyClassRootNode.z8Md7sh7o7l59kHmdoPJ(236071375 ^ 236038803), (object) this.propertyName);

    public virtual string Description
    {
      get => this.\u003CDescription\u003Ek__BackingField;
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
              this.\u003CDescription\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
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

    public virtual string Remarks
    {
      get => this.\u003CRemarks\u003Ek__BackingField;
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
              this.\u003CRemarks\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
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

    public virtual string Code
    {
      get => this.\u003CCode\u003Ek__BackingField;
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
              this.\u003CCode\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
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

    public IEnumerable<ISyntaxNode> Generate(
      IDictionary<string, IEnumerable<IPublicApiNode>> tree)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<ISyntaxNode>) new PublicApiStaticPropertyClassRootNode.\u003CGenerate\u003Ed__22(-2)
      {
        \u003C\u003E4__this = this,
        \u003C\u003E3__tree = tree
      };
    }

    internal static void K48aHlh7W9gmnQOn92PO() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object z8Md7sh7o7l59kHmdoPJ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object pWWGSyh7bKgpfleFRual([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static bool tZOyv2h7FXVGcdK41mpH() => PublicApiStaticPropertyClassRootNode.nsy6DihAzcCNDb3S8VUL == null;

    internal static PublicApiStaticPropertyClassRootNode vFfw1Yh7BXsnnOJn1Y05() => PublicApiStaticPropertyClassRootNode.nsy6DihAzcCNDb3S8VUL;
  }
}
