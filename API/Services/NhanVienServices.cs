using API.Data;
using API.IRepositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public class NhanVienServices:INhanVien
    {
        private readonly LaundyContext _context;

        public NhanVienServices(LaundyContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateNhanVien(NhanVien nhanVien)
        {
            try
            {
                await _context.AddAsync(nhanVien);
                await _context.SaveChangesAsync();
                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }

        public Task<bool> DeleteNhanVien(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditNhanVien(NhanVien nhanVien)
        {
            throw new NotImplementedException();
        }

        public async Task<List<NhanVien>> GetNhanViens()
        {
            return await _context.NhanViens.ToListAsync();
        }
    }
}
