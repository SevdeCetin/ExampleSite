﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ExampleSite.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category() {Name="KAMERA", Description="KAMERA ÜRÜNLERİ"},
                new Category() {Name="TELEFON", Description="TELEFON ÜRÜNLERİ"},
                new Category() {Name="BİLGİSAYAR", Description="BİLGİSAYAR ÜRÜNLERİ"},
            };
            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
                context.SaveChanges();
            }
            var urunler = new List<Product>()
            {
                new Product() {Name="Canon", Description="KAMERA ÜRÜNLERİ", Price=2500, Stock=125, IsHome=true, IsApproved=true, IsFeatured=false, Slider=true, CategoryId=1, image="1.jpg"},
                new Product() {Name="Asus", Description="BİLGİSAYAR ÜRÜNLERİ", Price=2000, Stock=100, IsHome=true, IsApproved=true, IsFeatured=true, Slider=true, CategoryId=3, image="2.jpg"},
                new Product() {Name="Lenovo", Description="BİLGİSAYAR ÜRÜNLERİ", Price=3000, Stock=50, IsHome=false, IsApproved=true, IsFeatured=true, Slider=false, CategoryId=3, image="3.jpg"},
                new Product() {Name="Samsung 6s", Description="TELEFON ÜRÜNLERİ", Price=5000, Stock=150, IsHome=true, IsApproved=true, IsFeatured=true, Slider=true, CategoryId=2, image="4.jpg"},
            };
            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
                context.SaveChanges();
            }
            base.Seed(context);
        }
    }
}