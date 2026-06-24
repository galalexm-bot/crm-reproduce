// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.DTO.Models.FormMetadataItemDTO
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.DTO;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.UI.DTO.Models
{
  [Serializable]
  public class FormMetadataItemDTO : EntityDTO<long>, ISerializable
  {
    internal static FormMetadataItemDTO Ur5iQgJ2bDH3uF8bpMj;

    public FormMetadataItemDTO()
    {
      FormMetadataItemDTO.vOh5LlJ1Y46dOPx98O8();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Уникальный идентификатор</summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
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

    /// <summary>Дата создания</summary>
    public DateTime CreationDate
    {
      get => this.\u003CCreationDate\u003Ek__BackingField;
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
              this.\u003CCreationDate\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
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

    /// <summary>Идентификатор автора создания</summary>
    public long? CreationAuthorId { get; set; }

    /// <summary>Метаданные</summary>
    public object Metadata
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
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

    /// <summary>Заголовок</summary>
    public FormMetadataItemHeaderDTO Header
    {
      get => this.\u003CHeader\u003Ek__BackingField;
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
              this.\u003CHeader\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
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

    /// <summary>Модуль сценариев</summary>
    public ScriptModuleDTO ScriptModule
    {
      get => this.\u003CScriptModule\u003Ek__BackingField;
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
              this.\u003CScriptModule\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
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

    public void CopyIdsFrom(FormMetadataItemDTO item)
    {
      int num1 = 9;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              this.CreationAuthorId = item.CreationAuthorId;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 3 : 2;
              continue;
            case 2:
              if (FormMetadataItemDTO.x5As77JaOBrfqs3lFjD((object) item) != null)
              {
                num2 = 10;
                continue;
              }
              goto label_3;
            case 3:
              if (this.ScriptModule == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 3 : 7;
                continue;
              }
              goto case 2;
            case 4:
              FormMetadataItemDTO.TNXRoJJDmW5YinZ3bRW((object) this.ScriptModule, ((ScriptModuleDTO) FormMetadataItemDTO.x5As77JaOBrfqs3lFjD((object) item)).Uid);
              num2 = 5;
              continue;
            case 5:
              goto label_7;
            case 6:
              this.CreationDate = FormMetadataItemDTO.ulJ3n5JpCsQUCNul7SP((object) item);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 1;
              continue;
            case 7:
              goto label_16;
            case 8:
              this.Id = item.Id;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
              continue;
            case 9:
              Contract.ArgumentNotNull((object) item, (string) FormMetadataItemDTO.Iv0WpPJNJVx1BAVwo8y(-345420348 ^ -345381446));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 8 : 7;
              continue;
            case 10:
              this.ScriptModule.Id = ((EntityDTO<long>) FormMetadataItemDTO.x5As77JaOBrfqs3lFjD((object) item)).Id;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 4 : 1;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        this.Uid = FormMetadataItemDTO.Bj8DndJ3QZy4m6uvc2p((object) item);
        num1 = 6;
      }
label_7:
      return;
label_16:
      return;
label_3:;
    }

    protected FormMetadataItemDTO(SerializationInfo info, StreamingContext context)
    {
      FormMetadataItemDTO.vOh5LlJ1Y46dOPx98O8();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 3;
      string xml;
      object obj;
      IEnumerator<PropertyInfo> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            obj = ClassSerializationHelper.DeserializeObjectByXml(FormMetadataItemDTO.k36cAUJ4H6piG11G3AX((object) this), xml);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          case 3:
            // ISSUE: type reference
            xml = (string) FormMetadataItemDTO.ITY63jJwnrQ9XagMNvn((object) info, FormMetadataItemDTO.Iv0WpPJNJVx1BAVwo8y(-1872275253 >> 6 ^ -29281813), FormMetadataItemDTO.wYa9ksJtJnsBAZpMMRk(__typeref (string)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 1 : 1;
            continue;
          case 4:
            PropertyInfo[] properties = obj.GetType().GetProperties();
            // ISSUE: reference to a compiler-generated field
            Func<PropertyInfo, bool> func = FormMetadataItemDTO.\u003C\u003Ec.\u003C\u003E9__26_0;
            Func<PropertyInfo, bool> predicate;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              FormMetadataItemDTO.\u003C\u003Ec.\u003C\u003E9__26_0 = predicate = (Func<PropertyInfo, bool>) (p =>
              {
                int num2 = 3;
                while (true)
                {
                  switch (num2)
                  {
                    case 1:
                    case 2:
                      goto label_5;
                    case 3:
                      if (!p.CanRead)
                      {
                        num2 = 2;
                        continue;
                      }
                      goto case 4;
                    case 4:
                      // ISSUE: reference to a compiler-generated method
                      if (!FormMetadataItemDTO.\u003C\u003Ec.IoDdDhf5EDWbIZOsB9cv((object) p))
                      {
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 1 : 0;
                        continue;
                      }
                      goto label_4;
                    default:
                      goto label_4;
                  }
                }
label_4:
                return AttributeHelper<XmlIgnoreAttribute>.GetAttribute((MemberInfo) p, true) == null;
label_5:
                return false;
              });
            }
            else
              goto label_25;
label_24:
            enumerator = ((IEnumerable<PropertyInfo>) properties).Where<PropertyInfo>(predicate).GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 2 : 0;
            continue;
label_25:
            predicate = func;
            goto label_24;
          case 5:
            goto label_22;
          default:
            if (obj != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 3 : 4;
              continue;
            }
            goto label_17;
        }
      }
label_22:
      return;
label_17:
      return;
label_5:
      try
      {
label_8:
        if (enumerator.MoveNext())
          goto label_10;
        else
          goto label_9;
label_6:
        PropertyInfo current;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_12;
            case 2:
              goto label_8;
            case 3:
              goto label_10;
            default:
              FormMetadataItemDTO.IowDwKJHIVlI3QMipLM((object) current, (object) this, FormMetadataItemDTO.tGFYk4J6udbgSWF24L8((object) current, obj, (object) null), (object) null);
              num3 = 2;
              continue;
          }
        }
label_12:
        return;
label_9:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 1;
        goto label_6;
label_10:
        current = enumerator.Current;
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
        {
          num3 = 0;
          goto label_6;
        }
        else
          goto label_6;
      }
      finally
      {
        if (enumerator != null)
        {
          int num4 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0)
            num4 = 0;
          while (true)
          {
            switch (num4)
            {
              case 1:
                FormMetadataItemDTO.EjRaLKJAMlTdC2Meq2c((object) enumerator);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
                continue;
              default:
                goto label_19;
            }
          }
        }
label_19:;
      }
    }

    void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            FormMetadataItemDTO.Lx1wxsJ71to9pPbVeQe((object) info, FormMetadataItemDTO.Iv0WpPJNJVx1BAVwo8y(1051276242 - 990076387 ^ 61176167), (object) ClassSerializationHelper.SerializeObjectByXml((object) this));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static void vOh5LlJ1Y46dOPx98O8() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool yXbF1XJeve0oR03pspY() => FormMetadataItemDTO.Ur5iQgJ2bDH3uF8bpMj == null;

    internal static FormMetadataItemDTO KvgweWJP0Zgxv0J8UgF() => FormMetadataItemDTO.Ur5iQgJ2bDH3uF8bpMj;

    internal static object Iv0WpPJNJVx1BAVwo8y(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Guid Bj8DndJ3QZy4m6uvc2p([In] object obj0) => ((FormMetadataItemDTO) obj0).Uid;

    internal static DateTime ulJ3n5JpCsQUCNul7SP([In] object obj0) => ((FormMetadataItemDTO) obj0).CreationDate;

    internal static object x5As77JaOBrfqs3lFjD([In] object obj0) => (object) ((FormMetadataItemDTO) obj0).ScriptModule;

    internal static void TNXRoJJDmW5YinZ3bRW([In] object obj0, Guid value) => ((ScriptModuleDTO) obj0).Uid = value;

    internal static Type wYa9ksJtJnsBAZpMMRk([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object ITY63jJwnrQ9XagMNvn([In] object obj0, [In] object obj1, [In] Type obj2) => ((SerializationInfo) obj0).GetValue((string) obj1, obj2);

    internal static Type k36cAUJ4H6piG11G3AX([In] object obj0) => obj0.GetType();

    internal static object tGFYk4J6udbgSWF24L8([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyInfo) obj0).GetValue(obj1, (object[]) obj2);

    internal static void IowDwKJHIVlI3QMipLM([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);

    internal static void EjRaLKJAMlTdC2Meq2c([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void Lx1wxsJ71to9pPbVeQe([In] object obj0, [In] object obj1, [In] object obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);
  }
}
