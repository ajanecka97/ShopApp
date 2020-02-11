// File:    PaymentWithCreditCard.cs
// Author:  126052
// Created: wtorek, 5 listopada 2019 11:10:49
// Purpose: Definition of Class PaymentWithCreditCard

using System;

public class PaymentWithCreditCard : BasePayment
{
   private string _creditCardNumber;
   private string _cvc;
   private DateTime _expirationDate;
   
   public string CreditCardNumber
   {
      get
      {
         return _creditCardNumber;
      }
      set
      {
         this._creditCardNumber = value;
      }
   }
   
   public string Cvc
   {
      get
      {
         return _cvc;
      }
      set
      {
         this._cvc = value;
      }
   }
   
   public DateTime ExpirationDate
   {
      get
      {
         return _expirationDate;
      }
      set
      {
         this._expirationDate = value;
      }
   }
   
   public PaymentWithCreditCard(string name, string surname, string address, string city, string zipCode, string creditCardNumber, string cvc, DateTime expirationDate)
   {
      throw new NotImplementedException();
   }
   
   public override bool CompletePayment()
   {
      throw new NotImplementedException();
   }

}