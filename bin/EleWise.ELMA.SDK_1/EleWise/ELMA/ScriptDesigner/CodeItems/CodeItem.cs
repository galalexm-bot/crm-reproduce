// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.CodeItems.CodeItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.ScriptDesigner.CodeItems
{
  /// <summary>Элемент кода (базовая реализация)</summary>
  [Component]
  [Serializable]
  public abstract class CodeItem : ICodeItem, IXsiType
  {
    internal Guid? uid;
    private static CodeItem ohFxYiiZg0DQCwRB76r;

    /// <summary>Имя</summary>
    [XmlElement("Name")]
    public string Name
    {
      get => this.\u003CName\u003Ek__BackingField;
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
              this.\u003CName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
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

    /// <summary>Уникальный идентификатор элемента представления</summary>
    [XmlElement("Uid")]
    public virtual Guid Uid
    {
      get
      {
        int num1 = 3;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                this.uid = new Guid?(Guid.NewGuid());
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
                continue;
              case 3:
                if (!this.uid.HasValue)
                  goto case 1;
                else
                  goto label_4;
              default:
                goto label_5;
            }
          }
label_4:
          num1 = 2;
        }
label_5:
        return this.uid.Value;
      }
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
              this.uid = new Guid?(value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
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

    public virtual void InitNew(ICodeItem parent)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            if (!CodeItem.CuiemCiSHN5obC6KI8A(CodeItem.xNOIOjiVvQoMDw0iGFp((object) this), Guid.Empty))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 1 : 1;
              continue;
            }
            break;
          case 3:
            goto label_2;
        }
        CodeItem.j2MiFqiRU7WYWQxkJIn((object) this, CodeItem.cE8igSiigHlcujHgptW());
        num = 3;
      }
label_4:
      return;
label_2:;
    }

    public abstract bool IsValidParent(ICodeItem codeItem);

    public abstract CodeStatement ToCodeStatement();

    public abstract CodeExpression ToCodeExpression();

    public abstract CodeStatement[] ToCodeStatementList();

    public abstract List<Type> GetValidToInsert();

    protected CodeItem()
    {
      CodeItem.y2y5mYiq02wudypYElH();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool rErTWDiu5dA97Fasxlf() => CodeItem.ohFxYiiZg0DQCwRB76r == null;

    internal static CodeItem mBDcXbiIS6yGP7AFI4F() => CodeItem.ohFxYiiZg0DQCwRB76r;

    internal static Guid xNOIOjiVvQoMDw0iGFp([In] object obj0) => ((CodeItem) obj0).Uid;

    internal static bool CuiemCiSHN5obC6KI8A([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static Guid cE8igSiigHlcujHgptW() => Guid.NewGuid();

    internal static void j2MiFqiRU7WYWQxkJIn([In] object obj0, Guid value) => ((CodeItem) obj0).Uid = value;

    internal static void y2y5mYiq02wudypYElH() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
