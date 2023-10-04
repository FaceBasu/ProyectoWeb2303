using FrontEnd.Models;

namespace FrontEnd.Helpers.Interfaces
{
    public interface IShipperHelper
    {
        List<ShipperViewModel> GetAll();
        ShipperViewModel GetById(int id);
        ShipperViewModel AddShipper(ShipperViewModel ShipperViewModel);
        ShipperViewModel EditShipper(ShipperViewModel ShipperViewModel);

        void DeleteShipper(int id);

    }
}
