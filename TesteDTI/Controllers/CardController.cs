using DomainApi.Entities;
using DomainApi.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteDTI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardController : ControllerBase
    {
        private readonly ICardService _cardService;

        public CardController(ICardService cardService)
        {
            _cardService = cardService;
        }

        [HttpPost]
        public string Create([FromBody] Card card)
        {
            string retorno = _cardService.RetornoCard(card);

            return retorno;
        }

        [HttpGet]
        public List<Card> GetCards()
        {
            return _cardService.GetCards();
        }

        [HttpGet("id")]
        public Card GetCardById(int idCard)
        {
            return _cardService.GetCardById(idCard);
        }
    }
}
