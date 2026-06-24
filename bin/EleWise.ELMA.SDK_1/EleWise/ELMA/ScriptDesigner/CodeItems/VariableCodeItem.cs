// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.CodeItems.VariableCodeItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.ScriptDesigner.Services;
using EleWise.ELMA.ScriptDesigner.ToolBoxItems;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.ScriptDesigner.CodeItems
{
  /// <summary>Переменная (локальная переменная)</summary>
  [EleWise.ELMA.Model.Attributes.DisplayName(typeof (ResourcesVariableCodeItem), "DisplayName")]
  [Serializable]
  public class VariableCodeItem : CodeItem
  {
    private List<string> propertyNames;
    private List<string> displayNames;
    private static VariableCodeItem kYj5ZSq7qbMbUfoLLdm;

    public VariableCodeItem()
    {
      VariableCodeItem.xJk37Aqm2lcyoyWvuRe();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.PropertyNames = new List<string>();
            num = 2;
            continue;
          case 2:
            this.BackItems = new List<byte[]>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
            continue;
          case 3:
            this.DisplayNames = new List<string>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 1 : 1;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    public List<string> DisplayNames
    {
      get
      {
        if (this.VariableCodeItemPoint == null)
          return this.displayNames;
        string displayName = this.VariableCodeItemPoint.DisplayNames[0];
        List<string> displayNames = this.displayNames;
        if (displayNames.Count > 0)
        {
          displayNames.RemoveAt(0);
          displayNames.Insert(0, displayName);
        }
        return displayNames;
      }
      set => this.displayNames = value;
    }

    public List<byte[]> BackItems { get; set; }

    public byte[] CurrentItem
    {
      get => this.\u003CCurrentItem\u003Ek__BackingField;
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
              this.\u003CCurrentItem\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
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

    public List<string> PropertyNames
    {
      get
      {
        if (this.VariableCodeItemPoint == null)
          return this.propertyNames;
        string displayName = this.VariableCodeItemPoint.DisplayNames[0];
        List<string> propertyNames = this.propertyNames;
        if (propertyNames.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 901775981)))
        {
          propertyNames.RemoveAt(1);
          propertyNames.Insert(1, displayName);
        }
        else
        {
          if (propertyNames.Count > 0)
            propertyNames.RemoveAt(0);
          propertyNames.Insert(0, displayName);
        }
        return propertyNames;
      }
      set => this.propertyNames = value;
    }

    public Guid SourceCodeItemUid
    {
      get => this.\u003CSourceCodeItemUid\u003Ek__BackingField;
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
              this.\u003CSourceCodeItemUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
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

    /// <summary>Переименовать</summary>
    /// <param name="name"></param>
    public void Rename(string name)
    {
      int num = 2;
      VariableCodeItemToolBoxItem variableCodeItemPoint;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            if (variableCodeItemPoint == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 0;
              continue;
            }
            goto case 4;
          case 2:
            variableCodeItemPoint = this.VariableCodeItemPoint;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 0;
            continue;
          case 3:
            goto label_2;
          case 4:
            VariableCodeItem.Gnv3EVqywBycZcqiHmI((object) variableCodeItemPoint, (object) name);
            num = 3;
            continue;
          default:
            goto label_8;
        }
      }
label_3:
      return;
label_2:
      return;
label_8:;
    }

    /// <summary>
    /// Основной элемент для переменной (для хранения имени и тд.)
    /// </summary>
    [XmlIgnore]
    public VariableCodeItemToolBoxItem VariableCodeItemPoint
    {
      get
      {
        int num = 2;
        ICodeItemStoreService service;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (service == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 2:
              service = Locator.GetService<ICodeItemStoreService>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_4;
            default:
              goto label_5;
          }
        }
label_4:
        return (VariableCodeItemToolBoxItem) VariableCodeItem.cYi2SGqMyqpQBoTMx6M((object) service, this.SourceCodeItemUid);
label_5:
        return (VariableCodeItemToolBoxItem) null;
      }
    }

    public string VariableName
    {
      get
      {
        int num1 = 1;
        List<string>.Enumerator enumerator;
        List<string> values;
        while (true)
        {
          switch (num1)
          {
            case 1:
              values = new List<string>();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_15;
            case 3:
              goto label_4;
            default:
              enumerator = this.PropertyNames.GetEnumerator();
              num1 = 3;
              continue;
          }
        }
label_4:
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
                goto label_15;
              case 2:
                goto label_6;
              case 3:
                goto label_9;
              default:
                values.Add((string) VariableCodeItem.sQhbCpqJ5F3BO6f2Ldd((object) current));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 1 : 3;
                continue;
            }
          }
