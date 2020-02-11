// File:    Payment.cs
// Author:  126052
// Created: wtorek, 5 listopada 2019 10:39:23
// Purpose: Definition of Class Payment

using System;

public class Payment
{
   private int _paymentID;
   private string _name;
   private string _surname;
   private string _address;
   private string _city;
   private string _zipCode;
   private string _status;
   
   public int PaymentID
   {
      get
      {
         return _paymentID;
      }
   }
   
   public string name
   {
      get
      {
         return _name;
      }
      set
      {
         this._name = value;
      }
   }
   
   public string surname
   {
      get
      {
         return _surname;
      }
      set
      {
         this._surname = value;
      }
   }
   
   public string address
   {
      get
      {
         return _address;
      }
      set
      {
         this._address = value;
      }
   }
   
   public string city
   {
      get
      {
         return _city;
      }
      set
      {
         this._city = value;
      }
   }
   
   public string zipCode
   {
      get
      {
         return _zipCode;
      }
      set
      {
         this._zipCode = value;
      }
   }
   
   public string Status
   {
      get
      {
         return _status;
      }
   }
   
   public Payment(string name, string surname, string address, string city, string zipCode)
   {
      throw new NotImplementedException();
   }
   
   public virtual bool CompletePayment()
   {
      throw new NotImplementedException();
   }

}