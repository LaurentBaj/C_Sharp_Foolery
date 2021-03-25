using System;
using System.Collections.Generic;

namespace DeckCreation
{
    public interface IDeck
    {
        Stack<String> _deckStack { get; }
        string PullCard();
    }
}