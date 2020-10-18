using Enco.Core.Models;
using Enco.Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Enco.Infrastructure.Repositories
{
    public class TeamRepository : IRepository<Team>
    {
        private readonly TeamsContext _dbContext;

        public TeamRepository(TeamsContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task AddAsync(Team entity)
        {
            _dbContext.Teams.Add(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Team entity)
        {
            _dbContext.Teams.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task EditAsync(Team entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public Team GetById(int? id)
        {
            return _dbContext.Teams.FirstOrDefault(t => t.Id == id);
        }

        public async Task<Team> GetByIdAsync(int? id)
        {
            return await _dbContext.Teams.FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<List<Team>> ListAsync()
        {
            return await _dbContext.Teams.ToListAsync();
        }

        public async Task<List<Team>> ListAsync(Expression<Func<Team, bool>> predicate)
        {
            return await _dbContext.Teams.Where(predicate).ToListAsync();
        }
    }
}
