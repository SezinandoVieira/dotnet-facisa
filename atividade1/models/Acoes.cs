namespace dotnet.models {
    public class Acoes {

        public int id {get;}
        public string empresa {get; }

        public Acoes (int id, string empresa){
            
            this.id = id;
            this.empresa = empresa;
        }

        public override string ToString(){
            return $"Código da empresa: {this.id} Nome da empresa: {this.empresa}";
        }

    }
}