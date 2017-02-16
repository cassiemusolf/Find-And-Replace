// using Nancy;
// using System;
// using System.Collections.Generic;
// using FindAndReplaceApp.Objects;
//
// namespace FindAndReplaceApp
// {
//   public class HomeModule : NancyModule
//   {
//     public HomeModule()
//     {
//       Get["/"] = _ => {
//         return View["index.cshtml"];
//       };
//
//       Post["/output"] = _ => {
//         FindString newFind = new Find();
//         string newOutput = Request.Form["user-string"].Replace(Request.Form["word-to-replace"], Request.Form["replacement-word"]);
//         return View["output.cshtml", newOutput];
//       };
//     }
//   }
// }
