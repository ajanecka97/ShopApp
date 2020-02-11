// File:    Product.cs
// Author:  szjan
// Created: wtorek, 29 paüdziernika 2019 08:54:22
// Purpose: Definition of Class Product

using System;

public class Product
{
   private string _name;
   private int _price;
   private int _amountAvailable;
   private string _description;
   private double _rating;
   
   private System.Collections.ArrayList _categories;
   
   /// <summary>
   /// Property for collection of Category
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.ArrayList Categories
   {
      get
      {
         if (_categories == null)
            _categories = new System.Collections.ArrayList();
         return _categories;
      }
      set
      {
         RemoveAll_categories();
         if (value != null)
         {
            foreach (Category oCategory in value)
               Add_categories(oCategory);
         }
      }
   }
   
   /// <summary>
   /// Add a new Category in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void Add_categories(Category newCategory)
   {
      if (newCategory == null)
         return;
      if (this._categories == null)
         this._categories = new System.Collections.ArrayList();
      if (!this._categories.Contains(newCategory))
      {
         this._categories.Add(newCategory);
         newCategory.Add_products(this);      
      }
   }
   
   /// <summary>
   /// Remove an existing Category from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void Remove_categories(Category oldCategory)
   {
      if (oldCategory == null)
         return;
      if (this._categories != null)
         if (this._categories.Contains(oldCategory))
         {
            this._categories.Remove(oldCategory);
            oldCategory.Remove_products(this);
         }
   }
   
   /// <summary>
   /// Remove all instances of Category from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAll_categories()
   {
      if (_categories != null)
      {
         System.Collections.ArrayList tmp_categories = new System.Collections.ArrayList();
         foreach (Category oldCategory in _categories)
            tmp_categories.Add(oldCategory);
         _categories.Clear();
         foreach (Category oldCategory in tmp_categories)
            oldCategory.Remove_products(this);
         tmp_categories.Clear();
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
   
   public int Price
   {
      get
      {
         return _price;
      }
      set
      {
         this._price = value;
      }
   }
   
   public int AmountAvailable
   {
      get
      {
         return _amountAvailable;
      }
      set
      {
         this._amountAvailable = value;
      }
   }
   
   public string Description
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
   
   public double Rating
   {
      get
      {
         return _rating;
      }
      set
      {
         this._rating = value;
      }
   }
   
   public Product(String name, int price, int amountAvailable, String description)
   {
      throw new NotImplementedException();
   }
   
   public void DisplayProductDetails()
   {
      throw new NotImplementedException();
   }

}