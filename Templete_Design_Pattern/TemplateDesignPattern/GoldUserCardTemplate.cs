using System.Text;

namespace Templete_Design_Pattern.TemplateDesignPattern
{
    public class GoldUserCardTemplate : UserCardTemplate
    {
        protected override string SetFooter()
        {
            var sb = new StringBuilder();
            sb.Append("<a href='#'class='card-link'>profili gör</a>");
            sb.Append("<a href='#'class='card-link'>mesaj gönder</a>");
            return sb.ToString();
        }

        protected override string SetImage()
        {
            return $"<img class='car-img-top' src='{AppUser.Image}' style='width:50px; height:50px;'>";
        }
    }
}
