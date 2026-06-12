using ClubeDaLeitura.ConsoleApp.Compartilhado;
using ClubeDaLeitura.ConsoleApp.ModuloAmigo;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;
using ClubeDaLeitura.ConsoleApp.Utilidades;

namespace ClubeDaLeitura.ConsoleApp.ModuloEmprestimo;

public enum StatusEmprestimo
{
    Aberto,
    Concluido,
    Atrasado
}

/*
    ● Campos obrigatórios:
        ○ Amigo
        ○ Revista (disponível no momento)
        ○ Data empréstimo (automática)
        ○ Data devolução (calculada conforme caixa)
        ● Status possíveis: Aberto / Concluído / Atrasado
*/
public class Emprestimo : EntidadeBase
{
    public Revista Revista { get; private set; }
    public Amigo Amigo { get; private set; }
    public StatusEmprestimo Status { get; set; }
    public DateTime DataAbertura { get; private set; }
    public DateTime DataConclusaoPrevista
    {
        get
        {
            int diasDeEmprestimo = Revista.Caixa.DiasDeEmprestimo;

            // (data de abertura + dias da caixa)
            DateTime dataConclusaoPrevista = DataAbertura.AddDays(diasDeEmprestimo);

            return dataConclusaoPrevista;
        }
    }

    public Emprestimo(Revista revista, Amigo amigo)
    {
        Id = GeradorIds.ObterIdEmprestimo();
        DataAbertura = DateTime.Now;
        Status = StatusEmprestimo.Aberto;

        Revista = revista;
        Amigo = amigo;
    }

    public override void Atualizar(EntidadeBase entidadeAtualizada)
    {
        Emprestimo emprestimoAtualizado = (Emprestimo)entidadeAtualizada;

        Status = emprestimoAtualizado.Status;
    }
}
