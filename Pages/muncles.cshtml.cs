using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace weirdwebsite.Pages;

public class MunclesModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public MunclesModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}