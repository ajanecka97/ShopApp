// File:    Cart.cs
// Author:  szjan
// Created: wtorek, 29 paüdziernika 2019 08:47:35
// Purpose: Definition of Class Cart

using System;

public class Cart
{
   private double CalculateValue()
   {
      throw new NotImplementedException();
   }
   
   private int _numberOfProducts;
   private double _totalValue;
   
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
         RemoveAll_products();
         if (value != null)
         {
            foreach (Product oProduct in value)
               Add_products(oProduct);
         }
      }
   }
   
   /// <summary>
   /// Add a new Product in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void Add_products(Product newProduct)
   {
      if (newProduct == null)
         return;
      if (this._products == null)
         this._products = new System.Collections.Generic.List<Product>();
      if (!this._products.Contains(newProduct))
         this._products.Add(newProduct);
   }
   
   /// <summary>
   /// Remove an existing Product from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void Remove_products(Product oldProduct)
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
   public void RemoveAll_products()
   {
      if (_products != null)
         _products.Clear();
   }
   
   public int NumberOfProducts
   {
      get
      {
         return _numberOfProducts;
      }
   }
   
   public double TotalValue
   {
      get
      {
         return _totalValue;
      }
   }
   
   public Cart()
   {
      throw new NotImplementedException();
   }
   
   public int Display()
   {
      throw new NotImplementedException();
   }
   
   public BasePayment ProceedToPayment(PaymentMethod paymentMethod)
   {
      throw new NotImplementedException();
   }

}