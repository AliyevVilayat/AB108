using Pronia.DAL.Models;

namespace Pronia.BL.Services.Abstractions;

public interface ISliderItemService
{

    Task<List<SliderItem>> GetAllSliderItemsAsync();
}
