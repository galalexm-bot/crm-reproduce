// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.Components.MemoryMetadataComponent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Autofac.Builder;
using EleWise.ELMA.Design;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.ComponentModel.Components
{
  public abstract class MemoryMetadataComponent : 
    AbstractMetadataEditorComponent,
    IMetadataEditorService,
    IMetadataService
  {
    private static MemoryMetadataComponent AlCa4AfuY0yXemTnMl7k;

    /// <summary>Сохранить объекты метаданных</summary>
    /// <param name="metadataList">Объекты метаданных</param>
    public override void SaveMetadata(IEnumerable<IMetadata> metadataList)
    {
      foreach (IMetadata metadata in metadataList)
        this.AddOrReplaceMetadata(this.ProjectName, metadata);
      this.lastMetadataUpdate = DateTime.Now;
    }

    /// <summary>Удалить объект метаданных</summary>
    /// <param name="metadata">Объект метаданных</param>
    public override void RemoveMetadata(IMetadata metadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.lastMetadataUpdate = DateTime.Now;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            MemoryMetadataComponent.jVlO8QfucQZXWUhErCYH((object) this, MemoryMetadataComponent.lfns7kfusouuMx6QO9V4((object) this), (object) metadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Построить документацию</summary>
    public override void BuildDocumentation()
    {
      int num1 = 19;
      string str1;
      string path1_1;
      string str2;
      while (true)
      {
        int num2 = num1;
        string str3;
        List<string> stringList;
        string path1_2;
        string path;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (MemoryMetadataComponent.gUZpZAfIh7aKI5FxhKSu((object) path1_1))
              {
                num2 = 6;
                continue;
              }
              goto label_25;
            case 2:
              str1 = Path.Combine(path1_2, (string) MemoryMetadataComponent.obZqqDfuzS9LgRKkPCMN(-70007027 ^ -69797777));
              num2 = 14;
              continue;
            case 3:
              goto label_5;
            case 4:
              goto label_8;
            case 5:
              if (Directory.Exists(path))
                goto case 2;
              else
                goto label_22;
            case 6:
              goto label_26;
            case 7:
              str2 = (string) MemoryMetadataComponent.z4Uha2fIQOU3skbJDQfl(MemoryMetadataComponent.AOmBNafIfBX4Fiop43Fy(), MemoryMetadataComponent.obZqqDfuzS9LgRKkPCMN(1199946765 ^ 1199960461));
              num2 = 20;
              continue;
            case 8:
              Process process = new Process();
              MemoryMetadataComponent.rCQmYZfIvFASnaP3TW24((object) process.StartInfo, (object) str1);
              ((ProcessStartInfo) MemoryMetadataComponent.vuqyXLfI8NfG1BPlLbw7((object) process)).Arguments = (string) MemoryMetadataComponent.CPXIMOfIuCvyo094Ovbx(MemoryMetadataComponent.obZqqDfuzS9LgRKkPCMN(-680446928 - -370807692 ^ -309653858), MemoryMetadataComponent.FZ0XnOfIZi9Eo7xO4FVs((object) stringList));
              MemoryMetadataComponent.Eg36dEfIVJU91TT1gE6x((object) process.StartInfo, MemoryMetadataComponent.iDmJP2fIII9uRKghwhZN(MemoryMetadataComponent.AOmBNafIfBX4Fiop43Fy()));
              MemoryMetadataComponent.asf5tpfISyRtJpNTWeNG(MemoryMetadataComponent.vuqyXLfI8NfG1BPlLbw7((object) process), true);
              MemoryMetadataComponent.EWNorwfIihFvMZP6bk7t(MemoryMetadataComponent.vuqyXLfI8NfG1BPlLbw7((object) process), false);
              MemoryMetadataComponent.Nto1a1fIRTEraiPTZAq4((object) ((ProcessStartInfo) MemoryMetadataComponent.vuqyXLfI8NfG1BPlLbw7((object) process)).EnvironmentVariables, MemoryMetadataComponent.obZqqDfuzS9LgRKkPCMN(1199946765 ^ 1199604691), (object) path1_1);
              process.Start();
              process.WaitForExit();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 2 : 3;
              continue;
            case 9:
              goto label_11;
            case 10:
              str3 = (string) MemoryMetadataComponent.z4Uha2fIQOU3skbJDQfl(MemoryMetadataComponent.ImJAtpfICKVJNDylACE9(MemoryMetadataComponent.AOmBNafIfBX4Fiop43Fy()), MemoryMetadataComponent.obZqqDfuzS9LgRKkPCMN(-70007027 ^ -70005469));
              num2 = 4;
              continue;
            case 11:
              path1_2 = (string) MemoryMetadataComponent.XuEXn9fIo3oaK7wHCVWP(MemoryMetadataComponent.QAMHK1fIWiImE3ClDy10());
              num2 = 21;
              continue;
            case 12:
              MemoryMetadataComponent.w8MoyEfIGshK9XGPPVtS((object) path);
              num2 = 2;
              continue;
            case 13:
              goto label_15;
            case 14:
              if (MemoryMetadataComponent.OaBB4MfIEaAXqVUjCNEr((object) str1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 4 : 7;
                continue;
              }
              goto label_15;
            case 15:
              goto label_9;
            case 16:
              stringList.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978142944));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 1 : 8;
              continue;
            case 17:
              goto label_25;
            case 18:
              if (!MemoryMetadataComponent.wDytl3fIFAXBYmIWQRSY((object) path1_1))
              {
                num2 = 11;
                continue;
              }
              goto label_11;
            case 19:
              path1_1 = EleWise.ELMA.SR.GetSetting((string) MemoryMetadataComponent.obZqqDfuzS9LgRKkPCMN(1917998801 >> 2 ^ 479308770));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 15 : 18;
              continue;
            case 20:
              if (!MemoryMetadataComponent.OaBB4MfIEaAXqVUjCNEr((object) str2))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 4 : 15;
                continue;
              }
              stringList = new List<string>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
              continue;
            case 21:
              path1_1 = (string) MemoryMetadataComponent.fghQjXfIbPYjO4odO61I((object) path1_1, MemoryMetadataComponent.obZqqDfuzS9LgRKkPCMN(-1876063057 ^ -1876381099), (object) path1_2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 1;
              continue;
            default:
              goto label_24;
          }
        }
label_8:
        stringList.Add(str3);
        num1 = 16;
        continue;
label_22:
        num1 = 12;
        continue;
label_24:
        stringList.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 653980827));
        num1 = 10;
        continue;
label_26:
        path = Path.Combine(path1_1, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1574304984), (string) MemoryMetadataComponent.obZqqDfuzS9LgRKkPCMN(-345420348 ^ -345214322));
        num1 = 5;
      }
