// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.FunctionMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.Attributes;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Signatures;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Метаданные функции</summary>
  [EleWise.ELMA.Model.Attributes.Uid("{44D6296F-E38E-4704-ABD6-785CC856BAB9}")]
  [DataContract]
  [XmlExport]
  [Serializable]
  public class FunctionMetadata : NamedMetadata, ICodeItemMetadata, IMetadata, IXsiType
  {
    /// <summary>Строковый уникальный идентификатор типа метаданных</summary>
    public const string UID_S = "{44D6296F-E38E-4704-ABD6-785CC856BAB9}";
    /// <summary>Уникальный идентификатор типа метаданных</summary>
    public static Guid UID;
    internal static FunctionMetadata XZfGIvbpSl2N0XPb7JP0;

    /// <summary>Ctor</summary>
    public FunctionMetadata()
    {
      FunctionMetadata.kyu5Spbpq9xjuxWoLX8P();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.DataClassDependencies = new List<DataClassDependency>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 3;
            continue;
          case 3:
            this.EntityDependencies = new List<EntityDependency>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
            continue;
          default:
            this.EnumDependencies = new List<EnumDependency>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Ctor</summary>
    /// <param name="moduleUid">Идентификатор модуля</param>
    public FunctionMetadata(Guid moduleUid)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            FunctionMetadata.TIrvLubpKo5aPChZOoFs((object) this, moduleUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
            continue;
          default:
            FunctionMetadata.lT971dbpXUErE1JajoZX((object) this, moduleUid != Guid.Empty);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 1 : 0;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Ссылка на код функции</summary>
    public Guid? ScriptUid { get; set; }

    /// <summary>Сигнатура возвращаемого типа</summary>
    public TypeSignature ReturnType
    {
      get => this.\u003CReturnType\u003Ek__BackingField;
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
              this.\u003CReturnType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
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

    /// <summary>Сигнатура входного параметра</summary>
    public TypeSignature ParameterType
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
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
    /// Зависимости от датаклассов. Список заполнен только у элементов конфигурации
    /// </summary>
    public List<DataClassDependency> DataClassDependencies { get; set; }

    /// <summary>Зависимости от сущностей.</summary>
    public List<EntityDependency> EntityDependencies { get; set; }

    /// <summary>Зависимости от перечислений.</summary>
    public List<EnumDependency> EnumDependencies { get; set; }

    /// <inheritdoc />
    public string Namespace
    {
      get => this.\u003CNamespace\u003Ek__BackingField;
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
              this.\u003CNamespace\u003Ek__BackingField = value;
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

    /// <inheritdoc />
    public string NamespaceForDisplay
    {
      get => this.\u003CNamespaceForDisplay\u003Ek__BackingField;
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
              this.\u003CNamespaceForDisplay\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
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
    public string FullTypeName => (string) FunctionMetadata.UY4gn9bpkj9ThJDVRNEB((object) this.Namespace, FunctionMetadata.UG4An8bpTZxtlZODA5g1(1218962250 ^ 1218948244), (object) this.Name);

    /// <inheritdoc />
    public override void InitNew()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            base.InitNew();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.Namespace = z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 44959799);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Нужно ли сериализовать</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeDataClassDependencies() => this.DataClassDependencies.Count != 0;

    /// <summary>Нужно ли сериализовать</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeEntityDependencies() => FunctionMetadata.fCJkaHbpnkZDpbGAwWef((object) this.EntityDependencies) != 0;

    /// <summary>Нужно ли сериализовать</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeEnumDependencies() => FunctionMetadata.J6DUdtbpOXCruRrV8xjp((object) this.EnumDependencies) != 0;

    /// <summary>
    /// Нужно ли сериализовать <see cref="P:EleWise.ELMA.Model.Metadata.FunctionMetadata.ScriptUid" />
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeScriptUid()
    {
      int num = 1;
      Guid? scriptUid;
      while (true)
      {
        switch (num)
        {
          case 1:
            scriptUid = this.ScriptUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return scriptUid.HasValue;
    }

    static FunctionMetadata()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            FunctionMetadata.UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 1360521629));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void kyu5Spbpq9xjuxWoLX8P() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool B3bEEbbpiwm7fT6XBKKa() => FunctionMetadata.XZfGIvbpSl2N0XPb7JP0 == null;

    internal static FunctionMetadata s8sjBpbpRAi2nmAyg5fq() => FunctionMetadata.XZfGIvbpSl2N0XPb7JP0;

    internal static void TIrvLubpKo5aPChZOoFs([In] object obj0, Guid value) => ((AbstractMetadata) obj0).ModuleUid = value;

    internal static void lT971dbpXUErE1JajoZX([In] object obj0, bool value) => ((AbstractMetadata) obj0).Internal = value;

    internal static object UG4An8bpTZxtlZODA5g1(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object UY4gn9bpkj9ThJDVRNEB([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static int fCJkaHbpnkZDpbGAwWef([In] object obj0) => ((List<EntityDependency>) obj0).Count;

    internal static int J6DUdtbpOXCruRrV8xjp([In] object obj0) => ((List<EnumDependency>) obj0).Count;
  }
}
