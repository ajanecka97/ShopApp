// File:    BasePayment.cs
// Author:  126052
// Created: wtorek, 5 listopada 2019 10:39:23
// Purpose: Definition of Class BasePayment

using ShopCore.Data;
using System;
using System.Diagnostics;

namespace ShopCore
{

    public class BasePayment
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string ZipCode { get; set; }

        public BasePayment(string name, string surname, string address, string city, string zipCode)
        {
            this.Name = name;
            this.Surname = surname;
            this.Address = address;
            this.City = city;
            this.ZipCode = zipCode;
        }

        /// <summary>
        /// Method inserts payment data into the database.
        /// </summary>
        /// <param name="userID">Id of the user that made the payment.</param>
        public void InsertIntoDatabase(int userID)
        {
            DatabaseManager dbManager = new DatabaseManager();

            String insertText = "INSERT INTO Payment (UserID, Name, Surname, Address, City, ZipCode, Status)" +
                " VALUES (" + userID.ToString() + ",'" + Name.Replace("'", "''") + "','" + Surname.Replace("'", "''") +
                "','" + Address.Replace("'", "''") + "','" + City.Replace("'", "''") + "','" + ZipCode.Replace("'", "''") 
                + "','Completed');";
            Debug.Write(insertText);
            dbManager.ExecuteQuery(insertText);
        }

    }

}