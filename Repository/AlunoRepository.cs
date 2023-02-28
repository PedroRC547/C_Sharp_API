using LogApi.Entities;

namespace LogApi.Repository
{
    public class AlunoRepository
    {
        public static List<Aluno> BancoDeDados { get; set; } = new List<Aluno>();

        public void Carga()
        {
            Aluno aluno1 = new Aluno(1, "Pedro", "Matriculado", 0001);
            Aluno aluno2 = new Aluno(2, "Pedro", "Matriculado", 0002);
            Aluno aluno3 = new Aluno(3, "Pedro", "Matriculado", 0003);
            Aluno aluno4 = new Aluno(4, "Pedro", "Matriculado", 0004);


            BancoDeDados.Add(aluno1);
            BancoDeDados.Add(aluno2);
            BancoDeDados.Add(aluno3);
            BancoDeDados.Add(aluno4);
        }
    }
}
