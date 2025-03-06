using Microsoft.EntityFrameworkCore;
using ServicesRest.Domain.Abstract;
using ServicesRest.Domain.Entity;
using ServicesRest.Infrastructure.DataAccess;

namespace ServicesRest.Infrastructure.Repository
{
    public class RecruitmentRepository(EfectyContext efectyContext) : IRecruitmentRepository
    {
        private readonly EfectyContext _efectyContext = efectyContext;

        public async Task Add(Prueba prueba)
        {
            _efectyContext.Pruebas.Add(prueba);
            await _efectyContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Prueba>> Get() => await _efectyContext.Pruebas.OrderBy(p => p.Id).ToListAsync();

    }
}
