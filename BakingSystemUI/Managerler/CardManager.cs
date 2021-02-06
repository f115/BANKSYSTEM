using BakingSystemUI.Core;
using BakingSystemUI.Models;
using BakingSystemUI.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingSystemUI.Managers
{
    public class CardManager
    {
        private readonly string _bankName;
        private readonly string _duration;
        private readonly string _cardType;
        private readonly Random _random;
        private readonly User _user;

        public CardManager(string bankName, string duration, string cardType, User user)
        {
            _bankName = bankName;
            _duration = duration;
            _cardType = cardType;
            _random = new Random();
            _user = user;
        }

        private string GetCardNumber()
        {
            StringBuilder cardNumber = new StringBuilder();

            for (int i = 0; i < 4; i++)
            {
                cardNumber.Append(_random.Next(1000, 9999));
            }
            return cardNumber.ToString();
        }

        private short GetCVC()
        {
            return (short)_random.Next(100, 999);
        }

        private DateTime GetExpDate()
        {
            return DateTime.Now.AddYears(int.Parse(_duration));
        }

        private BankName GetCardName()
        {
            BankName bankName = default;
            switch (_bankName)
            {
                case "Kapital Bank": bankName = BankName.KapitalBank; break;
                case "Express Bank": bankName = BankName.ExpressBank; break;
                case "Yellow Bank": bankName = BankName.YellowBank; break;
                case "BTB Bank": bankName = BankName.BTBBank; break;
                case "Beynalxalq Bank": bankName = BankName.BeynalxalqBank; break;
            }
            return bankName;
        }

        private DurationType GetDurationType()
        {
            DurationType duratoinType = default;
            switch (int.Parse(_duration))
            {
                case (int)DurationType.OneYear: duratoinType = DurationType.OneYear; break;
                case (int)DurationType.TwoYears: duratoinType = DurationType.TwoYears; break;
                case (int)DurationType.FiveYears: duratoinType = DurationType.FiveYears; break;
                case (int)DurationType.TenYears: duratoinType = DurationType.TenYears; break;
            }
            return duratoinType;
        }

        private CardType GetCardType()
        {
            CardType cardType = default;
            switch (_cardType)
            {
                case "Salary Card": cardType = CardType.SalaryCard; break;
                case "Debet Card": cardType = CardType.DebetCard; break;
                case "Scolarship Card": cardType = CardType.ScolarshipCard; break;
                case "Credit Card": cardType = CardType.CreditCard; break;
            }
            return cardType;
        }

        public Card GetCard()
        {
            return new Card
            {
                Id = Identificator<Card>.GetId(),
                Bank = GetCardName(),
                CVC = GetCVC(),
                Duration = GetDurationType(),
                ExpiredDate = GetExpDate(),
                CardType = GetCardType(),
                CardNumber = GetCardNumber(),
                CardHolder = $"{_user.Name}, {_user.Surname}",
                CardHolderId = _user.Id,
                Balance = 0
            };



        }
    }
}
