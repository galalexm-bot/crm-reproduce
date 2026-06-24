// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.EntityListInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Entities
{
  /// <summary>Информация о списке сущностей</summary>
  [Serializable]
  public class EntityListInfo : EntityInfoBase, ICloneable
  {
    private List<EntityInfo> items;
    private static EntityListInfo oRROXohZoFj6tekRgEI7;

    /// <summary>Элементы списка</summary>
    public List<EntityInfo> Items => this.items;

    public override string ToString()
    {
      object separator = EntityListInfo.n0cutHhZGHP53KyJr66k(1253244298 - 1829393894 ^ -575937026);
      List<EntityInfo> items = this.Items;
      // ISSUE: reference to a compiler-generated field
      Func<EntityInfo, string> func = EntityListInfo.\u003C\u003Ec.\u003C\u003E9__2_0;
      Func<EntityInfo, string> selector;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        EntityListInfo.\u003C\u003Ec.\u003C\u003E9__2_0 = selector = (Func<EntityInfo, string>) (i => i.ToString());
      }
      else
        goto label_1;
label_3:
      IEnumerable<string> values = items.Select<EntityInfo, string>(selector);
      return string.Join((string) separator, values);
label_1:
      selector = func;
      goto label_3;
    }

    public virtual EntityListInfo Clone()
    {
      EntityListInfo entityListInfo = new EntityListInfo();
      // ISSUE: reference to a compiler-generated method
      entityListInfo.Items.AddRange(this.Items.Select<EntityInfo, EntityInfo>((Func<EntityInfo, EntityInfo>) (a => (EntityInfo) EntityListInfo.\u003C\u003Ec.bofvfNCcfhe88QSbf9vH((object) a))));
      return entityListInfo;
    }

    object ICloneable.Clone() => EntityListInfo.NLHmxZhZELhqVptwXnaZ((object) this);

    public EntityListInfo()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.items = new List<EntityInfo>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object n0cutHhZGHP53KyJr66k(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool D5soWdhZb7ZhlEPMFl0V() => EntityListInfo.oRROXohZoFj6tekRgEI7 == null;

    internal static EntityListInfo YYFfC5hZhNuiYgK976O4() => EntityListInfo.oRROXohZoFj6tekRgEI7;

    internal static object NLHmxZhZELhqVptwXnaZ([In] object obj0) => (object) ((EntityListInfo) obj0).Clone();
  }
}
