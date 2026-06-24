// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.ToolBoxItems.DesignerParameterInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.ScriptDesigner.ToolBoxItems
{
  /// <summary>Параметр дизайнера действия</summary>
  [Serializable]
  public class DesignerParameterInfo
  {
    private static DesignerParameterInfo x3BRZxI1pra6k5ouBDF;

    public DesignerParameterInfo()
    {
      DesignerParameterInfo.oTVvcpIpJT0efibfcnO();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public DesignerParameterInfo(string name, Type type, string description, int order)
    {
      DesignerParameterInfo.oTVvcpIpJT0efibfcnO();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.Description = description;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
            continue;
          case 3:
            this.ParameterType = type;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 5 : 0;
            continue;
          case 4:
            this.TryGetTypeUid(this.ParameterType);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 1 : 1;
            continue;
          case 5:
            this.Order = order;
            num = 4;
            continue;
          default:
            this.ParameterName = name;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 1 : 3;
            continue;
        }
      }
label_3:;
    }

    public DesignerParameterInfo(string name, Type type)
    {
      DesignerParameterInfo.oTVvcpIpJT0efibfcnO();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.ParameterType = type;
            num = 3;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.TryGetTypeUid(this.ParameterType);
            num = 2;
            continue;
          default:
            this.ParameterName = name;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public DesignerParameterInfo(string name, string displayName, Type type)
    {
      DesignerParameterInfo.oTVvcpIpJT0efibfcnO();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 4;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
        num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.TryGetTypeUid(this.ParameterType);
            num = 3;
            continue;
          case 2:
            this.ParameterType = type;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
            continue;
          case 3:
            goto label_3;
          case 4:
            this.ParameterName = name;
            num = 2;
            continue;
          default:
            this.ParameterDisplayName = displayName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public string ParameterTypeName
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
              if (DesignerParameterInfo.zJRO0mIaFxZVmTxXvC4(this.ParameterType, (Type) null))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 1 : 1;
                continue;
              }
              goto label_4;
            default:
              goto label_4;
          }
        }
label_4:
        return (string) null;
