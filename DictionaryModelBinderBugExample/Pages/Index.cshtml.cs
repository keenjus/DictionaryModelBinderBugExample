using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace DictionaryModelBinderBugExample.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }

        public IActionResult OnPost(Dictionary<string, TestViewModel> data)
        {
            if (data == null || data.Count == 0)
            {
                return null;
            }

            return new JsonResult(new
            {
                data = data,
                form = Request.Form
            });
        }
    }

    public class TestViewModel
    {
        public string SomeValue { get; set; }
    }
}
