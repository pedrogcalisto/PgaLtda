using PGALtda.Models.DTOs;

namespace PGALtda.Models.Factory
{
    public class RelatorioFactory
    {
        public RelatorioDto GerarRelatorio(int tipo)
        {
            switch (tipo) 
            {
                case 0:
                    return new RelatorioAdmissaoDto();
                case 1:
                    return new RelatorioDemissaoDto();

            }
            throw new System.ArgumentException("Tipo Relatorio invalido não encontrada");
        }
    }
}
