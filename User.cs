// File:    User.cs
// Author:  szjan
// Created: wtorek, 29 paüdziernika 2019 08:47:14
// Purpose: Definition of Class User

using System;

namespace ShopCore
{
    public class User
    {
        private String _password;

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
                        AddEligibility(oEligibility);
                }
            }
        }

        /// <summary>
        /// Add a new Eligibility in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddEligibility(Eligibility newEligibility)
        {
            if (newEligibility == null)
                return;
            if (this._eligibility == null)
                this._eligibility = new System.Collections.Generic.List<Eligibility>();
            if (!this._eligibility.Contains(newEligibility))
                this._eligibility.Add(newEligibility);
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

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Address { get; set; }

        public DateTime BirthDate { get; set; }

        public string Email { get; set; }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                this._password = ShopCore.Utility.UserUtilities.HashPassword(value);
            }
        }

        public int Id { get; set; }

        public User(int id, String name, String surname, String address, DateTime birthdate, String email, string password)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.Address = address;
            this.BirthDate = birthdate;
            this.Email = email;
            this.Password = password;
        }

    }
}