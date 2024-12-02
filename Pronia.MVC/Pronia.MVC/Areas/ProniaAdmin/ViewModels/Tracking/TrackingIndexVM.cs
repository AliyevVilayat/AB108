using Microsoft.EntityFrameworkCore;
using Pronia.DAL.Models;

namespace Pronia.MVC.Areas.ProniaAdmin.ViewModels;

public class TrackingIndexVM
{
    public List<SliderItem> SliderItems { get; set; }
    public List<EntityState> EntityStates { get; set; }
}
