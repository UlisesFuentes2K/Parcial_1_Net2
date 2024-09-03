using Pacial_Net2.Models;

namespace Pacial_Net2.Repository.Interface
{
    public interface IMarcaRepository
    {
        Marca AddMarca(Marca marca);
        Marca UpdateMarca(Marca marca);
        Marca DeleteMarca(int id);
        void ConfirmedDeleteMarca(Marca marca);
        Marca EditMarca(int id);
        List<Marca> GetMarca();
    }
}