label_6:
          current = enumerator.Current;
          num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
          {
            num2 = 0;
            goto label_5;
          }
          else
            goto label_5;
label_10:
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 1 : 1;
          goto label_5;
        }
        finally
        {
          enumerator.Dispose();
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
            num3 = 0;
          switch (num3)
          {
            default:
          }
        }
label_15:
        return string.Join((string) VariableCodeItem.zEMxkZq9lZ5NpTby3uO(712480695 ^ 712478067), (IEnumerable<string>) values);
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
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

    public bool IsLocalFor
    {
      get => this.\u003CIsLocalFor\u003Ek__BackingField;
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
              this.\u003CIsLocalFor\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
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

    public string DisplayName
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
              displayNames = this.DisplayNames;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return string.Join((string) VariableCodeItem.zEMxkZq9lZ5NpTby3uO(-1204263869 ^ -1341583247 ^ 137457398), (IEnumerable<string>) displayNames);
      }
    }

    [XmlIgnore]
    public IterationCodeItem OwnerForeachCodeItem
    {
      get => this.\u003COwnerForeachCodeItem\u003Ek__BackingField;
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
              this.\u003COwnerForeachCodeItem\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
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

    public Guid MetadataUid
    {
      get
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_5;
            case 2:
              if (this.Metadata != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 0;
                continue;
              }
              goto label_4;
            default:
              goto label_4;
          }
        }
label_4:
        return Guid.Empty;
label_5:
        return VariableCodeItem.LEw15AqdkLthsMnTkWN((object) this.Metadata);
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
              this.Metadata = MetadataServiceContext.Service.GetMetadata(value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
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
    public IMetadata Metadata
    {
      get => this.\u003CMetadata\u003Ek__BackingField;
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
              this.\u003CMetadata\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
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

    public string VariableTypeName
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.VariableType != (Type) null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
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
              this.VariableType = !VariableCodeItem.l0ryyLqls1YsdkCcf5f((object) value) ? VariableCodeItem.jFBa3uqrDx0UwcsNjjw((object) value) : (Type) null;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
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

    public override bool IsValidParent(ICodeItem compositeCodeItem)
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        IterationCodeItem iterationCodeItem;
        CompositeCodeItem compositeCodeItem1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_13;
            case 2:
            case 9:
            case 11:
              if (this.IsInnerItem((CompositeCodeItem) this.OwnerForeachCodeItem, (CodeItem) compositeCodeItem1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 7 : 7;
                continue;
              }
              goto label_6;
            case 3:
              if (compositeCodeItem is ConditionCodeItem)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 1 : 1;
                continue;
              }
              goto label_12;
            case 4:
              if (!VariableCodeItem.LN6SFaqgThMGwKaniDI((object) iterationCodeItem).Equals((object) this))
                goto case 2;
              else
                goto label_4;
            case 5:
              compositeCodeItem1 = compositeCodeItem as CompositeCodeItem;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 8 : 13;
              continue;
            case 6:
              if (!this.IsLocalFor)
              {
                if (!(compositeCodeItem is AssignCodeItem))
                {
                  num2 = 3;
                  continue;
                }
                goto label_13;
              }
              else
              {
                num2 = 5;
                continue;
              }
            case 7:
            case 12:
              goto label_5;
            case 8:
              if (iterationCodeItem.LocalVariableCodeItem == null)
              {
                num2 = 9;
                continue;
              }
              goto case 4;
            case 10:
              goto label_12;
            case 13:
              iterationCodeItem = compositeCodeItem as IterationCodeItem;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
              continue;
            default:
              if (iterationCodeItem == null)
              {
                num2 = 2;
                continue;
              }
              goto case 8;
          }
        }
