using Microsoft.AspNetCore.Mvc;
using MadLib.Models;

namespace MadLib.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Form() { return View(); }
    
    [Route("/formpuppy")]
    public ActionResult FormPuppy() { return View(); }

    [Route("/madlib")]
    public ActionResult MadLib(string location, string tool, string pastVerb, string profession, string pastVerb2, string adjective, string creature, string pastVerb3)
    {
      MadLibVariable myMadLibVariable = new MadLibVariable();
      myMadLibVariable.Location = location;
      myMadLibVariable.Tool = tool;
      myMadLibVariable.PastVerb = pastVerb;
      myMadLibVariable.Profession = profession;
      myMadLibVariable.PastVerb2 = pastVerb2;
      myMadLibVariable.Adjective = adjective;
      myMadLibVariable.Creature = creature;
      myMadLibVariable.PastVerb3 = pastVerb3;
      return View(myMadLibVariable);
    }

    [Route("/puppy")]
    public ActionResult Puppy(string color, string name, string pastVerb, string adjective, string dinosaur)
    {
      PuppyVariable myPuppyVariable = new PuppyVariable();
      myPuppyVariable.Color = color;
      myPuppyVariable.Name = name;
      myPuppyVariable.PastVerb = pastVerb;
      myPuppyVariable.Adjective = adjective;
      myPuppyVariable.Dinosaur = dinosaur;
      return View(myPuppyVariable);
    }

  }
}