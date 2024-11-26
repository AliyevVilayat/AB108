using Microsoft.EntityFrameworkCore;
using Pronia.BL.Services.Abstractions;
using Pronia.DAL.Contexts;
using Pronia.DAL.Models;

namespace Pronia.BL.Services.Concretes;

public class SliderItemService : ISliderItemService
{
    private readonly ProniaDBContext _context;

    public SliderItemService(ProniaDBContext context)
    {
        _context = context;
    }

    public async Task CreateSliderItemAsync(SliderItem sliderItem)
    {
        await _context.SliderItems.AddAsync(sliderItem);
        await _context.SaveChangesAsync();
    }

    public async Task SoftDeleteSliderItemAsync(int id)
    {
        /* SliderItem baseSliderItem = await _context.SliderItems.FindAsync(id);
         if (baseSliderItem is null)
         {
             throw new Exception($"Slider Item not found with this id({id})");
         }

         if (baseSliderItem.IsDeleted)
         {
             throw new Exception($"Slider Item not found with this id({id})");
         }*/
        /*SliderItem? baseSliderItem2 = await _context.SliderItems.FirstOrDefaultAsync(s => s.Id == id && !s.IsDeleted);*/

        SliderItem? baseSliderItem = await _context.SliderItems.SingleOrDefaultAsync(s => s.Id == id && !s.IsDeleted);
        if (baseSliderItem is null)
        {
            throw new Exception($"Slider Item not found with this id({id})");
        }

        baseSliderItem.IsDeleted = true;
        await _context.SaveChangesAsync();
    }

    public async Task HardDeleteSliderItemAsync(int id)
    {
        SliderItem? baseSliderItem = await _context.SliderItems.FindAsync(id);
        if (baseSliderItem is null)
        {
            throw new Exception($"Slider Item not found with this id({id})");
        }

        if (!baseSliderItem.IsDeleted)
        {

            throw new Exception($"Slide Item with this id{id} not Soft deleted before. ");
        }

        _context.SliderItems.Remove(baseSliderItem);
        await _context.SaveChangesAsync();
    }

    public async Task<List<SliderItem>> GetAllSliderItemsAsync()
    {
        List<SliderItem> sliderItems = await _context.SliderItems.ToListAsync();
        return sliderItems;
    }

    public SliderItem GetSliderItemById(int id)
    {
        throw new NotImplementedException();
    }

    public void UpdateSliderItem(int id, SliderItem sliderItem)
    {
        throw new NotImplementedException();
    }
}
