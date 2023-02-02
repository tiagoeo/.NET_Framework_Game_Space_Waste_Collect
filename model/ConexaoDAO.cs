using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Entidades;

namespace Model
{
    public class ConexaoDAO
    {

        private static readonly HttpClient HttpClient = new HttpClient();

        public async Task<string> ConnAsync(Dictionary<string, string> data)
        {
            var resultado = await HttpClient.PostAsync(Game.Host, new FormUrlEncodedContent(data));
            if (resultado.StatusCode != System.Net.HttpStatusCode.OK)
                throw new HttpRequestException($"{resultado.StatusCode}-{resultado.RequestMessage}");

            var retorno = await resultado.Content.ReadAsStringAsync();
            return retorno;

        }
    }
}
