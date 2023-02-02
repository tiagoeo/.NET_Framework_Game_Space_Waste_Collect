using System.Collections.Generic;
using System.Threading.Tasks;
using Model;
using Newtonsoft.Json;
using Entidades;
using System;
using System.Linq;

namespace Controller
{
    public class ConexaoVO
    {
        ConexaoDAO novoAsync = new ConexaoDAO();

        public async Task<Usuario> Login(Dictionary<string, string> data)
        {
            try
            {
                data.Add("appLogin", Game.IdGame);

                var jsonString = await novoAsync.ConnAsync(data);

                var valueJSON = JsonConvert.DeserializeObject<Usuario>(jsonString.ToString());

                return valueJSON;
            }
            catch (Exception ex)
            {
                Usuario excep = new Usuario();
                excep.Excecoes = ex.ToString();
                return excep;
            }
        }

        public async Task<Usuario> BuscaPontos(Dictionary<string, string> data)
        {
            try
            {
                data.Add("buscaAppLogin", Game.IdGame);

                var jsonString = await novoAsync.ConnAsync(data);
                var valueJSON = JsonConvert.DeserializeObject<Usuario>(jsonString.ToString());
                return valueJSON;
            }
            catch (Exception ex)
            {
                Usuario excep = new Usuario();
                excep.Excecoes = ex.ToString();
                return excep;
            }
        }

        public async Task<SituacaoAsync> Vinculo(Dictionary<string, string> data)
        {
            try
            {
                data.Add("uidgamevincular", Game.IdGame);

                var jsonString = await novoAsync.ConnAsync(data);

                var valueJSON = JsonConvert.DeserializeObject<SituacaoAsync>(jsonString.ToString());

                return valueJSON;
            }
            catch (Exception ex)
            {
                SituacaoAsync excep = new SituacaoAsync();
                excep.Excecoes = ex.ToString();

                return excep;
            }
        }
        public async Task<SituacaoAsync> AtualizarPontos(Dictionary<string, string> data)
        {
            try
            {
                data.Add("uidgameatualizar", Game.IdGame);

                var jsonString = await novoAsync.ConnAsync(data);

                var valueJSON = JsonConvert.DeserializeObject<SituacaoAsync>(jsonString.ToString());

                return valueJSON;
            }
            catch (Exception ex)
            {
                SituacaoAsync excep = new SituacaoAsync();
                excep.Excecoes = ex.ToString();

                return excep;
            }
        }
    }
}
