using Domain.Entities;

namespace API.IRepositories
{
    public interface INhanVien
    {
        public Task<List<NhanVien>> GetNhanViens();
        public Task<bool> EditNhanVien(NhanVien nhanVien);
        public Task<bool> CreateNhanVien(NhanVien nhanVien);
        public Task<bool> DeleteNhanVien(int id);

    }
}
