namespace exercicio3_1112.classes
{
    public class MaquinaCafe
    {
        public int acucarDisponivel;

        public bool AcucarDaMaquina(float acucarDisponivel, float acucarCliente){

                
                if( acucarDisponivel > acucarCliente ){

                    return true;
                }

                return false;

        }

        public string FazerCafe(int acucarCliente){

            if (acucarCliente != 0)
            {
                return $"Fazendo seu cafe com {acucarCliente} gramas de açucar";
            }

            return "maquina sem açucar por favor escolha outra opção";
        }
        public string FazerCafe(){

            
            return $"Fazendo seu cafe com 10 gramas de açucar";

        }
    }
}