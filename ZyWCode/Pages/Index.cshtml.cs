using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UtilityLibrary;

namespace ZyWCode.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        //Dependency Injection out of the box!
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string emailText, string noNoWords)
        {
            //Just for fun. Didn't build a UI for it, but could.
            KeyValuePair<bool, string> test = TextExaminer.ExamineClassifiedString(emailText, noNoWords);
        }
    }
}