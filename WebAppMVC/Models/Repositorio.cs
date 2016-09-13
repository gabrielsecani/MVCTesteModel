using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppMVC.Models
{
    class Repositorio
    {
        private static Repositorio _repositorio;
        private static List<Funcionario> funcionarios;

        private Repositorio()
        {
            funcionarios = new List<Funcionario>();
        }

        public static Repositorio Instance()
        {
            if (_repositorio == null)
            {
                _repositorio = new Repositorio();
            }

            return _repositorio;
        }

        public void IncluirFuncionario(Funcionario f)
        {
            funcionarios.Add(f);
        }

        public IEnumerable<Funcionario> listarFuncionarios()
        {
            return funcionarios;
        }

        public void ExcluirFuncionario(Funcionario f)
        {
            funcionarios.Remove(f);
        }
        public void AlterarFuncionario(Funcionario f)
        {
            funcionarios.Remove(f);
            funcionarios.Add(f);
        }
        public Funcionario listarFuncionariO(int codigo)
        {
            return funcionarios.FirstOrDefault(f => f.codigo == codigo);
        }
    }
}
