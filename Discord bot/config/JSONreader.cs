using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

    

namespace Discord_bot.config
{
    public class JSONreader
    {
        public string token { get; set; }

        public string prefix { get; set; }
   
        public async Task ReadJSON()
        {
            using (StreamReader sr = new StreamReader("config.json"))
            {
                string json = await sr.ReadToEndAsync();
                JSONstructure data = JsonConvert.DeserializeObject<JSONstructure>(json);

                this.token = data.token;
                this.prefix = data.prefix;
            }
        }
    }

    internal sealed class JSONstructure
    {
        public string token { get; set; }
        public string prefix { get; set; }
    }
}
