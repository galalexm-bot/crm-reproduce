// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.PacketEntity
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy
{
  /// <summary>Пакет сущностей</summary>
  public class PacketEntity
  {
    /// <summary>Корневая сущность</summary>
    public IEntity Entity;
    /// <summary>Список вложеных сущностей</summary>
    public List<IEntity> SubEntities;
    /// <summary>Кастомные правила импорта свойств сущностей пакета</summary>
    public ExportRuleList ExportRules;
    /// <summary>Идентификатор содержимого пакета</summary>
    public string ContentType;
    /// <summary>Дополнительные данные пакета</summary>
    public IDictionary<string, object> PacketData;
    private int version;
    internal static PacketEntity AoG9ZMEpOhao5lp6xPbB;

    /// <summary>Конструктор для нетипизированного пакета</summary>
    public PacketEntity(IEntity entity)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
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
            this.SubEntities = new List<IEntity>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 2 : 2;
            continue;
          case 2:
            this.PacketData = (IDictionary<string, object>) new Dictionary<string, object>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
            continue;
          case 3:
            this.Entity = entity;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 1 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    /// <summary>Конструктор для типизированного пакета</summary>
    public PacketEntity(IEntity entity, string contentType)
    {
      PacketEntity.mJ6vAiEpP3r9kp8AqsIK();
      // ISSUE: explicit constructor call
      this.\u002Ector(entity);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.ContentType = contentType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Конструктор для типизированного пакета с версией</summary>
    public PacketEntity(IEntity entity, string contentType, int version)
    {
      PacketEntity.mJ6vAiEpP3r9kp8AqsIK();
      // ISSUE: explicit constructor call
      this.\u002Ector(entity, contentType);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Version = version;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Версия содержимого пакета</summary>
    public int Version
    {
      get => this.version;
      set
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              goto label_5;
            case 2:
              if (value <= 0)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 1;
                continue;
              }
              this.version = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
              continue;
            default:
              goto label_7;
          }
        }
label_2:
        return;
label_7:
        return;
label_5:
        throw new ArgumentOutOfRangeException((string) PacketEntity.WL7gWNEpNkjpuxXMv48J(PacketEntity.ThKYqVEp1CT02oC7sbfv(-2092274397 << 4 ^ 883054496)));
      }
    }

    /// <summary>Название узла пакета</summary>
    public string NodeName
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.version != 0)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_2;
          }
        }
label_2:
        return (string) PacketEntity.DrQBNQEp3qgRivQEaJUA(PacketEntity.ThKYqVEp1CT02oC7sbfv(-787452571 ^ -787218117), (object) this.version);
label_3:
        return (string) PacketEntity.ThKYqVEp1CT02oC7sbfv(-812025778 ^ -811784670);
      }
    }

    internal static bool oGNhNUEp2A0w510dGrYN() => PacketEntity.AoG9ZMEpOhao5lp6xPbB == null;

    internal static PacketEntity FCJptbEpevQa5Xmtq4cA() => PacketEntity.AoG9ZMEpOhao5lp6xPbB;

    internal static void mJ6vAiEpP3r9kp8AqsIK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object ThKYqVEp1CT02oC7sbfv(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object WL7gWNEpNkjpuxXMv48J([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object DrQBNQEp3qgRivQEaJUA([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);
  }
}
