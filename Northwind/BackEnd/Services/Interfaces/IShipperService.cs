using Entities.Entities;

namespace BackEnd.Services.Interfaces
{
    public interface IShipperService
    {
        Task<IEnumerable<Shipper>> GetCategoriesAsync();
        Shipper GetById(int id);
        bool AddShipper(Shipper Shipper);
        bool UpdateShipper(Shipper Shipper);
        bool DeteleShipper(Shipper Shipper);


    }
}
