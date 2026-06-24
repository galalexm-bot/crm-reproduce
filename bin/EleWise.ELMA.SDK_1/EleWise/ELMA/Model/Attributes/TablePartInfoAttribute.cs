// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.TablePartInfoAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Атрибут указывает информацию о метаданных блока</summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
  public class TablePartInfoAttribute : Attribute
  {
    internal static TablePartInfoAttribute HdPXVnoZ2RBDOEfO0OPY;

    /// <summary>
    /// Uid свойства, содержащего ссылку на родительский объект блока
    /// </summary>
    public Guid ParentPropertyUid
    {
      get => this.\u003CParentPropertyUid\u003Ek__BackingField;
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
              this.\u003CParentPropertyUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
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

    /// <summary>
    /// Uid свойства, содержащего ссылку на родительский объект блока (в строковом виде)
    /// </summary>
    public string ParentPropertyUidStr
    {
      get
      {
        int num = 1;
        Guid parentPropertyUid;
        while (true)
        {
          switch (num)
          {
            case 1:
              parentPropertyUid = this.ParentPropertyUid;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return parentPropertyUid.ToString();
      }
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_4;
            case 1:
              this.ParentPropertyUid = string.IsNullOrEmpty(value) ? Guid.Empty : new Guid(value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_4:
        return;
label_2:;
      }
    }

    /// <summary>Uid свойства, генерируемого для блока</summary>
    public Guid TablePartPropertyUid
    {
      get => this.\u003CTablePartPropertyUid\u003Ek__BackingField;
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
              this.\u003CTablePartPropertyUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
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

    /// <summary>
    /// Uid свойства, генерируемого для блока (в строковом виде)
    /// </summary>
    public string TablePartPropertyUidStr
    {
      get
      {
        int num = 1;
        Guid tablePartPropertyUid;
        while (true)
        {
          switch (num)
          {
            case 1:
              tablePartPropertyUid = this.TablePartPropertyUid;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return tablePartPropertyUid.ToString();
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
              this.TablePartPropertyUid = !TablePartInfoAttribute.qaPsOJoZ17i7L8LaVMFN((object) value) ? new Guid(value) : Guid.Empty;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
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

    /// <summary>Имя свойства, генерируемого для блока</summary>
    public string TablePartPropertyName
    {
      get => this.\u003CTablePartPropertyName\u003Ek__BackingField;
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
              this.\u003CTablePartPropertyName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
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

    public TablePartInfoAttribute()
    {
      TablePartInfoAttribute.FMLpf4oZNiwFqpYRVHYk();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool QmZdTpoZekYZBYXsrfkG() => TablePartInfoAttribute.HdPXVnoZ2RBDOEfO0OPY == null;

    internal static TablePartInfoAttribute yx9ovjoZPkyMwExZ2aOf() => TablePartInfoAttribute.HdPXVnoZ2RBDOEfO0OPY;

    internal static bool qaPsOJoZ17i7L8LaVMFN([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static void FMLpf4oZNiwFqpYRVHYk() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
