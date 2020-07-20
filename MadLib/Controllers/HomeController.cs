using MadLib.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadLib.Controllers
{
  public class HomeController : Controller
  {


    [Route("/")]
    public string MadLib() { return "Your madlib will appear here!"; }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/madlib")]
    public ActionResult Libs(string collectiveNoun, string thing, string kitchenUtensil, string name, string shape, string clothingItem, string color, string seaCreature)
    {
      MadLibsVariables myMadLib = new MadLibsVariables();
      myMadLib.CollectiveNoun = collectiveNoun;
      myMadLib.Thing = thing;
      myMadLib.KitchenUtensil = kitchenUtensil;
      myMadLib.Name = name;
      myMadLib.Shape = shape;
      myMadLib.ClothingItem = clothingItem;
      myMadLib.Color = color;
      myMadLib.SeaCreature = seaCreature;
      return View(myMadLib);
    }
  }
}