using ServicesRest.Application.Abstract;
using ServicesRest.Application.Dto;
using ServicesRest.Domain.Abstract;
using ServicesRest.Domain.Entity;

namespace ServicesRest.Application.Service
{
    public class RecruitmentService(IRecruitmentRepository recruitmentRepository) : IRecruitmentService
    {
        private readonly IRecruitmentRepository _recruitmentRepository = recruitmentRepository;

        public async Task AddPrueba(PruebaDto pruebaDto)
        {
            Prueba prueba = new()
            {
                Name = pruebaDto.Name,
                TipoDocumento = pruebaDto.TipoDocumento,
                FechaNacimiento = pruebaDto.FechaNacimiento,
                ValorGanar = pruebaDto.ValorGanar,
                EstadoCivil = pruebaDto.EstadoCivil
            };


            try
            {
                await _recruitmentRepository.Add(prueba);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<PruebaDto>> GetPrueba()
        {
            try
            {
                IEnumerable<Prueba> pruebas = await _recruitmentRepository.Get();

                IList<PruebaDto> pruebasDto = [];

                foreach (Prueba p in pruebas) 
                {
                    PruebaDto pruebaDto = new()
                    {
                        Name = p.Name,
                        TipoDocumento = p.TipoDocumento,
                        FechaNacimiento = p.FechaNacimiento,
                        ValorGanar = p.ValorGanar,
                        EstadoCivil = p.EstadoCivil,
                    };

                    pruebasDto.Add(pruebaDto);
                }

                return pruebasDto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