label_5:
      return;
label_9:
      throw new Exception(EleWise.ELMA.SR.T((string) MemoryMetadataComponent.obZqqDfuzS9LgRKkPCMN(-1334993905 ^ -1335319679), (object) str2));
label_11:
      throw new Exception((string) MemoryMetadataComponent.g2ta0ifIBo9c0YK90Ffo((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939714822)));
label_15:
      throw new Exception(EleWise.ELMA.SR.T((string) MemoryMetadataComponent.obZqqDfuzS9LgRKkPCMN(2045296739 + 1688595713 ^ -561278230), (object) str1));
label_25:
      throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(222162814 ^ 221827178), (object) path1_1));
    }

    /// <summary>Получить информацию об элементе метаданных</summary>
    /// <param name="metadata">Метаданные</param>
    /// <returns>Информация об элементе метаданных</returns>
    public override MetadataItemDTO GetMetadataItemDTO(IMetadata metadata) => (MetadataItemDTO) null;

    /// <summary>Получить все текущие элементы метаданных</summary>
    /// <returns>Список элементов метаданных</returns>
    public override IEnumerable<MetadataItemDTO> GetMetadataItemDTOList() => (IEnumerable<MetadataItemDTO>) new MetadataItemDTO[0];

    /// <summary>Действия при инициализации</summary>
    protected override void OnInit() => base.OnInit();

    /// <summary>Действия при завершении инициализации</summary>
    protected override void OnInitComplete()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            MemoryMetadataComponent.SCFBorfIqrdnNE2h70f5((object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
            continue;
          case 3:
            base.OnInitComplete();
            num = 2;
            continue;
          default:
            this.CurrentProjectName = (string) MemoryMetadataComponent.lfns7kfusouuMx6QO9V4((object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 1;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Регистрация данного компонента</summary>
    /// <param name="registrar">Регистратор</param>
    protected override void RegisterComponent(
      IRegistrationBuilder<AbstractMetadataEditorComponent, SimpleActivatorData, SingleRegistrationStyle> registrar)
    {
      base.RegisterComponent(registrar);
      registrar.As<IMetadataEditorService>();
    }

    protected virtual void AddReferences()
    {
    }

    /// <summary>Загрузить проект</summary>
    protected abstract void LoadProject();

    protected MemoryMetadataComponent()
    {
      MemoryMetadataComponent.XkxOjmfIKt8tm9XibpBR();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object lfns7kfusouuMx6QO9V4([In] object obj0) => (object) ((AbstractMetadataEditorComponent) obj0).ProjectName;

    internal static void jVlO8QfucQZXWUhErCYH([In] object obj0, [In] object obj1, [In] object obj2) => ((AbstractMetadataEditorComponent) obj0).RemoveMetadata((string) obj1, (IMetadata) obj2);

    internal static bool CViRgdfuLWRdZ8APmiA1() => MemoryMetadataComponent.AlCa4AfuY0yXemTnMl7k == null;

    internal static MemoryMetadataComponent H8CBQRfuUdFgtFU9ZmOc() => MemoryMetadataComponent.AlCa4AfuY0yXemTnMl7k;

    internal static object obZqqDfuzS9LgRKkPCMN(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool wDytl3fIFAXBYmIWQRSY([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object g2ta0ifIBo9c0YK90Ffo([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object QAMHK1fIWiImE3ClDy10() => (object) AppDomain.CurrentDomain;

    internal static object XuEXn9fIo3oaK7wHCVWP([In] object obj0) => (object) ((AppDomain) obj0).BaseDirectory;

    internal static object fghQjXfIbPYjO4odO61I([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static bool gUZpZAfIh7aKI5FxhKSu([In] object obj0) => Directory.Exists((string) obj0);

    internal static object w8MoyEfIGshK9XGPPVtS([In] object obj0) => (object) Directory.CreateDirectory((string) obj0);

    internal static bool OaBB4MfIEaAXqVUjCNEr([In] object obj0) => File.Exists((string) obj0);

    internal static object AOmBNafIfBX4Fiop43Fy() => (object) DesignEnvironment.LibsDir;

    internal static object z4Uha2fIQOU3skbJDQfl([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static object ImJAtpfICKVJNDylACE9([In] object obj0) => (object) Path.GetFileName((string) obj0);

    internal static void rCQmYZfIvFASnaP3TW24([In] object obj0, [In] object obj1) => ((ProcessStartInfo) obj0).FileName = (string) obj1;

    internal static object vuqyXLfI8NfG1BPlLbw7([In] object obj0) => (object) ((Process) obj0).StartInfo;

    internal static object FZ0XnOfIZi9Eo7xO4FVs([In] object obj0) => (object) ((List<string>) obj0).ToArray();

    internal static object CPXIMOfIuCvyo094Ovbx([In] object obj0, [In] object obj1) => (object) string.Join((string) obj0, (string[]) obj1);

    internal static object iDmJP2fIII9uRKghwhZN([In] object obj0) => (object) Path.GetDirectoryName((string) obj0);

    internal static void Eg36dEfIVJU91TT1gE6x([In] object obj0, [In] object obj1) => ((ProcessStartInfo) obj0).WorkingDirectory = (string) obj1;

    internal static void asf5tpfISyRtJpNTWeNG([In] object obj0, [In] bool obj1) => ((ProcessStartInfo) obj0).CreateNoWindow = obj1;

    internal static void EWNorwfIihFvMZP6bk7t([In] object obj0, [In] bool obj1) => ((ProcessStartInfo) obj0).UseShellExecute = obj1;

    internal static void Nto1a1fIRTEraiPTZAq4([In] object obj0, [In] object obj1, [In] object obj2) => ((StringDictionary) obj0).Add((string) obj1, (string) obj2);

    internal static void SCFBorfIqrdnNE2h70f5([In] object obj0) => ((MemoryMetadataComponent) obj0).LoadProject();

    internal static void XkxOjmfIKt8tm9XibpBR() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
