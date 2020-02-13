using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class BlogInıtializer:DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category() { KategoriAdi="C#" },
                new Category() { KategoriAdi="Asp.Net MVC" },
                new Category() { KategoriAdi="Asp.Net WebForm" },
                new Category() { KategoriAdi="Windows Form" }
            };


            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item);
            }
            context.SaveChanges();


            List<Blog> bloglar = new List<Blog>() 
            {
                new Blog () { Baslik = "C#  Delegates HakkındaC#  ", EklenmeTarihi = DateTime.Now.AddDays(-10), Anasayfa =true, Onay = false, Icerik="C#  Delegates HakkındaC#  Delegates HakkındaC#  Delegates Hakkında", Resim = "1.jpg", CategoryId=1  },
                new Blog () { Baslik = "C#  Generic List HakkındaDelegates HakkındaC#  Delegates HakkındaC#  Delegates HakkındaC#  Delegates HakkındaC#  Delegates HakkındaC#  Delegates HakkındaC#  Delegates HakkındaC#  Delegates HakkındaC#  Delegates HakkındaC#  Delegates HakkındaC#  Delegates Hakkında", EklenmeTarihi = DateTime.Now.AddDays(-10), Anasayfa =true, Onay = true, Icerik="C#  Delegates HakkındaC#  Delegates HakkındaC#  Delegates Hakkında", Resim = "1.jpg", CategoryId=2  },
                new Blog () { Baslik = "C#  Delegates Hakkında", EklenmeTarihi = DateTime.Now.AddDays(-30), Anasayfa =false, Onay = true, Icerik="C#  Delegates HakkındaC#  Delegates HakkındaC#  Delegates Hakkında", Resim = "2.jpg", CategoryId=2  },
                new Blog () { Baslik = "C#  Delegates Hakkında", EklenmeTarihi = DateTime.Now.AddDays(-20), Anasayfa =true, Onay = true, Icerik="C#  Delegates HakkındaC#  Delegates HakkındaC#  Delegates Hakkında", Resim = "2.jpg", CategoryId=3  },
                new Blog () { Baslik = "C#  Delegates Hakkında", EklenmeTarihi = DateTime.Now.AddDays(-5), Anasayfa =false, Onay = true, Icerik="C#  Delegates HakkındaC#  Delegates HakkındaC#  Delegates Hakkında", Resim = "2.jpg", CategoryId=4  },
                new Blog () { Baslik = "C#  Delegates Hakkında", EklenmeTarihi = DateTime.Now.AddDays(-20), Anasayfa =true, Onay = false, Icerik="C#  Delegates HakkındaC#  Delegates HakkındaC#  Delegates Hakkında", Resim = "3.jpg", CategoryId=4  },
                new Blog () { Baslik = "C#  Delegates Hakkında", EklenmeTarihi = DateTime.Now.AddDays(-8), Anasayfa =true, Onay = false, Icerik="C#  Delegates HakkındaC#  Delegates HakkındaC#  Delegates Hakkında", Resim = "4.jpg", CategoryId=4  }
            };

            foreach (var item in bloglar)
            {
                context.Bloglar.Add(item);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}