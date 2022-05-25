using Microsoft.AspNetCore.Mvc;

namespace TestCoreAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WordleController : Controller
    {
        [HttpGet(Name = "Wordle")]
        public String wordleWord(string test)
        {
            String result;

            if (test == "test")
                result = "wordy";
            else
            {
                List<string> lines = System.IO.File.ReadLines("C:\\repos\\Wordle\\WordleGame\\WordleGame\\WordList").ToList();
                Random rnd = new Random();
                int index = rnd.Next(1, lines.Count);

                result = lines[index];
            }
                
            return result;
        }
    }
}
