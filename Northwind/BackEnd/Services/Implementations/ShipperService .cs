using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
    public class ShipperService : IShipperService
    {

        public IUnidadDeTrabajo _unidadDeTrabajo;

        public ShipperService(IUnidadDeTrabajo unidadDeTrabajo)
        {
                _unidadDeTrabajo = unidadDeTrabajo;
        }

        public bool AddShipper(Shipper Shipper)
        {
            bool resultado =_unidadDeTrabajo._shipperDAL.Add(Shipper);
            _unidadDeTrabajo.Complete();

            return resultado;

        }

        public bool DeteleShipper(Shipper Shipper)
        {
            bool resultado = _unidadDeTrabajo._shipperDAL.Remove(Shipper);
            _unidadDeTrabajo.Complete();

            return resultado;
        }

        public Shipper GetById(int id)
        {
            Shipper Shipper;
            Shipper =  _unidadDeTrabajo._shipperDAL.Get(id);
            return Shipper;
        }

        public async Task<IEnumerable<Shipper>> GetCategoriesAsync()
        {
            IEnumerable<Shipper> categories;
            categories = await _unidadDeTrabajo._shipperDAL.GetAll();
            return categories;
        }

        public bool UpdateShipper(Shipper Shipper)
        {
            bool resultado = _unidadDeTrabajo._shipperDAL.Update(Shipper);
            _unidadDeTrabajo.Complete();

            return resultado;
        }
    }
}
