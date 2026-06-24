// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.Listeners.PostFlushEventListener
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;

namespace EleWise.ELMA.Runtime.NH.Listeners
{
  /// <summary>
  /// Базовый класс точки расширения IPostFlushEventListener для прослушивания событий NHibernate после их выполнения
  /// <see cref="T:EleWise.ELMA.Runtime.NH.Listeners.IPostFlushEventListener" />
  /// </summary>
  /// <remarks>
  /// <see href="http://www.elma-bpm.ru/kb/article-790.html">Пример реализации в базе знаний</see>
  /// </remarks>
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  public class PostFlushEventListener : IPostFlushEventListener
  {
    private static PostFlushEventListener vG4hukW7vQyTicfVbarN;

    /// <summary>После вставки</summary>
    /// <param name="event">Параметры события</param>
    public virtual void OnPostInsert(PostInsertEvent @event)
    {
    }

    /// <summary>После обновления</summary>
    /// <param name="event">Параметры события</param>
    public virtual void OnPostUpdate(PostUpdateEvent @event)
    {
    }

    /// <summary>После удаления</summary>
    /// <param name="event">Параметры события</param>
    public virtual void OnPostDelete(PostDeleteEvent @event)
    {
    }

    /// <summary>После обновления элемента в коллекции</summary>
    /// <param name="event">Параметры события</param>
    public virtual void OnPostUpdateCollection(PostCollectionUpdateEvent @event)
    {
    }

    public PostFlushEventListener()
    {
      PostFlushEventListener.m4e37gW7uVFXpK7Ryu29();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void m4e37gW7uVFXpK7Ryu29() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool g1XB5OW78OqEoSiCCi3P() => PostFlushEventListener.vG4hukW7vQyTicfVbarN == null;

    internal static PostFlushEventListener gZRQOoW7Z3HUGsIemOxN() => PostFlushEventListener.vG4hukW7vQyTicfVbarN;
  }
}
