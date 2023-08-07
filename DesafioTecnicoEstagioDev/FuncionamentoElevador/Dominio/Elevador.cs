using Dominio.Enums;

namespace Dominio.Elevador
{
    public class Elevador
    {
        private bool[] _chegouAndar;

        private readonly int _ultimoAndar = 4;

        public int atualAndar = 1;

        public ElevadorStatus Status;


        public Elevador()
        {
            _chegouAndar = new bool[4 + 1];
            Status = ElevadorStatus.Parado;
        }

        private void Parar(int andar)
        {
            Status = ElevadorStatus.Parado;
            atualAndar = andar;
            _chegouAndar[andar] = false;
            Console.WriteLine("Parado no andar {0}", andar);
        }

        private void Descendo(int andar)
        {
            for (int i = atualAndar; i >= 1; i--)
            {
                if (_chegouAndar[i])
                    Parar(andar);
                else
                    continue;
            }

            Status = ElevadorStatus.Parado;
            Console.WriteLine("Aguardando...");
        }

        private void Subindo(int andar)
        {
            for (int i = atualAndar; i <= _ultimoAndar; i++)
            {
                if (_chegouAndar[i])
                    Parar(andar);
                else
                    continue;
            }

            Status = ElevadorStatus.Parado;
            Console.WriteLine("Aguardando...");
        }

        private void FiqueAqui()
        {
            Console.WriteLine("Esse é o andar atual");
        }

        public void AndarSelecionado(int andar)
        {
            if (andar > _ultimoAndar)
            {
                Console.WriteLine("Temos apenas {0} andar", _ultimoAndar);
                return;
            }

            _chegouAndar[andar] = true;

            switch (Status)
            {

                case ElevadorStatus.Baixo:
                    Descendo(andar);
                    break;

                case ElevadorStatus.Parado:
                    if (atualAndar < andar)
                        Subindo(andar);
                    else if (atualAndar == andar)
                        FiqueAqui();
                    else
                        Descendo(andar);
                    break;

                case ElevadorStatus.Cima:
                    Subindo(andar);
                    break;

                default:
                    break;
            }
        }
    }
}