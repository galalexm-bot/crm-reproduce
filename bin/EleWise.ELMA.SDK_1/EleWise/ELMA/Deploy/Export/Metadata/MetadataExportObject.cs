// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.Metadata.MetadataExportObject
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExtensionPoints;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Xml;

namespace EleWise.ELMA.Deploy.Export.Metadata
{
  public class MetadataExportObject : IExportObject
  {
    private string serializedMd;
    internal static MetadataExportObject a4j40MEYNk0DlbeK2lUl;

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Use property Metadata", true)]
    public IGroupedMetadata Md
    {
      get => this.Metadata as IGroupedMetadata;
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
              this.Metadata = (IMetadata) this.Md;
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

    /// <summary>Метаданные</summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
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

    /// <summary>Список модулей скриптов</summary>
    /// <remarks>Ключ - название свойства, содержащего скрипт, Значение - идентификатор скрипта</remarks>
    public Dictionary<string, Guid> ScriptModules { get; set; }

    public MetadataExportObject()
    {
      MetadataExportObject.gX1BcXEYant7xoo3okhR();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
        num = 0;
      switch (num)
      {
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public MetadataExportObject(IGroupedMetadata metadata)
    {
      MetadataExportObject.gX1BcXEYant7xoo3okhR();
      // ISSUE: explicit constructor call
      this.\u002Ector((IMetadata) metadata);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>ctor</summary>
    /// <param name="metadata">Метаданные</param>
    public MetadataExportObject(IMetadata metadata)
    {
      MetadataExportObject.gX1BcXEYant7xoo3okhR();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Metadata = metadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public IExportObject Read()
    {
      int num1 = 1;
      string assemblyQualifiedName;
      IEnumerator<IPostEntityXmlSerializer> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            ((ILogger) MetadataExportObject.ytda25EYDdmoJKelSAj6()).Info((object) string.Format((string) MetadataExportObject.ofhww2EYte97hNywjPyx(1218962250 ^ 1218634258), (object) MetadataExportObject.jN3ZpcEYwSw2JYqP7fHx((object) this.Metadata)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
            continue;
          case 2:
            this.serializedMd = assemblyQualifiedName + this.serializedMd;
            num1 = 10;
            continue;
          case 3:
            this.serializedMd = (string) MetadataExportObject.iLs22uEY6F84xmkpSrFg((object) this.serializedMd, 0, MetadataExportObject.utmeI8EY425ERTvOttK2((object) this.serializedMd, MetadataExportObject.ofhww2EYte97hNywjPyx(-281842504 ^ -281861256)) + 1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 5 : 0;
            continue;
          case 4:
            goto label_11;
          case 5:
            assemblyQualifiedName = this.Metadata.GetType().AssemblyQualifiedName;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 3 : 7;
            continue;
          case 6:
          case 10:
            enumerator = ComponentManager.Current.GetExtensionPoints<IPostEntityXmlSerializer>().GetEnumerator();
            num1 = 9;
            continue;
          case 7:
            if (assemblyQualifiedName == null)
            {
              num1 = 6;
              continue;
            }
            goto case 2;
          case 8:
label_4:
            MetadataExportObject.NppiZwEYx52ooW8RLcV1((object) Logger.Log, (object) string.Format((string) MetadataExportObject.ofhww2EYte97hNywjPyx(~210725948 ^ -210398627), (object) MetadataExportObject.jN3ZpcEYwSw2JYqP7fHx((object) this.Metadata)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 1 : 4;
            continue;
          case 9:
            try
            {
label_14:
              if (MetadataExportObject.yZTTrCEYAHt6KidXtvJq((object) enumerator))
                goto label_17;
              else
                goto label_15;
label_13:
              IPostEntityXmlSerializer current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_4;
                  case 2:
                    this.serializedMd = (string) MetadataExportObject.w3AGnlEYHLFx3tXKESQ7((object) current, (object) this.serializedMd);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
                    continue;
                  case 3:
                    goto label_17;
                  default:
                    goto label_14;
                }
              }
label_15:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 1 : 1;
              goto label_13;
label_17:
              current = enumerator.Current;
              num2 = 2;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
              {
                num2 = 2;
                goto label_13;
              }
              else
                goto label_13;
            }
            finally
            {
              int num3;
              if (enumerator == null)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 1;
              else
                goto label_22;
label_21:
              switch (num3)
              {
                case 1:
                case 2:
              }
label_22:
              MetadataExportObject.Kk4GUYEY7XRrFXuVyCak((object) enumerator);
              num3 = 2;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
              {
                num3 = 0;
                goto label_21;
              }
              else
                goto label_21;
            }
          default:
            this.serializedMd = ClassSerializationHelper.SerializeObjectByXml((object) this.Metadata);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 3 : 2;
            continue;
        }
      }
label_11:
      return (IExportObject) this;
    }

    public DeployLogMessage Write(XmlWriter writer)
    {
      int num1 = 3;
      string text;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          ClassMetadata metadata;
          Dictionary<string, Guid>.Enumerator enumerator;
          string str;
          switch (num2)
          {
            case 1:
              metadata = this.Metadata as ClassMetadata;
              num2 = 6;
              continue;
            case 2:
              MetadataExportObject.vkbDdNEYmpkEoLyRbufQ((object) writer, MetadataExportObject.ofhww2EYte97hNywjPyx(-630932142 - 1120244082 ^ -1751147230));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 10 : 7;
              continue;
            case 3:
              goto label_12;
            case 4:
            case 5:
label_5:
              writer.WriteCData(this.serializedMd);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
              continue;
            case 6:
              if (metadata == null)
                goto case 13;
              else
                goto label_25;
            case 7:
              try
              {
label_18:
                if (enumerator.MoveNext())
                  goto label_16;
                else
                  goto label_19;
label_14:
                KeyValuePair<string, Guid> current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      MetadataExportObject.C0L6ABEYy5oLHLjTwJhX((object) writer, (object) current.Key, (object) current.Value.ToString());
                      num3 = 2;
                      continue;
                    case 2:
                      goto label_18;
                    case 3:
                      goto label_5;
                    default:
                      goto label_16;
                  }
                }
label_16:
                current = enumerator.Current;
                num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
                {
                  num3 = 0;
                  goto label_14;
                }
                else
                  goto label_14;
label_19:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 3;
                goto label_14;
              }
              finally
              {
                enumerator.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 8:
              goto label_26;
            case 9:
              MetadataExportObject.NppiZwEYx52ooW8RLcV1(MetadataExportObject.ytda25EYDdmoJKelSAj6(), MetadataExportObject.pYkRKFEY0TCTxM3rOpxO(MetadataExportObject.ofhww2EYte97hNywjPyx(647913418 ^ 647716332), (object) MetadataExportObject.jN3ZpcEYwSw2JYqP7fHx((object) this.Metadata)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 1 : 1;
              continue;
            case 10:
              if (this.ScriptModules == null)
              {
                num2 = 4;
                continue;
              }
              goto case 11;
            case 11:
              enumerator = this.ScriptModules.GetEnumerator();
              num2 = 7;
              continue;
            case 12:
              if (!MetadataExportObject.Ioyid8EY9pDxgNuIh3sQ(MetadataExportObject.sWSgvYEYJW5fW77JbShT((object) metadata)))
              {
                num2 = 14;
                continue;
              }
              goto case 13;
            case 13:
              str = EleWise.ELMA.SR.T((string) MetadataExportObject.ofhww2EYte97hNywjPyx(-398663332 ^ -398859468), (object) MetadataExportObject.jN3ZpcEYwSw2JYqP7fHx((object) this.Metadata));
              break;
            case 14:
              str = EleWise.ELMA.SR.T((string) MetadataExportObject.ofhww2EYte97hNywjPyx(-740338220 ^ -740665476), (object) this.Metadata.Uid, (object) metadata.DisplayName);
              break;
            default:
              MetadataExportObject.cEXMB1EYMhfV1C56gX4h((object) writer);
              num2 = 9;
              continue;
          }
          text = str;
          num2 = 8;
        }
label_12:
        MetadataExportObject.NppiZwEYx52ooW8RLcV1(MetadataExportObject.ytda25EYDdmoJKelSAj6(), MetadataExportObject.pYkRKFEY0TCTxM3rOpxO(MetadataExportObject.ofhww2EYte97hNywjPyx(-35995181 ^ -35667917), (object) this.Metadata.Uid));
        num1 = 2;
        continue;
label_25:
        num1 = 12;
      }
label_26:
      return new DeployLogMessage(DeployLogMessageType.Info, text, false);
    }

    public static string GetViewNamePrefix(ClassMetadata classMetadata)
    {
      int num = 6;
      ClassMetadata classMetadata1;
      while (true)
      {
        IMetadataService service;
        IMetadataService metadataService1;
        switch (num)
        {
          case 1:
            metadataService1 = (IMetadataService) Locator.GetServiceNotNull<IMetadataRuntimeService>();
            break;
          case 2:
            IMetadataService metadataService2 = service;
            if (metadataService2 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 1;
              continue;
            }
            metadataService1 = metadataService2;
            break;
          case 3:
            service = (IMetadataService) Locator.GetService<IMetadataEditorService>();
            num = 2;
            continue;
          case 4:
            if (MetadataExportObject.Og1dn6EYdP1aDbX3F9TF((object) (EntityMetadata) classMetadata1) == EntityMetadataType.InterfaceExtension)
            {
              num = 3;
              continue;
            }
            goto label_4;
          case 5:
            if (!(classMetadata1 is EntityMetadata))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
              continue;
            }
            goto case 4;
          case 6:
            classMetadata1 = classMetadata;
            num = 5;
            continue;
          default:
            goto label_4;
        }
        Guid metadataUid = MetadataExportObject.wXc7pIEYl3TptLQhOXiW((object) classMetadata1);
        classMetadata1 = (ClassMetadata) metadataService1.GetMetadata(metadataUid, false);
        num = 7;
      }
label_4:
      return (string) MetadataExportObject.cIPDrgEYg6D2qhEVSlp2((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178537416), MetadataExportObject.oIhyCkEYrsBIgR2u5iBu((object) classMetadata1), MetadataExportObject.ofhww2EYte97hNywjPyx(236071375 ^ 236080543));
    }

    public IEnumerable<FormExportData> GetFormExportData() => (IEnumerable<FormExportData>) new MetadataExportObject.\u003CGetFormExportData\u003Ed__18(-2)
    {
      \u003C\u003E4__this = this
    };

    internal static bool nfv9aQEY3Cc1SIFhpWp2() => MetadataExportObject.a4j40MEYNk0DlbeK2lUl == null;

    internal static MetadataExportObject DaYR0oEYpguvLGgGjZWX() => MetadataExportObject.a4j40MEYNk0DlbeK2lUl;

    internal static void gX1BcXEYant7xoo3okhR() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object ytda25EYDdmoJKelSAj6() => (object) Logger.Log;

    internal static object ofhww2EYte97hNywjPyx(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Guid jN3ZpcEYwSw2JYqP7fHx([In] object obj0) => ((IMetadata) obj0).Uid;

    internal static int utmeI8EY425ERTvOttK2([In] object obj0, [In] object obj1) => ((string) obj0).IndexOf((string) obj1);

    internal static object iLs22uEY6F84xmkpSrFg([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Remove(obj1, obj2);

    internal static object w3AGnlEYHLFx3tXKESQ7([In] object obj0, [In] object obj1) => (object) ((IPostEntityXmlSerializer) obj0).Replace((string) obj1);

    internal static bool yZTTrCEYAHt6KidXtvJq([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void Kk4GUYEY7XRrFXuVyCak([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void NppiZwEYx52ooW8RLcV1([In] object obj0, [In] object obj1) => ((ILogger) obj0).Info(obj1);

    internal static object pYkRKFEY0TCTxM3rOpxO([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static void vkbDdNEYmpkEoLyRbufQ([In] object obj0, [In] object obj1) => ((XmlWriter) obj0).WriteStartElement((string) obj1);

    internal static void C0L6ABEYy5oLHLjTwJhX([In] object obj0, [In] object obj1, [In] object obj2) => ((XmlWriter) obj0).WriteAttributeString((string) obj1, (string) obj2);

    internal static void cEXMB1EYMhfV1C56gX4h([In] object obj0) => ((XmlWriter) obj0).WriteEndElement();

    internal static object sWSgvYEYJW5fW77JbShT([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static bool Ioyid8EY9pDxgNuIh3sQ([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static EntityMetadataType Og1dn6EYdP1aDbX3F9TF([In] object obj0) => ((EntityMetadata) obj0).Type;

    internal static Guid wXc7pIEYl3TptLQhOXiW([In] object obj0) => ((ClassMetadata) obj0).BaseClassUid;

    internal static object oIhyCkEYrsBIgR2u5iBu([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object cIPDrgEYg6D2qhEVSlp2([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);
  }
}
