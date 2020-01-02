using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace snookerSite.Pages
{
  public class LiveScoresModel : PageModel
  {
    private readonly ILogger<LiveScoresModel> _logger;

    public LiveScoresModel(ILogger<LiveScoresModel> logger)
    {
      _logger = logger;
    }

    public void OnGet()
    {

    }
  }
}
