using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor9_EF.Pages;

public class IndexModel : PageModel
{
    public string abc{set; get;} = "ok con dê";
    public List<Article> posts{set; get;}
    private readonly ILogger<IndexModel> _logger;
    private readonly MyBlogContext _myBlogContext;
    public IndexModel(ILogger<IndexModel> logger, MyBlogContext myBlog)
    {
        _logger = logger;
        _myBlogContext = myBlog;
    }

    public void OnGet()
    {
        posts = (from a in _myBlogContext.articles orderby a.Created descending  select  a).ToList();

    }
}
