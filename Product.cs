// File:    Product.cs
// Author:  szjan
// Created: wtorek, 29 paüdziernika 2019 08:54:22
// Purpose: Definition of Class Product

using System;
using System.Data;
using System.Diagnostics;
using ShopCore.Data;


namespace ShopCore
{
    public class Product
    {
        private int _productID;
        private System.Collections.ArrayList _categories;


        /// <summary>
        /// Add a new Category in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddCategory(Category newCategory)
        {
            if (newCategory == null)
                return;
            if (this._categories == null)
                this._categories = new System.Collections.ArrayList();
            if (!this._categories.Contains(newCategory))
            {
                this._categories.Add(newCategory);
                newCategory.AddProduct(this);
            }
        }

        /// <summary>
        /// Remove an existing Category from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveCategory(Category oldCategory)
        {
            if (oldCategory == null)
                return;
            if (this._categories != null)
                if (this._categories.Contains(oldCategory))
                {
                    this._categories.Remove(oldCategory);
                    oldCategory.RemoveProduct(this);
                }
        }

        public string Name { get; set; }

        public int Price { get; set; }

        public int AmountAvailable { get; set; }

        public string Description { get; set; }

        public double Rating { get; set; }

        public Product(String name, int price, int amountAvailable, String description)
        {
            Name = name;
            Price = price;
            AmountAvailable = amountAvailable;
            Description = description;
        }


        /// <summary>
        /// Inserts product data into database.
        /// </summary>
        public void InsertIntoDatabase()
        {
            DatabaseManager dbManager = new DatabaseManager();

            String insertText = "INSERT INTO Product (Name, Price, AmountAvailable, Description, Rating)" +
                " VALUES ('" + Name.Replace("'", "''") + "'," + Price.ToString() + "," + AmountAvailable.ToString() + ",'" +
                Description.Replace("'", "''") + "'," + Rating.ToString() + ");";
            Debug.Write(insertText);
            dbManager.ExecuteQuery(insertText);

            _productID = dbManager.LastRowID("Product");
        }

        /// <summary>
        /// Adds product to the category and inserts that data into database.
        /// </summary>
        /// <param name="categoryID">Id of category of the product</param>
        public void AddCategory(int categoryID)
        {
            DatabaseManager dbManager = new DatabaseManager();

            String insertText = "INSERT INTO ProductCategory (ProductID, CategoryID)" +
                " VALUES (" + _productID.ToString() + "," + categoryID.ToString() + ");";

            dbManager.ExecuteQuery(insertText);
        }

        /// <summary>
        /// Loads products from Database.
        /// </summary>
        /// <returns>Products List in form of DataTable</returns>
        public static DataTable LoadFromDatabase()
        {
            DatabaseManager dbManager = new DatabaseManager();
            String sqlCommand = "SELECT * FROM Product";
            DataTable Products = dbManager.Load(sqlCommand);

            return Products;
        }

    }

}