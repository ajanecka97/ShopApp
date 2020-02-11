// File:    PaymentWithBankTransfer.cs
// Author:  126052
// Created: wtorek, 5 listopada 2019 11:10:48
// Purpose: Definition of Class PaymentWithBankTransfer

using System;

public class PaymentWithBankTransfer : BasePayment
{
   private string _bankAccount;
   
   public string bankAccount
   {
      get
      {
         return _bankAccount;
      }
      set
      {
         this._bankAccount = value;
      }
   }
   
   public PaymentWithBankTransfer(string name, string surname, string address, string city, string zipCode, string bankAccount) : basePayment(name, surname, address, city, zipCode)
   {
      throw new NotImplementedException();
   }
   
   public override bool CompletePayment()
   {
      throw new NotImplementedException();
   }

}