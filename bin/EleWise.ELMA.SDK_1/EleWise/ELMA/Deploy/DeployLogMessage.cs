// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.DeployLogMessage
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps.Enum;
using EleWise.ELMA.Packaging;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy
{
  [Serializable]
  public class DeployLogMessage
  {
    private static DeployLogMessage krEjmVEpIIQvgEsrtm9r;

    public string ObjUidStr
    {
      get => this.\u003CObjUidStr\u003Ek__BackingField;
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
              this.\u003CObjUidStr\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
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

    public BPMAppItemImportStatus ImportStatus
    {
      get => this.\u003CImportStatus\u003Ek__BackingField;
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
              this.\u003CImportStatus\u003Ek__BackingField = value;
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

    public string MessageText
    {
      get => this.\u003CMessageText\u003Ek__BackingField;
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
              this.\u003CMessageText\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
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

    public DeployLogMessageType MessageType
    {
      get => this.\u003CMessageType\u003Ek__BackingField;
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
              this.\u003CMessageType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
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

    public bool EndStage
    {
      get => this.\u003CEndStage\u003Ek__BackingField;
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
              this.\u003CEndStage\u003Ek__BackingField = value;
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

    public bool EndProcess
    {
      get => this.\u003CEndProcess\u003Ek__BackingField;
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
              this.\u003CEndProcess\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
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

    public bool NeedRestart
    {
      get => this.\u003CNeedRestart\u003Ek__BackingField;
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
              this.\u003CNeedRestart\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
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

    public PackageInstallInfo InstallInfo
    {
      get => this.\u003CInstallInfo\u003Ek__BackingField;
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
              this.\u003CInstallInfo\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
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
    /// Идентификатор дерева к которому относится сообщение обновления узла
    /// </summary>
    public string TreeUid
    {
      get => this.\u003CTreeUid\u003Ek__BackingField;
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
              this.\u003CTreeUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
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

    public DeployLogMessage(DeployLogMessageType type, string text, bool endProcess)
    {
      DeployLogMessage.fh6kZhEpi14WBuaF23RX();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.MessageText = text;
            num = 4;
            continue;
          case 2:
            this.MessageType = type;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 1;
            continue;
          case 3:
            this.EndStage = false;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
            continue;
          case 4:
            this.EndProcess = endProcess;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 3 : 0;
            continue;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_7:;
    }

    public DeployLogMessage(DeployLogMessageType type, string text)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.MessageText = text;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 1;
            continue;
          default:
            this.MessageType = type;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    public DeployLogMessage(
      DeployLogMessageType type,
      string text,
      bool endProcess,
      bool endStage,
      bool needRestart = false)
    {
      DeployLogMessage.fh6kZhEpi14WBuaF23RX();
      // ISSUE: explicit constructor call
      this.\u002Ector(type, text, endProcess);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.NeedRestart = needRestart;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 2 : 0;
            continue;
          case 2:
            this.EndStage = endStage;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    /// <summary>Формирование сообщения о ходе (статусе) импорта</summary>
    /// <param name="importStatus">Статус установки элемента</param>
    /// <param name="objUid">Идентификатор элемента</param>
    /// <param name="treeUid">Идентификатор дерева</param>
    public DeployLogMessage(BPMAppItemImportStatus importStatus, Guid objUid, string treeUid)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
        num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.TreeUid = treeUid;
            num = 4;
            continue;
          case 2:
            this.MessageType = DeployLogMessageType.SystemImportStatus;
            num = 3;
            continue;
          case 3:
            this.ImportStatus = importStatus;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
            continue;
          case 4:
            goto label_7;
          default:
            this.ObjUidStr = !(objUid == new Guid()) ? (string) DeployLogMessage.Eh6l6kEpR48M9Ho0KeOF((object) objUid.ToString()) : string.Empty;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 1;
            continue;
        }
      }
label_7:;
    }

    /// <summary>Формирование сообщения о ходе (статусе) импорта</summary>
    /// <param name="importStatus">Статус установки элемента</param>
    /// <param name="objUidStr">Идентификатор элемента</param>
    /// <param name="treeUid">Идентификатор дерева</param>
    public DeployLogMessage(BPMAppItemImportStatus importStatus, string objUidStr, string treeUid)
    {
      DeployLogMessage.fh6kZhEpi14WBuaF23RX();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.ImportStatus = importStatus;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
            continue;
          case 3:
            this.TreeUid = treeUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 1 : 0;
            continue;
          case 4:
            this.MessageType = DeployLogMessageType.SystemImportStatus;
            num = 2;
            continue;
          default:
            this.ObjUidStr = objUidStr;
            num = 3;
            continue;
        }
      }
label_2:;
    }

    internal static bool X97xnZEpVoCFtUMnksum() => DeployLogMessage.krEjmVEpIIQvgEsrtm9r == null;

    internal static DeployLogMessage HqOayWEpSKIw83PFGsO1() => DeployLogMessage.krEjmVEpIIQvgEsrtm9r;

    internal static void fh6kZhEpi14WBuaF23RX() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object Eh6l6kEpR48M9Ho0KeOF([In] object obj0) => (object) ((string) obj0).ToLower();
  }
}
