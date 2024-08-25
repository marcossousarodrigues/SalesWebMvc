using SalesWebMvc.Data;
using SalesWebMvc.Models;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Services.Exceptions;

namespace SalesWebMvc.Services
{
    public class SellerServices
    {

        private readonly SalesWebMvcContext _context;
        public SellerServices(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindById(int id) { 
        
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(Obj  => Obj.Id == id);
        }

        public void Remove(int id)
        {
            try
            {
                var obj = _context.Seller.Find(id);
                _context.Remove(obj);

                _context.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException(e.Message);
            }
           

        }

        public void Update(Seller obj)
        {
            if(!_context.Seller.Any( x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id not Founf"); 
            }
            try
            {
                _context.Update(obj);
                _context.SaveChanges();

            }
            catch(DbConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }

        }


    }
}