label_5:
        return this.ParameterType.AssemblyQualifiedName;
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
              this.ParameterType = value != null ? Type.GetType(value) : (Type) null;
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

    /// <summary>Индекс параметра в методе</summary>
    public int Order
    {
      get => this.\u003COrder\u003Ek__BackingField;
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
              this.\u003COrder\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
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

    /// <summary>Тип</summary>
    [XmlIgnore]
    public Type ParameterType
    {
      get => this.\u003CParameterType\u003Ek__BackingField;
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
              this.\u003CParameterType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
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

    /// <summary>Обязательно для заполнения</summary>
    public bool Required
    {
      get => this.\u003CRequired\u003Ek__BackingField;
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
              this.\u003CRequired\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
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

    /// <summary>Отображаемое имя параметра</summary>
    public string ParameterTypeDisplayName
    {
      get => this.\u003CParameterTypeDisplayName\u003Ek__BackingField;
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
              this.\u003CParameterTypeDisplayName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
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

    /// <summary>Уникальный идентификатор типа</summary>
    public Guid? ParameterTypeUid { get; set; }

    /// <summary>Наименование</summary>
    public string ParameterDisplayName
    {
      get => this.\u003CParameterDisplayName\u003Ek__BackingField;
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
              this.\u003CParameterDisplayName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
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

    /// <summary>Наименование</summary>
    public string ParameterName
    {
      get => this.\u003CParameterName\u003Ek__BackingField;
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
              this.\u003CParameterName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
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

    /// <summary>Основной метод</summary>
    public bool IsMain
    {
      get => this.\u003CIsMain\u003Ek__BackingField;
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
              this.\u003CIsMain\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
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

    /// <summary>Описание</summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
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

    /// <summary>Является ли сущностью</summary>
    public bool IsEntity
    {
      get
      {
        int num1 = 2;
        Type type;
        while (true)
        {
          switch (num1)
          {
            case 1:
              goto label_2;
            case 2:
              type = (Type) null;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 1 : 1;
              continue;
            default:
              goto label_9;
          }
        }
label_2:
        try
        {
          type = this.ParameterType.GetInterface((string) DesignerParameterInfo.JUVFUbIDTeDnhV7pqhy(-1598106783 - -968262081 ^ -629861922));
          int num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
            num2 = 0;
          switch (num2)
          {
          }
        }
        catch
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
            num3 = 0;
          switch (num3)
          {
          }
        }
label_9:
        return type != (Type) null;
      }
    }

    /// <summary>Текущий элемент меню</summary>
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

    /// <summary>Обратные элементы</summary>
    public List<byte[]> BackItems { get; set; }

    /// <summary>
    /// Название переменной или метода который выбран в качестве параметра.
    /// </summary>
    public string SelectedValueName
    {
      get => this.\u003CSelectedValueName\u003Ek__BackingField;
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
              this.\u003CSelectedValueName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
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
    /// Отображаемое имя переменной или метода который выбран в качестве параметра.
    /// </summary>
    public string SelectedValueDisplayName
    {
      get => this.\u003CSelectedValueDisplayName\u003Ek__BackingField;
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
              this.\u003CSelectedValueDisplayName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
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

    /// <summary>Является ли переменная локальной</summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
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

    /// <summary>Выбран ли параметр</summary>
    public bool IsSelected => !this.SelectedValueName.IsNullOrEmpty();

    private void TryGetTypeUid(Type parameterType)
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: type reference
            if (!DesignerParameterInfo.n8g0tiIwVNpf6XbaZ5x(parameterType, DesignerParameterInfo.TuigheItlt9xg21f6wZ(__typeref (void))))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_3;
          case 3:
            goto label_47;
          case 4:
            goto label_49;
          default:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 2 : 2;
            continue;
        }
      }
label_47:
      return;
label_49:
      return;
label_3:
      try
      {
        int num2;
        // ISSUE: type reference
        if (parameterType.GetInterface(DesignerParameterInfo.TuigheItlt9xg21f6wZ(__typeref (IEnumerable<>)).Name) != (Type) null)
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 12 : 23;
        else
          goto label_15;
label_5:
        EntityMetadata entityMetadata1;
        ITypeDescriptor typeDescriptor;
        IMetadata metadata;
        EntityMetadata entityMetadata2;
        EnumMetadata enumMetadata;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (typeDescriptor != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 19 : 12;
                continue;
              }
              goto case 4;
            case 2:
              if (metadata == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 8 : 4;
                continue;
              }
              goto default;
            case 3:
            case 25:
              if (metadata is EnumMetadata)
              {
                num2 = 11;
                continue;
              }
              goto label_41;
            case 4:
              metadata = MetadataLoader.LoadMetadata(parameterType, false, false);
              num2 = 2;
              continue;
            case 5:
              this.ParameterTypeDisplayName = (string) DesignerParameterInfo.kC3BvmI611C5qqkVMbW((object) entityMetadata2);
              num2 = 25;
              continue;
            case 6:
              this.ParameterTypeDisplayName = EleWise.ELMA.SR.T((string) DesignerParameterInfo.JUVFUbIDTeDnhV7pqhy(-1217523399 ^ -1217504549), DesignerParameterInfo.kC3BvmI611C5qqkVMbW((object) entityMetadata1));
              num2 = 16;
              continue;
            case 7:
              // ISSUE: type reference
              if (DesignerParameterInfo.zJRO0mIaFxZVmTxXvC4(parameterType, DesignerParameterInfo.TuigheItlt9xg21f6wZ(__typeref (string))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 9 : 3;
                continue;
              }
              goto label_15;
            case 8:
              goto label_46;
            case 9:
              if (parameterType.IsGenericType)
              {
                num2 = 15;
                continue;
              }
              goto label_15;
            case 10:
              this.ParameterTypeUid = new Guid?(DesignerParameterInfo.HJKEkbI7btWpJPdogmd((object) enumMetadata));
              num2 = 14;
              continue;
            case 11:
              enumMetadata = metadata as EnumMetadata;
              num2 = 10;
              continue;
            case 12:
              entityMetadata2 = metadata as EntityMetadata;
              num2 = 17;
              continue;
            case 13:
              goto label_28;
            case 14:
              this.ParameterTypeDisplayName = (string) DesignerParameterInfo.kC3BvmI611C5qqkVMbW((object) enumMetadata);
              num2 = 18;
              continue;
            case 15:
              entityMetadata1 = MetadataLoader.LoadMetadata(parameterType.GetGenericArguments()[0], false, false) as EntityMetadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 17 : 22;
              continue;
            case 16:
              goto label_22;
            case 17:
              this.ParameterTypeUid = new Guid?(DesignerParameterInfo.w2Ux5RI4wkwbuqTD5C8((object) entityMetadata2));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 5 : 2;
              continue;
            case 18:
              goto label_14;
            case 19:
              this.ParameterTypeDisplayName = typeDescriptor.Name;
              num2 = 21;
              continue;
            case 20:
              this.ParameterTypeUid = new Guid?(DesignerParameterInfo.w2Ux5RI4wkwbuqTD5C8((object) entityMetadata1));
              num2 = 6;
              continue;
            case 21:
              this.ParameterTypeUid = new Guid?(DesignerParameterInfo.GYDbDjIAflaL4MZopRv((object) typeDescriptor));
              num2 = 13;
              continue;
            case 22:
              if (entityMetadata1 != null)
              {
                num2 = 20;
                continue;
              }
              goto label_45;
            case 23:
              if (!parameterType.IsArray)
              {
                num2 = 7;
                continue;
              }
              goto label_15;
            case 24:
              goto label_15;
            default:
              if (!(metadata is EntityMetadata))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 3 : 3;
                continue;
              }
              goto case 12;
          }
        }
label_46:
        return;
label_28:
        return;
label_22:
        return;
label_14:
        return;
label_45:
        return;
label_41:
        return;
label_15:
        typeDescriptor = (ITypeDescriptor) DesignerParameterInfo.VwrDpkIHful3cgmk3SC((object) Locator.GetServiceNotNull<IMetadataRuntimeService>(), parameterType);
        num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
        {
          num2 = 1;
          goto label_5;
        }
        else
          goto label_5;
      }
      catch
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
          num3 = 0;
        switch (num3)
        {
          case 0:
            return;
          default:
            return;
        }
      }
label_2:;
    }

    internal static void oTVvcpIpJT0efibfcnO() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool f8LXadINVmakb8SfvFI() => DesignerParameterInfo.x3BRZxI1pra6k5ouBDF == null;

    internal static DesignerParameterInfo gtE9MpI3AxRsVS7oC6o() => DesignerParameterInfo.x3BRZxI1pra6k5ouBDF;

    internal static bool zJRO0mIaFxZVmTxXvC4([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static object JUVFUbIDTeDnhV7pqhy(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Type TuigheItlt9xg21f6wZ([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool n8g0tiIwVNpf6XbaZ5x([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static Guid w2Ux5RI4wkwbuqTD5C8([In] object obj0) => ((EntityMetadata) obj0).ImplementationUid;

    internal static object kC3BvmI611C5qqkVMbW([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static object VwrDpkIHful3cgmk3SC([In] object obj0, Type runtimeType) => (object) ((IMetadataService) obj0).GetTypeDescriptor(runtimeType);

    internal static Guid GYDbDjIAflaL4MZopRv([In] object obj0) => ((ITypeDescriptor) obj0).Uid;

    internal static Guid HJKEkbI7btWpJPdogmd([In] object obj0) => ((AbstractMetadata) obj0).Uid;
  }
}
