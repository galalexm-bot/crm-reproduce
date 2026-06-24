// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Metadata.FormMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml;

namespace EleWise.ELMA.UI.Metadata
{
  public abstract class FormMetadata : 
    NamedMetadata,
    ICodeItemMetadata,
    IMetadata,
    IXsiType,
    IRootMetadata
  {
    private static FormMetadata mirmE1BEIyxWexdAAiic;

    /// <summary>
    /// Получить уникальный идентификатор данного типа метаданных
    /// </summary>
    /// <returns></returns>
    public abstract Guid GetTypeUid();

    /// <summary>Пространство имен</summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
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

    /// <summary>Отображаемое пространство имен</summary>
    [DefaultValue("")]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
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

    public string FullTypeName => (string) FormMetadata.dgO3mNBEq5cJ2EPmxUUO((object) this.Namespace, FormMetadata.LTZJ9NBEik7Hjkntgkgn(1917256330 ^ 1917261902), FormMetadata.k3PtfBBERuVYtsWjDFJw((object) this));

    public virtual void LoadFromType(Type type, bool inherit = true)
    {
      int num1 = 2;
      Stream manifestResourceStream;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_45;
          case 1:
            goto label_2;
          case 2:
            manifestResourceStream = type.Assembly.GetReflectionManifestResourceStream((string) FormMetadata.ddaoqGBEKwcTOU95dftq((object) type.FullName, FormMetadata.LTZJ9NBEik7Hjkntgkgn(-1837662597 ^ -1837648853)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 1;
            continue;
          default:
            goto label_44;
        }
      }
label_45:
      return;
label_44:
      return;
label_2:
      try
      {
        int num2;
        if (manifestResourceStream == null)
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 1 : 1;
        else
          goto label_6;
label_4:
        XmlTextReader reader;
        switch (num2)
        {
          case 1:
            throw new InvalidOperationException((string) FormMetadata.LTZJ9NBEik7Hjkntgkgn(-2106517564 ^ -2106459412));
          default:
            try
            {
              Type tp = FormMetadata.SqofaOBEXF6GMICWLuvc((object) this);
              int num3 = 3;
              FormMetadata formMetadata;
              IEnumerator<PropertyInfo> enumerator;
              while (true)
              {
                switch (num3)
                {
                  case 0:
                    goto label_30;
                  case 1:
                    if (formMetadata == null)
                    {
                      num3 = 5;
                      continue;
                    }
                    goto case 4;
                  case 2:
                    goto label_14;
                  case 3:
                    formMetadata = (FormMetadata) ClassSerializationHelper.DeserializeObjectByXml(tp, (XmlReader) reader);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 1 : 1;
                    continue;
                  case 4:
                    PropertyInfo[] properties = tp.GetProperties();
                    // ISSUE: reference to a compiler-generated field
                    Func<PropertyInfo, bool> func = FormMetadata.\u003C\u003Ec.\u003C\u003E9__11_0;
                    Func<PropertyInfo, bool> predicate;
                    if (func == null)
                    {
                      // ISSUE: reference to a compiler-generated field
                      FormMetadata.\u003C\u003Ec.\u003C\u003E9__11_0 = predicate = (Func<PropertyInfo, bool>) (p =>
                      {
                        int num4 = 2;
                        while (true)
                        {
                          switch (num4)
                          {
                            case 1:
                              // ISSUE: reference to a compiler-generated method
                              if (FormMetadata.\u003C\u003Ec.WTEynLQboHgyAeyjjMU2((object) p))
                              {
                                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
                                continue;
                              }
                              goto label_3;
                            case 2:
                              // ISSUE: reference to a compiler-generated method
                              if (FormMetadata.\u003C\u003Ec.YJbWHHQbWo6LxFld79vW((object) p).Length == 0)
                              {
                                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 1 : 1;
                                continue;
                              }
                              goto label_3;
                            default:
                              goto label_2;
                          }
                        }
label_2:
                        // ISSUE: reference to a compiler-generated method
                        return FormMetadata.\u003C\u003Ec.MlLlXiQbbhr258hu7ZH7((object) p);
label_3:
                        return false;
                      });
                    }
                    else
                      goto label_49;
label_32:
                    enumerator = ((IEnumerable<PropertyInfo>) properties).Where<PropertyInfo>(predicate).GetEnumerator();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 2 : 1;
                    continue;
label_49:
                    predicate = func;
                    goto label_32;
                  case 5:
                    goto label_25;
                  default:
                    goto label_24;
                }
              }
label_30:
              return;
label_25:
              return;
label_24:
              return;
label_14:
              try
              {
label_16:
                if (FormMetadata.tytNTjBEnpfCiqSyAbe5((object) enumerator))
                  goto label_18;
                else
                  goto label_17;
label_15:
                PropertyInfo current;
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 0:
                      goto label_38;
                    case 1:
                      goto label_18;
                    case 2:
                      FormMetadata.QAWjAeBEkCyqIpv13r4T((object) current, (object) this, FormMetadata.gAlstABETyCdebUYNPa0((object) current, (object) formMetadata, (object) null), (object) null);
                      num5 = 3;
                      continue;
                    case 3:
                      goto label_16;
                    default:
                      goto label_33;
                  }
                }
label_38:
                return;
label_33:
                return;
label_17:
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
                goto label_15;
label_18:
                current = enumerator.Current;
                num5 = 2;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
                {
                  num5 = 2;
                  goto label_15;
                }
                else
                  goto label_15;
              }
              finally
              {
                int num6;
                if (enumerator == null)
                  num6 = 2;
                else
                  goto label_26;
label_23:
                switch (num6)
                {
                  case 1:
                  case 2:
                }
label_26:
                FormMetadata.yNqBLABEORePWDTVwHxw((object) enumerator);
                num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
                {
                  num6 = 1;
                  goto label_23;
                }
                else
                  goto label_23;
              }
            }
            finally
            {
              if (reader != null)
              {
                int num7 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
                  num7 = 1;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                      FormMetadata.yNqBLABEORePWDTVwHxw((object) reader);
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_40;
                  }
                }
              }
label_40:;
            }
        }
