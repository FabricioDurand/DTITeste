using DomainApi.Entities;
using DomainApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServicesApi
{
    public class CardService : ICardService
    {
        public string RetornoCard(Card card)
        {
            var lista = ListaDeCard();

            lista.Add(card);

            return "Sucesso em criar o card " + card.Name;
        }

        public List<Card> GetCards()
        {
            var lista = ListaDeCard();

            return lista;
        }

        public Card GetCardById(int id)
        {
            var lista = ListaDeCard();

            return lista.FirstOrDefault(x => x.Id == id);
        }

        public List<Card> ListaDeCard()
        {
            List<Card> cards = new List<Card>();
            Card card1 = new Card();

            card1.Id = 0;
            card1.Conteudo = "Conteudo";
            card1.Name = "Teste";

            cards.Add(card1);

            Card card2 = new Card();

            card2.Id = 1;
            card2.Conteudo = "ConteudoDois";
            card2.Name = "TesteDois";

            cards.Add(card2);

            return cards;
        }
    }
}
