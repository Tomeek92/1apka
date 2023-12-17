namespace PierwszaApka.Models
{
    public class About
    {
        public int JakasLiczba { get; set; }
        public string? Tittle { get; set; }

       public List<string> Tags { get; set;} = new List<string>();
    }
}
