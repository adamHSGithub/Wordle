using Microsoft.AspNetCore.Mvc;

namespace WordleList.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WordleController : ControllerBase
    {
        public static String WordleWord;

        [Route("WordleWord")]
        [HttpGet]
        public String WordleWordGet()
        {
            //WordleWord = "wordy";
            return WordleWord;
        }

        [Route("WordleWord")]
        [HttpPost]
        public void helloWorldPost(String name)
        {
            WordleWord = name;
        }
    }
}
