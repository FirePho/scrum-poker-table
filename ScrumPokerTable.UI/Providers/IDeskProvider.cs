﻿using ScrumPokerTable.UI.Model;

namespace ScrumPokerTable.UI.Providers
{
    public interface IDeskProvider
    {
        string CreateDesk(string[] cards);
        void DeleteDesk(string deskName);
        Desk GetDesk(string deskName);
        void SetDeskState(string deskName, DeskState newState);

        void JoinUser(string deskName, string userName);
        void SetUserCard(string deskName, string userName, string card);
    }
}