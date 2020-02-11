// File:    Category.cs
// Author:  126052
// Created: wtorek, 29 paüdziernika 2019 10:16:36
// Purpose: Definition of Class Category

using ShopCore.Data;
using System;
using System.Data;
using System.Diagnostics;

namespace ShopCore
{

    public class Category
    {
        private System.Collections.ArrayList _products;

        /// <summary>
        /// Property for collection of Product
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.ArrayList Products
        {
            get
            {
                if (_products == null)
                    _products = new System.Collections.ArrayList();
                return _products;
            }
            set
            {
                RemoveAllProducts();
                if (value != null)
                {
                    foreach (Product oProduct in value)
                        AddProduct(oProduct);
                }
            }
        }

        /// <summary>
        /// Add a new Product in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddProduct(Product newProduct)
        {
            if (newProduct == null)
                return;
            if (this._products == null)
                this._products = new System.Collections.ArrayList();
            if (!this._products.Contains(newProduct))
            {
                this._products.Add(newProduct);
                newProduct.AddCategory(this);
            }
        }

        /// <summary>
        /// Remove an existing Product from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveProduct(Product oldProduct)
        {
            if (oldProduct == null)
                return;
            if (this._products != null)
                if (this._products.Contains(oldProduct))
                {
                    this._products.Remove(oldProduct);
                    oldProduct.RemoveCategory(this);
                }
        }

        /// <summary>
        /// Remove all instances of Product from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllProducts()
        {
            if (_products != null)
            {
                System.Collections.ArrayList tmp_products = new System.Collections.ArrayList();
                foreach (Product oldProduct in _products)
                    tmp_products.Add(oldProduct);
                _products.Clear();
                foreach (Product oldProduct in tmp_products)
                    oldProduct.RemoveCategory(this);
                tmp_products.Clear();
            }
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public Category(String name, String description)
        {
            this.Name = name;
            this.Description = description;
        }

        /// <summary>
        /// Loads Category list from the database
        /// </summary>
        /// <returns>List of categories</returns>
        public static System.Collections.Generic.List<Category> LoadListFromDatabase()
        {
            DatabaseManager dbManager = new DatabaseManager();
            String sqlCommand = "SELECT * FROM Category";
            DataTable categoriesDT = dbManager.Load(sqlCommand);

            System.Collections.Generic.List<Category> categories = new System.Collections.Generic.List<Category>();

            foreach (DataRow row in categoriesDT.Rows)
            {
                String name = row["Name"].ToString();
                String description = row["Description"].ToString();

                categories.Add(new Category(name, description));
            }

            return categories;
        }

        /// <summary>
        /// Inserts product data into Products field.
        /// </summary>
        /// <param name="categoryID">Id of the category</param>
        public void LoadProductsFromCategory(int categoryID)
        {
            DatabaseManager dbManager = new DatabaseManager();
            String sqlCommand = "SELECT * FROM Product WHERE ProductID IN (SELECT ProductID FROM ProductCategory WHERE CategoryID = " + categoryID + ");";
            DataTable categoriesDT = dbManager.Load(sqlCommand);

            foreach (DataRow row in categoriesDT.Rows)
            {
                 String name = row["Name"].ToString();
                 int price = Int32.Parse(row["Price"].ToString());
                 int amountAvailable = Int32.Parse(row["AmountAvailable"].ToString());
                 String description = row["Description"].ToString();

                 this.AddProduct(new Product(name, price, amountAvailable, description));

                Debug.Write(name + "Category: " + categoryID + "\n");
                 
            }

        }


    }
}