using Microsoft.AspNetCore.Mvc;
using Calculator.Models;

namespace Calculator.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Home() { return View(); }
    
    [Route("/form-add")]
    public ActionResult FormAdd() { return View(); }

    [Route("/form-sub")]
    public ActionResult FormSub() { return View(); }

    [Route("/add")]
    public ActionResult Add(float add1, float add2)
    {
      AddVariable myAddVariable = new AddVariable();
      myAddVariable.Add1 = add1;
      myAddVariable.Add2 = add2;
      myAddVariable.AddResult = myAddVariable.Add1 + myAddVariable.Add2;
      return View(myAddVariable);
    }

    [Route("/sub")]
    public ActionResult Sub(float sub1, float sub2)
    {
      SubVariable mySubVariable = new SubVariable();
      mySubVariable.Sub1 = sub1;
      mySubVariable.Sub2 = sub2;
      mySubVariable.SubResult = mySubVariable.Sub1 - mySubVariable.Sub2;
      return View(mySubVariable);
    }

  }
}