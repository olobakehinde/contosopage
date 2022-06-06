using System.Text.Json;

namespace contoso.Models
{
    public class prod
    {
        public string id { get; set;}
        public string image{ get; set;}
        public string maker { get; set; }
        public string tittle{ get; set; }
        public string description  { get; set; }
        public override string ToString() => JsonSerializer.Serialize<prod>(this);
    }

}

