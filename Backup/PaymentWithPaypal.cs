// File:    PaymentWithPaypal.cs
// Author:  126052
// Created: wtorek, 5 listopada 2019 11:10:50
// Purpose: Definition of Class PaymentWithPaypal

using System;

public class PaymentWithPaypal : Payment
{
   private string _accountName;
   
   public string AccountName
   {
      get
      {
         return _accountName;
      }
      set
      {
         this._accountName = value;
      }
   }
   
   public PaymentWithPaypal(string name, string surname, string address, string city, string zipCode, string accountName)
   {
      throw new NotImplementedException();
   }
   
   public override bool CompletePayment()
   {
      throw new NotImplementedException();
   }

}