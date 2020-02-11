// File:    Cart.cs
// Author:  szjan
// Created: wtorek, 29 paüdziernika 2019 08:47:35
// Purpose: Definition of Class Cart

using System;

namespace ShopCore
{

    public class Cart
    {
        private System.Collections.Generic.List<Product> _products;

        /// <summary>
        /// Property for collection of Product
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.Generic.List<Product> Products
        {
            get
            {
                if (_products == null)
                    _products = new System.Collections.Generic.List<Product>();
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
                this._products = new System.Collections.Generic.List<Product>();
                this._products.Add(newProduct);
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
                    this._products.Remove(oldProduct);
        }

        /// <summary>
        /// Remove all instances of Product from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllProducts()
        {
            if (_products != null)
                _products.Clear();
        }

        public int NumberOfProducts { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Cart()
        {  }
    }

}