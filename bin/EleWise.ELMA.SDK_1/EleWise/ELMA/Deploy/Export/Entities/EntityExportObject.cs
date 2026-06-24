// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.Entities.EntityExportObject
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Deploy.Serialization;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml;

namespace EleWise.ELMA.Deploy.Export.Entities
{
  public class EntityExportObject : IExportObject
  {
    private IEntity entity;
    private EntityMetadata md;
    private ExportRuleList exportRules;
    private static readonly ILogger ExportLog;
    public Guid? CustomUid;
    public List<string> FileUids;
    internal static EntityExportObject lP3SE3EY5iyFpqokA155;

    public IEntity Entity => this.entity;

    public EntityExportObject(IEntity e)
    {
      EntityExportObject.PRxpR6EYLMVqNR6tLblU();
      this.FileUids = new List<string>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.md = (EntityMetadata) MetadataLoader.LoadMetadata(this.entity.CastAsRealType<IEntity>().GetType());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 1;
            continue;
          default:
            this.entity = e;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    public EntityExportObject(IEntity e, ExportRuleList rules)
    {
      EntityExportObject.PRxpR6EYLMVqNR6tLblU();
      this.FileUids = new List<string>();
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
            this.exportRules = rules;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
            continue;
          case 2:
            this.md = (EntityMetadata) MetadataLoader.LoadMetadata(this.entity.CastAsRealType<IEntity>().GetType());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 1;
            continue;
          case 3:
            this.entity = e;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 2 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    public IExportObject Read() => (IExportObject) this;

    /// <summary>Сериализация объекта и его запись</summary>
    /// <param name="writer"></param>
    /// <returns></returns>
    public DeployLogMessage Write(XmlWriter writer) => this.Write(writer, (IMetadata) null);

    /// <summary>Сериализация объекта и его запись</summary>
    /// <param name="writer"></param>
    /// <param name="metadataTrunc">ограниченя свойств при сериализации, будут импортированы только свойства пренадлежащие указанным метаданным и их родителям</param>
    /// <returns></returns>
    public DeployLogMessage Write(XmlWriter writer, IMetadata metadataTrunc)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              EntityExportObject.lmvYgMELFLtSs4L7hftq((object) writer, EntityExportObject.tdZuCYEYzNasRWvMmUMQ(-1839087379 - 334718690 ^ 2120877063));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
              continue;
            case 2:
              EntityExportObject.ExportLog.Info(EntityExportObject.AQ0YOAEYcpKmM6jjnwgv((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-710283084 ^ -537863435 ^ 173812055), EntityExportObject.YAVEiFEYUeWZFUK6lIsH((object) this.md), EntityExportObject.KKP69bEYsjKPVnpjUbo8((object) this.entity)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 0;
              continue;
            case 3:
            case 6:
              this.FileUids.AddRange((IEnumerable<string>) new EntityXmlSerializer().Serialize((object) this.entity, writer, (EntitySerializationSettings) null, this.exportRules, metadataTrunc));
              num2 = 5;
              continue;
            case 4:
              goto label_9;
            case 5:
              goto label_12;
            case 7:
              if (!this.CustomUid.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 6 : 6;
                continue;
              }
              goto case 9;
            case 8:
              goto label_10;
            case 9:
              writer.WriteAttributeString((string) EntityExportObject.tdZuCYEYzNasRWvMmUMQ(-97972138 ^ -97774790), this.CustomUid.ToString());
              num2 = 3;
              continue;
            default:
              EntityExportObject.PimhmPELWRBTOyb6YJWh((object) writer, EntityExportObject.tdZuCYEYzNasRWvMmUMQ(654297945 ^ 654281019), (object) EntityExportObject.xuNBpLELBT1nkUxDDKML((object) this.md).ToString());
              num2 = 7;
              continue;
          }
        }
label_10:
        EntityExportObject.UtfMxJELbxyaWd9VlRc0((object) EntityExportObject.ExportLog, EntityExportObject.AQ0YOAEYcpKmM6jjnwgv(EntityExportObject.tdZuCYEYzNasRWvMmUMQ(1669371371 ^ 1669699177), EntityExportObject.YAVEiFEYUeWZFUK6lIsH((object) this.md), this.entity.GetId()));
        num1 = 4;
        continue;
label_12:
        EntityExportObject.mh0l5AELoGLhh2kJje7m((object) writer);
        num1 = 8;
      }
label_9:
      return new DeployLogMessage(DeployLogMessageType.Info, EleWise.ELMA.SR.T((string) EntityExportObject.tdZuCYEYzNasRWvMmUMQ(44884861 ^ 44687529), (object) this.md.DisplayName, EntityExportObject.KKP69bEYsjKPVnpjUbo8((object) this.entity)), false);
    }

    static EntityExportObject()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            EntityExportObject.PRxpR6EYLMVqNR6tLblU();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            EntityExportObject.ExportLog = (ILogger) EntityExportObject.iKQKsdELhyiLjkN7Wqfo(EntityExportObject.tdZuCYEYzNasRWvMmUMQ(-649342099 - -1150814748 ^ 501726677));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static void PRxpR6EYLMVqNR6tLblU() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool OCoZcZEYjtXZHcGwE6Xb() => EntityExportObject.lP3SE3EY5iyFpqokA155 == null;

    internal static EntityExportObject RK7fHxEYYcCSyfUA8ZFT() => EntityExportObject.lP3SE3EY5iyFpqokA155;

    internal static object YAVEiFEYUeWZFUK6lIsH([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object KKP69bEYsjKPVnpjUbo8([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static object AQ0YOAEYcpKmM6jjnwgv([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object tdZuCYEYzNasRWvMmUMQ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void lmvYgMELFLtSs4L7hftq([In] object obj0, [In] object obj1) => ((XmlWriter) obj0).WriteStartElement((string) obj1);

    internal static Guid xuNBpLELBT1nkUxDDKML([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static void PimhmPELWRBTOyb6YJWh([In] object obj0, [In] object obj1, [In] object obj2) => ((XmlWriter) obj0).WriteAttributeString((string) obj1, (string) obj2);

    internal static void mh0l5AELoGLhh2kJje7m([In] object obj0) => ((XmlWriter) obj0).WriteEndElement();

    internal static void UtfMxJELbxyaWd9VlRc0([In] object obj0, [In] object obj1) => ((ILogger) obj0).Info(obj1);

    internal static object iKQKsdELhyiLjkN7Wqfo([In] object obj0) => (object) Logger.GetLogger((string) obj0);
  }
}
