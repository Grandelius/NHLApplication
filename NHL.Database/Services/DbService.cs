using AutoMapper;
using NHL.Database.Contexts;
using NHL.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHL.Database.Services
{
    public class DbService : IDbService
    {
        private readonly IMapper _mapper;
        private readonly NHLDbContext _db;

        public DbService(IMapper mapper, NHLDbContext db)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<TEntity> AddAsync<TEntity, TDto>(TDto dto)
            where TEntity : class
            where TDto : class
        {
            var entity = _mapper.Map<TEntity>(dto);
            await _db.Set<TEntity>().AddAsync(entity);
            return entity;
        }

        public async Task<bool> SaveChangesAsync() =>
            await _db.SaveChangesAsync() >= 0;

    }
}
