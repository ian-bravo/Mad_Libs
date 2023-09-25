using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {

    // [Route("/")]
    // public string Hello() { return "Hello friend!"; }

    [Route("/form")]
    public ActionResult Form() { return View(); }
    
    [Route("/computerz")]
    public ActionResult MadLibsForm(string noun, string pluralNoun, string verbPresentTense, string verbPastTense) 
    { 
      MadLibsVariable userInputMadLibsVariable = new MadLibsVariable();
      //properties for computerz
      userInputMadLibsVariable.Noun = noun;
      userInputMadLibsVariable.PluralNoun = pluralNoun;
      userInputMadLibsVariable.VerbPresentTense = verbPresentTense;
      userInputMadLibsVariable.VerbPastTense = verbPastTense;
      return View(userInputMadLibsVariable);
    
    }
    
  }
}