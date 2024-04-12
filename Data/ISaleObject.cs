using FribergHomez.Models;

namespace FribergHomez.Data
{
    //Henrik
    public interface ISaleObject
    {
        Task<List<SaleObject>> GetAllSalesObjectsAsync();
        Task GetSalesObjectByIdAsync(int id);
        Task AddSalesObjectAsync(SaleObject saleobject);
        Task DeleteSalesObjectAsync(int id);
        Task UpdateSalesObjectAsync(SaleObject saleobject);
    }
}
