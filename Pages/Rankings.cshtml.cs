using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace snookerSite.Pages
{
  public class RankingsModel : PageModel
  {
    private readonly ILogger<RankingsModel> _logger;

    public RankingsModel(ILogger<RankingsModel> logger)
    {
      _logger = logger;
    }

    public void OnGet()
    {

    }
  }
}