label_4:
        num1 = 12;
      }
label_5:
      return true;
label_6:
      return false;
label_12:
      return compositeCodeItem is MathCodeItem;
label_13:
      return true;
    }

    public bool IsInnerItem(CompositeCodeItem codeItem, CodeItem item)
    {
      int num1 = 2;
      List<CodeItem>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            enumerator = codeItem.Items.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 1 : 1;
            continue;
          default:
            goto label_19;
        }
      }
label_2:
      bool flag;
      try
      {
label_4:
        if (enumerator.MoveNext())
          goto label_14;
        else
          goto label_5;
label_3:
        CodeItem current;
        int num2;
        while (true)
        {
          CompositeCodeItem codeItem1;
          switch (num2)
          {
            case 1:
              goto label_19;
            case 2:
            case 8:
            case 10:
              goto label_20;
            case 3:
              goto label_4;
            case 4:
              goto label_14;
            case 5:
              if (VariableCodeItem.PM6lQqq5GFU2Bexq0tH(current.Uid, item.Uid))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 10 : 11;
                continue;
              }
              break;
            case 6:
              flag = false;
              num2 = 10;
              continue;
            case 7:
              flag = this.IsInnerItem(codeItem1, item);
              num2 = 2;
              continue;
            case 9:
              if (codeItem1 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 7 : 7;
                continue;
              }
              goto case 6;
            case 11:
              flag = true;
              num2 = 8;
              continue;
          }
          codeItem1 = current as CompositeCodeItem;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 9 : 6;
        }
label_5:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 1 : 1;
        goto label_3;
label_14:
        current = enumerator.Current;
        num2 = 5;
        goto label_3;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
label_20:
      return flag;
label_19:
      return false;
    }

    public override CodeStatement ToCodeStatement()
    {
      int num = 1;
      CodeExpression expression;
      while (true)
      {
        switch (num)
        {
          case 1:
            expression = (CodeExpression) VariableCodeItem.SpBJvDqjObMIBqENDXI((object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            if (expression != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 2 : 0;
              continue;
            }
            goto label_5;
        }
      }
label_4:
      return (CodeStatement) new CodeExpressionStatement(expression);
label_5:
      return (CodeStatement) null;
    }

    public override CodeExpression ToCodeExpression() => (CodeExpression) new CodeVariableReferenceExpression(this.VariableName);

    public override CodeStatement[] ToCodeStatementList() => (CodeStatement[]) null;

    public override List<Type> GetValidToInsert() => throw new NotImplementedException();

    internal static void xJk37Aqm2lcyoyWvuRe() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool U3WgZeqxohXp3lHt53k() => VariableCodeItem.kYj5ZSq7qbMbUfoLLdm == null;

    internal static VariableCodeItem eFSlEYq0UDMQF5WkqPq() => VariableCodeItem.kYj5ZSq7qbMbUfoLLdm;

    internal static void Gnv3EVqywBycZcqiHmI([In] object obj0, [In] object obj1) => ((NewCodeItemToolBoxItem) obj0).Rename((string) obj1);

    internal static object cYi2SGqMyqpQBoTMx6M([In] object obj0, Guid variableUid) => (object) ((ICodeItemStoreService) obj0).LoadLocalVariableByUid(variableUid);

    internal static object sQhbCpqJ5F3BO6f2Ldd([In] object obj0) => (object) ((string) obj0).ToTranslit();

    internal static object zEMxkZq9lZ5NpTby3uO(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Guid LEw15AqdkLthsMnTkWN([In] object obj0) => ((IMetadata) obj0).Uid;

    internal static bool l0ryyLqls1YsdkCcf5f([In] object obj0) => ((string) obj0).IsNullOrEmpty();

    internal static Type jFBa3uqrDx0UwcsNjjw([In] object obj0) => ReflectionType.GetType((string) obj0);

    internal static object LN6SFaqgThMGwKaniDI([In] object obj0) => (object) ((IterationCodeItem) obj0).LocalVariableCodeItem;

    internal static bool PM6lQqq5GFU2Bexq0tH([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object SpBJvDqjObMIBqENDXI([In] object obj0) => (object) ((CodeItem) obj0).ToCodeExpression();
  }
}
