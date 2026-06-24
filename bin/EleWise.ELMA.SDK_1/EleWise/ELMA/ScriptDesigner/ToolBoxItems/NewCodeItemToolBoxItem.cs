// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.ToolBoxItems.NewCodeItemToolBoxItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.ScriptDesigner.CodeItems;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.ScriptDesigner.ToolBoxItems
{
  /// <summary>
  /// Новый элемент кода в панели инструментов (базовая реализация)
  /// </summary>
  [Component]
  [Serializable]
  public abstract class NewCodeItemToolBoxItem : INewCodeItemToolBoxItem, ICodeItemPoint, IXsiType
  {
    private ITypeDescriptor _typeDescriptor;
    private static NewCodeItemToolBoxItem qLeascVuUFWVLdvIHyE;

    public abstract string Name { get; set; }

    public abstract Guid GroupUid { get; }

    public virtual Image Image => (Image) null;

    [XmlIgnore]
    public abstract Type CodeItemType { get; set; }

    public string CodeItemTypeName
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (NewCodeItemToolBoxItem.ACtUTcVi0UsSJN3GGOq(NewCodeItemToolBoxItem.KJj5YAVSpgDyyAQNEpD((object) this), (Type) null))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_2;
            default:
              goto label_3;
          }
        }
label_2:
        return (string) null;
label_3:
        return NewCodeItemToolBoxItem.KJj5YAVSpgDyyAQNEpD((object) this).AssemblyQualifiedName;
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
              this.CodeItemType = value != null ? NewCodeItemToolBoxItem.FkhTSDVRcIY8ClfHqJQ((object) value) : (Type) null;
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

    public List<string> DisplayNames { get; set; }

    public List<string> PropertyNames { get; set; }

    [XmlIgnore]
    public IMetadata PropertyMetadata
    {
      get => this.\u003CPropertyMetadata\u003Ek__BackingField;
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
              this.\u003CPropertyMetadata\u003Ek__BackingField = value;
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
    }

    public abstract ICodeItem CreateCodeItem();

    public string Path
    {
      get => this.\u003CPath\u003Ek__BackingField;
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
              this.\u003CPath\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
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

    public Guid TypeUid
    {
      get => this.\u003CTypeUid\u003Ek__BackingField;
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
              this.\u003CTypeUid\u003Ek__BackingField = value;
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

    public Guid SubTypeUid
    {
      get => this.\u003CSubTypeUid\u003Ek__BackingField;
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
              this.\u003CSubTypeUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
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

    [XmlIgnore]
    public ITypeDescriptor TypeDescriptor
    {
      get
      {
        int num = 2;
        ITypeDescriptor typeDescriptor1;
        ITypeDescriptor typeDescriptor2;
        while (true)
        {
          switch (num)
          {
            case 1:
              this._typeDescriptor = typeDescriptor1 = (ITypeDescriptor) NewCodeItemToolBoxItem.uYAuxRVKa3dNPTrlBQQ(NewCodeItemToolBoxItem.O7TA90VqqOW0WuRJ0YY(), this.TypeUid, this.SubTypeUid);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
              continue;
            case 2:
              typeDescriptor2 = this._typeDescriptor;
              if (typeDescriptor2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_6;
          }
        }
label_2:
        return typeDescriptor2;
label_6:
        return typeDescriptor1;
      }
    }

    public virtual string DisplayName
    {
      get
      {
        int num = 1;
        List<string> displayNames;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.DisplayNames != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
                continue;
              }
              goto case 2;
            case 2:
              this.DisplayNames = new List<string>();
              num = 3;
              continue;
            case 4:
              goto label_4;
            default:
              displayNames = this.DisplayNames;
              num = 4;
              continue;
          }
        }
label_4:
        return string.Join((string) NewCodeItemToolBoxItem.e1T69bVX6kDMFZZeBjl(-488881205 ^ -488875761), (IEnumerable<string>) displayNames);
      }
      set
      {
      }
    }

    /// <summary>Переименовать</summary>
    /// <param name="newName"></param>
    public void Rename(string newName)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.PropertyNames.Insert(0, (string) NewCodeItemToolBoxItem.cbc4dlVk1psvaGVcl1L((object) newName));
            num = 4;
            continue;
          case 2:
            this.DisplayNames.Insert(0, newName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
            continue;
          case 3:
            this.DisplayNames.RemoveAt(0);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 2;
            continue;
          case 4:
            goto label_2;
          default:
            NewCodeItemToolBoxItem.oUNQroVTlDyWsOOQhG7((object) this.PropertyNames, 0);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    public virtual string VariableName
    {
      get
      {
        int num1 = 2;
        List<string>.Enumerator enumerator;
        List<string> values;
        while (true)
        {
          switch (num1)
          {
            case 1:
              this.PropertyNames = new List<string>();
              num1 = 4;
              continue;
            case 2:
              if (this.PropertyNames == null)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 1;
                continue;
              }
              goto case 4;
            case 3:
              goto label_15;
            case 4:
              values = new List<string>();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 5 : 1;
              continue;
            case 5:
              enumerator = this.PropertyNames.GetEnumerator();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        try
        {
label_9:
          if (enumerator.MoveNext())
            goto label_6;
          else
            goto label_10;
label_5:
          string current;
          int num2;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_9;
              case 2:
                goto label_15;
              case 3:
                goto label_6;
              default:
                values.Add(current.ToTranslit());
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 0;
                continue;
            }
          }
label_6:
          current = enumerator.Current;
          num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
          {
            num2 = 0;
            goto label_5;
          }
          else
            goto label_5;
label_10:
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 2;
          goto label_5;
        }
        finally
        {
          enumerator.Dispose();
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0)
            num3 = 0;
          switch (num3)
          {
            default:
          }
        }
label_15:
        return string.Join((string) NewCodeItemToolBoxItem.e1T69bVX6kDMFZZeBjl(1021410165 ^ 1021403569), (IEnumerable<string>) values);
      }
      set
      {
      }
    }

    public string VariableTypeName
    {
      get
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            case 2:
              if (this.VariableType != (Type) null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 1 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_2;
          }
        }
