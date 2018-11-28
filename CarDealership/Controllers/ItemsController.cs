using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class ItemsController : Controller
  {
    [HttpGet("/items")]
    public ActionResult Index()
    {
    List<Item> allItems = Item.GetAll();
    return View(allItems);
    }

    [HttpGet("/items/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/items/{id}")]
    public ActionResult Show(int id)
    {
      Item item = Item.Find(id);
      return View(item);
    }

    [HttpPost("/items")]
    public ActionResult Create(string makeModel, int price, int miles, string description)
    {
      Item myItem = new Item(makeModel, price, miles, description);
      return RedirectToAction("Index");
    }

   [HttpPost("/items/delete")]
    public ActionResult DeleteAll()
    {
      Item.ClearAll();
      return View();
    }

  }
}