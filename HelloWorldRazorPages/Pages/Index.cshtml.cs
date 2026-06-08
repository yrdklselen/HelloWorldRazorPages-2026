using HelloWorldRazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloWorldRazorPages.Pages
{
    public class IndexModel : PageModel //inheritance
    {
        [BindProperty]
        public AppMessage Heading { get; set; }// AppMessage bir data type dir.
        public string SubHeading { get; set; }
        public void OnGet() //sayfa ilk açıldığında çalışır MVC deki GET index gibi düşünülebilir
        {
            this.Heading = new AppMessage();//Burdaki heading bu appmessage sınfından oluşturulmuş bir nesnedir.yani türü bir classtır.
            this.Heading.Message = "Hello World!";
        }
        public void OnPost()
        {
            this.SubHeading = "Message changed.";//buradaki this,içinde bulunduğumuz nesneyi temsil eder.Yani indexmodel classını
        }
    }
}
