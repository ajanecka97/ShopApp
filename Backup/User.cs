// File:    User.cs
// Author:  szjan
// Created: wtorek, 29 paüdziernika 2019 08:47:14
// Purpose: Definition of Class User

using System;

public class User
{
   private string _name;
   private string _surname;
   private string _address;
   private DateTime _birthDate;
   private string _email;
   private string _password;
   
   private Cart _cart;
   private System.Collections.Generic.List<Eligibility> _eligibility;
   
   /// <summary>
   /// Property for collection of Eligibility
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<Eligibility> Eligibility
   {
      get
      {
         if (_eligibility == null)
            _eligibility = new System.Collections.Generic.List<Eligibility>();
         return _eligibility;
      }
      set
      {
         RemoveAll_eligibility();
         if (value != null)
         {
            foreach (Eligibility oEligibility in value)
               Add_eligibility(oEligibility);
         }
      }
   }
   
   /// <summary>
   /// Add a new Eligibility in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void Add_eligibility(Eligibility newEligibility)
   {
      if (newEligibility == null)
         return;
      if (this._eligibility == null)
         this._eligibility = new System.Collections.Generic.List<Eligibility>();
      if (!this._eligibility.Contains(newEligibility))
         this._eligibility.Add(newEligibility);
   }
   
   /// <summary>
   /// Remove an existing Eligibility from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void Remove_eligibility(Eligibility oldEligibility)
   {
      if (oldEligibility == null)
         return;
      if (this._eligibility != null)
         if (this._eligibility.Contains(oldEligibility))
            this._eligibility.Remove(oldEligibility);
   }
   
   /// <summary>
   /// Remove all instances of Eligibility from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAll_eligibility()
   {
      if (_eligibility != null)
         _eligibility.Clear();
   }
   private System.Collections.Generic.List<Payment> _paymentHistory;
   
   /// <summary>
   /// Property for collection of Payment
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<Payment> PaymentHistory
   {
      get
      {
         if (_paymentHistory == null)
            _paymentHistory = new System.Collections.Generic.List<Payment>();
         return _paymentHistory;
      }
      set
      {
         RemoveAll_paymentHistory();
         if (value != null)
         {
            foreach (Payment oPayment in value)
               Add_paymentHistory(oPayment);
         }
      }
   }
   
   /// <summary>
   /// Add a new Payment in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void Add_paymentHistory(Payment newPayment)
   {
      if (newPayment == null)
         return;
      if (this._paymentHistory == null)
         this._paymentHistory = new System.Collections.Generic.List<Payment>();
      if (!this._paymentHistory.Contains(newPayment))
         this._paymentHistory.Add(newPayment);
   }
   
   /// <summary>
   /// Remove an existing Payment from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void Remove_paymentHistory(Payment oldPayment)
   {
      if (oldPayment == null)
         return;
      if (this._paymentHistory != null)
         if (this._paymentHistory.Contains(oldPayment))
            this._paymentHistory.Remove(oldPayment);
   }
   
   /// <summary>
   /// Remove all instances of Payment from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAll_paymentHistory()
   {
      if (_paymentHistory != null)
         _paymentHistory.Clear();
   }
   
   public string Name
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
   
   public string Surname
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
   
   public string Address
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
   
   public DateTime BirthDate
   {
      get
      {
         return _birthDate;
      }
      set
      {
         this._birthDate = value;
      }
   }
   
   public string Email
   {
      get
      {
         return _email;
      }
      set
      {
         this._email = value;
      }
   }
   
   public string Password
   {
      get
      {
         return _password;
      }
      set
      {
         this._password = value;
      }
   }
   
   public User(String name, String surname, String address, DateTime birthdate, String email, String password)
   {
      throw new NotImplementedException();
   }

}