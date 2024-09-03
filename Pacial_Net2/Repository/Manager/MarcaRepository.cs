using Pacial_Net2.Data;
using Pacial_Net2.Models;
using Pacial_Net2.Repository.Interface;

namespace Pacial_Net2.Repository.Manager
{
    public class MarcaRepository : IMarcaRepository
    {
        private readonly ApplicationDbContext _context;
        public MarcaRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Marca AddMarca(Marca marca)
        {
            _context.Add(marca);
            _context.SaveChanges();
            return marca;

            throw new NotImplementedException();
        }

        public void DeleteMarca(int id)
        {
            var marca = _context.marcas.Find(id);

            if(marca != null)
            {
                _context.Remove(marca);
                _context.SaveChanges();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public List<Marca> GetMarca()
        {
            return _context.marcas.ToList();

            throw new NotImplementedException();
        }

        public Marca EditMarca(int id)
        {
            return _context.marcas.Where(m => m.Id == id).FirstOrDefault();
            throw new NotImplementedException();
        }

        public Marca UpdateMarca(Marca marca)
        {
            var marcas = _context.marcas.Where(m => m.Id == marca.Id).FirstOrDefault();

            marcas.nombre = marca.nombre;

            _context.Update(marcas);
            _context.SaveChanges(true);

            return marcas;

            throw new NotImplementedException();
        }
    }
}
