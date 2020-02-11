// File:    Category.cs
// Author:  126052
// Created: wtorek, 29 paüdziernika 2019 10:16:36
// Purpose: Definition of Class Category

using System;

public class Category
{
   private string _name;
   private string _description;
   
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
         this._products = new System.Collections.ArrayList();
      if (!this._products.Contains(newProduct))
      {
         this._products.Add(newProduct);
         newProduct.Add_categories(this);      
      }
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
         {
            this._products.Remove(oldProduct);
            oldProduct.Remove_categories(this);
         }
   }
   
   /// <summary>
   /// Remove all instances of Product from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAll_products()
   {
      if (_products != null)
      {
         System.Collections.ArrayList tmp_products = new System.Collections.ArrayList();
         foreach (Product oldProduct in _products)
            tmp_products.Add(oldProduct);
         _products.Clear();
         foreach (Product oldProduct in tmp_products)
            oldProduct.Remove_categories(this);
         tmp_products.Clear();
      }
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
   
   public string description
   {
      get
      {
         return _description;
      }
      set
      {
         this._description = value;
      }
   }
   
   public Category(String name, String description)
   {
      throw new NotImplementedException();
   }
   
   public void DisplayProducts()
   {
      throw new NotImplementedException();
   }

}