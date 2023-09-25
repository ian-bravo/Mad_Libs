using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult index() { return View(); }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/form2")]
    public ActionResult FormTwo() { return View(); }
    
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

    [Route("/computerz2")]
    public ActionResult MadLibsFormTwo(string pluralBodyPart, string adjective, string pluralNoun2, string adjective2) 
    { 
      MadLibsVariable userInputMadLibsVariable = new MadLibsVariable();
      //properties for computerz2
      userInputMadLibsVariable.PluralBodyPart = pluralBodyPart;
      userInputMadLibsVariable.Adjective = adjective;
      userInputMadLibsVariable.PluralNoun2 = pluralNoun2;
      userInputMadLibsVariable.Adjective2 = adjective2;
      return View(userInputMadLibsVariable);
    
    }
  }
}