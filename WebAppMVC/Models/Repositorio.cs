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

        public void ExcluirFuncionario(int id)
        {
            var func = funcionarios.Where(f => f.codigo == id).FirstOrDefault();
            funcionarios.Remove(func);
        }

        public void AlterarFuncionario(Funcionario f)
        {
            funcionarios.Where(w => w.codigo == f.codigo).
                AsParallel().
                ToList().
                ForEach(s =>
                {
                    s.nome = f.nome;
                    s.genero = f.genero;

                });
        }
        public IEnumerable<Funcionario> listarFuncionarios()
        {
            return funcionarios;
        }

        public Funcionario listarFuncionario(int codigo)
        {
            return funcionarios.FirstOrDefault(f => f.codigo == codigo);
        }
    }
}
