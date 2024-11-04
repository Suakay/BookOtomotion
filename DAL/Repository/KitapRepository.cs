using DAL.Abstract;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class KitapRepository : BaseRepository<Kitap>
    {
        DbSet<Kitap> Kitaplar;

        public List<Kitap> GetAll()
        {
            return _dbContext.Kitaplar.ToList();
        }
    }
}
