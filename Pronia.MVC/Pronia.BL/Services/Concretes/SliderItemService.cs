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

    #region Create

    public async Task CreateSliderItemAsync(SliderItem sliderItem)
    {
        await _context.SliderItems.AddAsync(sliderItem);
        int rows = await _context.SaveChangesAsync();
        if (rows != 1)
        {

            throw new Exception("Something went wrong in creating process");
        }
    }
    #endregion

    #region Read
    public async Task<SliderItem> GetSliderItemByIdAsync(int id)
    {
        SliderItem? sliderItem = await _context.SliderItems.FindAsync(id);
        if (sliderItem is null)
        {
            throw new Exception($"Slider item not found with this id({id})");
        }

        return sliderItem;
    }

    public async Task<List<SliderItem>> GetAllSliderItemsAsync()
    {
        List<SliderItem> sliderItems = await _context.SliderItems.ToListAsync();
        return sliderItems;
    }
    #endregion

    #region Update
    public async Task UpdateSliderItemAsync(int id, SliderItem sliderItem)
    {
        if (id != sliderItem.Id)
        {
            throw new Exception("Slider Items' ids are not same");
        }
        SliderItem? baseSliderItem = await _context.SliderItems.AsNoTracking().SingleOrDefaultAsync(s => s.Id == id && !s.IsDeleted);
        if (baseSliderItem is null)
        {
            throw new Exception($"Slider Item not found with this id({id})");
        }

        baseSliderItem.Title = sliderItem.Title;
        baseSliderItem.ShortDescription = sliderItem.ShortDescription;
        baseSliderItem.Offer = sliderItem.Offer;
        baseSliderItem.ImgPath = sliderItem.ImgPath;
        baseSliderItem.LastModifiedDate = DateTime.Now;

        _context.SliderItems.Update(baseSliderItem);
        await _context.SaveChangesAsync();
    }


    public async Task RecoverySliderItemAsync(int id)
    {
        SliderItem? baseSliderItem = await _context.SliderItems.SingleOrDefaultAsync(s => s.Id == id && s.IsDeleted);
        if (baseSliderItem is null)
        {
            throw new Exception($"Slider Item not found with this id({id})");
        }

        baseSliderItem.IsDeleted = false;
        baseSliderItem.LastModifiedDate = DateTime.Now;
        baseSliderItem.DeletedDate = null;

        int rows = await _context.SaveChangesAsync();
        if (rows != 1)
        {
            throw new Exception("Something went wrong in update process");
        }

    }


    #endregion

    #region Delete
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
        baseSliderItem.LastModifiedDate = DateTime.Now;
        baseSliderItem.DeletedDate = DateTime.Now;
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

    #endregion




}
