using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cerberus.Extensions
{

    public static class PageExtensions
    {
        public static ObjectResult Ok<ttype>(this PageModel page, ttype body) where ttype : class
        {
            return new ObjectResult(body) { StatusCode = 200 };
        }
    }
}