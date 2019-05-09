using System;
using System.Collections.Generic;
using System.Text;

namespace BrettspielClient
{
    public enum MessageType
    {
        doLogin,
        Ack,
        getPlayers,
        PlayerList,
        getBoard,
        BoardInfo,
        doRoll,
        Success,
        Fail,
        TurnEvent,
        BoardState
    }
}
