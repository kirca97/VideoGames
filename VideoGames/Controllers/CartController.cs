﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoGames.Models;

namespace gamesProject.Controllers
{
    public class CartController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Buy(int id)
        {
            if (Session["cart"] == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item { VideoGame = db.VideoGames.Find(id), Quantity = 1 });
                Session["cart"] = cart;
            }
            else
            {
                List<Item> cart = (List<Item>)Session["cart"];
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new Item { VideoGame = db.VideoGames.Find(id), Quantity = 1 });
                }
                Session["cart"] = cart;
            }
            return RedirectToAction("Index");
        }
        public ActionResult Remove(int id)
        {
            List<Item> cart = (List<Item>)Session["cart"];
            int index = isExist(id);
            cart.RemoveAt(index);
            Session["cart"] = cart;
            return RedirectToAction("Index");
        }
        private int isExist(int id)
        {
            List<Item> cart = (List<Item>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
                if (cart[i].VideoGame.Id.Equals(id))
                    return i;
            return -1;
        }
    }
}