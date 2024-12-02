using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronia.DAL.Contexts;
using Pronia.DAL.Models;
using Pronia.MVC.Areas.ProniaAdmin.ViewModels;

namespace Pronia.MVC.Areas.ProniaAdmin.Controllers;

[Area("ProniaAdmin")]
public class TrackingController : Controller
{
    private readonly ProniaDBContext _dbContext;

    public TrackingController(ProniaDBContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IActionResult Index()
    {

        List<SliderItem> sliderItems = _dbContext.SliderItems.ToList();
        List<EntityState> states = new List<EntityState>();
        foreach (SliderItem sliderItem in sliderItems)
        {
            if (sliderItem.Id % 2 != 0)
            {
                _dbContext.Entry(sliderItem).State = EntityState.Deleted;
                //_dbContext.SliderItems.Remove(sliderItem);

            }


            _dbContext.SaveChanges();

            states.Add(_dbContext.Entry(sliderItem).State);
        }

        TrackingIndexVM trackingIndexVM = new TrackingIndexVM()
        {
            SliderItems = sliderItems,
            EntityStates = states
        };

        return View(trackingIndexVM);
    }
}




#region Entity State

// Obyektin vəziyəti, mərhələsi.

//Detached - Change Tracker mexanizmi tərəfindən izlənilməyən Entity obyektlərin state-i default olaraq Detached olur.

//Added - Əgər mən CSharp obyekti olaraq Entity obyekt yaratmışamsa? default olaraq bu Entity obyekt Change Tracker mexanizmi tərəfindən izlənilməyəcək. Add metodu ilə biz bu obyektin Change Tracker mexanizmi tərəfindən izlənilməsini təmin edirik. State-i Added olaraq dəyişir, Save Change metod vasitəsi ilə də data database-ə əlavə edilir. Save Change metodu işə düşdükdən sonra State-i Unchanged olaraq dəyişir.

//Unchanged - Change Tracker mexanizmi tərəfindən izlənilən Entity obyektlərin üzərində heç bir dəyişiklik icra edilməyibsə state-i default olaraq Unchanged.

//Modified - Change Tracker mexanizmi tərəfindən izlənilən Entity obyektlərin üzərində hər hansısa bir dəyişiklik olarsa state-i dəyişərək Modified olur. Və SaveChange method vasitəsi ilə biz obyekt üzərində olan dəyişikliyi Database-ə yansıda bilərik. Update metodu yazmağa ehtiyyac yoxdur.

//Deleted - Change Tracker mexanizmi tərəfindən izlənilən Entity obyektlərin Remove metodu vasitəsi ilə silinməsi nəticəsində onun State-i Deleted olaraq dəyişir. Save Change method işə düşdükdən sonra bu data database-dən silindiyi üçün izlənilə bilmir. Bu səbəbdən də Save Change metoddan sonra State-i Detached olaraq dəyişir.

// Add, Update və Remove metodları State-i dəyişmək və Context obyektinə bu prosesin icra edildiyini bildirmək üçündür. Dəyişikliyin database-ə yansıması üçün mütləq SaveChange metodu işə düşməlidir.


#endregion
