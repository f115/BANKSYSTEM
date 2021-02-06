using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BakingSystemUI.Core;
using BakingSystemUI.Data;
using BakingSystemUI.Roles;

namespace BakingSystemUI.Models
{
    public class Card : Entity
    {
        public BankName Bank { get; set; }
        public DurationType Duration { get; set; }
        public CardType CardType { get; set; }
        public string CardNumber { get; set; }
        public short CVC { get; set; }
        public DateTime ExpiredDate { get; set; }
        public decimal Balance { get; set; }
        public string CardHolder { get; set; }
        public int CardHolderId { get; set; }
    }
}