label_2:
        return (string) null;
label_3:
        return this.VariableType.AssemblyQualifiedName;
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
              this.VariableType = value == null ? (Type) null : NewCodeItemToolBoxItem.hHQERNVnGvo8TnDm6QN((object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
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

    [XmlIgnore]
    public Type VariableType
    {
      get => this.\u003CVariableType\u003Ek__BackingField;
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
              this.\u003CVariableType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
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

    public string Description
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
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

    public bool IsLocal
    {
      get => this.\u003CIsLocal\u003Ek__BackingField;
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
              this.\u003CIsLocal\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
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

    public Guid IterationUid
    {
      get => this.\u003CIterationUid\u003Ek__BackingField;
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
              this.\u003CIterationUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
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

    public abstract bool IsAvailable(IMetadata metadata);

    public Guid Uid
    {
      get => this.\u003CUid\u003Ek__BackingField;
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
              this.\u003CUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
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

    protected NewCodeItemToolBoxItem()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type KJj5YAVSpgDyyAQNEpD([In] object obj0) => ((NewCodeItemToolBoxItem) obj0).CodeItemType;

    internal static bool ACtUTcVi0UsSJN3GGOq([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static bool FOpgB0VIQ86S3Q4v9JQ() => NewCodeItemToolBoxItem.qLeascVuUFWVLdvIHyE == null;

    internal static NewCodeItemToolBoxItem HJAefeVVOXkXSN5vjT1() => NewCodeItemToolBoxItem.qLeascVuUFWVLdvIHyE;

    internal static Type FkhTSDVRcIY8ClfHqJQ([In] object obj0) => Type.GetType((string) obj0);

    internal static object O7TA90VqqOW0WuRJ0YY() => (object) MetadataServiceContext.Service;

    internal static object uYAuxRVKa3dNPTrlBQQ([In] object obj0, Guid typeUid, Guid subTypeUid) => (object) ((IMetadataService) obj0).GetTypeDescriptor(typeUid, subTypeUid);

    internal static object e1T69bVX6kDMFZZeBjl(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void oUNQroVTlDyWsOOQhG7([In] object obj0, [In] int obj1) => ((List<string>) obj0).RemoveAt(obj1);

    internal static object cbc4dlVk1psvaGVcl1L([In] object obj0) => (object) ((string) obj0).ToTranslit();

    internal static Type hHQERNVnGvo8TnDm6QN([In] object obj0) => ReflectionType.GetType((string) obj0);
  }
}
