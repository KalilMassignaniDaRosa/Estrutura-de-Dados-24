using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_01
{
    public class TipoEnumerador
    {
        public enum Language{
            //por serem especificações de valores não tem ;
            PTBR, EN, RU
        }

        public Language _language = Language.PTBR;

        public TipoEnumerador(){
            
        }

        /*
        Apenas Exemplo
        public TipoEnumerador(TipoEnumerador enum){
            _language = enum;  
        }
        */

        public Language GetLanguageEnum(string lang){
            switch(lang.ToLower()){
                case "português":
                    return Language.PTBR;
                case "inglês":
                    return Language.EN;
                case "russo":
                    return Language.RU;
                default:
                    return Language.PTBR;
            }
        }
    }
}