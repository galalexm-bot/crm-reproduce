// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.Publication.GlobalScriptModulePublicationServerInstanceActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.ActorModel.Publication
{
  /// <summary>
  /// Актор экземпляра сервера (для публикации глобальных модулей <see cref="T:EleWise.ELMA.Model.Scripts.IGlobalScriptModule" />)
  /// </summary>
  internal sealed class GlobalScriptModulePublicationServerInstanceActor : 
    Actor,
    IGlobalScriptModulePublicationServerInstanceActor,
    IServerPlacementActor,
    IActorWithGuidKey,
    IActor
  {
    private readonly IGlobalScriptModulePublicationEventHandler globalScriptModulePublicationEventHandler;
    private static GlobalScriptModulePublicationServerInstanceActor F5pGu8fpStVb8ofKGXdC;

    /// <summary>Ctor</summary>
    /// <param name="globalScriptModulePublicationEventHandler">Событие публикации глобального модуля</param>
    public GlobalScriptModulePublicationServerInstanceActor(
      IGlobalScriptModulePublicationEventHandler globalScriptModulePublicationEventHandler)
    {
      GlobalScriptModulePublicationServerInstanceActor.BsKGWpfpqQoRLOx9GFYH();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.globalScriptModulePublicationEventHandler = globalScriptModulePublicationEventHandler;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <inheritdoc />
    public Task PublicationError(long globalScriptModuleId, Exception exception) => (Task) GlobalScriptModulePublicationServerInstanceActor.PmYfvEfpKl8iPgyjKs3Q((object) this.globalScriptModulePublicationEventHandler, globalScriptModuleId, (object) exception);

    /// <inheritdoc />
    public Task PublicationSuccess(long globalScriptModuleId) => (Task) GlobalScriptModulePublicationServerInstanceActor.Pa8Q6JfpXyjMAKqxZak1((object) this.globalScriptModulePublicationEventHandler, globalScriptModuleId);

    internal static void BsKGWpfpqQoRLOx9GFYH() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool NdofeNfpitXxv4Y5E6w9() => GlobalScriptModulePublicationServerInstanceActor.F5pGu8fpStVb8ofKGXdC == null;

    internal static GlobalScriptModulePublicationServerInstanceActor zOPjGwfpR8vRKVAP9WwE() => GlobalScriptModulePublicationServerInstanceActor.F5pGu8fpStVb8ofKGXdC;

    internal static object PmYfvEfpKl8iPgyjKs3Q(
      [In] object obj0,
      long globalScriptModuleId,
      [In] object obj2)
    {
      return (object) ((IGlobalScriptModulePublicationEventHandler) obj0).Error(globalScriptModuleId, (Exception) obj2);
    }

    internal static object Pa8Q6JfpXyjMAKqxZak1([In] object obj0, long globalScriptModuleId) => (object) ((IGlobalScriptModulePublicationEventHandler) obj0).Complete(globalScriptModuleId);
  }
}
