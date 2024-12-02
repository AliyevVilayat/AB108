using Pronia.DAL.Models;

namespace Pronia.BL.Services.Abstractions;

public interface ISliderItemService
{

    Task<SliderItem> GetSliderItemByIdAsync(int id);
    Task<List<SliderItem>> GetAllSliderItemsAsync();

    Task CreateSliderItemAsync(SliderItem sliderItem);
    Task UpdateSliderItemAsync(int id, SliderItem sliderItem);
    Task HardDeleteSliderItemAsync(int id);
    Task SoftDeleteSliderItemAsync(int id);

    Task RecoverySliderItemAsync(int id);
}