label_6:
        reader = new XmlTextReader(manifestResourceStream);
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
        {
          num2 = 0;
          goto label_4;
        }
        else
          goto label_4;
      }
      finally
      {
        int num8;
        if (manifestResourceStream == null)
          num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
        else
          goto label_46;
label_43:
        switch (num8)
        {
          case 1:
            break;
          default:
        }
label_46:
        FormMetadata.yNqBLABEORePWDTVwHxw((object) manifestResourceStream);
        num8 = 2;
        goto label_43;
      }
    }

    public bool IsRestartNeeded(IRootMetadata metadata) => false;

    public void ApplyRestartUnrequiredChanges(bool inherit)
    {
    }

    public IEnumerable<IMetadata> GetMetadataToRegister()
    {
      List<IMetadata> metadataList = new List<IMetadata>();
      this.GetMetadataToRegister(metadataList);
      return (IEnumerable<IMetadata>) metadataList;
    }

    /// <summary>Получить метаданные контекста части формы</summary>
    /// <param name="uid">Уникальный идентификатор контекста</param>
    /// <returns></returns>
    public abstract EntityMetadata GetPartContext(Guid uid);

    /// <summary>Получить метаданные части формы</summary>
    /// <param name="partUid">Уникальный идентификатор части формы</param>
    /// <returns></returns>
    public abstract FormPartMetadata GetPart(Guid partUid);

    public abstract IEnumerable<Guid> PartUids { get; }

    /// <summary>
    /// Сгенерировать новые идентификаторы для всех составляющих элементов (например, для публикации или копирования)
    /// </summary>
    public virtual void GenerateNewUids()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            FormMetadata.i0f3qyBEekCgj1UP01NY((object) this, FormMetadata.Bqjds7BE2i2aVEVf0Qti());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    protected abstract void GetMetadataToRegister(List<IMetadata> metadataList);

    protected EntityMetadata FindFormContextRecursive(EntityMetadata metadata, Guid uid)
    {
      int num1 = 2;
      List<TablePartMetadata>.Enumerator enumerator;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_22;
            case 2:
              if (!FormMetadata.z0QBd6BE1d9n5IQVfJrR(FormMetadata.Xxc9LqBEPP6ciee3wlpc((object) metadata), uid))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 0;
                continue;
              }
              goto label_21;
            case 3:
              goto label_3;
            case 4:
              goto label_19;
            default:
              goto label_21;
          }
        }
label_22:
        enumerator = metadata.TableParts.GetEnumerator();
        num1 = 3;
      }
label_3:
      EntityMetadata contextRecursive1;
      try
      {
label_5:
        if (enumerator.MoveNext())
          goto label_10;
        else
          goto label_6;
label_4:
        EntityMetadata contextRecursive2;
        TablePartMetadata current;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_19;
            case 2:
              goto label_5;
            case 3:
              goto label_20;
            case 4:
              contextRecursive1 = contextRecursive2;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 3;
              continue;
            case 5:
              if (contextRecursive2 != null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 4 : 3;
                continue;
              }
              goto label_5;
            case 6:
              goto label_10;
            default:
              contextRecursive2 = this.FindFormContextRecursive((EntityMetadata) current, uid);
              num3 = 5;
              continue;
          }
        }
label_6:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 1;
        goto label_4;
label_10:
        current = enumerator.Current;
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
        {
          num3 = 0;
          goto label_4;
        }
        else
          goto label_4;
      }
      finally
      {
        enumerator.Dispose();
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
          num4 = 0;
        switch (num4)
        {
          default:
        }
      }
label_20:
      return contextRecursive1;
label_19:
      return (EntityMetadata) null;
label_21:
      return metadata;
    }

    protected FormMetadata()
    {
      FormMetadata.jT8pwkBENP5pRDbvNpyJ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool BRncqdBEVNwxrxDZBjSY() => FormMetadata.mirmE1BEIyxWexdAAiic == null;

    internal static FormMetadata RSEW2YBESNl6FN0Sv75Y() => FormMetadata.mirmE1BEIyxWexdAAiic;

    internal static object LTZJ9NBEik7Hjkntgkgn(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object k3PtfBBERuVYtsWjDFJw([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object dgO3mNBEq5cJ2EPmxUUO([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object ddaoqGBEKwcTOU95dftq([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static Type SqofaOBEXF6GMICWLuvc([In] object obj0) => obj0.GetType();

    internal static object gAlstABETyCdebUYNPa0([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyInfo) obj0).GetValue(obj1, (object[]) obj2);

    internal static void QAWjAeBEkCyqIpv13r4T([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);

    internal static bool tytNTjBEnpfCiqSyAbe5([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void yNqBLABEORePWDTVwHxw([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static Guid Bqjds7BE2i2aVEVf0Qti() => Guid.NewGuid();

    internal static void i0f3qyBEekCgj1UP01NY([In] object obj0, Guid value) => ((AbstractMetadata) obj0).Uid = value;

    internal static Guid Xxc9LqBEPP6ciee3wlpc([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static bool z0QBd6BE1d9n5IQVfJrR([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static void jT8pwkBENP5pRDbvNpyJ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
