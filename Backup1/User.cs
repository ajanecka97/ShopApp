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
   private System.Collections.Generic.List<BasePayment> _paymentHistory;
   
   /// <summary>
   /// Property for collection of BasePayment
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<BasePayment> PaymentHistory
   {
      get
      {
         if (_paymentHistory == null)
            _paymentHistory = new System.Collections.Generic.List<BasePayment>();
         return _paymentHistory;
      }
      set
      {
         RemoveAll_paymentHistory();
         if (value != null)
         {
            foreach (BasePayment oBasePayment in value)
               Add_paymentHistory(oBasePayment);
         }
      }
   }
   
   /// <summary>
   /// Add a new BasePayment in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void Add_paymentHistory(BasePayment newBasePayment)
   {
      if (newBasePayment == null)
         return;
      if (this._paymentHistory == null)
         this._paymentHistory = new System.Collections.Generic.List<BasePayment>();
      if (!this._paymentHistory.Contains(newBasePayment))
         this._paymentHistory.Add(newBasePayment);
   }
   
   /// <summary>
   /// Remove an existing BasePayment from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void Remove_paymentHistory(BasePayment oldBasePayment)
   {
      if (oldBasePayment == null)
         return;
      if (this._paymentHistory != null)
         if (this._paymentHistory.Contains(oldBasePayment))
            this._paymentHistory.Remove(oldBasePayment);
   }
   
   /// <summary>
   /// Remove all instances of BasePayment from the collection
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