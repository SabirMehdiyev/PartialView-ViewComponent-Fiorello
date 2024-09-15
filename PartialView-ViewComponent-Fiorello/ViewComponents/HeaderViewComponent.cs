using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.AspNetCore.Mvc;
using PartialView_ViewComponent_Fiorello.DataAccessLayer;
using Microsoft.EntityFrameworkCore;

namespace PartialView_ViewComponent_Fiorello.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly AppDbContext _dbContext;
        public HeaderViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ViewViewComponentResult> InvokeAsync()
        {
            var header = await _dbContext.Headers.SingleOrDefaultAsync();

            return View(header);
        }
    }
}
