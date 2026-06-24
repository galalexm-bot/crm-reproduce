// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Attributes.PacketAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Attributes
{
  /// <summary>Аттрибут пакета сущностей</summary>
  /// <remarks>
  /// Используется для формирования списка поддерживаемых версий типиризированных пакетов (пар Version-ContentType)
  /// Применять только к реализациям маркерного интерфейса <see cref="T:EleWise.ELMA.Deploy.ExtensionPoints.IPacketVersionProcessor" />
  /// </remarks>
  /// <example>
  /// Реализация <see cref="T:EleWise.ELMA.Deploy.ExtensionPoints.IPacketVersionProcessor" /> для отчетов
  /// <code>
  /// [Component]
  /// [Packet(ReportsConstants.FirstReportPacketVersion, ReportsConstants.ReportContentType)]
  /// public class ReportPacketVersionProcessor : IPacketVersionProcessor
  /// {
  /// }
  /// </code>
  /// </example>
  [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
  public class PacketAttribute : Attribute
  {
    private int version;
    private static PacketAttribute fOOgZdEppa5dyyPhNkLS;

    /// <summary>Версия пакета</summary>
    /// <remarks>Определяет название узла пакета</remarks>
    /// <example>
    /// Название узла пакета с версией 1
    /// <code>
    /// {Packet_1}
    /// </code>
    /// </example>
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
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 1 : 1;
                continue;
              }
              this.version = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
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
        throw new ArgumentOutOfRangeException((string) PacketAttribute.JoDiSwEpwtp997M4iNyn(PacketAttribute.kFI7lxEptRTgsRmYn4OJ(1470440286 ^ 1470211758)));
      }
    }

    /// <summary>Идентификатор содержимого пакета</summary>
    /// <remarks>Определяет тип содержимого пакета</remarks>
    /// <example>
    /// Узел пакета отчетов
    /// <code>
    /// {Packet_1 ContentType="EleWise.ELMA.Reports.Models.ReportHeader"}
    /// </code>
    /// </example>
    public string ContentType
    {
      get => this.\u003CContentType\u003Ek__BackingField;
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
              this.\u003CContentType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
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

    /// <summary>Версия типизированного пакета поддерживается</summary>
    [DefaultValue(true)]
    public bool Active
    {
      get => this.\u003CActive\u003Ek__BackingField;
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
              this.\u003CActive\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
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

    /// <summary>Ctor</summary>
    /// <param name="version">Версия пакета</param>
    /// <param name="contentType">Идентификатор контента</param>
    /// <param name="active">Версия пакета поддерживается</param>
    public PacketAttribute(int version, string contentType, bool active = true)
    {
      PacketAttribute.H1HTEpEp491UcOGgPG6M();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Version = version;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
            continue;
          case 2:
            this.Active = active;
            num = 3;
            continue;
          case 3:
            goto label_3;
          default:
            this.ContentType = contentType;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    internal static object kFI7lxEptRTgsRmYn4OJ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object JoDiSwEpwtp997M4iNyn([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool hDcZv8EpabEJrKfh2pOj() => PacketAttribute.fOOgZdEppa5dyyPhNkLS == null;

    internal static PacketAttribute BOFeWiEpD0WDHV6JsMpG() => PacketAttribute.fOOgZdEppa5dyyPhNkLS;

    internal static void H1HTEpEp491UcOGgPG6M() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
