using DomainApi.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainApi.Interfaces
{
    public interface ICardService
    {
        string RetornoCard(Card card);
        List<Card> GetCards();
        Card GetCardById(int id);
    }
}
