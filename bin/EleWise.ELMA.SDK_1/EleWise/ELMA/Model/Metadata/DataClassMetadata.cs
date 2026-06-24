// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.DataClassMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.Deploy.Attributes;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Метаданные объекта конструктора интерфейсов</summary>
  [XmlExport]
  [DataContract]
  [EleWise.ELMA.Model.Attributes.Uid("{6F1B7544-AA48-4820-823C-3579B8AF0A22}")]
  [Serializable]
  public class DataClassMetadata : ClassMetadata
  {
    /// <summary>
    /// Уникальный идентификатор типа "Структура обмена данными"
    /// </summary>
    public const string UID_S = "{6F1B7544-AA48-4820-823C-3579B8AF0A22}";
    /// <summary>
    /// Уникальный идентификатор типа "Структура обмена данными"
    /// </summary>
    public static readonly Guid UID;
    /// <summary>Пространство имен по умолчанию</summary>
    public const string DefaultNamespace = "EleWise.ELMA.DataClasses";
    /// <summary>Является ли интерфейсом</summary>
    [XmlIgnore]
    internal bool? isInterfaceType;
    private string[] dataClassInterfaces;
    internal static DataClassMetadata vw3Mx6baI7DI3hUKa240;

    /// <summary>Ctor</summary>
    public DataClassMetadata()
    {
      DataClassMetadata.iDimprbaihsfM9YHdSbA();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.IncludeList = new List<DataClassDependency>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Ctor</summary>
    /// <param name="moduleUid">Идентификатор модуля</param>
    public DataClassMetadata(Guid moduleUid)
    {
      DataClassMetadata.iDimprbaihsfM9YHdSbA();
      // ISSUE: explicit constructor call
      this.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.Internal = moduleUid != Guid.Empty;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 1;
            continue;
          default:
            DataClassMetadata.BHyZohbaRMH78bV4CVbL((object) this, moduleUid);
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Идентификатор, отвечающий за ссылку на тип</summary>
    [XmlForceElement]
    [Obsolete("TODO: ELMA-29857 Убрать после выноса EleWise.ELMA.SDK.DTO", false)]
    public string TypeRef
    {
      get => this.\u003CTypeRef\u003Ek__BackingField;
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
              this.\u003CTypeRef\u003Ek__BackingField = value;
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

    /// <summary>Список вложенных датаклассов</summary>
    public List<DataClassDependency> IncludeList { get; set; }

    /// <summary>Ссылка на реальный на .NET тип</summary>
    public TypeToMap TypeToMap
    {
      get => this.\u003CTypeToMap\u003Ek__BackingField;
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
              this.\u003CTypeToMap\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
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

    /// <inheritdoc />
    public override bool IsInterfaceType
    {
      get
      {
        int num = 1;
        bool? isInterfaceType;
        while (true)
        {
          switch (num)
          {
            case 1:
              isInterfaceType = this.isInterfaceType;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_5;
            default:
              if (!isInterfaceType.HasValue)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 2 : 2;
                continue;
              }
              goto label_6;
          }
        }
label_5:
        return false;
label_6:
        return isInterfaceType.GetValueOrDefault();
      }
    }

    /// <inheritdoc />
    public override bool IsRestartNeeded(IRootMetadata metadata) => false;

    /// <inheritdoc />
    public override void InitNew()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            DataClassMetadata.du6NUmbaKs77cRCMlRLL((object) this, DataClassMetadata.EvncrgbaqidZMoMogS35(~289714581 ^ -289775962));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 2 : 3;
            continue;
          case 2:
            base.InitNew();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 1 : 1;
            continue;
          case 3:
            this.TableViews.Add((TableView) DataClassMetadata.CpDwEobaXohsd0UlV7ee((object) this));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    /// <inheritdoc />
    public override void LoadFromType(Type type, bool inherit = true)
    {
      int num1 = 17;
      while (true)
      {
        int num2 = num1;
        string str1;
        EntityMetadataUidAttribute attribute1;
        object attribute2;
        Type type1;
        string str2;
        int index;
        IEnumerable<string> collection;
        UidAttribute attribute3;
        object[] objArray;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_39;
            case 1:
              str2 = (string) DataClassMetadata.yaMEKFba2eLydQhSv1yT();
              num2 = 5;
              continue;
            case 2:
            case 8:
            case 11:
              ++index;
              num2 = 9;
              continue;
            case 3:
              attribute3 = AttributeHelper<UidAttribute>.GetAttribute(type, false);
              num2 = 26;
              continue;
            case 4:
              this.ProcessIncludeAttribute(attribute2, type1);
              num2 = 11;
              continue;
            case 5:
              objArray = (object[]) DataClassMetadata.eXPucDbae8Pm8jZPfNwP((object) type, false);
              num2 = 23;
              continue;
            case 6:
              this.LoadFromEntityMetadata(DataClassMetadata.IheeVWbaTXxWjHSCZOk2((object) attribute1));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 10 : 25;
              continue;
            case 7:
            case 24:
              Type[] interfaces1 = type.GetInterfaces();
              // ISSUE: reference to a compiler-generated field
              Func<Type, string> func1 = DataClassMetadata.\u003C\u003Ec.\u003C\u003E9__23_0;
              Func<Type, string> selector1;
              if (func1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                DataClassMetadata.\u003C\u003Ec.\u003C\u003E9__23_0 = selector1 = (Func<Type, string>) (a => a.FullName);
              }
              else
                goto label_44;
label_36:
              IEnumerable<string> first = ((IEnumerable<Type>) interfaces1).Select<Type, string>(selector1);
              string[] dataClassInterfaces = this.dataClassInterfaces;
              string[] second;
              if (dataClassInterfaces == null)
              {
                Type[] interfaces2 = TypeOf<DataClass>.Raw.GetInterfaces();
                // ISSUE: reference to a compiler-generated field
                Func<Type, string> func2 = DataClassMetadata.\u003C\u003Ec.\u003C\u003E9__23_1;
                Func<Type, string> selector2;
                if (func2 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  DataClassMetadata.\u003C\u003Ec.\u003C\u003E9__23_1 = selector2 = (Func<Type, string>) (a => a.FullName);
                }
                else
                  goto label_3;
label_41:
                second = this.dataClassInterfaces = ((IEnumerable<Type>) interfaces2).Select<Type, string>(selector2).ToArray<string>();
                goto label_42;
label_3:
                selector2 = func2;
                goto label_41;
              }
              else
                goto label_43;
label_42:
              collection = first.Except<string>((IEnumerable<string>) second);
              num2 = 18;
              continue;
label_43:
              second = dataClassInterfaces;
              goto label_42;
label_44:
              selector1 = func1;
              goto label_36;
            case 9:
            case 29:
              if (index < objArray.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 12 : 22;
                continue;
              }
              goto case 21;
            case 10:
            case 22:
              attribute2 = objArray[index];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 13 : 5;
              continue;
            case 12:
              str1 = (string) DataClassMetadata.m3OKodbaOHKOrJLoC9gc();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 0;
              continue;
            case 13:
              type1 = attribute2.GetType();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 19 : 6;
              continue;
            case 14:
              if (DataClassMetadata.j7JwdMba14Wvho44mXQu((object) type1.FullName, (object) str2))
              {
                num2 = 4;
                continue;
              }
              goto case 20;
            case 15:
              this.ProcessDataClassFormAttribute(attribute2, type1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 8 : 8;
              continue;
            case 16:
              if (attribute1 != null)
              {
                num2 = 6;
                continue;
              }
              base.LoadFromType(type, inherit);
              num2 = 3;
              continue;
            case 17:
              goto label_17;
            case 18:
              this.ImplementedInterfaces.AddRange(collection);
              num2 = 12;
              continue;
            case 19:
              if (DataClassMetadata.Gj1n2pbaPTntSNI5Kqui((object) type1.FullName))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 2 : 2;
                continue;
              }
              goto case 14;
            case 20:
              if (type1.FullName == str1)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 15 : 2;
                continue;
              }
              goto case 2;
            case 21:
              this.TypeRef = (string) DataClassMetadata.nhlrdQbaNGyPyNSFh0q6(type);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
              continue;
            case 23:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 10 : 29;
              continue;
            case 25:
              goto label_14;
            case 26:
              DataClassMetadata.UIIqRJbanx46cPdeYctZ((object) this, attribute3 == null ? DataClassMetadata.gQsG6KbakfeIeHocKUl2(type) : attribute3.Uid);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 21 : 27;
              continue;
            case 27:
              if (this.ImplementedInterfaces != null)
              {
                num2 = 24;
                continue;
              }
              goto case 28;
            case 28:
              this.ImplementedInterfaces = new List<string>();
              num2 = 7;
              continue;
            default:
              goto label_37;
          }
        }
label_17:
        attribute1 = AttributeHelper<EntityMetadataUidAttribute>.GetAttribute(type, false);
        num1 = 16;
      }
label_39:
      return;
label_14:
      return;
label_37:;
    }

    /// <summary>Получить TypeRef</summary>
    /// <param name="dataClassType">Тип</param>
    /// <returns>TypeRef</returns>
    internal static string GetTypeRef(Type dataClassType)
    {
      int num1 = 6;
      long id;
      while (true)
      {
        int num2 = num1;
        Guid itemUid;
        MetadataItemUidAttribute attribute;
        Guid uid;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_12;
            case 2:
              goto label_3;
            case 3:
              goto label_6;
            case 4:
              if (attribute != null)
              {
                itemUid = DataClassMetadata.lydYhqba3GgHR8aNT6cO((object) attribute);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
                continue;
              }
              num2 = 3;
              continue;
            case 5:
              attribute = AttributeHelper<MetadataItemUidAttribute>.GetAttribute(dataClassType.Assembly);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 3 : 4;
              continue;
            case 6:
              uid = AttributeHelper<UidAttribute>.GetAttribute(dataClassType, false).Uid;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 5;
              continue;
            case 7:
              goto label_15;
            case 8:
              IDataClassTypeReferenceManager service = Locator.GetService<IDataClassTypeReferenceManager>();
              if (service == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 5 : 7;
                continue;
              }
              id = ((DataClassTypeReference) DataClassMetadata.jfUdsVbaacQpmBhH8xna((object) service, itemUid, uid)).Id;
              num2 = 2;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        if (!DataClassMetadata.GgKt7UbapkUcut4l14AE(itemUid, Guid.Empty))
          num1 = 8;
        else
          goto label_12;
      }
label_3:
      return id.ToString();
label_6:
      return (string) null;
label_12:
      return (string) null;
label_15:
      return (string) null;
    }

    /// <inheritdoc />
    protected override TableView CreateDefaultTableView()
    {
      TableView defaultTableView = base.CreateDefaultTableView();
      DataClassMetadata.yRaXvcbaD9kYls5HgHQB((object) defaultTableView, true);
      DataClassMetadata.xbb7j3batkDK7mMoANdr((object) defaultTableView, true);
      DataClassMetadata.MJ5ANAbawl90uenTZvWX((object) defaultTableView, true);
      DataClassMetadata.OpRTYlba4CThv9ZiW03r((object) defaultTableView, true);
      defaultTableView.CanDelete = true;
      return defaultTableView;
    }

    /// <summary>Нужно ли сериализовать</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeIncludeList() => DataClassMetadata.cXnhLFba6xUYb1ntNkyg((object) this.IncludeList) != 0;

    /// <summary>
    /// Нужно ли сериализовать <see cref="P:EleWise.ELMA.Model.Metadata.DataClassMetadata.TypeToMap" />
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeTypeToMap() => this.TypeToMap != null;

    private void LoadFromEntityMetadata(Guid guid)
    {
      int num1 = 27;
      while (true)
      {
        int num2 = num1;
        DataClassMetadata dataClassMetadata;
        while (true)
        {
          switch (num2)
          {
            case 1:
              this.Description = (string) DataClassMetadata.gT2CJ2baxN2DRXgfXi4c((object) dataClassMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 7 : 8;
              continue;
            case 2:
              DataClassMetadata.xfegw7bDWF7C1un3YSbb((object) this, DataClassMetadata.hcaaR6bDBDSRFOYh8yrW((object) dataClassMetadata));
              num2 = 4;
              continue;
            case 3:
              this.IncludeList = dataClassMetadata.IncludeList;
              num2 = 21;
              continue;
            case 4:
              this.TitlePropertyUid = dataClassMetadata.TitlePropertyUid;
              num2 = 18;
              continue;
            case 5:
              DataClassMetadata.GFLeqNbagQwHGVcSIcch((object) this, DataClassMetadata.IyL1FjbariLTjHoTDaxT((object) dataClassMetadata));
              num2 = 15;
              continue;
            case 6:
              this.OnViewLoadScriptName = (string) DataClassMetadata.tUpcHLbDE6OagdJ6ETTr((object) dataClassMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 14 : 6;
              continue;
            case 7:
              DataClassMetadata.nD1QGabac96bKhpCHilM((object) this, DataClassMetadata.PqOZBFbasB9xllqHQijV((object) dataClassMetadata));
              num2 = 35;
              continue;
            case 8:
              this.Forms = dataClassMetadata.Forms;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
              continue;
            case 9:
              DataClassMetadata.XlXLC0balZpdDTyWpbon((object) this, DataClassMetadata.erKtUJbadr3rk71IvSju((object) dataClassMetadata));
              num2 = 33;
              continue;
            case 10:
              goto label_10;
            case 11:
              DataClassMetadata.VeWkPtbaYpoaRLtTJlEv((object) this, dataClassMetadata.InheritForms);
              num2 = 29;
              continue;
            case 12:
              this.Internal = DataClassMetadata.c4DBAUba0XfC3mK8tSLS((object) dataClassMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 23 : 28;
              continue;
            case 13:
              this.PropertiesDiffContainer = dataClassMetadata.PropertiesDiffContainer;
              num2 = 2;
              continue;
            case 14:
              goto label_3;
            case 15:
              this.FormTransformations = dataClassMetadata.FormTransformations;
              num2 = 22;
              continue;
            case 16:
              this.ImplementedInterfaces = dataClassMetadata.ImplementedInterfaces;
              num2 = 11;
              continue;
            case 17:
              this.TableViews = dataClassMetadata.TableViews;
              num2 = 30;
              continue;
            case 18:
              DataClassMetadata.UsekyrbDbTY4UAlJC21U((object) this, DataClassMetadata.VRgOpgbDoIOmvajU9dhO((object) dataClassMetadata));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 10;
              continue;
            case 19:
              DataClassMetadata.nGf43obaJnlqiD4HqJM0((object) this, DataClassMetadata.NE8ty2baMKBfuH3oeyDE((object) dataClassMetadata));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 5 : 32;
              continue;
            case 20:
              this.AllowCreateHeirs = DataClassMetadata.RCnjXBbaU1jhR66TkLG3((object) dataClassMetadata);
              num2 = 7;
              continue;
            case 21:
              this.TypeRef = (string) DataClassMetadata.HHVWhHba7vqJJ7dryODt((object) dataClassMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 1 : 0;
              continue;
            case 22:
              this.FormViews = dataClassMetadata.FormViews;
              num2 = 31;
              continue;
            case 23:
              this.NamedImages = dataClassMetadata.NamedImages;
              num2 = 17;
              continue;
            case 24:
              this.Images = dataClassMetadata.Images;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 2 : 12;
              continue;
            case 25:
              DataClassMetadata.du6NUmbaKs77cRCMlRLL((object) this, (object) dataClassMetadata.Namespace);
              num2 = 34;
              continue;
            case 26:
              DataClassMetadata.UIIqRJbanx46cPdeYctZ((object) this, DataClassMetadata.XQi4FAbaAGLGXRNXNrMW((object) dataClassMetadata));
              num2 = 3;
              continue;
            case 27:
              dataClassMetadata = (DataClassMetadata) DataClassMetadata.AmYCqubaHypnFZcuh7Ut((object) (EntityMetadata) MetadataServiceContext.Service.GetMetadata(guid, false));
              num2 = 26;
              continue;
            case 28:
              DataClassMetadata.zGpjivbayYsQvK2HYFhH((object) this, DataClassMetadata.HCcROqbamplI0bHKuj5Q((object) dataClassMetadata));
              num2 = 25;
              continue;
            case 29:
              DataClassMetadata.BHyZohbaRMH78bV4CVbL((object) this, DataClassMetadata.je2MpmbaLwebILt5U8lm((object) dataClassMetadata));
              num2 = 23;
              continue;
            case 30:
              this.XmlComments = dataClassMetadata.XmlComments;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 20 : 13;
              continue;
            case 31:
              DataClassMetadata.SxdFADbajKdN5JnXB4W6((object) this, DataClassMetadata.VAZSruba5S1rPsF0HEju((object) dataClassMetadata));
              num2 = 16;
              continue;
            case 32:
              this.DefaultForms = (ClassDefaultForms) DataClassMetadata.xKuHHNba9u07e7TQaIOf((object) dataClassMetadata);
              num2 = 9;
              continue;
            case 33:
              this.DisplayName = dataClassMetadata.DisplayName;
              num2 = 5;
              continue;
            case 34:
              this.Properties = dataClassMetadata.Properties;
              num2 = 19;
              continue;
            case 35:
              DataClassMetadata.CMVUYcbDFvbRyjoRgCN2((object) this, DataClassMetadata.kO3p9NbazkmkDSRKW8eJ((object) dataClassMetadata));
              num2 = 13;
              continue;
            default:
              goto label_30;
          }
        }
label_10:
        DataClassMetadata.mUg4qdbDGfh6fIuXZBV8((object) this, DataClassMetadata.FjtTFybDhpVjsLOi5xg5((object) dataClassMetadata));
        num1 = 6;
        continue;
label_30:
        this.Id = dataClassMetadata.Id;
        num1 = 24;
      }
label_3:;
    }

    internal void ProcessIncludeAttribute(object attribute, Type attributeType)
    {
      int num = 8;
      System.Reflection.PropertyInfo property;
      Guid typeUid;
      DataClassMetadata metadata;
      DataClassDependency dependency;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            if (!this.IncludeList.Exists((Predicate<DataClassDependency>) (a => DataClassMetadata.\u003C\u003Ec__DisplayClass30_0.awVYKuCD91KsZQtHM3rM(DataClassMetadata.\u003C\u003Ec__DisplayClass30_0.FbeeSwCDJ71P4C5XVTK8((object) a), dependency.HeaderUid))))
            {
              this.IncludeList.Add(dependency);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 4 : 4;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
            continue;
          case 2:
            if (!DataClassMetadata.hueHg5bDf27W861etRuU((object) property, (object) null))
            {
              typeUid = (Guid) DataClassMetadata.sPImf4bDQrifurVrs72G((object) property, attribute);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 5 : 2;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 6 : 4;
            continue;
          case 3:
            dependency = metadata.GetSignature(true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 1;
            continue;
          case 4:
            goto label_6;
          case 5:
            metadata = (DataClassMetadata) DataClassMetadata.iZcysubDCVBuKAfNv7wx((object) Locator.GetServiceNotNull<DataClassDescriptor>(), typeUid);
            num = 3;
            continue;
          case 6:
            goto label_2;
          case 7:
            property = attributeType.GetProperty((string) DataClassMetadata.EvncrgbaqidZMoMogS35(222162814 ^ 222134508), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 2;
            continue;
          case 8:
            num = 7;
            continue;
          default:
            goto label_15;
        }
      }
label_3:
      return;
label_6:
      return;
label_2:
      return;
label_15:;
    }

    private void ProcessDataClassFormAttribute(object attribute, Type attributeType)
    {
      int num1 = 11;
      while (true)
      {
        int num2 = num1;
        System.Reflection.PropertyInfo property1;
        ViewType result1;
        System.Reflection.PropertyInfo property2;
        Guid result2;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_4;
            case 1:
              goto label_11;
            case 2:
              goto label_22;
            case 3:
              goto label_18;
            case 4:
              goto label_6;
            case 5:
              goto label_20;
            case 6:
              if (!DataClassMetadata.hueHg5bDf27W861etRuU((object) property2, (object) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 5 : 8;
                continue;
              }
              goto label_3;
            case 7:
              switch (result1)
              {
                case ViewType.Create:
                  DataClassMetadata.v3JMWmbDvUmUYOv20N9n(DataClassMetadata.xKuHHNba9u07e7TQaIOf((object) this), result2);
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
                  continue;
                case ViewType.Edit:
                  DataClassMetadata.WFwAA7bD8XnbY4Mxkjfy((object) this.DefaultForms, result2);
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 1 : 1;
                  continue;
                case ViewType.Create | ViewType.Edit:
                  goto label_24;
                case ViewType.Display:
                  DataClassMetadata.FCR7HEbDZFBhl2O6fTvg(DataClassMetadata.xKuHHNba9u07e7TQaIOf((object) this), result2);
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 3 : 2;
                  continue;
                default:
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 9 : 1;
                  continue;
              }
            case 8:
              Enum.TryParse<ViewType>(property1.GetValue(attribute).ToString(), out result1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 4 : 3;
              continue;
            case 9:
              goto label_7;
            case 10:
              if (DataClassMetadata.hueHg5bDf27W861etRuU((object) property1, (object) null))
              {
                num2 = 5;
                continue;
              }
              property2 = attributeType.GetProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917185638), BindingFlags.Instance | BindingFlags.NonPublic);
              num2 = 6;
              continue;
            case 11:
              property1 = attributeType.GetProperty((string) DataClassMetadata.EvncrgbaqidZMoMogS35(-688192331 - 435440695 ^ -1123789658), BindingFlags.Instance | BindingFlags.NonPublic);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 10 : 2;
              continue;
            default:
              goto label_23;
          }
        }
label_6:
        Guid.TryParse(DataClassMetadata.sPImf4bDQrifurVrs72G((object) property2, attribute).ToString(), out result2);
        num1 = 7;
      }
label_4:
      return;
label_11:
      return;
label_22:
      return;
label_18:
      return;
label_20:
      return;
label_7:
      return;
label_23:
      return;
label_3:
      return;
label_24:;
    }

    static DataClassMetadata()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            DataClassMetadata.UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-441065788 ^ -2092910478 ^ 1727499170));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
            continue;
          case 2:
            DataClassMetadata.iDimprbaihsfM9YHdSbA();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void iDimprbaihsfM9YHdSbA() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool wiJSLfbaVKEd1KFaNYQM() => DataClassMetadata.vw3Mx6baI7DI3hUKa240 == null;

    internal static DataClassMetadata p6T9MTbaSFgERkfrrMQR() => DataClassMetadata.vw3Mx6baI7DI3hUKa240;

    internal static void BHyZohbaRMH78bV4CVbL([In] object obj0, Guid value) => ((AbstractMetadata) obj0).ModuleUid = value;

    internal static object EvncrgbaqidZMoMogS35(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void du6NUmbaKs77cRCMlRLL([In] object obj0, [In] object obj1) => ((ClassMetadata) obj0).Namespace = (string) obj1;

    internal static object CpDwEobaXohsd0UlV7ee([In] object obj0) => (object) ((ClassMetadata) obj0).CreateDefaultTableView();

    internal static Guid IheeVWbaTXxWjHSCZOk2([In] object obj0) => ((EntityMetadataUidAttribute) obj0).Uid;

    internal static Guid gQsG6KbakfeIeHocKUl2(Type type) => DataClassDescriptor.GetSubtypeUid(type);

    internal static void UIIqRJbanx46cPdeYctZ([In] object obj0, Guid value) => ((AbstractMetadata) obj0).Uid = value;

    internal static object m3OKodbaOHKOrJLoC9gc() => (object) TypeOf<DataClassFormAttribute>.FullName;

    internal static object yaMEKFba2eLydQhSv1yT() => (object) TypeOf<IncludeAttribute>.FullName;

    internal static object eXPucDbae8Pm8jZPfNwP([In] object obj0, [In] bool obj1) => (object) ((MemberInfo) obj0).GetCustomAttributes(obj1);

    internal static bool Gj1n2pbaPTntSNI5Kqui([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static bool j7JwdMba14Wvho44mXQu([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object nhlrdQbaNGyPyNSFh0q6(Type dataClassType) => (object) DataClassMetadata.GetTypeRef(dataClassType);

    internal static Guid lydYhqba3GgHR8aNT6cO([In] object obj0) => ((MetadataItemUidAttribute) obj0).ItemUid;

    internal static bool GgKt7UbapkUcut4l14AE([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object jfUdsVbaacQpmBhH8xna([In] object obj0, Guid itemUid, Guid metadataUid) => (object) ((IDataClassTypeReferenceManager) obj0).FindByItemUid(itemUid, metadataUid);

    internal static void yRaXvcbaD9kYls5HgHQB([In] object obj0, bool value) => ((TableView) obj0).Resizeable = value;

    internal static void xbb7j3batkDK7mMoANdr([In] object obj0, bool value) => ((TableView) obj0).Groupable = value;

    internal static void MJ5ANAbawl90uenTZvWX([In] object obj0, bool value) => ((TableView) obj0).CanAdd = value;

    internal static void OpRTYlba4CThv9ZiW03r([In] object obj0, bool value) => ((TableView) obj0).CanEdit = value;

    internal static int cXnhLFba6xUYb1ntNkyg([In] object obj0) => ((List<DataClassDependency>) obj0).Count;

    internal static object AmYCqubaHypnFZcuh7Ut([In] object obj0) => (object) ((EntityMetadata) obj0).ViewModelMetadata;

    internal static Guid XQi4FAbaAGLGXRNXNrMW([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object HHVWhHba7vqJJ7dryODt([In] object obj0) => (object) ((DataClassMetadata) obj0).TypeRef;

    internal static object gT2CJ2baxN2DRXgfXi4c([In] object obj0) => (object) ((NamedMetadata) obj0).Description;

    internal static bool c4DBAUba0XfC3mK8tSLS([In] object obj0) => ((AbstractMetadata) obj0).Internal;

    internal static object HCcROqbamplI0bHKuj5Q([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static void zGpjivbayYsQvK2HYFhH([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).Name = (string) obj1;

    internal static object NE8ty2baMKBfuH3oeyDE([In] object obj0) => (object) ((ClassMetadata) obj0).CustomCode;

    internal static void nGf43obaJnlqiD4HqJM0([In] object obj0, [In] object obj1) => ((ClassMetadata) obj0).CustomCode = (string) obj1;

    internal static object xKuHHNba9u07e7TQaIOf([In] object obj0) => (object) ((ClassMetadata) obj0).DefaultForms;

    internal static object erKtUJbadr3rk71IvSju([In] object obj0) => (object) ((ClassMetadata) obj0).DisplayFormat;

    internal static void XlXLC0balZpdDTyWpbon([In] object obj0, [In] object obj1) => ((ClassMetadata) obj0).DisplayFormat = (string) obj1;

    internal static ClassFormsScheme IyL1FjbariLTjHoTDaxT([In] object obj0) => ((ClassMetadata) obj0).FormsScheme;

    internal static void GFLeqNbagQwHGVcSIcch([In] object obj0, ClassFormsScheme value) => ((ClassMetadata) obj0).FormsScheme = value;

    internal static long VAZSruba5S1rPsF0HEju([In] object obj0) => ((ClassMetadata) obj0).GroupId;

    internal static void SxdFADbajKdN5JnXB4W6([In] object obj0, long value) => ((ClassMetadata) obj0).GroupId = value;

    internal static void VeWkPtbaYpoaRLtTJlEv([In] object obj0, bool value) => ((ClassMetadata) obj0).InheritForms = value;

    internal static Guid je2MpmbaLwebILt5U8lm([In] object obj0) => ((AbstractMetadata) obj0).ModuleUid;

    internal static bool RCnjXBbaU1jhR66TkLG3([In] object obj0) => ((ClassMetadata) obj0).AllowCreateHeirs;

    internal static Guid PqOZBFbasB9xllqHQijV([In] object obj0) => ((ClassMetadata) obj0).BaseClassUid;

    internal static void nD1QGabac96bKhpCHilM([In] object obj0, Guid value) => ((ClassMetadata) obj0).BaseClassUid = value;

    internal static object kO3p9NbazkmkDSRKW8eJ([In] object obj0) => (object) ((ClassMetadata) obj0).NamespaceForDisplay;

    internal static void CMVUYcbDFvbRyjoRgCN2([In] object obj0, [In] object obj1) => ((ClassMetadata) obj0).NamespaceForDisplay = (string) obj1;

    internal static bool hcaaR6bDBDSRFOYh8yrW([In] object obj0) => ((ClassMetadata) obj0).ShowInDesigner;

    internal static void xfegw7bDWF7C1un3YSbb([In] object obj0, bool value) => ((ClassMetadata) obj0).ShowInDesigner = value;

    internal static object VRgOpgbDoIOmvajU9dhO([In] object obj0) => (object) ((ClassMetadata) obj0).ScriptModuleTypeName;

    internal static void UsekyrbDbTY4UAlJC21U([In] object obj0, [In] object obj1) => ((ClassMetadata) obj0).ScriptModuleTypeName = (string) obj1;

    internal static bool FjtTFybDhpVjsLOi5xg5([In] object obj0) => ((ClassMetadata) obj0).ShowInTypeTree;

    internal static void mUg4qdbDGfh6fIuXZBV8([In] object obj0, bool value) => ((ClassMetadata) obj0).ShowInTypeTree = value;

    internal static object tUpcHLbDE6OagdJ6ETTr([In] object obj0) => (object) ((ClassMetadata) obj0).OnViewLoadScriptName;

    internal static bool hueHg5bDf27W861etRuU([In] object obj0, [In] object obj1) => (System.Reflection.PropertyInfo) obj0 == (System.Reflection.PropertyInfo) obj1;

    internal static object sPImf4bDQrifurVrs72G([In] object obj0, [In] object obj1) => ((System.Reflection.PropertyInfo) obj0).GetValue(obj1);

    internal static object iZcysubDCVBuKAfNv7wx([In] object obj0, Guid typeUid) => (object) ((DataClassDescriptor) obj0).GetMetadataByUid(typeUid);

    internal static void v3JMWmbDvUmUYOv20N9n([In] object obj0, Guid value) => ((ClassDefaultForms) obj0).CreateUid = value;

    internal static void WFwAA7bD8XnbY4Mxkjfy([In] object obj0, Guid value) => ((ClassDefaultForms) obj0).EditUid = value;

    internal static void FCR7HEbDZFBhl2O6fTvg([In] object obj0, Guid value) => ((ClassDefaultForms) obj0).DisplayUid = value;

    /// <summary>Информация о типе метаданных</summary>
    [Component]
    private new class Info : IMetadataTypeInfo
    {
      internal static object qXJ5lGCDt1Xc6QAQvvMV;

      /// <inheritdoc />
      public string Name => (string) DataClassMetadata.Info.jUmsUcCDHHvMFoG1LvOZ(DataClassMetadata.Info.SrKBoSCD6XiI88Ko7HaP(-1858887263 ^ -1858728763));

      /// <inheritdoc />
      public string Description => (string) DataClassMetadata.Info.jUmsUcCDHHvMFoG1LvOZ((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -489034065));

      /// <inheritdoc />
      public Type MetadataType => typeof (DataClassMetadata);

      /// <inheritdoc />
      public Type GeneratorType => typeof (DataClassGenerator);

      public Info()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static object SrKBoSCD6XiI88Ko7HaP(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object jUmsUcCDHHvMFoG1LvOZ([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static bool es06DtCDwK8MvUEh6b2f() => DataClassMetadata.Info.qXJ5lGCDt1Xc6QAQvvMV == null;

      internal static DataClassMetadata.Info jE8GnECD4Pb9vusPjNZK() => (DataClassMetadata.Info) DataClassMetadata.Info.qXJ5lGCDt1Xc6QAQvvMV;
    }
  }
}
