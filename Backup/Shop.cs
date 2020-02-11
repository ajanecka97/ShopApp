// File:    Shop.cs
// Author:  126052
// Created: wtorek, 29 paüdziernika 2019 10:47:16
// Purpose: Definition of Class Shop

using System;

public class Shop
{
   private const System.Collections.Generic.List<Category> _categories;
   
   /// <summary>
   /// Property for collection of Category
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<Category> Categories
   {
      get
      {
         if (_categories == null)
            _categories = new System.Collections.Generic.List<Category>();
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
         this._categories = new System.Collections.Generic.List<Category>();
      if (!this._categories.Contains(newCategory))
         this._categories.Add(newCategory);
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
            this._categories.Remove(oldCategory);
   }
   
   /// <summary>
   /// Remove all instances of Category from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAll_categories()
   {
      if (_categories != null)
         _categories.Clear();
   }
   private System.Collections.Generic.List<User> _users;
   
   /// <summary>
   /// Property for collection of User
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<User> Users
   {
      get
      {
         if (_users == null)
            _users = new System.Collections.Generic.List<User>();
         return _users;
      }
      set
      {
         RemoveAll_users();
         if (value != null)
         {
            foreach (User oUser in value)
               Add_users(oUser);
         }
      }
   }
   
   /// <summary>
   /// Add a new User in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void Add_users(User newUser)
   {
      if (newUser == null)
         return;
      if (this._users == null)
         this._users = new System.Collections.Generic.List<User>();
      if (!this._users.Contains(newUser))
         this._users.Add(newUser);
   }
   
   /// <summary>
   /// Remove an existing User from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void Remove_users(User oldUser)
   {
      if (oldUser == null)
         return;
      if (this._users != null)
         if (this._users.Contains(oldUser))
            this._users.Remove(oldUser);
   }
   
   /// <summary>
   /// Remove all instances of User from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAll_users()
   {
      if (_users != null)
         _users.Clear();
   }
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
   
   public void DisplayCategories()
   {
      throw new NotImplementedException();
   }

}