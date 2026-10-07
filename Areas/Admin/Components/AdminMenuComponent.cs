using aznew.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
namespace aznews.Areas.Admin.Components
{
    [ViewComponent(Name ="AdminMenu")]
    public class AdminMenuComponent : ViewComponent
    {
        private readonly DataContext _Context ;
        public AdminMenuComponent(DataContext context)
        {
            _Context= context;

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var mnList = (from mn in _Context .AdminMenus
            where (mn.IsActive == true )
            select mn).ToList();
            return await Task .FromResult((IViewComponentResult)View("Default",mnList));
        }

    }
}